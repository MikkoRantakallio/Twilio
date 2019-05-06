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
            const string accountSid = "AC5ac57f1381d7ea938e95bb515b00f87f";
            const string authToken = "16e3efab1c3ba477fe07e8b3bde07ff8";

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
