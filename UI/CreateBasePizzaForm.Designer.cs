namespace Pizzeria
{
    partial class CreateBasePizzaForm
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
            this.wheatCheckBox = new System.Windows.Forms.CheckBox();
            this.wholeWheatCheckBox = new System.Windows.Forms.CheckBox();
            this.riceCheckBox = new System.Windows.Forms.CheckBox();
            this.cornCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PestoCheckBox = new System.Windows.Forms.CheckBox();
            this.garlicCheckBox = new System.Windows.Forms.CheckBox();
            this.tomatoCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // wheatCheckBox
            // 
            this.wheatCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wheatCheckBox.AutoSize = true;
            this.wheatCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wheatCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wheatCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wheatCheckBox.Location = new System.Drawing.Point(215, 84);
            this.wheatCheckBox.Name = "wheatCheckBox";
            this.wheatCheckBox.Size = new System.Drawing.Size(105, 36);
            this.wheatCheckBox.TabIndex = 0;
            this.wheatCheckBox.Text = "Wheat";
            this.wheatCheckBox.UseVisualStyleBackColor = true;
            this.wheatCheckBox.CheckedChanged += new System.EventHandler(this.WheatCheckBox_CheckedChanged);
            // 
            // wholeWheatCheckBox
            // 
            this.wholeWheatCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wholeWheatCheckBox.AutoSize = true;
            this.wholeWheatCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wholeWheatCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wholeWheatCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wholeWheatCheckBox.Location = new System.Drawing.Point(215, 130);
            this.wholeWheatCheckBox.Name = "wholeWheatCheckBox";
            this.wholeWheatCheckBox.Size = new System.Drawing.Size(175, 36);
            this.wholeWheatCheckBox.TabIndex = 1;
            this.wholeWheatCheckBox.Text = "Whole wheat";
            this.wholeWheatCheckBox.UseVisualStyleBackColor = true;
            this.wholeWheatCheckBox.CheckedChanged += new System.EventHandler(this.WholeWheetCheckBox_CheckedChanged);
            // 
            // riceCheckBox
            // 
            this.riceCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.riceCheckBox.AutoSize = true;
            this.riceCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.riceCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.riceCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.riceCheckBox.Location = new System.Drawing.Point(215, 176);
            this.riceCheckBox.Name = "riceCheckBox";
            this.riceCheckBox.Size = new System.Drawing.Size(80, 36);
            this.riceCheckBox.TabIndex = 2;
            this.riceCheckBox.Text = "Rice";
            this.riceCheckBox.UseVisualStyleBackColor = true;
            this.riceCheckBox.CheckedChanged += new System.EventHandler(this.riceCheckBox_CheckedChanged);
            // 
            // cornCheckBox
            // 
            this.cornCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cornCheckBox.AutoSize = true;
            this.cornCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cornCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cornCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cornCheckBox.Location = new System.Drawing.Point(215, 222);
            this.cornCheckBox.Name = "cornCheckBox";
            this.cornCheckBox.Size = new System.Drawing.Size(88, 36);
            this.cornCheckBox.TabIndex = 3;
            this.cornCheckBox.Text = "Corn";
            this.cornCheckBox.UseVisualStyleBackColor = true;
            this.cornCheckBox.CheckedChanged += new System.EventHandler(this.cornCheckBox_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.okButton.Location = new System.Drawing.Point(332, 491);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(145, 44);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Clicked);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(215, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(290, 38);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Select type of dough";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(215, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(290, 38);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Select type of sause";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PestoCheckBox
            // 
            this.PestoCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PestoCheckBox.AutoSize = true;
            this.PestoCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PestoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PestoCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PestoCheckBox.Location = new System.Drawing.Point(215, 437);
            this.PestoCheckBox.Name = "PestoCheckBox";
            this.PestoCheckBox.Size = new System.Drawing.Size(92, 36);
            this.PestoCheckBox.TabIndex = 8;
            this.PestoCheckBox.Text = "Pesto";
            this.PestoCheckBox.UseVisualStyleBackColor = true;
            this.PestoCheckBox.CheckedChanged += new System.EventHandler(this.PestoCheckBox_CheckedChanged);
            // 
            // garlicCheckBox
            // 
            this.garlicCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.garlicCheckBox.AutoSize = true;
            this.garlicCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.garlicCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.garlicCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.garlicCheckBox.Location = new System.Drawing.Point(215, 391);
            this.garlicCheckBox.Name = "garlicCheckBox";
            this.garlicCheckBox.Size = new System.Drawing.Size(98, 36);
            this.garlicCheckBox.TabIndex = 7;
            this.garlicCheckBox.Text = "Garlic";
            this.garlicCheckBox.UseVisualStyleBackColor = true;
            this.garlicCheckBox.CheckedChanged += new System.EventHandler(this.GarlicCheckBox_CheckedChanged);
            // 
            // tomatoCheckBox
            // 
            this.tomatoCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tomatoCheckBox.AutoSize = true;
            this.tomatoCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tomatoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tomatoCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tomatoCheckBox.Location = new System.Drawing.Point(215, 345);
            this.tomatoCheckBox.Name = "tomatoCheckBox";
            this.tomatoCheckBox.Size = new System.Drawing.Size(115, 36);
            this.tomatoCheckBox.TabIndex = 6;
            this.tomatoCheckBox.Text = "Tomato";
            this.tomatoCheckBox.UseVisualStyleBackColor = true;
            this.tomatoCheckBox.CheckedChanged += new System.EventHandler(this.TomatoCheckBox_CheckedChanged);
            // 
            // CreateBasePizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PestoCheckBox);
            this.Controls.Add(this.garlicCheckBox);
            this.Controls.Add(this.tomatoCheckBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cornCheckBox);
            this.Controls.Add(this.riceCheckBox);
            this.Controls.Add(this.wholeWheatCheckBox);
            this.Controls.Add(this.wheatCheckBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "CreateBasePizzaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePizza";
            this.Load += new System.EventHandler(this.CreatePizzaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox wheatCheckBox;
        private System.Windows.Forms.CheckBox wholeWheatCheckBox;
        private System.Windows.Forms.CheckBox riceCheckBox;
        private System.Windows.Forms.CheckBox cornCheckBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox PestoCheckBox;
        private System.Windows.Forms.CheckBox garlicCheckBox;
        private System.Windows.Forms.CheckBox tomatoCheckBox;
    }
}