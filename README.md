# About
This project parses a PGN file containing multiple games, and separates that info into separate files for each game.

## How to Use
Get a PGN file containing the games you wish to parse from the chess platform you use. Then, get the file location of the file and supply it as the first argument to the program. Then, supply the output directory in the second argument. If you are parsing many games I suggest creating a new directory to hold the output files. Then, the files will be created with a distinct file name unrelated to the game contents.

## Examples
Input File:
```text
[Event "Rated rapid game"]
[Site "https://lichess.org/pkFX4PKi"]
[Date "2024.07.06"]
[White "jab1373"]
[Black "TPJ1994"]
[Result "1-0"]
[UTCDate "2024.07.06"]
[UTCTime "15:45:53"]
[WhiteElo "1066"]
[BlackElo "1093"]
[WhiteRatingDiff "+88"]
[BlackRatingDiff "-6"]
[Variant "Standard"]
[TimeControl "600+0"]
[ECO "D00"]
[Termination "Normal"]

1. d4 d5 2. Bf4 Nf6 3. e3 c5 4. Bd3 c4 5. Be2 Nc6 6. Nf3 e6 7. O-O Ng4 8. Nc3 e5 9. dxe5 Bf5 10. Bg5 f6 11. exf6 gxf6 12. Bf4 Bd6 13. Qxd5 Nb4 14. Qxf5 Bxf4 15. exf4 Nxh2 16. Kxh2 Nxc2 17. Rad1 Qc7 18. g3 Kf7 19. Qxc2 1-0


[Event "Rated rapid game"]
[Site "https://lichess.org/2HlNzbBi"]
[Date "2024.07.06"]
[White "sun_n_moon_angel"]
[Black "jab1373"]
[Result "1-0"]
[UTCDate "2024.07.06"]
[UTCTime "15:41:39"]
[WhiteElo "1127"]
[BlackElo "1187"]
[WhiteRatingDiff "+8"]
[BlackRatingDiff "-121"]
[Variant "Standard"]
[TimeControl "600+0"]
[ECO "C46"]
[Termination "Normal"]

1. e4 e5 2. Nf3 Nc6 3. Nc3 Bc5 4. a3 d6 5. b4 Bb6 6. Nd5 Nge7 7. Nxb6 axb6 8. Bb5 O-O 9. d4 exd4 10. Nxd4 Nxd4 11. Qxd4 d5 12. Bb2 Nc6 13. Qxg7# 1-0
```
Execute:
```console
dotnet build
dotnet run C:\Users\jayba\Downloads\lichess_jab1373_2024-07-06.pgn C:\Users\jayba\Downloads\ParserOutput\
```
Output:
```text
[Event "Rated rapid game"]
[Site "https://lichess.org/pkFX4PKi"]
[Date "2024.07.06"]
[White "jab1373"]
[Black "TPJ1994"]
[Result "1-0"]
[UTCDate "2024.07.06"]
[UTCTime "15:45:53"]
[WhiteElo "1066"]
[BlackElo "1093"]
[WhiteRatingDiff "+88"]
[BlackRatingDiff "-6"]
[Variant "Standard"]
[TimeControl "600+0"]
[ECO "D00"]
[Termination "Normal"]

1. d4 d5 2. Bf4 Nf6 3. e3 c5 4. Bd3 c4 5. Be2 Nc6 6. Nf3 e6 7. O-O Ng4 8. Nc3 e5 9. dxe5 Bf5 10. Bg5 f6 11. exf6 gxf6 12. Bf4 Bd6 13. Qxd5 Nb4 14. Qxf5 Bxf4 15. exf4 Nxh2 16. Kxh2 Nxc2 17. Rad1 Qc7 18. g3 Kf7 19. Qxc2 1-0
```
```text
[Event "Rated rapid game"]
[Site "https://lichess.org/2HlNzbBi"]
[Date "2024.07.06"]
[White "sun_n_moon_angel"]
[Black "jab1373"]
[Result "1-0"]
[UTCDate "2024.07.06"]
[UTCTime "15:41:39"]
[WhiteElo "1127"]
[BlackElo "1187"]
[WhiteRatingDiff "+8"]
[BlackRatingDiff "-121"]
[Variant "Standard"]
[TimeControl "600+0"]
[ECO "C46"]
[Termination "Normal"]

1. e4 e5 2. Nf3 Nc6 3. Nc3 Bc5 4. a3 d6 5. b4 Bb6 6. Nd5 Nge7 7. Nxb6 axb6 8. Bb5 O-O 9. d4 exd4 10. Nxd4 Nxd4 11. Qxd4 d5 12. Bb2 Nc6 13. Qxg7# 1-0
```

### Info
This project utilizes .NET 8.
