using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Data.Seed
{
    public class DimensionConfiguration : IEntityTypeConfiguration<Dimension>
    {
        public void Configure(EntityTypeBuilder<Dimension> builder)
        {
            builder.HasData(
                new Dimension
                {
                    Id = 1,
                    Name = "35-C",
                    Description = "A Dimensão 35-C é um mundo muito colorido, cheio de um céu amarelo e criaturas bizarras e de aparência estranha. Vários planetas, um que lembra muito Saturno, parecem estar muito próximos da Terra desta dimensão, como são claramente visíveis durante o dia.",
                    Image = "\\src\\assets\\images\\35C.png",
                    CreateAt = DateTime.Now
                },
                new Dimension
                {
                    Id = 2,
                    Name = "C-137",
                    Description = "A dimensão C-137 é um dos muitos universos no multiverso e no universo onde os Rick e Morty são frequentemente identificados como provenientes. Dado que Rick não lista seu genro adotivo Jerry como originário da mesma dimensão que ele, a dimensão C-137 é o universo em que a Terra foi invadida por Cronenbergs em \"Rick Potion # 9\".",
                    Image = "\\src\\assets\\images\\C137.png",
                    CreateAt = DateTime.Now
                },
                new Dimension
                {
                    Id = 3,
                    Name = "C-132",
                    Description = "A dimensão C-132 é um dos muitos universos no multiverso e foi o universo em que Rick e Morty dos dois primeiros volumes da série de quadrinhos Rick e Morty foram considerados, que é separado da corrente principal de Rick e Morty , que é da Dimensão C-137 . A série mudaria o foco para Rick e Morty da Dimensão C-137 após a Edição # 10, com o destino da Dimensão C-132 sendo revelado entre as Questões # 12-14.",
                    Image = "\\src\\assets\\images\\C132.png",
                    CreateAt = DateTime.Now
                }
            );
        }
    }
}
