using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace WorkflowService
{

    public sealed class CodeActivity1 : CodeActivity
    {
        // Define 2 activity input argument of type string
        public InArgument<int> lower { get; set; }
        public InArgument<int> upper { get; set; }
        //Define an output
        public OutArgument<int> sec { get; set; }
        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            //  string text = context.GetValue(this.Text);
            DateTime currentDate = DateTime.Now;
            int seed = (int)currentDate.Ticks;
            Random random = new Random(seed);
            int lo = context.GetValue(this.lower);
            int up = context.GetValue(this.upper);
            int sNumber = random.Next(lo, up);
            context.SetValue(this.sec, sNumber);
        }
    }
}
