namespace LaraAlvaroProjectA
{
    partial class frmChat
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
            this.mnuChat = new System.Windows.Forms.MenuStrip();
            this.mnuItmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvChat = new System.Windows.Forms.DataGridView();
            this.hlpChat = new System.Windows.Forms.HelpProvider();
            this.mnuChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChat)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuChat
            // 
            this.mnuChat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItmClose,
            this.mnuItmHelp});
            this.mnuChat.Location = new System.Drawing.Point(0, 0);
            this.mnuChat.Name = "mnuChat";
            this.mnuChat.Size = new System.Drawing.Size(834, 24);
            this.mnuChat.TabIndex = 28;
            this.mnuChat.Text = "menuStrip1";
            // 
            // mnuItmClose
            // 
            this.mnuItmClose.Name = "mnuItmClose";
            this.mnuItmClose.Size = new System.Drawing.Size(48, 20);
            this.mnuItmClose.Text = "&Close";
            this.mnuItmClose.Click += new System.EventHandler(this.mnuItmClose_Click);
            // 
            // mnuItmHelp
            // 
            this.mnuItmHelp.Name = "mnuItmHelp";
            this.mnuItmHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuItmHelp.Text = "&Help";
            this.mnuItmHelp.Click += new System.EventHandler(this.mnuItmHelp_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(12, 411);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(659, 80);
            this.txtMessage.TabIndex = 30;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(677, 393);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(145, 50);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(677, 449);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 50);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvChat
            // 
            this.dgvChat.AllowUserToAddRows = false;
            this.dgvChat.AllowUserToDeleteRows = false;
            this.dgvChat.AllowUserToResizeColumns = false;
            this.dgvChat.AllowUserToResizeRows = false;
            this.dgvChat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChat.Location = new System.Drawing.Point(13, 28);
            this.dgvChat.Name = "dgvChat";
            this.dgvChat.ReadOnly = true;
            this.dgvChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChat.Size = new System.Drawing.Size(809, 359);
            this.dgvChat.TabIndex = 31;
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(212)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.ControlBox = false;
            this.Controls.Add(this.dgvChat);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.mnuChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.hlpChat.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChat";
            this.hlpChat.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.mnuChat.ResumeLayout(false);
            this.mnuChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuChat;
        private System.Windows.Forms.ToolStripMenuItem mnuItmClose;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem mnuItmHelp;
        private System.Windows.Forms.DataGridView dgvChat;
        private System.Windows.Forms.HelpProvider hlpChat;
    }
}