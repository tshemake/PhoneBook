using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("BuildingId")]
        public Building Building { get; set; }
        public long BuildingId { get; set; }

        /// <summary>
        /// Кабинет
        /// </summary>
        [DisplayName("Кабинет")]
        [ForeignKey("RoomId")]
        public Room Room { get; set; }
        public long RoomId { get; set; }

        /// <summary>
        /// Подразделение
        /// </summary>
        [DisplayName("Подразделение")]
        [ForeignKey("SubdivisionId")]
        public Subdivision Subdivision { get; set; }
        public long? SubdivisionId { get; set; }

        /// <summary>
        /// Отделение
        /// </summary>
        [DisplayName("Отделение")]
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public long? DepartmentId { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        [DisplayName("Должность")]
        [ForeignKey("PositionId")]
        public Position Position { get; set; }
        public long PositionId { get; set; }
    }
}
