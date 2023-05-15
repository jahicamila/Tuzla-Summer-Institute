/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 7.7.2022.
 * Time: 13:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace calculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.result = new System.Windows.Forms.TextBox();
			this.digit1 = new System.Windows.Forms.Button();
			this.digit2 = new System.Windows.Forms.Button();
			this.digit3 = new System.Windows.Forms.Button();
			this.digit4 = new System.Windows.Forms.Button();
			this.digit5 = new System.Windows.Forms.Button();
			this.digit6 = new System.Windows.Forms.Button();
			this.digit7 = new System.Windows.Forms.Button();
			this.digit8 = new System.Windows.Forms.Button();
			this.digit9 = new System.Windows.Forms.Button();
			this.dott = new System.Windows.Forms.Button();
			this.plus = new System.Windows.Forms.Button();
			this.digit0 = new System.Windows.Forms.Button();
			this.divide = new System.Windows.Forms.Button();
			this.multiply = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.onestepback = new System.Windows.Forms.Button();
			this.equal = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// result
			// 
			this.result.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.result.Location = new System.Drawing.Point(12, 12);
			this.result.Multiline = true;
			this.result.Name = "result";
			this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.result.Size = new System.Drawing.Size(399, 81);
			this.result.TabIndex = 0;
			this.result.Text = "0";
			this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// digit1
			// 
			this.digit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.digit1.Location = new System.Drawing.Point(12, 99);
			this.digit1.Name = "digit1";
			this.digit1.Size = new System.Drawing.Size(75, 75);
			this.digit1.TabIndex = 1;
			this.digit1.Text = "1";
			this.digit1.UseVisualStyleBackColor = true;
			this.digit1.Click += new System.EventHandler(this.Button1Click);
			// 
			// digit2
			// 
			this.digit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.digit2.Location = new System.Drawing.Point(93, 99);
			this.digit2.Name = "digit2";
			this.digit2.Size = new System.Drawing.Size(75, 75);
			this.digit2.TabIndex = 2;
			this.digit2.Text = "2";
			this.digit2.UseVisualStyleBackColor = true;
			this.digit2.Click += new System.EventHandler(this.Digit2Click);
			// 
			// digit3
			// 
			this.digit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.digit3.Location = new System.Drawing.Point(174, 99);
			this.digit3.Name = "digit3";
			this.digit3.Size = new System.Drawing.Size(75, 75);
			this.digit3.TabIndex = 3;
			this.digit3.Text = "3";
			this.digit3.UseVisualStyleBackColor = true;
			this.digit3.Click += new System.EventHandler(this.Digit3Click);
			// 
			// digit4
			// 
			this.digit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.digit4.Location = new System.Drawing.Point(12, 180);
			this.digit4.Name = "digit4";
			this.digit4.Size = new System.Drawing.Size(75, 75);
			this.digit4.TabIndex = 4;
			this.digit4.Text = "4";
			this.digit4.UseVisualStyleBackColor = true;
			this.digit4.Click += new System.EventHandler(this.Digit4Click);
			// 
			// digit5
			// 
			this.digit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.digit5.Location = new System.Drawing.Point(93, 180);
			this.digit5.Name = "digit5";
			this.digit5.Size = new System.Drawing.Size(75, 75);
			this.digit5.TabIndex = 5;
			this.digit5.Text = "5";
			this.digit5.UseVisualStyleBackColor = true;
			this.digit5.Click += new System.EventHandler(this.Digit5Click);
			// 
			// digit6
			// 
			this.digit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.digit6.Location = new System.Drawing.Point(174, 180);
			this.digit6.Name = "digit6";
			this.digit6.Size = new System.Drawing.Size(75, 75);
			this.digit6.TabIndex = 6;
			this.digit6.Text = "6";
			this.digit6.UseVisualStyleBackColor = true;
			this.digit6.Click += new System.EventHandler(this.Digit6Click);
			// 
			// digit7
			// 
			this.digit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.digit7.Location = new System.Drawing.Point(12, 261);
			this.digit7.Name = "digit7";
			this.digit7.Size = new System.Drawing.Size(75, 75);
			this.digit7.TabIndex = 7;
			this.digit7.Text = "7";
			this.digit7.UseVisualStyleBackColor = true;
			this.digit7.Click += new System.EventHandler(this.Digit7Click);
			// 
			// digit8
			// 
			this.digit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.digit8.Location = new System.Drawing.Point(93, 261);
			this.digit8.Name = "digit8";
			this.digit8.Size = new System.Drawing.Size(75, 75);
			this.digit8.TabIndex = 8;
			this.digit8.Text = "8";
			this.digit8.UseVisualStyleBackColor = true;
			this.digit8.Click += new System.EventHandler(this.Digit8Click);
			// 
			// digit9
			// 
			this.digit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.digit9.Location = new System.Drawing.Point(174, 261);
			this.digit9.Name = "digit9";
			this.digit9.Size = new System.Drawing.Size(75, 75);
			this.digit9.TabIndex = 9;
			this.digit9.Text = "9";
			this.digit9.UseVisualStyleBackColor = true;
			this.digit9.Click += new System.EventHandler(this.Digit9Click);
			// 
			// dott
			// 
			this.dott.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dott.Location = new System.Drawing.Point(12, 342);
			this.dott.Name = "dott";
			this.dott.Size = new System.Drawing.Size(75, 75);
			this.dott.TabIndex = 10;
			this.dott.Text = ".";
			this.dott.UseVisualStyleBackColor = true;
			this.dott.Click += new System.EventHandler(this.DottClick);
			// 
			// plus
			// 
			this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.plus.Location = new System.Drawing.Point(255, 342);
			this.plus.Name = "plus";
			this.plus.Size = new System.Drawing.Size(75, 75);
			this.plus.TabIndex = 11;
			this.plus.Text = "+";
			this.plus.UseVisualStyleBackColor = true;
			this.plus.Click += new System.EventHandler(this.PlusClick);
			// 
			// digit0
			// 
			this.digit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.digit0.Location = new System.Drawing.Point(93, 342);
			this.digit0.Name = "digit0";
			this.digit0.Size = new System.Drawing.Size(156, 75);
			this.digit0.TabIndex = 12;
			this.digit0.Text = "0";
			this.digit0.UseVisualStyleBackColor = true;
			this.digit0.Click += new System.EventHandler(this.Digit0Click);
			// 
			// divide
			// 
			this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.divide.Location = new System.Drawing.Point(255, 99);
			this.divide.Name = "divide";
			this.divide.Size = new System.Drawing.Size(75, 75);
			this.divide.TabIndex = 13;
			this.divide.Text = "/";
			this.divide.UseVisualStyleBackColor = true;
			this.divide.Click += new System.EventHandler(this.DivideClick);
			// 
			// multiply
			// 
			this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.multiply.Location = new System.Drawing.Point(255, 180);
			this.multiply.Name = "multiply";
			this.multiply.Size = new System.Drawing.Size(75, 75);
			this.multiply.TabIndex = 14;
			this.multiply.Text = "*";
			this.multiply.UseVisualStyleBackColor = true;
			this.multiply.Click += new System.EventHandler(this.MultiplyClick);
			// 
			// minus
			// 
			this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.minus.Location = new System.Drawing.Point(255, 261);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(75, 75);
			this.minus.TabIndex = 15;
			this.minus.Text = "-";
			this.minus.UseVisualStyleBackColor = true;
			this.minus.Click += new System.EventHandler(this.MinusClick);
			// 
			// delete
			// 
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.delete.Location = new System.Drawing.Point(336, 99);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(75, 75);
			this.delete.TabIndex = 16;
			this.delete.Text = "C";
			this.delete.UseVisualStyleBackColor = true;
			// 
			// onestepback
			// 
			this.onestepback.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.onestepback.Location = new System.Drawing.Point(336, 180);
			this.onestepback.Name = "onestepback";
			this.onestepback.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.onestepback.Size = new System.Drawing.Size(75, 75);
			this.onestepback.TabIndex = 17;
			this.onestepback.Text = "<-";
			this.onestepback.UseVisualStyleBackColor = true;
			// 
			// equal
			// 
			this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.equal.Location = new System.Drawing.Point(336, 261);
			this.equal.Name = "equal";
			this.equal.Size = new System.Drawing.Size(75, 156);
			this.equal.TabIndex = 18;
			this.equal.Text = "=";
			this.equal.UseVisualStyleBackColor = true;
			this.equal.Click += new System.EventHandler(this.EqualClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 458);
			this.Controls.Add(this.equal);
			this.Controls.Add(this.onestepback);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.multiply);
			this.Controls.Add(this.divide);
			this.Controls.Add(this.digit0);
			this.Controls.Add(this.plus);
			this.Controls.Add(this.dott);
			this.Controls.Add(this.digit9);
			this.Controls.Add(this.digit8);
			this.Controls.Add(this.digit7);
			this.Controls.Add(this.digit6);
			this.Controls.Add(this.digit5);
			this.Controls.Add(this.digit4);
			this.Controls.Add(this.digit3);
			this.Controls.Add(this.digit2);
			this.Controls.Add(this.digit1);
			this.Controls.Add(this.result);
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "calculator";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button equal;
		private System.Windows.Forms.Button onestepback;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button minus;
		private System.Windows.Forms.Button multiply;
		private System.Windows.Forms.Button divide;
		private System.Windows.Forms.Button digit0;
		private System.Windows.Forms.Button plus;
		private System.Windows.Forms.Button dott;
		private System.Windows.Forms.Button digit9;
		private System.Windows.Forms.Button digit8;
		private System.Windows.Forms.Button digit7;
		private System.Windows.Forms.Button digit6;
		private System.Windows.Forms.Button digit5;
		private System.Windows.Forms.Button digit4;
		private System.Windows.Forms.Button digit3;
		private System.Windows.Forms.Button digit2;
		private System.Windows.Forms.Button digit1;
		private System.Windows.Forms.TextBox result;
	}
}
