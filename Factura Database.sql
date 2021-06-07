Create Database Factura;
Go
use Factura
Go


create table Clientes --
(ID_Cliente INT IDENTITY (1,1) primary key NOT NULL,
Nom_Cliente varchar(50) not null,
Apellido varchar (50) not null,
Telefono nvarchar (20) not null,
Cedula nvarchar(20) not null,
Activo int not null
)

Create table Suplidor -- 
(Cod_Supli int primary key identity(1,1) not null,
Compañia varchar (50) NOT NULL,
Representante varchar (50) NOT NULL,
Telefono nvarchar (20) NOT NULL,
Activo int NOT NULL
);

Create table Forma_de_pago --
(ID_FP INT IDENTITY (1,1) primary key NOT NULL,
Forma_Pago int NOT NULL --0 efectivo 1 tarjeta
);

Create table Clasificacion 
(Cod_Cla INT IDENTITY (1,1) primary key NOT NULL,
Clasificacion varchar (100) not null);

 create table Productos --
 (ID_Pro INT IDENTITY (1,1) primary key NOT NULL,
 Nom_Pro varchar (50) NOT NULL,
 Precio float NOT NULL,
 Precio_Venta float not null,
 Cantidad int NOT NULL,
 Cod_Cla int foreign key references Clasificacion(Cod_Cla) not null,
 Cod_Supli int foreign key references Suplidor(Cod_Supli) NOT NULL,
 Activo int NOT NULL
 );

create table Compras --
(Cod_Comp INT IDENTITY (1,1) primary key NOT NULL,
Cod_Supli int foreign key references Suplidor(Cod_Supli) NOT NULL,
ID_FP int foreign key references Forma_de_pago(ID_FP) NOT NULL,
Fecha_Compra varchar(100) NOT NULL
);

create table Detalles_Compras --
(Cod_DC INT IDENTITY (1,1) primary key NOT NULL,
Cod_Comp INT FOREIGN KEY REFERENCES Compras(Cod_Comp) ON DELETE CASCADE not null , 
ID_Pro int foreign key references Productos(ID_Pro) not null,
Cantidad int not null,
)

CREATE TABLE USUARIOS( --
ID_Usuario INT IDENTITY (1,1) primary key NOT NULL,
Usuario varchar(50) not null,
Contraseña varchar (20) not null,
ID_Empleado int not null,
Tipo int not null, -- admin 0 , factura 1, almacen 2
Activo int not null
)

CREATE TABLE FACTURA(
ID_Factura INT IDENTITY (1,1) primary key NOT NULL,
ID_Usuario int Foreign key references USUARIOS(ID_Usuario) not null,
ID_Cliente INT FOREIGN KEY REFERENCES Clientes(ID_Cliente) NOT NULL,
FECHA_COMPRA VARCHAR(100) NOT NULL,
ID_FP INT FOREIGN KEY REFERENCES Forma_de_pago(ID_FP) NOT NULL
)

Create table Detalles_Factura --
(Cod_DF INT IDENTITY (1,1) primary key NOT NULL,
ID_Pro int Foreign key references Productos(ID_Pro) NOT NULL,
Cod_Fact int Foreign key references FACTURA(ID_Factura) ON DELETE CASCADE NOT NULL,
Cantidad int NOT NULL
)
GO

Create PROC GENERAL_BILL
@id int
as
SELECT F.ID_Factura, U.Usuario, C.Nom_Cliente + ' ' + C.Apellido As Cliente, F.FECHA_COMPRA, F.ID_FP 
FROM FACTURA F 
INNER JOIN USUARIOS U ON F.ID_Usuario = U.ID_Usuario 
INNER JOIN Clientes C ON F.ID_Cliente = C.ID_Cliente
WHERE F.ID_Factura = @id
GO

exec GENERAL_BILL @id = 1
Go

CREATE PROC BILL_DETAILS
@id_bill int
as
SELECT DF.ID_Pro, P.Nom_Pro, P.Precio_Venta, DF.Cantidad, (P.Precio_Venta * DF.Cantidad) AS 'TOTAL'
FROM Detalles_Factura DF
INNER JOIN Productos P ON DF.ID_Pro = P.ID_Pro
INNER JOIN FACTURA F ON DF.Cod_Fact = F.ID_Factura
WHERE F.ID_Factura = @id_bill
GO

--Reporte a Clientes: Datos Personales, todas las facturas, cantidad de dinero en compras  

