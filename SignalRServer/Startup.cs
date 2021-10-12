﻿using Microsoft.Owin;
using Owin;
using System.Collections.Generic;

[assembly: OwinStartupAttribute(typeof(SignalRServer.Startup))]
namespace SignalRServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}


