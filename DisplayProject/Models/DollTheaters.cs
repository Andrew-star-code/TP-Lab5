using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DisplayProject.Models
{
    public class DollTheaters
    {
        public int Id { get; set; }

        [DisplayName("Название театра")]
        public string Name { get; set; }

        [DisplayName("Город")]
        public string City { get; set; }

        [DisplayName("Дата основания")]
        [DataType(DataType.Date)]
        public DateTime OpenDate { get; set; }

        [DisplayName("Количество представлений")]
        public int NumberOfPerfomances { get; set; }

        [DisplayName("Средняя цена билета")]
        public double AveragePerfomancePrice { get; set; }

        [DisplayName("Ежегодный доход")]
        public decimal AnnualRevenue { get; set; }
    }
}
