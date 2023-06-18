namespace Restaurant
{
    partial class GestionareComenzi
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdaugaComanda = new System.Windows.Forms.Button();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbIdComanda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbListaProduse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAfiseazaComenzi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genereazaFisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genereazaChitantaTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printeazaChitantaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(427, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(921, 318);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestionare Comenzi";
            // 
            // btnAdaugaComanda
            // 
            this.btnAdaugaComanda.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdaugaComanda.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaComanda.Location = new System.Drawing.Point(177, 345);
            this.btnAdaugaComanda.Name = "btnAdaugaComanda";
            this.btnAdaugaComanda.Size = new System.Drawing.Size(131, 28);
            this.btnAdaugaComanda.TabIndex = 9;
            this.btnAdaugaComanda.Text = "Adauga Comanda";
            this.btnAdaugaComanda.UseVisualStyleBackColor = false;
            this.btnAdaugaComanda.Click += new System.EventHandler(this.btnAdaugaComanda_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID Comanda";
            this.columnHeader6.Width = 102;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Data Comanda";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lista Produse";
            this.columnHeader2.Width = 209;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 104;
            // 
            // tbIdComanda
            // 
            this.tbIdComanda.Location = new System.Drawing.Point(177, 102);
            this.tbIdComanda.Name = "tbIdComanda";
            this.tbIdComanda.Size = new System.Drawing.Size(100, 22);
            this.tbIdComanda.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Comanda";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data Comanda";
            // 
            // tbListaProduse
            // 
            this.tbListaProduse.Location = new System.Drawing.Point(177, 185);
            this.tbListaProduse.Name = "tbListaProduse";
            this.tbListaProduse.Size = new System.Drawing.Size(100, 22);
            this.tbListaProduse.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lista Produse";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "New",
            "In Progress",
            "Closed"});
            this.cbStatus.Location = new System.Drawing.Point(177, 293);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Status Comanda";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(177, 236);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 22);
            this.tbTotal.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total";
            // 
            // btnAfiseazaComenzi
            // 
            this.btnAfiseazaComenzi.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAfiseazaComenzi.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfiseazaComenzi.Location = new System.Drawing.Point(617, 395);
            this.btnAfiseazaComenzi.Name = "btnAfiseazaComenzi";
            this.btnAfiseazaComenzi.Size = new System.Drawing.Size(185, 43);
            this.btnAfiseazaComenzi.TabIndex = 20;
            this.btnAfiseazaComenzi.Text = "Afiseaza Comenzi";
            this.btnAfiseazaComenzi.UseVisualStyleBackColor = false;
            this.btnAfiseazaComenzi.Click += new System.EventHandler(this.btnAfiseazaComenzi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genereazaFisiereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1425, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genereazaFisiereToolStripMenuItem
            // 
            this.genereazaFisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genereazaChitantaTextToolStripMenuItem,
            this.printeazaChitantaToolStripMenuItem});
            this.genereazaFisiereToolStripMenuItem.Name = "genereazaFisiereToolStripMenuItem";
            this.genereazaFisiereToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.genereazaFisiereToolStripMenuItem.Text = "Genereaza fisiere";
            // 
            // genereazaChitantaTextToolStripMenuItem
            // 
            this.genereazaChitantaTextToolStripMenuItem.Name = "genereazaChitantaTextToolStripMenuItem";
            this.genereazaChitantaTextToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.genereazaChitantaTextToolStripMenuItem.Text = "Genereaza chitanta text";
            this.genereazaChitantaTextToolStripMenuItem.Click += new System.EventHandler(this.genereazaChitantaTextToolStripMenuItem_Click);
            // 
            // printeazaChitantaToolStripMenuItem
            // 
            this.printeazaChitantaToolStripMenuItem.Name = "printeazaChitantaToolStripMenuItem";
            this.printeazaChitantaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.printeazaChitantaToolStripMenuItem.Text = "Printeaza chitanta";
            this.printeazaChitantaToolStripMenuItem.Click += new System.EventHandler(this.printeazaChitantaToolStripMenuItem_Click);
            // 
            // GestionareComenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1425, 450);
            this.Controls.Add(this.btnAfiseazaComenzi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbListaProduse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdComanda);
            this.Controls.Add(this.btnAdaugaComanda);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionareComenzi";
            this.Text = "GestionareComenzi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdaugaComanda;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbIdComanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbListaProduse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAfiseazaComenzi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genereazaFisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genereazaChitantaTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printeazaChitantaToolStripMenuItem;
    }
}