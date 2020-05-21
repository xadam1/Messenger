namespace Messenger.Controls
{
    partial class MessageToUser
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
            this.Receiver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Receiver
            // 
            this.Receiver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Receiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Receiver.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receiver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.Receiver.Location = new System.Drawing.Point(6, 10);
            this.Receiver.Name = "Receiver";
            this.Receiver.Size = new System.Drawing.Size(214, 81);
            this.Receiver.TabIndex = 0;
            this.Receiver.Text = "John Doe";
            this.Receiver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Receiver.Click += new System.EventHandler(this.Username_Click);
            // 
            // MessageToUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.Receiver);
            this.Name = "MessageToUser";
            this.Size = new System.Drawing.Size(227, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Receiver;
    }
}
