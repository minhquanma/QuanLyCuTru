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
                config.CreateMap<NguoiDung, NguoiDungDTO>();
                config.CreateMap<NguoiDungDTO, NguoiDung>()
                    .ForMember(dest => dest.Id, option => option.Ignore());

                config.CreateMap<CuTru, CuTruDTO>()
                    .ForMember(
                        dest => dest.CongDans,
                        option => option.MapFrom(f => f.CongDans.Select(Mapper.Map<NguoiDung, NguoiDungDTO>))
                    )
                    .ForMember(
                        dest => dest.LoaiCuTru,
                        option => option.MapFrom(f => f.LoaiCuTru.Ten)
                    )
                    .ForMember(
                        dest => dest.CanBoDuyet,
                        option => option.MapFrom(f => f.CanBo.HoTen)
                    );
                config.CreateMap<CuTruDTO, CuTru>();

                //config.CreateMap<CuTru, CuTruDTO>()
                //    .ForMember(
                //        dest => dest.CongDans,
                //        option => option.MapFrom(f => f.CongDans.Select(c => c.Id))
                //     );

                config.CreateMap<CuTruDTO, CuTru>()
                    .ForMember(dest => dest.Id, option => option.Ignore())
                    .ForMember(
                        dest => dest.CongDans,
                        option => option.Ignore()
                    )
                    .ForMember(
                        dest => dest.LoaiCuTru,
                        option => option.Ignore()
                    );
            });
        }
    }
}