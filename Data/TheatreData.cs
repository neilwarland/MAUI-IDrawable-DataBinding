using myapp.Models;

namespace myapp.Data
{
    public static class TheatreData
    {
        public static IList<Theatre> Theatres { get; private set; }

        static TheatreData()
        {
            Theatres = new List<Theatre>();

            Theatres.Add(new Theatre
            {
                TheatreName = "Theatre 1"
            });

            Theatres.Add(new Theatre
            {
                TheatreName = "Theatre 2"
            });

            Theatres.Add(new Theatre
            {
                TheatreName = "Theatre 3"
            });
        }
    }
}
