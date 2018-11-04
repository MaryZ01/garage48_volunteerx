using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace VolunteerX.Models.Commands
{
    public class TestEventCommand : Command
    {
        public override string Name => "Форум видавців";

        public override bool Contains(Telegram.Bot.Types.Message message)
        {
            if (message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
                return false;

            return message.Text.Contains(this.Name);
        }

        public override async Task Execute(Telegram.Bot.Types.Message message, TelegramBotClient botClient)
        {
            var chatId = message.Chat.Id;

            ReplyKeyboardMarkup ReplyKeyboard = new[]
                                       {
                        new[] { "Мої завдання" },
                        new[] { "Контакти", "Залишити відгук" },
                        new[] { "Інформація" },
                        new[] { "Основне меню" }
                    };
            ReplyKeyboard.ResizeKeyboard = true;

            await botClient.SendTextMessageAsync(chatId, "Форум видавців", replyMarkup: ReplyKeyboard
        , parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);

            //throw new NotImplementedException();
            //TODO: USER MUST BE ABLE TO CASTOMISE INFO ABOUT HIS PROFILE
        }
    }
}
