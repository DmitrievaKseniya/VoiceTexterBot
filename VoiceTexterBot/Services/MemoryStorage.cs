using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoiceTexterBot.Models;

namespace VoiceTexterBot.Services
{
    internal class MemoryStorage : IStorage
    {
        //Хранилище сессий
        private readonly ConcurrentDictionary<long, Session> _session;
        public MemoryStorage()
        {
            _session = new ConcurrentDictionary<long, Session>();
        }
        public Session GetSession(long chatId) 
        {
            //возвращаем сессию по ключу если она существует
            if (_session.ContainsKey(chatId))
                return _session[chatId];

            //Создаем и возвращаем новую, если такой нет
            var newSession = new Session() { LanguageCode = "ru" };
            _session.TryAdd(chatId, newSession);
            return newSession;
        }
    }
}
