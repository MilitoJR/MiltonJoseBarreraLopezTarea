create database ferreteria;
use ferreteria;
create table rol (
  id_rol int identity(1,1) primary key not null,
  nombre_rol varchar(20) unique not null
);
create table departamento(
	id_departamento int identity(1,1) primary key not null,
    nombre_departamento varchar(100) unique not null
);
create table municipio(
	id_municipio int identity(1,1) primary key not null,
    nombre_municipio varchar(100) unique not null
);
create table usuario(
	id_usuario int identity(1,1) primary key not null,
	nombre varchar(30),
	apellido varchar(30),
    id_rol int,
	usuario varchar(15) unique not null,
    estado varchar(50) not null,
	clave varchar(15) not null,
	direccion varchar(200),
	id_departamento int,
	id_municipio int,
	telefono int,
    foreign key (id_rol) references rol(id_rol),
    foreign key (id_departamento) references departamento(id_departamento),
	foreign key (id_municipio) references municipio(id_municipio)
);
create table categoria(
	id_categoria int identity(1,1) primary key not null,
    nombre_categoria varchar(100) unique not null
);
create table proveedor(
	id_proveedor int identity(1,1) primary key not null,
    nombre_proveedor varchar(50) unique not null,
    nombre_contacto varchar(50) not null,
    id_departamento int not null,
	id_municipio int not null,
    telefono int ,
    foreign key (id_departamento) references departamento(id_departamento),
	foreign key (id_municipio) references municipio(id_municipio)
);
create table presentacion(
	id_presentacion int identity(1,1) primary key not null,
    nombre_presentacion varchar(50) unique not null
);
create table marca(
	id_marca int identity(1,1) primary key not null,
    nombre_marca varchar(50) unique not null,
    id_proveedor int not null,
    foreign key (id_proveedor) references proveedor(id_proveedor)
);
create table producto(
	id_producto int identity(1,1) primary key not null,
    nombre_producto varchar(100) not null,
    id_marca int not null,
    cantidad int not null,
    id_presentacion int not null,
    descripcion varchar(100),
    precio_compra decimal not null,
    precio_venta decimal  not null,
    id_categoria int not null,
    id_proveedor int not null,
    foreign key (id_proveedor) references proveedor(id_proveedor),
	foreign key (id_marca) references marca(id_marca),
    foreign key (id_categoria) references categoria(id_categoria),
    foreign key (id_presentacion) references presentacion(id_presentacion)
);

create table pago(
id_pago int identity(1,1) primary key not null,
metodo_pago varchar(100) not null
);

create table venta(
	id_venta int identity(1,1) primary key not null,
    id_producto int not null,
    cantidad_venta int not null,
    id_pago int not null,
    total decimal not null,
    foreign key (id_producto) references producto(id_producto),
    foreign key (id_pago) references pago(id_pago)
);


