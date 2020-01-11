namespace thap
{
    partial class ThapHanoi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThapHanoi));
            this.A = new System.Windows.Forms.Label();
            this.thoigian = new System.Windows.Forms.Label();
            this.solandich = new System.Windows.Forms.Label();
            this.sodia = new System.Windows.Forms.NumericUpDown();
            this.play = new System.Windows.Forms.Button();
            this.tamdung = new System.Windows.Forms.Button();
            this.counttime = new System.Windows.Forms.Timer(this.components);
            this.muc = new System.Windows.Forms.Label();
            this.De = new System.Windows.Forms.Button();
            this.kho = new System.Windows.Forms.Button();
            this.solandichchuyentoida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dia8 = new System.Windows.Forms.PictureBox();
            this.dia7 = new System.Windows.Forms.PictureBox();
            this.dia6 = new System.Windows.Forms.PictureBox();
            this.dia5 = new System.Windows.Forms.PictureBox();
            this.dia4 = new System.Windows.Forms.PictureBox();
            this.dia3 = new System.Windows.Forms.PictureBox();
            this.dia2 = new System.Windows.Forms.PictureBox();
            this.dia1 = new System.Windows.Forms.PictureBox();
            this.CotC = new System.Windows.Forms.PictureBox();
            this.CotB = new System.Windows.Forms.PictureBox();
            this.CotA = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sodia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotA)).BeginInit();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.BackColor = System.Drawing.Color.Transparent;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Image = global::thap.Properties.Resources.A;
            this.A.Location = new System.Drawing.Point(149, 399);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(0, 31);
            this.A.TabIndex = 3;
            // 
            // thoigian
            // 
            this.thoigian.AutoSize = true;
            this.thoigian.BackColor = System.Drawing.Color.Transparent;
            this.thoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoigian.ForeColor = System.Drawing.Color.Purple;
            this.thoigian.Location = new System.Drawing.Point(637, 10);
            this.thoigian.Name = "thoigian";
            this.thoigian.Size = new System.Drawing.Size(88, 24);
            this.thoigian.TabIndex = 14;
            this.thoigian.Text = "00:00:00";
            this.thoigian.Click += new System.EventHandler(this.thoigian_Click);
            // 
            // solandich
            // 
            this.solandich.AutoSize = true;
            this.solandich.BackColor = System.Drawing.Color.Transparent;
            this.solandich.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solandich.ForeColor = System.Drawing.Color.Purple;
            this.solandich.Location = new System.Drawing.Point(711, 36);
            this.solandich.Name = "solandich";
            this.solandich.Size = new System.Drawing.Size(27, 24);
            this.solandich.TabIndex = 15;
            this.solandich.Text = " 0";
            this.solandich.Click += new System.EventHandler(this.solandich_Click);
            // 
            // sodia
            // 
            this.sodia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sodia.ForeColor = System.Drawing.Color.Purple;
            this.sodia.Location = new System.Drawing.Point(94, 26);
            this.sodia.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.sodia.Name = "sodia";
            this.sodia.Size = new System.Drawing.Size(40, 20);
            this.sodia.TabIndex = 16;
            this.sodia.ValueChanged += new System.EventHandler(this.sodia_ValueChanged);
            this.sodia.Click += new System.EventHandler(this.Cot_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImage = global::thap.Properties.Resources.text_play1;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.Location = new System.Drawing.Point(241, 120);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(99, 37);
            this.play.TabIndex = 18;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // tamdung
            // 
            this.tamdung.BackColor = System.Drawing.Color.Transparent;
            this.tamdung.BackgroundImage = global::thap.Properties.Resources.text_pause;
            this.tamdung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tamdung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamdung.Location = new System.Drawing.Point(374, 120);
            this.tamdung.Name = "tamdung";
            this.tamdung.Size = new System.Drawing.Size(125, 37);
            this.tamdung.TabIndex = 19;
            this.tamdung.UseVisualStyleBackColor = false;
            this.tamdung.Visible = false;
            this.tamdung.Click += new System.EventHandler(this.tamdung_Click);
            // 
            // counttime
            // 
            this.counttime.Tick += new System.EventHandler(this.counttime_Tick);
            // 
            // muc
            // 
            this.muc.AutoSize = true;
            this.muc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muc.Location = new System.Drawing.Point(499, 36);
            this.muc.Name = "muc";
            this.muc.Size = new System.Drawing.Size(0, 25);
            this.muc.TabIndex = 29;
            this.muc.Click += new System.EventHandler(this.mức_Click);
            // 
            // De
            // 
            this.De.BackColor = System.Drawing.Color.Transparent;
            this.De.BackgroundImage = global::thap.Properties.Resources.text_dễ;
            this.De.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.De.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.De.Location = new System.Drawing.Point(111, 59);
            this.De.Name = "De";
            this.De.Size = new System.Drawing.Size(57, 26);
            this.De.TabIndex = 30;
            this.De.UseVisualStyleBackColor = false;
            this.De.Click += new System.EventHandler(this.De_Click);
            // 
            // kho
            // 
            this.kho.BackColor = System.Drawing.Color.Transparent;
            this.kho.BackgroundImage = global::thap.Properties.Resources.text_kho;
            this.kho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kho.Location = new System.Drawing.Point(111, 91);
            this.kho.Name = "kho";
            this.kho.Size = new System.Drawing.Size(57, 32);
            this.kho.TabIndex = 31;
            this.kho.UseVisualStyleBackColor = false;
            this.kho.Click += new System.EventHandler(this.kho_Click);
            // 
            // solandichchuyentoida
            // 
            this.solandichchuyentoida.AutoSize = true;
            this.solandichchuyentoida.BackColor = System.Drawing.Color.Transparent;
            this.solandichchuyentoida.Enabled = false;
            this.solandichchuyentoida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solandichchuyentoida.ForeColor = System.Drawing.Color.Purple;
            this.solandichchuyentoida.Location = new System.Drawing.Point(747, 64);
            this.solandichchuyentoida.Name = "solandichchuyentoida";
            this.solandichchuyentoida.Size = new System.Drawing.Size(21, 24);
            this.solandichchuyentoida.TabIndex = 32;
            this.solandichchuyentoida.Text = "0";
            this.solandichchuyentoida.Visible = false;
            this.solandichchuyentoida.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::thap.Properties.Resources.text_time;
            this.label1.Location = new System.Drawing.Point(152, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // dia8
            // 
            this.dia8.BackColor = System.Drawing.Color.Transparent;
            this.dia8.BackgroundImage = global::thap.Properties.Resources.dĩa8;
            this.dia8.Location = new System.Drawing.Point(58, 351);
            this.dia8.Name = "dia8";
            this.dia8.Size = new System.Drawing.Size(200, 23);
            this.dia8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia8.TabIndex = 28;
            this.dia8.TabStop = false;
            this.dia8.Tag = "8";
            this.dia8.Visible = false;
            this.dia8.Click += new System.EventHandler(this.dia_Click);
            // 
            // dia7
            // 
            this.dia7.BackColor = System.Drawing.Color.Transparent;
            this.dia7.Image = global::thap.Properties.Resources.dĩa7;
            this.dia7.Location = new System.Drawing.Point(58, 332);
            this.dia7.Name = "dia7";
            this.dia7.Size = new System.Drawing.Size(200, 24);
            this.dia7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia7.TabIndex = 27;
            this.dia7.TabStop = false;
            this.dia7.Tag = "7";
            this.dia7.Visible = false;
            this.dia7.Click += new System.EventHandler(this.dia_Click);
            // 
            // dia6
            // 
            this.dia6.BackColor = System.Drawing.Color.Transparent;
            this.dia6.Image = global::thap.Properties.Resources.dĩa6;
            this.dia6.Location = new System.Drawing.Point(58, 311);
            this.dia6.Name = "dia6";
            this.dia6.Size = new System.Drawing.Size(200, 24);
            this.dia6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia6.TabIndex = 26;
            this.dia6.TabStop = false;
            this.dia6.Tag = "6";
            this.dia6.Visible = false;
            this.dia6.Click += new System.EventHandler(this.dia_Click);
            // 
            // dia5
            // 
            this.dia5.BackColor = System.Drawing.Color.Transparent;
            this.dia5.Image = global::thap.Properties.Resources.dĩa5;
            this.dia5.Location = new System.Drawing.Point(58, 289);
            this.dia5.Name = "dia5";
            this.dia5.Size = new System.Drawing.Size(200, 26);
            this.dia5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia5.TabIndex = 25;
            this.dia5.TabStop = false;
            this.dia5.Tag = "5";
            this.dia5.Visible = false;
            this.dia5.Click += new System.EventHandler(this.dia_Click);
            // 
            // dia4
            // 
            this.dia4.BackColor = System.Drawing.Color.Transparent;
            this.dia4.Image = global::thap.Properties.Resources.dĩa4;
            this.dia4.Location = new System.Drawing.Point(58, 266);
            this.dia4.Name = "dia4";
            this.dia4.Size = new System.Drawing.Size(200, 25);
            this.dia4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia4.TabIndex = 24;
            this.dia4.TabStop = false;
            this.dia4.Tag = "4";
            this.dia4.Visible = false;
            this.dia4.Click += new System.EventHandler(this.dia_Click);
            // 
            // dia3
            // 
            this.dia3.BackColor = System.Drawing.Color.Transparent;
            this.dia3.Image = global::thap.Properties.Resources.dĩa3;
            this.dia3.Location = new System.Drawing.Point(58, 243);
            this.dia3.Name = "dia3";
            this.dia3.Size = new System.Drawing.Size(200, 25);
            this.dia3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia3.TabIndex = 23;
            this.dia3.TabStop = false;
            this.dia3.Tag = "3";
            this.dia3.Visible = false;
            this.dia3.Click += new System.EventHandler(this.dia_Click);
            // 
            // dia2
            // 
            this.dia2.BackColor = System.Drawing.Color.Transparent;
            this.dia2.Image = global::thap.Properties.Resources.dĩa2;
            this.dia2.Location = new System.Drawing.Point(58, 218);
            this.dia2.Name = "dia2";
            this.dia2.Size = new System.Drawing.Size(200, 25);
            this.dia2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia2.TabIndex = 22;
            this.dia2.TabStop = false;
            this.dia2.Tag = "2";
            this.dia2.Visible = false;
            this.dia2.Click += new System.EventHandler(this.dia_Click);
            // 
            // dia1
            // 
            this.dia1.BackColor = System.Drawing.Color.Transparent;
            this.dia1.Image = global::thap.Properties.Resources.dĩa1;
            this.dia1.Location = new System.Drawing.Point(58, 198);
            this.dia1.Name = "dia1";
            this.dia1.Size = new System.Drawing.Size(200, 24);
            this.dia1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia1.TabIndex = 21;
            this.dia1.TabStop = false;
            this.dia1.Tag = "1";
            this.dia1.Visible = false;
            this.dia1.Click += new System.EventHandler(this.dia_Click);
            // 
            // CotC
            // 
            this.CotC.BackColor = System.Drawing.Color.Transparent;
            this.CotC.Image = global::thap.Properties.Resources.cot1;
            this.CotC.Location = new System.Drawing.Point(525, 184);
            this.CotC.Name = "CotC";
            this.CotC.Size = new System.Drawing.Size(200, 210);
            this.CotC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CotC.TabIndex = 2;
            this.CotC.TabStop = false;
            this.CotC.Click += new System.EventHandler(this.Cot_Click);
            // 
            // CotB
            // 
            this.CotB.BackColor = System.Drawing.Color.Transparent;
            this.CotB.Image = global::thap.Properties.Resources.cot1;
            this.CotB.Location = new System.Drawing.Point(299, 184);
            this.CotB.Name = "CotB";
            this.CotB.Size = new System.Drawing.Size(200, 210);
            this.CotB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CotB.TabIndex = 1;
            this.CotB.TabStop = false;
            this.CotB.Click += new System.EventHandler(this.Cot_Click);
            // 
            // CotA
            // 
            this.CotA.BackColor = System.Drawing.Color.Transparent;
            this.CotA.Image = global::thap.Properties.Resources.cot1;
            this.CotA.Location = new System.Drawing.Point(58, 184);
            this.CotA.Name = "CotA";
            this.CotA.Size = new System.Drawing.Size(200, 210);
            this.CotA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CotA.TabIndex = 0;
            this.CotA.TabStop = false;
            this.CotA.Click += new System.EventHandler(this.Cot_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::thap.Properties.Resources.text_time;
            this.panel1.Location = new System.Drawing.Point(565, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 23);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(565, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 26);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(12, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 26);
            this.panel3.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::thap.Properties.Resources.text_dichmax;
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(565, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 26);
            this.panel4.TabIndex = 37;
            this.panel4.Visible = false;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(12, 59);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 31);
            this.panel5.TabIndex = 38;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Location = new System.Drawing.Point(248, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(245, 93);
            this.panel6.TabIndex = 39;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::thap.Properties.Resources.A;
            this.panel7.Location = new System.Drawing.Point(138, 400);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(30, 31);
            this.panel7.TabIndex = 40;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BackgroundImage = global::thap.Properties.Resources.B;
            this.panel8.Location = new System.Drawing.Point(385, 400);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(26, 31);
            this.panel8.TabIndex = 41;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = global::thap.Properties.Resources.C;
            this.panel9.Location = new System.Drawing.Point(606, 400);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(25, 31);
            this.panel9.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::thap.Properties.Resources.text_backmenu1;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(-2, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 27);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThapHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::thap.Properties.Resources.phongchinh1;
            this.ClientSize = new System.Drawing.Size(787, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solandichchuyentoida);
            this.Controls.Add(this.kho);
            this.Controls.Add(this.De);
            this.Controls.Add(this.muc);
            this.Controls.Add(this.dia8);
            this.Controls.Add(this.dia7);
            this.Controls.Add(this.dia6);
            this.Controls.Add(this.dia5);
            this.Controls.Add(this.dia4);
            this.Controls.Add(this.dia3);
            this.Controls.Add(this.dia2);
            this.Controls.Add(this.dia1);
            this.Controls.Add(this.tamdung);
            this.Controls.Add(this.play);
            this.Controls.Add(this.sodia);
            this.Controls.Add(this.solandich);
            this.Controls.Add(this.thoigian);
            this.Controls.Add(this.CotC);
            this.Controls.Add(this.CotB);
            this.Controls.Add(this.CotA);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ThapHanoi";
            this.Text = "Tháp Hà Nội";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sodia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CotA;
        private System.Windows.Forms.PictureBox CotB;
        private System.Windows.Forms.PictureBox CotC;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label thoigian;
        private System.Windows.Forms.Label solandich;
        private System.Windows.Forms.NumericUpDown sodia;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button tamdung;
        private System.Windows.Forms.PictureBox dia1;
        private System.Windows.Forms.PictureBox dia2;
        private System.Windows.Forms.PictureBox dia3;
        private System.Windows.Forms.PictureBox dia4;
        private System.Windows.Forms.PictureBox dia5;
        private System.Windows.Forms.PictureBox dia6;
        private System.Windows.Forms.PictureBox dia7;
        private System.Windows.Forms.PictureBox dia8;
        public System.Windows.Forms.Timer counttime;
        private System.Windows.Forms.Label muc;
        private System.Windows.Forms.Button De;
        private System.Windows.Forms.Button kho;
        private System.Windows.Forms.Label solandichchuyentoida;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Button button1;
    }
}

