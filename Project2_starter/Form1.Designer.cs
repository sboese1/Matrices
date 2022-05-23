
namespace Project2_starter
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MatrixOneText = new System.Windows.Forms.TextBox();
            this.MatrixTwoText = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultingMatrixText = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Matrix 1 from File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load Matrix 2 from File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MatrixOneText
            // 
            this.MatrixOneText.Location = new System.Drawing.Point(32, 77);
            this.MatrixOneText.Multiline = true;
            this.MatrixOneText.Name = "MatrixOneText";
            this.MatrixOneText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MatrixOneText.Size = new System.Drawing.Size(217, 189);
            this.MatrixOneText.TabIndex = 2;
            this.MatrixOneText.WordWrap = false;
            // 
            // MatrixTwoText
            // 
            this.MatrixTwoText.Location = new System.Drawing.Point(374, 77);
            this.MatrixTwoText.Multiline = true;
            this.MatrixTwoText.Name = "MatrixTwoText";
            this.MatrixTwoText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MatrixTwoText.Size = new System.Drawing.Size(224, 189);
            this.MatrixTwoText.TabIndex = 3;
            this.MatrixTwoText.WordWrap = false;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(170, 292);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 34);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(374, 292);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(75, 34);
            this.MultiplyButton.TabIndex = 5;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resulting Matrix:";
            // 
            // ResultingMatrixText
            // 
            this.ResultingMatrixText.Location = new System.Drawing.Point(170, 402);
            this.ResultingMatrixText.Multiline = true;
            this.ResultingMatrixText.Name = "ResultingMatrixText";
            this.ResultingMatrixText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultingMatrixText.Size = new System.Drawing.Size(280, 215);
            this.ResultingMatrixText.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(222, 635);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 31);
            this.button5.TabIndex = 8;
            this.button5.Text = "Save Result to File";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 678);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ResultingMatrixText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MatrixTwoText);
            this.Controls.Add(this.MatrixOneText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox MatrixOneText;
        private System.Windows.Forms.TextBox MatrixTwoText;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultingMatrixText;
        private System.Windows.Forms.Button button5;
    }
}

