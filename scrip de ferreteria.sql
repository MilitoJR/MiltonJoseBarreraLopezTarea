USE ferreteria;

INSERT INTO categoria( nombre_categoria)VALUES('CAMPIN');


INSERT INTO departamento(nombre_departamento)VALUES('Chalatenango');

INSERT INTO marca(nombre_marca,id_proveedor)VALUES('STIHL','4');

INSERT INTO municipio(nombre_municipio)VALUES('San Miguel de Mercedes');

INSERT INTO pago(metodo_pago)VALUES('Credito');

INSERT INTO presentacion( nombre_presentacion)VALUES('Llevar');

INSERT INTO producto
(nombre_producto,cantidad,descripcion,precio_compra,precio_venta,id_categoria,id_proveedor,id_marca,id_presentacion)
VALUES('Motocierra','1','MOTOCIERRA STIHL, motor;150cc, gasolina-aceite,color:naranja','250','400','1','4','6','1');

INSERT INTO proveedor
(nombre_proveedor,nombre_contacto,telefono,id_departamento,id_municipio)
VALUES('Yamaha','JOSE','23578612','1','1');

INSERT INTO rol
(nombre_rol)
VALUES('INGENIERO');

INSERT INTO usuario
(nombre,apellido,id_rol,usuario,estado,clave,direccion,id_departamento,id_municipio,telefono)
VALUES('Milton','Barrera','1','admin','Soltero','123','Barrio El Centro CH','1','1','23546123');

INSERT INTO venta
(id_producto,cantidad_venta,id_pago,total)
VALUES('7','1','1','450.00');