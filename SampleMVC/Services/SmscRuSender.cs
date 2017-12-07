using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SampleMVC.Services
{
    public class SmscRuSender : ISmsSender
    {
        public async Task SendSmsAsync(string phoneNumber, string message)
        {
            using(var client = new HttpClient())
            {
                await client.GetAsync(
                    $"https://smsc.ru/sys/send.php" +
                    $"?login=qlineb" +
                    $"&psw=9ff233721fcdef34ad40451625ff1504" +
                    $"&phones={phoneNumber}" +
                    $"&mes={message}"
                    );
            }
        }
    }
}
