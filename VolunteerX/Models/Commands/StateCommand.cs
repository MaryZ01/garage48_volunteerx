using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace VolunteerX.Models.Commands
{
    public class StateCommand : Command
    {
        public override string Name => "Mary";

        public override bool Contains(Telegram.Bot.Types.Message message)
        {
            if (message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
                return false;

            return message.Text.Contains(this.Name);
        }

        public override async Task Execute(Telegram.Bot.Types.Message message, TelegramBotClient bot_client)
        {
            var chatId = message.Chat.Id;

            await bot_client.SendTextMessageAsync(chatId, "Please, input your state: ",
                parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);
        }
    }
}
