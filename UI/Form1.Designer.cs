namespace UI
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
            this.carPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.speedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentInfoLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.speedBox = new System.Windows.Forms.NumericUpDown();
            this.info = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // carPanel
            // 
            this.carPanel.BackColor = System.Drawing.Color.Gray;
            this.carPanel.Location = new System.Drawing.Point(6, 155);
            this.carPanel.Name = "carPanel";
            this.carPanel.Size = new System.Drawing.Size(147, 97);
            this.carPanel.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(514, 361);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 29);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // speedButton
            // 
            this.speedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedButton.Location = new System.Drawing.Point(608, 325);
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(75, 26);
            this.speedButton.TabIndex = 2;
            this.speedButton.Text = "Set";
            this.speedButton.UseVisualStyleBackColor = true;
            this.speedButton.Click += new System.EventHandler(this.speedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(449, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Speed:";
            // 
            // currentInfoLabel
            // 
            this.currentInfoLabel.AutoSize = true;
            this.currentInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentInfoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentInfoLabel.Location = new System.Drawing.Point(570, 9);
            this.currentInfoLabel.Name = "currentInfoLabel";
            this.currentInfoLabel.Size = new System.Drawing.Size(0, 16);
            this.currentInfoLabel.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(608, 361);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 29);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // speedBox
            // 
            this.speedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedBox.Location = new System.Drawing.Point(514, 325);
            this.speedBox.Name = "speedBox";
            this.speedBox.ReadOnly = true;
            this.speedBox.Size = new System.Drawing.Size(88, 22);
            this.speedBox.TabIndex = 8;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.YellowGreen;
            this.info.Location = new System.Drawing.Point(187, 374);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 16);
            this.info.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Set Speed Here:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(2, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Use The Arrow Keys To control The Direction";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(0, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 128);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(474, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 16);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(474, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 93);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(0, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 94);
            this.panel4.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(474, 272);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(22, 128);
            this.panel6.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(695, 400);
            this.Controls.Add(this.carPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.currentInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(715, 443);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Animation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel carPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button speedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentInfoLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.NumericUpDown speedBox;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
    }
}

