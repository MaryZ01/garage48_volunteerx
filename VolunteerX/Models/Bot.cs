using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using VolunteerX.Models.Commands;

namespace VolunteerX.Models
{
    public class Bot
    {
        private static TelegramBotClient botClient;
        private static List<Command> commandsList;
        public static Dictionary<long, Specifications> idsList;

        public static IReadOnlyList<Command> Commands => commandsList.AsReadOnly();

        public static async Task<TelegramBotClient> GetBotClientAsync()
        {
            if (botClient != null)
            {
                return botClient;
            }

            idsList = new Dictionary<long, Specifications>();

            commandsList = new List<Command>();
            commandsList.Add(new StartCommand());
            commandsList.Add(new MyRaitingCommand());
            commandsList.Add(new HistoryOfEvents());
            commandsList.Add(new InformationCommand());
            commandsList.Add(new MainMenuCommand());
            commandsList.Add(new MyEventsCommand());
            commandsList.Add(new MyselfInformation());
            commandsList.Add(new MyTasksCommand());
            commandsList.Add(new ProfileCommand());
            commandsList.Add(new SearchingEventCommand());
            commandsList.Add(new TestEventCommand());
            //TODO: Add more commands

            botClient = new TelegramBotClient(AppSettings.Key);
            string hook = string.Format(AppSettings.Url, "api/message/update");
            await botClient.SetWebhookAsync(hook);
            return botClient;
        }
    }
}
