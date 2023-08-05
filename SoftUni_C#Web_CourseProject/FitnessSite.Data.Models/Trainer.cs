﻿namespace FitnessSite.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationsConstants.Trainer;

    public class Trainer
    {
        public Trainer()
        {
            Id = Guid.NewGuid();
            ApllicationUsers = new HashSet<ApplicationUser>();
            Messages = new HashSet<Message>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public int Year { get; set; }

        public int StartedAt { get; set; }

        public decimal PricePerMonth { get; set; }

        [Required]
        [MaxLength(TelefoneMaxLenght)]
        public string TelefoneNumber { get; set; } = null!;

        [Required]
        [MaxLength(EmailMaxLength)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public virtual ICollection<ApplicationUser> ApllicationUsers { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
