using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Numerics;


namespace TestCRM.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано Имя")]
        [StringLength(2, ErrorMessage = "Поле имя не может быть меньше 2 символов и содержать только пробелы")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указана Фамилия")]
        [DataType(DataType.Text)]
        public string? SurName { get; set; }
        
        public UserModel()
        {
            
        }
        
        public UserModel(string name, string surName)
        {
            Name = name;
            SurName = surName;
        }
    }
}