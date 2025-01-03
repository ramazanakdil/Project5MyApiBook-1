﻿using MyApiBook_1.BusinessLayer.Abstract;
using MyApiBook_1.DataAccessLayer.Abstract;
using MyApiBook_1.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiBook_1.BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        private readonly IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void TDelete(int id)
        {
            _writerDal.Delete(id);
        }

        public List<Writer> TGetAll()
        {
            return _writerDal.GetAll();
        }

        public Writer TGetById(int id)
        {
            return _writerDal.GetById(id);
        }

        public void TInsert(Writer entity)
        {
            _writerDal.Insert(entity);
        }

        public void TUpdate(Writer entity)
        {
            _writerDal.Update(entity);
        }
    }
}
