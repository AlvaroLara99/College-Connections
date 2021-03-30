namespace LaraAlvaroProjectA
{
    partial class frmChatLog
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
            this.crvChat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvChat
            // 
            this.crvChat.ActiveViewIndex = -1;
            this.crvChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvChat.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvChat.Location = new System.Drawing.Point(0, 0);
            this.crvChat.Name = "crvChat";
            this.crvChat.Size = new System.Drawing.Size(800, 450);
            this.crvChat.TabIndex = 0;
            this.crvChat.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmChatLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvChat);
            this.Name = "frmChatLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Log";
            this.Load += new System.EventHandler(this.frmChatLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvChat;
    }
}