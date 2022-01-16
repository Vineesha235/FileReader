namespace FileReader
{
    partial class Reader
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
            this.richTextBoxFileData = new System.Windows.Forms.RichTextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // richTextBoxFileData
            // 
            this.richTextBoxFileData.BackColor = System.Drawing.Color.Silver;
            this.richTextBoxFileData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxFileData.Location = new System.Drawing.Point(23, 28);
            this.richTextBoxFileData.Name = "richTextBoxFileData";
            this.richTextBoxFileData.ReadOnly = true;
            this.richTextBoxFileData.Size = new System.Drawing.Size(753, 304);
            this.richTextBoxFileData.TabIndex = 0;
            this.richTextBoxFileData.Text = "";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Location = new System.Drawing.Point(23, 338);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(753, 27);
            this.txtPath.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpload.Location = new System.Drawing.Point(182, 382);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(132, 40);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Import";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Location = new System.Drawing.Point(320, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Location = new System.Drawing.Point(458, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.richTextBoxFileData);
            this.Name = "Reader";
            this.Text = "File Reder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBoxFileData;
        private TextBox txtPath;
        private Button btnUpload;
        private Button btnClear;
        private Button btnExit;
        private OpenFileDialog openFileDialog;
    }
}