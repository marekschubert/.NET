using AutoMapper;

namespace ConsoleApp2
{
    public class UserMapper
    {
        private IMapper _mapper;

        public UserMapper()
        {
            _mapper = new MapperConfiguration(config => 
            {
                config.CreateMap<UserEntity, UserDto>()
                     .ForMember(x => x.IsAboveEighteen, y => y.MapFrom(z => z.Age > 18))
                     .ReverseMap();

                config.CreateMap<UserDto, UserViewModel>()
                .ReverseMap();

            }
                    ).CreateMapper();


        }

        public UserDto Map(UserEntity entity)
            => _mapper.Map<UserDto>(entity);
        public UserEntity ReverseMapMap(UserDto dto)
            => _mapper.Map<UserEntity>(dto);
        public UserViewModel Map(UserDto dto)
            => _mapper.Map<UserViewModel>(dto);
        public UserDto ReverseMap(UserViewModel viewModel)
            => _mapper.Map<UserDto>(viewModel);

    }
}
