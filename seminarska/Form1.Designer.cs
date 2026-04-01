namespace seminarska
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
            this.grpDogodek = new System.Windows.Forms.GroupBox();
            this.btnDodajDogodek = new System.Windows.Forms.Button();
            this.timeDo = new System.Windows.Forms.DateTimePicker();
            this.lblUraDo = new System.Windows.Forms.Label();
            this.timeOd = new System.Windows.Forms.DateTimePicker();
            this.lblUraOd = new System.Windows.Forms.Label();
            this.dtDo = new System.Windows.Forms.DateTimePicker();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.dtOd = new System.Windows.Forms.DateTimePicker();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.txtHala = new System.Windows.Forms.TextBox();
            this.lblHala = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.comboTip = new System.Windows.Forms.ComboBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.grpElementi = new System.Windows.Forms.GroupBox();
            this.listElementi = new System.Windows.Forms.ListBox();
            this.btnOdstrani = new System.Windows.Forms.Button();
            this.btnDodajElement = new System.Windows.Forms.Button();
            this.numPovrsina = new System.Windows.Forms.NumericUpDown();
            this.lblPovrsina = new System.Windows.Forms.Label();
            this.txtNazivElementa = new System.Windows.Forms.TextBox();
            this.lblNazivELementa = new System.Windows.Forms.Label();
            this.comboElement = new System.Windows.Forms.ComboBox();
            this.lblTipElementa = new System.Windows.Forms.Label();
            this.grpSeznam = new System.Windows.Forms.GroupBox();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.listDogodki = new System.Windows.Forms.ListBox();
            this.grpPodrobnosti = new System.Windows.Forms.GroupBox();
            this.lblStatistika = new System.Windows.Forms.Label();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.listProgram = new System.Windows.Forms.ListBox();
            this.btnDodajProgram = new System.Windows.Forms.Button();
            this.timeProgramDo = new System.Windows.Forms.DateTimePicker();
            this.timeProgramOd = new System.Windows.Forms.DateTimePicker();
            this.txtProgramNaziv = new System.Windows.Forms.TextBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblObremenitev = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblNaslovOpis = new System.Windows.Forms.Label();
            this.grpDogodek.SuspendLayout();
            this.grpElementi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPovrsina)).BeginInit();
            this.grpSeznam.SuspendLayout();
            this.grpPodrobnosti.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDogodek
            // 
            this.grpDogodek.Controls.Add(this.btnDodajDogodek);
            this.grpDogodek.Controls.Add(this.timeDo);
            this.grpDogodek.Controls.Add(this.lblUraDo);
            this.grpDogodek.Controls.Add(this.timeOd);
            this.grpDogodek.Controls.Add(this.lblUraOd);
            this.grpDogodek.Controls.Add(this.dtDo);
            this.grpDogodek.Controls.Add(this.lblDatumDo);
            this.grpDogodek.Controls.Add(this.dtOd);
            this.grpDogodek.Controls.Add(this.lblDatumOd);
            this.grpDogodek.Controls.Add(this.txtHala);
            this.grpDogodek.Controls.Add(this.lblHala);
            this.grpDogodek.Controls.Add(this.txtNaziv);
            this.grpDogodek.Controls.Add(this.lblNaziv);
            this.grpDogodek.Controls.Add(this.comboTip);
            this.grpDogodek.Controls.Add(this.lblTip);
            this.grpDogodek.Location = new System.Drawing.Point(20, 20);
            this.grpDogodek.Name = "grpDogodek";
            this.grpDogodek.Size = new System.Drawing.Size(320, 344);
            this.grpDogodek.TabIndex = 0;
            this.grpDogodek.TabStop = false;
            this.grpDogodek.Text = "Ustvarjanje dogodka";
            // 
            // btnDodajDogodek
            // 
            this.btnDodajDogodek.Location = new System.Drawing.Point(90, 300);
            this.btnDodajDogodek.Name = "btnDodajDogodek";
            this.btnDodajDogodek.Size = new System.Drawing.Size(140, 35);
            this.btnDodajDogodek.TabIndex = 4;
            this.btnDodajDogodek.Text = "Dodaj dogodek";
            this.btnDodajDogodek.UseVisualStyleBackColor = true;
            this.btnDodajDogodek.Click += new System.EventHandler(this.btnDodajDogodek_Click);
            // 
            // timeDo
            // 
            this.timeDo.CustomFormat = "HH:00";
            this.timeDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeDo.Location = new System.Drawing.Point(140, 270);
            this.timeDo.Name = "timeDo";
            this.timeDo.ShowUpDown = true;
            this.timeDo.Size = new System.Drawing.Size(150, 22);
            this.timeDo.TabIndex = 4;
            // 
            // lblUraDo
            // 
            this.lblUraDo.AutoSize = true;
            this.lblUraDo.Location = new System.Drawing.Point(20, 275);
            this.lblUraDo.Name = "lblUraDo";
            this.lblUraDo.Size = new System.Drawing.Size(51, 16);
            this.lblUraDo.TabIndex = 4;
            this.lblUraDo.Text = "Ura do:";
            // 
            // timeOd
            // 
            this.timeOd.CustomFormat = "HH:00";
            this.timeOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeOd.Location = new System.Drawing.Point(140, 230);
            this.timeOd.Name = "timeOd";
            this.timeOd.ShowUpDown = true;
            this.timeOd.Size = new System.Drawing.Size(150, 22);
            this.timeOd.TabIndex = 4;
            // 
            // lblUraOd
            // 
            this.lblUraOd.AutoSize = true;
            this.lblUraOd.Location = new System.Drawing.Point(20, 235);
            this.lblUraOd.Name = "lblUraOd";
            this.lblUraOd.Size = new System.Drawing.Size(51, 16);
            this.lblUraOd.TabIndex = 4;
            this.lblUraOd.Text = "Ura od:";
            // 
            // dtDo
            // 
            this.dtDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDo.Location = new System.Drawing.Point(140, 190);
            this.dtDo.Name = "dtDo";
            this.dtDo.Size = new System.Drawing.Size(150, 22);
            this.dtDo.TabIndex = 4;
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Location = new System.Drawing.Point(20, 195);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(68, 16);
            this.lblDatumDo.TabIndex = 4;
            this.lblDatumDo.Text = "Datum do:";
            // 
            // dtOd
            // 
            this.dtOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOd.Location = new System.Drawing.Point(140, 150);
            this.dtOd.Name = "dtOd";
            this.dtOd.Size = new System.Drawing.Size(150, 22);
            this.dtOd.TabIndex = 4;
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Location = new System.Drawing.Point(20, 155);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(68, 16);
            this.lblDatumOd.TabIndex = 4;
            this.lblDatumOd.Text = "Datum od:";
            // 
            // txtHala
            // 
            this.txtHala.Location = new System.Drawing.Point(140, 115);
            this.txtHala.Name = "txtHala";
            this.txtHala.Size = new System.Drawing.Size(150, 22);
            this.txtHala.TabIndex = 4;
            // 
            // lblHala
            // 
            this.lblHala.AutoSize = true;
            this.lblHala.Location = new System.Drawing.Point(20, 115);
            this.lblHala.Name = "lblHala";
            this.lblHala.Size = new System.Drawing.Size(39, 16);
            this.lblHala.TabIndex = 4;
            this.lblHala.Text = "Hala:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(140, 70);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(150, 22);
            this.txtNaziv.TabIndex = 4;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(20, 75);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 16);
            this.lblNaziv.TabIndex = 4;
            this.lblNaziv.Text = "Naziv:";
            // 
            // comboTip
            // 
            this.comboTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTip.FormattingEnabled = true;
            this.comboTip.Location = new System.Drawing.Point(140, 30);
            this.comboTip.Name = "comboTip";
            this.comboTip.Size = new System.Drawing.Size(150, 24);
            this.comboTip.TabIndex = 4;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(20, 35);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(88, 16);
            this.lblTip.TabIndex = 4;
            this.lblTip.Text = "Tip dogodka:";
            // 
            // grpElementi
            // 
            this.grpElementi.Controls.Add(this.listElementi);
            this.grpElementi.Controls.Add(this.btnOdstrani);
            this.grpElementi.Controls.Add(this.btnDodajElement);
            this.grpElementi.Controls.Add(this.numPovrsina);
            this.grpElementi.Controls.Add(this.lblPovrsina);
            this.grpElementi.Controls.Add(this.txtNazivElementa);
            this.grpElementi.Controls.Add(this.lblNazivELementa);
            this.grpElementi.Controls.Add(this.comboElement);
            this.grpElementi.Controls.Add(this.lblTipElementa);
            this.grpElementi.Location = new System.Drawing.Point(20, 370);
            this.grpElementi.Name = "grpElementi";
            this.grpElementi.Size = new System.Drawing.Size(320, 330);
            this.grpElementi.TabIndex = 1;
            this.grpElementi.TabStop = false;
            this.grpElementi.Text = "Elementi dogodka";
            // 
            // listElementi
            // 
            this.listElementi.FormattingEnabled = true;
            this.listElementi.ItemHeight = 16;
            this.listElementi.Location = new System.Drawing.Point(20, 205);
            this.listElementi.Name = "listElementi";
            this.listElementi.Size = new System.Drawing.Size(270, 100);
            this.listElementi.TabIndex = 4;
            // 
            // btnOdstrani
            // 
            this.btnOdstrani.Location = new System.Drawing.Point(165, 155);
            this.btnOdstrani.Name = "btnOdstrani";
            this.btnOdstrani.Size = new System.Drawing.Size(125, 35);
            this.btnOdstrani.TabIndex = 4;
            this.btnOdstrani.Text = "Odstrani izbranega";
            this.btnOdstrani.UseVisualStyleBackColor = true;
            this.btnOdstrani.Click += new System.EventHandler(this.btnOdstrani_Click);
            // 
            // btnDodajElement
            // 
            this.btnDodajElement.Location = new System.Drawing.Point(30, 155);
            this.btnDodajElement.Name = "btnDodajElement";
            this.btnDodajElement.Size = new System.Drawing.Size(120, 35);
            this.btnDodajElement.TabIndex = 4;
            this.btnDodajElement.Text = "Dodaj element";
            this.btnDodajElement.UseVisualStyleBackColor = true;
            this.btnDodajElement.Click += new System.EventHandler(this.btnDodajElement_Click);
            // 
            // numPovrsina
            // 
            this.numPovrsina.Location = new System.Drawing.Point(140, 110);
            this.numPovrsina.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPovrsina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPovrsina.Name = "numPovrsina";
            this.numPovrsina.Size = new System.Drawing.Size(150, 22);
            this.numPovrsina.TabIndex = 4;
            this.numPovrsina.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblPovrsina
            // 
            this.lblPovrsina.AutoSize = true;
            this.lblPovrsina.Location = new System.Drawing.Point(20, 115);
            this.lblPovrsina.Name = "lblPovrsina";
            this.lblPovrsina.Size = new System.Drawing.Size(63, 16);
            this.lblPovrsina.TabIndex = 4;
            this.lblPovrsina.Text = "Povrsina:";
            // 
            // txtNazivElementa
            // 
            this.txtNazivElementa.Location = new System.Drawing.Point(140, 70);
            this.txtNazivElementa.Name = "txtNazivElementa";
            this.txtNazivElementa.Size = new System.Drawing.Size(150, 22);
            this.txtNazivElementa.TabIndex = 4;
            // 
            // lblNazivELementa
            // 
            this.lblNazivELementa.AutoSize = true;
            this.lblNazivELementa.Location = new System.Drawing.Point(20, 75);
            this.lblNazivELementa.Name = "lblNazivELementa";
            this.lblNazivELementa.Size = new System.Drawing.Size(103, 16);
            this.lblNazivELementa.TabIndex = 4;
            this.lblNazivELementa.Text = "Naziv elementa:";
            // 
            // comboElement
            // 
            this.comboElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboElement.FormattingEnabled = true;
            this.comboElement.Location = new System.Drawing.Point(140, 30);
            this.comboElement.Name = "comboElement";
            this.comboElement.Size = new System.Drawing.Size(150, 24);
            this.comboElement.TabIndex = 4;
            // 
            // lblTipElementa
            // 
            this.lblTipElementa.AutoSize = true;
            this.lblTipElementa.Location = new System.Drawing.Point(20, 35);
            this.lblTipElementa.Name = "lblTipElementa";
            this.lblTipElementa.Size = new System.Drawing.Size(89, 16);
            this.lblTipElementa.TabIndex = 4;
            this.lblTipElementa.Text = "Tip elementa:";
            // 
            // grpSeznam
            // 
            this.grpSeznam.Controls.Add(this.btnOsvezi);
            this.grpSeznam.Controls.Add(this.listDogodki);
            this.grpSeznam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpSeznam.Location = new System.Drawing.Point(360, 20);
            this.grpSeznam.Name = "grpSeznam";
            this.grpSeznam.Size = new System.Drawing.Size(350, 680);
            this.grpSeznam.TabIndex = 2;
            this.grpSeznam.TabStop = false;
            this.grpSeznam.Text = "Seznam dogodkov";
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(95, 625);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(150, 35);
            this.btnOsvezi.TabIndex = 1;
            this.btnOsvezi.Text = "Osvezi seznam";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // listDogodki
            // 
            this.listDogodki.FormattingEnabled = true;
            this.listDogodki.ItemHeight = 16;
            this.listDogodki.Location = new System.Drawing.Point(20, 35);
            this.listDogodki.Name = "listDogodki";
            this.listDogodki.Size = new System.Drawing.Size(300, 580);
            this.listDogodki.TabIndex = 0;
            // 
            // grpPodrobnosti
            // 
            this.grpPodrobnosti.Controls.Add(this.lblStatistika);
            this.grpPodrobnosti.Controls.Add(this.btnStatistika);
            this.grpPodrobnosti.Controls.Add(this.listLog);
            this.grpPodrobnosti.Controls.Add(this.lblLog);
            this.grpPodrobnosti.Controls.Add(this.listProgram);
            this.grpPodrobnosti.Controls.Add(this.btnDodajProgram);
            this.grpPodrobnosti.Controls.Add(this.timeProgramDo);
            this.grpPodrobnosti.Controls.Add(this.timeProgramOd);
            this.grpPodrobnosti.Controls.Add(this.txtProgramNaziv);
            this.grpPodrobnosti.Controls.Add(this.lblProgram);
            this.grpPodrobnosti.Controls.Add(this.progressBar1);
            this.grpPodrobnosti.Controls.Add(this.lblObremenitev);
            this.grpPodrobnosti.Controls.Add(this.lblOpis);
            this.grpPodrobnosti.Controls.Add(this.lblNaslovOpis);
            this.grpPodrobnosti.Location = new System.Drawing.Point(730, 20);
            this.grpPodrobnosti.Name = "grpPodrobnosti";
            this.grpPodrobnosti.Size = new System.Drawing.Size(630, 680);
            this.grpPodrobnosti.TabIndex = 3;
            this.grpPodrobnosti.TabStop = false;
            this.grpPodrobnosti.Text = "Podrobnosti, dogodki in statistika";
            // 
            // lblStatistika
            // 
            this.lblStatistika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatistika.Location = new System.Drawing.Point(20, 615);
            this.lblStatistika.Name = "lblStatistika";
            this.lblStatistika.Size = new System.Drawing.Size(580, 50);
            this.lblStatistika.TabIndex = 13;
            this.lblStatistika.Text = "Statistika se bo prikazala tukaj";
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(20, 570);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(160, 35);
            this.btnStatistika.TabIndex = 12;
            this.btnStatistika.Text = "Prikazi statistiko";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // listLog
            // 
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 16;
            this.listLog.Location = new System.Drawing.Point(20, 430);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(580, 116);
            this.listLog.TabIndex = 11;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLog.Location = new System.Drawing.Point(20, 405);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(137, 16);
            this.lblLog.TabIndex = 10;
            this.lblLog.Text = "Dnevnik dogodkov";
            // 
            // listProgram
            // 
            this.listProgram.FormattingEnabled = true;
            this.listProgram.ItemHeight = 16;
            this.listProgram.Location = new System.Drawing.Point(20, 280);
            this.listProgram.Name = "listProgram";
            this.listProgram.Size = new System.Drawing.Size(580, 100);
            this.listProgram.TabIndex = 9;
            this.listProgram.SelectedIndexChanged += new System.EventHandler(this.listProgram_SelectedIndexChanged);
            // 
            // btnDodajProgram
            // 
            this.btnDodajProgram.Location = new System.Drawing.Point(470, 237);
            this.btnDodajProgram.Name = "btnDodajProgram";
            this.btnDodajProgram.Size = new System.Drawing.Size(130, 32);
            this.btnDodajProgram.TabIndex = 8;
            this.btnDodajProgram.Text = "Dodaj program";
            this.btnDodajProgram.UseVisualStyleBackColor = true;
            this.btnDodajProgram.Click += new System.EventHandler(this.btnDodajProgram_Click_1);
            // 
            // timeProgramDo
            // 
            this.timeProgramDo.CustomFormat = "HH:00";
            this.timeProgramDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeProgramDo.Location = new System.Drawing.Point(345, 240);
            this.timeProgramDo.Name = "timeProgramDo";
            this.timeProgramDo.ShowUpDown = true;
            this.timeProgramDo.Size = new System.Drawing.Size(110, 22);
            this.timeProgramDo.TabIndex = 7;
            // 
            // timeProgramOd
            // 
            this.timeProgramOd.CustomFormat = "HH:00";
            this.timeProgramOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeProgramOd.Location = new System.Drawing.Point(220, 240);
            this.timeProgramOd.Name = "timeProgramOd";
            this.timeProgramOd.ShowUpDown = true;
            this.timeProgramOd.Size = new System.Drawing.Size(110, 22);
            this.timeProgramOd.TabIndex = 6;
            // 
            // txtProgramNaziv
            // 
            this.txtProgramNaziv.Location = new System.Drawing.Point(20, 240);
            this.txtProgramNaziv.Name = "txtProgramNaziv";
            this.txtProgramNaziv.Size = new System.Drawing.Size(180, 22);
            this.txtProgramNaziv.TabIndex = 5;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProgram.Location = new System.Drawing.Point(20, 215);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(132, 16);
            this.lblProgram.TabIndex = 4;
            this.lblProgram.Text = "Program dogodka";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 170);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(580, 28);
            this.progressBar1.TabIndex = 3;
            // 
            // lblObremenitev
            // 
            this.lblObremenitev.AutoSize = true;
            this.lblObremenitev.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObremenitev.Location = new System.Drawing.Point(20, 145);
            this.lblObremenitev.Name = "lblObremenitev";
            this.lblObremenitev.Size = new System.Drawing.Size(95, 16);
            this.lblObremenitev.TabIndex = 2;
            this.lblObremenitev.Text = "Obremenitev";
            // 
            // lblOpis
            // 
            this.lblOpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpis.Location = new System.Drawing.Point(20, 60);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(580, 70);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "Ni izbranega dogodka";
            // 
            // lblNaslovOpis
            // 
            this.lblNaslovOpis.AutoSize = true;
            this.lblNaslovOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovOpis.Location = new System.Drawing.Point(20, 30);
            this.lblNaslovOpis.Name = "lblNaslovOpis";
            this.lblNaslovOpis.Size = new System.Drawing.Size(230, 16);
            this.lblNaslovOpis.TabIndex = 0;
            this.lblNaslovOpis.Text = "Podrobnosti izbranega dogodka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.grpPodrobnosti);
            this.Controls.Add(this.grpSeznam);
            this.Controls.Add(this.grpElementi);
            this.Controls.Add(this.grpDogodek);
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje sejmisca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDogodek.ResumeLayout(false);
            this.grpDogodek.PerformLayout();
            this.grpElementi.ResumeLayout(false);
            this.grpElementi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPovrsina)).EndInit();
            this.grpSeznam.ResumeLayout(false);
            this.grpPodrobnosti.ResumeLayout(false);
            this.grpPodrobnosti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDogodek;
        private System.Windows.Forms.GroupBox grpElementi;
        private System.Windows.Forms.GroupBox grpSeznam;
        private System.Windows.Forms.GroupBox grpPodrobnosti;
        private System.Windows.Forms.ComboBox comboTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtHala;
        private System.Windows.Forms.Label lblHala;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.DateTimePicker dtOd;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.Label lblUraDo;
        private System.Windows.Forms.DateTimePicker timeOd;
        private System.Windows.Forms.Label lblUraOd;
        private System.Windows.Forms.DateTimePicker dtDo;
        private System.Windows.Forms.Button btnDodajDogodek;
        private System.Windows.Forms.DateTimePicker timeDo;
        private System.Windows.Forms.Label lblTipElementa;
        private System.Windows.Forms.TextBox txtNazivElementa;
        private System.Windows.Forms.Label lblNazivELementa;
        private System.Windows.Forms.ComboBox comboElement;
        private System.Windows.Forms.Button btnOdstrani;
        private System.Windows.Forms.Button btnDodajElement;
        private System.Windows.Forms.NumericUpDown numPovrsina;
        private System.Windows.Forms.Label lblPovrsina;
        private System.Windows.Forms.ListBox listElementi;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.ListBox listDogodki;
        private System.Windows.Forms.Label lblNaslovOpis;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblObremenitev;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtProgramNaziv;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.DateTimePicker timeProgramDo;
        private System.Windows.Forms.DateTimePicker timeProgramOd;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.ListBox listProgram;
        private System.Windows.Forms.Button btnDodajProgram;
        private System.Windows.Forms.Label lblStatistika;
    }
}

