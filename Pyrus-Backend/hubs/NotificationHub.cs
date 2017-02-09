using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Pyrus_Backend.hubs
{
    [HubName("Notification")] // exposed as notification to client
    public class NotificationHub : Hub
    {
        private static IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
        private void send(string message)
        {
            Clients.All.broadcastMessage(message);
        }

        public void getDeviceStatusList()
        {
            string message = @"
                [{'deviceId': '1', 'deviceName': 'aa', 'deviceStatus': 'Audio'},
                {'deviceId': '2', 'deviceName': 'bb', 'deviceStatus': 'Audio1'},
                {'deviceId': '3', 'deviceName': 'cc', 'deviceStatus': 'Audio3'},
                {'deviceId': '4', 'deviceName': 'dd', 'deviceStatus': 'Audio4'},
                {'deviceId': '5', 'deviceName': 'ee', 'deviceStatus': 'Audio5'},
                {'deviceId': '6', 'deviceName': 'ff', 'deviceStatus': 'Audio6'},]
                ";
            this.send(message);
        }
    }
}