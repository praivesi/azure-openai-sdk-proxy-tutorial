namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        // Call your data access technology here
        Pizza[] pizzas = new Pizza[10];

        for (var i = 0; i < pizzas.Length; i++)
        {
            pizzas[i] = new Pizza
            {
                PizzaId = i,
                Name = $"Pizza {i}",
                Description = $"This is a description for Pizza {i}",
                Price = 10 + i,
                Vegetarian = i % 2 == 0,
                Vegan = i % 3 == 0
            };
        }

        return Task.FromResult(pizzas);
    }
}