using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace VolunteerX.Models.Commands
{
    public class MainMenuCommand : Command
    {
        public override string Name => @"Query menu";

        public override bool Contains(Telegram.Bot.Types.Message message)
        {
            if (message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
                return false;

            return message.Text.Contains(this.Name);
        }

        public override async Task Execute(Telegram.Bot.Types.Message message, TelegramBotClient bot_client)
        {
            var chatId = message.Chat.Id;

            ReplyKeyboardMarkup ReplyKeyboard = new[]
                   {
                        new[] { "Chat" },
                        new[] { "search for events", "My event" },
                        new[] { "My events history" },
                        new[] { "Personal office" }
                    };
            ReplyKeyboard.ResizeKeyboard = true;

            await bot_client.SendTextMessageAsync(chatId, "Query menu", replyMarkup: ReplyKeyboard, parseMode:
                Telegram.Bot.Types.Enums.ParseMode.Markdown);
        }
    }
}
