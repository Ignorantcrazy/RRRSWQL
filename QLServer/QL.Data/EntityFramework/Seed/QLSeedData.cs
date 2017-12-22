using Microsoft.EntityFrameworkCore;
using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL.Data.EntityFramework.Seed
{
    public static class QLSeedData
    {
        public static void Initialize(this QLContext db)
        {
            if (!db.Droids.Any())
            {
                Droid droid = new Droid
                {
                    Id = 1,
                    Name = "R2-D2"
                };
                db.Droids.Add(droid);
                droid = new Droid
                {
                    Id = 2,
                    Name = "R3-D3"
                };
                db.Droids.Add(droid);
                droid = new Droid
                {
                    Id = 3,
                    Name = "R4-D4"
                };
                db.Droids.Add(droid);
                db.SaveChanges();
            }

            if (!db.Friends.Any())
            {
                Friend friend = new Friend {Id = 1, Name = "R2-A", Sex = 0, Droid = new Droid { Id = 1, Name = "R2-D2" } };
                db.Friends.Add(friend);
                friend = new Friend { Id = 2, Name = "R2-B", Sex = 0, Droid = new Droid { Id = 1, Name = "R2-D2" } };
                db.Friends.Add(friend);
                friend = new Friend { Id = 3, Name = "R2-C", Sex = 1, Droid = new Droid { Id = 2, Name = "R3-D3" } };
                db.Friends.Add(friend);
                friend = new Friend { Id = 4, Name = "R2-D", Sex = 1, Droid = new Droid { Id = 3, Name = "R4-D4" } };
                db.Friends.Add(friend);
                db.SaveChanges();
            }
        }
    }
}
