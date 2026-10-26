 List<int> calificaciones = new List<int>();

        int estudiantes;

        do
        {
            Console.Write("Ingrese número de estudiantes: ");
            estudiantes = Convert.ToInt32(Console.ReadLine());

            if (estudiantes <= 0)
            {
                Console.WriteLine("Error: Ingrese un número positivo.");
            }

        } while (estudiantes <= 0);

        for (int i = 0; i < estudiantes; i++)
        {
            int nota;

            do
            {
                Console.Write($"Ingrese la calificación del estudiante {i + 1}: ");
                nota = Convert.ToInt32(Console.ReadLine());

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Error: la nota debe estar entre 0 y 10.");
                }

            } while (nota < 0 || nota > 10);

            calificaciones.Add(nota);
        }

        int total = 0;

        foreach (int nota in calificaciones)
        {
            total += nota;
        }

        double promedio = (double)total / calificaciones.Count;

        int maxNota = calificaciones[0];
        int minNota = calificaciones[0];

        int estudianteMayor = 1;
        int estudianteMenor = 1;

        for (int i = 1; i < calificaciones.Count; i++)
        {
            if (calificaciones[i] > maxNota)
            {
                maxNota = calificaciones[i];
                estudianteMayor = i + 1;
            }

            if (calificaciones[i] < minNota)
            {
                minNota = calificaciones[i];
                estudianteMenor = i + 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine("===== RESULTADOS =====");
        Console.WriteLine($"Promedio de calificaciones: {promedio:F2}");
        Console.WriteLine($"Nota más alta: {maxNota} (Estudiante {estudianteMayor})");
        Console.WriteLine($"Nota más baja: {minNota} (Estudiante {estudianteMenor})");
    




