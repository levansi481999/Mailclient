namespace MailClient
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toText = new System.Windows.Forms.TextBox();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.chatText = new System.Windows.Forms.TextBox();
            this.btfilebrowse = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.txtattachment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subject";
            // 
            // toText
            // 
            this.toText.Location = new System.Drawing.Point(118, 46);
            this.toText.Margin = new System.Windows.Forms.Padding(2);
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(263, 20);
            this.toText.TabIndex = 1;
            this.toText.TextChanged += new System.EventHandler(this.toText_TextChanged);
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(118, 84);
            this.subjectText.Margin = new System.Windows.Forms.Padding(2);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(263, 20);
            this.subjectText.TabIndex = 2;
            // 
            // chatText
            // 
            this.chatText.Location = new System.Drawing.Point(118, 287);
            this.chatText.Margin = new System.Windows.Forms.Padding(2);
            this.chatText.Multiline = true;
            this.chatText.Name = "chatText";
            this.chatText.Size = new System.Drawing.Size(263, 88);
            this.chatText.TabIndex = 6;
            // 
            // btfilebrowse
            // 
            this.btfilebrowse.Location = new System.Drawing.Point(271, 254);
            this.btfilebrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btfilebrowse.Name = "btfilebrowse";
            this.btfilebrowse.Size = new System.Drawing.Size(110, 29);
            this.btfilebrowse.TabIndex = 7;
            this.btfilebrowse.Text = "File Browse";
            this.btfilebrowse.UseVisualStyleBackColor = true;
            this.btfilebrowse.Click += new System.EventHandler(this.btfilebrowes_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(203, 379);
            this.btSend.Margin = new System.Windows.Forms.Padding(2);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(113, 44);
            this.btSend.TabIndex = 9;
            this.btSend.Text = "SEND";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // txtattachment
            // 
            this.txtattachment.Location = new System.Drawing.Point(118, 220);
            this.txtattachment.Margin = new System.Windows.Forms.Padding(2);
            this.txtattachment.Name = "txtattachment";
            this.txtattachment.Size = new System.Drawing.Size(263, 20);
            this.txtattachment.TabIndex = 5;
            this.txtattachment.TextChanged += new System.EventHandler(this.txtattachment_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 608);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btfilebrowse);
            this.Controls.Add(this.chatText);
            this.Controls.Add(this.txtattachment);
            this.Controls.Add(this.subjectText);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Send Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toText;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.TextBox chatText;
        private System.Windows.Forms.Button btfilebrowse;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox txtattachment;
    }
}

