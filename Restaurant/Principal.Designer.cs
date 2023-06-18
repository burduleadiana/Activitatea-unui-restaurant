namespace Restaurant
{
    partial class Principal
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
            this.btnProduse = new System.Windows.Forms.Button();
            this.btnComenzi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activitatea unui Restaurant";
            // 
            // btnProduse
            // 
            this.btnProduse.BackColor = System.Drawing.Color.DarkOrange;
            this.btnProduse.Location = new System.Drawing.Point(80, 216);
            this.btnProduse.Name = "btnProduse";
            this.btnProduse.Size = new System.Drawing.Size(263, 44);
            this.btnProduse.TabIndex = 1;
            this.btnProduse.Text = "Catre Produse";
            this.btnProduse.UseVisualStyleBackColor = false;
            this.btnProduse.Click += new System.EventHandler(this.btnProduse_Click);
            // 
            // btnComenzi
            // 
            this.btnComenzi.BackColor = System.Drawing.Color.DarkOrange;
            this.btnComenzi.Location = new System.Drawing.Point(450, 216);
            this.btnComenzi.Name = "btnComenzi";
            this.btnComenzi.Size = new System.Drawing.Size(259, 44);
            this.btnComenzi.TabIndex = 2;
            this.btnComenzi.Text = "Catre Comenzi";
            this.btnComenzi.UseVisualStyleBackColor = false;
            this.btnComenzi.Click += new System.EventHandler(this.btnComenzi_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComenzi);
            this.Controls.Add(this.btnProduse);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProduse;
        private System.Windows.Forms.Button btnComenzi;
    }
}

