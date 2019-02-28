namespace Prominent
{
    partial class ProjectUploadControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectNmeTB = new System.Windows.Forms.TextBox();
            this.projectTypelabel = new System.Windows.Forms.Label();
            this.projectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(3, 35);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(77, 13);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Project Name :";
            // 
            // projectNmeTB
            // 
            this.projectNmeTB.Location = new System.Drawing.Point(86, 32);
            this.projectNmeTB.Name = "projectNmeTB";
            this.projectNmeTB.Size = new System.Drawing.Size(334, 20);
            this.projectNmeTB.TabIndex = 1;
            // 
            // projectTypelabel
            // 
            this.projectTypelabel.AutoSize = true;
            this.projectTypelabel.Location = new System.Drawing.Point(3, 67);
            this.projectTypelabel.Name = "projectTypelabel";
            this.projectTypelabel.Size = new System.Drawing.Size(73, 13);
            this.projectTypelabel.TabIndex = 2;
            this.projectTypelabel.Text = "Project Type :";
            // 
            // projectTypeComboBox
            // 
            this.projectTypeComboBox.FormattingEnabled = true;
            this.projectTypeComboBox.Location = new System.Drawing.Point(86, 64);
            this.projectTypeComboBox.Name = "projectTypeComboBox";
            this.projectTypeComboBox.Size = new System.Drawing.Size(143, 21);
            this.projectTypeComboBox.TabIndex = 4;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(267, 115);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Project";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ProjectUploadControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.projectTypeComboBox);
            this.Controls.Add(this.projectTypelabel);
            this.Controls.Add(this.projectNmeTB);
            this.Controls.Add(this.projectNameLabel);
            this.Name = "ProjectUploadControl";
            this.Size = new System.Drawing.Size(430, 177);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox projectNmeTB;
        private System.Windows.Forms.Label projectTypelabel;
        private System.Windows.Forms.ComboBox projectTypeComboBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button button2;
    }
}
