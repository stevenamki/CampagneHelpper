namespace CampagneHelpperInterface
{
	partial class AddChapter
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
			this.RDescription = new System.Windows.Forms.RichTextBox();
			this.LDescription = new System.Windows.Forms.Label();
			this.TxtTitle = new System.Windows.Forms.TextBox();
			this.lTitle = new System.Windows.Forms.Label();
			this.BtnCreate = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// RDescription
			// 
			this.RDescription.Location = new System.Drawing.Point(12, 91);
			this.RDescription.Name = "RDescription";
			this.RDescription.Size = new System.Drawing.Size(776, 312);
			this.RDescription.TabIndex = 0;
			this.RDescription.Text = "";
			// 
			// LDescription
			// 
			this.LDescription.AutoSize = true;
			this.LDescription.Location = new System.Drawing.Point(12, 73);
			this.LDescription.Name = "LDescription";
			this.LDescription.Size = new System.Drawing.Size(67, 15);
			this.LDescription.TabIndex = 1;
			this.LDescription.Text = "Description";
			// 
			// TxtTitle
			// 
			this.TxtTitle.Location = new System.Drawing.Point(47, 23);
			this.TxtTitle.Name = "TxtTitle";
			this.TxtTitle.Size = new System.Drawing.Size(484, 23);
			this.TxtTitle.TabIndex = 2;
			// 
			// lTitle
			// 
			this.lTitle.AutoSize = true;
			this.lTitle.Location = new System.Drawing.Point(12, 26);
			this.lTitle.Name = "lTitle";
			this.lTitle.Size = new System.Drawing.Size(29, 15);
			this.lTitle.TabIndex = 3;
			this.lTitle.Text = "Title";
			// 
			// BtnCreate
			// 
			this.BtnCreate.Location = new System.Drawing.Point(713, 415);
			this.BtnCreate.Name = "BtnCreate";
			this.BtnCreate.Size = new System.Drawing.Size(75, 23);
			this.BtnCreate.TabIndex = 4;
			this.BtnCreate.Text = "Create";
			this.BtnCreate.UseVisualStyleBackColor = true;
			// 
			// BtnCancel
			// 
			this.BtnCancel.Location = new System.Drawing.Point(632, 415);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(75, 23);
			this.BtnCancel.TabIndex = 5;
			this.BtnCancel.Text = "Cancel";
			this.BtnCancel.UseVisualStyleBackColor = true;
			// 
			// AddChapter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnCreate);
			this.Controls.Add(this.lTitle);
			this.Controls.Add(this.TxtTitle);
			this.Controls.Add(this.LDescription);
			this.Controls.Add(this.RDescription);
			this.Name = "AddChapter";
			this.Text = "AddChapter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RichTextBox RDescription;
		private Label LDescription;
		private TextBox TxtTitle;
		private Label lTitle;
		private Button BtnCreate;
		private Button BtnCancel;
	}
}