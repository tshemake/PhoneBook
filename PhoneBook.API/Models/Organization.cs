using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.API.Models
{
    /// <summary>
    /// Организация
    /// </summary>
    public class Organization
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Наименование организации
        /// </summary>
        [DisplayName("Наименование организации")]
        public string Name { get; set; }

        /// <summary>
        /// Здания
        /// </summary>
        [DisplayName("Здания")]
        public ICollection<Building> Buildings { get; set; }

        /// <summary>
        /// Подразделения
        /// </summary>
        [DisplayName("Подразделения")]
        public ICollection<Subdivision> Subdivisions { get; set; }

        /// <summary>
        /// Отделы
        /// </summary>
        [DisplayName("Отделы")]
        public ICollection<Department> Departments { get; set; }
    }
}
