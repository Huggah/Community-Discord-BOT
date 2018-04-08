﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityBot.Entities
{
    public interface IGlobalAccount
    {
        ulong Id { get; set; }
        Dictionary<string, string> Tags { get; set; }
    }
}
