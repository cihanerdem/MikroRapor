using Entities.Abstract;
using System;

namespace Entities.Dtos
{
    public class CategoryDetailDto:IDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int UpdateUser { get; set; }

    }
}
