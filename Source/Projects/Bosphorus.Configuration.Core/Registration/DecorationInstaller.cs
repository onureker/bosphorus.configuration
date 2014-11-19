﻿using Bosphorus.Configuration.Core.Decoration.Exception;
using Bosphorus.Configuration.Core.Decoration.Safe;
using Bosphorus.Container.Castle.Fluent;
using Bosphorus.Container.Castle.Registration;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Configuration.Core.Registration
{
    public class DecorationInstaller: AbstractWindsorInstaller, IDecoratorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Decorator
                    .For<IParameterProvider>()
                    .Is<SafeDecorator>()
                    .Is<ExceptionDecorator>()
            );
        }
    }
}
