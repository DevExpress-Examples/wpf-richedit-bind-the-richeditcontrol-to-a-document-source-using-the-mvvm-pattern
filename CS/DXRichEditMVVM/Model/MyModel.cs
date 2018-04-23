namespace DXRichEditMVVM.Model
{
    using System.Data.Entity;

    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyModel")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
