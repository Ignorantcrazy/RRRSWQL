﻿using GraphQL.Types;
using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL.WebAPI.Models
{
    public class FriendType : ObjectGraphType<Friend>
    {
        public FriendType()
        {
            Field(x => x.Id);
            Field(x => x.Name, nullable: true);
            Field(x => x.Sex, nullable: true);
        }
    }
}
