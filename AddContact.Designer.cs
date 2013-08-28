namespace PhoneBook
{
    partial class AddContact
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContact));
        	this.listView1 = new System.Windows.Forms.ListView();
        	this.id = new System.Windows.Forms.ColumnHeader();
        	this.Famile = new System.Windows.Forms.ColumnHeader();
        	this.nume = new System.Windows.Forms.ColumnHeader();
        	this.Prenumele = new System.Windows.Forms.ColumnHeader();
        	this.nr = new System.Windows.Forms.ColumnHeader();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.textBox3 = new System.Windows.Forms.TextBox();
        	this.textBox4 = new System.Windows.Forms.TextBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button3 = new System.Windows.Forms.Button();
        	this.textBox5 = new System.Windows.Forms.TextBox();
        	this.SuspendLayout();
        	// 
        	// listView1
        	// 
        	this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.id,
        	        	        	this.Famile,
        	        	        	this.nume,
        	        	        	this.Prenumele,
        	        	        	this.nr});
        	this.listView1.FullRowSelect = true;
        	this.listView1.GridLines = true;
        	this.listView1.HoverSelection = true;
        	this.listView1.Location = new System.Drawing.Point(15, 51);
        	this.listView1.Name = "listView1";
        	this.listView1.Size = new System.Drawing.Size(665, 686);
        	this.listView1.TabIndex = 0;
        	this.listView1.UseCompatibleStateImageBehavior = false;
        	this.listView1.View = System.Windows.Forms.View.Details;
        	// 
        	// id
        	// 
        	this.id.Text = "Id";
        	// 
        	// Famile
        	// 
        	this.Famile.Text = "Familie";
        	this.Famile.Width = 114;
        	// 
        	// nume
        	// 
        	this.nume.Text = "Numele";
        	this.nume.Width = 115;
        	// 
        	// Prenumele
        	// 
        	this.Prenumele.Text = "Prenumele";
        	this.Prenumele.Width = 154;
        	// 
        	// nr
        	// 
        	this.nr.Text = "Nr.Telefon";
        	this.nr.Width = 276;
        	// 
        	// textBox1
        	// 
        	this.textBox1.Location = new System.Drawing.Point(181, 25);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(150, 20);
        	this.textBox1.TabIndex = 1;
        	// 
        	// textBox2
        	// 
        	this.textBox2.Location = new System.Drawing.Point(15, 25);
        	this.textBox2.Name = "textBox2";
        	this.textBox2.Size = new System.Drawing.Size(150, 20);
        	this.textBox2.TabIndex = 2;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(12, 9);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(39, 13);
        	this.label1.TabIndex = 3;
        	this.label1.Text = "Familia";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(178, 9);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(43, 13);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "Numele";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(347, 9);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(57, 13);
        	this.label3.TabIndex = 5;
        	this.label3.Text = "Prenumele";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(516, 9);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(57, 13);
        	this.label4.TabIndex = 6;
        	this.label4.Text = "Nr.Telefon";
        	// 
        	// textBox3
        	// 
        	this.textBox3.Location = new System.Drawing.Point(350, 25);
        	this.textBox3.Name = "textBox3";
        	this.textBox3.Size = new System.Drawing.Size(150, 20);
        	this.textBox3.TabIndex = 7;
        	// 
        	// textBox4
        	// 
        	this.textBox4.Location = new System.Drawing.Point(519, 25);
        	this.textBox4.Name = "textBox4";
        	this.textBox4.Size = new System.Drawing.Size(161, 20);
        	this.textBox4.TabIndex = 8;
        	// 
        	// button1
        	// 
        	this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
        	this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.button1.Location = new System.Drawing.Point(685, 24);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(101, 51);
        	this.button1.TabIndex = 9;
        	this.button1.Text = "Adaugă";
        	this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// button2
        	// 
        	this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
        	this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.button2.Location = new System.Drawing.Point(685, 81);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(101, 51);
        	this.button2.TabIndex = 10;
        	this.button2.Text = "Șterge";
        	this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(686, 715);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(100, 23);
        	this.button3.TabIndex = 11;
        	this.button3.Text = "Închide";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.Click += new System.EventHandler(this.button3_Click);
        	// 
        	// textBox5
        	// 
        	this.textBox5.Location = new System.Drawing.Point(685, 138);
        	this.textBox5.Name = "textBox5";
        	this.textBox5.Size = new System.Drawing.Size(100, 20);
        	this.textBox5.TabIndex = 12;
        	// 
        	// AddContact
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(799, 749);
        	this.Controls.Add(this.textBox5);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.textBox4);
        	this.Controls.Add(this.textBox3);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.textBox2);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.listView1);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "AddContact";
        	this.Text = "Adaugă / Șterge";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader Famile;
        private System.Windows.Forms.ColumnHeader nume;
        private System.Windows.Forms.ColumnHeader Prenumele;
        private System.Windows.Forms.ColumnHeader nr;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.ColumnHeader id;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox5;
    }
}