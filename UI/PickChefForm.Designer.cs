namespace Pizzeria
{
    partial class PickChefForm
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
            this.traineeButton = new System.Windows.Forms.Button();
            this.regularChefButton = new System.Windows.Forms.Button();
            this.topChefButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // traineeButton
            // 
            this.traineeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.traineeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.traineeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.traineeButton.FlatAppearance.BorderSize = 0;
            this.traineeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.traineeButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.traineeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.traineeButton.Location = new System.Drawing.Point(582, 204);
            this.traineeButton.Name = "traineeButton";
            this.traineeButton.Size = new System.Drawing.Size(152, 43);
            this.traineeButton.TabIndex = 1;
            this.traineeButton.Text = "Trainee";
            this.traineeButton.UseVisualStyleBackColor = false;
            this.traineeButton.Click += new System.EventHandler(this.traineeButton_Click);
            // 
            // regularChefButton
            // 
            this.regularChefButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regularChefButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.regularChefButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regularChefButton.FlatAppearance.BorderSize = 0;
            this.regularChefButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regularChefButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regularChefButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.regularChefButton.Location = new System.Drawing.Point(304, 204);
            this.regularChefButton.Name = "regularChefButton";
            this.regularChefButton.Size = new System.Drawing.Size(184, 43);
            this.regularChefButton.TabIndex = 2;
            this.regularChefButton.Text = "Regular chef";
            this.regularChefButton.UseVisualStyleBackColor = false;
            this.regularChefButton.Click += new System.EventHandler(this.regularChefButton_Click);
            // 
            // topChefButton
            // 
            this.topChefButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topChefButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.topChefButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topChefButton.FlatAppearance.BorderSize = 0;
            this.topChefButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topChefButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topChefButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(150)))));
            this.topChefButton.Location = new System.Drawing.Point(67, 204);
            this.topChefButton.Name = "topChefButton";
            this.topChefButton.Size = new System.Drawing.Size(152, 43);
            this.topChefButton.TabIndex = 3;
            this.topChefButton.Text = "Top chef";
            this.topChefButton.UseVisualStyleBackColor = false;
            this.topChefButton.Click += new System.EventHandler(this.topChefButton_Click);
            // 
            // PickChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(73)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.traineeButton);
            this.Controls.Add(this.regularChefButton);
            this.Controls.Add(this.topChefButton);
            this.Name = "PickChefForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PickChefForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button traineeButton;
        private System.Windows.Forms.Button regularChefButton;
        private System.Windows.Forms.Button topChefButton;
    }
}