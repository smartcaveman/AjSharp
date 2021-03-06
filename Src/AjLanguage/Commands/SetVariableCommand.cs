﻿namespace AjLanguage.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AjLanguage.Expressions;

    [Serializable]
    public class SetVariableCommand : ICommand
    {
        private string name;
        private IExpression expression;

        public SetVariableCommand(string name, IExpression expression)
        {
            this.name = name;
            this.expression = expression;
        }

        public string VariableName { get { return this.name; } }

        public IExpression Expression { get { return this.expression; } }

        public void Execute(IBindingEnvironment environment)
        {
            environment.SetValue(this.name, this.expression.Evaluate(environment));
        }
    }
}
