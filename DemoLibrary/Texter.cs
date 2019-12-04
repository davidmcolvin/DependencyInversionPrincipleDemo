using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public class Texter : IMessageSender
  {
    public void SendMessage(IPerson owner, string message)
    {
      Console.WriteLine($"I am texting {owner.FirstName} to say {message}");
    }
  }
}
