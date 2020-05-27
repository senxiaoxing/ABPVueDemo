using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPVue.Authorization;

namespace ABPVue
{
    [DependsOn(
        typeof(ABPVueCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPVueApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPVueAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPVueApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
