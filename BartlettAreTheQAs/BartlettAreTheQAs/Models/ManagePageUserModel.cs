﻿namespace BartlettAreTheQAs.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ManagePageUserModel
    {
        public string Key { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string Id { get; set; }
        public string FullName { get; set; }
    }
}
