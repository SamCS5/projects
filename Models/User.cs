﻿namespace UserApplication.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Permission> Permissions { get; set; }
    }
}
