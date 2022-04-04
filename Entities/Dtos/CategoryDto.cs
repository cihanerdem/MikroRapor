using Entities.Abstract;

namespace Entities.Dtos
{
    public class CategoryDto : IDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
