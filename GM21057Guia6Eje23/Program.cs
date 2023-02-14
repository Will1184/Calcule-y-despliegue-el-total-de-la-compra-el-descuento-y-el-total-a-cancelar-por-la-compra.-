/*
 * Creado por SharpDevelop.
 * Usuario: BRANDON
 * Fecha: 26/3/2022
 * Hora: 16:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
// Guía:6
// Ejercicio:23
// Fecha: 26/3/2022
// Autor: Brandon William Gomez Monge
// Carnet: GM21057
// GD: #12
// Instructora: Lizeth Carmeline Gochez De Peñate

namespace GM21057Guia6Eje23
{
	//Descripcion del programa:
	/*Una tienda vende Agua embotellada en garrafones de 5 galones, a un precio de $2.50 la unidad. Si 
      la compra es de 10 ó menos unidades no se hace descuento, pero si es de más de 10 unidades, las 
      primeras 10 cuestan el precio establecido, las demás tienen un 10% de descuento. Si la compra es
      mayor de 30, obtiene un 30% de descuento, tomando como base el precio establecido, 
      exclusivamente sobre las que pasen de 30. Dado el número de unidades que compra un cliente, 
      calcule y despliegue el total de la compra, el descuento, y el total a cancelar por la compra.*/

	class Program
	{
		const double PRECIO_UNIDAD =2.50;
		public static void Main(string[] args)
		{
	    //Identificacion del programa en pantalla
		Console.Title=("Una tienda vende Agua embotellada en garrafones de 5 galones, a un precio de $2.50 la unidad. Calcule y despliegue el total de la compra, el descuento, y el total a cancelar por la compra. ");
		Console.WriteLine("Una tienda vende Agua embotellada en garrafones de 5 galones, a un precio de $2.50 la unidad. Calcule y despliegue el total de la compra, el descuento, y el total a cancelar por la compra. ");
		Console.WriteLine("Autor:Brandon Gomez");
	    
	    
		//DECLARACION DE VARIABLES
		double cantidadCompra,totalDeCompra,descuento,totalSinDescuento;
		
		//ENTRADA DE DATOS
		Console.WriteLine("Ingrese cantidad de garrafones de agua a comprar"); cantidadCompra=double.Parse(Console.ReadLine());
		Console.WriteLine("------------------------------------------------");
		
        //PROCESO DE DATOS
        if (cantidadCompra>10 && cantidadCompra<=30)
        {
         totalSinDescuento=cantidadCompra*PRECIO_UNIDAD;
         descuento=totalSinDescuento*(10.0/100.0);
         totalDeCompra=totalSinDescuento-descuento;
         //SALIDA DE DATOS
         Console.WriteLine("El Total de la compra es:$ "+totalSinDescuento);
         Console.WriteLine("El descuento del 10% en la compra es:$ "+descuento);
         Console.WriteLine("El total a pagar es:$ "+totalDeCompra);
        }
        
        
        if (cantidadCompra>30)
        {
         totalSinDescuento=cantidadCompra*PRECIO_UNIDAD;
         descuento=totalSinDescuento*(30.0/100.0);
         totalDeCompra=totalSinDescuento-descuento;
         //SALIDA DE DATOS
         Console.WriteLine("El Total de la compra es:$ "+totalSinDescuento);
         Console.WriteLine("El descuento del 30% en la compra es: "+descuento);
         Console.WriteLine("El total a pagar es:$ "+totalDeCompra);
        }
        
        
        if(cantidadCompra<=10)
        {
         totalSinDescuento=cantidadCompra*PRECIO_UNIDAD;
         descuento=0;
         totalDeCompra=totalSinDescuento-descuento;
         //SALIDA DE DATOS
         Console.WriteLine("El Total de la compra es :$ "+totalSinDescuento);
         Console.WriteLine("El descuento en la compra es:${0} No hay descuento",descuento);
         Console.WriteLine("El total a pagar es:$ "+totalDeCompra);
        }
		
		//SALIDA DE DATOS
		
		
		Console.ReadKey();
		}
	}
}