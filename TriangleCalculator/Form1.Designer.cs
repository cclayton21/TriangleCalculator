
namespace TriangleCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.outputTxt = new System.Windows.Forms.Label();
            this.sideA = new System.Windows.Forms.NumericUpDown();
            this.sideB = new System.Windows.Forms.NumericUpDown();
            this.sideC = new System.Windows.Forms.NumericUpDown();
            this.angleA = new System.Windows.Forms.Label();
            this.angleB = new System.Windows.Forms.Label();
            this.angleC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sideA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Purpose: Provides information about a triangle given the lenghts of three sides";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inputs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Side a length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Side b length:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Side c length:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Output:";
            // 
            // outputTxt
            // 
            this.outputTxt.AutoSize = true;
            this.outputTxt.Location = new System.Drawing.Point(32, 214);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.Size = new System.Drawing.Size(37, 13);
            this.outputTxt.TabIndex = 11;
            this.outputTxt.Text = "output";
            // 
            // sideA
            // 
            this.sideA.Location = new System.Drawing.Point(107, 62);
            this.sideA.Name = "sideA";
            this.sideA.Size = new System.Drawing.Size(120, 20);
            this.sideA.TabIndex = 12;
            this.sideA.ValueChanged += new System.EventHandler(this.sideA_ValueChanged);
            // 
            // sideB
            // 
            this.sideB.Location = new System.Drawing.Point(108, 97);
            this.sideB.Name = "sideB";
            this.sideB.Size = new System.Drawing.Size(120, 20);
            this.sideB.TabIndex = 13;
            this.sideB.ValueChanged += new System.EventHandler(this.sideB_ValueChanged);
            // 
            // sideC
            // 
            this.sideC.Location = new System.Drawing.Point(108, 133);
            this.sideC.Name = "sideC";
            this.sideC.Size = new System.Drawing.Size(120, 20);
            this.sideC.TabIndex = 14;
            this.sideC.ValueChanged += new System.EventHandler(this.sideC_ValueChanged);
            // 
            // angleA
            // 
            this.angleA.AutoSize = true;
            this.angleA.Location = new System.Drawing.Point(38, 237);
            this.angleA.Name = "angleA";
            this.angleA.Size = new System.Drawing.Size(13, 13);
            this.angleA.TabIndex = 15;
            this.angleA.Text = "a";
            // 
            // angleB
            // 
            this.angleB.AutoSize = true;
            this.angleB.Location = new System.Drawing.Point(38, 250);
            this.angleB.Name = "angleB";
            this.angleB.Size = new System.Drawing.Size(13, 13);
            this.angleB.TabIndex = 16;
            this.angleB.Text = "b";
            // 
            // angleC
            // 
            this.angleC.AutoSize = true;
            this.angleC.Location = new System.Drawing.Point(38, 263);
            this.angleC.Name = "angleC";
            this.angleC.Size = new System.Drawing.Size(13, 13);
            this.angleC.TabIndex = 17;
            this.angleC.Text = "c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.angleC);
            this.Controls.Add(this.angleB);
            this.Controls.Add(this.angleA);
            this.Controls.Add(this.sideC);
            this.Controls.Add(this.sideB);
            this.Controls.Add(this.sideA);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Triangle Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.sideA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label outputTxt;
        private System.Windows.Forms.NumericUpDown sideA;
        private System.Windows.Forms.NumericUpDown sideB;
        private System.Windows.Forms.NumericUpDown sideC;
        private System.Windows.Forms.Label angleA;
        private System.Windows.Forms.Label angleB;
        private System.Windows.Forms.Label angleC;
    }
}

