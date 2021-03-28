using System;
using System.Windows.Forms;

namespace Электронная_библиотека
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
       
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            nameBox.Text = Data.Value;
            switch (Data.Value)
            {
                case "Джек Лондон":
                    textBox1.Text = "40 лет, умер в 1916г";
                    textBox2.Text = "1236";
                    Book.Items.Add("Зов предков");
                    Book.Items.Add("Белый клык");
                    Book.Items.Add("Костер");
                    Book.Items.Add("Люди бездны");
                    Book.Items.Add("Лунная долина");
                    Book.Items.Add("Сын солнца");
                    break;

                case "Эрих Фромм":
                    textBox1.Text = "80 лет, умер в 1980г";
                    textBox2.Text = "7852";
                    Book.Items.Add("Искусство любить");
                    Book.Items.Add("Иметь или быть?");
                    Book.Items.Add("Здоровое общество");
                    Book.Items.Add("Душа человека");
                    Book.Items.Add("Из плена иллюзий");
                    Book.Items.Add("Искусство слушать");
                    break;

                case "Джон Грей":
                    textBox1.Text = "69 лет";
                    textBox2.Text = "1569";
                    Book.Items.Add("Мужчины с Марса, женщины с Венеры");
                    Book.Items.Add("Марс и Венера в спальне");
                    Book.Items.Add("Дети - с небес");
                    Book.Items.Add("Рецепты счастливых отношений");
                    Book.Items.Add("Марс и Венера. Почему мы ссоримся?");
                    break;

                case "Дэн Браун":
                    textBox1.Text = "56 лет";
                    textBox2.Text = "4587";
                    Book.Items.Add("Код да Винчи");
                    Book.Items.Add("Ангелы и демоны");
                    Book.Items.Add("Утраченный символ");
                    Book.Items.Add("Инферно");
                    Book.Items.Add("Точка обмана");
                    break;
                case "Зигмунд Фрейд":
                    textBox1.Text = "83 лет, умер в 1939г";
                    textBox2.Text = "6514";
                    Book.Items.Add("Я и Оно");
                    Book.Items.Add("Толкование сноведений");
                    Book.Items.Add("Тотем и табу");
                    Book.Items.Add("Очерки по истерии");
                    Book.Items.Add("Очерк психоанализа");
                    Book.Items.Add("Жуткое");
                    break;
                case "Роджер Желязны":
                    textBox1.Text = "58 лет, умер в 1995г";
                    textBox2.Text = "9856";
                    Book.Items.Add("Князь света") ;
                    Book.Items.Add("Владения Хаоса");
                    Book.Items.Add("Знак единорога");
                    Book.Items.Add("Джек из тени");
                    Book.Items.Add("Принц Хаоса");
                    Book.Items.Add("Знак Хаоса");
                    break;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Bookname.Value = (string)Book.SelectedItem;
            Enum.Value = "yes";
        }

        private void reservation_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
