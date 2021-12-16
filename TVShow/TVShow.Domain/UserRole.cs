﻿using System.ComponentModel.DataAnnotations;

namespace TVShows.Domain
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public Role Role { get; set; }

        public int RoleId { get; set; }

    }
}