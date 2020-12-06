using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Sockets;
using Microsoft.AspNetCore.SignalR;

namespace Secheli_Stefania_Lab2.Hubs
{
    public class ChatHub : Hub
    {

        public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", Context.User.Identity.Name, message);
    }

    }

}
