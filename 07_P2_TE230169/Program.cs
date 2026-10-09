// Muestra el título del programa en consola
Console.WriteLine("SIMULACIÓN DE CICLOS DE BRAZO ROBÓTICO");
Console.WriteLine();

// Crea el objeto brazo1 de la clase BrazoRobotico
BrazoRobotico brazo1 = new BrazoRobotico();

// Captura el tiempo de la primera etapa (tomar)
Console.Write("Ingrese el tiempo de la etapa 1 (tomar) en segundos: ");
brazo1.TiempoEtapa1 = Convert.ToDouble(Console.ReadLine());

// Captura el tiempo de la segunda etapa (trasladar)
Console.Write("Ingrese el tiempo de la etapa 2 (trasladar) en segundos: ");
brazo1.TiempoEtapa2 = Convert.ToDouble(Console.ReadLine());

// Captura el tiempo de la tercera etapa (soltar)
Console.Write("Ingrese el tiempo de la etapa 3 (soltar) en segundos: ");
brazo1.TiempoEtapa3 = Convert.ToDouble(Console.ReadLine());

// Captura la cantidad de ciclos que el usuario desea simular
Console.Write("Ingrese el número de ciclos que desea simular: ");
brazo1.NumeroCiclos = Convert.ToInt32(Console.ReadLine());

// Calcula el tiempo que dura un solo ciclo sumando las tres etapas
double tiempoCiclo = brazo1.CalcularTiempoCiclo();
double tiempoAcumulado = 0;

Console.WriteLine();
Console.WriteLine($"Tiempo de un ciclo individual: {tiempoCiclo:F2} segundos\n");

// Ciclo for para calcular y mostrar el tiempo acumulado en cada ciclo simulado
for (int i = 1; i <= brazo1.NumeroCiclos; i++)
{
    tiempoAcumulado += tiempoCiclo; // Suma el ciclo actual al acumulador global
    Console.WriteLine($"Ciclo {i}: Tiempo acumulado = {tiempoAcumulado:F2} segundos");
}

// Imprime el tiempo total de producción al finalizar todas las repeticiones
Console.WriteLine();
Console.WriteLine($"Tiempo total de producción: {tiempoAcumulado:F2} segundos");

// Definición de la clase BrazoRobotico
class BrazoRobotico
{
    // Propiedad para el tiempo de la etapa 1
    public double TiempoEtapa1 { get; set; }
    // Propiedad para el tiempo de la etapa 2
    public double TiempoEtapa2 { get; set; }
    // Propiedad para el tiempo de la etapa 3
    public double TiempoEtapa3 { get; set; }
    // Propiedad para la cantidad de ciclos a simular
    public int NumeroCiclos { get; set; }

    // Método que calcula el tiempo total de un ciclo sumando sus tres partes
    public double CalcularTiempoCiclo() => TiempoEtapa1 + TiempoEtapa2 + TiempoEtapa3;
}