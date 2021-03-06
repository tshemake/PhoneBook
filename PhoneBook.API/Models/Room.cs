﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.API.Models
{
    /// <summary>
    /// Кабинет
    /// </summary>
    public class Room
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Наименование кабинета
        /// </summary>
        [DisplayName("Наименование кабинета")]
        public string Name { get; set; }

        /// <summary>
        /// Этаж
        /// </summary>
        [DisplayName("Этаж")]
        [ForeignKey("FloorId")]
        public Floor Floor { get; set; }
        public long FloorId { get; set; }
    }
}
