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
            this.tezkaButton = new System.Windows.Forms.Button();
            this.lahkaButton = new System.Windows.Forms.Button();
            this.srednjaButton = new System.Windows.Forms.Button();
            this.tezavnostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rezultatiListBox
            // 
            this.rezultatiListBox.FormattingEnabled = true;
            this.rezultatiListBox.ItemHeight = 20;
            this.rezultatiListBox.Location = new System.Drawing.Point(244, 116);
            this.rezultatiListBox.Name = "rezultatiListBox";
            this.rezultatiListBox.Size = new System.Drawing.Size(388, 324);
            this.rezultatiListBox.TabIndex = 0;
            // 
            // nazajButton
            // 
            this.nazajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazajButton.Location = new System.Drawing.Point(358, 446);
            this.nazajButton.Name = "nazajButton";
            this.nazajButton.Size = new System.Drawing.Size(150, 50);
            this.nazajButton.TabIndex = 1;
            this.nazajButton.Text = "Nazaj";
            this.nazajButton.UseVisualStyleBackColor = true;
            this.nazajButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PojdiNazaj);
            // 
            // tezkaButton
            // 
            this.tezkaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tezkaButton.Location = new System.Drawing.Point(35, 189);
            this.tezkaButton.Name = "tezkaButton";
            this.tezkaButton.Size = new System.Drawing.Size(150, 50);
            this.tezkaButton.TabIndex = 3;
            this.tezkaButton.Text = "Težka";
            this.tezkaButton.UseVisualStyleBackColor = true;
            this.tezkaButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrikaziTezka);
            // 
            // lahkaButton
            // 
            this.lahkaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lahkaButton.Location = new System.Drawing.Point(35, 301);
            this.lahkaButton.Name = "lahkaButton";
            this.lahkaButton.Size = new System.Drawing.Size(150, 50);
            this.lahkaButton.TabIndex = 4;
            this.lahkaButton.Text = "Lahka";
            this.lahkaButton.UseVisualStyleBackColor = true;
            this.lahkaButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrikaziLahka);
            // 
            // srednjaButton
            // 
            this.srednjaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srednjaButton.Location = new System.Drawing.Point(35, 245);
            this.srednjaButton.Name = "srednjaButton";
            this.srednjaButton.Size = new System.Drawing.Size(150, 50);
            this.srednjaButton.TabIndex = 5;
            this.srednjaButton.Text = "Srednja";
            this.srednjaButton.UseVisualStyleBackColor = true;
            this.srednjaButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrikaziSrednja);
            // 
            // tezavnostLabel
            // 
            this.tezavnostLabel.AutoSize = true;
            this.tezavnostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tezavnostLabel.ForeColor = System.Drawing.Color.Lime;
            this.tezavnostLabel.Location = new System.Drawing.Point(312, 41);
            this.tezavnostLabel.Name = "tezavnostLabel";
            this.tezavnostLabel.Size = new System.Drawing.Size(273, 40);
            this.tezavnostLabel.TabIndex = 6;
            this.tezavnostLabel.Text = "Top 10 - Težko";
            // 
            // Rezultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(837, 508);
            this.Controls.Add(this.tezavnostLabel);
            this.Controls.Add(this.srednjaButton);
            this.Controls.Add(this.lahkaButton);
            this.Controls.Add(this.tezkaButton);
            this.Controls.Add(this.nazajButton);
            this.Controls.Add(this.rezultatiListBox);
            this.Name = "Rezultati";
            this.Text = "Rezultati";
            this.Load += new System.EventHandler(this.NaloziRezultate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox rezultatiListBox;
        private System.Windows.Forms.Button nazajButton;
        private System.Windows.Forms.Button tezkaButton;
        private System.Windows.Forms.Button lahkaButton;
        private System.Windows.Forms.Button srednjaButton;
        private System.Windows.Forms.Label tezavnostLabel;
    }
}