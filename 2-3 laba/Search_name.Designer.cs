namespace Электронная_библиотека
{
    partial class Search_name
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_name));
            this.Infa = new System.Windows.Forms.Label();
            this.name2Box = new System.Windows.Forms.TextBox();
            this.findbook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.ListBox();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Infa
            // 
            this.Infa.AutoSize = true;
            this.Infa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Infa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Infa.Location = new System.Drawing.Point(74, 40);
            this.Infa.Name = "Infa";
            this.Infa.Size = new System.Drawing.Size(150, 15);
            this.Infa.TabIndex = 4;
            this.Infa.Text = "Введите название книги";
            // 
            // name2Box
            // 
            this.name2Box.Location = new System.Drawing.Point(59, 71);
            this.name2Box.Name = "name2Box";
            this.name2Box.Size = new System.Drawing.Size(180, 20);
            this.name2Box.TabIndex = 8;
            this.name2Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name2Box_KeyPress);
            // 
            // findbook
            // 
            this.findbook.BackColor = System.Drawing.Color.Moccasin;
            this.findbook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findbook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findbook.Location = new System.Drawing.Point(86, 107);
            this.findbook.Name = "findbook";
            this.findbook.Size = new System.Drawing.Size(120, 26);
            this.findbook.TabIndex = 12;
            this.findbook.Text = "Найти";
            this.findbook.UseVisualStyleBackColor = false;
            this.findbook.Click += new System.EventHandler(this.findbook_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(37, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.Location = new System.Drawing.Point(12, 146);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(276, 95);
            this.Results.TabIndex = 14;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Moccasin;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(160, 247);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(106, 26);
            this.exit.TabIndex = 15;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Search_name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(487, 328);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.findbook);
            this.Controls.Add(this.name2Box);
            this.Controls.Add(this.Infa);
            this.Name = "Search_name";
            this.Text = "Search_name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name2Box;
        private System.Windows.Forms.Button findbook;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Infa;
        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Button exit;
    }
}