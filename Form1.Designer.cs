namespace Caro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelCaro = new System.Windows.Forms.Panel();
            this.PanelBoard = new System.Windows.Forms.Panel();
            this.PanelPicture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.picturePlayer = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TimeBar = new System.Windows.Forms.ProgressBar();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelPicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCaro
            // 
            this.panelCaro.AutoSize = true;
            this.panelCaro.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelCaro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCaro.Location = new System.Drawing.Point(12, 12);
            this.panelCaro.Name = "panelCaro";
            this.panelCaro.Size = new System.Drawing.Size(672, 708);
            this.panelCaro.TabIndex = 0;
            // 
            // PanelBoard
            // 
            this.PanelBoard.BackColor = System.Drawing.Color.White;
            this.PanelBoard.Controls.Add(this.PanelPicture);
            this.PanelBoard.Location = new System.Drawing.Point(731, 12);
            this.PanelBoard.Name = "PanelBoard";
            this.PanelBoard.Size = new System.Drawing.Size(338, 309);
            this.PanelBoard.TabIndex = 1;
            this.PanelBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBoard_Paint);
            // 
            // PanelPicture
            // 
            this.PanelPicture.Image = ((System.Drawing.Image)(resources.GetObject("PanelPicture.Image")));
            this.PanelPicture.Location = new System.Drawing.Point(27, 26);
            this.PanelPicture.Name = "PanelPicture";
            this.PanelPicture.Size = new System.Drawing.Size(282, 260);
            this.PanelPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PanelPicture.TabIndex = 0;
            this.PanelPicture.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.picturePlayer);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.TimeBar);
            this.panel3.Controls.Add(this.PlayerName);
            this.panel3.Location = new System.Drawing.Point(733, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 248);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picturePlayer
            // 
            this.picturePlayer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picturePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlayer.Location = new System.Drawing.Point(12, 68);
            this.picturePlayer.Name = "picturePlayer";
            this.picturePlayer.Size = new System.Drawing.Size(101, 90);
            this.picturePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePlayer.TabIndex = 3;
            this.picturePlayer.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 26);
            this.textBox1.TabIndex = 2;
            // 
            // TimeBar
            // 
            this.TimeBar.Location = new System.Drawing.Point(12, 12);
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(313, 39);
            this.TimeBar.TabIndex = 1;
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(150, 68);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(175, 26);
            this.PlayerName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1094, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanelBoard);
            this.Controls.Add(this.panelCaro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Caro Game";
            this.PanelBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCaro;
        private System.Windows.Forms.Panel PanelBoard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picturePlayer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar TimeBar;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PanelPicture;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

