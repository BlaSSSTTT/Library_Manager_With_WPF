using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LibraryUI.ViewModels;
using PortableLibrary;

namespace LibraryUI.Base
{
    public class Mapping
    {
        public Mapper RegisterMap()
        {
            return new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataModel, DataViewModel>();
                cfg.CreateMap<DataViewModel, DataModel>();

                cfg.CreateMap<Author, AuthorViewModel>();
                cfg.CreateMap<AuthorViewModel, Author>();

                cfg.CreateMap<Book, BookViewModel>();
                cfg.CreateMap<BookViewModel, Book>();

                cfg.CreateMap<Reader, ReaderViewModel>();
                cfg.CreateMap<ReaderViewModel, Reader>();
            }));
        }
        
    }
}
