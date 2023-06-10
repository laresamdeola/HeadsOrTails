namespace HeadsOrTails
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.coinTossButton = new System.Windows.Forms.Button();
            this.coinTossLabel = new System.Windows.Forms.Label();
            this.coinResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coinTossButton
            // 
            this.coinTossButton.BackColor = System.Drawing.Color.Black;
            this.coinTossButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.coinTossButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coinTossButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coinTossButton.ForeColor = System.Drawing.Color.White;
            this.coinTossButton.Location = new System.Drawing.Point(302, 197);
            this.coinTossButton.Name = "coinTossButton";
            this.coinTossButton.Size = new System.Drawing.Size(186, 54);
            this.coinTossButton.TabIndex = 0;
            this.coinTossButton.Text = "TOSS";
            this.coinTossButton.UseVisualStyleBackColor = false;
            this.coinTossButton.Click += new System.EventHandler(this.coinTossButton_Click);
            // 
            // coinTossLabel
            // 
            this.coinTossLabel.AutoSize = true;
            this.coinTossLabel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coinTossLabel.Location = new System.Drawing.Point(369, 141);
            this.coinTossLabel.Name = "coinTossLabel";
            this.coinTossLabel.Size = new System.Drawing.Size(0, 20);
            this.coinTossLabel.TabIndex = 1;
            // 
            // coinResetButton
            // 
            this.coinResetButton.BackColor = System.Drawing.Color.Black;
            this.coinResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.coinResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coinResetButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coinResetButton.ForeColor = System.Drawing.Color.White;
            this.coinResetButton.Location = new System.Drawing.Point(302, 257);
            this.coinResetButton.Name = "coinResetButton";
            this.coinResetButton.Size = new System.Drawing.Size(186, 54);
            this.coinResetButton.TabIndex = 2;
            this.coinResetButton.Text = "RESET";
            this.coinResetButton.UseVisualStyleBackColor = false;
            this.coinResetButton.Click += new System.EventHandler(this.coinResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 353);
            this.Controls.Add(this.coinResetButton);
            this.Controls.Add(this.coinTossLabel);
            this.Controls.Add(this.coinTossButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(824, 489);
            this.Name = "Form1";
            this.Text = "HeadsOrTails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button coinTossButton;
        private Label coinTossLabel;
        private Button coinResetButton;
    }
}