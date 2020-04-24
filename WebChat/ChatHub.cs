using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChat
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string userName)
        {
            await this.Clients.All.SendAsync("Send", message, userName);

        }

        public async Task editText(string message, string id, string userName)
        {
            await this.Clients.All.SendAsync("editText", message, id, userName);
        }

        public async Task sendNewName(string oldName, string newName)
        {
            await this.Clients.All.SendAsync("sendNewName", oldName, newName);
        }

        public async Task deleteMessage(string mainId)
        {
            await this.Clients.All.SendAsync("deleteMessage", mainId);
        }

    }
    
}
