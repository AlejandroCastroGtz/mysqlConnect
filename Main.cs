using System;

namespace mysqlConnect
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int menu;
			string nombre;
			string telefono,id;
			Alumnos alumnos = new Alumnos();
			do{
			Console.WriteLine("\n1.-Insertar\n2.-Ver\n3.-Editar\n4.-Eliminar\n5.-Salir\n");
				menu=int.Parse(Console.ReadLine());
			switch(menu){
				case 1: 
					Console.WriteLine("Nombre: ");
					nombre=Console.ReadLine();
					Console.WriteLine("Telefono: ");
					telefono=Console.ReadLine();
					Console.WriteLine("ID: ");
					id=Console.ReadLine();
					alumnos.insertarRegistroNuevo(nombre,telefono,id);
					nombre="";
					telefono="";
					id="";
				break;
				
				case 2: alumnos.mostrarTodos();
		
				break;
				
				case 3: 
				Console.WriteLine("\n1-Nombre\n2-Telefono\n3-Salir\n");
				int menu2 = int.Parse(Console.ReadLine());
				switch(menu2){
						case 1 :
							Console.WriteLine("id: ");
							id=Console.ReadLine();
							Console.WriteLine("Nombre a modificar: ");
							nombre=Console.ReadLine();
							alumnos.editarNombreRegistro(id,nombre);
							break;
						case 2 :Console.WriteLine("id: ");
							id=Console.ReadLine();
							Console.WriteLine("Telefono a modificar: ");
							telefono=Console.ReadLine();
							alumnos.editarTelefonoRegistro(id,telefono);
							break;
				}
							break;
				
				case 4:
					Console.WriteLine("id: ");
					id=Console.ReadLine();
					alumnos.eliminarRegistroPorId(id);
					break;
			}
			}while(menu != 5);
			
		}
	}
}

