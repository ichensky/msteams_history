using System.Collections.Generic;
using Microsoft.Graph;
using MSTeamsHistory.Models.Graph.Members;

namespace MSTeamsHistory.Models.Db
{
    public class Chat
    {
        public Graph.Chats.Chat ChatObj { get; set; }
        public List<Message> Messages { get; set; }
        public List<Member> Members { get; set; }
    }
}