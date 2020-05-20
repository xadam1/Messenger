namespace Messenger
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.flowlayoutMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.newMessagePanel = new System.Windows.Forms.Panel();
            this.sendNewMessageLbl = new System.Windows.Forms.Label();
            this.sendNewMessageButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.userPanel = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSubForm = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newMessagePanelToggle = new System.Windows.Forms.Panel();
            this.newMessageOverlay = new System.Windows.Forms.Label();
            this.newMessageOverlayBtn = new System.Windows.Forms.Button();
            this.addMessageOverlayPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.newMessagePanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.panelSubForm.SuspendLayout();
            this.newMessagePanelToggle.SuspendLayout();
            this.addMessageOverlayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.sidePanel.Controls.Add(this.flowlayoutMessages);
            this.sidePanel.Controls.Add(this.newMessagePanel);
            this.sidePanel.Controls.Add(this.userPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 761);
            this.sidePanel.TabIndex = 0;
            // 
            // flowlayoutMessages
            // 
            this.flowlayoutMessages.AutoScroll = true;
            this.flowlayoutMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.flowlayoutMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowlayoutMessages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowlayoutMessages.Location = new System.Drawing.Point(0, 149);
            this.flowlayoutMessages.Name = "flowlayoutMessages";
            this.flowlayoutMessages.Size = new System.Drawing.Size(250, 612);
            this.flowlayoutMessages.TabIndex = 1;
            this.flowlayoutMessages.WrapContents = false;
            // 
            // newMessagePanel
            // 
            this.newMessagePanel.Controls.Add(this.newMessagePanelToggle);
            this.newMessagePanel.Controls.Add(this.addMessageOverlayPanel);
            this.newMessagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newMessagePanel.Location = new System.Drawing.Point(0, 80);
            this.newMessagePanel.Name = "newMessagePanel";
            this.newMessagePanel.Size = new System.Drawing.Size(250, 69);
            this.newMessagePanel.TabIndex = 0;
            // 
            // sendNewMessageLbl
            // 
            this.sendNewMessageLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendNewMessageLbl.AutoSize = true;
            this.sendNewMessageLbl.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendNewMessageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.sendNewMessageLbl.Location = new System.Drawing.Point(3, 9);
            this.sendNewMessageLbl.Name = "sendNewMessageLbl";
            this.sendNewMessageLbl.Size = new System.Drawing.Size(188, 19);
            this.sendNewMessageLbl.TabIndex = 5;
            this.sendNewMessageLbl.Text = "Send new message to...";
            // 
            // sendNewMessageButton
            // 
            this.sendNewMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendNewMessageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.sendNewMessageButton.FlatAppearance.BorderSize = 0;
            this.sendNewMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendNewMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendNewMessageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sendNewMessageButton.Image = ((System.Drawing.Image)(resources.GetObject("sendNewMessageButton.Image")));
            this.sendNewMessageButton.Location = new System.Drawing.Point(207, 25);
            this.sendNewMessageButton.Name = "sendNewMessageButton";
            this.sendNewMessageButton.Size = new System.Drawing.Size(37, 38);
            this.sendNewMessageButton.TabIndex = 3;
            this.sendNewMessageButton.UseVisualStyleBackColor = true;
            this.sendNewMessageButton.Click += new System.EventHandler(this.sendNewMessageButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.comboBox1.Location = new System.Drawing.Point(3, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.userPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanel.Controls.Add(this.btnUser);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(250, 80);
            this.userPanel.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Montserrat", 14F);
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(11, 15);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(232, 52);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Log In...";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.titlePanel.Controls.Add(this.exit);
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(250, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(584, 80);
            this.titlePanel.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.exit.Location = new System.Drawing.Point(540, 22);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 41);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.lblTitle.Location = new System.Drawing.Point(250, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelSubForm
            // 
            this.panelSubForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panelSubForm.Controls.Add(this.button2);
            this.panelSubForm.Controls.Add(this.button1);
            this.panelSubForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubForm.Location = new System.Drawing.Point(250, 80);
            this.panelSubForm.Name = "panelSubForm";
            this.panelSubForm.Size = new System.Drawing.Size(584, 681);
            this.panelSubForm.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newMessagePanelToggle
            // 
            this.newMessagePanelToggle.Controls.Add(this.newMessageOverlayBtn);
            this.newMessagePanelToggle.Controls.Add(this.newMessageOverlay);
            this.newMessagePanelToggle.Location = new System.Drawing.Point(0, 0);
            this.newMessagePanelToggle.Name = "newMessagePanelToggle";
            this.newMessagePanelToggle.Size = new System.Drawing.Size(247, 28);
            this.newMessagePanelToggle.TabIndex = 6;
            // 
            // newMessageOverlay
            // 
            this.newMessageOverlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newMessageOverlay.AutoSize = true;
            this.newMessageOverlay.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMessageOverlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.newMessageOverlay.Location = new System.Drawing.Point(20, 3);
            this.newMessageOverlay.Name = "newMessageOverlay";
            this.newMessageOverlay.Size = new System.Drawing.Size(168, 19);
            this.newMessageOverlay.TabIndex = 6;
            this.newMessageOverlay.Text = "Send new message...";
            // 
            // newMessageOverlayBtn
            // 
            this.newMessageOverlayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newMessageOverlayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.newMessageOverlayBtn.FlatAppearance.BorderSize = 0;
            this.newMessageOverlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newMessageOverlayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMessageOverlayBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newMessageOverlayBtn.Image = ((System.Drawing.Image)(resources.GetObject("newMessageOverlayBtn.Image")));
            this.newMessageOverlayBtn.Location = new System.Drawing.Point(187, -1);
            this.newMessageOverlayBtn.Name = "newMessageOverlayBtn";
            this.newMessageOverlayBtn.Size = new System.Drawing.Size(29, 28);
            this.newMessageOverlayBtn.TabIndex = 7;
            this.newMessageOverlayBtn.UseVisualStyleBackColor = true;
            this.newMessageOverlayBtn.Click += new System.EventHandler(this.newMessageOverlayBtn_Click);
            // 
            // addMessageOverlayPanel
            // 
            this.addMessageOverlayPanel.Controls.Add(this.sendNewMessageButton);
            this.addMessageOverlayPanel.Controls.Add(this.sendNewMessageLbl);
            this.addMessageOverlayPanel.Controls.Add(this.comboBox1);
            this.addMessageOverlayPanel.Location = new System.Drawing.Point(0, 0);
            this.addMessageOverlayPanel.Name = "addMessageOverlayPanel";
            this.addMessageOverlayPanel.Size = new System.Drawing.Size(250, 69);
            this.addMessageOverlayPanel.TabIndex = 7;
            this.addMessageOverlayPanel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.panelSubForm);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.sidePanel);
            this.MinimumSize = new System.Drawing.Size(840, 580);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessengerApp";
            this.sidePanel.ResumeLayout(false);
            this.newMessagePanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.panelSubForm.ResumeLayout(false);
            this.newMessagePanelToggle.ResumeLayout(false);
            this.newMessagePanelToggle.PerformLayout();
            this.addMessageOverlayPanel.ResumeLayout(false);
            this.addMessageOverlayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel panelSubForm;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowlayoutMessages;
        private System.Windows.Forms.Button sendNewMessageButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel newMessagePanel;
        private System.Windows.Forms.Label sendNewMessageLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel newMessagePanelToggle;
        private System.Windows.Forms.Button newMessageOverlayBtn;
        private System.Windows.Forms.Label newMessageOverlay;
        private System.Windows.Forms.Panel addMessageOverlayPanel;
    }
}