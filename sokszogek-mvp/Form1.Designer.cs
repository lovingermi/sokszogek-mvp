namespace sokszogek_mvp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSokszog = new System.Windows.Forms.ComboBox();
            this.textBoxKerulet = new System.Windows.Forms.TextBox();
            this.textBoxTerulet = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOldalB = new System.Windows.Forms.TextBox();
            this.textBoxOldalA = new System.Windows.Forms.TextBox();
            this.textBoxOldalC = new System.Windows.Forms.TextBox();
            this.buttonKiszamol = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.43988F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.56012F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxTerulet, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSokszog, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxKerulet, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sokszög";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kerület";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Terület";
            // 
            // comboBoxSokszog
            // 
            this.comboBoxSokszog.FormattingEnabled = true;
            this.comboBoxSokszog.Location = new System.Drawing.Point(175, 3);
            this.comboBoxSokszog.Name = "comboBoxSokszog";
            this.comboBoxSokszog.Size = new System.Drawing.Size(163, 21);
            this.comboBoxSokszog.TabIndex = 6;
            // 
            // textBoxKerulet
            // 
            this.textBoxKerulet.Location = new System.Drawing.Point(175, 60);
            this.textBoxKerulet.Name = "textBoxKerulet";
            this.textBoxKerulet.Size = new System.Drawing.Size(163, 20);
            this.textBoxKerulet.TabIndex = 7;
            // 
            // textBoxTerulet
            // 
            this.textBoxTerulet.Location = new System.Drawing.Point(175, 117);
            this.textBoxTerulet.Name = "textBoxTerulet";
            this.textBoxTerulet.Size = new System.Drawing.Size(163, 20);
            this.textBoxTerulet.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.43988F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.56012F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxOldalA, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxOldalB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxOldalC, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(433, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(314, 174);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "OldalC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "OldalB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "OldalA";
            // 
            // textBoxOldalB
            // 
            this.textBoxOldalB.Location = new System.Drawing.Point(161, 58);
            this.textBoxOldalB.Name = "textBoxOldalB";
            this.textBoxOldalB.Size = new System.Drawing.Size(150, 20);
            this.textBoxOldalB.TabIndex = 7;
            // 
            // textBoxOldalA
            // 
            this.textBoxOldalA.Location = new System.Drawing.Point(161, 3);
            this.textBoxOldalA.Name = "textBoxOldalA";
            this.textBoxOldalA.Size = new System.Drawing.Size(150, 20);
            this.textBoxOldalA.TabIndex = 9;
            // 
            // textBoxOldalC
            // 
            this.textBoxOldalC.Location = new System.Drawing.Point(161, 113);
            this.textBoxOldalC.Name = "textBoxOldalC";
            this.textBoxOldalC.Size = new System.Drawing.Size(150, 20);
            this.textBoxOldalC.TabIndex = 10;
            // 
            // buttonKiszamol
            // 
            this.buttonKiszamol.Location = new System.Drawing.Point(27, 246);
            this.buttonKiszamol.Name = "buttonKiszamol";
            this.buttonKiszamol.Size = new System.Drawing.Size(144, 23);
            this.buttonKiszamol.TabIndex = 10;
            this.buttonKiszamol.Text = "Kiszámol";
            this.buttonKiszamol.UseVisualStyleBackColor = true;
            this.buttonKiszamol.Click += new System.EventHandler(this.buttonKiszamol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKiszamol);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTerulet;
        private System.Windows.Forms.ComboBox comboBoxSokszog;
        private System.Windows.Forms.TextBox textBoxKerulet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOldalB;
        private System.Windows.Forms.TextBox textBoxOldalA;
        private System.Windows.Forms.TextBox textBoxOldalC;
        private System.Windows.Forms.Button buttonKiszamol;
    }
}

