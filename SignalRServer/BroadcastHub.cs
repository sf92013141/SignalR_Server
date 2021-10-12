using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRServer
{

    public class BroadcastHub : Hub
    {
        public static List<string> OnlineList = new List<string>();
    
        public void Broadcast(string ConnectionId, string message)
        {
            Clients.All.showmessage(ConnectionId, message);
        }
        public void LoginSignalR(string ConnectionId)
        {
            OnlineList.Add(ConnectionId);
            Clients.All.RefreshMember(OnlineList);
        }
        public void LogOutSignalR(string ConnectionId)
        {
            OnlineList.Remove(ConnectionId);
            Clients.All.RefreshMember(OnlineList);
        }
        public void PrivateMessage(string ConnectionId,string MessageId,string Message)
        {
            Clients.Client(MessageId).showmessage(ConnectionId, Message);;
        }
    }


 



}