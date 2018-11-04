using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace VolunteerX.Models.Commands
{
    public class ProfileCommand : Command
    {
        public override string Name => "Особистий кабінет";

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
                        new[] { "Особиста інформація", "Історія подій" },
                        new[] { "Статус заявок" },
                        new[] { "Надати інформацію про себе" },
                        new[] { "Основне меню" }
                    };
            ReplyKeyboard.ResizeKeyboard = true;

            await bot_client.SendTextMessageAsync(chatId, "Особистий кабінет", replyMarkup: ReplyKeyboard, parseMode:
                Telegram.Bot.Types.Enums.ParseMode.Markdown);
        }
    }
}