using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePeClone.Domain.Entities
{
    

    public class User
    {
        public Guid Id { get; private set; }
        public string FullName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsActive { get; private set; }

        private User() { } // required by EF Core

        public User(string fullName, string phoneNumber, string email, string passwordHash)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            PasswordHash = passwordHash;
            CreatedAt = DateTime.UtcNow;
            IsActive = true;
        }
    }
}

