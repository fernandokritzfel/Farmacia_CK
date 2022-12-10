/*
 * Creado por SharpDevelop.
 * Usuario: ferna
 * Fecha: 1/10/2022
 * Hora: 13:54
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace TP_Integrador
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado
	{
		
		/*De cada empleado de la farmacia se conoce su nombre y apellido, dni*/
		
		//ATRIBUTOS
		
		private string nombre,apellido;
		private int dni;
		private int cont_vta;
		private int codigo_Empleado;
		private int cod_emp;
		private static int contador_objetos=0;
		
		
		//CONSTRUCTOR
		public Empleado(string nom,string ape,int doc)
		{
			this.nombre = nom;
			this.apellido = ape;
			this.dni = doc;
			this.cont_vta = 0;
			this.cod_emp = contador_objetos++;
			this.codigo_Empleado=cod_emp;
			
			
		}
		
		
		//PROPIEDADES
		
		public string Nombre{
			set{
				nombre = value;
			}
			get{
				return nombre;
			}
		}
		
		public string Apellido{
			set{
				apellido = value;
			}
			get{
				return apellido;
			}
		}
		
		public int Dni{
			set{
				dni = value;
			}
			get{
				return dni;
			}
		}
		public int Cont_vta{
			set{
				cont_vta = value;
			}
			get{
				return cont_vta;
			}
		}
		public int Codigo_empleado{
			
			get{
				return codigo_Empleado;
			}
		}
		
	}
}
