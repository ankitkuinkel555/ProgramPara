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

// Define the "Movie" record type with RunLength as a string
type Movie = {
    Title: string
    RunLength: string  // Change the type to string
    Genre: Genre
    Director: Director
    IMDBRating: float
}

// Create movie instances
let coda = { Title = "CODA"; RunLength = "111"; Genre = Drama; Director = { Name = "Sian Heder"; MoviesDirected = 9 }; IMDBRating = 8.1 }
let belfast = { Title = "Belfast"; RunLength = "98"; Genre = Comedy; Director = { Name = "Kenneth Branagh"; MoviesDirected = 23 }; IMDBRating = 7.3 }
let dontLookUp = { Title = "Don't Look Up"; RunLength = "138"; Genre = Comedy; Director = { Name = "Adam McKay"; MoviesDirected = 27 }; IMDBRating = 7.2 }
let driveMyCar = { Title = "Drive My Car"; RunLength = "179"; Genre = Drama; Director = { Name = "Ryusuke Hamaguchi"; MoviesDirected = 16 }; IMDBRating = 7.6 }
let dune = { Title = "Dune"; RunLength = "155"; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; MoviesDirected = 24 }; IMDBRating = 8.1 }
let kingRichard = { Title = "King Richard"; RunLength = "144"; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; MoviesDirected = 151 }; IMDBRating = 7.5 }
let licoricePizza = { Title = "Licorice Pizza"; RunLength = "133"; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; MoviesDirected = 49 }; IMDBRating = 7.4 }
let nightmareAlley = { Title = "Nightmare Alley"; RunLength = "150"; Genre = Thriller; Director = { Name = "Guillermo Del Toro"; MoviesDirected = 22 }; IMDBRating = 7.1 }

// Create a list of movies
let movieList = [coda; belfast; dontLookUp; driveMyCar; dune; kingRichard; licoricePizza; nightmareAlley]

// Function to convert run length to hours and minutes format
let convertRunLength runLength =
    let runLengthInt = int runLength
    let hours = runLengthInt / 60
    let minutes = runLengthInt % 60
    sprintf "%dh %dmin" hours minutes

// Map function to convert run length for all movies
let convertedRunLengths =
    movieList
    |> List.map (fun movie -> { movie with RunLength = convertRunLength movie.RunLength })

// Example usage: print details of movies with converted run length
convertedRunLengths
|> List.iter (fun movie ->
    printfn "Movie: %s, Run Length: %s, Genre: %A, Director: %s, IMDB Rating: %.1f"
        movie.Title movie.RunLength movie.Genre movie.Director.Name movie.IMDBRating
)
