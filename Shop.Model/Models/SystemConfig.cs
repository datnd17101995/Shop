﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Code { set; get; }

        [MaxLength(500)]
        public string ValueString { set; get; }

        public int? ValueInt { set; get; }
    }
}