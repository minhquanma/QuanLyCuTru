using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using QuanLyCuTru.Models;
using QuanLyCuTru.DTOs;

namespace QuanLyCuTru.App_Start
{
    public class MappingConfig
    {
        public static void RegisterMapping()
        {
            /* Mapper for CuTru entity
             * CongDans from destination entity (DTO) 
             * are selected by CongDans.Id from source entity
            */
            Mapper.Initialize(config =>
            {
                config.CreateMap<CuTru, CuTruDTO>()
                    .ForMember(
                        dest => dest.CongDans,
                        option => option.MapFrom(f => f.CongDans.Select(c => c.Id))
                     );

                config.CreateMap<CuTruDTO, CuTru>()
                    .ForMember(dest => dest.Id, option => option.Ignore())
                    .ForMember(
                        dest => dest.CongDans,
                        option => option.Ignore()
                    );
            });
        }
    }
}