using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace VolunteerX.Models.Commands
{
    public class StartCommand : Command
    {
        public override string Name => @"/start";

        public override bool Contains(Telegram.Bot.Types.Message message)
        {
            if (message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
                return false;

            return message.Text.Contains(this.Name);
        }

        public override async Task Execute(Telegram.Bot.Types.Message message, TelegramBotClient botClient)
        {
            var chatId = message.Chat.Id;

            await botClient.SendTextMessageAsync(chatId, "Привіт, я VolunteerX чат-бот. Як я можу до тебе звертатися?"
                , parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);
        }
    }
}
