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
                    Name = "R2-D2"
                };
                db.Droids.Add(droid);
                droid = new Droid
                {
                    Name = "R3-D3"
                };
                db.Droids.Add(droid);
                droid = new Droid
                {
                    Name = "R4-D4"
                };
                db.Droids.Add(droid);
                db.SaveChanges();
            }

            if (!db.Friends.Any())
            {
                Friend friend =   new Friend{ Name = "R2-A",Sex = 0};
                db.Friends.Add(friend);
                friend = new Friend { Name = "R2-B", Sex = 0 };
                db.Friends.Add(friend);
                friend = new Friend { Name = "R2-C", Sex = 1 };
                db.Friends.Add(friend);
                friend = new Friend { Name = "R2-D", Sex = 1 };
                db.Friends.Add(friend);
                db.SaveChanges();
            }
        }
    }
}
