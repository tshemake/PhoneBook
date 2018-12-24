using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.API.Models
{
    /// <summary>
    /// Должность
    /// </summary>
    public class Position
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Наименование должности
        /// </summary>
        [DisplayName("Наименование должности")]
        public string Name { get; set; }
    }
}
