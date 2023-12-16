namespace Tyuiu.NasyrovaVR.Sprint6.TaskReview.V26
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.TextBoxInfo_NVR = new System.Windows.Forms.TextBox();
            this.ButtonOk_NVR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxInfo_NVR
            // 
            this.TextBoxInfo_NVR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxInfo_NVR.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxInfo_NVR.Location = new System.Drawing.Point(12, 12);
            this.TextBoxInfo_NVR.Multiline = true;
            this.TextBoxInfo_NVR.Name = "TextBoxInfo_NVR";
            this.TextBoxInfo_NVR.ReadOnly = true;
            this.TextBoxInfo_NVR.Size = new System.Drawing.Size(450, 190);
            this.TextBoxInfo_NVR.TabIndex = 2;
            this.TextBoxInfo_NVR.TabStop = false;
            this.TextBoxInfo_NVR.Text = resources.GetString("TextBoxInfo_NVR.Text");
            // 
            // ButtonOk_NVR
            // 
            this.ButtonOk_NVR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOk_NVR.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonOk_NVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOk_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOk_NVR.Location = new System.Drawing.Point(406, 193);
            this.ButtonOk_NVR.Name = "ButtonOk_NVR";
            this.ButtonOk_NVR.Size = new System.Drawing.Size(96, 31);
            this.ButtonOk_NVR.TabIndex = 3;
            this.ButtonOk_NVR.Text = "Ок";
            this.ButtonOk_NVR.UseVisualStyleBackColor = false;
            this.ButtonOk_NVR.Click += new System.EventHandler(this.ButtonOk_NVR_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 236);
            this.Controls.Add(this.ButtonOk_NVR);
            this.Controls.Add(this.TextBoxInfo_NVR);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxInfo_NVR;
        private System.Windows.Forms.Button ButtonOk_NVR;
    }
}