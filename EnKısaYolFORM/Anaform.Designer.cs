namespace EnKısaYolFORM
{
    partial class Anaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anaform));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKime = new System.Windows.Forms.Label();
            this.lblKimden = new System.Windows.Forms.Label();
            this.cmbKime = new System.Windows.Forms.ComboBox();
            this.cmbKimden = new System.Windows.Forms.ComboBox();
            this.btnFordFulkerson = new System.Windows.Forms.Button();
            this.btnEdmonds = new System.Windows.Forms.Button();
            this.btnKruksal = new System.Windows.Forms.Button();
            this.btnPrim = new System.Windows.Forms.Button();
            this.btnGenislik = new System.Windows.Forms.Button();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "kruksal tamam";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 24;
            this.button1.Text = "sıralama deneme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKime
            // 
            this.lblKime.AutoSize = true;
            this.lblKime.Location = new System.Drawing.Point(757, 229);
            this.lblKime.Name = "lblKime";
            this.lblKime.Size = new System.Drawing.Size(39, 17);
            this.lblKime.TabIndex = 23;
            this.lblKime.Text = "Kime";
            this.lblKime.Visible = false;
            // 
            // lblKimden
            // 
            this.lblKimden.AutoSize = true;
            this.lblKimden.Location = new System.Drawing.Point(757, 151);
            this.lblKimden.Name = "lblKimden";
            this.lblKimden.Size = new System.Drawing.Size(55, 17);
            this.lblKimden.TabIndex = 22;
            this.lblKimden.Text = "Kimden";
            this.lblKimden.Visible = false;
            // 
            // cmbKime
            // 
            this.cmbKime.FormattingEnabled = true;
            this.cmbKime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbKime.Location = new System.Drawing.Point(760, 249);
            this.cmbKime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKime.Name = "cmbKime";
            this.cmbKime.Size = new System.Drawing.Size(121, 24);
            this.cmbKime.TabIndex = 21;
            // 
            // cmbKimden
            // 
            this.cmbKimden.FormattingEnabled = true;
            this.cmbKimden.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbKimden.Location = new System.Drawing.Point(760, 171);
            this.cmbKimden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKimden.Name = "cmbKimden";
            this.cmbKimden.Size = new System.Drawing.Size(121, 24);
            this.cmbKimden.TabIndex = 20;
            // 
            // btnFordFulkerson
            // 
            this.btnFordFulkerson.Location = new System.Drawing.Point(164, 485);
            this.btnFordFulkerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFordFulkerson.Name = "btnFordFulkerson";
            this.btnFordFulkerson.Size = new System.Drawing.Size(565, 30);
            this.btnFordFulkerson.TabIndex = 19;
            this.btnFordFulkerson.Text = "Ford Fulkerson Algoritması Tabanlı Maksimum Akış problemi ";
            this.btnFordFulkerson.UseVisualStyleBackColor = true;
            this.btnFordFulkerson.Click += new System.EventHandler(this.btnFordFulkerson_Click);
            // 
            // btnEdmonds
            // 
            this.btnEdmonds.Location = new System.Drawing.Point(164, 455);
            this.btnEdmonds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdmonds.Name = "btnEdmonds";
            this.btnEdmonds.Size = new System.Drawing.Size(565, 30);
            this.btnEdmonds.TabIndex = 18;
            this.btnEdmonds.Text = "Edmonds Karp Algoritması Tabanlı Maksimum Akış problemi";
            this.btnEdmonds.UseVisualStyleBackColor = true;
            this.btnEdmonds.Click += new System.EventHandler(this.btnEdmonds_Click);
            // 
            // btnKruksal
            // 
            this.btnKruksal.Location = new System.Drawing.Point(164, 427);
            this.btnKruksal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKruksal.Name = "btnKruksal";
            this.btnKruksal.Size = new System.Drawing.Size(565, 30);
            this.btnKruksal.TabIndex = 17;
            this.btnKruksal.Text = "Kruskal Algoritması Tabanlı En Küçük Kapsayan Ağaç problemi ";
            this.btnKruksal.UseVisualStyleBackColor = true;
            this.btnKruksal.Click += new System.EventHandler(this.btnKruksal_Click);
            // 
            // btnPrim
            // 
            this.btnPrim.Location = new System.Drawing.Point(164, 398);
            this.btnPrim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(565, 30);
            this.btnPrim.TabIndex = 16;
            this.btnPrim.Text = "Prim Algoritması Tabanlı En Küçük Kapsayan Ağaç problemi";
            this.btnPrim.UseVisualStyleBackColor = true;
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // btnGenislik
            // 
            this.btnGenislik.Location = new System.Drawing.Point(164, 369);
            this.btnGenislik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenislik.Name = "btnGenislik";
            this.btnGenislik.Size = new System.Drawing.Size(565, 30);
            this.btnGenislik.TabIndex = 15;
            this.btnGenislik.Text = "Genişlik Öncelikli Dolaşma problemi ";
            this.btnGenislik.UseVisualStyleBackColor = true;
            this.btnGenislik.Click += new System.EventHandler(this.btnGenislik_Click_1);
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(164, 340);
            this.btnDijkstra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(565, 30);
            this.btnDijkstra.TabIndex = 14;
            this.btnDijkstra.Text = "Dijkstra’nın En kısa yol problemi ";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKime);
            this.Controls.Add(this.lblKimden);
            this.Controls.Add(this.cmbKime);
            this.Controls.Add(this.cmbKimden);
            this.Controls.Add(this.btnFordFulkerson);
            this.Controls.Add(this.btnEdmonds);
            this.Controls.Add(this.btnKruksal);
            this.Controls.Add(this.btnPrim);
            this.Controls.Add(this.btnGenislik);
            this.Controls.Add(this.btnDijkstra);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Anaform";
            this.Text = "Anaform";
            this.Load += new System.EventHandler(this.Anaform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKime;
        private System.Windows.Forms.Label lblKimden;
        private System.Windows.Forms.ComboBox cmbKime;
        private System.Windows.Forms.ComboBox cmbKimden;
        private System.Windows.Forms.Button btnFordFulkerson;
        private System.Windows.Forms.Button btnEdmonds;
        private System.Windows.Forms.Button btnKruksal;
        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.Button btnGenislik;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}