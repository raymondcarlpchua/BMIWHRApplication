namespace BMIandWHRApplication
{
    partial class FormCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optF = new System.Windows.Forms.RadioButton();
            this.optM = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHip = new System.Windows.Forms.TextBox();
            this.txtWaist = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBMI = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnWHR = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblBMID = new System.Windows.Forms.Label();
            this.lblWHR = new System.Windows.Forms.Label();
            this.lblWHRD = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.healthGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodyMassIndexBMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waistAndHipRatioWHRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthyTipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underweightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overweightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obeseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wHRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUsedThisApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = " BMI and WHR Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.optF);
            this.groupBox1.Controls.Add(this.optM);
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(31, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 48);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // optF
            // 
            this.optF.AutoSize = true;
            this.optF.Location = new System.Drawing.Point(187, 15);
            this.optF.Name = "optF";
            this.optF.Size = new System.Drawing.Size(86, 23);
            this.optF.TabIndex = 23;
            this.optF.TabStop = true;
            this.optF.Text = "Female";
            this.optF.UseVisualStyleBackColor = true;
            this.optF.CheckedChanged += new System.EventHandler(this.optF_CheckedChanged);
            // 
            // optM
            // 
            this.optM.AutoSize = true;
            this.optM.Location = new System.Drawing.Point(65, 15);
            this.optM.Name = "optM";
            this.optM.Size = new System.Drawing.Size(68, 23);
            this.optM.TabIndex = 22;
            this.optM.TabStop = true;
            this.optM.Text = "Male";
            this.optM.UseVisualStyleBackColor = true;
            this.optM.CheckedChanged += new System.EventHandler(this.optM_CheckedChanged);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.Font = new System.Drawing.Font("Stencil", 12F);
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Location = new System.Drawing.Point(76, 146);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(42, 26);
            this.txtAge.TabIndex = 40;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(28, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Age:";
            // 
            // txtHip
            // 
            this.txtHip.ForeColor = System.Drawing.Color.Black;
            this.txtHip.Location = new System.Drawing.Point(263, 334);
            this.txtHip.Name = "txtHip";
            this.txtHip.Size = new System.Drawing.Size(100, 20);
            this.txtHip.TabIndex = 37;
            // 
            // txtWaist
            // 
            this.txtWaist.ForeColor = System.Drawing.Color.Black;
            this.txtWaist.Location = new System.Drawing.Point(295, 374);
            this.txtWaist.Name = "txtWaist";
            this.txtWaist.Size = new System.Drawing.Size(100, 20);
            this.txtWaist.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(27, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Enter Hip Circumference :\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Enter Waist Circumference :\r\n";
            // 
            // txtHeight
            // 
            this.txtHeight.ForeColor = System.Drawing.Color.Black;
            this.txtHeight.Location = new System.Drawing.Point(160, 254);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(48, 20);
            this.txtHeight.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Enter Height:";
            // 
            // txtWeight
            // 
            this.txtWeight.ForeColor = System.Drawing.Color.Black;
            this.txtWeight.Location = new System.Drawing.Point(161, 296);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(48, 20);
            this.txtWeight.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Enter Weight:";
            // 
            // btnBMI
            // 
            this.btnBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMI.Location = new System.Drawing.Point(31, 415);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(178, 42);
            this.btnBMI.TabIndex = 42;
            this.btnBMI.Text = "Calculate BMI";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(569, 415);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(184, 42);
            this.btnReset.TabIndex = 43;
            this.btnReset.Text = "Reset Data";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnWHR
            // 
            this.btnWHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWHR.Location = new System.Drawing.Point(247, 415);
            this.btnWHR.Name = "btnWHR";
            this.btnWHR.Size = new System.Drawing.Size(178, 42);
            this.btnWHR.TabIndex = 44;
            this.btnWHR.Text = "Calculate WHR";
            this.btnWHR.UseVisualStyleBackColor = true;
            this.btnWHR.Click += new System.EventHandler(this.btnWHR_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(789, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 42);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(508, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Your BMI Result :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(810, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 19);
            this.label7.TabIndex = 47;
            this.label7.Text = "Your WHR Result :";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(548, 291);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(71, 25);
            this.lblBMI.TabIndex = 48;
            this.lblBMI.Text = "lblBMI";
            this.lblBMI.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblBMID
            // 
            this.lblBMID.AutoSize = true;
            this.lblBMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMID.Location = new System.Drawing.Point(425, 328);
            this.lblBMID.Name = "lblBMID";
            this.lblBMID.Size = new System.Drawing.Size(82, 25);
            this.lblBMID.TabIndex = 49;
            this.lblBMID.Text = "label10";
            // 
            // lblWHR
            // 
            this.lblWHR.AutoSize = true;
            this.lblWHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWHR.Location = new System.Drawing.Point(839, 291);
            this.lblWHR.Name = "lblWHR";
            this.lblWHR.Size = new System.Drawing.Size(82, 25);
            this.lblWHR.TabIndex = 50;
            this.lblWHR.Text = "label11";
            // 
            // lblWHRD
            // 
            this.lblWHRD.AutoSize = true;
            this.lblWHRD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWHRD.Location = new System.Drawing.Point(839, 363);
            this.lblWHRD.Name = "lblWHRD";
            this.lblWHRD.Size = new System.Drawing.Size(82, 25);
            this.lblWHRD.TabIndex = 51;
            this.lblWHRD.Text = "label12";
            this.lblWHRD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pb1
            // 
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb1.Location = new System.Drawing.Point(526, 47);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(214, 202);
            this.pb1.TabIndex = 52;
            this.pb1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-129, 582);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 144);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(761, 50);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(212, 199);
            this.pb2.TabIndex = 54;
            this.pb2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healthGuideToolStripMenuItem,
            this.healthyTipsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // healthGuideToolStripMenuItem
            // 
            this.healthGuideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bodyMassIndexBMIToolStripMenuItem,
            this.waistAndHipRatioWHRToolStripMenuItem});
            this.healthGuideToolStripMenuItem.Name = "healthGuideToolStripMenuItem";
            this.healthGuideToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.healthGuideToolStripMenuItem.Text = "Health Guide";
            // 
            // bodyMassIndexBMIToolStripMenuItem
            // 
            this.bodyMassIndexBMIToolStripMenuItem.Name = "bodyMassIndexBMIToolStripMenuItem";
            this.bodyMassIndexBMIToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.bodyMassIndexBMIToolStripMenuItem.Text = " Body Mass Index (BMI)";
            this.bodyMassIndexBMIToolStripMenuItem.Click += new System.EventHandler(this.bodyMassIndexBMIToolStripMenuItem_Click);
            // 
            // waistAndHipRatioWHRToolStripMenuItem
            // 
            this.waistAndHipRatioWHRToolStripMenuItem.Name = "waistAndHipRatioWHRToolStripMenuItem";
            this.waistAndHipRatioWHRToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.waistAndHipRatioWHRToolStripMenuItem.Text = "Waist and Hip Ratio (WHR)";
            this.waistAndHipRatioWHRToolStripMenuItem.Click += new System.EventHandler(this.waistAndHipRatioWHRToolStripMenuItem_Click);
            // 
            // healthyTipsToolStripMenuItem
            // 
            this.healthyTipsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMIToolStripMenuItem,
            this.wHRToolStripMenuItem});
            this.healthyTipsToolStripMenuItem.Name = "healthyTipsToolStripMenuItem";
            this.healthyTipsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.healthyTipsToolStripMenuItem.Text = "Healthy Tips";
            // 
            // bMIToolStripMenuItem
            // 
            this.bMIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.underweightToolStripMenuItem,
            this.overweightToolStripMenuItem,
            this.obeseToolStripMenuItem});
            this.bMIToolStripMenuItem.Name = "bMIToolStripMenuItem";
            this.bMIToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.bMIToolStripMenuItem.Text = "BMI";
            // 
            // underweightToolStripMenuItem
            // 
            this.underweightToolStripMenuItem.Name = "underweightToolStripMenuItem";
            this.underweightToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.underweightToolStripMenuItem.Text = "Underweight";
            this.underweightToolStripMenuItem.Click += new System.EventHandler(this.underweightToolStripMenuItem_Click);
            // 
            // overweightToolStripMenuItem
            // 
            this.overweightToolStripMenuItem.Name = "overweightToolStripMenuItem";
            this.overweightToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.overweightToolStripMenuItem.Text = "Overweight";
            this.overweightToolStripMenuItem.Click += new System.EventHandler(this.overweightToolStripMenuItem_Click);
            // 
            // obeseToolStripMenuItem
            // 
            this.obeseToolStripMenuItem.Name = "obeseToolStripMenuItem";
            this.obeseToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.obeseToolStripMenuItem.Text = "Overweight";
            // 
            // wHRToolStripMenuItem
            // 
            this.wHRToolStripMenuItem.Name = "wHRToolStripMenuItem";
            this.wHRToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.wHRToolStripMenuItem.Text = "WHR";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUsedThisApplicationToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUsedThisApplicationToolStripMenuItem
            // 
            this.howToUsedThisApplicationToolStripMenuItem.Name = "howToUsedThisApplicationToolStripMenuItem";
            this.howToUsedThisApplicationToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.howToUsedThisApplicationToolStripMenuItem.Text = "How to used this application ?";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(28, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 56;
            this.label9.Text = "Hi ,";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(70, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(110, 26);
            this.textBox1.TabIndex = 57;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BMIandWHRApplication.Properties.Resources.bmi_login_background;
            this.ClientSize = new System.Drawing.Size(985, 469);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lblWHRD);
            this.Controls.Add(this.lblWHR);
            this.Controls.Add(this.lblBMID);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWHR);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHip);
            this.Controls.Add(this.txtWaist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCalculator";
            this.Text = "FormCalculator";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optF;
        private System.Windows.Forms.RadioButton optM;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHip;
        private System.Windows.Forms.TextBox txtWaist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnWHR;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblBMID;
        private System.Windows.Forms.Label lblWHR;
        private System.Windows.Forms.Label lblWHRD;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem healthGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodyMassIndexBMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waistAndHipRatioWHRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthyTipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underweightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overweightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem obeseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wHRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUsedThisApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;

    }
}