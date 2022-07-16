using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialize.Linq.Nodes;
using System.Linq.Expressions;
namespace ExpressionFiddling
{
    public class Response
    {
        public ExpressionNode? CanSayExpression { get; set; }
        private Func<InteractionContext,bool> _canSay { get;  set; } = x => true;
        public bool CanSay(InteractionContext context) => _canSay.Invoke(context);
        public string PlayerDialog { get; set; } = string.Empty;
        public string Preview { get; set; } = string.Empty;
        public string? Event { get; set; }
        public string NextId { get; set; } = string.Empty;
        public void Build()
        {
            if (CanSayExpression == null)
                return;
            _canSay = CanSayExpression.ToBooleanExpression<InteractionContext>().Compile();
        }
    }
}
