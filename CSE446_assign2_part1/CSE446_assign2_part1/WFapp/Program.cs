using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace WorkflowConsoleApplication1
{

    class Program
    {
        public WorkflowConsoleApplication1.Mysec.SecretRequest SecretRequest
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public WorkflowConsoleApplication1.Mycheck.checkNumberRequest checkNumberRequest
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        static void Main(string[] args)
        {
            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1);
        }
    }
}
