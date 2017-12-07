using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleMVC.Services;

namespace SampleMVC.Extensions
{
    public static class SmsSenderExtensions
    {
        public static async Task SendVerificationCode(
            this ISmsSender smsSender, string phoneNumber, string code
            )
        {
            await smsSender.SendSmsAsync(phoneNumber,
                $"Confirmation code: {code}"
                );
        }
    }
}
