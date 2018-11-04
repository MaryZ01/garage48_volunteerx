using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using VolunteerX.Models;
using VolunteerX.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VolunteerX.Controllers
{
    [Route("api/message/update")]
    public class MessageController : Controller
    {
        private readonly IGenericRepository<Volunteer> _volunteersRepository;

        public MessageController(IGenericRepository<Volunteer> volunteersRepository)
        {
            _volunteersRepository = volunteersRepository;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "Method GET unuvalable";
        }

        // POST api/values
        [HttpPost]
        public async Task<OkResult> Post([FromBody]Update update)
        {
            if (update == null) return Ok();

            var commands = Bot.Commands;
            var message = update.Message;
            var botClient = await Bot.GetBotClientAsync();
            var list = Bot.idsList;
            var chatId = message.Chat.Id;

            //if (_volunteersRepository.Get(x => x.ChatId == chatId).Count() == 0)
            //{
            //    Volunteer user = new Volunteer
            //    {
            //        ChatId = chatId
            //    };

            //    Bot.idsList[chatId] = new Specifications
            //    {
            //        IsName = true
            //    };

            //    _volunteersRepository.Create(user);
            //}
            //else
            //{
            //    if (list[chatId].IsName)
            //    {
            //        Volunteer user = _volunteersRepository.Get(x => x.ChatId == chatId).FirstOrDefault();

            //        user.Name = message.Text;

            //        _volunteersRepository.Update(user);

            //        list[chatId].IsName = false;

            //        ReplyKeyboardMarkup ReplyKeyboard = new[]
            //                           {
            //            new[] { "Мій рейтинг" },
            //            new[] { "Пошук події", "Мої події" },
            //            new[] { "Особистий кабінет" }
            //        };
            //        ReplyKeyboard.ResizeKeyboard = true;

            //        await botClient.SendTextMessageAsync(chatId, "Мені потрібно знати також твій номер телефону", replyMarkup: ReplyKeyboard
            //    , parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);


            //        list[chatId].IsPhone = true;
            //    }

            //    if (list[chatId].IsPhone)
            //    {
            //        Volunteer user = _volunteersRepository.Get(x => x.ChatId == chatId).FirstOrDefault();

            //        user.PhoneNumber = message.Text;

            //        _volunteersRepository.Update(user);

            //        list[chatId].IsPhone = false;

            //        list.Remove(chatId);

            //        await botClient.SendTextMessageAsync(chatId, "Дякую, тепер ти можеш користуватися моєю допомогу у пошуку волонтерських програм"
            //    , parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);
            //    }
            //}
            

            foreach (var command in commands)
            {
                if (command.Contains(message))
                {
                    await command.Execute(message, botClient);
                    break;
                }
            }
            return Ok();
        }
    }
}
