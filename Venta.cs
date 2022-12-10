/*
 * Creado por SharpDevelop.
 * Usuario: ferna
 * Fecha: 1/10/2022
 * Hora: 13:54
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_Integrador
{
	/// <summary>
	/// Description of Venta.
	/// </summary>
	public class Venta
	{
			/*nombre comercial del medicamento, droga, obra social (“particular “, si no fue comprado por 
			obra social),importe, código de vendedor, fecha y hora de venta (DateTime) y nro de ticket-factura*/
			
			
		
			
		//ATRIBUTOS
		
		private string nombre,droga,osocial;
		private double importe;
		private int codvendedor,numfactura;
		private DateTime fecha_hora_vta;
		
		//CONSTRUCTOR
		
		public Venta(string nom,string drog,string obrasoc,double imp,int vend,int fact,string fechayhora)
		{
			nombre = nom;
			droga = drog;
			osocial = obrasoc;
			importe = imp;
			
			fecha_hora_vta = convierte_a_date(fechayhora);
			codvendedor = vend;
			numfactura = fact;
			
			
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
		
		public string Droga{
			set{
				droga = value;
			}
			get{
				return droga;
			}
		}
		
		public string Osocial{
			set{
				osocial = value;
			}
			get{
				return osocial;
			}
		}
		
		public double Importe{
			set{
				importe = value;
			}
			get{
				return importe;
			}
		}
		
		public int Codvendedor{
			set{
				codvendedor = value;
			}
			get{
				return codvendedor;
			}
		}
		
		public int Numfactura{
			set{
				numfactura = value;
			}
			get{
				return numfactura;
			}
		}
		
		public DateTime Fecha_hora_vta{
			set{
				fecha_hora_vta = value;
			}
			get{
				return fecha_hora_vta;
			}
		}
		private DateTime convierte_a_date(string fech){
			DateTime fecha_ok = DateTime.ParseExact(fech,"yyyyMMdd",null);
			return fecha_ok;
		}
	}
}
