using System.Web.Mvc;
using FluentValidation.Mvc;
using Ninject;
using Ninject.Web.Mvc5.FluentValidation;
using WebActivatorEx;

using Grocery_Shop_Management;

[assembly: PreApplicationStartMethod(typeof(NinjectValidatorFactoryInitializer), nameof(NinjectValidatorFactoryInitializer.PreStart))]
namespace Grocery_Shop_Management
{
    public static class NinjectValidatorFactoryInitializer
    {
        public static void PreStart()
        {
            var ninjectValidatorFactory = new NinjectValidatorFactory(DependencyResolver.Current.GetService<IKernel>());
            ModelValidatorProviders.Providers.Add(new FluentValidationModelValidatorProvider(ninjectValidatorFactory));
            DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;
        }
    }
}
