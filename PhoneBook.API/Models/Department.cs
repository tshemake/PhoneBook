using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.API.Models
{
    /// <summary>
    /// Отдел
    /// </summary>
    public class Department
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Наименование отдела
        /// </summary>
        [DisplayName("Наименование отдела")]
        public string Name { get; set; }

        /// <summary>
        /// Организация
        /// </summary>
        [DisplayName("Организация")]
        public Organization Organization { get; set; }

        /// <summary>
        /// Подразделение
        /// </summary>
        [DisplayName("Подразделение")]
        public Subdivision Subdivision { get; set; }
    }
}
