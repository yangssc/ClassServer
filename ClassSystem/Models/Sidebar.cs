namespace Coursmanager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sidebar")]
    public partial class Sidebar
    {
        public int Id { get; set; }

        [StringLength(10)]
        [Display(Name = "����")]
        public string Name { get; set; }

        [StringLength(32)]
        [Display(Name = "������")]
        public string Controller { get; set; }

        [StringLength(10)]
        [Display(Name = "ҳ��")]
        public string Action { get; set; }
    }
}
