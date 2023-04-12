using csharp_calcolatrice;

int a = 5, b = 8, c = 0, d = -3, e= -4;
double f = 5.35, g = 8.84, h = -0.96, i = -3.15;

Console.WriteLine($"Somma interi : {a} + {b} = {CalcoliHelper.Somma(a, b)}");
Console.WriteLine($"Somma double : {f} + {g} = {CalcoliHelper.Somma(f, g)}");
Console.WriteLine($"Differenza interi : {e} - {a} = {CalcoliHelper.Differenza(e, a)}");
Console.WriteLine($"Differenza double : {i} - {f} = {CalcoliHelper.Differenza(i, f)}");
Console.WriteLine($"Moltiplicazione interi : {c} * {d} = {CalcoliHelper.Moltiplicazione(c, d)}");
Console.WriteLine($"Moltiplicazione double : {h} * {i} = {CalcoliHelper.Moltiplicazione(h, i)}");
Console.WriteLine($"Valore assoluto intero: |{b}| = {CalcoliHelper.Assoluto(b)}");
Console.WriteLine($"Valore assoluto double : |{i}| = {CalcoliHelper.Assoluto(i)}");
Console.WriteLine($"Minimo interi : {c} e {e} = {CalcoliHelper.Minimo(c, e)}");
Console.WriteLine($"Minimo double : {g} e {f} = {CalcoliHelper.Minimo(g, f)}");
Console.WriteLine($"Massimo interi: {d} e {e} = {CalcoliHelper.Massimo(d, e)}");
Console.WriteLine($"Massimo double : {h} e {i} = {CalcoliHelper.Massimo(h, i)}");
Console.WriteLine($"Potenza : {a} ^ {b} = {CalcoliHelper.Potenza(a, b)}");
Console.WriteLine($"Potenza : {a} ^ {c} = {CalcoliHelper.Potenza(a, c)}");
Console.WriteLine($"Potenza : {a} ^ {d} = {CalcoliHelper.Potenza(a, d)}");
Console.WriteLine($"Potenza : {c} ^ {c} = {CalcoliHelper.Potenza(c, c)}");
Console.WriteLine($"Potenza : {c} ^ {e} = {CalcoliHelper.Potenza(c, e)}");
Console.WriteLine($"Potenza : {d} ^ {b} = {CalcoliHelper.Potenza(d, b)}");
Console.WriteLine($"Potenza : {d} ^ {e} = {CalcoliHelper.Potenza(d, e)}");