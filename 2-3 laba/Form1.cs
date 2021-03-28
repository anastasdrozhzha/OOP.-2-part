using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Linq;

namespace Электронная_библиотека
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDown1.TextChanged += domainUpDown1_TextChanged;
        }

        private List<Record> list_of_records = new List<Record>();
        private List<Record> listSort = new List<Record>();
        void domainUpDown1_TextChanged(object sender, EventArgs e)
        {
            Data.Value = domainUpDown1.Text;
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                nameBox.BackColor = Color.Red;
            }
            else nameBox.BackColor = SystemColors.Window;
        }

        private void name2Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                name2Box.BackColor = Color.Red;
            }
            else name2Box.BackColor = SystemColors.Window;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.Value == null)
            {
                MessageBox.Show("Вы не выбрали автора!!!");
            }
            else
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
        }

        private void reservation_Click(object sender, EventArgs e)
        {
            textBox1.Text = Bookname.Value;
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = Bookname.Value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
              Record record = new Record(this.name2Box.Text, this.textBox1.Text, this.nameBox.Text, this.maskedTextBox1.Text, this.monthCalendar1.SelectionRange.Start.ToShortDateString());

            var results = new List<ValidationResult>(); // список не прошедших валидацию полей в классе 
            var context = new ValidationContext(record); // контекст (шаблон), по которому проходит проверка валидации
            if (!Validator.TryValidateObject(record, context, results, true))
            {
                string errors = "";
                foreach (var error in results)
                {
                    errors += error.ErrorMessage + '\n';
                }
                MessageBox.Show(errors, "Ошибка");
                return;
            }
                       
                list_of_records.Add(record);
                this.richTextBox1.Text = this.nameBox.Text + " " + this.name2Box.Text + " с номером телефона " + this.maskedTextBox1.Text + " забронировал(а) книгу " + this.textBox1.Text + " на " + this.monthCalendar1.SelectionRange.Start.ToShortDateString() + "\r\n";
                
                Act.Text = "Добавлен объект";
                
                col.Text = list_of_records.Count.ToString(); 
        }
            /*try
            {
                if (this.name2Box.Text.Equals("") || this.nameBox.Text.Equals("") || this.textBox1.Text.Equals(""))
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {
                    Record record = new Record(this.name2Box.Text, this.textBox1.Text, this.nameBox.Text, this.maskedTextBox1.Text, this.monthCalendar1.SelectionRange.Start.ToShortDateString());


                    this.richTextBox1.Text = this.nameBox.Text + " " + this.name2Box.Text + " с номером телефона " + this.maskedTextBox1.Text + " забронировал(а) книгу " + this.textBox1.Text + " на " + this.monthCalendar1.SelectionRange.Start.ToShortDateString() + "\r\n";
                    list_of_records.Add(record);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }*/
        //}

        private void saveReserv_Click(object sender, EventArgs e)
        {
            NetDataContractSerializer serializer = new NetDataContractSerializer();
            using (FileStream fs = File.Create("Test.xml"))
            {
                serializer.Serialize(fs, list_of_records);
            }
            richTextBox1.Text = "";
            richTextBox1.Text = "Запись в файл произошла успешно!";
            Act.Text = "Запись в файл";

        }

        private void checkReserv_Click(object sender, EventArgs e)
        {
            Act.Text = "Проверено бронирование";
            string InputXML = @"Test.XML";

             XmlDocument XmlDoc = new XmlDocument();

             XmlDoc.Load(InputXML);

             foreach (XmlNode Record in XmlDoc.GetElementsByTagName("name_second"))
             {
                 foreach (XmlNode PlaceNode in Record.ChildNodes)
                 {
                     richTextBox1.Text = "Читатель " +PlaceNode.InnerText+" забронировал книгу в библиотеке по адресу ул.Бродского 57. По всем вопросам звоните +(017)674-45-45";
                 }
             }

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prog prog = new Prog();
            prog.ShowDialog();
        }

        private void поНазваниюКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inf.Value = "book";
            Search_name sr = new Search_name();
            sr.Show();
            sr.Infa.Text = "Введите точное название книги";

        }

        private void Searh_name_Click(object sender, EventArgs e)
        {
            inf.Value = "bookreg";
            Search_name sr = new Search_name();
            sr.Show();
            sr.Infa.Text = "Нажмите кнопку Найти, чтобы найти слова,\n"+
                "которые содержат буквы М, В, Д";
        }

        private void поИмениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inf.Value = "FIO";
            Search_name sr = new Search_name();
            sr.Show();
            sr.Infa.Text = "Введите фамилию заказчика";
        }

        private void Search_FIO_Click(object sender, EventArgs e)
        {
            inf.Value = "FIO";

            Search_name sr = new Search_name();
            sr.Show();
            sr.Infa.Text = "Введите фамилию заказчика";
        }

        private void поФамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inf.Value = "data";
            Search_name sr = new Search_name();
            sr.Show();
            sr.Infa.Text = "Введите дату бронирования в формате 01.01.2021";
        }

        private void Search_date_Click(object sender, EventArgs e)
        {
            inf.Value = "dataVih";
            Search_name sr = new Search_name();
            sr.Show();
            sr.Infa.Text = " Нажмите кнопку Найти, чтоб увидеть выходные в библиотеке";
        }

        private void поНазваниюКнигиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (list_of_records.Count == 0)
            {
                MessageBox.Show("Добавьте запись!");
            }
            else
            {
                Results.Items.Clear();
                var Sorted_list = from i in list_of_records
                                  orderby i.name_first ascending
                                  select i;
                foreach (Record s in Sorted_list)
                {
                    Results.Items.Add(s.name_first + " ~~ " + s.name_second);
                }
            }
        }

        private void поДатеЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list_of_records.Count == 0)
            {
                MessageBox.Show("Добавьте запись!");
            }
            else
            { 
               
                Results.Items.Clear();
                var Sorted_list = from i in list_of_records
                                  orderby i.data ascending
                                  select i;
                foreach (Record s in Sorted_list)
                {
                    Results.Items.Add(s.data + " ~~ " + s.name_second + " " + s.book + " " + s.name_first);
                    listSort.Add(s);
                }  
            }

        }
        private void Sort_date_Click(object sender, EventArgs e)
        {
            if (list_of_records.Count == 0)
            {
                MessageBox.Show("Добавьте запись!");
            }
            else
            {
                Results.Items.Clear();
                var Sorted_list = from i in list_of_records
                                  orderby i.name_second ascending
                                  select i;
                foreach (Record s in Sorted_list)
                {
                    Results.Items.Add(s.name_second + " ~~ " + s.name_first);
                }
            }
        }

        private void Sort_name_Click(object sender, EventArgs e)
        {
            if (list_of_records.Count==0)
            {
                MessageBox.Show("Добавьте запись!");
            }
            else
            {
                Results.Items.Clear();
                var Sorted_list = from i in list_of_records
                                  orderby i.book ascending
                                  select i;
                foreach (Record s in Sorted_list)
                {
                    Results.Items.Add(s.book + " ~~ " + s.name_first);
                }

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Results.Items.Clear();
            nameBox.Text = "";
            name2Box.Text = "";
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            richTextBox1.Text = "";
            col.Text = "";
            Act.Text = "";
        }

        private void eyes_Click(object sender, EventArgs e)
        {
            toolStrip1.Show();
           
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            CurrentDateTimeLabel.Text = DateTime.Now.ToString();
        }

        private void closeMenu_Click(object sender, EventArgs e)
        {
            toolStrip1.Hide();
            Openmenu.Visible = true;
        }

        private void Openmenu_Click(object sender, EventArgs e)
        {
            toolStrip1.Show();
            Openmenu.Visible = false;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list_of_records.Count == 0)
            {
                MessageBox.Show("Добавьте запись!");
            }
            else
            {
                Act.Text = "Сохрание в файл";
                NetDataContractSerializer serializer = new NetDataContractSerializer();
                using (FileStream fs = File.Create("Sort.xml"))
                {
                    serializer.Serialize(fs, listSort);
                }
                Act.Text = "Запись в файл";
            }
        }
    }
}
    
