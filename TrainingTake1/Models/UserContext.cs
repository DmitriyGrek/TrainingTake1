using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace TrainingTake1.Models
{
    public class UserContext
    {
        MongoClient user;
        IMongoDatabase database;

        public UserContext()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString;
            var con = new MongoUrlBuilder(connectionString);

            user = new MongoClient(connectionString);
            database = user.GetDatabase(con.DatabaseName);
            //gridFS = new MongoGridFS(
            //    new MongoServer(
            //        new MongoServerSettings { Server = con.Server }),
            //    con.DatabaseName,
            //    new MongoGridFSSettings()
            //);
        }

        public IMongoCollection<User> Users => database.GetCollection<User>("Users");
    }


}