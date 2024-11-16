using Microsoft.EntityFrameworkCore;
using FilmRecommend.Entities;

namespace FilmRecommend.Entities
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string LeadingActor { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public double Rating { get; set; }

        public int MovieSubCategoryID { get; set; }
        public MovieSubCategory SubCategory { get; set; }

    }

    public class MovieCategory
    {
        public int MovieCategoryID { get; set; }
        public string CategoryName { get; set; }


        public ICollection<MovieSubCategory> SubCategories { get; set; }
    }

    public class MovieSubCategory
    {
        public int MovieSubCategoryID { get; set; }
        public string SubCategoryName { get; set; }

        public int MovieCategoryID { get; set; }
        public MovieCategory Category { get; set; }

        public ICollection<Movie> Movies { get; set; }

    }
}
