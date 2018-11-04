using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace VolunteerX.Models.Commands
{
    public class MyTasksCommand : Command
    {
        public override string Name => "Мої завдання";

        public override bool Contains(Telegram.Bot.Types.Message message)
        {
            if (message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
                return false;

            return message.Text.Contains(this.Name);
        }

        public override async Task Execute(Telegram.Bot.Types.Message message, TelegramBotClient bot_client)
        {
            //TODO: REALISE EVENTS HISTORY
            var chatId = message.Chat.Id;

            ReplyKeyboardMarkup ReplyKeyboard = new[]
                                                   {
                        new[] { "Мої завдання" },
                        new[] { "Контакти", "Залишити відгук" },
                        new[] { "Інформація про команду", "Інформація про подію" },
                        new[] { "Основне меню" }
                    };
            ReplyKeyboard.ResizeKeyboard = true;

            await bot_client.SendTextMessageAsync(chatId, "Твої завдання (не актуальні): 1. порахувати кількість бейджів", replyMarkup: ReplyKeyboard, parseMode:
                Telegram.Bot.Types.Enums.ParseMode.Markdown);
        }
    }
}
