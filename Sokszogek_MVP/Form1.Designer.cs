﻿namespace Sokszogek_MVP
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTerulet = new System.Windows.Forms.TextBox();
            this.textBoxKerulet = new System.Windows.Forms.TextBox();
            this.comboBoxSokszog = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxOldalA = new System.Windows.Forms.TextBox();
            this.labelOldalC = new System.Windows.Forms.Label();
            this.labelOldalB = new System.Windows.Forms.Label();
            this.textBoxOldalC = new System.Windows.Forms.TextBox();
            this.textBoxOldalB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSzamol = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTerulet, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxKerulet, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSokszog, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.38272F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.61728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(223, 127);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Terület";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kerület";
            // 
            // textBoxTerulet
            // 
            this.textBoxTerulet.Location = new System.Drawing.Point(114, 84);
            this.textBoxTerulet.Name = "textBoxTerulet";
            this.textBoxTerulet.Size = new System.Drawing.Size(106, 20);
            this.textBoxTerulet.TabIndex = 5;
            // 
            // textBoxKerulet
            // 
            this.textBoxKerulet.Location = new System.Drawing.Point(114, 43);
            this.textBoxKerulet.Name = "textBoxKerulet";
            this.textBoxKerulet.Size = new System.Drawing.Size(105, 20);
            this.textBoxKerulet.TabIndex = 3;
            // 
            // comboBoxSokszog
            // 
            this.comboBoxSokszog.FormattingEnabled = true;
            this.comboBoxSokszog.Location = new System.Drawing.Point(114, 3);
            this.comboBoxSokszog.Name = "comboBoxSokszog";
            this.comboBoxSokszog.Size = new System.Drawing.Size(105, 21);
            this.comboBoxSokszog.TabIndex = 6;
            this.comboBoxSokszog.SelectedIndexChanged += new System.EventHandler(this.comboBoxSokszog_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sokszög";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxOldalA, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelOldalC, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelOldalB, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxOldalC, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxOldalB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(276, 69);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.38272F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.61728F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(223, 127);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // textBoxOldalA
            // 
            this.textBoxOldalA.Location = new System.Drawing.Point(114, 3);
            this.textBoxOldalA.Name = "textBoxOldalA";
            this.textBoxOldalA.Size = new System.Drawing.Size(106, 20);
            this.textBoxOldalA.TabIndex = 10;
            // 
            // labelOldalC
            // 
            this.labelOldalC.AutoSize = true;
            this.labelOldalC.Location = new System.Drawing.Point(3, 81);
            this.labelOldalC.Name = "labelOldalC";
            this.labelOldalC.Size = new System.Drawing.Size(41, 13);
            this.labelOldalC.TabIndex = 9;
            this.labelOldalC.Text = "Oldal C";
            // 
            // labelOldalB
            // 
            this.labelOldalB.AutoSize = true;
            this.labelOldalB.Location = new System.Drawing.Point(3, 40);
            this.labelOldalB.Name = "labelOldalB";
            this.labelOldalB.Size = new System.Drawing.Size(41, 13);
            this.labelOldalB.TabIndex = 8;
            this.labelOldalB.Text = "Oldal B";
            // 
            // textBoxOldalC
            // 
            this.textBoxOldalC.Location = new System.Drawing.Point(114, 84);
            this.textBoxOldalC.Name = "textBoxOldalC";
            this.textBoxOldalC.Size = new System.Drawing.Size(106, 20);
            this.textBoxOldalC.TabIndex = 5;
            // 
            // textBoxOldalB
            // 
            this.textBoxOldalB.Location = new System.Drawing.Point(114, 43);
            this.textBoxOldalB.Name = "textBoxOldalB";
            this.textBoxOldalB.Size = new System.Drawing.Size(105, 20);
            this.textBoxOldalB.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Oldal A";
            // 
            // buttonSzamol
            // 
            this.buttonSzamol.Location = new System.Drawing.Point(26, 227);
            this.buttonSzamol.Name = "buttonSzamol";
            this.buttonSzamol.Size = new System.Drawing.Size(75, 23);
            this.buttonSzamol.TabIndex = 3;
            this.buttonSzamol.Text = "Kiszámol";
            this.buttonSzamol.UseVisualStyleBackColor = true;
            this.buttonSzamol.Click += new System.EventHandler(this.buttonSzamol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 277);
            this.Controls.Add(this.buttonSzamol);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTerulet;
        private System.Windows.Forms.TextBox textBoxKerulet;
        private System.Windows.Forms.ComboBox comboBoxSokszog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelOldalC;
        private System.Windows.Forms.Label labelOldalB;
        private System.Windows.Forms.TextBox textBoxOldalC;
        private System.Windows.Forms.TextBox textBoxOldalB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSzamol;
        private System.Windows.Forms.TextBox textBoxOldalA;
    }
}

