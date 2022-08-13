namespace WindowsFormsApplication3
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
            this.components = new System.ComponentModel.Container();
            this.bn_Conect = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGoto = new System.Windows.Forms.Button();
            this.groupBoxGOTO = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPosition = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelVars = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RESET_POS = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelConection = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxJogRigth = new System.Windows.Forms.CheckBox();
            this.numericUpDownJogSpeed = new System.Windows.Forms.NumericUpDown();
            this.checkBoxJogLeft = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonEnergize = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStop = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.gbStepMode = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.groupBoxGOTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosition)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJogSpeed)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStop)).BeginInit();
            this.gbStepMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn_Conect
            // 
            this.bn_Conect.Location = new System.Drawing.Point(15, 25);
            this.bn_Conect.Name = "bn_Conect";
            this.bn_Conect.Size = new System.Drawing.Size(75, 23);
            this.bn_Conect.TabIndex = 0;
            this.bn_Conect.Text = "Connect";
            this.bn_Conect.UseVisualStyleBackColor = true;
            this.bn_Conect.Click += new System.EventHandler(this.bn_Conect_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(400, 14);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(94, 23);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "HOME";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonGoto
            // 
            this.buttonGoto.Location = new System.Drawing.Point(6, 16);
            this.buttonGoto.Name = "buttonGoto";
            this.buttonGoto.Size = new System.Drawing.Size(75, 23);
            this.buttonGoto.TabIndex = 2;
            this.buttonGoto.Text = "RUN";
            this.buttonGoto.UseVisualStyleBackColor = true;
            this.buttonGoto.Click += new System.EventHandler(this.buttonGoto_Click);
            // 
            // groupBoxGOTO
            // 
            this.groupBoxGOTO.Controls.Add(this.label2);
            this.groupBoxGOTO.Controls.Add(this.label1);
            this.groupBoxGOTO.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxGOTO.Controls.Add(this.numericUpDownPosition);
            this.groupBoxGOTO.Controls.Add(this.buttonGoto);
            this.groupBoxGOTO.Location = new System.Drawing.Point(19, 126);
            this.groupBoxGOTO.Name = "groupBoxGOTO";
            this.groupBoxGOTO.Size = new System.Drawing.Size(225, 72);
            this.groupBoxGOTO.TabIndex = 3;
            this.groupBoxGOTO.TabStop = false;
            this.groupBoxGOTO.Text = "GOTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Position";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(143, 42);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownSpeed.TabIndex = 5;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            // 
            // numericUpDownPosition
            // 
            this.numericUpDownPosition.Location = new System.Drawing.Point(144, 16);
            this.numericUpDownPosition.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPosition.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownPosition.Name = "numericUpDownPosition";
            this.numericUpDownPosition.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownPosition.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelVars);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Location = new System.Drawing.Point(14, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 333);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATUS";
            // 
            // labelVars
            // 
            this.labelVars.Location = new System.Drawing.Point(8, 18);
            this.labelVars.Name = "labelVars";
            this.labelVars.Size = new System.Drawing.Size(176, 312);
            this.labelVars.TabIndex = 1;
            this.labelVars.Text = "Vars";
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(184, 16);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(307, 314);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RESET_POS);
            this.groupBox2.Controls.Add(this.labelPosition);
            this.groupBox2.Location = new System.Drawing.Point(214, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Position";
            // 
            // RESET_POS
            // 
            this.RESET_POS.Location = new System.Drawing.Point(80, 19);
            this.RESET_POS.Name = "RESET_POS";
            this.RESET_POS.Size = new System.Drawing.Size(94, 23);
            this.RESET_POS.TabIndex = 2;
            this.RESET_POS.Text = "RESET";
            this.RESET_POS.UseVisualStyleBackColor = true;
            this.RESET_POS.Click += new System.EventHandler(this.RESET_POS_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(17, 23);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(13, 13);
            this.labelPosition.TabIndex = 0;
            this.labelPosition.Text = "0";
            // 
            // labelConection
            // 
            this.labelConection.AutoSize = true;
            this.labelConection.Location = new System.Drawing.Point(19, 23);
            this.labelConection.Name = "labelConection";
            this.labelConection.Size = new System.Drawing.Size(23, 13);
            this.labelConection.TabIndex = 0;
            this.labelConection.Text = "NO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelConection);
            this.groupBox3.Location = new System.Drawing.Point(96, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 48);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conection";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.checkBoxJogRigth);
            this.groupBox5.Controls.Add(this.numericUpDownJogSpeed);
            this.groupBox5.Controls.Add(this.checkBoxJogLeft);
            this.groupBox5.Location = new System.Drawing.Point(290, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 80);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "JOG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Speed";
            // 
            // checkBoxJogRigth
            // 
            this.checkBoxJogRigth.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxJogRigth.Location = new System.Drawing.Point(116, 21);
            this.checkBoxJogRigth.Name = "checkBoxJogRigth";
            this.checkBoxJogRigth.Size = new System.Drawing.Size(80, 23);
            this.checkBoxJogRigth.TabIndex = 7;
            this.checkBoxJogRigth.Text = "--->";
            this.checkBoxJogRigth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxJogRigth.UseVisualStyleBackColor = true;
            this.checkBoxJogRigth.CheckedChanged += new System.EventHandler(this.checkBoxJogRigth_CheckedChanged);
            // 
            // numericUpDownJogSpeed
            // 
            this.numericUpDownJogSpeed.Location = new System.Drawing.Point(116, 50);
            this.numericUpDownJogSpeed.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numericUpDownJogSpeed.Name = "numericUpDownJogSpeed";
            this.numericUpDownJogSpeed.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownJogSpeed.TabIndex = 8;
            this.numericUpDownJogSpeed.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // checkBoxJogLeft
            // 
            this.checkBoxJogLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxJogLeft.Location = new System.Drawing.Point(23, 21);
            this.checkBoxJogLeft.Name = "checkBoxJogLeft";
            this.checkBoxJogLeft.Size = new System.Drawing.Size(80, 23);
            this.checkBoxJogLeft.TabIndex = 6;
            this.checkBoxJogLeft.Text = "<---";
            this.checkBoxJogLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxJogLeft.UseVisualStyleBackColor = true;
            this.checkBoxJogLeft.CheckedChanged += new System.EventHandler(this.checkBoxJogLeft_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonEnergize
            // 
            this.buttonEnergize.Location = new System.Drawing.Point(400, 43);
            this.buttonEnergize.Name = "buttonEnergize";
            this.buttonEnergize.Size = new System.Drawing.Size(94, 23);
            this.buttonEnergize.TabIndex = 6;
            this.buttonEnergize.Text = "DEENERGIZE";
            this.buttonEnergize.UseVisualStyleBackColor = true;
            this.buttonEnergize.Click += new System.EventHandler(this.buttonEnergize_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.numericUpDownStop);
            this.groupBox4.Controls.Add(this.numericUpDownDelay);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.numericUpDownInterval);
            this.groupBox4.Location = new System.Drawing.Point(15, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(496, 79);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DRC";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(97, 16);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownInterval.TabIndex = 5;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interval (in steps)";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(97, 40);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(257, 40);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delay (in ms)";
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Location = new System.Drawing.Point(255, 16);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownDelay.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownDelay.TabIndex = 11;
            this.numericUpDownDelay.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // numericUpDownStop
            // 
            this.numericUpDownStop.Location = new System.Drawing.Point(404, 16);
            this.numericUpDownStop.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStop.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownStop.Name = "numericUpDownStop";
            this.numericUpDownStop.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownStop.TabIndex = 12;
            this.numericUpDownStop.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stop at";
            // 
            // gbStepMode
            // 
            this.gbStepMode.Controls.Add(this.radioButton9);
            this.gbStepMode.Controls.Add(this.radioButton8);
            this.gbStepMode.Controls.Add(this.radioButton7);
            this.gbStepMode.Controls.Add(this.radioButton6);
            this.gbStepMode.Controls.Add(this.radioButton5);
            this.gbStepMode.Controls.Add(this.radioButton4);
            this.gbStepMode.Controls.Add(this.radioButton3);
            this.gbStepMode.Controls.Add(this.radioButton2);
            this.gbStepMode.Controls.Add(this.radioButton1);
            this.gbStepMode.Location = new System.Drawing.Point(15, 72);
            this.gbStepMode.Name = "gbStepMode";
            this.gbStepMode.Size = new System.Drawing.Size(491, 48);
            this.gbStepMode.TabIndex = 8;
            this.gbStepMode.TabStop = false;
            this.gbStepMode.Text = "Step Mode";
            this.gbStepMode.Validated += new System.EventHandler(this.gbStepMode_Validated);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "Full";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(72, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "Half";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(118, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(42, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "2";
            this.radioButton3.Text = "1/4";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(162, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(42, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "3";
            this.radioButton4.Text = "1/8";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(206, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(48, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "4";
            this.radioButton5.Text = "1/16";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(256, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(48, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "5";
            this.radioButton6.Text = "1/32";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(306, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(48, 17);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Tag = "7";
            this.radioButton7.Text = "1/64";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(356, 19);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(54, 17);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Tag = "8";
            this.radioButton8.Text = "1/128";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(412, 19);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(54, 17);
            this.radioButton9.TabIndex = 8;
            this.radioButton9.TabStop = true;
            this.radioButton9.Tag = "9";
            this.radioButton9.Text = "1/256";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 684);
            this.Controls.Add(this.gbStepMode);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonEnergize);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxGOTO);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.bn_Conect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxGOTO.ResumeLayout(false);
            this.groupBoxGOTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosition)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJogSpeed)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStop)).EndInit();
            this.gbStepMode.ResumeLayout(false);
            this.gbStepMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bn_Conect;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGoto;
        private System.Windows.Forms.GroupBox groupBoxGOTO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelConection;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownPosition;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxJogRigth;
        private System.Windows.Forms.CheckBox checkBoxJogLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownJogSpeed;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelVars;
        private System.Windows.Forms.Button buttonEnergize;
        private System.Windows.Forms.Button RESET_POS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownStop;
        private System.Windows.Forms.GroupBox gbStepMode;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

