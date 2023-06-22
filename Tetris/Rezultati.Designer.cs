namespace Tetris
{
    partial class Rezultati
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
            this.rezultatiListBox = new System.Windows.Forms.ListBox();
            this.nazajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rezultatiListBox
            // 
            this.rezultatiListBox.FormattingEnabled = true;
            this.rezultatiListBox.ItemHeight = 20;
            this.rezultatiListBox.Location = new System.Drawing.Point(221, 25);
            this.rezultatiListBox.Name = "rezultatiListBox";
            this.rezultatiListBox.Size = new System.Drawing.Size(388, 324);
            this.rezultatiListBox.TabIndex = 0;
            // 
            // nazajButton
            // 
            this.nazajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazajButton.Location = new System.Drawing.Point(355, 379);
            this.nazajButton.Name = "nazajButton";
            this.nazajButton.Size = new System.Drawing.Size(150, 50);
            this.nazajButton.TabIndex = 1;
            this.nazajButton.Text = "Nazaj";
            this.nazajButton.UseVisualStyleBackColor = true;
            this.nazajButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PojdiNazaj);
            // 
            // Rezultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nazajButton);
            this.Controls.Add(this.rezultatiListBox);
            this.Name = "Rezultati";
            this.Text = "Rezultati";
            this.Load += new System.EventHandler(this.NaloziRezultate);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox rezultatiListBox;
        private System.Windows.Forms.Button nazajButton;
    }
}