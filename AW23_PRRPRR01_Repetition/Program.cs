using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_Repetition {
	// datastrukturer för att lagra flera värden
	struct Person { // Person är nu en datatyp som jag kan använda
		// ordet public är nödvändigt för att strukturen ska fungera
		public string firstName;
		public string lastName;
		public int age;
	}

	internal class Program {
		static void Main(string[] args) {
			Console.WriteLine("Hello world"); // output

			string myName = "Hannes";
			string myLastName; // deklaration
			myLastName = "Blåman"; // tilldelning (=)

			string myInput = Console.ReadLine();

			if (myInput == "stroganoff") { // innanför parenteserna = villkor
				Console.WriteLine("mmmmm meow");
			} else if (myInput == "teriyaki") {
				Console.WriteLine("föredrar stroganoff");
			} else {
				Console.WriteLine("ew");
			}

			int myAge = 21;
			double myHeight = 1.78;

			if (myAge >= 18 && myHeight >= 1.80) { // && = och, båda villkor måste gälla
				Console.WriteLine("gott");
			}

			if (myHeight < 0.50 || myHeight >= 3) { // || = eller, minst ett villkor måste gälla
				Console.WriteLine("du kanske behöver en egen stol");
			}

			bool isAlive = true;

			if (!isAlive) {
				Console.WriteLine("död");
			}

			if (!(myHeight < 0.50 || myHeight >= 3)) {
				// det här kan förenklas till (myHeight >= 0.50 && myHeight < 3)
				Console.WriteLine("vanliga stolar funkar");
			}

			double myDouble = 13.37;
			int myInt = (int)myDouble + 10; // typgjutning/casting då datatyperna är liknande (t.ex. båda är tal)

			string numberInput = Console.ReadLine();
			int convertedNumber = int.Parse(numberInput); // parsning vid konvertering från string

			bool continueRunning = true;

			while (continueRunning) {
				Console.WriteLine("hej");

				Console.WriteLine("Vill du fortsätta köra?");
				string continueRunningInput = Console.ReadLine();
				if (continueRunningInput == "nej") {
					continueRunning = false;
				}
			}

			// (initiering/startvärde; villkor; uppdatering)
			for (int i = 0; i <= 10; i++) {
				Console.WriteLine(i);
			}
			for (int i = 10; i >= 0; i--) {
				Console.WriteLine(i);
			}
			for (int i = 0; i <= 10; i += 2) {
				Console.WriteLine(i);
			}

			int[] scores = new int[5]; // array med 5 platser

			scores[0] = 13; // lägsta index är 0
			scores[1] = 47;
			scores[2] = 0;
			scores[3] = 100;
			scores[4] = 1000000; // högsta index är 1 lägre än antalet platser

			string[] favoriteFoods = new string[] { // om du anger värden från början behöver du inte ange antal platser
				"kebabpizza",
				"hjortronsylt",
				"blodpudding"
			};

			Console.WriteLine(favoriteFoods[0]);
			Console.WriteLine(favoriteFoods[1]);
			Console.WriteLine(favoriteFoods[2]);

			for (int i = 0; i < favoriteFoods.Length; i++) {
				Console.WriteLine(favoriteFoods[i]);
			}

			favoriteFoods[3] = "sprängd anka"; // indexet är utanför arrayen, arrayer kan inte ändra storlek

			List<bool> myBools = new List<bool>() {
				false, false, true, true, false, true, false
			};

			Console.WriteLine(myBools[3]);

			myBools.Add(false); // lägger till false i slutet av listan
			myBools.RemoveAt(3); // tar bort värdet vid index 3

			PrintHello(); // funktionsanrop

			int result = Add(3, 4);
			Console.WriteLine(result);

			Person person1 = new Person {
				firstName = "bla",
				lastName = "blablabla",
				age = 13
			};

			person1.firstName = "Hannes";
			Console.WriteLine(person1.lastName);

			Console.WriteLine(person1.firstName + " " + person1.lastName + " (" + person1.age + ")");


			for (int i = 0; i < 10; i++) {
				for (int j = 0; j < i; j++) {
					Console.Write('*');
				}
				Console.WriteLine();
			}

			int[,] intGrid = new int[9, 4];
			intGrid[0, 0] = 100;
			intGrid[8, 3] = -100;

			for (int y = 0; y < intGrid.GetLength(1); y++) {
				for (int x = 0; x < intGrid.GetLength(0); x++) {
					Console.Write(intGrid[x, y] + " ");
				}
				Console.WriteLine();
			}

			// samt användargränssnitt i någon form, t.ex. kommandosystem
		}

		static void PrintHello() { // funktionsdeklaration
			Console.WriteLine("Hello");
		}

		
		static int Add(int a, int b) { // funktionen kommer ta in två värden (a och b) av typen int = parametrar
			// ^
			// |
			// funktionen kommer kommer skicka tillbaka ett värde av typen int = retur
			return a + b;

			// retur ÄR INTE Console.WriteLine()
			// parameter ÄR INTE Console.ReadLine()
		}
	}
}
