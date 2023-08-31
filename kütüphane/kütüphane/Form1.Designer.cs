
namespace kütüphane
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxYzr = new System.Windows.Forms.TextBox();
            this.buttonGtr = new System.Windows.Forms.Button();
            this.textBoxKtp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxDelKtp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.listViewList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kitap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Yazar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxYzr
            // 
            this.textBoxYzr.Location = new System.Drawing.Point(267, 97);
            this.textBoxYzr.Name = "textBoxYzr";
            this.textBoxYzr.Size = new System.Drawing.Size(100, 20);
            this.textBoxYzr.TabIndex = 1;
            // 
            // buttonGtr
            // 
            this.buttonGtr.Location = new System.Drawing.Point(68, 64);
            this.buttonGtr.Name = "buttonGtr";
            this.buttonGtr.Size = new System.Drawing.Size(93, 49);
            this.buttonGtr.TabIndex = 2;
            this.buttonGtr.Text = "GETİR";
            this.buttonGtr.UseVisualStyleBackColor = true;
            this.buttonGtr.Click += new System.EventHandler(this.buttonGtr_Click);
            // 
            // textBoxKtp
            // 
            this.textBoxKtp.Location = new System.Drawing.Point(267, 57);
            this.textBoxKtp.Name = "textBoxKtp";
            this.textBoxKtp.Size = new System.Drawing.Size(100, 20);
            this.textBoxKtp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitap İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yazar";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(389, 64);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(93, 49);
            this.buttonEkle.TabIndex = 5;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxDelKtp
            // 
            this.textBoxDelKtp.Location = new System.Drawing.Point(608, 57);
            this.textBoxDelKtp.Name = "textBoxDelKtp";
            this.textBoxDelKtp.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelKtp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kitap İsmi";
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(615, 97);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(93, 49);
            this.buttonSil.TabIndex = 8;
            this.buttonSil.Text = "SIL";
            this.buttonSil.UseVisualStyleBackColor = true;
            // 
            // listViewList
            // 
            this.listViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Kitap,
            this.Yazar});
            this.listViewList.HideSelection = false;
            this.listViewList.Location = new System.Drawing.Point(195, 151);
            this.listViewList.Name = "listViewList";
            this.listViewList.Size = new System.Drawing.Size(351, 175);
            this.listViewList.TabIndex = 9;
            this.listViewList.UseCompatibleStateImageBehavior = false;
            this.listViewList.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Kitap
            // 
            this.Kitap.Text = "Kitap";
            this.Kitap.Width = 140;
            // 
            // Yazar
            // 
            this.Yazar.Text = "Yazar";
            this.Yazar.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewList);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDelKtp);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGtr);
            this.Controls.Add(this.textBoxYzr);
            this.Controls.Add(this.textBoxKtp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxYzr;
        private System.Windows.Forms.Button buttonGtr;
        private System.Windows.Forms.TextBox textBoxKtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxDelKtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.ListView listViewList;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Kitap;
        private System.Windows.Forms.ColumnHeader Yazar;
    }
}

