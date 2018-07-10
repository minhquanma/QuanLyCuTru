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
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CuTru, CuTruDTO>();
                config.CreateMap<CuTruDTO, CuTru>();
            });

            mapperConfig.CreateMapper();
        }
        
    }
}