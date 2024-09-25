Retangulo re1 = new Retangulo();
Retangulo re2 = new Retangulo(2);
Retangulo re3 = new Retangulo(2,3);



Console.WriteLine($"Retangulo 1 area: {re1.CalcularArea()} e Perimetro: {re1.CalcularPerimetro()}");
Console.WriteLine($"Retangulo 2 area: {re2.CalcularArea()} e Perimetro: {re2.CalcularPerimetro()}");
Console.WriteLine($"Retangulo 3 area: {re3.CalcularArea()} e Perimetro: {re3.CalcularPerimetro()}");

re3.redimensionar(2);
Console.WriteLine($"Retangulo 3 Area: {re3.CalcularArea()} e Perimetro: {re3.CalcularPerimetro()}");

re2.redimensionar(10, 15);
Console.WriteLine($"Retangulo 2 Area: {re2.CalcularArea()} e Perimetro: {re3.CalcularPerimetro()}");

