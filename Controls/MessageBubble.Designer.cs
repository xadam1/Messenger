namespace Messenger.Controls
{
    partial class MessageBubble
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
            this.FromUserLbl = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FromUserLbl
            // 
            this.FromUserLbl.AutoSize = true;
            this.FromUserLbl.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromUserLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.FromUserLbl.Location = new System.Drawing.Point(14, 6);
            this.FromUserLbl.Name = "FromUserLbl";
            this.FromUserLbl.Size = new System.Drawing.Size(87, 19);
            this.FromUserLbl.TabIndex = 0;
            this.FromUserLbl.Text = "Username";
            // 
            // message
            // 
            this.message.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.message.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.message.Location = new System.Drawing.Point(14, 28);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(473, 43);
            this.message.TabIndex = 1;
            this.message.Text = "Lorem ipsum, querte muo alis guambad";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageBubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.message);
            this.Controls.Add(this.FromUserLbl);
            this.MinimumSize = new System.Drawing.Size(500, 80);
            this.Name = "MessageBubble";
            this.Size = new System.Drawing.Size(500, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromUserLbl;
        private System.Windows.Forms.Label message;
    }
}
