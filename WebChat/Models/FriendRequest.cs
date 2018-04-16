﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChat.Models
{
    public class FriendRequest
    {
        public int Id { get; set; }
        public string FromId { get; set; }
        public string ToId { get; set; }

        public virtual ApplicationUser To { get; set; }
    }
}