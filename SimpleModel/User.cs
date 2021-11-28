using System;
using System.Collections.Generic;

namespace SimpleModel
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }

    public class DataPopulator
    {
        public IEnumerable<User> GetUsers()
        {
            var users = new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Kerem",
                    LastName = "Burak",
                    Address = "Maltepe",
                    City = "İSTANBUL"
                },
                new User
                {
                    Id = 2,
                    FirstName = "John",
                    LastName = "Doe",
                    Address = "Kadiköy",
                    City = "İSTANBUL"
                },
                new User
                {
                    Id = 3,
                    FirstName = "Mehmet",
                    LastName = "ŞİMŞEK",
                    Address = "Foça",
                    City = "İZMİR"
                },
                new User
                {
                    Id = 4,
                    FirstName = "Lale",
                    LastName = "Oraloğlu",
                    Address = "Merkez",
                    City = "Adana"
                },
                new User
                {
                    Id = 5,
                    FirstName = "Cüneyt",
                    LastName = "Arkın",
                    Address = "Merkez",
                    City = "ESKİŞEHİR"
                }
            };

            return users;
        }
    }
}
