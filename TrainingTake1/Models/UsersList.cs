using System.Collections.Generic;
using MongoDB.Driver;

namespace TrainingTake1.Models
{
    public class UsersList
    {
        public IEnumerable<User> Users { get; set; }
    }
}