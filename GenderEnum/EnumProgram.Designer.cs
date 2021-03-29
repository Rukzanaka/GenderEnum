namespace GenderEnum
{
    partial class EnumProgram
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
            this.cmbBxName = new System.Windows.Forms.ComboBox();
            this.btnTossing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBxName
            // 
            this.cmbBxName.FormattingEnabled = true;
            this.cmbBxName.Items.AddRange(new object[] {
            "Ammu",
            "Achu"});
            this.cmbBxName.Location = new System.Drawing.Point(192, 131);
            this.cmbBxName.Name = "cmbBxName";
            this.cmbBxName.Size = new System.Drawing.Size(208, 24);
            this.cmbBxName.TabIndex = 0;
            // 
            // btnTossing
            // 
            this.btnTossing.Location = new System.Drawing.Point(266, 233);
            this.btnTossing.Name = "btnTossing";
            this.btnTossing.Size = new System.Drawing.Size(75, 31);
            this.btnTossing.TabIndex = 1;
            this.btnTossing.Text = "Tossing";
            this.btnTossing.UseVisualStyleBackColor = true;
            this.btnTossing.Click += new System.EventHandler(this.btnTossing_Click);
            // 
            // EnumProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 392);
            this.Controls.Add(this.btnTossing);
            this.Controls.Add(this.cmbBxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EnumProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBxName;
        private System.Windows.Forms.Button btnTossing;
    }
}

