using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace VolunteerX.Models.Commands
{
    public class MyRaitingCommand : Command
    {
        public override string Name => @"Мій рейтинг";

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
                        new[] { "Мій рейтинг" },
                        new[] { "Пошук події", "Мої події" },
                        new[] { "Особистий кабінет" }
                    };
            ReplyKeyboard.ResizeKeyboard = true;

            await bot_client.SendTextMessageAsync(chatId, "Твій рейнтинг становить 0 балів, допомогай більше і рейтинг буде рости на очах", replyMarkup: ReplyKeyboard, parseMode:
                Telegram.Bot.Types.Enums.ParseMode.Markdown);
        }
    }
}
