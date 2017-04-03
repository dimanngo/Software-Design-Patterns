using System.Collections.Generic;
using BridgePattern.Abstraction;
using BridgePattern.ConcreteImplementations;
using BridgePattern.RefinedAbstraction;

namespace BridgePattern
{
    class Program
    {
        static void Main()
        {
            var listOfMessages = new List<Message>
                                     {
                                                   new Message
                                                       {
                                                           Body = "Hello World 1",
                                                           Importance = 1,
                                                           Title = "Hello World Title 1"
                                                       },
                                                   new UserEditedMessage(new EmailSender())
                                                       {
                                                           Body = "User Edited Message",
                                                           Importance = 3,
                                                           UserComments = "Comments",
                                                           Title = "User Edited Title"
                                                       }
                                               };
            foreach (var message in listOfMessages)
            {
                message.Send();
            }
        }
    }
}
