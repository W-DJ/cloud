﻿namespace cloud_style
{
	partial class Login
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Location = new System.Drawing.Point(56, 324);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(188, 93);
			this.button1.TabIndex = 3;
			this.button1.Text = "LOGIN";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Control;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.textBox1.Location = new System.Drawing.Point(56, 201);
			this.textBox1.Margin = new System.Windows.Forms.Padding(5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(188, 14);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Control;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.ForeColor = System.Drawing.SystemColors.Desktop;
			this.textBox2.Location = new System.Drawing.Point(56, 261);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(188, 14);
			this.textBox2.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel1.Location = new System.Drawing.Point(56, 217);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(188, 1);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.Location = new System.Drawing.Point(56, 277);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(188, 1);
			this.panel2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label1.Location = new System.Drawing.Point(55, 178);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label2.Location = new System.Drawing.Point(55, 246);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel3.Controls.Add(this.button2);
			this.panel3.ForeColor = System.Drawing.SystemColors.Control;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(300, 137);
			this.panel3.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("나눔스퀘어 네오 OTF Heavy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Location = new System.Drawing.Point(3, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(63, 26);
			this.button2.TabIndex = 6;
			this.button2.Text = "JOIN";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Login
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 450);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Login";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button2;
	}
}

