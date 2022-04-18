
namespace DiscordRPC_Installer_Redesign
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.maximizeBtn = new GhostButton();
            this.minimizeBtn = new GhostButton();
            this.installBtn = new GhostButton();
            this.locationLabel = new System.Windows.Forms.Label();
            this.ghostSwitch1 = new GhostSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ghostSwitch2 = new GhostSwitch();
            this.ghostSwitch3 = new GhostSwitch();
            this.ghostSwitch4 = new GhostSwitch();
            this.locationBox = new GhostTextBox();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.maximizeBtn);
            this.topPanel.Controls.Add(this.minimizeBtn);
            this.topPanel.Location = new System.Drawing.Point(0, -1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(588, 27);
            this.topPanel.TabIndex = 2;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "DiscordRP Installer";
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Backcolor = System.Drawing.Color.Transparent;
            this.maximizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.maximizeBtn.ClickAnimation = GhostButton.ClickAnimationType.Ripple;
            this.maximizeBtn.DisabledBackColor = System.Drawing.Color.Transparent;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeBtn.ForeColor = System.Drawing.Color.White;
            this.maximizeBtn.Location = new System.Drawing.Point(542, -11);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.RippleSpeed = 10;
            this.maximizeBtn.RoundRadius = 3;
            this.maximizeBtn.Size = new System.Drawing.Size(37, 44);
            this.maximizeBtn.TabIndex = 0;
            this.maximizeBtn.Text = "⤬";
            this.maximizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maximizeBtn.UseVisualStyleBackColor = false;
            this.maximizeBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Backcolor = System.Drawing.Color.Transparent;
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.ClickAnimation = GhostButton.ClickAnimationType.Ripple;
            this.minimizeBtn.DisabledBackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Location = new System.Drawing.Point(512, -11);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.RippleSpeed = 10;
            this.minimizeBtn.RoundRadius = 3;
            this.minimizeBtn.Size = new System.Drawing.Size(42, 44);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "⎯";
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.ghostButton1_Click);
            // 
            // installBtn
            // 
            this.installBtn.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.installBtn.BackColor = System.Drawing.Color.Transparent;
            this.installBtn.ClickAnimation = GhostButton.ClickAnimationType.Blink;
            this.installBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.installBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.installBtn.ForeColor = System.Drawing.Color.White;
            this.installBtn.Location = new System.Drawing.Point(440, 250);
            this.installBtn.Name = "installBtn";
            this.installBtn.RippleSpeed = 10;
            this.installBtn.RoundRadius = 3;
            this.installBtn.Size = new System.Drawing.Size(135, 30);
            this.installBtn.TabIndex = 0;
            this.installBtn.Text = "Install";
            this.installBtn.UseVisualStyleBackColor = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.White;
            this.locationLabel.Location = new System.Drawing.Point(8, 232);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(110, 21);
            this.locationLabel.TabIndex = 4;
            this.locationLabel.Text = "Install location";
            // 
            // ghostSwitch1
            // 
            this.ghostSwitch1.AutoSize = true;
            this.ghostSwitch1.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.ghostSwitch1.DisabledUnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.ghostSwitch1.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.ghostSwitch1.EnabledUnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.ghostSwitch1.Location = new System.Drawing.Point(7, 68);
            this.ghostSwitch1.Name = "ghostSwitch1";
            this.ghostSwitch1.Size = new System.Drawing.Size(47, 19);
            this.ghostSwitch1.TabIndex = 5;
            this.ghostSwitch1.Text = "ghostSwitch1";
            this.ghostSwitch1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Automatically install updates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Automatically start upon boot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Install latest updates (now)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Send optional data";
            // 
            // ghostSwitch2
            // 
            this.ghostSwitch2.AutoSize = true;
            this.ghostSwitch2.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.ghostSwitch2.DisabledUnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.ghostSwitch2.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.ghostSwitch2.EnabledUnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.ghostSwitch2.Location = new System.Drawing.Point(7, 144);
            this.ghostSwitch2.Name = "ghostSwitch2";
            this.ghostSwitch2.Size = new System.Drawing.Size(47, 19);
            this.ghostSwitch2.TabIndex = 14;
            this.ghostSwitch2.Text = "ghostSwitch2";
            this.ghostSwitch2.UseVisualStyleBackColor = true;
            // 
            // ghostSwitch3
            // 
            this.ghostSwitch3.AutoSize = true;
            this.ghostSwitch3.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.ghostSwitch3.DisabledUnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.ghostSwitch3.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.ghostSwitch3.EnabledUnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.ghostSwitch3.Location = new System.Drawing.Point(7, 118);
            this.ghostSwitch3.Name = "ghostSwitch3";
            this.ghostSwitch3.Size = new System.Drawing.Size(47, 19);
            this.ghostSwitch3.TabIndex = 15;
            this.ghostSwitch3.Text = "ghostSwitch3";
            this.ghostSwitch3.UseVisualStyleBackColor = true;
            // 
            // ghostSwitch4
            // 
            this.ghostSwitch4.AutoSize = true;
            this.ghostSwitch4.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.ghostSwitch4.DisabledUnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.ghostSwitch4.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.ghostSwitch4.EnabledUnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(191)))), ((int)(((byte)(196)))));
            this.ghostSwitch4.Location = new System.Drawing.Point(7, 93);
            this.ghostSwitch4.Name = "ghostSwitch4";
            this.ghostSwitch4.Size = new System.Drawing.Size(47, 19);
            this.ghostSwitch4.TabIndex = 16;
            this.ghostSwitch4.Text = "ghostSwitch4";
            this.ghostSwitch4.UseVisualStyleBackColor = true;
            // 
            // locationBox
            // 
            this.locationBox.bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.locationBox.Filter = "All Files (*.*)|*.*";
            this.locationBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.locationBox.FontColor = System.Drawing.Color.White;
            this.locationBox.IsEnabled = true;
            this.locationBox.Location = new System.Drawing.Point(12, 256);
            this.locationBox.Name = "locationBox";
            this.locationBox.ShowOpenButton = false;
            this.locationBox.Size = new System.Drawing.Size(300, 24);
            this.locationBox.TabIndex = 17;
            this.locationBox.Text = "C:\\Program Files\\DiscordRP";
            this.locationBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.locationBox.TypeToOpen = GhostTextBox.Open.OpenFolder;
            this.locationBox.UseSystemPasswordChar = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(587, 292);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.ghostSwitch4);
            this.Controls.Add(this.ghostSwitch3);
            this.Controls.Add(this.ghostSwitch2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ghostSwitch1);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.installBtn);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GhostButton maximizeBtn;
        private GhostButton minimizeBtn;
        private System.Windows.Forms.Panel topPanel;
        private GhostButton installBtn;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label1;
        private GhostSwitch ghostSwitch1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private GhostSwitch ghostSwitch2;
        private GhostSwitch ghostSwitch3;
        private GhostSwitch ghostSwitch4;
        private GhostTextBox locationBox;
    }
}

