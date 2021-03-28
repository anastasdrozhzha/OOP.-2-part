namespace Электронная_библиотека
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.reservation = new System.Windows.Forms.Button();
            this.saveReserv = new System.Windows.Forms.Button();
            this.checkReserv = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.name2Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюКнигиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Searh_name = new System.Windows.Forms.ToolStripButton();
            this.Search_FIO = new System.Windows.Forms.ToolStripButton();
            this.Search_date = new System.Windows.Forms.ToolStripButton();
            this.Sort_date = new System.Windows.Forms.ToolStripButton();
            this.Sort_name = new System.Windows.Forms.ToolStripButton();
            this.Delete = new System.Windows.Forms.ToolStripButton();
            this.closeMenu = new System.Windows.Forms.ToolStripButton();
            this.Results = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.CurrentDateTimeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.action = new System.Windows.Forms.Label();
            this.Act = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.col = new System.Windows.Forms.Label();
            this.Openmenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservation
            // 
            this.reservation.BackColor = System.Drawing.Color.Moccasin;
            this.reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reservation.Location = new System.Drawing.Point(44, 288);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(120, 26);
            this.reservation.TabIndex = 0;
            this.reservation.Text = "Выбранная книга";
            this.reservation.UseVisualStyleBackColor = false;
            this.reservation.Click += new System.EventHandler(this.reservation_Click);
            // 
            // saveReserv
            // 
            this.saveReserv.BackColor = System.Drawing.Color.Moccasin;
            this.saveReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveReserv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveReserv.Location = new System.Drawing.Point(185, 392);
            this.saveReserv.Name = "saveReserv";
            this.saveReserv.Size = new System.Drawing.Size(109, 42);
            this.saveReserv.TabIndex = 1;
            this.saveReserv.Text = "Сохранить бронирование";
            this.saveReserv.UseVisualStyleBackColor = false;
            this.saveReserv.Click += new System.EventHandler(this.saveReserv_Click);
            // 
            // checkReserv
            // 
            this.checkReserv.BackColor = System.Drawing.Color.Moccasin;
            this.checkReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkReserv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkReserv.Location = new System.Drawing.Point(331, 392);
            this.checkReserv.Name = "checkReserv";
            this.checkReserv.Size = new System.Drawing.Size(109, 42);
            this.checkReserv.TabIndex = 2;
            this.checkReserv.Text = "Проверить бронирование";
            this.checkReserv.UseVisualStyleBackColor = false;
            this.checkReserv.Click += new System.EventHandler(this.checkReserv_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(103, 29);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(180, 20);
            this.nameBox.TabIndex = 5;
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            // 
            // name2Box
            // 
            this.name2Box.Location = new System.Drawing.Point(137, 63);
            this.name2Box.Name = "name2Box";
            this.name2Box.Size = new System.Drawing.Size(180, 20);
            this.name2Box.TabIndex = 7;
            this.name2Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name2Box_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(161, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(498, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Заполните все поля, чтобы забронировать книгу в нашей библиотеке";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ваше имя*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(19, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ваш номер телефона";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(19, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ваша фамилия*";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(480, 220);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(461, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "День, когда хотите забрать книгу";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.name2Box);
            this.groupBox1.Location = new System.Drawing.Point(37, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 138);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "О Вас";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(172, 98);
            this.maskedTextBox1.Mask = "#999 (00) 000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(180, 20);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(43, 323);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(409, 63);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите автора";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("Джек Лондон");
            this.domainUpDown1.Items.Add("Роджер Желязны");
            this.domainUpDown1.Items.Add("Эрих Фромм");
            this.domainUpDown1.Items.Add("Джон Грей");
            this.domainUpDown1.Items.Add("Зигмунд Фрейд");
            this.domainUpDown1.Items.Add("Дэн Браун");
            this.domainUpDown1.Location = new System.Drawing.Point(174, 233);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 16;
            this.domainUpDown1.Text = "Авторы";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(329, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Выбрать книгу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(42, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "*помечены обязательные поля для заполнения ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(44, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "Забронировать книгу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(42, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "нажмите \"Выбранная книга\",чтоб проверить выбранную книгу\r\n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНазваниюКнигиToolStripMenuItem,
            this.поИмениToolStripMenuItem,
            this.поФамилииToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поНазваниюКнигиToolStripMenuItem
            // 
            this.поНазваниюКнигиToolStripMenuItem.Name = "поНазваниюКнигиToolStripMenuItem";
            this.поНазваниюКнигиToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.поНазваниюКнигиToolStripMenuItem.Text = "По названию книги";
            this.поНазваниюКнигиToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюКнигиToolStripMenuItem_Click);
            // 
            // поИмениToolStripMenuItem
            // 
            this.поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            this.поИмениToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.поИмениToolStripMenuItem.Text = "По фамилии заказчика";
            this.поИмениToolStripMenuItem.Click += new System.EventHandler(this.поИмениToolStripMenuItem_Click);
            // 
            // поФамилииToolStripMenuItem
            // 
            this.поФамилииToolStripMenuItem.Name = "поФамилииToolStripMenuItem";
            this.поФамилииToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.поФамилииToolStripMenuItem.Text = "По дате бронирования";
            this.поФамилииToolStripMenuItem.Click += new System.EventHandler(this.поФамилииToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНазваниюКнигиToolStripMenuItem1,
            this.поДатеЗаказаToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поНазваниюКнигиToolStripMenuItem1
            // 
            this.поНазваниюКнигиToolStripMenuItem1.Name = "поНазваниюКнигиToolStripMenuItem1";
            this.поНазваниюКнигиToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.поНазваниюКнигиToolStripMenuItem1.Text = "По названию книги";
            this.поНазваниюКнигиToolStripMenuItem1.Click += new System.EventHandler(this.поНазваниюКнигиToolStripMenuItem1_Click);
            // 
            // поДатеЗаказаToolStripMenuItem
            // 
            this.поДатеЗаказаToolStripMenuItem.Name = "поДатеЗаказаToolStripMenuItem";
            this.поДатеЗаказаToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.поДатеЗаказаToolStripMenuItem.Text = "По дате бронирования";
            this.поДатеЗаказаToolStripMenuItem.Click += new System.EventHandler(this.поДатеЗаказаToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Searh_name,
            this.Search_FIO,
            this.Search_date,
            this.Sort_date,
            this.Sort_name,
            this.Delete,
            this.closeMenu});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(2, 54);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(32, 191);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // Searh_name
            // 
            this.Searh_name.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Searh_name.Image = ((System.Drawing.Image)(resources.GetObject("Searh_name.Image")));
            this.Searh_name.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Searh_name.Name = "Searh_name";
            this.Searh_name.Size = new System.Drawing.Size(30, 20);
            this.Searh_name.Text = "Выборка по критериям";
            this.Searh_name.Click += new System.EventHandler(this.Searh_name_Click);
            // 
            // Search_FIO
            // 
            this.Search_FIO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Search_FIO.Image = ((System.Drawing.Image)(resources.GetObject("Search_FIO.Image")));
            this.Search_FIO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_FIO.Name = "Search_FIO";
            this.Search_FIO.Size = new System.Drawing.Size(30, 20);
            this.Search_FIO.Text = "Поиск по имени заказчика";
            this.Search_FIO.ToolTipText = "Поиск по фамилии заказчика";
            this.Search_FIO.Click += new System.EventHandler(this.Search_FIO_Click);
            // 
            // Search_date
            // 
            this.Search_date.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Search_date.Image = ((System.Drawing.Image)(resources.GetObject("Search_date.Image")));
            this.Search_date.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_date.Name = "Search_date";
            this.Search_date.Size = new System.Drawing.Size(30, 20);
            this.Search_date.Text = "Выходнын в библиотеке";
            this.Search_date.Click += new System.EventHandler(this.Search_date_Click);
            // 
            // Sort_date
            // 
            this.Sort_date.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sort_date.Image = ((System.Drawing.Image)(resources.GetObject("Sort_date.Image")));
            this.Sort_date.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sort_date.Name = "Sort_date";
            this.Sort_date.Size = new System.Drawing.Size(30, 20);
            this.Sort_date.Text = "Сортировка по фамилии";
            this.Sort_date.Click += new System.EventHandler(this.Sort_date_Click);
            // 
            // Sort_name
            // 
            this.Sort_name.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sort_name.Image = ((System.Drawing.Image)(resources.GetObject("Sort_name.Image")));
            this.Sort_name.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sort_name.Name = "Sort_name";
            this.Sort_name.Size = new System.Drawing.Size(30, 20);
            this.Sort_name.Text = "Сортировка по имени";
            this.Sort_name.Click += new System.EventHandler(this.Sort_name_Click);
            // 
            // Delete
            // 
            this.Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(30, 20);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // closeMenu
            // 
            this.closeMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeMenu.Image = ((System.Drawing.Image)(resources.GetObject("closeMenu.Image")));
            this.closeMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(30, 20);
            this.closeMenu.Text = "Скрыть меню";
            this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.Location = new System.Drawing.Point(464, 97);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(343, 82);
            this.Results.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(616, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 24;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(461, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Результаты";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.SystemColors.Window;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(495, 488);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(80, 13);
            this.Date.TabIndex = 26;
            this.Date.Text = "Дата и время:";
            // 
            // CurrentDateTimeLabel
            // 
            this.CurrentDateTimeLabel.AutoSize = true;
            this.CurrentDateTimeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.CurrentDateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentDateTimeLabel.Location = new System.Drawing.Point(578, 488);
            this.CurrentDateTimeLabel.Name = "CurrentDateTimeLabel";
            this.CurrentDateTimeLabel.Size = new System.Drawing.Size(0, 16);
            this.CurrentDateTimeLabel.TabIndex = 27;
            this.CurrentDateTimeLabel.UseCompatibleTextRendering = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // action
            // 
            this.action.AutoSize = true;
            this.action.BackColor = System.Drawing.SystemColors.Window;
            this.action.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.action.Location = new System.Drawing.Point(34, 488);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(60, 13);
            this.action.TabIndex = 28;
            this.action.Text = "Действие:";
            // 
            // Act
            // 
            this.Act.AutoSize = true;
            this.Act.BackColor = System.Drawing.SystemColors.Window;
            this.Act.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Act.Location = new System.Drawing.Point(97, 488);
            this.Act.Name = "Act";
            this.Act.Size = new System.Drawing.Size(0, 13);
            this.Act.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(309, 488);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Кол-во объектов:";
            // 
            // col
            // 
            this.col.AutoSize = true;
            this.col.BackColor = System.Drawing.SystemColors.Window;
            this.col.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.col.Location = new System.Drawing.Point(400, 488);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(13, 13);
            this.col.TabIndex = 31;
            this.col.Text = "0";
            // 
            // Openmenu
            // 
            this.Openmenu.BackColor = System.Drawing.SystemColors.Window;
            this.Openmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Openmenu.Location = new System.Drawing.Point(9, 32);
            this.Openmenu.Margin = new System.Windows.Forms.Padding(0);
            this.Openmenu.Name = "Openmenu";
            this.Openmenu.Size = new System.Drawing.Size(94, 22);
            this.Openmenu.TabIndex = 32;
            this.Openmenu.Text = "Открыть меню";
            this.Openmenu.UseVisualStyleBackColor = false;
            this.Openmenu.Visible = false;
            this.Openmenu.Click += new System.EventHandler(this.Openmenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(819, 512);
            this.Controls.Add(this.Openmenu);
            this.Controls.Add(this.col);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Act);
            this.Controls.Add(this.action);
            this.Controls.Add(this.CurrentDateTimeLabel);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkReserv);
            this.Controls.Add(this.saveReserv);
            this.Controls.Add(this.reservation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Электронная библиотека";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reservation;
        private System.Windows.Forms.Button saveReserv;
        private System.Windows.Forms.Button checkReserv;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox name2Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюКнигиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поДатеЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Searh_name;
        private System.Windows.Forms.ToolStripButton Search_FIO;
        private System.Windows.Forms.ToolStripButton Search_date;
        private System.Windows.Forms.ToolStripButton Sort_date;
        private System.Windows.Forms.ToolStripButton Sort_name;
        private System.Windows.Forms.ToolStripButton Delete;
        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label CurrentDateTimeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label action;
        private System.Windows.Forms.Label Act;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label col;
        private System.Windows.Forms.ToolStripButton closeMenu;
        private System.Windows.Forms.Button Openmenu;
    }
}

