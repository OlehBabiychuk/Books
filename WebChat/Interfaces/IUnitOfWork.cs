using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChat.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<ApplicationUser> UsersRepo { get; }
        IBaseRepository<FriendRequest> RequestsRepo { get; }
        IBaseRepository<Friend> FriendsRepo { get; }
        int Save();
    }
}