namespace upvoteNotification
{
    partial class notify
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.upvoteL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sbdL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 23);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // upvoteL
            // 
            this.upvoteL.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.upvoteL.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upvoteL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.upvoteL.Location = new System.Drawing.Point(12, 53);
            this.upvoteL.Name = "upvoteL";
            this.upvoteL.Size = new System.Drawing.Size(161, 39);
            this.upvoteL.TabIndex = 1;
            this.upvoteL.Text = "0";
            this.upvoteL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 23);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sbdL
            // 
            this.sbdL.BackColor = System.Drawing.Color.ForestGreen;
            this.sbdL.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbdL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sbdL.Location = new System.Drawing.Point(197, 53);
            this.sbdL.Name = "sbdL";
            this.sbdL.Size = new System.Drawing.Size(161, 39);
            this.sbdL.TabIndex = 3;
            this.sbdL.Text = "0";
            this.sbdL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 138);
            this.Controls.Add(this.sbdL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upvoteL);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "notify";
            this.Text = "notify";
            this.Load += new System.EventHandler(this.notify_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label upvoteL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sbdL;
        private System.Windows.Forms.Timer timer1;
    }
}