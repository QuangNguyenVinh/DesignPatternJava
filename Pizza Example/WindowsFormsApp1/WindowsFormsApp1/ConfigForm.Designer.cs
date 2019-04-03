namespace WindowsFormsApp1
{
	partial class ConfigForm
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
			this.btnRed = new System.Windows.Forms.Button();
			this.btnBlue = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnRed
			// 
			this.btnRed.Location = new System.Drawing.Point(119, 88);
			this.btnRed.Name = "btnRed";
			this.btnRed.Size = new System.Drawing.Size(154, 87);
			this.btnRed.TabIndex = 0;
			this.btnRed.Text = "red";
			this.btnRed.UseVisualStyleBackColor = true;
			this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
			// 
			// btnBlue
			// 
			this.btnBlue.Location = new System.Drawing.Point(494, 88);
			this.btnBlue.Name = "btnBlue";
			this.btnBlue.Size = new System.Drawing.Size(154, 87);
			this.btnBlue.TabIndex = 0;
			this.btnBlue.Text = "blue";
			this.btnBlue.UseVisualStyleBackColor = true;
			this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(312, 258);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(154, 87);
			this.btnReset.TabIndex = 0;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// ConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnBlue);
			this.Controls.Add(this.btnRed);
			this.Name = "ConfigForm";
			this.Text = "ConfigForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnRed;
		private System.Windows.Forms.Button btnBlue;
		private System.Windows.Forms.Button btnReset;
	}
}