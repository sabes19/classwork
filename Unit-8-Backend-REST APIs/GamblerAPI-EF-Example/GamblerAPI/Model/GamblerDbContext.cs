using Microsoft.EntityFrameworkCore;

namespace GamblerAPI.Model
{
    /***************************************************************************
     * The DbContext class/object establishes info the EF features for the table 
     * 
     * You define a subclass of DbContext to add information about your table
     * 
     * Partial attribute is added to the subclass to indicate it is only a partial description
     * of what Entity Framework needs to work
     * 
     * Partial means your subclass will be essentially merging into EF
     * 
     * 
     * 
     * 
     * 
     * 
     ****************************************************************************/


    public partial class GamblerDbContext : DbContext
    {
        // Define constructror to take options passed when instatiated by application
        //        and pass those options to base (DbContext) class constructor
        public GamblerDbContext(DbContextOptions<GamblerDbContext> options)
            : base(options) { }

        // Define property to represent the collection of data in the data source
        // our datasource is called Gamblers
        public virtual DbSet<Gambler> Gamblers { get; set; }

        /* Define table and columns to be accessed using Entity Framework
         * ModelBuilder will create EF structures to represent the table 
         *  
         * ModelBuilder uses the "Builder Design Pattern" to create and initialize the object instead of constructors 
         *   
         * "Builder Design Pattern" allows you to initialize an object one step at a time instead of with constructors 
         *   
         * Suppose you had an object with 25 data members, but some are optional 
         * You could have a constructor that takes up all 25 membber values 
         * but then you would have to have others that took other combinations of less than 25 values 
         * ITs possible you would need 25 constructos or more 
         *   
         * its "Builder Design Pattern" makes it much easier to initialize objects with many data members 
         *  
         * To use the Builder Design Pattern
         * 
         *      Define a builder class for the object with one method to initialize on data members
         * 
         *      When all individual data members you want to initialize have been assigned values
         *      
         *      Call the "build()' method of the builder to instantiate the object and assign the values to object you been giving the building
         */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Create an EF entity to represent our gambler table with a gambler object
            modelBuilder.Entity<Gambler>(entity =>
            {
                entity.ToTable("gambler");      // tell it the table name
                   
                // tell it about each column in the table
                entity.Property(e => e.Id)      // = the gambler class member called 'Id' 
                    .HasColumnName("id")        // = relates to the table column called 'id' (lowercase)
                    .IsRequired()               // = cannot be null
                    .HasColumnType("smallint"); // = data type of the column


                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("gambler_name")
                    .HasColumnType("text");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("text")
                    .HasDefaultValue("unknown");

                entity.Property(e => e.BirthDate)
                      .IsRequired()
                      .HasColumnName("birth_date")
                      .HasColumnType("date");

                entity.Property(e => e.Salary)
                    .IsRequired()
                    .HasColumnName("monthly_salary")
                    .HasColumnType("decimal(9,2)");

                // Once we have told EF about all the columns, caller the "build" method of the Builder
                // to instantiate the class associate in EF with our gambler class
                OnModelCreatingPartial(modelBuilder);
            });  // End of modelBuilder.entity()
        }  // End of onModelCreating()

        // method called to instantiate the objects in EF
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        
    } // End of class
} // End of namespace
