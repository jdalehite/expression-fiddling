using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionFiddling
{
    public class ConversationHandler
    {
        private readonly ConversationConfig _config;
        public bool Done { get; private set; } = false;
        private string _currentId = "Start";
        private InteractionContext _context = new InteractionContext(3, 1, new List<string>());
        public ConversationHandler(ConversationConfig config)
        {
            _config = config;
            _config.Build();
        }
        public void Start()
        {
            Console.WriteLine("You walk into a party and see your friend Cindy");
            var cindysConversations = _config.ConversationsBySpeaker["Cindy"];
            var currentDialog = cindysConversations.DialogsByID[_currentId];
            Console.WriteLine(currentDialog.Statement);
            foreach(var resp in currentDialog.Responses)
            {
                if (resp.CanSay(_context))
                {
                    Console.WriteLine(resp.Preview);
                }
            }
     
        }
    }
}
