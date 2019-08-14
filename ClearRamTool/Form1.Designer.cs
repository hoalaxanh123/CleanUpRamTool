namespace ClearRamTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_lv1 = new System.Windows.Forms.Button();
            this.btn_Level2 = new System.Windows.Forms.Button();
            this.btn_lv3 = new System.Windows.Forms.Button();
            this.btn_lv4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_settimer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_TimeOfClean = new System.Windows.Forms.Label();
            this.label_Remain = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Second = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Minute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Hour = new System.Windows.Forms.NumericUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lv1
            // 
            this.btn_lv1.BackColor = System.Drawing.Color.Yellow;
            this.btn_lv1.ForeColor = System.Drawing.Color.Red;
            this.btn_lv1.Location = new System.Drawing.Point(14, 28);
            this.btn_lv1.Name = "btn_lv1";
            this.btn_lv1.Size = new System.Drawing.Size(75, 23);
            this.btn_lv1.TabIndex = 0;
            this.btn_lv1.Text = "Level 1";
            this.btn_lv1.UseVisualStyleBackColor = false;
            this.btn_lv1.Click += new System.EventHandler(this.btn_lv1_Click);
            // 
            // btn_Level2
            // 
            this.btn_Level2.Location = new System.Drawing.Point(114, 28);
            this.btn_Level2.Name = "btn_Level2";
            this.btn_Level2.Size = new System.Drawing.Size(75, 23);
            this.btn_Level2.TabIndex = 0;
            this.btn_Level2.Text = "Level 2";
            this.btn_Level2.UseVisualStyleBackColor = true;
            this.btn_Level2.Click += new System.EventHandler(this.btn_Level2_Click);
            // 
            // btn_lv3
            // 
            this.btn_lv3.Location = new System.Drawing.Point(220, 28);
            this.btn_lv3.Name = "btn_lv3";
            this.btn_lv3.Size = new System.Drawing.Size(75, 23);
            this.btn_lv3.TabIndex = 0;
            this.btn_lv3.Text = "Level 3";
            this.btn_lv3.UseVisualStyleBackColor = true;
            this.btn_lv3.Click += new System.EventHandler(this.btn_lv3_Click);
            // 
            // btn_lv4
            // 
            this.btn_lv4.Location = new System.Drawing.Point(324, 28);
            this.btn_lv4.Name = "btn_lv4";
            this.btn_lv4.Size = new System.Drawing.Size(75, 23);
            this.btn_lv4.TabIndex = 0;
            this.btn_lv4.Text = "Level 4";
            this.btn_lv4.UseVisualStyleBackColor = true;
            this.btn_lv4.Click += new System.EventHandler(this.btn_lv4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_lv4);
            this.groupBox1.Controls.Add(this.btn_lv1);
            this.groupBox1.Controls.Add(this.btn_lv3);
            this.groupBox1.Controls.Add(this.btn_Level2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "-Recommended using level 1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 169);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 143);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clean up RAM";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(263, 115);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CopyRight @2019 Vuong Nguyen";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 143);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Timer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_settimer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label_TimeOfClean);
            this.groupBox2.Controls.Add(this.label_Remain);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown_Second);
            this.groupBox2.Controls.Add(this.numericUpDown_Minute);
            this.groupBox2.Controls.Add(this.numericUpDown_Hour);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 131);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // button_settimer
            // 
            this.button_settimer.Location = new System.Drawing.Point(33, 57);
            this.button_settimer.Name = "button_settimer";
            this.button_settimer.Size = new System.Drawing.Size(370, 23);
            this.button_settimer.TabIndex = 2;
            this.button_settimer.Text = "Hẹn giờ";
            this.button_settimer.UseVisualStyleBackColor = true;
            this.button_settimer.Click += new System.EventHandler(this.button_settimer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "giây";
            // 
            // label_TimeOfClean
            // 
            this.label_TimeOfClean.AutoSize = true;
            this.label_TimeOfClean.Location = new System.Drawing.Point(327, 103);
            this.label_TimeOfClean.Name = "label_TimeOfClean";
            this.label_TimeOfClean.Size = new System.Drawing.Size(76, 13);
            this.label_TimeOfClean.TabIndex = 1;
            this.label_TimeOfClean.Text = "Đã clear: 5 lần";
            // 
            // label_Remain
            // 
            this.label_Remain.AutoSize = true;
            this.label_Remain.Location = new System.Drawing.Point(30, 103);
            this.label_Remain.Name = "label_Remain";
            this.label_Remain.Size = new System.Drawing.Size(192, 13);
            this.label_Remain.TabIndex = 1;
            this.label_Remain.Text = "Còn lại: 0 giờ 5 phút 0 giây sẽ clear ram";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "phút";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "giờ";
            // 
            // numericUpDown_Second
            // 
            this.numericUpDown_Second.Location = new System.Drawing.Point(293, 19);
            this.numericUpDown_Second.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_Second.Name = "numericUpDown_Second";
            this.numericUpDown_Second.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown_Second.TabIndex = 0;
            // 
            // numericUpDown_Minute
            // 
            this.numericUpDown_Minute.Location = new System.Drawing.Point(158, 19);
            this.numericUpDown_Minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_Minute.Name = "numericUpDown_Minute";
            this.numericUpDown_Minute.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown_Minute.TabIndex = 0;
            this.numericUpDown_Minute.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDown_Hour
            // 
            this.numericUpDown_Hour.Location = new System.Drawing.Point(33, 19);
            this.numericUpDown_Hour.Name = "numericUpDown_Hour";
            this.numericUpDown_Hour.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown_Hour.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 169);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clean up Ram Tool- Code by Vuong Nguyen - +8437.552.8766";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_lv1;
        private System.Windows.Forms.Button btn_Level2;
        private System.Windows.Forms.Button btn_lv3;
        private System.Windows.Forms.Button btn_lv4;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_settimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_TimeOfClean;
        private System.Windows.Forms.Label label_Remain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Second;
        private System.Windows.Forms.NumericUpDown numericUpDown_Minute;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hour;
        internal System.Windows.Forms.Timer timer2;
    }
}

