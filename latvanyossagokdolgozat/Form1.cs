using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace latvanyossagokdolgozat
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();

            conn = new MySqlConnection("Server = localhost;" +
                "Database = latvanyossagokdb;" +
                "Uid = root;" +
                "Pwd = ;");
            conn.Open();

            this.FormClosed += (sender, args) =>
            {
                if (conn != null)
                {
                    conn.Close();
                }
            };
            AdatBetoltesVaros();
        }

        private void AdatBetoltesVaros()
        {
            string sql = @"
                SELECT nev, lakossag
                FROM varosok
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nev = reader.GetString("nev");
                    int lakossag = reader.GetInt32("lakossag");
                    Varos v = new Varos(nev, lakossag);
                    lbox_varosok.Items.Add(v);
                }
            }
        }

        private void varosListaReset()
        {
            lbox_varosok.Items.Clear();
            AdatBetoltesVaros();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_hozzaad_Click(object sender, EventArgs e)
        {
            if (txtbx_varosneve.Text.Length>0 && numupd_varoslakossag.Value>0)
            {
                string nev = txtbx_varosneve.Text;
                int lakossag = Convert.ToInt32(numupd_varoslakossag.Value);
                var insertComm = conn.CreateCommand();
                insertComm.CommandText = @"
                            INSERT INTO varosok (nev,lakossag)
                            VALUES(@nev,@lakossag)
                        ";
                insertComm.Parameters.AddWithValue("@nev", nev);
                insertComm.Parameters.AddWithValue("@lakossag", lakossag);
                insertComm.ExecuteNonQuery();
                Varos v = new Varos(nev,lakossag);
                lbox_varosok.Items.Add(v);
                varosListaReset();
            }
            else
            {
                MessageBox.Show("Hiba! Nem megfelelő értékek","Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void lbox_varosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbox_varoslatvanyossagai.Items.Clear();
            Varos v = (Varos)lbox_varosok.SelectedItem;
            int id = getId(v);

            string sql = @"
                SELECT nev, leiras, ar, varos_id
                FROM latvanyossagok
                WHERE varos_id=@id
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@id",id);
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nev = reader.GetString("nev");
                    string leairas = reader.GetString("leiras");
                    int ar = reader.GetInt32("ar");
                    int varosid = reader.GetInt32("varos_id");
                    Latvanyossag l = new Latvanyossag(nev,leairas,ar,varosid);
                    lbox_varoslatvanyossagai.Items.Add(l);
                    
                }
            }

            string tboxbanev = v.Nev;
            txtbx_varosneve.Text = Convert.ToString(tboxbanev);
            int tboxbalakossag = v.Lakossag;
            numupd_varoslakossag.Value = tboxbalakossag;
        }

        private int getId(Varos v)
        {
            string keresettNev = v.Nev;
            int id=0;
            string sql = @"
                SELECT id
                FROM varosok
                WHERE nev LIKE @keresettNev
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@keresettnev",keresettNev);
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    id = reader.GetInt32("id");
                }
            }
            return id;
        }

        private void btn_latvanyossaghozzaad_Click(object sender, EventArgs e)
        {
            if (txtbx_latvanyossagneve.Text.Length>0 && rtbox_latvanyossagleiras.Text.Length>0 && numupd_latvanyossagara.Value>0 && lbox_varosok.SelectedIndex>-1)
            {
                string nev = txtbx_latvanyossagneve.Text;
                string leiras = rtbox_latvanyossagleiras.Text;
                int ar = Convert.ToInt32(numupd_latvanyossagara.Value);
                Varos v = (Varos)lbox_varosok.SelectedItem;
                int varosid= getId(v);


                var insertComm = conn.CreateCommand();
                insertComm.CommandText = @"
                            INSERT INTO latvanyossagok (nev,leiras,ar,varos_id)
                            VALUES(@nev,@leiras,@ar,@varos_id)
                        ";
                insertComm.Parameters.AddWithValue("@nev", nev);
                insertComm.Parameters.AddWithValue("@leiras", leiras);
                insertComm.Parameters.AddWithValue("@ar", ar);
                insertComm.Parameters.AddWithValue("@varos_id", varosid);
                insertComm.ExecuteNonQuery();
                Latvanyossag l = new Latvanyossag(nev, leiras, ar, varosid);
                v.setLavanyossagok(l);
                
            }
            else
            {
                MessageBox.Show("Hiba! Nem megfelelő értékek", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modosit_Click(object sender, EventArgs e)
        {
            if (lbox_varosok.SelectedIndex > -1)
            {
                Varos v = (Varos)lbox_varosok.SelectedItem;
                string nev = txtbx_varosneve.Text;
                int lakossag = (int)numupd_varoslakossag.Value;
                int id = getId(v);
                var updateComm = conn.CreateCommand();
                updateComm.CommandText = @"
                            UPDATE varosok SET nev=@nev, lakossag=@lakossag
                            WHERE id=@id
                        ";
                updateComm.Parameters.AddWithValue("@id", id);
                updateComm.Parameters.AddWithValue("@nev", nev);
                updateComm.Parameters.AddWithValue("@lakossag", lakossag);
                updateComm.ExecuteNonQuery();
                varosListaReset();
            }
            else
            {
                MessageBox.Show("Nincs adat kiválasztva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int vaneLatvanyossag(Varos varos)
        {
            int c = 0;
            varos = (Varos)lbox_varosok.SelectedItem;
            int id = getId(varos);
            string sql = @"
                SELECT COUNT(nev) AS c
                FROM latvanyossagok
                WHERE varos_id=@id
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@id", id);
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    c = reader.GetInt32("c");
                    
                }
            }
            return c;
        }

        private void btn_torles_Click(object sender, EventArgs e)
        {
            if (lbox_varosok.SelectedIndex > -1)
            {
                Varos v = (Varos)lbox_varosok.SelectedItem;
                string nev = v.Nev;
                if (vaneLatvanyossag(v)==0)
                {
                    var deleteComm = conn.CreateCommand();
                    deleteComm.CommandText = @"
                            DELETE FROM varosok
                            WHERE nev LIKE @nev
                        ";
                    deleteComm.Parameters.AddWithValue("@nev", nev);
                    deleteComm.ExecuteNonQuery();
                    varosListaReset();
                }
                
            }
            else
            {
                MessageBox.Show("Nincs adat kiválasztva vagy tartozik hozzá látványosság!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
