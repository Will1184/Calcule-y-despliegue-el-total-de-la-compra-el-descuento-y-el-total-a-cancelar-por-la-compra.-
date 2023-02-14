Algoritmo Una_tienda_vende_Agua_embotellada_en_garrafones_de_5_galones_a_un_precio_de_2_50_la_unidad_Calcule_y_despliegue_el_total_de_la_compra_el_descuento_y_el_total_a_cancelar_por_la_compra
	PRECIO_UNIDAD =2.50
	definir cantidadCompra,totalDeCompra,descuento,totalSinDescuento Como Real
	Escribir  "Ingrese cantidad de garrafones de agua a comprar"
	Leer cantidadCompra
	
	si cantidadCompra>10 Y cantidadCompra<=30
		totalSinDescuento=cantidadCompra*PRECIO_UNIDAD
		descuento=totalSinDescuento*(10.0/100.0)
		totalDeCompra=totalSinDescuento-descuento
		
		escribir "El Total de la compra es:$ ",totalSinDescuento
		escribir "El descuento del 10% en la compra es:$ ",descuento
		escribir "El total a pagar es:$ ",totalDeCompra
		
		
	FinSi
	si cantidadCompra>30 
		totalSinDescuento=cantidadCompra*PRECIO_UNIDAD
		descuento=totalSinDescuento*(30.0/100.0)
		totalDeCompra=totalSinDescuento-descuento
		
		escribir "El Total de la compra es:$ ",totalSinDescuento
		escribir "El descuento del 10% en la compra es:$ ",descuento
		escribir "El total a pagar es:$ ",totalDeCompra
		
		
	FinSi
	si cantidadCompra<=10
		totalSinDescuento=cantidadCompra*PRECIO_UNIDAD
		descuento=0
		totalDeCompra=totalSinDescuento-descuento
		
		escribir "El Total de la compra es:$ ",totalSinDescuento
		escribir "El descuento del 10% en la compra es:$ ",descuento
		escribir "El total a pagar es:$ ",totalDeCompra
		
		
	FinSi
	
	
FinAlgoritmo
