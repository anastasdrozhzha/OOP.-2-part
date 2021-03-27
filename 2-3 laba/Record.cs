using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Электронная_библиотека
{
    public abstract class Author
    {
        public string nameAut;
    }
    [Serializable]
    [DataContract]
    class Record
    {
        [DataMember]
        [Required(ErrorMessage = "Имя указано неверно!!!!!!")]
        [StringLength(50, MinimumLength = 2)]
        public string name_first { get; set; }
       
        [DataMember]
        [Required(ErrorMessage = "Фамилия указано неверно!!!!!!")]
        [StringLength(50, MinimumLength = 2)]
        public string name_second { get; set; }

        [DataMember]
        [Required(AllowEmptyStrings = true)]
        public string telephone { get; set; }


        [Required(ErrorMessage = "Книга не указана!!!!!!")]
        public string book { get; set; }


        [DataMember] 
        [Required(AllowEmptyStrings = true)]
        //[MyAttribute]
        public string data { get; set; }

        public Author author { get; set; }

        public Record(Author aut)
        {
            author = aut;
        }


        public Record(string name_second, string name_first,   string book,string telephone,string data)
        {
            this.name_second = name_second;
            this.name_first = name_first;
            this.telephone = telephone;
            this.book = book;
            this.data = data;
        }
    }
}
