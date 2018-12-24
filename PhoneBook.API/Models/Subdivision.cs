using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.API.Models
{
    /// <summary>
    /// Подразделение
    /// </summary>
    public class Subdivision
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Наименование подразделения
        /// </summary>
        [DisplayName("Наименование подразделения")]
        public string Name { get; set; }

        /// <summary>
        /// Отделы
        /// </summary>
        [DisplayName("Отделы")]
        public ICollection<Department> Departments { get; set; }
    }
}
