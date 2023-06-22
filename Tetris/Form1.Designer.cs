namespace Tetris
{
    partial class Okno
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
            this.Igraj = new System.Windows.Forms.Button();
            this.zapriButton = new System.Windows.Forms.Button();
            this.tertrisLabel = new System.Windows.Forms.Label();
            this.rezultatiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Igraj
            // 
            this.Igraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igraj.Location = new System.Drawing.Point(422, 217);
            this.Igraj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Igraj.Name = "Igraj";
            this.Igraj.Size = new System.Drawing.Size(225, 77);
            this.Igraj.TabIndex = 0;
            this.Igraj.Text = "Igraj";
            this.Igraj.UseVisualStyleBackColor = true;
            this.Igraj.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PricniIgro);
            // 
            // zapriButton
            // 
            this.zapriButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zapriButton.Location = new System.Drawing.Point(422, 317);
            this.zapriButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zapriButton.Name = "zapriButton";
            this.zapriButton.Size = new System.Drawing.Size(225, 77);
            this.zapriButton.TabIndex = 1;
            this.zapriButton.Text = "Zapri";
            this.zapriButton.UseVisualStyleBackColor = true;
            this.zapriButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ZapriOkno);
            // 
            // tertrisLabel
            // 
            this.tertrisLabel.AutoSize = true;
            this.tertrisLabel.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tertrisLabel.ForeColor = System.Drawing.Color.Lime;
            this.tertrisLabel.Location = new System.Drawing.Point(438, 123);
            this.tertrisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tertrisLabel.Name = "tertrisLabel";
            this.tertrisLabel.Size = new System.Drawing.Size(194, 50);
            this.tertrisLabel.TabIndex = 2;
            this.tertrisLabel.Text = "TETRIS";
            // 
            // rezultatiButton
            // 
            this.rezultatiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultatiButton.Location = new System.Drawing.Point(422, 415);
            this.rezultatiButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rezultatiButton.Name = "rezultatiButton";
            this.rezultatiButton.Size = new System.Drawing.Size(225, 77);
            this.rezultatiButton.TabIndex = 3;
            this.rezultatiButton.Text = "Rezultati";
            this.rezultatiButton.UseVisualStyleBackColor = true;
            this.rezultatiButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrikaziRezultate);
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1026, 555);
            this.Controls.Add(this.rezultatiButton);
            this.Controls.Add(this.tertrisLabel);
            this.Controls.Add(this.zapriButton);
            this.Controls.Add(this.Igraj);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1039, 585);
            this.Name = "Okno";
            this.Text = "Tetris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer CasVertikalno;
        private System.Windows.Forms.Button Igraj;
        private System.Windows.Forms.Button zapriButton;
        private System.Windows.Forms.Label tertrisLabel;
        private System.Windows.Forms.Button rezultatiButton;
    }
}

