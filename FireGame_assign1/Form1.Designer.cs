namespace FireGame_assign1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLoadBullet = new System.Windows.Forms.Button();
            this.btnSpinChamber = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnSHootAway = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(3, 421);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 65);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLoadBullet
            // 
            this.btnLoadBullet.BackColor = System.Drawing.Color.Red;
            this.btnLoadBullet.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBullet.ForeColor = System.Drawing.Color.White;
            this.btnLoadBullet.Location = new System.Drawing.Point(106, 420);
            this.btnLoadBullet.Name = "btnLoadBullet";
            this.btnLoadBullet.Size = new System.Drawing.Size(104, 65);
            this.btnLoadBullet.TabIndex = 2;
            this.btnLoadBullet.Text = "Load Bullet";
            this.btnLoadBullet.UseVisualStyleBackColor = false;
            this.btnLoadBullet.Click += new System.EventHandler(this.btnLoadBullet_Click);
            // 
            // btnSpinChamber
            // 
            this.btnSpinChamber.BackColor = System.Drawing.Color.Red;
            this.btnSpinChamber.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpinChamber.ForeColor = System.Drawing.Color.White;
            this.btnSpinChamber.Location = new System.Drawing.Point(223, 421);
            this.btnSpinChamber.Name = "btnSpinChamber";
            this.btnSpinChamber.Size = new System.Drawing.Size(104, 65);
            this.btnSpinChamber.TabIndex = 3;
            this.btnSpinChamber.Text = "Spin Chamber";
            this.btnSpinChamber.UseVisualStyleBackColor = false;
            this.btnSpinChamber.Click += new System.EventHandler(this.btnSpinChamber_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.BackColor = System.Drawing.Color.Red;
            this.btnShoot.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoot.ForeColor = System.Drawing.Color.White;
            this.btnShoot.Location = new System.Drawing.Point(333, 421);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(104, 65);
            this.btnShoot.TabIndex = 4;
            this.btnShoot.Text = "Shoot Bullet";
            this.btnShoot.UseVisualStyleBackColor = false;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnSHootAway
            // 
            this.btnSHootAway.BackColor = System.Drawing.Color.Red;
            this.btnSHootAway.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHootAway.ForeColor = System.Drawing.Color.White;
            this.btnSHootAway.Location = new System.Drawing.Point(443, 421);
            this.btnSHootAway.Name = "btnSHootAway";
            this.btnSHootAway.Size = new System.Drawing.Size(104, 65);
            this.btnSHootAway.TabIndex = 5;
            this.btnSHootAway.Text = "Shoot Away Bullet";
            this.btnSHootAway.UseVisualStyleBackColor = false;
            this.btnSHootAway.Click += new System.EventHandler(this.btnSHootAway_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(97, 364);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(121, 22);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "click on Start ";
            // 
            // pbBox
            // 
            this.pbBox.Image = global::FireGame_assign1.Properties.Resources.fire1;
            this.pbBox.Location = new System.Drawing.Point(106, 12);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(347, 328);
            this.pbBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBox.TabIndex = 0;
            this.pbBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 554);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSHootAway);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnSpinChamber);
            this.Controls.Add(this.btnLoadBullet);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBox;
        private System.Windows.Forms.Button btnLoadBullet;
        private System.Windows.Forms.Button btnSpinChamber;
        private System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.Button btnShoot;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Button btnSHootAway;
    }
}

