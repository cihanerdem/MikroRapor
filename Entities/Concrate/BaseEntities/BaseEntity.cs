﻿using Entities.Abstract;
using System;

namespace Entities.Concrate.BaseEntities
{
    public class BaseEntity : IEntity
    {
        public int Id { get ; set ; }
        public DateTime? CreateDate { get ; set ; }
        public int CreateUser { get ; set ; }
        public DateTime? UpdateDate { get ; set ; }
        public int UpdateUser { get ; set ; }
    }
}
