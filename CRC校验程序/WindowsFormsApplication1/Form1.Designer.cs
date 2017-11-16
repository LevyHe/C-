namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.rhex = new System.Windows.Forms.RadioButton();
            this.rascii = new System.Windows.Forms.RadioButton();
            this.bytesnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HexRadio = new System.Windows.Forms.RadioButton();
            this.DecRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start.Location = new System.Drawing.Point(555, 77);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(87, 26);
            this.Start.TabIndex = 0;
            this.Start.Text = "开始校验";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Result.Location = new System.Drawing.Point(6, 66);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(463, 26);
            this.Result.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(555, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "清空输入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(19, 149);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(484, 225);
            this.textBox.TabIndex = 7;
            // 
            // rhex
            // 
            this.rhex.AutoSize = true;
            this.rhex.Checked = true;
            this.rhex.Location = new System.Drawing.Point(555, 251);
            this.rhex.Name = "rhex";
            this.rhex.Size = new System.Drawing.Size(71, 16);
            this.rhex.TabIndex = 8;
            this.rhex.TabStop = true;
            this.rhex.Text = "十六进制";
            this.rhex.UseVisualStyleBackColor = true;
            this.rhex.CheckedChanged += new System.EventHandler(this.rhex_CheckedChanged);
            // 
            // rascii
            // 
            this.rascii.AutoSize = true;
            this.rascii.Location = new System.Drawing.Point(555, 274);
            this.rascii.Name = "rascii";
            this.rascii.Size = new System.Drawing.Size(53, 16);
            this.rascii.TabIndex = 9;
            this.rascii.Text = "ASCII\r\n";
            this.rascii.UseVisualStyleBackColor = true;
            // 
            // bytesnum
            // 
            this.bytesnum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bytesnum.Location = new System.Drawing.Point(93, 27);
            this.bytesnum.Name = "bytesnum";
            this.bytesnum.Size = new System.Drawing.Size(100, 26);
            this.bytesnum.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "字节数目";
            // 
            // HexRadio
            // 
            this.HexRadio.AutoSize = true;
            this.HexRadio.Checked = true;
            this.HexRadio.Location = new System.Drawing.Point(210, 32);
            this.HexRadio.Name = "HexRadio";
            this.HexRadio.Size = new System.Drawing.Size(71, 16);
            this.HexRadio.TabIndex = 12;
            this.HexRadio.TabStop = true;
            this.HexRadio.Text = "十六进制";
            this.HexRadio.UseVisualStyleBackColor = true;
            this.HexRadio.CheckedChanged += new System.EventHandler(this.HexRadio_CheckedChanged);
            // 
            // DecRadio
            // 
            this.DecRadio.AutoSize = true;
            this.DecRadio.Location = new System.Drawing.Point(311, 32);
            this.DecRadio.Name = "DecRadio";
            this.DecRadio.Size = new System.Drawing.Size(59, 16);
            this.DecRadio.TabIndex = 13;
            this.DecRadio.Text = "十进制";
            this.DecRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DecRadio);
            this.groupBox1.Controls.Add(this.Result);
            this.groupBox1.Controls.Add(this.HexRadio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bytesnum);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "校验结果";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 249);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "校验内容";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(516, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 367);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 12);
            this.label2.TabIndex = 17;
            this.label2.Tag = "";
            this.label2.Text = "版权所有：天津华德宝航翼光电科技有限公司";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rascii);
            this.Controls.Add(this.rhex);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CRC校验";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RadioButton rhex;
        private System.Windows.Forms.RadioButton rascii;
        private System.Windows.Forms.TextBox bytesnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton HexRadio;
        private System.Windows.Forms.RadioButton DecRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
    }
}

