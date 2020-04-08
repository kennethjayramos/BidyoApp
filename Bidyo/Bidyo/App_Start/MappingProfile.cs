using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Bidyo.Dtos;
using Bidyo.Models;

namespace Bidyo.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //domain to dtos
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            //dtos to domain
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
            
        }
    }
}