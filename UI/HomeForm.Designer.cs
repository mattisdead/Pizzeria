namespace progbase_cw_2._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pizzaMenuButton = new System.Windows.Forms.Button();
            this.OrderLbl = new System.Windows.Forms.Label();
            this.addPizzaButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pickChefButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzaMenuButton
            // 
            this.pizzaMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.pizzaMenuButton.FlatAppearance.BorderSize = 0;
            this.pizzaMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pizzaMenuButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pizzaMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.pizzaMenuButton.Location = new System.Drawing.Point(12, 12);
            this.pizzaMenuButton.Name = "pizzaMenuButton";
            this.pizzaMenuButton.Size = new System.Drawing.Size(142, 58);
            this.pizzaMenuButton.TabIndex = 5;
            this.pizzaMenuButton.Text = "Menu";
            this.pizzaMenuButton.UseVisualStyleBackColor = false;
            this.pizzaMenuButton.Click += new System.EventHandler(this.pizzaMenuButton_Click);
            // 
            // OrderLbl
            // 
            this.OrderLbl.AutoSize = true;
            this.OrderLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.OrderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.OrderLbl.Location = new System.Drawing.Point(13, 105);
            this.OrderLbl.Name = "OrderLbl";
            this.OrderLbl.Size = new System.Drawing.Size(20, 32);
            this.OrderLbl.TabIndex = 6;
            this.OrderLbl.Text = " ";
            this.OrderLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // addPizzaButton
            // 
            this.addPizzaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.addPizzaButton.FlatAppearance.BorderSize = 0;
            this.addPizzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPizzaButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPizzaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.addPizzaButton.Location = new System.Drawing.Point(180, 12);
            this.addPizzaButton.Name = "addPizzaButton";
            this.addPizzaButton.Size = new System.Drawing.Size(179, 58);
            this.addPizzaButton.TabIndex = 7;
            this.addPizzaButton.Text = "Add pizza";
            this.addPizzaButton.UseVisualStyleBackColor = false;
            this.addPizzaButton.Click += new System.EventHandler(this.addPizzaButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.pickChefButton);
            this.panel1.Controls.Add(this.payButton);
            this.panel1.Controls.Add(this.addPizzaButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 8;
            // 
            // pickChefButton
            // 
            this.pickChefButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.pickChefButton.FlatAppearance.BorderSize = 0;
            this.pickChefButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickChefButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pickChefButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.pickChefButton.Location = new System.Drawing.Point(550, 12);
            this.pickChefButton.Name = "pickChefButton";
            this.pickChefButton.Size = new System.Drawing.Size(179, 58);
            this.pickChefButton.TabIndex = 8;
            this.pickChefButton.Text = "Pick chef";
            this.pickChefButton.UseVisualStyleBackColor = false;
            this.pickChefButton.Click += new System.EventHandler(this.pickChefButton_Click);
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.payButton.FlatAppearance.BorderSize = 0;
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.payButton.Location = new System.Drawing.Point(365, 12);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(179, 58);
            this.payButton.TabIndex = 8;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderLbl);
            this.Controls.Add(this.pizzaMenuButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pizzaMenuButton;
        private System.Windows.Forms.Label OrderLbl;
        private System.Windows.Forms.Button addPizzaButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button pickChefButton;
    }
}

