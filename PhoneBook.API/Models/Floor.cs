using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.API.Models
{
    /// <summary>
    /// Этаж
    /// </summary>
    public class Floor
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Номер этажа
        /// </summary>
        [DisplayName("Номер этажа")]
        public int Level { get; set; }

        /// <summary>
        /// Наименование этажа
        /// </summary>
        [DisplayName("Наименование этажа")]
        public string Name { get; private set; }

        /// <summary>
        /// Здание
        /// </summary>
        [DisplayName("Здание")]
        public Building Building { get; set; }

        /// <summary>
        /// Кабинеты
        /// </summary>
        [DisplayName("Кабинеты")]
        public ICollection<Room> Rooms { get; set; }
    }
}
