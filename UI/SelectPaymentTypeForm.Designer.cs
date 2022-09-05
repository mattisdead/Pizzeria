namespace Pizzeria
{
    partial class SelectPaymentTypeForm
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
            this.creditCardButton = new System.Windows.Forms.Button();
            this.debitCardButton = new System.Windows.Forms.Button();
            this.cashButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.sumLbl = new System.Windows.Forms.Label();
            this.changeSumLbl = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // creditCardButton
            // 
            this.creditCardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creditCardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.creditCardButton.FlatAppearance.BorderSize = 0;
            this.creditCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditCardButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditCardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.creditCardButton.Location = new System.Drawing.Point(71, 127);
            this.creditCardButton.Name = "creditCardButton";
            this.creditCardButton.Size = new System.Drawing.Size(152, 43);
            this.creditCardButton.TabIndex = 0;
            this.creditCardButton.Text = "Credit card";
            this.creditCardButton.UseVisualStyleBackColor = false;
            this.creditCardButton.Click += new System.EventHandler(this.creditCardButton_Click);
            // 
            // debitCardButton
            // 
            this.debitCardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debitCardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.debitCardButton.FlatAppearance.BorderSize = 0;
            this.debitCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debitCardButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debitCardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.debitCardButton.Location = new System.Drawing.Point(326, 127);
            this.debitCardButton.Name = "debitCardButton";
            this.debitCardButton.Size = new System.Drawing.Size(152, 43);
            this.debitCardButton.TabIndex = 0;
            this.debitCardButton.Text = "Debit card";
            this.debitCardButton.UseVisualStyleBackColor = false;
            this.debitCardButton.Click += new System.EventHandler(this.debitCardButton_Click);
            // 
            // cashButton
            // 
            this.cashButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cashButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.cashButton.FlatAppearance.BorderSize = 0;
            this.cashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.cashButton.Location = new System.Drawing.Point(586, 127);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(152, 43);
            this.cashButton.TabIndex = 0;
            this.cashButton.Text = "Cash";
            this.cashButton.UseVisualStyleBackColor = false;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(326, 236);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(152, 40);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // sumLbl
            // 
            this.sumLbl.AutoSize = true;
            this.sumLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.sumLbl.Location = new System.Drawing.Point(390, 59);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(20, 32);
            this.sumLbl.TabIndex = 3;
            this.sumLbl.Text = " ";
            // 
            // changeSumLbl
            // 
            this.changeSumLbl.AutoSize = true;
            this.changeSumLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.changeSumLbl.Location = new System.Drawing.Point(390, 323);
            this.changeSumLbl.Name = "changeSumLbl";
            this.changeSumLbl.Size = new System.Drawing.Size(20, 32);
            this.changeSumLbl.TabIndex = 3;
            this.changeSumLbl.Text = " ";
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.okButton.Location = new System.Drawing.Point(326, 394);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(145, 44);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SelectPaymentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.changeSumLbl);
            this.Controls.Add(this.sumLbl);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.debitCardButton);
            this.Controls.Add(this.creditCardButton);
            this.Name = "SelectPaymentTypeForm";
            this.Text = "SelectPaymentTypeForm";
            this.Load += new System.EventHandler(this.SelectPaymentTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button creditCardButton;
        private System.Windows.Forms.Button debitCardButton;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label sumLbl;
        private System.Windows.Forms.Label changeSumLbl;
        private System.Windows.Forms.Button okButton;
    }
}