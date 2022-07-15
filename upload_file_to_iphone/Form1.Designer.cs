namespace upload_file_to_iphone
{
    partial class Form1
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
            this.listIpBtn = new System.Windows.Forms.Button();
            this.listIpTxt = new System.Windows.Forms.TextBox();
            this.fileUploadTxt = new System.Windows.Forms.TextBox();
            this.fileUploadBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.fileToolTxt = new System.Windows.Forms.TextBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listIpBtn
            // 
            this.listIpBtn.Location = new System.Drawing.Point(409, 28);
            this.listIpBtn.Name = "listIpBtn";
            this.listIpBtn.Size = new System.Drawing.Size(75, 23);
            this.listIpBtn.TabIndex = 0;
            this.listIpBtn.Text = "list ip";
            this.listIpBtn.UseVisualStyleBackColor = true;
            this.listIpBtn.Click += new System.EventHandler(this.listIpBtn_Click);
            // 
            // listIpTxt
            // 
            this.listIpTxt.Location = new System.Drawing.Point(58, 31);
            this.listIpTxt.Name = "listIpTxt";
            this.listIpTxt.Size = new System.Drawing.Size(286, 20);
            this.listIpTxt.TabIndex = 1;
            this.listIpTxt.Text = "   File list ip";
            // 
            // fileUploadTxt
            // 
            this.fileUploadTxt.Location = new System.Drawing.Point(58, 64);
            this.fileUploadTxt.Name = "fileUploadTxt";
            this.fileUploadTxt.Size = new System.Drawing.Size(286, 20);
            this.fileUploadTxt.TabIndex = 3;
            this.fileUploadTxt.Text = "  File upload";
            // 
            // fileUploadBtn
            // 
            this.fileUploadBtn.Location = new System.Drawing.Point(409, 61);
            this.fileUploadBtn.Name = "fileUploadBtn";
            this.fileUploadBtn.Size = new System.Drawing.Size(75, 23);
            this.fileUploadBtn.TabIndex = 2;
            this.fileUploadBtn.Text = "file upload";
            this.fileUploadBtn.UseVisualStyleBackColor = true;
            this.fileUploadBtn.Click += new System.EventHandler(this.fileUploadBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(409, 99);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(75, 23);
            this.uploadBtn.TabIndex = 4;
            this.uploadBtn.Text = "upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(55, 190);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 13);
            this.statusLbl.TabIndex = 5;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(269, 143);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // fileToolTxt
            // 
            this.fileToolTxt.Location = new System.Drawing.Point(58, 102);
            this.fileToolTxt.Name = "fileToolTxt";
            this.fileToolTxt.Size = new System.Drawing.Size(286, 20);
            this.fileToolTxt.TabIndex = 10;
            this.fileToolTxt.Text = "  Nhập tên file";
            this.fileToolTxt.TextChanged += new System.EventHandler(this.startTxt_TextChanged);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(58, 143);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(75, 23);
            this.runBtn.TabIndex = 11;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(409, 143);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 219);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.fileToolTxt);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.fileUploadTxt);
            this.Controls.Add(this.fileUploadBtn);
            this.Controls.Add(this.listIpTxt);
            this.Controls.Add(this.listIpBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listIpBtn;
        private System.Windows.Forms.TextBox listIpTxt;
        private System.Windows.Forms.TextBox fileUploadTxt;
        private System.Windows.Forms.Button fileUploadBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox fileToolTxt;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}

