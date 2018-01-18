namespace Lotto_Picker
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
			this.btnRandom = new System.Windows.Forms.Button();
			this.lblOne = new System.Windows.Forms.Label();
			this.lblSix = new System.Windows.Forms.Label();
			this.lblFive = new System.Windows.Forms.Label();
			this.lblFour = new System.Windows.Forms.Label();
			this.lblThree = new System.Windows.Forms.Label();
			this.lblTwo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRandom
			// 
			this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRandom.Location = new System.Drawing.Point(275, 171);
			this.btnRandom.Name = "btnRandom";
			this.btnRandom.Size = new System.Drawing.Size(189, 71);
			this.btnRandom.TabIndex = 0;
			this.btnRandom.Text = "Pick Random Numbers";
			this.btnRandom.UseVisualStyleBackColor = true;
			this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
			// 
			// lblOne
			// 
			this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOne.Image = global::Lotto_Picker.Properties.Resources.Lotto_Token;
			this.lblOne.Location = new System.Drawing.Point(22, 9);
			this.lblOne.Name = "lblOne";
			this.lblOne.Size = new System.Drawing.Size(111, 124);
			this.lblOne.TabIndex = 1;
			this.lblOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSix
			// 
			this.lblSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSix.Image = global::Lotto_Picker.Properties.Resources.Lotto_Token;
			this.lblSix.Location = new System.Drawing.Point(607, 9);
			this.lblSix.Name = "lblSix";
			this.lblSix.Size = new System.Drawing.Size(111, 124);
			this.lblSix.TabIndex = 2;
			this.lblSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFive
			// 
			this.lblFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFive.Image = global::Lotto_Picker.Properties.Resources.Lotto_Token;
			this.lblFive.Location = new System.Drawing.Point(490, 9);
			this.lblFive.Name = "lblFive";
			this.lblFive.Size = new System.Drawing.Size(111, 124);
			this.lblFive.TabIndex = 3;
			this.lblFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFour
			// 
			this.lblFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFour.Image = global::Lotto_Picker.Properties.Resources.Lotto_Token;
			this.lblFour.Location = new System.Drawing.Point(373, 9);
			this.lblFour.Name = "lblFour";
			this.lblFour.Size = new System.Drawing.Size(111, 124);
			this.lblFour.TabIndex = 4;
			this.lblFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblThree
			// 
			this.lblThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblThree.Image = global::Lotto_Picker.Properties.Resources.Lotto_Token;
			this.lblThree.Location = new System.Drawing.Point(256, 9);
			this.lblThree.Name = "lblThree";
			this.lblThree.Size = new System.Drawing.Size(111, 124);
			this.lblThree.TabIndex = 5;
			this.lblThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTwo
			// 
			this.lblTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTwo.Image = global::Lotto_Picker.Properties.Resources.Lotto_Token;
			this.lblTwo.Location = new System.Drawing.Point(139, 9);
			this.lblTwo.Name = "lblTwo";
			this.lblTwo.Size = new System.Drawing.Size(111, 124);
			this.lblTwo.TabIndex = 6;
			this.lblTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 266);
			this.Controls.Add(this.lblTwo);
			this.Controls.Add(this.lblThree);
			this.Controls.Add(this.lblFour);
			this.Controls.Add(this.lblFive);
			this.Controls.Add(this.lblSix);
			this.Controls.Add(this.lblOne);
			this.Controls.Add(this.btnRandom);
			this.Name = "Form1";
			this.Text = "Lotto Picker";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnRandom;
		private System.Windows.Forms.Label lblOne;
		private System.Windows.Forms.Label lblSix;
		private System.Windows.Forms.Label lblFive;
		private System.Windows.Forms.Label lblFour;
		private System.Windows.Forms.Label lblThree;
		private System.Windows.Forms.Label lblTwo;
	}
}

