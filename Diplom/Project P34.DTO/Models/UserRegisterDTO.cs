﻿using Project_P34.API_Angular.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project_IDA.DTO.Models
{
    public class UserRegisterDto
    {
        [Required(ErrorMessage = "Введіть name")]
        public string Name { get; set; }

        [Required]
        public string Surnmame { get; set; }

        [Required(ErrorMessage = "Введіть електронну пошту")]
        [EmailAddress(ErrorMessage = "Некоректно введена електронна пошта")]
        [CustomEmail(ErrorMessage = "Така електронна пошта вже зареєстрована")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введіть пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Введіть телефон")]
        public string PhoneNumber { get; set; }



    }
}
