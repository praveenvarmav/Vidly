namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieEditOptions : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Hangover', 5, 12-10-2009, 12-10-2006, 30)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Die Hard', 1, 12-10-1998, 12-10-2009, 32)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Terminator', 1, 12-09-2001, 12-10-2006, 30)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Toy Story', 3, 12-10-2008, 11-10-2009, 30)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Titanic', 4, 12-10-1998, 12-10-2006, 30)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Zootopia', 3, 12-10-2015, 02-10-2016, 30)");
        }
        
        public override void Down()
        {
        }
    }
}
