using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.Chat
{
    public interface ChatRoom
    {
        string post(string msg, Chatter c);
        string quit(Chatter c);
        string join(Chatter c);
        string getTopic();
    }
}
