using System;

class Program
{
	static void Main(string[] args)
	{
		bool[] interruptores = new bool[3]; // Array para representar o estado dos interruptores

		// 1. Ligue o primeiro interruptor e aguarde alguns minutos. Depois, desligue-o.
		LigarInterruptor(interruptores, 0);
		DesligarInterruptor(interruptores, 0);

		// 2. Ligue o segundo interruptor e vá imediatamente para a sala das lâmpadas.
		LigarInterruptor(interruptores, 1);
		int salaControlada = VerificarLampada(interruptores);

		// 3. Determinar qual interruptor controla qual lâmpada
		switch (salaControlada)
		{
			case 0:
				Console.WriteLine("O interruptor 2 controla a lâmpada 1, o interruptor 1 controla a lâmpada 2 e o interruptor 3 controla a lâmpada 3.");
				break;
			case 1:
				Console.WriteLine("O interruptor 1 controla a lâmpada 1, o interruptor 2 controla a lâmpada 2 e o interruptor 3 controla a lâmpada 3.");
				break;
			case 2:
				Console.WriteLine("O interruptor 1 controla a lâmpada 1, o interruptor 3 controla a lâmpada 2 e o interruptor 2 controla a lâmpada 3.");
				break;
		}
	}

	// Método para ligar um interruptor
	static void LigarInterruptor(bool[] interruptores, int numeroInterruptor)
	{
		interruptores[numeroInterruptor] = true;
	}

	// Método para desligar um interruptor
	static void DesligarInterruptor(bool[] interruptores, int numeroInterruptor)
	{
		interruptores[numeroInterruptor] = false;
	}

	// Método para verificar qual lâmpada está ligada
	static int VerificarLampada(bool[] interruptores)
	{
		for (int i = 0; i < interruptores.Length; i++)
		{
			if (interruptores[i])
			{
				return i;
			}
		}
		return -1; // Se nenhum interruptor estiver ligado
	}
}
