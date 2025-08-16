--creacion de la base de datos--
Create Database db_Restaurante

use db_restaurante;

--Creacion de la Tabla --
create table tbl_Pedidos
(
  CodigoPedido int primary key identity (1,1) not null,
  Fecha DateTime,
  Cantidad int,
  MenuProducto Varchar(25),
  Precio Decimal(10,2),
  PrecioTotal Decimal(10,2),
  Propina Decimal(10,2),
  TotalPedido Decimal(10,2)
);

--Scrip selecionar Tabla 
select * from tbl_Pedidos;
