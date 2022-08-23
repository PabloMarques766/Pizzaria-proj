using AtividadePizzaria.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace AtividadePizzaria.Data
{
    public class InicializadorDeDados
    {
        public static void Inicializar(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope
                    .ServiceProvider
                    .GetService<PizzariaDbContext>();

                context.Database.EnsureCreated();

                if(!context.Sabores.Any())
                {
                    context.Sabores.AddRange(new List<Sabor>() 
                    {
                        new Sabor("Massa Tradicional", "https://maringa.cidadecancao.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/m/a/massa-pizza-tradicional-kg-0000000025263.jpg"),
                        new Sabor("Atum", "https://oreinodopeixe.com.br/wp-content/uploads/2019/08/NOVO_Atum2.jpg"),
                        new Sabor("Calabresa", "https://oacougue.com.br/wp-content/uploads/2020/06/LINGUICA-CALABRESA-DEFUMADA.jpg"),
                        new Sabor("Mussarela", "https://static.clubeextra.com.br/img/uploads/1/0/583000.jpg")
                    });
                    context.SaveChanges();
                }

                if (!context.Tamanhos.Any())
                {
                    context.Tamanhos.AddRange(new List<Tamanho>()
                    {
                        new Tamanho("Broto"),
                        new Tamanho("Média"),
                        new Tamanho("Familia") 
                    });
                    context.SaveChanges();
                }

                if (!context.Pizzas.Any())
                {
                    context.Pizzas.AddRange(new List<Pizza>()
                    {
                        new Pizza("Portuguesa",30,"https://media.istockphoto.com/photos/pizza-argentina-picture-id1047708734",1),
                        new Pizza("Parmesão",40,"http://luccapizzaria.com.br/wp-content/uploads/2020/04/5queijos.jpg",2),
                        new Pizza("Atum",50,"https://www.comidaereceitas.com.br/img/sizeswp/1200x675/2015/03/pizza_atum_especial.jpg",3)
                    });
                    context.SaveChanges();
                }

                if (!context.PizzasSabores.Any())
                {
                    context.PizzasSabores.AddRange(new List<PizzaSabor>()
                    {
                        new PizzaSabor(1,3),
                        new PizzaSabor(2,4),
                        new PizzaSabor(3,2),
                        new PizzaSabor(1,1),
                        new PizzaSabor(2,1),
                        new PizzaSabor(3,1)
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
