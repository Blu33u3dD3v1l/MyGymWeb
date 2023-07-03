﻿using System.ComponentModel.DataAnnotations;
using static MyGymWeb.Common.Constants.ValidationConstants.ClasicTrainerValidations;

namespace MyGymWeb.Data.Models
{
    public class Trainer
    {

        [Key]
        public int Id { get; set; }


       
        [MaxLength(NameMaxValidation)]
        [Required]
        
        public string Name { get; set; } = null!;

        
        [MaxLength(InfoMaxValidation)]
        [Required]
        public string Info { get; set; } = null!;


        [Required]
        public string ImageUrl { get; set; } = null!;

       
        [MaxLength(PractisMaxValidation)]
        [Required]
        public string Practis { get; set; } = null!;

        [Range(typeof(decimal), PriceMaxValidation, PriceMinValidation)]
        [Required]
        public decimal PricePerHour { get; set; }

        
        public string Type { get; set; } = null!;

       
        [MaxLength(MotoMaxValidation)]
        public string Moto { get; set; } = null!;

        public List<All> All { get; set; } = new List<All>();
    }
}
