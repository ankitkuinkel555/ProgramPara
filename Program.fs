// Define the discriminated union for movie genres
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
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

// Example usage:
let ramBabuGurung = { Name = "Ram Babu Gurung"; MoviesDirected = 5 }
let pardon = { Title = "Pardeshi"; RunLength = 120; Genre = Drama; Director = ramBabuGurung; IMDBRating = 7.5 }
let kabbadi = { Title = "Kabbadi Kabbadi Kabbadi"; RunLength = 110; Genre = Comedy; Director = ramBabuGurung; IMDBRating = 8.2 }

// Print the result
printfn "Director: %s, Movies Directed: %d" ramBabuGurung.Name ramBabuGurung.MoviesDirected
printfn "Movie: %s, Run Length: %d minutes, Genre: %A, Director: %s, IMDB Rating: %.1f" pardon.Title pardon.RunLength pardon.Genre ramBabuGurung.Name pardon.IMDBRating
printfn "Movie: %s, Run Length: %d minutes, Genre: %A, Director: %s, IMDB Rating: %.1f" kabbadi.Title kabbadi.RunLength kabbadi.Genre ramBabuGurung.Name kabbadi.IMDBRating
