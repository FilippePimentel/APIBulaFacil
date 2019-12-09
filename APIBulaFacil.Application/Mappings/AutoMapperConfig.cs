using AutoMapper;

namespace APIBulaFacil.Application.Mappings
{
    public class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(cfg
                =>
            {
                cfg.AddProfile<ViewModelToEntityMap>();
                cfg.AddProfile<EntityToViewModelMap>();
            });
        }
    }

}
