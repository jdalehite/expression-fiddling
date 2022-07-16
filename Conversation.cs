using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionFiddling
{
    public class Conversation
    {
        public Dictionary<string, Dialog> DialogsByID { get; set; } = new Dictionary<string, Dialog>();
        public void Build()
        {
            foreach(var dialog in DialogsByID.Values)
            {
                dialog.Build();
            }
        }
    }
}
