using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using WebChat.Hubs;
using WebChat.Models;

[assembly: OwinStartup(typeof(WebChat.Startup))]

namespace WebChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.DependencyResolver.Register(
                typeof(ChatHub),
                () => new ChatHub(new UnitOfWork(new ApplicationDbContext())));
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
