namespace Restaurant
{
    partial class GestionareProduse
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfisareProduse = new System.Windows.Forms.Button();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.btnStergeProdus = new System.Windows.Forms.Button();
            this.btnValoareTotala = new System.Windows.Forms.Button();
            this.tbValoareTotala = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.incarcaMeniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genereazaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaMeniuDinDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genereazaFisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genereazaFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genereazaFisierXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionare Produse";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(728, 318);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID Produs";
            this.columnHeader7.Width = 89;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Denumire";
            this.columnHeader8.Width = 88;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Pret";
            this.columnHeader9.Width = 65;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Descriere";
            this.columnHeader10.Width = 113;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Stoc";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ingrediente";
            this.columnHeader12.Width = 307;
            // 
            // btnAfisareProduse
            // 
            this.btnAfisareProduse.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAfisareProduse.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisareProduse.Location = new System.Drawing.Point(782, 127);
            this.btnAfisareProduse.Name = "btnAfisareProduse";
            this.btnAfisareProduse.Size = new System.Drawing.Size(149, 45);
            this.btnAfisareProduse.TabIndex = 2;
            this.btnAfisareProduse.Text = "Afisare Produse Disponibile";
            this.btnAfisareProduse.UseVisualStyleBackColor = false;
            this.btnAfisareProduse.Click += new System.EventHandler(this.btnAfisareProduse_Click);
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdaugaProdus.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaProdus.Location = new System.Drawing.Point(782, 188);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(149, 45);
            this.btnAdaugaProdus.TabIndex = 4;
            this.btnAdaugaProdus.Text = "Adauga Produs";
            this.btnAdaugaProdus.UseVisualStyleBackColor = false;
            this.btnAdaugaProdus.Click += new System.EventHandler(this.btnAdaugaProdus_Click);
            // 
            // btnStergeProdus
            // 
            this.btnStergeProdus.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStergeProdus.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeProdus.Location = new System.Drawing.Point(782, 251);
            this.btnStergeProdus.Name = "btnStergeProdus";
            this.btnStergeProdus.Size = new System.Drawing.Size(149, 47);
            this.btnStergeProdus.TabIndex = 5;
            this.btnStergeProdus.Text = "Sterge Produs";
            this.btnStergeProdus.UseVisualStyleBackColor = false;
            this.btnStergeProdus.Click += new System.EventHandler(this.btnStergeProdus_Click);
            // 
            // btnValoareTotala
            // 
            this.btnValoareTotala.BackColor = System.Drawing.Color.DarkOrange;
            this.btnValoareTotala.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValoareTotala.Location = new System.Drawing.Point(12, 387);
            this.btnValoareTotala.Name = "btnValoareTotala";
            this.btnValoareTotala.Size = new System.Drawing.Size(127, 51);
            this.btnValoareTotala.TabIndex = 6;
            this.btnValoareTotala.Text = "Calcul Valoare Totala";
            this.btnValoareTotala.UseVisualStyleBackColor = false;
            this.btnValoareTotala.Click += new System.EventHandler(this.btnValoareTotala_Click);
            // 
            // tbValoareTotala
            // 
            this.tbValoareTotala.Location = new System.Drawing.Point(164, 401);
            this.tbValoareTotala.Name = "tbValoareTotala";
            this.tbValoareTotala.Size = new System.Drawing.Size(100, 22);
            this.tbValoareTotala.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "RON";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcaMeniuToolStripMenuItem,
            this.genereazaXMLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 52);
            // 
            // incarcaMeniuToolStripMenuItem
            // 
            this.incarcaMeniuToolStripMenuItem.Name = "incarcaMeniuToolStripMenuItem";
            this.incarcaMeniuToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.incarcaMeniuToolStripMenuItem.Text = "Incarca Meniu";
            this.incarcaMeniuToolStripMenuItem.Click += new System.EventHandler(this.incarcaMeniuToolStripMenuItem_Click);
            // 
            // genereazaXMLToolStripMenuItem
            // 
            this.genereazaXMLToolStripMenuItem.Name = "genereazaXMLToolStripMenuItem";
            this.genereazaXMLToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.genereazaXMLToolStripMenuItem.Text = "Genereaza XML";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBToolStripMenuItem,
            this.genereazaFisiereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dBToolStripMenuItem
            // 
            this.dBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcaMeniuDinDBToolStripMenuItem});
            this.dBToolStripMenuItem.Name = "dBToolStripMenuItem";
            this.dBToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.dBToolStripMenuItem.Text = "DB";
            // 
            // incarcaMeniuDinDBToolStripMenuItem
            // 
            this.incarcaMeniuDinDBToolStripMenuItem.Name = "incarcaMeniuDinDBToolStripMenuItem";
            this.incarcaMeniuDinDBToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.incarcaMeniuDinDBToolStripMenuItem.Text = "Incarca Meniu din DB";
            this.incarcaMeniuDinDBToolStripMenuItem.Click += new System.EventHandler(this.incarcaMeniuDinDBToolStripMenuItem_Click);
            // 
            // genereazaFisiereToolStripMenuItem
            // 
            this.genereazaFisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genereazaFisierTextToolStripMenuItem,
            this.genereazaFisierXMLToolStripMenuItem});
            this.genereazaFisiereToolStripMenuItem.Name = "genereazaFisiereToolStripMenuItem";
            this.genereazaFisiereToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.genereazaFisiereToolStripMenuItem.Text = "Genereaza Fisiere";
            // 
            // genereazaFisierTextToolStripMenuItem
            // 
            this.genereazaFisierTextToolStripMenuItem.Name = "genereazaFisierTextToolStripMenuItem";
            this.genereazaFisierTextToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.genereazaFisierTextToolStripMenuItem.Text = "Genereaza Fisier Text";
            this.genereazaFisierTextToolStripMenuItem.Click += new System.EventHandler(this.genereazaFisierTextToolStripMenuItem_Click);
            // 
            // genereazaFisierXMLToolStripMenuItem
            // 
            this.genereazaFisierXMLToolStripMenuItem.Name = "genereazaFisierXMLToolStripMenuItem";
            this.genereazaFisierXMLToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.genereazaFisierXMLToolStripMenuItem.Text = "Genereaza Fisier XML";
            // 
            // GestionareProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(958, 454);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbValoareTotala);
            this.Controls.Add(this.btnValoareTotala);
            this.Controls.Add(this.btnStergeProdus);
            this.Controls.Add(this.btnAdaugaProdus);
            this.Controls.Add(this.btnAfisareProduse);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionareProduse";
            this.Text = "GestionareProduse";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAfisareProduse;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.Button btnStergeProdus;
        private System.Windows.Forms.Button btnValoareTotala;
        private System.Windows.Forms.TextBox tbValoareTotala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incarcaMeniuToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ToolStripMenuItem genereazaXMLToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaMeniuDinDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genereazaFisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genereazaFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genereazaFisierXMLToolStripMenuItem;
    }
}