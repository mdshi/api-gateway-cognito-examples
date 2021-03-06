﻿using System.Collections.Generic;

namespace Api
{
    public interface IGenericRepository<T>
    {
        Community GetById(int id);
        List<Community> GetAll();
        void Create(Community entity);
        void Delete(int id);
        void Update(Community entity, int id);
    }
}