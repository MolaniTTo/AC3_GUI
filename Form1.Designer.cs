namespace AC3_GUI_C_
{
    partial class GestioDadesContainer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GBGestioDades = new GroupBox();
            TBTotal = new TextBox();
            lblTotal = new Label();
            TBPoblacio = new TextBox();
            TBConsumDom = new TextBox();
            TBActivitatsEcon = new TextBox();
            TBDomesticXarxa = new TextBox();
            lblConsumDomestic = new Label();
            lblActivitatsEcon = new Label();
            lblDomesticXarxa = new Label();
            CBComarca = new ComboBox();
            CBAny = new ComboBox();
            lblPoblacio = new Label();
            lblComarca = new Label();
            lblAny = new Label();
            ButNetejar = new Button();
            ButGuardar = new Button();
            GBEstadistiques = new GroupBox();
            lblConsDomesticCapitaBaix = new Label();
            lblConsDomesticCapitaAlt = new Label();
            lblConsDomMitja = new Label();
            lblPoblacioGreatherThan = new Label();
            label1 = new Label();
            lblConDomCapitaAlt = new Label();
            lblConsumDomMitja = new Label();
            lblPoblacio2000 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            GBGestioDades.SuspendLayout();
            GBEstadistiques.SuspendLayout();
            SuspendLayout();
            // 
            // GBGestioDades
            // 
            GBGestioDades.Controls.Add(TBTotal);
            GBGestioDades.Controls.Add(lblTotal);
            GBGestioDades.Controls.Add(TBPoblacio);
            GBGestioDades.Controls.Add(TBConsumDom);
            GBGestioDades.Controls.Add(TBActivitatsEcon);
            GBGestioDades.Controls.Add(TBDomesticXarxa);
            GBGestioDades.Controls.Add(lblConsumDomestic);
            GBGestioDades.Controls.Add(lblActivitatsEcon);
            GBGestioDades.Controls.Add(lblDomesticXarxa);
            GBGestioDades.Controls.Add(CBComarca);
            GBGestioDades.Controls.Add(CBAny);
            GBGestioDades.Controls.Add(lblPoblacio);
            GBGestioDades.Controls.Add(lblComarca);
            GBGestioDades.Controls.Add(lblAny);
            GBGestioDades.Location = new Point(12, 12);
            GBGestioDades.Name = "GBGestioDades";
            GBGestioDades.Size = new Size(510, 179);
            GBGestioDades.TabIndex = 0;
            GBGestioDades.TabStop = false;
            GBGestioDades.Text = "Gestió de dades demogràfiques de regions";
            // 
            // TBTotal
            // 
            TBTotal.Location = new Point(397, 138);
            TBTotal.Name = "TBTotal";
            TBTotal.Size = new Size(100, 23);
            TBTotal.TabIndex = 14;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(280, 141);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(111, 20);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total";
            lblTotal.Click += lblTotal_Click;
            // 
            // TBPoblacio
            // 
            TBPoblacio.Location = new Point(193, 46);
            TBPoblacio.Name = "TBPoblacio";
            TBPoblacio.Size = new Size(100, 23);
            TBPoblacio.TabIndex = 12;
            // 
            // TBConsumDom
            // 
            TBConsumDom.Location = new Point(397, 98);
            TBConsumDom.Name = "TBConsumDom";
            TBConsumDom.Size = new Size(100, 23);
            TBConsumDom.TabIndex = 11;
            // 
            // TBActivitatsEcon
            // 
            TBActivitatsEcon.Location = new Point(128, 138);
            TBActivitatsEcon.Name = "TBActivitatsEcon";
            TBActivitatsEcon.Size = new Size(100, 23);
            TBActivitatsEcon.TabIndex = 10;
            // 
            // TBDomesticXarxa
            // 
            TBDomesticXarxa.Location = new Point(18, 138);
            TBDomesticXarxa.Name = "TBDomesticXarxa";
            TBDomesticXarxa.Size = new Size(100, 23);
            TBDomesticXarxa.TabIndex = 9;
            // 
            // lblConsumDomestic
            // 
            lblConsumDomestic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsumDomestic.Location = new Point(280, 98);
            lblConsumDomestic.Name = "lblConsumDomestic";
            lblConsumDomestic.Size = new Size(111, 36);
            lblConsumDomestic.TabIndex = 8;
            lblConsumDomestic.Text = "Consum domèstic per capita";
            lblConsumDomestic.Click += label2_Click;
            // 
            // lblActivitatsEcon
            // 
            lblActivitatsEcon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblActivitatsEcon.Location = new Point(125, 98);
            lblActivitatsEcon.Name = "lblActivitatsEcon";
            lblActivitatsEcon.Size = new Size(139, 36);
            lblActivitatsEcon.TabIndex = 7;
            lblActivitatsEcon.Text = "Activitats econòmiques i fonts pròpies";
            lblActivitatsEcon.Click += label1_Click;
            // 
            // lblDomesticXarxa
            // 
            lblDomesticXarxa.AutoSize = true;
            lblDomesticXarxa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDomesticXarxa.Location = new Point(18, 98);
            lblDomesticXarxa.Name = "lblDomesticXarxa";
            lblDomesticXarxa.Size = new Size(101, 15);
            lblDomesticXarxa.TabIndex = 6;
            lblDomesticXarxa.Text = "Domeèstic xarxa";
            // 
            // CBComarca
            // 
            CBComarca.FormattingEnabled = true;
            CBComarca.Location = new Point(96, 46);
            CBComarca.Name = "CBComarca";
            CBComarca.Size = new Size(77, 23);
            CBComarca.TabIndex = 4;
            // 
            // CBAny
            // 
            CBAny.FormattingEnabled = true;
            CBAny.Items.AddRange(new object[] { "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050" });
            CBAny.Location = new Point(18, 46);
            CBAny.Name = "CBAny";
            CBAny.Size = new Size(57, 23);
            CBAny.TabIndex = 3;
            CBAny.SelectedIndexChanged += CBAny_SelectedIndexChanged;
            // 
            // lblPoblacio
            // 
            lblPoblacio.AutoSize = true;
            lblPoblacio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPoblacio.Location = new Point(193, 28);
            lblPoblacio.Name = "lblPoblacio";
            lblPoblacio.Size = new Size(53, 15);
            lblPoblacio.TabIndex = 2;
            lblPoblacio.Text = "Població";
            // 
            // lblComarca
            // 
            lblComarca.AutoSize = true;
            lblComarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblComarca.Location = new Point(96, 28);
            lblComarca.Name = "lblComarca";
            lblComarca.Size = new Size(55, 15);
            lblComarca.TabIndex = 1;
            lblComarca.Text = "Comarca";
            // 
            // lblAny
            // 
            lblAny.AutoSize = true;
            lblAny.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAny.Location = new Point(18, 28);
            lblAny.Name = "lblAny";
            lblAny.Size = new Size(28, 15);
            lblAny.TabIndex = 0;
            lblAny.Text = "Any";
            // 
            // ButNetejar
            // 
            ButNetejar.Location = new Point(357, 197);
            ButNetejar.Name = "ButNetejar";
            ButNetejar.Size = new Size(75, 23);
            ButNetejar.TabIndex = 1;
            ButNetejar.Text = "Netejar";
            ButNetejar.UseVisualStyleBackColor = true;
            // 
            // ButGuardar
            // 
            ButGuardar.Location = new Point(447, 197);
            ButGuardar.Name = "ButGuardar";
            ButGuardar.Size = new Size(75, 23);
            ButGuardar.TabIndex = 2;
            ButGuardar.Text = "Guardar";
            ButGuardar.UseVisualStyleBackColor = true;
            // 
            // GBEstadistiques
            // 
            GBEstadistiques.Controls.Add(lblConsDomesticCapitaBaix);
            GBEstadistiques.Controls.Add(lblConsDomesticCapitaAlt);
            GBEstadistiques.Controls.Add(lblConsDomMitja);
            GBEstadistiques.Controls.Add(lblPoblacioGreatherThan);
            GBEstadistiques.Controls.Add(label1);
            GBEstadistiques.Controls.Add(lblConDomCapitaAlt);
            GBEstadistiques.Controls.Add(lblConsumDomMitja);
            GBEstadistiques.Controls.Add(lblPoblacio2000);
            GBEstadistiques.Location = new Point(528, 12);
            GBEstadistiques.Name = "GBEstadistiques";
            GBEstadistiques.Size = new Size(260, 179);
            GBEstadistiques.TabIndex = 3;
            GBEstadistiques.TabStop = false;
            GBEstadistiques.Text = "Estadístiques";
            GBEstadistiques.Enter += GBEstadistiques_Enter;
            // 
            // lblConsDomesticCapitaBaix
            // 
            lblConsDomesticCapitaBaix.AutoSize = true;
            lblConsDomesticCapitaBaix.Location = new Point(236, 138);
            lblConsDomesticCapitaBaix.Name = "lblConsDomesticCapitaBaix";
            lblConsDomesticCapitaBaix.Size = new Size(0, 15);
            lblConsDomesticCapitaBaix.TabIndex = 7;
            // 
            // lblConsDomesticCapitaAlt
            // 
            lblConsDomesticCapitaAlt.AutoSize = true;
            lblConsDomesticCapitaAlt.Location = new Point(230, 98);
            lblConsDomesticCapitaAlt.Name = "lblConsDomesticCapitaAlt";
            lblConsDomesticCapitaAlt.Size = new Size(0, 15);
            lblConsDomesticCapitaAlt.TabIndex = 6;
            // 
            // lblConsDomMitja
            // 
            lblConsDomMitja.AutoSize = true;
            lblConsDomMitja.Location = new Point(157, 61);
            lblConsDomMitja.Name = "lblConsDomMitja";
            lblConsDomMitja.Size = new Size(0, 15);
            lblConsDomMitja.TabIndex = 5;
            // 
            // lblPoblacioGreatherThan
            // 
            lblPoblacioGreatherThan.AutoSize = true;
            lblPoblacioGreatherThan.Location = new Point(151, 32);
            lblPoblacioGreatherThan.Name = "lblPoblacioGreatherThan";
            lblPoblacioGreatherThan.Size = new Size(0, 15);
            lblPoblacioGreatherThan.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 138);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 3;
            label1.Text = "Consum domèstic per càpita més baix:";
            label1.Click += label1_Click_1;
            // 
            // lblConDomCapitaAlt
            // 
            lblConDomCapitaAlt.AutoSize = true;
            lblConDomCapitaAlt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConDomCapitaAlt.Location = new Point(12, 98);
            lblConDomCapitaAlt.Name = "lblConDomCapitaAlt";
            lblConDomCapitaAlt.Size = new Size(209, 15);
            lblConDomCapitaAlt.TabIndex = 2;
            lblConDomCapitaAlt.Text = "Consum domèstic per càpita més alt:";
            lblConDomCapitaAlt.Click += lblConDomCapitaAlt_Click;
            // 
            // lblConsumDomMitja
            // 
            lblConsumDomMitja.AutoSize = true;
            lblConsumDomMitja.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsumDomMitja.Location = new Point(12, 61);
            lblConsumDomMitja.Name = "lblConsumDomMitja";
            lblConsumDomMitja.Size = new Size(139, 15);
            lblConsumDomMitja.TabIndex = 1;
            lblConsumDomMitja.Text = "Consum domèstic mitjà:";
            // 
            // lblPoblacio2000
            // 
            lblPoblacio2000.AutoSize = true;
            lblPoblacio2000.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPoblacio2000.Location = new Point(12, 32);
            lblPoblacio2000.Name = "lblPoblacio2000";
            lblPoblacio2000.Size = new Size(128, 15);
            lblPoblacio2000.TabIndex = 0;
            lblPoblacio2000.Text = "Poblacio > 20000 hab:";
            // 
            // printDocument1
            // 
            printDocument1.DocumentName = "";
            // 
            // printDocument2
            // 
            printDocument2.DocumentName = "C:\\Users\\argo\\Documents\\TOT\\AccesDades\\EA's\\AC3_GUI_C#\\Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv";
            // 
            // GestioDadesContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GBEstadistiques);
            Controls.Add(ButGuardar);
            Controls.Add(ButNetejar);
            Controls.Add(GBGestioDades);
            Name = "GestioDadesContainer";
            Text = "Form1";
            GBGestioDades.ResumeLayout(false);
            GBGestioDades.PerformLayout();
            GBEstadistiques.ResumeLayout(false);
            GBEstadistiques.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GBGestioDades;
        private Label lblPoblacio;
        private Label lblComarca;
        private Label lblAny;
        private ComboBox CBAny;
        private ComboBox CBComarca;
        private Label lblConsumDomestic;
        private Label lblActivitatsEcon;
        private Label lblDomesticXarxa;
        private Label lblTotal;
        private TextBox TBPoblacio;
        private TextBox TBConsumDom;
        private TextBox TBActivitatsEcon;
        private TextBox TBDomesticXarxa;
        private TextBox TBTotal;
        private Button ButNetejar;
        private Button ButGuardar;
        private GroupBox GBEstadistiques;
        private Label lblConDomCapitaAlt;
        private Label lblConsumDomMitja;
        private Label lblPoblacio2000;
        private Label label1;
        private Label lblPoblacioGreatherThan;
        private Label lblConsDomesticCapitaBaix;
        private Label lblConsDomesticCapitaAlt;
        private Label lblConsDomMitja;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}
