using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionFiddling
{
    public class ConversationConfig
    {
        public Dictionary<string, Conversation> ConversationsBySpeaker { get; set; } = new Dictionary<string, Conversation>();
        public void Build()
        {
            foreach(var convo in ConversationsBySpeaker.Values)
            {
                convo.Build();
            }
        }
    }
}
