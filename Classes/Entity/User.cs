namespace PerfumeWorld.Classes.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        [Required]
        public string UserFullName { get; set; }

        [Required]
        public string UserLogin { get; set; }

        [Required]
        public string UserPassword { get; set; }

        public virtual Role Role { get; set; }
    }
}
