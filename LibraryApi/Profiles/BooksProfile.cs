﻿using LibraryApi.Domain;
using LibraryApi.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Profiles
{
    public class BooksProfile : Profile
    {
        public BooksProfile()
        {
            //Book-- > GetBooksResponseItem
            CreateMap<Book, GetBooksResponseItem>();
        }
    }
}
