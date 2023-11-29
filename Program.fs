// Define the discriminated union for movie genres
type Genre =
    | Drama
    | Comedy
    | Thriller
    | Fantasy
    | Sport

// Define the "Director" record type
type Director = {
    Name: string
    MoviesDirected: int
}

// Define the "Movie" record type
type Movie = {
    Title: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}

// Create movie instances
let coda = { Title = "CODA"; RunLength = 111; Genre = Drama; Director = { Name = "Sian Heder"; MoviesDirected = 9 }; IMDBRating = 8.1 }
let belfast = { Title = "Belfast"; RunLength = 98; Genre = Comedy; Director = { Name = "Kenneth Branagh"; MoviesDirected = 23 }; IMDBRating = 7.3 }
let dontLookUp = { Title = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = { Name = "Adam McKay"; MoviesDirected = 27 }; IMDBRating = 7.2 }
let driveMyCar = { Title = "Drive My Car"; RunLength = 179; Genre = Drama; Director = { Name = "Ryusuke Hamaguchi"; MoviesDirected = 16 }; IMDBRating = 7.6 }
let dune = { Title = "Dune"; RunLength = 155; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; MoviesDirected = 24 }; IMDBRating = 8.1 }
let kingRichard = { Title = "King Richard"; RunLength = 144; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; MoviesDirected = 151 }; IMDBRating = 7.5 }
let licoricePizza = { Title = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; MoviesDirected = 49 }; IMDBRating = 7.4 }
let nightmareAlley = { Title = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = { Name = "Guillermo Del Toro"; MoviesDirected = 22 }; IMDBRating = 7.1 }

// Example
printfn "Movie: %s, Run Length: %d minutes, Genre: %A, Director: %s, IMDB Rating: %.1f" coda.Title coda.RunLength coda.Genre coda.Director.Name coda.IMDBRating
printfn "Movie: %s, Run Length: %d minutes, Genre: %A, Director: %s, IMDB Rating: %.1f" belfast.Title belfast.RunLength belfast.Genre belfast.Director.Name belfast.IMDBRating
printfn "Movie: %s, Run Length: %d minutes, Genre: %A, Director: %s, IMDB Rating: %.1f" dontLookUp.Title dontLookUp.RunLength dontLookUp.Genre dontLookUp.Director.Name dontLookUp.IMDBRating
printfn "Movie: %s, Run Length: %d minutes, Genre: %A, Director: %s, IMDB Rating: %.1f" driveMyCar.Title driveMyCar.RunLength driveMyCar.Genre driveMyCar.Director.Name driveMyCar.IMDBRating
printfn "Movie: %s, Run Length: %d minutes, Genre: %A, Director: %s, IMDB Rating: %.1f" dune.Title dune.RunLength dune.Genre dune.Director.Name dune.IMDBRating
printfn "Movie: %s, Run Length: %d minutes, Genre: %A, Director: %s, IMDB Rating: %.1f" kingRichard.Title kingRichard.RunLength kingRichard.Genre kingRichard.Director.Name kingRichard.IMDBRating
printfn "Movie: %s, Run Length: %d minutes, Genre: %A, Director: %s, IMDB Rating: %.1f" licoricePizza.Title licoricePizza.RunLength licoricePizza.Genre licoricePizza.Director.Name licoricePizza.IMDBRating
printfn "Movie: %s, Run Length: %d minutes, Genre: %A, Director: %s, IMDB Rating: %.1f" nightmareAlley.Title nightmareAlley.RunLength nightmareAlley.Genre nightmareAlley.Director.Name nightmareAlley.IMDBRating
