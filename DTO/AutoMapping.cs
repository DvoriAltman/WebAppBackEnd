using AutoMapper;
using DAL.Entities;
using DTO.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserDTO>();
          //CreateMap<User, UserLoginDTO>();
            CreateMap<Order, OrderDTO>();
            CreateMap<Product, ProductDTO>();
            
            CreateMap<UserDTO, User>();
         // CreateMap<UserLoginDTO, User>();
            CreateMap<OrderDTO, Order>();
            CreateMap<ProductDTO, Product>();

        }



    }
}
