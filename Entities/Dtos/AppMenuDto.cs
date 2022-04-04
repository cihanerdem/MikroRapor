using Entities.Abstract;

namespace Entities.Dtos
{
    public class AppMenuDto : IDto
    {
        public int Id { get; set; }
        public int MenuNo { get; set; }
        public string StaffIdToAccess { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
        public int AssociatedMenuId { get; set; }
        public int CategoryId { get; set; }
        public string Url { get; set; }
    }
}
