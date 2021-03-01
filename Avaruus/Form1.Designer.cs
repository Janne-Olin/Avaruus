namespace Avaruus
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.checkBoxBH = new System.Windows.Forms.CheckBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxXVel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxYVel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxYPos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxXPos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAccuracy = new System.Windows.Forms.Label();
            this.trackBarAccuracy = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 673);
            this.panel1.TabIndex = 0;
            // 
            // buttonUI
            // 
            this.buttonUI.Location = new System.Drawing.Point(12, 12);
            this.buttonUI.Name = "buttonUI";
            this.buttonUI.Size = new System.Drawing.Size(98, 29);
            this.buttonUI.TabIndex = 1;
            this.buttonUI.Text = "Avaa / Sulje";
            this.buttonUI.UseVisualStyleBackColor = true;
            this.buttonUI.Click += new System.EventHandler(this.buttonUI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nimi";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(123, 60);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(229, 27);
            this.textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Massa";
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(123, 94);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(229, 27);
            this.textBoxMass.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mitätön (Asteroidi)",
            "Pieni (Kuu)",
            "Pienehkö (Kiviplaneetta)",
            "Keskisuuri (Kaasuplaneetta)",
            "Suurehko (Tähti)",
            "Suuri (Valtava tähti)",
            "Valtava (Keskisuuri musta aukko)",
            "Hirviömäinen (Supermassiivinen musta aukko)",
            "Aurinkokunta"});
            this.comboBox1.Location = new System.Drawing.Point(9, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(343, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.buttonSettings);
            this.groupBox1.Controls.Add(this.checkBoxBH);
            this.groupBox1.Controls.Add(this.buttonColor);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxXVel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxYVel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxYPos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxXPos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxMass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 347);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(9, 322);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 20);
            this.labelError.TabIndex = 20;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(3, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(368, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(258, 283);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(94, 29);
            this.buttonSettings.TabIndex = 18;
            this.buttonSettings.Text = "Asetukset";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // checkBoxBH
            // 
            this.checkBoxBH.AutoSize = true;
            this.checkBoxBH.Location = new System.Drawing.Point(9, 241);
            this.checkBoxBH.Name = "checkBoxBH";
            this.checkBoxBH.Size = new System.Drawing.Size(114, 24);
            this.checkBoxBH.TabIndex = 17;
            this.checkBoxBH.Text = "Musta aukko";
            this.checkBoxBH.UseVisualStyleBackColor = true;
            this.checkBoxBH.CheckedChanged += new System.EventHandler(this.checkBoxBH_CheckedChanged);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(258, 241);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(94, 29);
            this.buttonColor.TabIndex = 16;
            this.buttonColor.Text = "Väri";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(9, 283);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Lisää";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxXVel
            // 
            this.textBoxXVel.Location = new System.Drawing.Point(150, 200);
            this.textBoxXVel.Name = "textBoxXVel";
            this.textBoxXVel.Size = new System.Drawing.Size(82, 27);
            this.textBoxXVel.TabIndex = 10;
            this.textBoxXVel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Y:";
            // 
            // textBoxYVel
            // 
            this.textBoxYVel.Location = new System.Drawing.Point(270, 200);
            this.textBoxYVel.Name = "textBoxYVel";
            this.textBoxYVel.Size = new System.Drawing.Size(82, 27);
            this.textBoxYVel.TabIndex = 13;
            this.textBoxYVel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nopeus (m/s)";
            // 
            // textBoxYPos
            // 
            this.textBoxYPos.Location = new System.Drawing.Point(270, 165);
            this.textBoxYPos.Name = "textBoxYPos";
            this.textBoxYPos.Size = new System.Drawing.Size(82, 27);
            this.textBoxYPos.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "X:";
            // 
            // textBoxXPos
            // 
            this.textBoxXPos.Location = new System.Drawing.Point(150, 165);
            this.textBoxXPos.Name = "textBoxXPos";
            this.textBoxXPos.Size = new System.Drawing.Size(82, 27);
            this.textBoxXPos.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sijainti";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(123, 128);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(229, 27);
            this.textBoxD.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Halkaisija";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.LightSteelBlue;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 2000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.labelAccuracy);
            this.groupBox2.Controls.Add(this.trackBarAccuracy);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.labelSpeed);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.trackBarSpeed);
            this.groupBox2.Location = new System.Drawing.Point(392, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 347);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // labelAccuracy
            // 
            this.labelAccuracy.AutoSize = true;
            this.labelAccuracy.Location = new System.Drawing.Point(304, 82);
            this.labelAccuracy.Name = "labelAccuracy";
            this.labelAccuracy.Size = new System.Drawing.Size(48, 20);
            this.labelAccuracy.TabIndex = 5;
            this.labelAccuracy.Text = "10 ms";
            // 
            // trackBarAccuracy
            // 
            this.trackBarAccuracy.Location = new System.Drawing.Point(76, 82);
            this.trackBarAccuracy.Maximum = 4;
            this.trackBarAccuracy.Name = "trackBarAccuracy";
            this.trackBarAccuracy.Size = new System.Drawing.Size(221, 56);
            this.trackBarAccuracy.TabIndex = 4;
            this.trackBarAccuracy.Value = 2;
            this.trackBarAccuracy.Scroll += new System.EventHandler(this.trackBarAccyracy_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tarkkuus";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(303, 29);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(56, 20);
            this.labelSpeed.TabIndex = 2;
            this.labelSpeed.Text = "* 1 milj";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nopeus";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(72, 26);
            this.trackBarSpeed.Maximum = 6;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(225, 56);
            this.trackBarSpeed.TabIndex = 0;
            this.trackBarSpeed.Value = 4;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonUI);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Avaruus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxXVel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxYVel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxYPos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxXPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox checkBoxBH;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TrackBar trackBarAccuracy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelAccuracy;
    }
}

