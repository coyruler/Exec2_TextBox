namespace Q3
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnConfirm = new System.Windows.Forms.Button();
			this.txtBirth = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblBirth = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(34, 84);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(75, 23);
			this.btnConfirm.TabIndex = 0;
			this.btnConfirm.Text = "確認";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// txtBirth
			// 
			this.txtBirth.Location = new System.Drawing.Point(34, 56);
			this.txtBirth.Name = "txtBirth";
			this.txtBirth.Size = new System.Drawing.Size(100, 22);
			this.txtBirth.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "請輸入您的生日yyy/MM/dd";
			// 
			// lblBirth
			// 
			this.lblBirth.AutoSize = true;
			this.lblBirth.Location = new System.Drawing.Point(32, 132);
			this.lblBirth.Name = "lblBirth";
			this.lblBirth.Size = new System.Drawing.Size(33, 12);
			this.lblBirth.TabIndex = 3;
			this.lblBirth.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(241, 196);
			this.Controls.Add(this.lblBirth);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBirth);
			this.Controls.Add(this.btnConfirm);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.TextBox txtBirth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblBirth;
	}
}

