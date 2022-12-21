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
			this.btnCampagne = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCampagne
			// 
			this.btnCampagne.Location = new System.Drawing.Point(69, 45);
			this.btnCampagne.Name = "btnCampagne";
			this.btnCampagne.Size = new System.Drawing.Size(145, 46);
			this.btnCampagne.TabIndex = 0;
			this.btnCampagne.Text = "Open a Campagne";
			this.btnCampagne.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(69, 131);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(145, 46);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.ClientSize = new System.Drawing.Size(280, 219);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCampagne);
			this.Name = "Menu";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private Button btnCampagne;
		private Button btnClose;
	}
}