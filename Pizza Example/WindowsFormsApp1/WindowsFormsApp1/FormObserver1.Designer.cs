namespace WindowsFormsApp1
{
	partial class FormObserver1
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
			this.button1 = new System.Windows.Forms.Button();
			this.btnBreakup = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(308, 150);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 99);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnBreakup
			// 
			this.btnBreakup.Location = new System.Drawing.Point(330, 318);
			this.btnBreakup.Name = "btnBreakup";
			this.btnBreakup.Size = new System.Drawing.Size(106, 44);
			this.btnBreakup.TabIndex = 1;
			this.btnBreakup.Text = "Break up";
			this.btnBreakup.UseVisualStyleBackColor = true;
			this.btnBreakup.Click += new System.EventHandler(this.btnBreakup_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(601, 170);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 58);
			this.button2.TabIndex = 2;
			this.button2.Text = "Nani";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// FormObserver1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnBreakup);
			this.Controls.Add(this.button1);
			this.Name = "FormObserver1";
			this.Text = "FormObserver1";
			this.Load += new System.EventHandler(this.FormObserver1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnBreakup;
		private System.Windows.Forms.Button button2;
	}
}