﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.UserModels
{
    public class UserRegisterModel
    {
       public string FullName { get; set; }

        public string Email { get; set; }


      public string Password { get; set; }

     
        public string Mobile { get; set; }
    }
}
