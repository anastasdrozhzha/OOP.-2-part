using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _1._1_Windows_Form.Cartoons;


namespace _1._1_Windows_Form
{
    
    delegate void Comparator();
    public partial class Form1 : Form
    {
        int var_for_sort;
        public void Sort() 
    {
            try
            {
                Results.Items.Clear();
                if (var_for_sort == 1) 
                { 
                     var Sorted_list = from i in Massive_of_characters
                                          orderby i.all_characters descending
                                          select i;
                        foreach (Cartoons s in Sorted_list)
                        {
                            Results.Items.Add(s.all_characters + " ~ " + s.type_characters + " ~ " + s.time + " minutes" + " ~ " + s.character);
                        }
                }
                if (var_for_sort == 2)
                {
                    var Sorted_list = from i in Massive_of_characters
                                      orderby i.all_characters ascending
                                      select i;
                    foreach (Cartoons s in Sorted_list)
                    {
                        Results.Items.Add(s.all_characters + " ~ " + s.type_characters + " ~ " + s.time + " minutes" + " ~ " + s.character);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private List<Cartoons> Massive_of_characters;


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Results.Items.Clear();
                if (Massive_of_characters == null || Massive_of_characters.Count == 0)
                {
                    MessageBox.Show("Something wrong((( Collection is empty");
                }
                else
                {

                    string type_temp = "Choleric";
                    var list_of_temp = from m in Massive_of_characters
                                       where m.type_characters == type_temp
                                       select m;
                    foreach (Cartoons s in list_of_temp) 
                    {
                        Results.Items.Add(s.all_characters + " ~ " + s.type_characters + " ~ " + s.time + " minutes" + " ~ " + s.character);
                    }
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Collection.Items.Clear();
                int count= Convert.ToInt32(textBox5.Text);
                if (textBox5.Text == "" || (count = Convert.ToInt32(textBox5.Text)) == 0)
                {
                    MessageBox.Show("Input the size....");
                    this.Massive_of_characters = null;
                }
                else
                {
                    Massive_of_characters = new List<Cartoons>(count);
                    Cartoons per;
                    for (int i = 0; i < count; i++)
                    {
                        per = new Cartoons();
                        Massive_of_characters.Add(per);
                    }
                    foreach (Cartoons s in Massive_of_characters)
                    {
                        Collection.Items.Add(s.all_characters+" ~ "+ s.type_characters + " ~ " + s.time+" minutes" + " ~ " + s.character );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                 char number = e.KeyChar;
                 if (!Char.IsDigit(number))
                 {
                    e.Handled = true;
                     textBox5.BackColor = Color.Red;
                 }

                else textBox5.BackColor = SystemColors.Window;
            }
            catch (FormatException)
            {
                MessageBox.Show("Error, you input wrong numbers!Try again");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            Collection.Items.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var_for_sort = 1;
                Results.Items.Clear();
                if (Massive_of_characters == null || Massive_of_characters.Count == 0)
                {
                    MessageBox.Show("Something wrong((( Collection is empty");
                }
                else
                {
                    Comparator var;
                    var = Sort;
                    var();
                }
             }
             catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Results.Items.Clear();
                if (Massive_of_characters == null || Massive_of_characters.Count == 0)
                {
                    MessageBox.Show("Something wrong((( Collection is empty");
                }
                else
                {

                    var list_of_time = from m in Massive_of_characters
                                           where m.time>50 && m.time<75
                                           select m;
                    foreach (Cartoons s in list_of_time)
                    {
                        Results.Items.Add(s.all_characters + " ~ " + s.type_characters + " ~ " + s.time + " minutes" + " ~ " + s.character);
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Results.Items.Clear();
                if (Massive_of_characters == null || Massive_of_characters.Count == 0)
                {
                    MessageBox.Show("Something wrong((( Collection is empty");
                }
                else
                {
                    var list_of_time = from m in Massive_of_characters
                                       where m.character == 1
                                       select m;
                    foreach (Cartoons s in list_of_time)
                    {
                        Results.Items.Add(s.all_characters + " is a good character ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Results.Items.Clear();
                if (Massive_of_characters == null || Massive_of_characters.Count == 0)
                {
                    MessageBox.Show("Something wrong((( Collection is empty");
                }
                else
                {
                    var_for_sort = 2;
                    Comparator variable;
                    variable = Sort;
                    variable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }
    }
}
