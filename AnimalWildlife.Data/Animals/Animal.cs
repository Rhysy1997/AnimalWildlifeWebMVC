using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AnimalWildlife.Data.Animals
{
    public class Animal
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Name of pet Required")]
        [StringLength(20, ErrorMessage = "Cannot be longer than 20 characters.")]
        [RegularExpression("^([A-Za-z]+)$", ErrorMessage = "Invalid Name. Only letters allowed.")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Type of pet Required")]
        [StringLength(20, ErrorMessage = "Cannot be longer than 20 characters.")]
        [RegularExpression("^([A-Za-z]+)$", ErrorMessage = "Invalid Type. Only letters allowed.")]
        public string Type { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Breed of pet Required")]
        [StringLength(20, ErrorMessage = "Cannot be longer than 20 characters.")]
        [RegularExpression("^([A-Za-z]+)$", ErrorMessage = "Invalid Breed. Only letters allowed.")]
        public string Breed { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression("^([M|m|F|f])$", ErrorMessage = "Invalid Gender (e.g 'M' or 'F')")]
        [Required(ErrorMessage = "Gender of pet Required")]
        public char Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [StringLength(40, ErrorMessage = "Description cannot be longer than 40 characters.")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public string Image { get; set; }
    }
}
