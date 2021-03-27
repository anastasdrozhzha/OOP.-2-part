namespace Электронная_библиотека
{
    partial class Prog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prog));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Stich = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Infa = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 289);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Stich
            // 
            this.Stich.AutoSize = true;
            this.Stich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stich.Location = new System.Drawing.Point(60, 104);
            this.Stich.Name = "Stich";
            this.Stich.Size = new System.Drawing.Size(443, 15);
            this.Stich.TabIndex = 1;
            this.Stich.Text = "Ой.. А я потерялся( Не подскажите, как мне вернутся к себе в программу?)";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(107, 40);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(330, 15);
            this.Author.TabIndex = 2;
            this.Author.Text = "О создателе: любитель мультиков и милых картиночек";
            // 
            // Infa
            // 
            this.Infa.AutoSize = true;
            this.Infa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Infa.Location = new System.Drawing.Point(107, 72);
            this.Infa.Name = "Infa";
            this.Infa.Size = new System.Drawing.Size(192, 15);
            this.Infa.TabIndex = 3;
            this.Infa.Text = "Версия: самая мимимишная 2.0";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Moccasin;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(186, 429);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(199, 30);
            this.close.TabIndex = 19;
            this.close.Text = "Отправить Стича домой?";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Prog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 471);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Infa);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Stich);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Prog";
            this.Text = "Prog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Stich;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Infa;
        private System.Windows.Forms.Button close;
    }
}