﻿namespace EventMenegmentAdmin.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
       public List<string>? Role { get; set; }
    }
}
