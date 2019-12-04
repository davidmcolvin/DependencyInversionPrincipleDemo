using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public class Emailer : IMessageSender
  {
    public void SendMessage(IPerson owner, string v)
    {
      Console.WriteLine($"Simulating sending an email to {owner.EmailAddress}");
    }
  }
}
