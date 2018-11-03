using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace VolunteerX.Models.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public abstract Task Execute(Telegram.Bot.Types.Message message, TelegramBotClient client);

        public abstract bool Contains(Telegram.Bot.Types.Message message);
    }
}
