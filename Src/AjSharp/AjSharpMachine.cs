﻿namespace AjSharp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AjLanguage;
    using AjLanguage.Language;
    using AjLanguage.Primitives;

    using AjSharp.Primitives;
    using AjSharp.Hosting;
    using AjLanguage.Transactions;

    public class AjSharpMachine : Machine
    {
        public AjSharpMachine()
            : this(true)
        {
        }

        public AjSharpMachine(bool iscurrent)
            : base(iscurrent)
        {
            this.Environment.SetValue("Machine", typeof(AjSharpMachine));

            // Natite Types
            this.Environment.SetValue("byte", typeof(System.Byte));
            this.Environment.SetValue("char", typeof(System.Char));
            this.Environment.SetValue("short", typeof(System.Int16));
            this.Environment.SetValue("int", typeof(System.Int32));
            this.Environment.SetValue("long", typeof(System.Int64));
            this.Environment.SetValue("float", typeof(System.Single));
            this.Environment.SetValue("double", typeof(System.Double));
            this.Environment.SetValue("decimal", typeof(System.Decimal));
            this.Environment.SetValue("bool", typeof(System.Boolean));
            this.Environment.SetValue("object", typeof(System.Object));

            // Alias to Dynamic Types
            this.Environment.SetValue("DynamicObject", typeof(DynamicObject));
            this.Environment.SetValue("DynamicClass", typeof(DynamicClass));

            // Alias to Native Types
            this.Environment.SetValue("List", typeof(ArrayList));
            this.Environment.SetValue("Dictionary", typeof(Hashtable));

            // Primitive Functions
            this.Environment.SetValue("Print", new PrintSubroutine());
            this.Environment.SetValue("PrintLine", new PrintLineSubroutine());
            this.Environment.SetValue("Include", new IncludeSubroutine());
            this.Environment.SetValue("Evaluate", new EvaluateFunction());
            this.Environment.SetValue("Execute", new ExecuteSubroutine());

            this.Environment.SetValue("Channel", typeof(Channel));
            this.Environment.SetValue("QueueChannel", typeof(QueueChannel));
            this.Environment.SetValue("Future", typeof(Future));
            this.Environment.SetValue("Reference", typeof(TransactionalReference));

            this.Environment.SetValue("Host", typeof(Hosting.Host));
            this.Environment.SetValue("RemotingHostServer", typeof(Hosting.RemotingHostServer));
            this.Environment.SetValue("RemotingHostClient", typeof(AjLanguage.Hosting.Remoting.RemotingHostClient));
            this.Environment.SetValue("WcfHostServer", typeof(Hosting.WcfHostServer));
            this.Environment.SetValue("WcfHostClient", typeof(AjLanguage.Hosting.Wcf.WcfHostClient));
        }
    }
}
