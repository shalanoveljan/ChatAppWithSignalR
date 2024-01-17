using chat_task.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chat_task.Hubs
{
    public class ChatHub:Hub
    {
        private readonly UserManager<AppUser> _userManager;

        public ChatHub(UserManager<AppUser> userManager)
        {
           _userManager = userManager;
        }
        public async Task SendMessage( string message, string reciveuserid)
        {
            AppUser user = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;

            if (string.IsNullOrWhiteSpace(reciveuserid))
            {
                // Her iki durumda da aynı mesaj gönderiliyor
                await Clients.All.SendAsync("ReciveMessage", user.FullName, message);
            }
            else
            {
                AppUser ReciveUser = _userManager.FindByIdAsync(reciveuserid).Result;

                // Her iki durumda da aynı mesaj gönderiliyor
                await Clients.Client(ReciveUser.CpnnectionId).SendAsync("ReciveMessage", user.FullName, message);
            }

            


        }

        public override Task OnConnectedAsync()
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser User = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;

                User.CpnnectionId = Context.ConnectionId;

                var result = _userManager.UpdateAsync(User).Result;
                Clients.All.SendAsync("UserConnected",User.Id);
            }
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser User = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;

                User.CpnnectionId = null;

                var result = _userManager.UpdateAsync(User).Result;
                Clients.All.SendAsync("UserDisConnected", User.Id);
            }
            return base.OnDisconnectedAsync(exception);
        }
    }


 
}
