using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace VolunteerX.Models.Commands
{
    public class InformationAboutEvent : Command
    {
        public override string Name => "Інформація про подію";

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

            await botClient.SendTextMessageAsync(chatId, "Назва - Форум видавців. Опис - Ми здійснюємо культурні, освітні та соціальні проекти, спрямовані на заохочення читання та просування літератури, на розвиток книговидавництва та бібліотечного сектору, підвищення культурного та освітнього рівня дітей та молоді.  Ми приділяємо багато уваги просуванню читання поміж дітей та молоді: читання презентується як спосіб успішної соціальної адаптації, яка сприяє формуванню високорозвиненої особистості, здатної інтегруватися у світове співтовариство.", replyMarkup: ReplyKeyboard
        , parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);

            //throw new NotImplementedException();
            //TODO: USER MUST BE ABLE TO CASTOMISE INFO ABOUT HIS PROFILE
        }
    }
}
