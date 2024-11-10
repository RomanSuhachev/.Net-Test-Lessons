using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TestCRM.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Не указан ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано Имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указана Фамилия")]
        public string? SurName { get; set; }
        
        public UserModel()
        {
            
        }
        
        public UserModel(int id, string name, string surName)
        {
            Id = id;
            Name = name;
            SurName = surName;
        }
    }
}