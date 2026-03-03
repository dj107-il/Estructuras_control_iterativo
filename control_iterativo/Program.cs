// See https://aka.ms/new-console-template for more information

// Sección 1 — For y Foreach: Registro y análisis de calificaciones

int[] calificaciones = {72, 85, 91, 60, 43, 78, 95, 55, 88, 67};

Console.WriteLine("==== REGISTRO DE CALIFICACIONES ====");
for(int posicion = 0; posicion < calificaciones.Length; posicion++)
{
    Console.WriteLine($"Estudiante {posicion + 1}: {calificaciones[posicion]}");
}

Console.WriteLine("\n===== ORDEN DESCENDENTE =====");
for(int descendente = calificaciones.Length - 1; descendente >= 0; descendente--)
{   
    Console.WriteLine($"Estudiante {descendente + 1}: {calificaciones[descendente]}");
}

Console.WriteLine("\n === PROMEDIO DEL GRUPO ===");
int suma = 0;
foreach (int promedio in calificaciones)
{
    suma += promedio;
}
double promedioGeneral = (double)suma / calificaciones.Length;
Console.WriteLine($"Suma de calificaciones: {suma}");
Console.WriteLine($"Promedio general: {promedioGeneral:F2}");

Console.WriteLine("\n === Posiciones pares ===");
for(int posicion = 0; posicion < calificaciones.Length; posicion += 2)
{
    Console.WriteLine($"Posición par: {calificaciones[posicion]}");
}

// Sección 2 — While y Do-While: Validación y juego interactivo

int intentos = 0;
string clave = "sena2025";
string ingreso = "";

Console.WriteLine("\n === CONTROL DE ACCESO ===");

while (ingreso != clave && intentos < 3)
{
    Console.Write("Ingrese la clave: ");
    ingreso = Console.ReadLine();

    if (ingreso == clave)
    {
        Console.WriteLine("Acceso concedido.");
        break;
    }else
    {
        intentos++;
        if (intentos < 3)
        {
            Console.WriteLine($"Clave incorrecta. Intentos restantes: {3 - intentos}");
        }
        else
        {
            Console.WriteLine("Acceso bloqueado.");
        }
    }
}

int opciones;
do
{
    Console.WriteLine("\n === MENÚ PRINCIPAL ===");
    Console.WriteLine("1. Ver el promedio del grupo");
    Console.WriteLine("2. Ver calificación más alta.");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opción: ");
    opciones = int.Parse(Console.ReadLine());

    switch(opciones)
    {
        case 1:
            Console.WriteLine($"Promedio general: {promedioGeneral:F2}");
            break;
        case 2:
            int calificacionMaxima = calificaciones[0];
            for(int i = 1; i < calificaciones.Length; i++)
            {
                if(calificaciones[i] > calificacionMaxima)
                {
                    calificacionMaxima = calificaciones[i];
                }
            }
            Console.WriteLine($"Calificación más alta: {calificacionMaxima}");
            break;
        case 3:
            Console.WriteLine("Hasta luego.");
            break;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }
} while (opciones != 3);

// Sección 3 — Break y Continue: Filtrado y búsqueda eficiente

Console.WriteLine("\n=== PRIMERA CALIFICACIÓN REPROBATORIA ===");
for (int i = 0; i < calificaciones.Length; i++)
{
    if (calificaciones[i] < 60)
    {
        Console.WriteLine($"Encontrada en posición {i + 1}: {calificaciones[i]}");
        break;
    }
}

Console.WriteLine("\n=== ESTUDIANTES APROBADOS ===");
int aprobados = 0;
foreach (int calificacion in calificaciones)
{
    if (calificacion >= 60)
    {
        Console.WriteLine($"Aprobado: {calificacion}");
        aprobados++;
    }else
    {
        continue;   
    }
}
Console.WriteLine("Total aprobados: " + aprobados);

Console.WriteLine("\n=== FILTRO COMBINADO ===");
for (int i = 0; i < calificaciones.Length; i++)
{
    if (calificaciones[i] < 70)
    {
        continue; 
    }

    if (calificaciones[i] >= 95)
    {
        // detener la búsqueda en cuanto aparezca una calificación de 95 o más
        Console.WriteLine($"Búsqueda detenida al encontrar: {calificaciones[i]}");
        break;
    }

    Console.WriteLine($"Calificación procesada: {calificaciones[i]}");
}