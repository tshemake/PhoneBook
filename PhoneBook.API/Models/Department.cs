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
        [ForeignKey("OrganizationId")]
        public Organization Organization { get; set; }
        public long OrganizationId { get; set; }

        /// <summary>
        /// Подразделение
        /// </summary>
        [DisplayName("Подразделение")]
        [ForeignKey("SubdivisionId")]
        public Subdivision Subdivision { get; set; }
        public long? SubdivisionId { get; set; }
    }
}
