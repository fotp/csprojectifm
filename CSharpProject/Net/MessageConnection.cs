

namespace CSharpProject.Net
{
    interface MessageConnection
    {
        Message getMessage();
        void sendMessage(Message msg);
    }
}
