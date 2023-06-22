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
            this.pauseButton.Location = new System.Drawing.Point(430, 314);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(150, 50);
            this.pauseButton.TabIndex = 0;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pause);
            // 
            // zapustiButton
            // 
            this.zapustiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zapustiButton.Location = new System.Drawing.Point(430, 381);
            this.zapustiButton.Name = "zapustiButton";
            this.zapustiButton.Size = new System.Drawing.Size(150, 50);
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
            this.rezultatLabel.Location = new System.Drawing.Point(426, 258);
            this.rezultatLabel.Name = "rezultatLabel";
            this.rezultatLabel.Size = new System.Drawing.Size(105, 21);
            this.rezultatLabel.TabIndex = 2;
            this.rezultatLabel.Text = "Rezultat: ";
            // 
            // OknoIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.rezultatLabel);
            this.Controls.Add(this.zapustiButton);
            this.Controls.Add(this.pauseButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(700, 600);
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
    }
}