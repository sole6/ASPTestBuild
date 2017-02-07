using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApiSignalR.Hubs
{
    public class MyHub : Hub
    {
        private static IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<MyHub>();

        public void Hello()
        {
            hubContext.Clients.All.hello();
        }
    }
}