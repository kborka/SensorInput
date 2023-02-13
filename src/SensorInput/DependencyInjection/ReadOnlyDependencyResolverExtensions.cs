using Splat;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorInput.DependencyInjection;

public static class ReadOnlyDependencyResolverExtensions
{
    public static TService GetServiceSafe<TService>(this IReadonlyDependencyResolver resolver)
    {
        var service = resolver.GetService<TService>();
        if (service is null)
        {
            throw new InvalidOperationException($"Service {typeof(TService)} was not found or registered.");
        }
        return service;
    }
}
