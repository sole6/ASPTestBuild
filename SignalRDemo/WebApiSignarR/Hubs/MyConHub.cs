using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApiSignarR.Hubs
{
    public class MyConHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}