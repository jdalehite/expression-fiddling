using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;
namespace ExpressionFiddling
{
    public class InteractionContext
    {
        public int Charm { get; }
        public int Reputation { get; }
        public ImmutableList<string> Events { get; }

        public InteractionContext() 
        {
            Events = ImmutableList<string>.Empty;
        }
        public InteractionContext(int charm, int rep, List<string> events)
        {
            Charm = charm;
            Reputation = rep;
            Events = events.ToImmutableList();
        }
    }
}
