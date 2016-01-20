using AutoMapper;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBest.Models.Entities;

namespace TheBest.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            CreateMap<Student, StudentViewModel>();
            //CreateMap<Evaluator, EvaluatorViewModel>();
        }

        public static void CreateMap<TSource, TDestination>()
        {
            Mapper.CreateMap<TSource, TDestination>().ReverseMap();
        }
    }
}