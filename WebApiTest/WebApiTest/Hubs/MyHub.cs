﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApiTest.Hubs
{
    public class MyHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}