namespace Tetris
{
    partial class Nastavitve
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
            this.pricniButton = new System.Windows.Forms.Button();
            this.lahkaRB = new System.Windows.Forms.RadioButton();
            this.tezavnostGB = new System.Windows.Forms.GroupBox();
            this.tezkaRB = new System.Windows.Forms.RadioButton();
            this.srednjaRB = new System.Windows.Forms.RadioButton();
            this.uporabnikTextBox = new System.Windows.Forms.TextBox();
            this.uporabniskoImeLbl = new System.Windows.Forms.Label();
            this.tezavnostGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pricniButton
            // 
            this.pricniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricniButton.Location = new System.Drawing.Point(339, 329);
            this.pricniButton.Name = "pricniButton";
            this.pricniButton.Size = new System.Drawing.Size(150, 50);
            this.pricniButton.TabIndex = 0;
            this.pricniButton.Text = "Prični";
            this.pricniButton.UseVisualStyleBackColor = true;
            this.pricniButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PricniIgro);
            // 
            // lahkaRB
            // 
            this.lahkaRB.AutoSize = true;
            this.lahkaRB.Checked = true;
            this.lahkaRB.Location = new System.Drawing.Point(19, 25);
            this.lahkaRB.Name = "lahkaRB";
            this.lahkaRB.Size = new System.Drawing.Size(78, 24);
            this.lahkaRB.TabIndex = 1;
            this.lahkaRB.TabStop = true;
            this.lahkaRB.Text = "Lahka";
            this.lahkaRB.UseVisualStyleBackColor = true;
            // 
            // tezavnostGB
            // 
            this.tezavnostGB.Controls.Add(this.tezkaRB);
            this.tezavnostGB.Controls.Add(this.lahkaRB);
            this.tezavnostGB.Controls.Add(this.srednjaRB);
            this.tezavnostGB.ForeColor = System.Drawing.Color.Lime;
            this.tezavnostGB.Location = new System.Drawing.Point(301, 75);
            this.tezavnostGB.Name = "tezavnostGB";
            this.tezavnostGB.Size = new System.Drawing.Size(200, 124);
            this.tezavnostGB.TabIndex = 2;
            this.tezavnostGB.TabStop = false;
            this.tezavnostGB.Text = "Težavnost";
            // 
            // tezkaRB
            // 
            this.tezkaRB.AutoSize = true;
            this.tezkaRB.Location = new System.Drawing.Point(19, 85);
            this.tezkaRB.Name = "tezkaRB";
            this.tezkaRB.Size = new System.Drawing.Size(77, 24);
            this.tezkaRB.TabIndex = 4;
            this.tezkaRB.Text = "Težka";
            this.tezkaRB.UseVisualStyleBackColor = true;
            // 
            // srednjaRB
            // 
            this.srednjaRB.AutoSize = true;
            this.srednjaRB.Location = new System.Drawing.Point(19, 55);
            this.srednjaRB.Name = "srednjaRB";
            this.srednjaRB.Size = new System.Drawing.Size(89, 24);
            this.srednjaRB.TabIndex = 3;
            this.srednjaRB.Text = "Srednja";
            this.srednjaRB.UseVisualStyleBackColor = true;
            // 
            // uporabnikTextBox
            // 
            this.uporabnikTextBox.Location = new System.Drawing.Point(409, 240);
            this.uporabnikTextBox.Name = "uporabnikTextBox";
            this.uporabnikTextBox.Size = new System.Drawing.Size(200, 26);
            this.uporabnikTextBox.TabIndex = 3;
            // 
            // uporabniskoImeLbl
            // 
            this.uporabniskoImeLbl.AutoSize = true;
            this.uporabniskoImeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uporabniskoImeLbl.ForeColor = System.Drawing.Color.Lime;
            this.uporabniskoImeLbl.Location = new System.Drawing.Point(194, 236);
            this.uporabniskoImeLbl.Name = "uporabniskoImeLbl";
            this.uporabniskoImeLbl.Size = new System.Drawing.Size(196, 29);
            this.uporabniskoImeLbl.TabIndex = 4;
            this.uporabniskoImeLbl.Text = "Uporabniško ime";
            // 
            // Nastavitve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uporabniskoImeLbl);
            this.Controls.Add(this.uporabnikTextBox);
            this.Controls.Add(this.tezavnostGB);
            this.Controls.Add(this.pricniButton);
            this.Name = "Nastavitve";
            this.Text = "Tetris";
            this.tezavnostGB.ResumeLayout(false);
            this.tezavnostGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pricniButton;
        private System.Windows.Forms.RadioButton lahkaRB;
        private System.Windows.Forms.GroupBox tezavnostGB;
        private System.Windows.Forms.RadioButton tezkaRB;
        private System.Windows.Forms.RadioButton srednjaRB;
        private System.Windows.Forms.TextBox uporabnikTextBox;
        private System.Windows.Forms.Label uporabniskoImeLbl;
    }
}