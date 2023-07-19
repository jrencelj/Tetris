namespace Tetris
{
    partial class OknoIgra
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
            this.Cas = new System.Windows.Forms.Timer(this.components);
            this.CasH = new System.Windows.Forms.Timer(this.components);
            this.pauseButton = new System.Windows.Forms.Button();
            this.zapustiButton = new System.Windows.Forms.Button();
            this.rezultatLabel = new System.Windows.Forms.Label();
            this.tezavnostLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cas
            // 
            this.Cas.Interval = 200;
            this.Cas.Tick += new System.EventHandler(this.Casovnik);
            // 
            // CasH
            // 
            this.CasH.Interval = 300;
            this.CasH.Tick += new System.EventHandler(this.CasovnikHorizontalno);
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(636, 442);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(225, 77);
            this.pauseButton.TabIndex = 0;
            this.pauseButton.Text = "Ustavi";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pause);
            // 
            // zapustiButton
            // 
            this.zapustiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zapustiButton.Location = new System.Drawing.Point(636, 545);
            this.zapustiButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zapustiButton.Name = "zapustiButton";
            this.zapustiButton.Size = new System.Drawing.Size(225, 77);
            this.zapustiButton.TabIndex = 1;
            this.zapustiButton.Text = "Zapusti";
            this.zapustiButton.UseVisualStyleBackColor = true;
            this.zapustiButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ZapustiIgro);
            // 
            // rezultatLabel
            // 
            this.rezultatLabel.AutoSize = true;
            this.rezultatLabel.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultatLabel.ForeColor = System.Drawing.Color.Lime;
            this.rezultatLabel.Location = new System.Drawing.Point(630, 356);
            this.rezultatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rezultatLabel.Name = "rezultatLabel";
            this.rezultatLabel.Size = new System.Drawing.Size(156, 34);
            this.rezultatLabel.TabIndex = 2;
            this.rezultatLabel.Text = "Rezultat: ";
            // 
            // tezavnostLabel
            // 
            this.tezavnostLabel.AutoSize = true;
            this.tezavnostLabel.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tezavnostLabel.ForeColor = System.Drawing.Color.Lime;
            this.tezavnostLabel.Location = new System.Drawing.Point(630, 298);
            this.tezavnostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tezavnostLabel.Name = "tezavnostLabel";
            this.tezavnostLabel.Size = new System.Drawing.Size(171, 34);
            this.tezavnostLabel.TabIndex = 3;
            this.tezavnostLabel.Text = "Težavnost:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(640, 705);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "D";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(640, 817);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Q";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(640, 649);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "A";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(640, 761);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 7;
            this.button4.Text = "S";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(640, 873);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 8;
            this.button5.Text = "E";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(717, 667);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Premakni levo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(717, 887);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rotiraj desno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(717, 831);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rotiraj levo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(717, 775);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Premakni navzdol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(717, 719);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Premakni desno";
            // 
            // OknoIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1078, 1044);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tezavnostLabel);
            this.Controls.Add(this.rezultatLabel);
            this.Controls.Add(this.zapustiButton);
            this.Controls.Add(this.pauseButton);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.MinimumSize = new System.Drawing.Size(1100, 1100);
            this.Name = "OknoIgra";
            this.Text = "Tetris";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Narisi);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Premik);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Cas;
        private System.Windows.Forms.Timer CasH;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button zapustiButton;
        private System.Windows.Forms.Label rezultatLabel;
        private System.Windows.Forms.Label tezavnostLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}