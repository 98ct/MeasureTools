namespace Canvas
{
	partial class About
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
            this.m_ok = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_ok
            // 
            this.m_ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.m_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_ok.Location = new System.Drawing.Point(137, 86);
            this.m_ok.Name = "m_ok";
            this.m_ok.Size = new System.Drawing.Size(75, 23);
            this.m_ok.TabIndex = 0;
            this.m_ok.Text = "OK";
            this.m_ok.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(7, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(317, 48);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "雷震子航拍测绘软件\r\nV1.1\r\n航拍世家 出品\r\nhttps://arsui.net";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // About
            // 
            this.AcceptButton = this.m_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.m_ok;
            this.ClientSize = new System.Drawing.Size(348, 119);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.m_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_ok;
		private System.Windows.Forms.TextBox textBox1;
	}
}