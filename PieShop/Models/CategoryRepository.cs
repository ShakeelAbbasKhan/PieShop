namespace PieShop.Models
{
    public class CategoryRepository : ICategoryRepository

    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> AllCategories => 
            _context.Categories.OrderBy(p=>p.CategoryName);
    }
}
