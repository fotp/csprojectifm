namespace CSharpProject.Net
{
    public class Header
    {
        public enum MsgType
        {
            UNAVAILABLE,
            ACK_OK,
            ACK_ERROR,
            CONNECT,
            QUIT_SESSION,
            GET_TOPICS,
            LISTE_TOPICS,
            CREATE_TOPIC,
            JOIN_TOPIC,
            QUIT_TOPIC,
            POST_MSG,
            RECV_POST
        };

        MsgType _source;

        public MsgType source
        {
            get { return _source; }
            set { _source = value; }
        }

        public Header()
        {
            source = MsgType.UNAVAILABLE;
        }

        public Header(MsgType msgt)
        {
            source = msgt;
        }
    }
}