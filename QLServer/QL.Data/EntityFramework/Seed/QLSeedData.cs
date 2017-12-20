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
                var droid = new Droid
                {
                    Name = "R2-D2"
                };
                db.Droids.Add(droid);
                db.SaveChanges();
            }
        }
    }
}
