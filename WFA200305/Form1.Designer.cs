namespace WFA200305
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
            this.cbMuvelet = new System.Windows.Forms.ComboBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbMuvelet
            // 
            this.cbMuvelet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMuvelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMuvelet.FormattingEnabled = true;
            this.cbMuvelet.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbMuvelet.Location = new System.Drawing.Point(94, 28);
            this.cbMuvelet.Name = "cbMuvelet";
            this.cbMuvelet.Size = new System.Drawing.Size(58, 39);
            this.cbMuvelet.TabIndex = 0;
            this.cbMuvelet.SelectedIndexChanged += new System.EventHandler(this.cbMuvelet_SelectedIndexChanged);
            // 
            // tbX
            // 
            this.tbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbX.Location = new System.Drawing.Point(22, 28);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(66, 38);
            this.tbX.TabIndex = 1;
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.AutoSize = true;
            this.lblEredmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEredmeny.Location = new System.Drawing.Point(230, 31);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(82, 31);
            this.lblEredmeny.TabIndex = 2;
            this.lblEredmeny.Text = "= ???";
            // 
            // tbY
            // 
            this.tbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbY.Location = new System.Drawing.Point(158, 28);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(66, 38);
            this.tbY.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(332, 95);
            this.Controls.Add(this.lblEredmeny);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.cbMuvelet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMuvelet;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label lblEredmeny;
        private System.Windows.Forms.TextBox tbY;
    }
}

