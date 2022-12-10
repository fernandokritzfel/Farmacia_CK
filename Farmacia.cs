/*
 * Creado por SharpDevelop.
 * Usuario: ferna
 * Fecha: 1/10/2022
 * Hora: 13:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace TP_Integrador
{
	/// <summary>
	/// Description of Farmacia.
	/// </summary>
	public class Farmacia
	{
		//ATRIBUTOS
		
		private ArrayList listaventa;
		private ArrayList listaempleado;
		private string nombrefarma;
		
		//CONSTRUCTOR
		public Farmacia(string name)
		{
			listaventa = new ArrayList();
			listaempleado = new ArrayList();
			this.nombrefarma = name;
		}
		
		//METODOS
		public void agregarventa(Venta unaventa)
		
		{
			listaventa.Add(unaventa);
		}
		
		
		public void eliminarventa(Venta unaventa)
			
		{
			listaventa.Remove(unaventa);
		}
		
		
		public int cantidad_ventas()
		
		{
			return listaventa.Count;
		}
		
		public bool existeVenta(Venta unaventa)
		{
			return listaventa.Contains(unaventa);
		}
		
		
		public Venta verVenta(int i)
		
		{
			return (Venta) listaventa[i];
		}
		
		
		public ArrayList todasVentas()
		
		{
			return listaventa;
		}
		
	
		
		public void agregarEmpleado(Empleado un_empleado)
		
		{
			listaempleado.Add(un_empleado);
		}
		
		public void borrarEmpleado(Empleado un_empleado)
		
		{
			listaempleado.Remove(un_empleado);
		}
		
		public int cantidad_empleados()
		
		{
			return listaempleado.Count;
		}
		
		public bool existeEmpleado(Empleado un_empleado)
		{
			return listaempleado.Contains(un_empleado);
		}
		
		public Empleado verEmpleado(int i)
		
		{
			return (Empleado) listaempleado[i];
		}
		
		public ArrayList todosEmpleados()
		
		{
			return listaempleado;
		}
	}
}
