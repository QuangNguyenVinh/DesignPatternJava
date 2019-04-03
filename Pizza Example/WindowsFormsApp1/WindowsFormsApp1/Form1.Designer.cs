namespace WindowsFormsApp1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.windows1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.windows2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.windowsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// configToolStripMenuItem
			// 
			this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configColorToolStripMenuItem});
			this.configToolStripMenuItem.Name = "configToolStripMenuItem";
			this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.configToolStripMenuItem.Text = "Config";
			this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
			// 
			// configColorToolStripMenuItem
			// 
			this.configColorToolStripMenuItem.Name = "configColorToolStripMenuItem";
			this.configColorToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.configColorToolStripMenuItem.Text = "Config Color";
			this.configColorToolStripMenuItem.Click += new System.EventHandler(this.configColorToolStripMenuItem_Click);
			// 
			// windowsToolStripMenuItem
			// 
			this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windows1ToolStripMenuItem,
            this.windows2ToolStripMenuItem});
			this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
			this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.windowsToolStripMenuItem.Text = "Windows";
			// 
			// windows1ToolStripMenuItem
			// 
			this.windows1ToolStripMenuItem.Name = "windows1ToolStripMenuItem";
			this.windows1ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.windows1ToolStripMenuItem.Text = "Windows 1";
			this.windows1ToolStripMenuItem.Click += new System.EventHandler(this.windows1ToolStripMenuItem_Click);
			// 
			// windows2ToolStripMenuItem
			// 
			this.windows2ToolStripMenuItem.Name = "windows2ToolStripMenuItem";
			this.windows2ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.windows2ToolStripMenuItem.Text = "Windows 2";
			this.windows2ToolStripMenuItem.Click += new System.EventHandler(this.windows2ToolStripMenuItem_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(175, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(461, 205);
			this.button1.TabIndex = 1;
			this.button1.Text = "Nani";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem windows1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem windows2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configColorToolStripMenuItem;
		private System.Windows.Forms.Button button1;
	}
}

