namespace KillSmoke
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
            System.Windows.Forms.Button buttonNo;
            System.Windows.Forms.Button buttonYes;
            this.labelTitle = new System.Windows.Forms.Label();
            buttonNo = new System.Windows.Forms.Button();
            buttonYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNo
            // 
            buttonNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            buttonNo.FlatAppearance.BorderSize = 0;
            buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonNo.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonNo.Location = new System.Drawing.Point(229, 226);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new System.Drawing.Size(154, 92);
            buttonNo.TabIndex = 2;
            buttonNo.Text = "No";
            buttonNo.UseVisualStyleBackColor = false;
            buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            buttonYes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            buttonYes.FlatAppearance.BorderSize = 0;
            buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonYes.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonYes.Location = new System.Drawing.Point(12, 226);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new System.Drawing.Size(154, 92);
            buttonYes.TabIndex = 3;
            buttonYes.Text = "Yes";
            buttonYes.UseVisualStyleBackColor = false;
            buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(67, 44);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(259, 48);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "You smoke?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 438);
            this.Controls.Add(buttonYes);
            this.Controls.Add(buttonNo);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KillSmoke";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Button buttonNo;
    }
}