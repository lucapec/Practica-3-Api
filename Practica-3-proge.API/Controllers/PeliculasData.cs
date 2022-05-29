using Practica_3_proge.API.Models;

namespace Practica_3_proge.API.Controllers
{
    public class PeliculasData
    {
        public List<PeliculasDto> Peliculas { get; set; }

        public static PeliculasData InstanciaActual { get; } = new PeliculasData();

        public PeliculasData()
        {
            Peliculas = new List<PeliculasDto>()
            {
                new PeliculasDto()
                {
                    Id = 1,
                    Name = "Batman",
                    Sinopsis = "En su segundo año luchando contra el crimen, Batman explora la corrupción existente en la ciudad de Gotham y el vínculo de esta con su propia familia. Además, entrará en conflicto con un asesino en serie conocido como 'el Acertijo'.",
                    Reviews = new List<ReviewsDto>()
                    {
                        new ReviewsDto()
                        {
                            Id = 1,
                            Name = "Carla",
                            Description = "Gran Pelicula" },
                        new ReviewsDto()
                        {
                            Id = 2,
                            Name = "Jimmy",
                            Description = "Medio aburrida" },

                        new ReviewsDto()
                        {
                            Id = 3,
                            Name = "Carlos",
                            Description = "Sublime el Batinson" },
                        new ReviewsDto()
                        {
                            Id = 4,
                            Name = "Charles",
                            Description = "Paul Dano se lució" },
                    }

                },
                 new PeliculasDto()
                {
                    Id = 2,
                    Name = "Spider-man",
                    Sinopsis = "Luego de sufrir la picadura de una araña genéticamente modificada, un estudiante de secundaria tímido y torpe adquiere increíbles capacidades como arácnido. Pronto comprenderá que su misión es utilizarlas para luchar contra el mal y defender a sus vecinos.",
                    Reviews = new List<ReviewsDto>()
                    {
                        new ReviewsDto()
                        {
                            Id = 1,
                            Name = "Ailen",
                            Description = "Gran Pelicula" },
                        new ReviewsDto()
                        {
                            Id = 2,
                            Name = "Victoria",
                            Description = "Aguante Tobey Maguire" },

                        new ReviewsDto()
                        {
                            Id = 3,
                            Name = "Roberto",
                            Description = "Sublime William Dafoe" },
                        new ReviewsDto()
                        {
                            Id = 4,
                            Name = "Carlos",
                            Description = "Un clásico del cine de super heroes" },
                    }

                },
                  new PeliculasDto()
                {
                    Id = 3,
                    Name = "John Wick",
                    Sinopsis = "John Wick, un exasesino a sueldo, se enfrenta al mafioso Viggo Tarazov, quien ofrece una recompensa a aquel que logre acabar con la vida de Wick.",
                    Reviews = new List<ReviewsDto>()
                    {
                        new ReviewsDto()
                        {
                            Id = 1,
                            Name = "Mateo",
                            Description = "De verdad usó un lapiz??!?" },
                        new ReviewsDto()
                        {
                            Id = 2,
                            Name = "Lucho",
                            Description = "Pobre chicho" },

                        new ReviewsDto()
                        {
                            Id = 3,
                            Name = "Lando",
                            Description = "Nunca se quedan sin balas?" },
                        new ReviewsDto()
                        {
                            Id = 4,
                            Name = "Laura",
                            Description = "Muy violenta, me encantó" },


                    }



                },
                   new PeliculasDto()
            {
                Id = 4,
                Name = "Leon el Profesional",
                Sinopsis = "Mathilda es una niña que no se lleva bien con su familia, excepto con su hermano pequeño. Su padre es un narcotraficante que hace negocios con Stan, un corrupto agente de la D.E.A. Un día Stan mata a su familia y Mathilda se refugia en casa de Léon, un solitario y misterioso vecino que resulta ser un asesino a sueldo, pero hará un pacto con él: ella se encargará de las tareas domésticas y le enseñará a leer a Léon y éste le enseñará a disparar para poder vengarse de la muerte de su hermano.",
                Reviews = new List<ReviewsDto>()
                {
                    new ReviewsDto()
                    {
                        Id = 1,
                        Name = "Gabrieñ",
                        Description = "Terrible"
                    },
                    new ReviewsDto()
                    {
                        Id = 2,
                        Name = "Matias",
                        Description = "Pobre familia"
                    },

                    new ReviewsDto()
                    {
                        Id = 3,
                        Name = "Max",
                        Description = "Muy buena actriz Natalie Portman"
                    },
                    new ReviewsDto()
                    {
                        Id = 4,
                        Name = "Lucia",
                        Description = "Cuidaba muy bien a su planta"
                    },
                }
            }   
            };
        }
    }
}
