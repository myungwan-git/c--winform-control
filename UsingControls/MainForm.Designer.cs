namespace UsingControls
{
	partial class MainForm
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
			this.grpFont = new System.Windows.Forms.GroupBox();
			this.txtSampleText = new System.Windows.Forms.TextBox();
			this.chkItalic = new System.Windows.Forms.CheckBox();
			this.chkBold = new System.Windows.Forms.CheckBox();
			this.cboFont = new System.Windows.Forms.ComboBox();
			this.lblFont = new System.Windows.Forms.Label();
			this.grpFont.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpFont
			// 
			this.grpFont.Controls.Add(this.txtSampleText);
			this.grpFont.Controls.Add(this.chkItalic);
			this.grpFont.Controls.Add(this.chkBold);
			this.grpFont.Controls.Add(this.cboFont);
			this.grpFont.Controls.Add(this.lblFont);
			this.grpFont.Location = new System.Drawing.Point(24, 53);
			this.grpFont.Name = "grpFont";
			this.grpFont.Size = new System.Drawing.Size(747, 196);
			this.grpFont.TabIndex = 0;
			this.grpFont.TabStop = false;
			this.grpFont.Text = "ComboBox, CheckBox, TextBox";
			this.grpFont.Enter += new System.EventHandler(this.grpFont_Enter);
			// 
			// txtSampleText
			// 
			this.txtSampleText.Location = new System.Drawing.Point(9, 93);
			this.txtSampleText.Name = "txtSampleText";
			this.txtSampleText.Size = new System.Drawing.Size(360, 28);
			this.txtSampleText.TabIndex = 4;
			this.txtSampleText.Text = "Hello, C#";
			// 
			// chkItalic
			// 
			this.chkItalic.AutoSize = true;
			this.chkItalic.Location = new System.Drawing.Point(289, 47);
			this.chkItalic.Name = "chkItalic";
			this.chkItalic.Size = new System.Drawing.Size(88, 22);
			this.chkItalic.TabIndex = 3;
			this.chkItalic.Text = "이탤릭";
			this.chkItalic.UseVisualStyleBackColor = true;
			this.chkItalic.Click += new System.EventHandler(this.chkItalic_Click_1);
			// 
			// chkBold
			// 
			this.chkBold.AutoSize = true;
			this.chkBold.Location = new System.Drawing.Point(213, 47);
			this.chkBold.Name = "chkBold";
			this.chkBold.Size = new System.Drawing.Size(70, 22);
			this.chkBold.TabIndex = 2;
			this.chkBold.Text = "굵게";
			this.chkBold.UseVisualStyleBackColor = true;
			this.chkBold.Click += new System.EventHandler(this.chkBold_Click);
			// 
			// cboFont
			// 
			this.cboFont.FormattingEnabled = true;
			this.cboFont.Location = new System.Drawing.Point(55, 45);
			this.cboFont.Name = "cboFont";
			this.cboFont.Size = new System.Drawing.Size(121, 26);
			this.cboFont.TabIndex = 1;
			this.cboFont.Click += new System.EventHandler(this.cboFont_Click);
			// 
			// lblFont
			// 
			this.lblFont.AutoSize = true;
			this.lblFont.Location = new System.Drawing.Point(6, 53);
			this.lblFont.Name = "lblFont";
			this.lblFont.Size = new System.Drawing.Size(43, 18);
			this.lblFont.TabIndex = 0;
			this.lblFont.Text = "Font";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grpFont);
			this.Name = "MainForm";
			this.Text = "Control Test";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.grpFont.ResumeLayout(false);
			this.grpFont.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpFont;
		private System.Windows.Forms.Label lblFont;
		private System.Windows.Forms.ComboBox cboFont;
		private System.Windows.Forms.TextBox txtSampleText;
		private System.Windows.Forms.CheckBox chkItalic;
		private System.Windows.Forms.CheckBox chkBold;
	}
}

