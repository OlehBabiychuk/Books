using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChat.Interfaces
{
    public interface IChatRepository
    {
        void Add(string name, string message);
    }
}