CREATE PROC REPORT_CUSTOMER
@id_customer int
as
SELECT A.Codigo, A.Nombre, A.Cedula, A.Telefono, B.TOTAL FROM 
(SELECT C.ID_Cliente AS 'Codigo', C.Nom_Cliente + ' ' + C.Apellido AS 'Nombre', C.Cedula, C.Telefono
FROM Clientes C
WHERE C.ID_Cliente = @id_customer) A
INNER JOIN 
(SELECT SUM(DF2.Cantidad * P2.Precio_Venta) AS 'TOTAL', C2.ID_Cliente FROM Detalles_Factura DF2
LEFT JOIN Productos P2 on DF2.ID_Pro = P2.ID_Pro
INNER JOIN FACTURA F2 ON DF2.ID_Pro = F2.ID_Factura
INNER JOIN Clientes C2 ON F2.ID_Cliente = C2.ID_Cliente
WHERE C2.ID_Cliente = @id_customer 
GROUP BY C2.ID_Cliente)B ON A.Codigo = B.ID_Cliente

exec REPORT_CUSTOMER @id_customer = 1
go
--ahora que lo pienso, esta query pudo haber sido mas sencilla, pero na

--Reporte a Suplidores: Datos de la institucion, todos los productos comprados a la institucion (solo nombres),
--cantidad de dinero gastado en ese suplidor HAY UN BOBO CON ESTO, DE PODER HACERSE SE PUEDE, PERO NO SE SI SERIA UTIL
--DEBIDO A QUE EN EL MOMENTO QUE LE PRESENTES A JOHANNA LA POSIBILIDAD DE SABER CUANTO DINERO LA EMPRESA GASTO EN UN SUPLIDOR,
--ELLA QUERRA SABER CUANTO DINERO LA EMPRESA GASTO POR PRODUCTO, Y POR ENDE, TANTO LA QUERY COMO EL DISEñO SERIAN MUCHO MAS COMPEJOS
--LO QUE PODEMOS HACER EN SUSTITUCION ES EL PRODUCTO MAS COMPRADO AL SUPLIDOR. TE PARECE?

CREATE PROC REPORT_SUPPLIER
@id_supplier int
as
SELECT S.Cod_Supli AS Codigo, S.Compañia, S.Representante, S.Telefono, P.Nom_Pro AS 'PRODUCTO MAS COMPRADO', SUM(DC.Cantidad) AS 'CANTIDAD DE VECES COMPRADO'
FROM Suplidor S
INNER JOIN Productos P ON S.Cod_Supli = P.Cod_Supli
INNER JOIN Detalles_Compras DC ON P.ID_Pro = DC.ID_Pro
INNER JOIN Compras C ON DC.Cod_Comp = C.Cod_Comp
--WHERE C.Cod_Supli = @id_supplier
GROUP BY S.Cod_Supli, S.Compañia, S.Representante, S.Telefono, P.Nom_Pro
ORDER BY SUM(DC.Cantidad) DESC


SELECT C.Cod_Comp, S.Cod_Supli, S.Compañia, S.Representante, C.Fecha_Compra, C.ID_FP
FROM Compras C 
INNER JOIN Suplidor S ON C.Cod_Supli = S.Cod_Supli

SELECT P.Nom_Pro, (SUM(DF.Cantidad)) AS 'Cantidad de veces vendido' FROM Productos P
INNER JOIN Detalles_Factura DF ON P.ID_Pro = DF.ID_Pro
WHERE P.Cod_Supli = 1
Group BY P.Nom_Pro

EXEC REPORT_CUSTOMER @id_customer = 1

--DIABLO ME BURLE HAHHAHAHHA ME SALIO DE UNAAAAA, HACE TIEMPO NO ME PASABA :))))))))))))))))))))

EXEC BILL_DETAILS @id_bill = 3

select * from Detalles_Factura
select * from Detalles_Compras

EXEC REPORT_SUPPLIER @id_supplier = 3

SELECT P.ID_Pro as Codigo, P.Nom_Pro as Producto, ((COUNT(DF.ID_Pro)) * SUM(DF.Cantidad)) AS 'Cantidad de veces vendido' FROM Productos P INNER JOIN Detalles_Factura DF ON P.ID_Pro = DF.ID_Pro WHERE P.Cod_Supli = 2 Group BY P.Nom_Pro, P.ID_Pro

