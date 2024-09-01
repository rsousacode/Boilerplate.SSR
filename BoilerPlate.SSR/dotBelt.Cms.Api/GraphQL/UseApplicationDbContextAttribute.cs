using System.Reflection;
using BoilerPlate.Shared;
using HotChocolate.Types.Descriptors;

namespace BoilerPlateSSR.QueriesMutations;

public class UseApplicationDbContextAttribute : ObjectFieldDescriptorAttribute
{
    protected override void OnConfigure(IDescriptorContext context, IObjectFieldDescriptor descriptor, MemberInfo member)
    {
        descriptor.UseDbContext<ApplicationDbContext>();
    }
}