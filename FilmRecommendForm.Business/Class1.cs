namespace FilmRecommend.Business
{
    using FilmRecommend.Data;
    using FilmRecommend.Entities;
    using System.Xml;

    public class DataOperations
    {
        FilmMoodDBContext context = new FilmMoodDBContext();

        // Filmleri ekleyen metot
        public void AddMoviesToDatabase()
        {


            // Akiyon kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme 
            MovieCategory movieCategoryAksiyon = new()
            {
                CategoryName = "Aksiyon",
                SubCategories = new List<MovieSubCategory>()
            {

                new MovieSubCategory()
                {
                    SubCategoryName = "Aksiyon",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Die Hard",
                            ReleaseYear=1988,
                            Director="John McTiernan",
                            LeadingActor="Bruce Wills",
                            Rating=8.2},

                        new Movie(){
                            MovieName="Mad Max: Fury Road",
                            ReleaseYear=2015,
                            Director="George Miller",
                            LeadingActor="Tom Hardy",
                            Rating=8.1},

                        new Movie(){
                            MovieName="John Wick",
                            ReleaseYear=2014,
                            Director="Chad Stahelski",
                            LeadingActor="Keanu Reeves",
                            Rating=7.4},

                        new Movie(){
                            MovieName="Judgment Day",
                            ReleaseYear=1991,
                            Director="James Cameron",
                            LeadingActor="Arnold Schwarzenegger"
                            , Rating=8.5},

                        new Movie(){
                            MovieName="The Dark Night",
                            ReleaseYear=2018,
                            Director="Christopher Nolan",
                            LeadingActor="Christian Bale",
                            Rating=9.0
                        }
                    }
                    },

                new MovieSubCategory()
                {
                    SubCategoryName = "Casusuluk",
                    Movies = new HashSet<Movie>()
                    {
                        new Movie(){MovieName="Skyfall", ReleaseYear=2012, Director="Sam Mendes", LeadingActor="Daniel Craig", Rating=7.8},
                        new Movie(){MovieName="Mission: Impossible - Fallout", ReleaseYear=2018, Director="Christopher McQuarrie", LeadingActor="Tom Cruise", Rating=7.7},
                        new Movie(){MovieName="Tinker Tailor Soldier Spy", ReleaseYear=2011, Director="Tomas Alfredson", LeadingActor="Gary Oldman", Rating=7.1},
                        new Movie(){MovieName="The Bourne Identity", ReleaseYear=2002, Director="Doug Liman", LeadingActor="Matt Damon", Rating=7.9},
                        new Movie(){MovieName="Bridge of Spies", ReleaseYear=2015, Director="Steven Spielberg", LeadingActor="Tom Hanks", Rating=7.6}
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Dövüş",
                    Movies = new HashSet<Movie>()
                    {
                        new Movie(){MovieName="Enter the Dragon", ReleaseYear=1973, Director="Robert Clouse", LeadingActor="Bruce Lee", Rating=7.6},
                        new Movie(){MovieName="The Raid:Redemption", ReleaseYear=2011, Director="Gareth Evans", LeadingActor="Iko Uwaise", Rating=7.6},
                        new Movie(){MovieName="Rocky", ReleaseYear=1976, Director="John G.Avildsen", LeadingActor="Sylvester Stallone", Rating=8.1},
                        new Movie(){MovieName="Ip Man", ReleaseYear=2008, Director="Wilson Yip", LeadingActor="Donnie Yen", Rating=8.0},
                        new Movie(){MovieName="Fight Clup", ReleaseYear=199, Director="David Fincher", LeadingActor="Tyler Durden", Rating=8.8}
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Felaket",
                    Movies = new HashSet<Movie>()
                    {
                        new Movie(){MovieName="Twister", ReleaseYear=1996, Director="Jan de Bont", LeadingActor="Helen Hunt", Rating=6.4},
                        new Movie(){MovieName="Armageddon", ReleaseYear=1998, Director="Micheal Bay", LeadingActor="Bruce Wills", Rating=6.7},
                        new Movie(){MovieName="The Day After Tomorrow", ReleaseYear=2004, Director="Roland Emmerich", LeadingActor="Dennis Quaid", Rating=6.5},
                        new Movie(){MovieName="San Andreas", ReleaseYear=2015, Director="Brad Peyton", LeadingActor="Dwayne Johnson", Rating=6.1},
                        new Movie(){MovieName="2012", ReleaseYear=2009, Director="Roland Emmerich", LeadingActor="John Cusack", Rating=5.8}
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Süper Kahraman",
                    Movies = new HashSet<Movie>()
                    {
                        new Movie(){MovieName="The Avengers", ReleaseYear=2012, Director="Joss Whedon", LeadingActor="Robert Downey Jr.", Rating=8.0},
                        new Movie(){MovieName="Spider-Man", ReleaseYear=2002, Director="Sam Raimi", LeadingActor="Tobet Maguire", Rating=7.4},
                        new Movie(){MovieName="Black Panther", ReleaseYear=2018, Director="Ryan Coogler", LeadingActor="Chadwick Boseman", Rating=7.3},
                        new Movie(){MovieName="Iron Man", ReleaseYear=2008, Director="Jon Favreau", LeadingActor="Robert Downey Jr.", Rating=7.9},
                        new Movie(){MovieName="Wonder Woman", ReleaseYear=2017, Director="Patty Jenkins", LeadingActor="Gal Gadot", Rating=7.4}
                    }
                }



                }

            };

            // Belgesel kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme 
            MovieCategory movieCategoryBelgesel = new()
            {
                CategoryName = "Belgesel",
                SubCategories = new List<MovieSubCategory>()
            {

                new MovieSubCategory()
                {
                    SubCategoryName = "Belgesel",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Planet Earth",
                            ReleaseYear=2006,
                            Director="Alastair Fothergill",
                            LeadingActor="David Attenborough",
                            Rating=9.4},

                        new Movie(){
                            MovieName="The Last Dance",
                            ReleaseYear=2020,
                            Director="Jason Hehir",
                            LeadingActor="Michael Jordan",
                            Rating=9.1},

                        new Movie(){
                            MovieName="Free Solo",
                            ReleaseYear=2018,
                            Director="Elizabeth Chai Vasarhelyi, Jimmy Chin",
                            LeadingActor="Alex Honnold",
                            Rating=8.1},

                        new Movie(){
                            MovieName="13th ",
                            ReleaseYear=2016,
                            Director="Ava DuVernay",
                            LeadingActor="Belgesel"
                            , Rating=8.2},

                        new Movie(){
                            MovieName="Won't You Be My Neighbor?",
                            ReleaseYear=2018,
                            Director="Morgan Neville",
                            LeadingActor="Fred Rogers",
                            Rating=8.4
                        }
                    }

                 },

                new MovieSubCategory()
                {
                    SubCategoryName = "Doğa",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="March of the Penguins",
                            ReleaseYear=2005,
                            Director="Luc Jacquet",
                            LeadingActor="Morgan Freeman",
                            Rating=7.5},

                        new Movie(){
                            MovieName="Rivers and Tides",
                            ReleaseYear=2001,
                            Director="Thomas Riedelsheimer",
                            LeadingActor="Andy Goldsworthy",
                            Rating=8.1},

                        new Movie(){
                            MovieName="The Blue Planet",
                            ReleaseYear=2001,
                            Director="Alastair Fothergill, Andy Byatt",
                            LeadingActor="David Attenborough",
                            Rating=9.0},

                        new Movie(){
                            MovieName="Chasing Ice",
                            ReleaseYear=2012,
                            Director="Jeff Orlowski",
                            LeadingActor=" James Balog"
                            , Rating=7.8},

                        new Movie(){
                            MovieName="Our Planet",
                            ReleaseYear=2019,
                            Director="Alastair Fothergill, Jonathan Hughes",
                            LeadingActor="David Attenborough",
                            Rating=9.3
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Gezi", //yarım
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="March of the Penguins",
                            ReleaseYear=2005,
                            Director="Luc Jacquet",
                            LeadingActor="Morgan Freeman",
                            Rating=7.5},

                        new Movie(){
                            MovieName="Rivers and Tides",
                            ReleaseYear=2001,
                            Director="Thomas Riedelsheimer",
                            LeadingActor="Andy Goldsworthy",
                            Rating=8.1},

                        new Movie(){
                            MovieName="The Blue Planet",
                            ReleaseYear=2001,
                            Director="Alastair Fothergill, Andy Byatt",
                            LeadingActor="David Attenborough",
                            Rating=9.0},

                        new Movie(){
                            MovieName="Chasing Ice",
                            ReleaseYear=2012,
                            Director="Jeff Orlowski",
                            LeadingActor=" James Balog"
                            , Rating=7.8},

                        new Movie(){
                            MovieName="Our Planet",
                            ReleaseYear=2019,
                            Director="Alastair Fothergill, Jonathan Hughes",
                            LeadingActor="David Attenborough",
                            Rating=9.3
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Yarı Belgesel",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="March of the Penguins",
                            ReleaseYear=2005,
                            Director="Luc Jacquet",
                            LeadingActor="Morgan Freeman",
                            Rating=7.5},

                        new Movie(){
                            MovieName="Rivers and Tides",
                            ReleaseYear=2001,
                            Director="Thomas Riedelsheimer",
                            LeadingActor="Andy Goldsworthy",
                            Rating=8.1},

                        new Movie(){
                            MovieName="The Blue Planet",
                            ReleaseYear=2001,
                            Director="Alastair Fothergill, Andy Byatt",
                            LeadingActor="David Attenborough",
                            Rating=9.0},

                        new Movie(){
                            MovieName="Chasing Ice",
                            ReleaseYear=2012,
                            Director="Jeff Orlowski",
                            LeadingActor=" James Balog"
                            , Rating=7.8},

                        new Movie(){
                            MovieName="Our Planet",
                            ReleaseYear=2019,
                            Director="Alastair Fothergill, Jonathan Hughes",
                            LeadingActor="David Attenborough",
                            Rating=9.3
                        }
                    }
                },


            }


            };  //doğa,gezi ve yarıbelgesel aynı filmler olmuş

            // BilimKurgu kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme 
            MovieCategory movieCategoryBilimkurgu = new()
            {
                CategoryName = "Bilimkurgu ",
                SubCategories = new List<MovieSubCategory>()
            {

                new MovieSubCategory()
                {
                    SubCategoryName = "Bilimkurgu",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Blade Runner 2049 ",
                            ReleaseYear=2017,
                            Director="Denis Villeneuve",
                            LeadingActor=" Ryan Gosling",
                            Rating=8.0},

                        new Movie(){
                            MovieName="The Matrix",
                            ReleaseYear=1999,
                            Director="Lana Wachowski",
                            LeadingActor="Keanu Reeves",
                            Rating=8.7},

                        new Movie(){
                            MovieName="Interstellar ",
                            ReleaseYear=2014,
                            Director="Christopher Nolan",
                            LeadingActor="Matthew McConaughey",
                            Rating=8.6},

                        new Movie(){
                            MovieName="Inception ",
                            ReleaseYear=2010,
                            Director="Christopher Nolan",
                            LeadingActor="Leonardo DiCaprio"
                            , Rating=8.8},

                        new Movie(){
                            MovieName="Minority Report",
                            ReleaseYear=2002,
                            Director="Steven Spielberg",
                            LeadingActor="Tom Cruise",
                            Rating=7.7
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Alternatif Tarih",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Man in the High Castle",
                            ReleaseYear=2015,
                            Director="Frank Spotnitz",
                            LeadingActor="Alexa Davalos",
                            Rating=8.0},

                        new Movie(){
                            MovieName="The Plot Against America",
                            ReleaseYear=2020,
                            Director="David Simon",
                            LeadingActor="Winona Ryder",
                            Rating=7.3},

                        new Movie(){
                            MovieName="V for Vendetta",
                            ReleaseYear=2005,
                            Director="James McTeigue",
                            LeadingActor="Hugo Weaving",
                            Rating=8.1},

                        new Movie(){
                            MovieName="The Butterfly Effect",
                            ReleaseYear=2004,
                            Director="Eric Bress",
                            LeadingActor="Ashton Kutcher"
                            , Rating=7.6},

                        new Movie(){
                            MovieName="Fatherland",
                            ReleaseYear=1994,
                            Director="Christopher Menaul",
                            LeadingActor="Rutger Hauer",
                            Rating=6.4}

                    }
                 },

                new MovieSubCategory()
                {
                    SubCategoryName = "Askerî Bilimkurgu",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Starship Troopers",
                            ReleaseYear=1997,
                            Director="Paul Verhoeven",
                            LeadingActor="Casper Van Dien",
                            Rating=7.3},

                        new Movie(){
                            MovieName="Edge of Tomorrow",
                            ReleaseYear=2014,
                            Director="Doug Liman",
                            LeadingActor="Tom Cruise",
                            Rating=7.9},

                        new Movie(){
                            MovieName="RoboCop",
                            ReleaseYear=1987,
                            Director="Paul Verhoeven",
                            LeadingActor="Peter Weller",
                            Rating=7.6},

                        new Movie(){
                            MovieName="Battle Los Angeles",
                            ReleaseYear=2011,
                            Director="Jonathan Liebesman",
                            LeadingActor="Aaron Eckhart"
                            , Rating=5.7},

                        new Movie(){
                            MovieName="Dredd ",
                            ReleaseYear=2012,
                            Director="Pete Travis",
                            LeadingActor="Karl Urban",
                            Rating=7.1}

                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Bilimkurgu-Macera",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Guardians of the Galaxy",
                            ReleaseYear=2014,
                            Director="James Gunn",
                            LeadingActor="Chris Pratt",
                            Rating=8.0},

                        new Movie(){
                            MovieName="Star Wars: Episode IV - A New Hope",
                            ReleaseYear=1977,
                            Director="George Lucas",
                            LeadingActor="Mark Hamill",
                            Rating=8.6},

                        new Movie(){
                            MovieName="The Fifth Element",
                            ReleaseYear=1997,
                            Director="Luc Besson",
                            LeadingActor=" Bruce Willis",
                            Rating=7.7},

                        new Movie(){
                            MovieName="Avatar",
                            ReleaseYear=2009,
                            Director="James Cameron",
                            LeadingActor="Sam Worthington"
                            , Rating=7.9},

                        new Movie(){
                            MovieName="Jurassic Park",
                            ReleaseYear=1993,
                            Director="Steven Spielberg",
                            LeadingActor="Sam Neill",
                            Rating=8.2}

                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Kıyamet Sonrası Bilimkurgu",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Mad Max: Fury Road",
                            ReleaseYear=2015,
                            Director="George Miller",
                            LeadingActor="Tom Hardy",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Children of Men",
                            ReleaseYear=2006,
                            Director="Alfonso Cuarón",
                            LeadingActor="Clive Owen",
                            Rating=7.9},

                        new Movie(){
                            MovieName="The Road",
                            ReleaseYear=2009,
                            Director="John Hillcoat",
                            LeadingActor="Viggo Mortensen",
                            Rating=7.2},

                        new Movie(){
                            MovieName="Snowpiercer",
                            ReleaseYear=2013,
                            Director="Bong Joon Ho",
                            LeadingActor="Chris Evans"
                            , Rating=7.1},

                        new Movie(){
                            MovieName="I Am Legend",
                            ReleaseYear=2007,
                            Director="Francis Lawrence",
                            LeadingActor="Will Smith",
                            Rating=7.2}

                    }
                },

                }

            };

            // Dram kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategoryDram = new()
            {
                CategoryName = "Dram",
                SubCategories = new List<MovieSubCategory>()
            {

                new MovieSubCategory()
                {
                    SubCategoryName = "Dramatik",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Shawshank Redemption",
                            ReleaseYear=1994,
                            Director="Frank Darabont",
                            LeadingActor="Tim Robbins, Morgan Freeman",
                            Rating=9.3},

                        new Movie(){
                            MovieName="Forrest Gump",
                            ReleaseYear=1994,
                            Director="Robert Zemeckis",
                            LeadingActor="Tom Hanks",
                            Rating=8.8},

                        new Movie(){
                            MovieName="The Green Mile",
                            ReleaseYear=1999,
                            Director="Frank Darabont",
                            LeadingActor="Tom Hanks, Michael Clarke Duncan",
                            Rating=8.6},

                        new Movie(){
                            MovieName="A Beautiful Mind",
                            ReleaseYear=2001,
                            Director="Ron Howard",
                            LeadingActor="Russell Crowe"
                            , Rating=8.2},

                        new Movie(){
                            MovieName="12 Years a Slave",
                            ReleaseYear=2013,
                            Director="Steve McQueen",
                            LeadingActor="Chiwetel Ejiofor",
                            Rating=8.1
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Melodram",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Far from the Madding Crowd",
                            ReleaseYear=2015,
                            Director="Thomas Vinterberg",
                            LeadingActor="Carey Mulligan",
                            Rating=7.1},

                        new Movie(){
                            MovieName="Atonement ",
                            ReleaseYear=2007,
                            Director="Joe Wright",
                            LeadingActor=" Keira Knightley",
                            Rating=7.8},

                        new Movie(){
                            MovieName="Revolutionary Road",
                            ReleaseYear=2008,
                            Director="Sam Mendes",
                            LeadingActor="Leonardo DiCaprio",
                            Rating=7.3},

                        new Movie(){
                            MovieName="Titanic ",
                            ReleaseYear=1997,
                            Director="James Cameron",
                            LeadingActor="Leonardo DiCaprio, Kate Winslet"
                            , Rating=7.9},

                        new Movie(){
                            MovieName="The Notebook",
                            ReleaseYear=2004,
                            Director="Nick Cassavetes",
                            LeadingActor=" Ryan Gosling",
                            Rating=7.8
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Politik Dram",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Trial of the Chicago 7",
                            ReleaseYear=2020,
                            Director="Aaron Sorkin",
                            LeadingActor="Eddie Redmayne",
                            Rating=7.8},

                        new Movie(){
                            MovieName="The Post",
                            ReleaseYear=2017,
                            Director="Steven Spielberg",
                            LeadingActor="Meryl Streep",
                            Rating=7.2},

                        new Movie(){
                            MovieName="Milk ",
                            ReleaseYear=2008,
                            Director="Gus Van Sant",
                            LeadingActor="Sean Penn",
                            Rating=7.5},

                        new Movie(){
                            MovieName="Lincoln ",
                            ReleaseYear=2012,
                            Director="Steven Spielberg",
                            LeadingActor="Daniel Day-Lewis"
                            , Rating=7.3},

                        new Movie(){
                            MovieName="The Ides of March",
                            ReleaseYear=2011,
                            Director="George Clooney",
                            LeadingActor="Ryan Gosling",
                            Rating=7.1
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Tarihi Dram",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Dunkirk ",
                            ReleaseYear=2017,
                            Director="Christopher Nolan",
                            LeadingActor=" Fionn Whitehead",
                            Rating=7.8},

                        new Movie(){
                            MovieName="The Last Emperor",
                            ReleaseYear=1987,
                            Director="Bernardo Bertolucci",
                            LeadingActor="John Lone",
                            Rating=7.7},

                        new Movie(){
                            MovieName="The King's Speech",
                            ReleaseYear=2010,
                            Director="Tom Hooper",
                            LeadingActor="Colin Firth",
                            Rating=8.0},

                        new Movie(){
                            MovieName="Gladiator ",
                            ReleaseYear=2000,
                            Director="Ridley Scott",
                            LeadingActor="Russell Crowe, Joaquin Phoenix"
                            , Rating=8.5},

                        new Movie(){
                            MovieName="Schindler's List",
                            ReleaseYear=1993,
                            Director="Steven Spielberg",
                            LeadingActor="Liam Neeson",
                            Rating=9.0
                        }
                    }
                },

                }
            };

            // Gerilim kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategoryGerilim = new()
            {
                CategoryName = "Gerilim",
                SubCategories = new List<MovieSubCategory>()
            {

                new MovieSubCategory()
                {
                    SubCategoryName = "Gerilim ",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Shutter Island",
                            ReleaseYear=2010,
                            Director="Martin Scorsese",
                            LeadingActor="Leonardo DiCaprio",
                            Rating=8.2},

                        new Movie(){
                            MovieName="Zodiac",
                            ReleaseYear=2007,
                            Director="David Fincher",
                            LeadingActor="Jake Gyllenhaal, Robert Downey Jr.",
                            Rating=7.7},

                        new Movie(){
                            MovieName="The Silence of the Lambs",
                            ReleaseYear=1991,
                            Director="Jonathan Demme",
                            LeadingActor="Jodie Foster",
                            Rating=8.6},

                        new Movie(){
                            MovieName="Gone Girl",
                            ReleaseYear=2014,
                            Director="David Fincher",
                            LeadingActor="Ben Affleck"
                            , Rating=8.1},

                        new Movie(){
                            MovieName="Se7en ",
                            ReleaseYear=1995,
                            Director="David Fincher",
                            LeadingActor="Brad Pitt, Morgan Freeman",
                            Rating=8.6
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Aksiyon-Gerilim",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Colombiana",
                            ReleaseYear=2011,
                            Director="Olivier Megaton",
                            LeadingActor="Zoe Saldana",
                            Rating=6.4},

                        new Movie(){
                            MovieName="Casino Royale",
                            ReleaseYear=2006,
                            Director="Martin Campbell",
                            LeadingActor="Daniel Craig",
                            Rating=8.0},

                        new Movie(){
                            MovieName="John Wick: Chapter 2",
                            ReleaseYear=2017,
                            Director="Chad Stahelski",
                            LeadingActor=" Keanu Reeves",
                            Rating=7.4},

                        new Movie(){
                            MovieName="The Dark Knight Rises",
                            ReleaseYear=2012,
                            Director="Christopher Nolan",
                            LeadingActor="Christian Bale, Tom Hardy"
                            , Rating=8.4},

                        new Movie(){
                            MovieName="Mad Max: Fury Road ",
                            ReleaseYear=2015,
                            Director="George Miller",
                            LeadingActor="Tom Hardy",
                            Rating=8.1
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Politik Gerilim",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Argo",
                            ReleaseYear=2012,
                            Director=" Ben Affleck",
                            LeadingActor="Ben Affleck",
                            Rating=7.7},

                        new Movie(){
                            MovieName="The Manchurian Candidate",
                            ReleaseYear=2004,
                            Director="Jonathan Demme",
                            LeadingActor="Denzel Washington",
                            Rating=6.6},

                        new Movie(){
                            MovieName="Clear and Present Danger",
                            ReleaseYear=1994,
                            Director="Phillip Noyce",
                            LeadingActor="Harrison Ford",
                            Rating=6.9},

                        new Movie(){
                            MovieName="Body of Lies",
                            ReleaseYear=2008,
                            Director="Ridley Scott",
                            LeadingActor=" Leonardo DiCaprio"
                            , Rating=7.0},

                        new Movie(){
                            MovieName="The Hunt for Red October",
                            ReleaseYear=1990,
                            Director="John McTiernan",
                            LeadingActor="Sean Connery",
                            Rating=7.5
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Psikolojik Gerilim",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Sixth Sense ",
                            ReleaseYear=1999,
                            Director="M. Night Shyamalan",
                            LeadingActor="Bruce Willis",
                            Rating=8.2},

                        new Movie(){
                            MovieName="Memento",
                            ReleaseYear=2000,
                            Director="Christopher Nolan",
                            LeadingActor="Guy Pearce",
                            Rating=8.4},

                        new Movie(){
                            MovieName="Gone Girl",
                            ReleaseYear=2014,
                            Director="David Fincher",
                            LeadingActor="Ben Affleck",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Fight Clup",
                            ReleaseYear=1999,
                            Director="David Fincher",
                            LeadingActor="Brad Pitt"
                            , Rating=8.8},

                        new Movie(){
                            MovieName="Black Swan",
                            ReleaseYear=2010,
                            Director="Darren Aronofsky",
                            LeadingActor="Natalie Portman",
                            Rating=8.0
                        }
                    }
                },

                }
            };

            // Komedi kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategoryKomedi = new()
            {
                CategoryName = "Komedi",
                SubCategories = new List<MovieSubCategory>()
            {

                new MovieSubCategory()
                {
                    SubCategoryName = "Absürt Komedi",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Big Lebowski",
                            ReleaseYear=1998,
                            Director="Joel Coen",
                            LeadingActor="Jeff Bridges",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Monty Python and the Holy Grail",
                            ReleaseYear=1975,
                            Director="Terry Gilliam",
                            LeadingActor="Graham Chapman",
                            Rating=8.2},

                        new Movie(){
                            MovieName="Airplane",
                            ReleaseYear=1980,
                            Director="Jim Abrahams",
                            LeadingActor="Robert Hays",
                            Rating=7.7},

                        new Movie(){
                            MovieName="Superbad ",
                            ReleaseYear=2007,
                            Director="Greg Mottola",
                            LeadingActor="Jonah Hill"
                            , Rating=7.6},

                        new Movie(){
                            MovieName="This Is Spinal Tap",
                            ReleaseYear=1984,
                            Director="Rob Reiner",
                            LeadingActor="Michael McKean",
                            Rating=7.9
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Aksiyon Komedisi ",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Rush Hour",
                            ReleaseYear=1998,
                            Director="Brett Ratner",
                            LeadingActor=" Jackie Chan",
                            Rating=7.0},

                        new Movie(){
                            MovieName="Bad Boys",
                            ReleaseYear=1995,
                            Director=" Michael Bay",
                            LeadingActor="Will Smith",
                            Rating=6.9},

                        new Movie(){
                            MovieName="21 Jump Street",
                            ReleaseYear=2012,
                            Director="Phil Lord",
                            LeadingActor="Jonah Hill",
                            Rating=7.2},

                        new Movie(){
                            MovieName="The Nice Guys ",
                            ReleaseYear=2016,
                            Director="Shane Black",
                            LeadingActor=" Russell Crowe, Ryan Gosling"
                            , Rating=7.4},

                        new Movie(){
                            MovieName="Hot Fuzz",
                            ReleaseYear=2007,
                            Director="Edgar Wright",
                            LeadingActor="Simon Pegg",
                            Rating=7.8
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Absürt Komedi",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Big Lebowski",
                            ReleaseYear=1998,
                            Director="Joel Coen",
                            LeadingActor="Jeff Bridges",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Monty Python and the Holy Grail",
                            ReleaseYear=1975,
                            Director="Terry Gilliam",
                            LeadingActor="Graham Chapman",
                            Rating=8.2},

                        new Movie(){
                            MovieName="Airplane",
                            ReleaseYear=1980,
                            Director="Jim Abrahams",
                            LeadingActor="Robert Hays",
                            Rating=7.7},

                        new Movie(){
                            MovieName="Superbad ",
                            ReleaseYear=2007,
                            Director="Greg Mottola",
                            LeadingActor="Jonah Hill"
                            , Rating=7.6},

                        new Movie(){
                            MovieName="This Is Spinal Tap",
                            ReleaseYear=1984,
                            Director="Rob Reiner",
                            LeadingActor="Michael McKean",
                            Rating=7.9
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Askerî Komedi",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Stripes ",
                            ReleaseYear=1981,
                            Director="Ivan Reitman",
                            LeadingActor="Bill Murray",
                            Rating=6.9},

                        new Movie(){
                            MovieName="Private Benjamin",
                            ReleaseYear=1980,
                            Director="Howard Zieff",
                            LeadingActor="Goldie Hawn",
                            Rating=6.2},

                        new Movie(){
                            MovieName="MAS*H",
                            ReleaseYear=1970,
                            Director="Robert Altman",
                            LeadingActor="Donald Sutherland",
                            Rating=7.4},

                        new Movie(){
                            MovieName="Tropic Thunder",
                            ReleaseYear=2008,
                            Director="Ben Stiller",
                            LeadingActor="Ben Stiller"
                            , Rating=7.0},

                        new Movie(){
                            MovieName="The Interview",
                            ReleaseYear=2014,
                            Director="Seth Rogen",
                            LeadingActor="James Franco",
                            Rating=7.8
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Bilimkurgu-Komedi",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Men in Black",
                            ReleaseYear=1997,
                            Director="Barry Sonenfeld",
                            LeadingActor="Will Smith",
                            Rating=7.3},

                        new Movie(){
                            MovieName="Ghostbusters",
                            ReleaseYear=1984,
                            Director="Ivan Reitman",
                            LeadingActor="Bill Murray",
                            Rating=7.8},

                        new Movie(){
                            MovieName="Paul",
                            ReleaseYear=2011,
                            Director="Greg Mottola",
                            LeadingActor="Simon Pegg",
                            Rating=7.0},

                        new Movie(){
                            MovieName="Spaceballs",
                            ReleaseYear=1987,
                            Director="Mel Brooks",
                            LeadingActor="Mel Brooks"
                            , Rating=7.1},

                        new Movie(){
                            MovieName="The Hitchhiker's Guide to the Glaxy",
                            ReleaseYear=2005,
                            Director="Garth Jennings",
                            LeadingActor="Martin Freeman",
                            Rating=6.7
                        }
                    }
                },




                }
            };

            // Korku kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategoryKorku = new()
            {
                CategoryName = "Korku",
                SubCategories = new List<MovieSubCategory>()
            {

                new MovieSubCategory()
                {
                    SubCategoryName = "Bilimkurgu Korku",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Alien",
                            ReleaseYear=1979,
                            Director="Ridley Scott",
                            LeadingActor="Sigourny Weaver",
                            Rating=8.5},

                        new Movie(){
                            MovieName="The Thing",
                            ReleaseYear=1982,
                            Director="John Carpenter",
                            LeadingActor="Kurt Russell",
                            Rating=8.2},

                        new Movie(){
                            MovieName="Event Horizon",
                            ReleaseYear=1997,
                            Director="Paul W.S Anderson",
                            LeadingActor="Lauerence Fishburne",
                            Rating=6.7},

                        new Movie(){
                            MovieName="The Terminator",
                            ReleaseYear=1984,
                            Director="James Cameron",
                            LeadingActor="Arnold Schwarzenegger"
                            , Rating=8.1},

                        new Movie(){
                            MovieName="The Fly",
                            ReleaseYear=1986,
                            Director="David Cronrnberg",
                            LeadingActor="Jeff Goldblum",
                            Rating=7.6
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Biyolojik Korku",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Ruins",
                            ReleaseYear=2008,
                            Director="Carter Smith",
                            LeadingActor="Jonathan Tucker",
                            Rating=5.9},

                        new Movie(){
                            MovieName="The Descent",
                            ReleaseYear=2005,
                            Director="Neil Marshall",
                            LeadingActor="Shauna Macdonald",
                            Rating=7.2},

                        new Movie(){
                            MovieName="The Happening",
                            ReleaseYear=2008,
                            Director="M. Night Shyamalan",
                            LeadingActor="Mark Wahlberg",
                            Rating=5.0},

                        new Movie(){
                            MovieName="Cabin Fever",
                            ReleaseYear=2002,
                            Director="Eli Roth",
                            LeadingActor="Jordan Ladd"
                            , Rating=5.7},

                        new Movie(){
                            MovieName="The Bay",
                            ReleaseYear=2012,
                            Director="Barry Levinson",
                            LeadingActor="Nansi Aluka",
                            Rating=5.7
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Büyücü",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Jon TurtelTaub",
                            ReleaseYear=2010,
                            Director="Jon Turteltaub",
                            LeadingActor="Nicolas Cage",
                            Rating=6.1},

                        new Movie(){
                            MovieName="The Craft",
                            ReleaseYear=1996,
                            Director="Andrew Fleming",
                            LeadingActor="Robin Tunney",
                            Rating=6.4},

                        new Movie(){
                            MovieName="The Wizard of Oz",
                            ReleaseYear=1939,
                            Director="Victor Fleming",
                            LeadingActor="Judy Garland",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Harry Poter and the Chamber of Secrets",
                            ReleaseYear=2002,
                            Director="Chris Columbus",
                            LeadingActor="Daniel Radcliffe"
                            , Rating=7.4},

                        new Movie(){
                            MovieName="Eragom",
                            ReleaseYear=2006,
                            Director="Stefen Fangmeier",
                            LeadingActor="Edward Speleers",
                            Rating=5.1
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Canavar",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Jaws",
                            ReleaseYear=1975,
                            Director="Steven Spielberg",
                            LeadingActor="Roy Scheider",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Godzilla",
                            ReleaseYear=1954,
                            Director="Ishirö Honda",
                            LeadingActor="Takashi Shimura",
                            Rating=7.5},

                        new Movie(){
                            MovieName="King Kong",
                            ReleaseYear=2005,
                            Director="Peter Jackson",
                            LeadingActor="Naomi Watts",
                            Rating=7.2},

                        new Movie(){
                            MovieName="Cloverfield",
                            ReleaseYear=2008,
                            Director="Matt Reeves",
                            LeadingActor="Lizzy Caplan"
                            , Rating=7.0},

                        new Movie(){
                            MovieName="The Host",
                            ReleaseYear=2006,
                            Director="Bong Joon-ho",
                            LeadingActor="Kang-ho Song",
                            Rating=7.1
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Cadı",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Hocus Pocus",
                            ReleaseYear=1993,
                            Director="Kenny Ortega",
                            LeadingActor="Bette Midler",
                            Rating=6.9},

                        new Movie(){
                            MovieName="The Witches",
                            ReleaseYear=1990,
                            Director="Nicolas Roeg",
                            LeadingActor="Anjelica Huston",
                            Rating=6.9},

                        new Movie(){
                            MovieName="The Witch",
                            ReleaseYear=2015,
                            Director="Robert Eggers",
                            LeadingActor="Anya Taylor-Joy",
                            Rating=6.9},

                        new Movie(){
                            MovieName="Suspiria",
                            ReleaseYear=1997,
                            Director="Dario Argento",
                            LeadingActor="Jessica Harper"
                            , Rating=7.4},

                        new Movie(){
                            MovieName="The Craft",
                            ReleaseYear=1996,
                            Director="Andrew Fleming",
                            LeadingActor="Robin Tunney",
                            Rating=6.4
                        }
                    }
                },



                }
            };

            // Fantastik kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategoryFantastik = new()
            {
                CategoryName = "Fantastik",
                SubCategories = new List<MovieSubCategory>()
            {

                 new MovieSubCategory()
                {
                    SubCategoryName = "Fantastik",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Lord of the Rings: The Fellowship of the Ring",
                            ReleaseYear=2001,
                            Director="Peter Jackson",
                            LeadingActor="Elijah Wood",
                            Rating=8.8},

                        new Movie(){
                            MovieName="Pan's Labyrinth",
                            ReleaseYear=2006,
                            Director="Guillermo del Toro",
                            LeadingActor="Ivana Baquero",
                            Rating=8.2},

                        new Movie(){
                            MovieName="Harry Potter and the Sorcerer's Stone",
                            ReleaseYear=2001,
                            Director="Chriss Columbus",
                            LeadingActor="Daniel Radcliffe",
                            Rating=7.6},

                        new Movie(){
                            MovieName="Spirited Away",
                            ReleaseYear=2001,
                            Director="Hayao Miyazaki",
                            LeadingActor="Rumi Hiiragi"
                            , Rating=8.6},

                        new Movie(){
                            MovieName="The Chronicles of Narnia: The Lion, the Witch and the Wardrobe",
                            ReleaseYear=2005,
                            Director="Andrew Adamson",
                            LeadingActor="Georgie Henley",
                            Rating=6.9
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Masal",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Alice in Wonderland",
                            ReleaseYear=2010,
                            Director="Tim Burton",
                            LeadingActor="Mia Wasikowska",
                            Rating=6.4},

                        new Movie(){
                            MovieName="The Princess Bride",
                            ReleaseYear=1987,
                            Director="Rob Reiner",
                            LeadingActor="Cary Elwes",
                            Rating=8.1},

                        new Movie(){
                            MovieName="The Wizard of Oz",
                            ReleaseYear=1939,
                            Director="Victor Fleming",
                            LeadingActor="Judy Garland",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Ella Enchanted",
                            ReleaseYear=2004,
                            Director="Tommy O'Haver",
                            LeadingActor="Anne Hathaway"
                            , Rating=6.2},

                        new Movie(){
                            MovieName="Stardust",
                            ReleaseYear=2007,
                            Director="Matthew Vaughn",
                            LeadingActor="Charlie Cox",
                            Rating=7.6
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Mitolojik ",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Clash of the Titans",
                            ReleaseYear=1981,
                            Director="Desmond Davis",
                            LeadingActor="Harry Hamlin",
                            Rating=6.9},

                        new Movie(){
                            MovieName="Troy",
                            ReleaseYear=2004,
                            Director="Wolfgang Petersen",
                            LeadingActor="Brad Pitt",
                            Rating=7.3},

                        new Movie(){
                            MovieName="Immortals",
                            ReleaseYear=2011,
                            Director="Tarsem Singh",
                            LeadingActor="Henry Cavill",
                            Rating=6.0},

                        new Movie(){
                            MovieName="Percy Jackson & the Olympians: The Lightning Thief",
                            ReleaseYear=2010,
                            Director="Chris Columbus",
                            LeadingActor="Logan Lerman"
                            , Rating=5.9},

                        new Movie(){
                            MovieName="The Odyssey",
                            ReleaseYear=1997,
                            Director="Andrei Konchalovsky",
                            LeadingActor="Armand Assante",
                            Rating=7.0
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Tarihsel Fantezi",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Princess Bride",
                            ReleaseYear=1987,
                            Director="Rob Reiner",
                            LeadingActor="Cary Elwes",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Stardust",
                            ReleaseYear=2007,
                            Director="Matthew Vaughn",
                            LeadingActor="Charlie Cox",
                            Rating=7.6},

                        new Movie(){
                            MovieName="Ella Enchanted",
                            ReleaseYear=2004,
                            Director="Tommy O'Haver",
                            LeadingActor="Anne Hathaway",
                            Rating=6.2},

                        new Movie(){
                            MovieName="Enchanted",
                            ReleaseYear=2007,
                            Director="Kevin Lima",
                            LeadingActor="Amy Adams"
                            , Rating=7.0},

                        new Movie(){
                            MovieName="The Fall",
                            ReleaseYear=2006,
                            Director="Tarsem Singh",
                            LeadingActor="Lee Pace",
                            Rating=7.8
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Steampunk ",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The League of Extraordinary Gentlemen",
                            ReleaseYear=2003,
                            Director="Stephen Norrington",
                            LeadingActor="Sean Connery",
                            Rating=5.8},

                        new Movie(){
                            MovieName="Wild Wild West",
                            ReleaseYear=1999,
                            Director="Barry Sonnenfeld",
                            LeadingActor="Will Smith",
                            Rating=4.9},

                        new Movie(){
                            MovieName="Hugo",
                            ReleaseYear=2011,
                            Director="Martin Scorsese",
                            LeadingActor="Asa Butterfield",
                            Rating=7.5},

                        new Movie(){
                            MovieName="City of Lost Children",
                            ReleaseYear=1995,
                            Director="Marc Caro",
                            LeadingActor="Ron Perlman"
                            , Rating=7.6},

                        new Movie(){
                            MovieName="Howl's Moving Castle",
                            ReleaseYear=2004,
                            Director="Hayao Miyazaki",
                            LeadingActor="Chieko Baisho",
                            Rating=8.2
                        }
                    }

                }





                }
            };

            // Politik kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategoryPolitik = new()
            {
                CategoryName = "Politik",
                SubCategories = new List<MovieSubCategory>()
            {

                 new MovieSubCategory()
                {
                    SubCategoryName = "Propaganda",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Triumph of the Will",
                            ReleaseYear=1935,
                            Director="Leni Riefenstahl",
                            LeadingActor="Adolf Hitler",
                            Rating=7.2},

                        new Movie(){
                            MovieName="The Birth of a Nation",
                            ReleaseYear=1915,
                            Director="D.W. Griffith",
                            LeadingActor="Lillian Gish",
                            Rating=6.3},

                        new Movie(){
                            MovieName="Why We Fight",
                            ReleaseYear=1942,
                            Director="Frank Capra",
                            LeadingActor="(belgesel)",
                            Rating=7.5},

                        new Movie(){
                            MovieName="The Eternal Jew",
                            ReleaseYear=1940,
                            Director="Fritz Hippler",
                            LeadingActor="(belgesel)"
                            , Rating=3.5},

                        new Movie(){
                            MovieName="The Great Dictator",
                            ReleaseYear=1940,
                            Director="Charlie Chaplin",
                            LeadingActor="Charlie Chaplin",
                            Rating=8.4
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Politik",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Ides of March",
                            ReleaseYear=2011,
                            Director="George Clooney",
                            LeadingActor="Ryan Gosling",
                            Rating=7.1},

                        new Movie(){
                            MovieName="The American President",
                            ReleaseYear=1995,
                            Director="Rob Reiner",
                            LeadingActor="Micheal Douglas",
                            Rating=6.8},

                        new Movie(){
                            MovieName="Way the Dog",
                            ReleaseYear=1997,
                            Director="Barry Levinson",
                            LeadingActor="Dustin Hoffman",
                            Rating=7.1},

                        new Movie(){
                            MovieName="JFK",
                            ReleaseYear=1991,
                            Director="Oliver Stone",
                            LeadingActor="Kevin Costner"
                            , Rating=8.0},

                        new Movie(){
                            MovieName="All the President's Men",
                            ReleaseYear=1976,
                            Director="Alan J. Pakula",
                            LeadingActor="Robert Redford",
                            Rating=7.9
                        }
                    }
                },

                }
            };

            // Romantik kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategoryRomantik = new()
            {
                CategoryName = "Romantik",
                SubCategories = new List<MovieSubCategory>()
            {

                 new MovieSubCategory()
                {
                    SubCategoryName = "Romantik",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Pride and Prejudice",
                            ReleaseYear=2005,
                            Director="Joe Wright",
                            LeadingActor="Keira Knightley",
                            Rating=7.8},

                        new Movie(){
                            MovieName="The Notebook",
                            ReleaseYear=2004,
                            Director="Nick Cassavetes",
                            LeadingActor="Ryan Gosling",
                            Rating=7.8},

                        new Movie(){
                            MovieName="La La Land",
                            ReleaseYear=2016,
                            Director="Damien Chazelle",
                            LeadingActor="Ryan Gosling,Emma Stone",
                            Rating=8.0},

                        new Movie(){
                            MovieName="Titanic",
                            ReleaseYear=1997,
                            Director="James Cameron",
                            LeadingActor="Leanardo DiCaprio"
                            , Rating=7.9},

                        new Movie(){
                            MovieName="Notting Hill",
                            ReleaseYear=1999,
                            Director="Roger Michell",
                            LeadingActor="Julia Roberts",
                            Rating=7.2
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Romantik Gerilim",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Fatal Attraction",
                            ReleaseYear=1987,
                            Director="Adrian Lyne",
                            LeadingActor="Michael Douglas",
                            Rating=6.9},

                        new Movie(){
                            MovieName="The Hand that Rocks the Cradle",
                            ReleaseYear=1992,
                            Director="Curtis Hanson",
                            LeadingActor="Annabella Sciorra",
                            Rating=6.6},

                        new Movie(){
                            MovieName="Basic Instinc",
                            ReleaseYear=1992,
                            Director="Paul Verhoeven",
                            LeadingActor="Michael Douglas",
                            Rating=7.0},

                        new Movie(){
                            MovieName="The Bodyguard",
                            ReleaseYear=1992,
                            Director="Mick Jackson",
                            LeadingActor="Kevin Costner"
                            , Rating=6.3},

                        new Movie(){
                            MovieName="Unfaithfull",
                            ReleaseYear=2002,
                            Director="Adrian Lyne",
                            LeadingActor="Richard Gere",
                            Rating=6.7
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Romantik Macera",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Princess Bride",
                            ReleaseYear=1987,
                            Director="Rob Reiner",
                            LeadingActor="Cary Elwes",
                            Rating=8.0},

                        new Movie(){
                            MovieName="Romancing the Stone",
                            ReleaseYear=1984,
                            Director="Robert Zemeckis",
                            LeadingActor="Michael Douglas",
                            Rating=6.9},

                        new Movie(){
                            MovieName="Out of Africa",
                            ReleaseYear=1985,
                            Director="Sydney Pollack",
                            LeadingActor="Meryl Streep",
                            Rating=7.2},

                        new Movie(){
                            MovieName="Ever After",
                            ReleaseYear=1998,
                            Director="Andy Tennant",
                            LeadingActor="Drew Barrymore"
                            , Rating=7.1},

                        new Movie(){
                            MovieName="Enchanted",
                            ReleaseYear=2007,
                            Director="Kevin Lima",
                            LeadingActor="Amy Adams",
                            Rating=7.0
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Romantik Dram",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Atonement",
                            ReleaseYear=2007,
                            Director="Joe Wright",
                            LeadingActor="Keira Knightley",
                            Rating=7.8},

                        new Movie(){
                            MovieName="Broklyn",
                            ReleaseYear=2015,
                            Director="Johm Crowley",
                            LeadingActor="Saoirse Ronan",
                            Rating=7.5},

                        new Movie(){
                            MovieName="The Vow",
                            ReleaseYear=2012,
                            Director="Micheal Sucsy",
                            LeadingActor="Rachel McAdams",
                            Rating=6.8},

                        new Movie(){
                            MovieName="Before Sunsire",
                            ReleaseYear=1995,
                            Director="Richard Linklater",
                            LeadingActor="Ethan Hawke,Julie Delpy"
                            , Rating=8.1},

                        new Movie(){
                            MovieName="The Time Traveler's Wife",
                            ReleaseYear=2009,
                            Director="Robert Schwentke",
                            LeadingActor="Rachel McAdams",
                            Rating=7.1
                        }
                    }
                },


                }
            };

            // Macera kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategoryMacera = new()
            {
                CategoryName = "Macera",
                SubCategories = new List<MovieSubCategory>()
            {

                 new MovieSubCategory()
                {
                    SubCategoryName = "Korsan",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Pirates of the Caribbean: The Curse of the Black Pearl",
                            ReleaseYear=2003,
                            Director="Gore Verbinski",
                            LeadingActor="Kohnny Depp",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Hook",
                            ReleaseYear=1991,
                            Director="Steven Spielberg",
                            LeadingActor="Robin Williams",
                            Rating=6.8},

                        new Movie(){
                            MovieName="The Princess Bride",
                            ReleaseYear=1987,
                            Director="Rob Reiner",
                            LeadingActor="Cary Elwes",
                            Rating=8.0},

                        new Movie(){
                            MovieName="Treasure Island",
                            ReleaseYear=1950,
                            Director="Byron Haskin",
                            LeadingActor="Booby Driscoll"
                            , Rating=7.0},

                        new Movie(){
                            MovieName="Cutthroat Island",
                            ReleaseYear=1995,
                            Director="Renny Harlin",
                            LeadingActor="Geena Davis",
                            Rating=5.7
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Hazine Avı",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Indiana Jones and the Raiders of the Lost Ark",
                            ReleaseYear=1981,
                            Director="Steven Spielberg",
                            LeadingActor="Harrison Ford",
                            Rating=8.4},

                        new Movie(){
                            MovieName="National Treasure",
                            ReleaseYear=2004,
                            Director="Jon Turteltaub",
                            LeadingActor="Nicolas Cage",
                            Rating=6.9},

                        new Movie(){
                            MovieName="The Goonies",
                            ReleaseYear=1985,
                            Director="Richard Donner",
                            LeadingActor="Sean Astin",
                            Rating=7.7},

                        new Movie(){
                            MovieName="Lara Croft: Tomb Raider",
                            ReleaseYear=2001,
                            Director="Simon West",
                            LeadingActor="Angelina Jolie"
                            , Rating=5.8},

                        new Movie(){
                            MovieName="Romancing the Stone",
                            ReleaseYear=1984,
                            Director="Robert Zemeckis",
                            LeadingActor="Michael Douglas",
                            Rating=6.9
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Yolculuk ve Keşif",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Into the Wild",
                            ReleaseYear=2007,
                            Director="Sean Penn",
                            LeadingActor="Emile Hirsch",
                            Rating=8.1},

                        new Movie(){
                            MovieName="The Secret Life of Walter Mitty",
                            ReleaseYear=2013,
                            Director="Ben Stiller",
                            LeadingActor="Ben Stiller",
                            Rating=7.3},

                        new Movie(){
                            MovieName="Cast Away",
                            ReleaseYear=2000,
                            Director="Robert Zemeckis",
                            LeadingActor="Tom Hanks",
                            Rating=7.8},

                        new Movie(){
                            MovieName="Life of Pi",
                            ReleaseYear=2012,
                            Director="Ang Lee",
                            LeadingActor="Suraj Sharma"
                            , Rating=7.9},

                        new Movie(){
                            MovieName="Seven Years in Tibet",
                            ReleaseYear=1997,
                            Director="Jean-Jacques Annaud",
                            LeadingActor="Brad Pitt",
                            Rating=7.0
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Tarihi Macera",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Braveheart",
                            ReleaseYear=1995,
                            Director="Mel Gibson",
                            LeadingActor="Mel Gibson",
                            Rating=8.3},

                        new Movie(){
                            MovieName="The Last of the Mohicans",
                            ReleaseYear=1992,
                            Director="Michael Mann",
                            LeadingActor="Daniel Day-Lewis",
                            Rating=7.7},

                        new Movie(){
                            MovieName="Lawrence of Arabia",
                            ReleaseYear=1962,
                            Director="David Lean",
                            LeadingActor="Peter O'Toole",
                            Rating=8.3},

                        new Movie(){
                            MovieName="Gladiator",
                            ReleaseYear=2000,
                            Director="Ridley Scott",
                            LeadingActor="Russell Crowe"
                            , Rating=8.5},

                        new Movie(){
                            MovieName="Kingdom of Heaven",
                            ReleaseYear=2005,
                            Director="Ridley Scott",
                            LeadingActor="Orlando Bloom",
                            Rating=7.2
                        }
                    }
                },



                }
            };

            // Savaş kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategorySavaş = new()
            {
                CategoryName = "Savaş",
                SubCategories = new List<MovieSubCategory>()
            {

                 new MovieSubCategory()
                {
                    SubCategoryName = "I. Dünya Savaşı",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="1917",
                            ReleaseYear=2019,
                            Director="Sam Mendes",
                            LeadingActor="George MacKay",
                            Rating=8.2},

                        new Movie(){
                            MovieName="War Horse",
                            ReleaseYear=2011,
                            Director="Steven Spielberg",
                            LeadingActor="Jeremy Irvine",
                            Rating=7.2},

                        new Movie(){
                            MovieName="All Quiet on the Western Front",
                            ReleaseYear=1930,
                            Director="Lewis Milestone",
                            LeadingActor="Lew Ayres",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Paths of Glory",
                            ReleaseYear=1957,
                            Director="Stanley Kubrick",
                            LeadingActor="Kirk Douglas"
                            , Rating=8.4},

                        new Movie(){
                            MovieName="The Trench",
                            ReleaseYear=1999,
                            Director="William Boyd",
                            LeadingActor="Daniel Craig",
                            Rating=6.0
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "II. Dünya Savaşı",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Saving Private Ryan",
                            ReleaseYear=1998,
                            Director="Steven Spielberg",
                            LeadingActor="Tom Hanks",
                            Rating=8.6},

                        new Movie(){
                            MovieName="Schindler's List",
                            ReleaseYear=1993,
                            Director="Steven Spielberg",
                            LeadingActor="Liam Neeson",
                            Rating=9.0},

                        new Movie(){
                            MovieName="The Thin Red Line",
                            ReleaseYear=1998,
                            Director="Terrence Malick",
                            LeadingActor="Jim Caviezel",
                            Rating=7.6},

                        new Movie(){
                            MovieName="Inglourious Basterds",
                            ReleaseYear=2009,
                            Director="Quentin Tarantino",
                            LeadingActor="Brad Pitt"
                            , Rating=8.3},

                        new Movie(){
                            MovieName="Letters from Iwo Jima",
                            ReleaseYear=2006,
                            Director="Clint Eastwood",
                            LeadingActor="Ken Watanabe",
                            Rating=7.9
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Modern Savaş",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Black Hawk Down",
                            ReleaseYear=2011,
                            Director="Ridley Scott",
                            LeadingActor="Josh Hartnett",
                            Rating=7.7},

                        new Movie(){
                            MovieName="American Sniper",
                            ReleaseYear=2014,
                            Director="Clint Eastwood",
                            LeadingActor="Bradley Cooper",
                            Rating=7.3},

                        new Movie(){
                            MovieName="Lone Survivor",
                            ReleaseYear=2013,
                            Director="Peter Beng",
                            LeadingActor="Mark Wahlberg",
                            Rating=7.5},

                        new Movie(){
                            MovieName="Zero Dark Thirty",
                            ReleaseYear=2012,
                            Director="Kathryn Bigelow",
                            LeadingActor="Jessica Chastain"
                            , Rating=7.4},

                        new Movie(){
                            MovieName="The Hurt Locker",
                            ReleaseYear=2008,
                            Director="Kathryn Bigelow",
                            LeadingActor="Jeremy Renner",
                            Rating=7.5
                        }
                    }
                },



                }
            };

            // Spor kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategorySpor = new()
            {
                CategoryName = "Spor",
                SubCategories = new List<MovieSubCategory>()
            {

                 new MovieSubCategory()
                {
                    SubCategoryName = "Boks",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Rocky",
                            ReleaseYear=1976,
                            Director="John G. Avildsen",
                            LeadingActor="Sylvester Stallone",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Raging Bull",
                            ReleaseYear=1980,
                            Director="Martin Scorsese",
                            LeadingActor="Robert De Niro",
                            Rating=8.2},

                        new Movie(){
                            MovieName="The Fighter",
                            ReleaseYear=2010,
                            Director="David O. Russell",
                            LeadingActor="Mark Wahlberg,Christian Bale",
                            Rating=7.8},

                        new Movie(){
                            MovieName="Creed",
                            ReleaseYear=2015,
                            Director="Ryan Coogler",
                            LeadingActor="Micheal B. Jordan"
                            , Rating=7.6},

                        new Movie(){
                            MovieName="Million Dollar Baby",
                            ReleaseYear=2004,
                            Director="Clint Eastwood",
                            LeadingActor="Hilary Swank",
                            Rating=8.1
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Basketbol",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Hoosiers",
                            ReleaseYear=1986,
                            Director="David Anspaugh",
                            LeadingActor="Gene Hackman",
                            Rating=7.5},

                        new Movie(){
                            MovieName="Space Jam",
                            ReleaseYear=1996,
                            Director="Joe Pytka",
                            LeadingActor="Michael Jordan",
                            Rating=6.5},

                        new Movie(){
                            MovieName="Coach Carter",
                            ReleaseYear=2005,
                            Director="Thomas Carter",
                            LeadingActor="Samuel L. Jackson",
                            Rating=7.3},

                        new Movie(){
                            MovieName="He Got Game",
                            ReleaseYear=1998,
                            Director="Spike Lee",
                            LeadingActor="Denzel Washington"
                            , Rating=6.9},

                        new Movie(){
                            MovieName="The Last Dance",
                            ReleaseYear=2020,
                            Director="Jason Hehir",
                            LeadingActor="Micheal Jordan",
                            Rating=9.1
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Yarış",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Rush",
                            ReleaseYear=2013,
                            Director="Ron Howard",
                            LeadingActor="Chris Hemsworth",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Ford v Ferrari",
                            ReleaseYear=2019,
                            Director="James Mangold",
                            LeadingActor="Matt Damon",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Days of Thunder",
                            ReleaseYear=1990,
                            Director="Tony Scott",
                            LeadingActor="Tom Cruise",
                            Rating=6.1},

                        new Movie(){
                            MovieName="Senna",
                            ReleaseYear=2010,
                            Director="Asif Kapadia",
                            LeadingActor="Ayrton Senna"
                            , Rating=8.5},

                        new Movie(){
                            MovieName="Talladega Nights:The Ballad of Ricky Bobby",
                            ReleaseYear=2006,
                            Director="Adam McKay",
                            LeadingActor="Will Ferrell",
                            Rating=6.6
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Futbol",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Goal!",
                            ReleaseYear=2005,
                            Director="Danny Connon",
                            LeadingActor="Kuno Becker",
                            Rating=6.7},

                        new Movie(){
                            MovieName="The Damned United",
                            ReleaseYear=2009,
                            Director="Tom Hooper",
                            LeadingActor="Michael Sheen",
                            Rating=7.5},

                        new Movie(){
                            MovieName="Green Street Hooligans",
                            ReleaseYear=2005,
                            Director="Lexi Alexander",
                            LeadingActor="Elijah Wood",
                            Rating=7.4},

                        new Movie(){
                            MovieName="Bend It Like Beckham",
                            ReleaseYear=2002,
                            Director="Gurinder Chadha",
                            LeadingActor="Parminder Nagra"
                            , Rating=6.6},

                        new Movie(){
                            MovieName="Shaolin Soccer",
                            ReleaseYear=2001,
                            Director="Stephen Chow",
                            LeadingActor="Stephen Chow",
                            Rating=7.3
                        }
                    }
                },



                }
            };

            // Suç kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategorySuç = new()
            {
                CategoryName = "Suç",
                SubCategories = new List<MovieSubCategory>()
            {

                 new MovieSubCategory()
                {
                    SubCategoryName = "Suç",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Godfather",
                            ReleaseYear=1972,
                            Director="Francis Ford Coppola",
                            LeadingActor="Marlon Brando",
                            Rating=9.2},

                        new Movie(){
                            MovieName="Goodfellas",
                            ReleaseYear=1990,
                            Director="Martin Scorsese",
                            LeadingActor="Ray Liotta",
                            Rating=8.7},

                        new Movie(){
                            MovieName="The Departed",
                            ReleaseYear=2006,
                            Director="Martin Scorsese",
                            LeadingActor="Leanardo DiCaprio",
                            Rating=8.5},

                        new Movie(){
                            MovieName="Pulp Fiction",
                            ReleaseYear=1994,
                            Director="Quentin Tarantino",
                            LeadingActor="John Travolta"
                            , Rating=8.9},

                        new Movie(){
                            MovieName="Heat",
                            ReleaseYear=1995,
                            Director="Michael Mann",
                            LeadingActor="Al Pacino",
                            Rating=8.2
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Sahtekarlık",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Catch Me If You Can",
                            ReleaseYear=2002,
                            Director="Steven Spielberg",
                            LeadingActor="Leanardo DiCaprio",
                            Rating=8.1},

                        new Movie(){
                            MovieName="The Sting",
                            ReleaseYear=1973,
                            Director="George Roy Hill",
                            LeadingActor="Paul Newman",
                            Rating=8.3},

                        new Movie(){
                            MovieName="The Italian Job",
                            ReleaseYear=2003,
                            Director="F.Gary Gary",
                            LeadingActor="Mark Wahlberg",
                            Rating=7.0},

                        new Movie(){
                            MovieName="Now You See Me",
                            ReleaseYear=2013,
                            Director="Louis Leterrier",
                            LeadingActor="Jesse Eisenberg"
                            , Rating=7.2},

                        new Movie(){
                            MovieName="Ocean's Eleven",
                            ReleaseYear=2001,
                            Director="Steven Soderbergh",
                            LeadingActor="George Clooney",
                            Rating=7.8
                        }
                    }
                },

                 new MovieSubCategory()
                {
                    SubCategoryName = "Organize Suç",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Casino ",
                            ReleaseYear=1995,
                            Director="Martin Scorsese",
                            LeadingActor="Robert De Niro",
                            Rating=8.2},

                        new Movie(){
                            MovieName="Donnie Brasco",
                            ReleaseYear=1997,
                            Director="Mike Newell",
                            LeadingActor="Johnny Depp",
                            Rating=7.7},

                        new Movie(){
                            MovieName="The Town",
                            ReleaseYear=2010,
                            Director="Ben Affleck",
                            LeadingActor="Ben Affleck",
                            Rating=7.5},

                        new Movie(){
                            MovieName="Scarface",
                            ReleaseYear=1983,
                            Director="Brian De Palma",
                            LeadingActor="Al Pacino"
                            , Rating=8.3},

                        new Movie(){
                            MovieName="City of God",
                            ReleaseYear=2002,
                            Director="Fernando Meirelles",
                            LeadingActor="Alexandre Rodrigues",
                            Rating=8.6
                        }
                    }
                },




                }
            };



            context.MovieCategories.Add(movieCategoryAksiyon); // Film kategorisini ekle
            context.MovieCategories.Add(movieCategoryBelgesel);
            context.MovieCategories.Add(movieCategoryBilimkurgu);
            context.MovieCategories.Add(movieCategoryDram);
            context.MovieCategories.Add(movieCategoryGerilim);
            context.MovieCategories.Add(movieCategoryKomedi);
            context.MovieCategories.Add(movieCategoryKorku);
            context.MovieCategories.Add(movieCategoryFantastik);
            context.MovieCategories.Add(movieCategoryPolitik);
            context.MovieCategories.Add(movieCategoryRomantik);
            context.MovieCategories.Add(movieCategoryMacera);
            context.MovieCategories.Add(movieCategorySavaş);
            context.MovieCategories.Add(movieCategorySpor);
            context.MovieCategories.Add(movieCategorySuç);

           // context.SaveChanges(); // Değişiklikleri kaydet


        }





    }
}


