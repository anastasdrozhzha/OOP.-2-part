using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Электронная_библиотека
{
    public partial class Search_name : Form
    {
        public Search_name()
        {
            InitializeComponent();
        }
        private void name2Box_KeyPress(object sender, KeyPressEventArgs e)
        { 
        }

        private void findbook_Click(object sender, EventArgs e)
        {
            int n = 0;
            int num = 0;
            XmlDocument doc = new XmlDocument();
            doc.Load("Test.xml");
            switch (inf.Value)
            {
                case "book":
                    foreach (XmlElement element in doc.GetElementsByTagName("name_first"))
                    {
                        if (element.InnerText == name2Box.Text)
                        {
                            Results.Items.Add(element.InnerText + " была забронирована");
                            n = 1;
                        }
                    }
                    if (n == 0)
                    {
                        Results.Items.Add("Эта книга не бронировалась или отсутсвует");
                    }
                    n = 0;
                    break;

                case "FIO":
                    foreach (XmlElement element in doc.GetElementsByTagName("name_second"))
                    {
                        if (element.InnerText == name2Box.Text)
                        {
                            Results.Items.Add(element.InnerText + " бронировал(а) книгу в библиотеке");
                            n = 1;
                        }
                    }
                    if (n == 0)
                    {
                        Results.Items.Add("Этот человек отсутсвует в базе");
                    }
                    n = 0;
                    break;

                case "data":
                    foreach (XmlElement element in doc.GetElementsByTagName("data"))
                    {

                        if (element.InnerText == name2Box.Text)
                        {
                            num = num + 1;
                            n = 1;
                        }
                    }
                    Results.Items.Add(name2Box.Text + " было забронировано(ы) " + num + " книг(и) ");
                    n = 0;
                    break;

                case "dataVih":
                    name2Box.Text = "Выходные дни";
                    int  T= 0;
                    string days = @"Режим работы: пн-ср с 8.00 до 19.00, чт-сб с 8.00 до 19.00, вс(вых)" +
                        "Дополнительные выходные дни: (вых)21.05.2021." +
                        "Дополнительные выходные дни: 30.05.2021(вых) " +
                        "Дополнительные выходные дни: 08.03.2021(вых) " +
                        "Дополнительные выходные дни: 20.06.2021(вых) " +
                        "Дополнительные выходные дни: 26.07.2021(вых) " +
                        "Дополнительные выходные дни: 01.08.2021(вых) " +
                        "Дополнительные выходные дни: 22.06.2021(вых) ";
                    Regex regexf = new Regex(@"[0-9]{2}.[0-9]{2}.[0-9]{4}");
                    MatchCollection matchesf = regexf.Matches(days);
                    if (matchesf.Count > 0)
                    {
                        foreach (Match match in matchesf)
                        {
                            T = T + 1;
                            Results.Items.Add(match.Value);
                        }
                        Results.Items.Add("Количсетво выходных: " + T);
                    }
                    else
                    {
                        Results.Items.Add("Совпадений не найдено");
                    }
                    break;
                case "bookreg":

                    name2Box.Text = "Слова начинаются с М*, В*,Д*";
                    int k = 0;
                    string books = @"Зов предков, Белый клык, Костер, Люди бездны, Лунная долина, Сын солнца, Искусство любить," +
                        "Иметь или быть?, Здоровое общество, Душа человека, Из плена иллюзий, Искусство слушать, Мужчины с Марса, женщины с Венеры" +
                        "Марс и Венера в спальне, Дети - с небес, Рецепты счастливых отношений, Марс и Венера. Почему мы ссоримся? " +
                        "Код да Винчи, Ангелы и демоны, Утраченный символ, Инферно, Точка обмана, Я и Оно, Толкование сноведений," +
                        "Тотем и табу, Очерки по истерии, Очерк психоанализа, Жуткое, Князь света, Владения Хаоса, Знак единорога" +
                        "Джек из тени, Принц Хаоса, Знак Хаоса, pattern";
                    Regex regex = new Regex(@"М(\w*)|В(\w*)|Д(\w*)");
                    MatchCollection matches = regex.Matches(books);
                    if (matches.Count > 0)
                    {
                        foreach (Match match in matches)
                        {
                            k = k + 1;
                            Results.Items.Add(match.Value);
                        }
                        Results.Items.Add("Количсетво таких слов: "+ k);
                    }
                    else
                    {
                        Results.Items.Add("Совпадений не найдено");
                    }

                    break;
            }
        }    
       
        private void button1_Click(object sender, EventArgs e)
        {
            XElement element = new XElement("Items");
            foreach (var item in Results.Items)
            {
                element.Add(new XElement("Name", item));
            }
            XDocument document = new XDocument();
            document.Add(element);
            document.Save("items.xml", SaveOptions.DisableFormatting); //create items.xml file in bin folder
            Results.Items.Add("");
            Results.Items.Add("Запись в файл прошла успешно!");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
