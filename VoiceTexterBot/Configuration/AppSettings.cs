using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceTexterBot.Configuration
{
    public class AppSettings
    {
        //токен для телеграмм API
        public string BotToken { get; set; }
        
        //Папка загрузки аудио файлов
        public string DownloadsFolder { get; set; }

        //Имя файла при згрузке
        public string AudioFileName { get; set; }

        //Формат аудио при загрузке
        public string InputAudioFormat { get; set; }

        //Формат аудио при загрузке
        public string OutputAudioFormat { get; set; }

        //Битгрейд аудио при загрузке
        public float InputAudioBitrate { get; set; }
    }
}
