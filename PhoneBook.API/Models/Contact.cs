using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.API.Models
{
    /// <summary>
    /// Контакт
    /// </summary>
    public class Contact
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [DisplayName("Имя")]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [DisplayName("Фамилия")]
        public string SecondName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }

        /// <summary>
        /// Внутренний телефон
        /// </summary>
        [DisplayName("Внутренний телефон")]
        [Validators.Phone]
        public string PhoneInternal { get; set; }

        /// <summary>
        /// Внешний телефон
        /// </summary>
        [DisplayName("Внешний телефон")]
        [Validators.Phone]
        public string PhoneExternal { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        [DisplayName("Электронная почта")]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Здание
        /// </summary>
        [DisplayName("Здание")]
        public Building Building { get; set; }

        /// <summary>
        /// Кабинет
        /// </summary>
        [DisplayName("Кабинет")]
        public Room Room { get; set; }

        /// <summary>
        /// Отделение
        /// </summary>
        [DisplayName("Отделение")]
        public Department Department { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        [DisplayName("Должность")]
        public Position Position { get; set; }
    }
}
