namespace MyRGB
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.staticLiveCheck = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.rgbNum = new System.Windows.Forms.NumericUpDown();
            this.staticColorWheel = new Unclassified.UI.ColorWheel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.theaterChaseRainbowRadio = new System.Windows.Forms.RadioButton();
            this.theaterChaseStaticRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.theaterChaseDelayNum = new System.Windows.Forms.NumericUpDown();
            this.applyMode2Btn = new System.Windows.Forms.Button();
            this.theaterColorWheel = new Unclassified.UI.ColorWheel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rainbowCycleCb = new System.Windows.Forms.CheckBox();
            this.rainbowApplyBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rainbowDelayNum = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.wipeApply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.wipeDelayNum = new System.Windows.Forms.NumericUpDown();
            this.wipeColorWheel = new Unclassified.UI.ColorWheel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.divideNum = new System.Windows.Forms.NumericUpDown();
            this.audioApplyBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbNum)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theaterChaseDelayNum)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rainbowDelayNum)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wipeDelayNum)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divideNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "S";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(268, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 401);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.staticLiveCheck);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.radioButton10);
            this.tabPage1.Controls.Add(this.radioButton9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rgbNum);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.staticColorWheel);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Static";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // staticLiveCheck
            // 
            this.staticLiveCheck.AutoSize = true;
            this.staticLiveCheck.Location = new System.Drawing.Point(304, 271);
            this.staticLiveCheck.Name = "staticLiveCheck";
            this.staticLiveCheck.Size = new System.Drawing.Size(68, 34);
            this.staticLiveCheck.TabIndex = 24;
            this.staticLiveCheck.Text = "Live";
            this.staticLiveCheck.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 41);
            this.button3.TabIndex = 23;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 46);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(144, 34);
            this.radioButton10.TabIndex = 22;
            this.radioButton10.Text = "Specific LED";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Checked = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 6);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(97, 34);
            this.radioButton9.TabIndex = 21;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "All LED";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // rgbNum
            // 
            this.rgbNum.Location = new System.Drawing.Point(156, 46);
            this.rgbNum.Name = "rgbNum";
            this.rgbNum.Size = new System.Drawing.Size(147, 35);
            this.rgbNum.TabIndex = 19;
            // 
            // staticColorWheel
            // 
            this.staticColorWheel.Hue = ((byte)(0));
            this.staticColorWheel.Lightness = ((byte)(128));
            this.staticColorWheel.Location = new System.Drawing.Point(9, 90);
            this.staticColorWheel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.staticColorWheel.Name = "staticColorWheel";
            this.staticColorWheel.Saturation = ((byte)(255));
            this.staticColorWheel.SecondaryHues = null;
            this.staticColorWheel.Size = new System.Drawing.Size(241, 238);
            this.staticColorWheel.TabIndex = 0;
            this.staticColorWheel.Text = "colorWheel1";
            this.staticColorWheel.HSLChanged += new System.EventHandler(this.staticColorWheel_HSLChanged);
            this.staticColorWheel.Click += new System.EventHandler(this.colorWheel1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.theaterChaseRainbowRadio);
            this.tabPage2.Controls.Add(this.theaterChaseStaticRadio);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.theaterChaseDelayNum);
            this.tabPage2.Controls.Add(this.applyMode2Btn);
            this.tabPage2.Controls.Add(this.theaterColorWheel);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Theater chase";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // theaterChaseRainbowRadio
            // 
            this.theaterChaseRainbowRadio.AutoSize = true;
            this.theaterChaseRainbowRadio.Location = new System.Drawing.Point(77, 59);
            this.theaterChaseRainbowRadio.Name = "theaterChaseRainbowRadio";
            this.theaterChaseRainbowRadio.Size = new System.Drawing.Size(111, 34);
            this.theaterChaseRainbowRadio.TabIndex = 27;
            this.theaterChaseRainbowRadio.Text = "Rainbow";
            this.theaterChaseRainbowRadio.UseVisualStyleBackColor = true;
            // 
            // theaterChaseStaticRadio
            // 
            this.theaterChaseStaticRadio.AutoSize = true;
            this.theaterChaseStaticRadio.Checked = true;
            this.theaterChaseStaticRadio.Location = new System.Drawing.Point(77, 99);
            this.theaterChaseStaticRadio.Name = "theaterChaseStaticRadio";
            this.theaterChaseStaticRadio.Size = new System.Drawing.Size(133, 34);
            this.theaterChaseStaticRadio.TabIndex = 26;
            this.theaterChaseStaticRadio.TabStop = true;
            this.theaterChaseStaticRadio.Text = "Static color";
            this.theaterChaseStaticRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "Delay";
            // 
            // theaterChaseDelayNum
            // 
            this.theaterChaseDelayNum.Location = new System.Drawing.Point(77, 18);
            this.theaterChaseDelayNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.theaterChaseDelayNum.Name = "theaterChaseDelayNum";
            this.theaterChaseDelayNum.Size = new System.Drawing.Size(120, 35);
            this.theaterChaseDelayNum.TabIndex = 24;
            this.theaterChaseDelayNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // applyMode2Btn
            // 
            this.applyMode2Btn.Location = new System.Drawing.Point(6, 311);
            this.applyMode2Btn.Name = "applyMode2Btn";
            this.applyMode2Btn.Size = new System.Drawing.Size(95, 41);
            this.applyMode2Btn.TabIndex = 20;
            this.applyMode2Btn.Text = "Apply";
            this.applyMode2Btn.UseVisualStyleBackColor = true;
            this.applyMode2Btn.Click += new System.EventHandler(this.applyMode2Btn_Click);
            // 
            // theaterColorWheel
            // 
            this.theaterColorWheel.Hue = ((byte)(0));
            this.theaterColorWheel.Lightness = ((byte)(128));
            this.theaterColorWheel.Location = new System.Drawing.Point(219, 28);
            this.theaterColorWheel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.theaterColorWheel.Name = "theaterColorWheel";
            this.theaterColorWheel.Saturation = ((byte)(255));
            this.theaterColorWheel.SecondaryHues = null;
            this.theaterColorWheel.Size = new System.Drawing.Size(241, 238);
            this.theaterColorWheel.TabIndex = 21;
            this.theaterColorWheel.Text = "colorWheel2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rainbowCycleCb);
            this.tabPage3.Controls.Add(this.rainbowApplyBtn);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.rainbowDelayNum);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rainbow";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rainbowCycleCb
            // 
            this.rainbowCycleCb.AutoSize = true;
            this.rainbowCycleCb.Location = new System.Drawing.Point(77, 68);
            this.rainbowCycleCb.Name = "rainbowCycleCb";
            this.rainbowCycleCb.Size = new System.Drawing.Size(81, 34);
            this.rainbowCycleCb.TabIndex = 30;
            this.rainbowCycleCb.Text = "Cycle";
            this.rainbowCycleCb.UseVisualStyleBackColor = true;
            // 
            // rainbowApplyBtn
            // 
            this.rainbowApplyBtn.Location = new System.Drawing.Point(6, 311);
            this.rainbowApplyBtn.Name = "rainbowApplyBtn";
            this.rainbowApplyBtn.Size = new System.Drawing.Size(95, 41);
            this.rainbowApplyBtn.TabIndex = 28;
            this.rainbowApplyBtn.Text = "Apply";
            this.rainbowApplyBtn.UseVisualStyleBackColor = true;
            this.rainbowApplyBtn.Click += new System.EventHandler(this.rainbowApplyBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "Delay";
            // 
            // rainbowDelayNum
            // 
            this.rainbowDelayNum.Location = new System.Drawing.Point(77, 6);
            this.rainbowDelayNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.rainbowDelayNum.Name = "rainbowDelayNum";
            this.rainbowDelayNum.Size = new System.Drawing.Size(120, 35);
            this.rainbowDelayNum.TabIndex = 26;
            this.rainbowDelayNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.wipeApply);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.wipeDelayNum);
            this.tabPage4.Controls.Add(this.wipeColorWheel);
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(756, 358);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Wipe";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // wipeApply
            // 
            this.wipeApply.Location = new System.Drawing.Point(259, 270);
            this.wipeApply.Name = "wipeApply";
            this.wipeApply.Size = new System.Drawing.Size(95, 41);
            this.wipeApply.TabIndex = 31;
            this.wipeApply.Text = "Apply";
            this.wipeApply.UseVisualStyleBackColor = true;
            this.wipeApply.Click += new System.EventHandler(this.wipeApply_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 30);
            this.label5.TabIndex = 29;
            this.label5.Text = "Delay";
            // 
            // wipeDelayNum
            // 
            this.wipeDelayNum.Location = new System.Drawing.Point(104, 28);
            this.wipeDelayNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.wipeDelayNum.Name = "wipeDelayNum";
            this.wipeDelayNum.Size = new System.Drawing.Size(120, 35);
            this.wipeDelayNum.TabIndex = 28;
            this.wipeDelayNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // wipeColorWheel
            // 
            this.wipeColorWheel.Hue = ((byte)(0));
            this.wipeColorWheel.Lightness = ((byte)(127));
            this.wipeColorWheel.Location = new System.Drawing.Point(9, 73);
            this.wipeColorWheel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.wipeColorWheel.Name = "wipeColorWheel";
            this.wipeColorWheel.Saturation = ((byte)(255));
            this.wipeColorWheel.SecondaryHues = null;
            this.wipeColorWheel.Size = new System.Drawing.Size(241, 238);
            this.wipeColorWheel.TabIndex = 30;
            this.wipeColorWheel.Text = "colorWheel2";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(756, 358);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Flash";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.divideNum);
            this.tabPage6.Controls.Add(this.audioApplyBtn);
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(756, 358);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Audio";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 30);
            this.label6.TabIndex = 34;
            this.label6.Text = "Divide";
            // 
            // divideNum
            // 
            this.divideNum.Location = new System.Drawing.Point(178, 117);
            this.divideNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.divideNum.Name = "divideNum";
            this.divideNum.Size = new System.Drawing.Size(120, 35);
            this.divideNum.TabIndex = 33;
            this.divideNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // audioApplyBtn
            // 
            this.audioApplyBtn.Location = new System.Drawing.Point(77, 190);
            this.audioApplyBtn.Name = "audioApplyBtn";
            this.audioApplyBtn.Size = new System.Drawing.Size(95, 41);
            this.audioApplyBtn.TabIndex = 32;
            this.audioApplyBtn.Text = "Apply";
            this.audioApplyBtn.UseVisualStyleBackColor = true;
            this.audioApplyBtn.Click += new System.EventHandler(this.audioApplyBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 334);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 425);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbNum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theaterChaseDelayNum)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rainbowDelayNum)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wipeDelayNum)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divideNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Unclassified.UI.ColorWheel staticColorWheel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.NumericUpDown rgbNum;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton theaterChaseRainbowRadio;
        private System.Windows.Forms.RadioButton theaterChaseStaticRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown theaterChaseDelayNum;
        private Unclassified.UI.ColorWheel theaterColorWheel;
        private System.Windows.Forms.Button applyMode2Btn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button rainbowApplyBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown rainbowDelayNum;
        private System.Windows.Forms.CheckBox staticLiveCheck;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox rainbowCycleCb;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button wipeApply;
        private Unclassified.UI.ColorWheel wipeColorWheel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown wipeDelayNum;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button audioApplyBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown divideNum;
    }
}

