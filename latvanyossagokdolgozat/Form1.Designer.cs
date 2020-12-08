namespace latvanyossagokdolgozat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox_varosok = new System.Windows.Forms.GroupBox();
            this.lbox_varoslatvanyossagai = new System.Windows.Forms.ListBox();
            this.lbox_varosok = new System.Windows.Forms.ListBox();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numupd_varoslakossag = new System.Windows.Forms.NumericUpDown();
            this.txtbx_varosneve = new System.Windows.Forms.TextBox();
            this.gbox_latvanyossagok = new System.Windows.Forms.GroupBox();
            this.btn_latvanyossaghozzaad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numupd_latvanyossagara = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_latvanyossag = new System.Windows.Forms.Label();
            this.rtbox_latvanyossagleiras = new System.Windows.Forms.RichTextBox();
            this.txtbx_latvanyossagneve = new System.Windows.Forms.TextBox();
            this.btn_modosit = new System.Windows.Forms.Button();
            this.btn_torles = new System.Windows.Forms.Button();
            this.gbox_varosok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupd_varoslakossag)).BeginInit();
            this.gbox_latvanyossagok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupd_latvanyossagara)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_varosok
            // 
            this.gbox_varosok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbox_varosok.Controls.Add(this.btn_torles);
            this.gbox_varosok.Controls.Add(this.btn_modosit);
            this.gbox_varosok.Controls.Add(this.lbox_varoslatvanyossagai);
            this.gbox_varosok.Controls.Add(this.lbox_varosok);
            this.gbox_varosok.Controls.Add(this.btn_hozzaad);
            this.gbox_varosok.Controls.Add(this.label2);
            this.gbox_varosok.Controls.Add(this.label1);
            this.gbox_varosok.Controls.Add(this.numupd_varoslakossag);
            this.gbox_varosok.Controls.Add(this.txtbx_varosneve);
            this.gbox_varosok.Location = new System.Drawing.Point(12, 12);
            this.gbox_varosok.Name = "gbox_varosok";
            this.gbox_varosok.Size = new System.Drawing.Size(379, 588);
            this.gbox_varosok.TabIndex = 0;
            this.gbox_varosok.TabStop = false;
            this.gbox_varosok.Text = "Városok";
            // 
            // lbox_varoslatvanyossagai
            // 
            this.lbox_varoslatvanyossagai.FormattingEnabled = true;
            this.lbox_varoslatvanyossagai.Location = new System.Drawing.Point(197, 276);
            this.lbox_varoslatvanyossagai.Name = "lbox_varoslatvanyossagai";
            this.lbox_varoslatvanyossagai.Size = new System.Drawing.Size(166, 290);
            this.lbox_varoslatvanyossagai.TabIndex = 6;
            // 
            // lbox_varosok
            // 
            this.lbox_varosok.FormattingEnabled = true;
            this.lbox_varosok.Location = new System.Drawing.Point(15, 276);
            this.lbox_varosok.Name = "lbox_varosok";
            this.lbox_varosok.Size = new System.Drawing.Size(159, 290);
            this.lbox_varosok.TabIndex = 5;
            this.lbox_varosok.SelectedIndexChanged += new System.EventHandler(this.lbox_varosok_SelectedIndexChanged);
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Location = new System.Drawing.Point(132, 153);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(75, 23);
            this.btn_hozzaad.TabIndex = 4;
            this.btn_hozzaad.Text = "Hozzáadás";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.btn_hozzaad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Város lakossága";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Város neve";
            // 
            // numupd_varoslakossag
            // 
            this.numupd_varoslakossag.Location = new System.Drawing.Point(92, 113);
            this.numupd_varoslakossag.Name = "numupd_varoslakossag";
            this.numupd_varoslakossag.Size = new System.Drawing.Size(159, 20);
            this.numupd_varoslakossag.TabIndex = 1;
            // 
            // txtbx_varosneve
            // 
            this.txtbx_varosneve.Location = new System.Drawing.Point(92, 60);
            this.txtbx_varosneve.Name = "txtbx_varosneve";
            this.txtbx_varosneve.Size = new System.Drawing.Size(159, 20);
            this.txtbx_varosneve.TabIndex = 0;
            // 
            // gbox_latvanyossagok
            // 
            this.gbox_latvanyossagok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbox_latvanyossagok.Controls.Add(this.btn_latvanyossaghozzaad);
            this.gbox_latvanyossagok.Controls.Add(this.label4);
            this.gbox_latvanyossagok.Controls.Add(this.numupd_latvanyossagara);
            this.gbox_latvanyossagok.Controls.Add(this.label3);
            this.gbox_latvanyossagok.Controls.Add(this.lbl_latvanyossag);
            this.gbox_latvanyossagok.Controls.Add(this.rtbox_latvanyossagleiras);
            this.gbox_latvanyossagok.Controls.Add(this.txtbx_latvanyossagneve);
            this.gbox_latvanyossagok.Location = new System.Drawing.Point(442, 12);
            this.gbox_latvanyossagok.Name = "gbox_latvanyossagok";
            this.gbox_latvanyossagok.Size = new System.Drawing.Size(389, 587);
            this.gbox_latvanyossagok.TabIndex = 1;
            this.gbox_latvanyossagok.TabStop = false;
            this.gbox_latvanyossagok.Text = "Látványosságok";
            // 
            // btn_latvanyossaghozzaad
            // 
            this.btn_latvanyossaghozzaad.Location = new System.Drawing.Point(153, 312);
            this.btn_latvanyossaghozzaad.Name = "btn_latvanyossaghozzaad";
            this.btn_latvanyossaghozzaad.Size = new System.Drawing.Size(75, 23);
            this.btn_latvanyossaghozzaad.TabIndex = 7;
            this.btn_latvanyossaghozzaad.Text = "Hozzáadás";
            this.btn_latvanyossaghozzaad.UseVisualStyleBackColor = true;
            this.btn_latvanyossaghozzaad.Click += new System.EventHandler(this.btn_latvanyossaghozzaad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Látványosság ára";
            // 
            // numupd_latvanyossagara
            // 
            this.numupd_latvanyossagara.Location = new System.Drawing.Point(107, 261);
            this.numupd_latvanyossagara.Name = "numupd_latvanyossagara";
            this.numupd_latvanyossagara.Size = new System.Drawing.Size(159, 20);
            this.numupd_latvanyossagara.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Látványosság leírása";
            // 
            // lbl_latvanyossag
            // 
            this.lbl_latvanyossag.AutoSize = true;
            this.lbl_latvanyossag.Location = new System.Drawing.Point(136, 44);
            this.lbl_latvanyossag.Name = "lbl_latvanyossag";
            this.lbl_latvanyossag.Size = new System.Drawing.Size(100, 13);
            this.lbl_latvanyossag.TabIndex = 3;
            this.lbl_latvanyossag.Text = "Látványosság neve";
            // 
            // rtbox_latvanyossagleiras
            // 
            this.rtbox_latvanyossagleiras.Location = new System.Drawing.Point(69, 113);
            this.rtbox_latvanyossagleiras.Name = "rtbox_latvanyossagleiras";
            this.rtbox_latvanyossagleiras.Size = new System.Drawing.Size(243, 111);
            this.rtbox_latvanyossagleiras.TabIndex = 2;
            this.rtbox_latvanyossagleiras.Text = "";
            // 
            // txtbx_latvanyossagneve
            // 
            this.txtbx_latvanyossagneve.Location = new System.Drawing.Point(107, 60);
            this.txtbx_latvanyossagneve.Name = "txtbx_latvanyossagneve";
            this.txtbx_latvanyossagneve.Size = new System.Drawing.Size(159, 20);
            this.txtbx_latvanyossagneve.TabIndex = 0;
            // 
            // btn_modosit
            // 
            this.btn_modosit.Location = new System.Drawing.Point(132, 182);
            this.btn_modosit.Name = "btn_modosit";
            this.btn_modosit.Size = new System.Drawing.Size(75, 23);
            this.btn_modosit.TabIndex = 7;
            this.btn_modosit.Text = "Módosítás";
            this.btn_modosit.UseVisualStyleBackColor = true;
            this.btn_modosit.Click += new System.EventHandler(this.btn_modosit_Click);
            // 
            // btn_torles
            // 
            this.btn_torles.Location = new System.Drawing.Point(132, 211);
            this.btn_torles.Name = "btn_torles";
            this.btn_torles.Size = new System.Drawing.Size(75, 23);
            this.btn_torles.TabIndex = 8;
            this.btn_torles.Text = "Törlés";
            this.btn_torles.UseVisualStyleBackColor = true;
            this.btn_torles.Click += new System.EventHandler(this.btn_torles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 612);
            this.Controls.Add(this.gbox_latvanyossagok);
            this.Controls.Add(this.gbox_varosok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox_varosok.ResumeLayout(false);
            this.gbox_varosok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupd_varoslakossag)).EndInit();
            this.gbox_latvanyossagok.ResumeLayout(false);
            this.gbox_latvanyossagok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupd_latvanyossagara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_varosok;
        private System.Windows.Forms.NumericUpDown numupd_varoslakossag;
        private System.Windows.Forms.TextBox txtbx_varosneve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.ListBox lbox_varosok;
        private System.Windows.Forms.ListBox lbox_varoslatvanyossagai;
        private System.Windows.Forms.GroupBox gbox_latvanyossagok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numupd_latvanyossagara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_latvanyossag;
        private System.Windows.Forms.RichTextBox rtbox_latvanyossagleiras;
        private System.Windows.Forms.TextBox txtbx_latvanyossagneve;
        private System.Windows.Forms.Button btn_latvanyossaghozzaad;
        private System.Windows.Forms.Button btn_modosit;
        private System.Windows.Forms.Button btn_torles;
    }
}

