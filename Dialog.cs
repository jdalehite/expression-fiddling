using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionFiddling
{
    public class Dialog
    {
        public string Statement { get; set; } = string.Empty;
        public List<Response> Responses { get; set; } = new List<Response>();
        public void Build()
        {
            foreach(var response in Responses)
            {
                response.Build();
            }
        }
    }
}
