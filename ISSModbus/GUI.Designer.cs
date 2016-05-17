namespace ISSModbus
{
    partial class GUI
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
            this.DrivingTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tp1 = new System.Windows.Forms.Label();
            this.tpt1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tpt2 = new System.Windows.Forms.TextBox();
            this.tp2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tpt3 = new System.Windows.Forms.TextBox();
            this.tp3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tpt4 = new System.Windows.Forms.TextBox();
            this.tp4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.behindGarage = new System.Windows.Forms.Button();
            this.garage = new System.Windows.Forms.Button();
            this.gate = new System.Windows.Forms.Button();
            this.outerLights = new System.Windows.Forms.Button();
            this.innerLights = new System.Windows.Forms.Button();
            this.steerTempButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrivingTimer
            // 
            this.DrivingTimer.Tick += new System.EventHandler(this.DrivingTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tp1);
            this.groupBox1.Controls.Add(this.tpt1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pokój 1";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "zadana";
            // 
            // tp1
            // 
            this.tp1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tp1.AutoSize = true;
            this.tp1.Location = new System.Drawing.Point(27, 34);
            this.tp1.Name = "tp1";
            this.tp1.Size = new System.Drawing.Size(35, 13);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "label1";
            // 
            // tpt1
            // 
            this.tpt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpt1.Location = new System.Drawing.Point(68, 57);
            this.tpt1.Name = "tpt1";
            this.tpt1.Size = new System.Drawing.Size(59, 20);
            this.tpt1.TabIndex = 2;
            this.tpt1.Text = "20";
            this.tpt1.TextChanged += new System.EventHandler(this.tpt1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tpt2);
            this.groupBox2.Controls.Add(this.tp2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(181, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pokój 2";
            // 
            // tpt2
            // 
            this.tpt2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpt2.Location = new System.Drawing.Point(65, 57);
            this.tpt2.Name = "tpt2";
            this.tpt2.Size = new System.Drawing.Size(59, 20);
            this.tpt2.TabIndex = 3;
            this.tpt2.Text = "20";
            this.tpt2.TextChanged += new System.EventHandler(this.tpt2_TextChanged);
            // 
            // tp2
            // 
            this.tp2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tp2.AutoSize = true;
            this.tp2.Location = new System.Drawing.Point(24, 34);
            this.tp2.Name = "tp2";
            this.tp2.Size = new System.Drawing.Size(35, 13);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "label2";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "zadana";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tpt3);
            this.groupBox3.Controls.Add(this.tp3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 110);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pokój 3";
            // 
            // tpt3
            // 
            this.tpt3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpt3.Location = new System.Drawing.Point(68, 54);
            this.tpt3.Name = "tpt3";
            this.tpt3.Size = new System.Drawing.Size(59, 20);
            this.tpt3.TabIndex = 4;
            this.tpt3.Text = "20";
            this.tpt3.TextChanged += new System.EventHandler(this.tpt3_TextChanged);
            // 
            // tp3
            // 
            this.tp3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tp3.AutoSize = true;
            this.tp3.Location = new System.Drawing.Point(27, 30);
            this.tp3.Name = "tp3";
            this.tp3.Size = new System.Drawing.Size(35, 13);
            this.tp3.TabIndex = 2;
            this.tp3.Text = "label3";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "zadana";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tpt4);
            this.groupBox4.Controls.Add(this.tp4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(183, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 110);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pokój 4";
            // 
            // tpt4
            // 
            this.tpt4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpt4.Location = new System.Drawing.Point(63, 54);
            this.tpt4.Name = "tpt4";
            this.tpt4.Size = new System.Drawing.Size(59, 20);
            this.tpt4.TabIndex = 5;
            this.tpt4.Text = "20";
            this.tpt4.TextChanged += new System.EventHandler(this.tpt4_TextChanged);
            // 
            // tp4
            // 
            this.tp4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tp4.AutoSize = true;
            this.tp4.Location = new System.Drawing.Point(22, 30);
            this.tp4.Name = "tp4";
            this.tp4.Size = new System.Drawing.Size(35, 13);
            this.tp4.TabIndex = 3;
            this.tp4.Text = "label4";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "zadana";
            // 
            // behindGarage
            // 
            this.behindGarage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.behindGarage.Location = new System.Drawing.Point(404, 12);
            this.behindGarage.Name = "behindGarage";
            this.behindGarage.Size = new System.Drawing.Size(137, 225);
            this.behindGarage.TabIndex = 2;
            this.behindGarage.Text = "Podjazd";
            this.behindGarage.UseVisualStyleBackColor = true;
            this.behindGarage.Click += new System.EventHandler(this.behindGarage_Click);
            // 
            // garage
            // 
            this.garage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.garage.Location = new System.Drawing.Point(627, 13);
            this.garage.Name = "garage";
            this.garage.Size = new System.Drawing.Size(137, 225);
            this.garage.TabIndex = 3;
            this.garage.Text = "Garaż";
            this.garage.UseVisualStyleBackColor = true;
            this.garage.Click += new System.EventHandler(this.garage_Click);
            // 
            // gate
            // 
            this.gate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gate.Enabled = false;
            this.gate.Location = new System.Drawing.Point(560, 12);
            this.gate.Name = "gate";
            this.gate.Size = new System.Drawing.Size(50, 225);
            this.gate.TabIndex = 4;
            this.gate.Text = "Brama";
            this.gate.UseVisualStyleBackColor = true;
            // 
            // outerLights
            // 
            this.outerLights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outerLights.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outerLights.Enabled = false;
            this.outerLights.Location = new System.Drawing.Point(363, 13);
            this.outerLights.Name = "outerLights";
            this.outerLights.Size = new System.Drawing.Size(35, 31);
            this.outerLights.TabIndex = 5;
            this.outerLights.UseVisualStyleBackColor = false;
            // 
            // innerLights
            // 
            this.innerLights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.innerLights.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.innerLights.Enabled = false;
            this.innerLights.Location = new System.Drawing.Point(770, 13);
            this.innerLights.Name = "innerLights";
            this.innerLights.Size = new System.Drawing.Size(35, 31);
            this.innerLights.TabIndex = 6;
            this.innerLights.UseVisualStyleBackColor = false;
            // 
            // steerTempButton
            // 
            this.steerTempButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.steerTempButton.Location = new System.Drawing.Point(12, 244);
            this.steerTempButton.Name = "steerTempButton";
            this.steerTempButton.Size = new System.Drawing.Size(332, 27);
            this.steerTempButton.TabIndex = 7;
            this.steerTempButton.Text = "Steruj";
            this.steerTempButton.UseVisualStyleBackColor = true;
            this.steerTempButton.Click += new System.EventHandler(this.steerTempButton_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 272);
            this.Controls.Add(this.steerTempButton);
            this.Controls.Add(this.innerLights);
            this.Controls.Add(this.outerLights);
            this.Controls.Add(this.gate);
            this.Controls.Add(this.garage);
            this.Controls.Add(this.behindGarage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer DrivingTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tp1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tp2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label tp3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label tp4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tpt1;
        private System.Windows.Forms.TextBox tpt2;
        private System.Windows.Forms.TextBox tpt3;
        private System.Windows.Forms.TextBox tpt4;
        private System.Windows.Forms.Button behindGarage;
        private System.Windows.Forms.Button garage;
        private System.Windows.Forms.Button gate;
        private System.Windows.Forms.Button outerLights;
        private System.Windows.Forms.Button innerLights;
        private System.Windows.Forms.Button steerTempButton;
    }
}