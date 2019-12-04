using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public class Emailer
  {
    public void SendEmail(Person owner, string v)
    {
      Console.WriteLine($"Simulating sending an email to {owner.EmailAddress}");
    }
  }
}
