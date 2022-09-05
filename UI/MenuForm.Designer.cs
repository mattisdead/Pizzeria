namespace Pizzeria
{
    partial class MenuForm
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
            this.toppingsMenuLbl = new System.Windows.Forms.Label();
            this.toppingsMenuButton = new System.Windows.Forms.Button();
            this.pizzaMenuLbl = new System.Windows.Forms.Label();
            this.pizzaMenuButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // toppingsMenuLbl
            // 
            this.toppingsMenuLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toppingsMenuLbl.AutoSize = true;
            this.toppingsMenuLbl.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toppingsMenuLbl.ForeColor = System.Drawing.Color.Black;
            this.toppingsMenuLbl.Location = new System.Drawing.Point(469, 83);
            this.toppingsMenuLbl.Name = "toppingsMenuLbl";
            this.toppingsMenuLbl.Size = new System.Drawing.Size(19, 29);
            this.toppingsMenuLbl.TabIndex = 7;
            this.toppingsMenuLbl.Text = " ";
            // 
            // toppingsMenuButton
            // 
            this.toppingsMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toppingsMenuButton.AutoSize = true;
            this.toppingsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.toppingsMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toppingsMenuButton.FlatAppearance.BorderSize = 0;
            this.toppingsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toppingsMenuButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.toppingsMenuButton.Location = new System.Drawing.Point(474, 12);
            this.toppingsMenuButton.Name = "toppingsMenuButton";
            this.toppingsMenuButton.Size = new System.Drawing.Size(134, 59);
            this.toppingsMenuButton.TabIndex = 6;
            this.toppingsMenuButton.Text = "Toppings";
            this.toppingsMenuButton.UseVisualStyleBackColor = false;
            this.toppingsMenuButton.Click += new System.EventHandler(this.toppingsMenuButton_Click_1);
            // 
            // pizzaMenuLbl
            // 
            this.pizzaMenuLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pizzaMenuLbl.AutoSize = true;
            this.pizzaMenuLbl.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pizzaMenuLbl.ForeColor = System.Drawing.Color.Black;
            this.pizzaMenuLbl.Location = new System.Drawing.Point(55, 83);
            this.pizzaMenuLbl.Name = "pizzaMenuLbl";
            this.pizzaMenuLbl.Size = new System.Drawing.Size(19, 29);
            this.pizzaMenuLbl.TabIndex = 5;
            this.pizzaMenuLbl.Text = " ";
            // 
            // pizzaMenuButton
            // 
            this.pizzaMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pizzaMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.pizzaMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pizzaMenuButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.pizzaMenuButton.FlatAppearance.BorderSize = 0;
            this.pizzaMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pizzaMenuButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.pizzaMenuButton.Location = new System.Drawing.Point(60, 12);
            this.pizzaMenuButton.Name = "pizzaMenuButton";
            this.pizzaMenuButton.Size = new System.Drawing.Size(113, 59);
            this.pizzaMenuButton.TabIndex = 4;
            this.pizzaMenuButton.Text = "Pizzas";
            this.pizzaMenuButton.UseVisualStyleBackColor = false;
            this.pizzaMenuButton.Click += new System.EventHandler(this.pizzaMenuButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 9;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toppingsMenuLbl);
            this.Controls.Add(this.toppingsMenuButton);
            this.Controls.Add(this.pizzaMenuLbl);
            this.Controls.Add(this.pizzaMenuButton);
            this.Controls.Add(this.panel1);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toppingsMenuLbl;
        private System.Windows.Forms.Button toppingsMenuButton;
        private System.Windows.Forms.Label pizzaMenuLbl;
        private System.Windows.Forms.Button pizzaMenuButton;
        private System.Windows.Forms.Panel panel1;
    }
}