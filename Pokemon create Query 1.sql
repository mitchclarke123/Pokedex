--DROP DATABASE POKEDEXPOKEMON

--CREATE DATABASE POKEDEXPOKEMON

--DROP TABLE Pokemon

CREATE TABLE Pokemon
(
PokemonID INT NOT NULL IDENTITY (1,1) PRIMARY KEY
,PokemonName VARCHAR(30)
,PokemonImage1 VARCHAR(30)
,PokemonImage2 VARCHAR (30)
);


	INSERT   [Pokemon]
			([PokemonName]
			,[PokemonImage1]
			,[PokemonImage2])
	VALUES
		   ('Bulbasaur'
		   ,'bulbasaur'
		   ,'bulbasaur blacked')
; 





--CREATE TABLE PokemonImage
--(
--PokemonID INT
--FOREIGN KEY (PokemonID) REFERENCES Pokemon (PokemonID)
--,PokemonImage VARBINARY(MAX) 
--);


--INSERT [Pokemon]
--		([PokemonName])
--		VALUES
--		('Bulbasaur')
--;
