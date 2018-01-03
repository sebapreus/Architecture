using AutoMapper;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Notes;

namespace Mappings
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(
                    cfg =>
                    {
                        cfg.CreateMap<Note, NoteViewModel>();
                        cfg.CreateMap<NoteViewModel, Note>();

                    }
                );
        }
    }
}
