using MSTeamsHistory.Models.Graph;
using MSTeamsHistory.Models.Graph.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTeamsHistory.Models.Db
{
    public class Chat
    {
        public Models.Graph.Chats.Chat ChatObj { get; set; }
        public List<Microsoft.Graph.Message> Messages { get; set; }
        public List<Member> Members { get; set; }
    }
}
