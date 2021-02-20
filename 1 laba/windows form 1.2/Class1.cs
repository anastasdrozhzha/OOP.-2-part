using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1._1_Windows_Form
{
    public class Cartoons
    {
        public int time;
        public int character;
        public string all_characters;
        public string type_characters;
        private string[] names_of_characters = new string[8]
        {
            "Lilo", "Stich", "Nani", "AgentVendi", "Dzhamba", "CaptainGanty", "GrandConsul", "CobiaBabbls"
        };
        private string[] types_of_characters = new string[4]
       {
            "Sanguine", "Choleric", "Melancholic", "Phlegmatic"
       };


        public short Character;
            public string Name;

        public Cartoons() 
        {
            Random random = new Random();
            Thread.Sleep(1);
            this.time = (short)random.Next(1, 70);
            this.character = (short)random.Next(0, 2);
            this.all_characters = names_of_characters[random.Next(0, 8)];
            this.type_characters = types_of_characters[random.Next(0, 4)];
        }         
    }
}
