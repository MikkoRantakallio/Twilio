using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace TwilioSend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Token at twilio.com/console
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Kukkuluuruu! Viestiä Twiliolta :-)",
                from: new Twilio.Types.PhoneNumber("+12063509867"),
                to: new Twilio.Types.PhoneNumber("+3580405833473")
            );

            Console.WriteLine(message.Sid);
            Console.ReadLine();
        }
    }
}
