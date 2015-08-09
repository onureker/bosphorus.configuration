﻿using Bosphorus.Configuration.Default.InMemory;

namespace Bosphorus.Configuration.Core.Demo
{
    public class ProgramConfiguration: AbstractConfiguration<Kernel>
    {
        public ProgramConfiguration(IInMemoryParameterProvider parameterProvider) 
            : base(parameterProvider)
        {
        }

        public string Key1
        {
            get { return GetValue<string>("Key1"); }
        }

        public string Key2
        {
            get { return GetValue<string>("Key2"); }
        }
    }
}