using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using WebAPIDemo.Models;

namespace WebAPIDemo.Hubs
{
    [HubName ("Hub")]
    public class MyHub : Hub
    {
        //what the client can tell the server to do
        //
        
        public void Announce(Contact contact)
        {
            Clients.All.announce(contact); // function of the clients
        }
    }
}