namespace DBProject
{
    partial class UserForm
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
            this.pasportlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pasportlabel
            // 
            this.pasportlabel.AutoSize = true;
            this.pasportlabel.Location = new System.Drawing.Point(12, 9);
            this.pasportlabel.Name = "pasportlabel";
            this.pasportlabel.Size = new System.Drawing.Size(75, 20);
            this.pasportlabel.TabIndex = 0;
            this.pasportlabel.Text = "Паспорт: ";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pasportlabel);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pasportlabel;
    }
}