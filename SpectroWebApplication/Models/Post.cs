namespace SpectroWebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public bool IsPublic { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        [MaxLength]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual Account Account { get; set; }
    }
}
