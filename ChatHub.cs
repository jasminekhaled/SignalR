﻿using Microsoft.AspNetCore.SignalR;

namespace SignalR
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceivedMessage", user, message);
        }
    }
}
