﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject.Chat
{
    public interface TopicsManager
    {
        string listTopics();
        ChatRoom joinTopic(string topic);
        void createTopic(string topic);
    }
}
