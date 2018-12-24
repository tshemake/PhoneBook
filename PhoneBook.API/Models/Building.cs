using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.API.Models
{
    /// <summary>
    /// Здание
    /// </summary>
    public class Building
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Наименование здания
        /// </summary>
        [DisplayName("Наименование здания")]
        public string Name { get; set; }

        /// <summary>
        /// Этажи
        /// </summary>
        [DisplayName("Этажи")]
        public ICollection<Floor> Floors { get; set; }
    }
}
