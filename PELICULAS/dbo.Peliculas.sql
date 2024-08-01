CREATE TABLE [dbo].[Peliculas] (
    [IdPeliculas]        INT        IDENTITY (1, 1) NOT NULL,
    [Codigo de Pelicula] CHAR (10)  NULL,
    [Titulo]             CHAR (20)  NOT NULL,
    [Autor]              CHAR (20)  NULL,
    [Sinopsis]           CHAR (150) NOT NULL,
    [Duracion]           INT   NULL,
    [Clasificacion]      CHAR (5)   NOT NULL,
    PRIMARY KEY CLUSTERED ([IdPeliculas] ASC)
);

