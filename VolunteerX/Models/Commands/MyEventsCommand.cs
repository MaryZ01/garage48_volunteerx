using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace VolunteerX.Models.Commands
{
    public class MyEventsCommand : Command
    {
        public override string Name => "Мої події";

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
                        new[] { "Форум видавців" },
                        new[] { "Основне меню" }
                    };
            ReplyKeyboard.ResizeKeyboard = true;

            await bot_client.SendTextMessageAsync(chatId, "Мої події", replyMarkup: ReplyKeyboard, parseMode:
                Telegram.Bot.Types.Enums.ParseMode.Markdown);

            //var chatId = message.Chat.Id;

            //TODO: INFORMATION ABOUT EVENT

            //ReplyKeyboard.ResizeKeyboard = true;

            //await bot_client.SendTextMessageAsync(chatId, "Your event", replyMarkup: ReplyKeyboard, parseMode:
            //  Telegram.Bot.Types.Enums.ParseMode.Markdown);
        }
    }
}
