using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SecondHFTez.Core.Entities;

namespace SecondHFTez.Entities.Concrete
{
    [Table("Users")]
    public class SecondHfUser : SecondHfBase, IEntity
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public string TelNumber { get; set; }
        public bool IsActive { get; set; }
        public Guid ActiveGuid { get; set; }
        public byte[] Image { get; set; }


        public int Role_Id { get; set; }


    }
}