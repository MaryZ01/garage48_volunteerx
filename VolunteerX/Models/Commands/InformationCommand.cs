using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace VolunteerX.Models.Commands
{
    public class InformationCommand : Command
    {
        public override string Name => "Інформація про команду";

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
                        new[] { "Інформація про команду", "Інформація про подію" },
                        new[] { "Основне меню" }
                    };
            ReplyKeyboard.ResizeKeyboard = true;

            await botClient.SendTextMessageAsync(chatId, "Твоя команда - Реєстрація. Опис команди - Реєструють відвідувачів та учасників форуму", replyMarkup: ReplyKeyboard
        , parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);

            //throw new NotImplementedException();
            //TODO: USER MUST BE ABLE TO CASTOMISE INFO ABOUT HIS PROFILE
        }
    }
}
