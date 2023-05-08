namespace WinFormsApp1
{
	partial class Menu
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnLoadCampagne = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNewCampagne = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLoadCampagne
			// 
			this.btnLoadCampagne.Location = new System.Drawing.Point(69, 112);
			this.btnLoadCampagne.Name = "btnLoadCampagne";
			this.btnLoadCampagne.Size = new System.Drawing.Size(145, 46);
			this.btnLoadCampagne.TabIndex = 0;
			this.btnLoadCampagne.Text = "Open a Campagne";
			this.btnLoadCampagne.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(69, 182);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(145, 46);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// btnNewCampagne
			// 
			this.btnNewCampagne.Location = new System.Drawing.Point(69, 40);
			this.btnNewCampagne.Name = "btnNewCampagne";
			this.btnNewCampagne.Size = new System.Drawing.Size(145, 46);
			this.btnNewCampagne.TabIndex = 2;
			this.btnNewCampagne.Text = "New Campagne";
			this.btnNewCampagne.UseVisualStyleBackColor = true;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.ClientSize = new System.Drawing.Size(280, 269);
			this.Controls.Add(this.btnNewCampagne);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnLoadCampagne);
			this.Name = "Menu";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private Button btnLoadCampagne;
		private Button btnClose;
		private Button btnNewCampagne;
	}
}