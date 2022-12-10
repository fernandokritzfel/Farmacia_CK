/*
 * Creado por SharpDevelop.
 * Usuario: ferna
 * Fecha: 1/10/2022
 * Hora: 13:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace TP_Integrador
{
	class Program
	{
		public static void Main(string[] args)
		{
				/* Proyecto 4: 

				Una farmacia guarda información de las ventas de medicamentos realizadas dentro del último mes. 
				De cada venta se registra el nombre comercial del medicamento, droga, obra social (“particular “, si no fue comprado por 
				obra social),importe, código de vendedor, fecha y hora de venta (DateTime) y nro de ticket-factura. De cada empleado de 
				la farmacia se conoce su nombre y apellido, dni.

				Se deberá desarrollar una aplicación, utilizando las clases que crea necesarias, que resuelva las funcionalidades que 
				se muestran en el siguiente menú:
				
				a) Agregar una venta de medicamento  ✅
				
				b) Eliminar venta de medicamento por nro de ticket-factura. En caso de no existir venta con ese nro de ticket se debe
				levantar una excepción indicando lo ocurrido (“nro de ticket inválido”).✅
				
				
				c) Informar el porcentaje de ventas realizadas en la primer quincena  que hayan sido por obra social.✅
				
				d) Listar la cantidad de ventas realizadas por cada vendedor. ✅
				
				e) Agregar empleado ✅
				
				f) Borrar empleado ✅
				
				g) Listado de empleados✅ 
				
				h) Listado de medicamentos vendidos sin repeticiones (se obtiene a partir de las ventas)  */
				
				Farmacia farm;
				string nom;
				bool corte;
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("BIENVENIDO AL SISTEMA DE GESTION!");
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Ingrese el nombre de su farmacia: ");
				nom=Console.ReadLine();
				
				farm = new Farmacia(nom);
				
				Venta venta_1 = new Venta ("lotrial","enalapril","SWISS MEDICAL",130,0,1231,"20221115");
				Venta venta_2 = new Venta ("ibux","ibuprofeno","PARTICULAR",130,1,1232,"20221101");
				Venta venta_3 = new Venta ("alplax","alprazolam","PARTICULAR",130,2,1233,"20221117");
				Venta venta_4 = new Venta ("ibulgia","ibuprofeno","PARTICULAR",130,3,1235,"20221117");
				
				
				
				farm.agregarventa(venta_1);
				farm.agregarventa(venta_2);
				farm.agregarventa(venta_3);
				farm.agregarventa(venta_4);
				
				
				int increm_1 = 1;
				
				Empleado empleado_1 = new Empleado("anibal","lopez",12345123);	
				empleado_1.Cont_vta=empleado_1.Cont_vta+increm_1;
				Empleado empleado_2 = new Empleado("jose","perez",56789231);
				empleado_2.Cont_vta+=empleado_2.Cont_vta+increm_1;
				Empleado empleado_3 = new Empleado("mario","rodriguez",32456784);
				empleado_3.Cont_vta+=empleado_3.Cont_vta+increm_1;
				Empleado empleado_4 = new Empleado("alberto","martinez",30124532);
				empleado_4.Cont_vta+=empleado_4.Cont_vta+increm_1;
				
				farm.agregarEmpleado(empleado_1);
				farm.agregarEmpleado(empleado_2);
				farm.agregarEmpleado(empleado_3);
				farm.agregarEmpleado(empleado_4);
				
				corte = true;
				
				while(corte)
				{
					Console.BackgroundColor = ConsoleColor.Black;
					Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine();
				Console.WriteLine("MENU: ");
				Console.WriteLine();
 				Console.WriteLine("1 – Agrega Venta ");
 				Console.WriteLine("2 – Eliminar Venta ");
 				Console.WriteLine("3 – Porcentaje de ventas 1er quincena por Obra Social");
 				Console.WriteLine("4 - Ventas por empleado");
 				Console.WriteLine("5 – Agregar empleado");
 				Console.WriteLine("6 – Borrar empleado ");
 				Console.WriteLine("7 – Lista de empleados");
 				Console.WriteLine("8 – Listado de medicamentos vendidos ");
 				Console.WriteLine("0 – listado de ventas ");
 				Console.WriteLine("9 – Salir ");
 				Console.WriteLine();
 				Console.ForegroundColor = ConsoleColor.Magenta;
 				int opcion=int.Parse(Console.ReadLine());
 				Console.ForegroundColor = ConsoleColor.White;
 				Console.WriteLine();
 				
 					
				
 				switch(opcion){
 						case 0 :
 						ver_lista_ventas(farm);
 						break;
 						
 						case 1 :
 						agregarVta(farm);
 						break;
 						
 						case 2 :
 						Console.WriteLine("Ingrese numero de ticket-factura para eliminar la venta");
 						int ticket_fact;
 						ticket_fact = int.Parse(Console.ReadLine());
 						eliminarVenta(farm,ticket_fact);
 						break;
 						
 						case 3 :
 						porcentaje_vta_quincena_osocial(farm);
 						break;
 						
 						case 4 :
 						Cantidad_ventas_por_empleado(farm);
 						break;
 						
 						case 5 :
 						agregar_empleado(farm);
 						break;
 						
 						case 6 :
 						Console.WriteLine("Ingrese codigo de empleado para borrar: ");
 						int cod_emp = int.Parse(Console.ReadLine());
 						Borrar_empleado(farm,cod_emp);
 						break;
 						
 						case 7 :ver_lista_empleados(farm);
 						break;
 						
 						case 8 :medicamentos_vendidos(farm);
 						break;
 						
 						case 9 :
 						
 						Console.WriteLine("GRACIAS POR UTILIZAR EL SISTEMA CK®");
 						Console.WriteLine();
 						Console.WriteLine("HASTA LUEGO!");
 						
 						corte =false;
 						break;
 						
 				}
				}
		Console.ReadKey(true);
		}
		public static void agregarVta(Farmacia f){
			
			string nombrecom,droga,osocial,osocial1,fecha_vta;
			double importe;
			int num_vendedor,ticket_factura;
			
			
			Console.WriteLine ("Ingrese nombre comercial del medicamento: ");
			nombrecom = Console.ReadLine();
			Console.WriteLine ();
			
			Console.WriteLine ("Ingrese droga: ");
			droga = Console.ReadLine();
			Console.WriteLine ();
			
			Console.WriteLine ("Ingrese Obra Social o particular: ");
			osocial1 = Console.ReadLine();
			osocial = osocial1.ToUpper();
			
			Console.WriteLine ();
			
			Console.WriteLine ("Ingrese Importe: ");
			importe = double.Parse(Console.ReadLine());
			Console.WriteLine ();
			
			Console.WriteLine ("Ingrese Numero de vendedor: ");
			num_vendedor = int.Parse(Console.ReadLine());
			Console.WriteLine ();
			
			Console.WriteLine ("Ingrese Numero de ticket-factura: ");
			ticket_factura = int.Parse(Console.ReadLine());
			Console.WriteLine ();
			
			Console.WriteLine ("Ingrese fecha de la venta en formato: yyyyMMdd");

			fecha_vta = Console.ReadLine();
			
			
			Venta una_venta = new Venta (nombrecom, droga, osocial, importe,num_vendedor,ticket_factura, fecha_vta);
			
			ArrayList empleados = f.todosEmpleados();
			
			foreach(Empleado x in empleados){
				if(una_venta.Codvendedor==x.Codigo_empleado){
					int contador_venta = x.Cont_vta;
					int incremento = contador_venta+1;
					x.Cont_vta =incremento;
				}
			}
			
			f.agregarventa(una_venta);
			
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine ();
			Console.WriteLine (" ------------------------------------------------");
			Console.WriteLine ("| Venta AGREGADA correctamente [PRESIONE ENTER]  |");
			Console.WriteLine (" ------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.White;			
			Console.ReadKey(true);
			
			
		}
		
		public static void eliminarVenta(Farmacia f,int tkt){
				
			ArrayList conjVtas; ;
				conjVtas = f.todasVentas();
				int codigo_vend;
						
				foreach (Venta equis in conjVtas){
					try{
						bool encontro=true;
						if(equis.Numfactura==tkt && encontro){
							codigo_vend = equis.Codvendedor;
							f.eliminarventa(equis);
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine();
							Console.WriteLine (" ------------------------------------------------");
							Console.WriteLine ("| Venta ELIMINADA correctamente [PRESIONE ENTER]  |");
							Console.WriteLine (" ------------------------------------------------");
							Console.ForegroundColor = ConsoleColor.White;
							
						
							ArrayList empleados = f.todosEmpleados();
						
						foreach(Empleado x in empleados){
							if(codigo_vend==x.Codigo_empleado){
								int contador_venta = x.Cont_vta;
								int decremento = contador_venta-1;
								x.Cont_vta =decremento;
								break;
						
								}}
							encontro=false;
							break;
						}
						
						
						else{
							if(!encontro){
							throw new NoExisteTicket();}	
							}
							
						}
				
					
					catch(NoExisteTicket){
						Console.BackgroundColor=ConsoleColor.DarkRed;
						Console.ForegroundColor=ConsoleColor.DarkYellow;
						Console.WriteLine("Numero de ticket-factura invalido");
						Console.BackgroundColor=ConsoleColor.Black;
						Console.ForegroundColor=ConsoleColor.White;
						break;
					}
				}
							
						
							}
//		public static void eliminarVenta(Farmacia f, int tkt){
//			
//			ArrayList ventas = f.todasVentas();
//			int cod_vend=0;
//			foreach (Venta v in ventas)
//			{
//				try{
//					if(v.Numfactura==tkt){
//						cod_vend = v.Codvendedor;
//						f.eliminarventa(v);
//						Console.ForegroundColor = ConsoleColor.Red;
//							Console.WriteLine();
//							Console.WriteLine (" ------------------------------------------------");
//							Console.WriteLine ("| Venta ELIMINADA correctamente [PRESIONE ENTER]  |");
//							Console.WriteLine (" ------------------------------------------------");
//							Console.ForegroundColor = ConsoleColor.White;
//							break;
//					}
//					else{
//						throw new NoExisteTicket();
//					}
//				}
//				catch(NoExisteTicket){
//				Console.BackgroundColor=ConsoleColor.DarkRed;
//						Console.ForegroundColor=ConsoleColor.DarkYellow;
//						Console.WriteLine("Numero de ticket-factura invalido");
//						Console.BackgroundColor=ConsoleColor.Black;
//						Console.ForegroundColor=ConsoleColor.White;
//						break;
//				}
//				ArrayList empleados = f.todosEmpleados();
//			foreach (Empleado e in empleados) {
//				if(cod_vend == e.Codigo_empleado){
//					e.Cont_vta-=e.Cont_vta;
//			}
//			
////			ArrayList empleados = f.todosEmpleados();
////			foreach (Empleado e in empleados) {
////				if(cod_vend == e.Codigo_empleado){
////					e.Cont_vta-=e.Cont_vta;
//				}
//			}
//		}
		
		public static void porcentaje_vta_quincena_osocial(Farmacia far){
			
			ArrayList vtas = new ArrayList();
			vtas = far.todasVentas();
			int cantidad_vtas=0;
			int contador=0;
			int porcentaje = 0;
			
			foreach (Venta x in vtas){
				cantidad_vtas = cantidad_vtas+1;
				DateTime hoy = DateTime.Today;
				DateTime fe = x.Fecha_hora_vta;
				DateTime dia_uno = new DateTime(hoy.Year,hoy.Month,1);	
				DateTime dia_quince = new DateTime(hoy.Year,hoy.Month,15);
				//TimeSpan dif_fechas = hoy - fe;
				//int dif_dias = dif_fechas.Days;
				
				
				
				
				if(((fe>=dia_uno)&&(fe<=dia_quince)) && (x.Osocial!="PARTICULAR")){
					contador=contador+1;
					
				}
				
			}
			porcentaje = (contador*100)/cantidad_vtas;
			Console.WriteLine("EL PORCENTAJE DE VENTAS POR OBRA SOCIAL DE LA PRIMER QUINCENA ES: ");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(porcentaje+" %");
			
			
		}
		public static void agregar_empleado(Farmacia f){
			string nom,ape;
			int documento;
			Console.WriteLine("ingrese el nombre: ");
			nom = Console.ReadLine();
			Console.WriteLine ();
			
			Console.WriteLine("ingrese el apellido: ");
			ape = Console.ReadLine();
			Console.WriteLine ();
			
			Console.WriteLine("ingrese el numero de documento: ");
			documento = int.Parse(Console.ReadLine());
			Console.WriteLine ();
			
			
			
			
			Empleado un_empleado = new Empleado(nom,ape,documento);
			f.agregarEmpleado(un_empleado);
			
			
			
			
			
			Console.WriteLine ();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine (" --------------------------------------------------------------------------------");
			Console.WriteLine ("| Empleado: {0} {1} {2} {3} AGREGADO correctamente [PRESIONE ENTER]  |",un_empleado.Nombre,un_empleado.Apellido,un_empleado.Dni,un_empleado.Codigo_empleado);
			Console.WriteLine (" --------------------------------------------------------------------------------");
			
			
			Console.ReadKey(true);
			
		}
		
		public static void ver_lista_empleados(Farmacia f){
			ArrayList lista_empleados;
			lista_empleados = f.todosEmpleados();
			
			Console.WriteLine("EMPLEADOS:");
			Console.WriteLine();
			
			foreach(Empleado x in lista_empleados){
				
				Console.WriteLine("{0},{1}		{2}		Cod {3}",x.Nombre,x.Apellido,x.Dni,x.Codigo_empleado);
			}
			
			
		}
		
		public static void Cantidad_ventas_por_empleado(Farmacia f){
			ArrayList todos_empleados = new ArrayList();
			todos_empleados = f.todosEmpleados();
			
			foreach(Empleado x in todos_empleados){
				Console.WriteLine(x.Nombre.ToUpper()+" realizó "+x.Cont_vta+" ventas");
			}
		}
		public static void Borrar_empleado(Farmacia f, int cod_e){
			
			ArrayList empleados = f.todosEmpleados();
			
			ArrayList elementos_a_borrar = new ArrayList();
			
			foreach(Empleado x in empleados){
				if(x.Codigo_empleado==cod_e){
					elementos_a_borrar.Add(x);
				}
			}
			
			foreach(Empleado x in elementos_a_borrar){
				empleados.Remove(x);
			}
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine();
			Console.WriteLine (" ----------------------------------------------------");
			Console.WriteLine ("| Empleado ELIMINADO correctamente [PRESIONE ENTER]  |");
			Console.WriteLine (" ----------------------------------------------------");
			
			Console.ReadKey(true);

			
		}
		public static void medicamentos_vendidos(Farmacia f){
			
			ArrayList ventas = f.todasVentas();
			ArrayList ventas_sinrepe = new ArrayList();
			
			foreach (Venta  v in ventas) {
				if (ventas_sinrepe.Count == 0 ){
					ventas_sinrepe.Add(v.Nombre);
				}
				else{
					if (!ventas_sinrepe.Contains(v.Nombre)){
						ventas_sinrepe.Add(v.Nombre);
				}
				}}
			foreach (String n in ventas_sinrepe) {
				Console.WriteLine(n);
			
			}
		}
		public static void ver_lista_ventas(Farmacia f){
			ArrayList lista_ventas;
			lista_ventas = f.todasVentas();
			
			Console.WriteLine("VENTAS:");
			Console.WriteLine();
			
			foreach(Venta x in lista_ventas){
				
				Console.WriteLine("{0},{1}		{2}		Cod {3}    TICKET: {4}",x.Nombre,x.Droga,x.Importe,x.Codvendedor,x.Numfactura);
			}
			
			
		}
		
		
	}
	public class NoExisteTicket : Exception{
	}
	
	
}