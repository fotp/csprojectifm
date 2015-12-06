using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.Chat
{
    public interface Chatter
    {
        string Alias { get; set; }

        string receiveAMessage(string msg, Chatter c);
        //string getAlias();
    }
}
