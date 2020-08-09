go
Create database Taxeria
go
use Taxeria
go
CREATE TABLE chofer
(
	id_chofer int primary key,
    nombre varchar(15) not null,
    apellidos varchar(40),
    edad int not null,
    licencia int not null unique,
);
go
alter table chofer add constraint ck_edad check (edad>=18);
go
CREATE TABLE carro
(
	id_carro int primary key,
    marca varchar(20) not null,
    modelo varchar(20) not null,
    año int not null,
	color varchar(10)
);
go
alter table carro add constraint ck_modelo check(año>=2010);
go
CREATE TABLE chofer_carro
(
	id_chofer int  constraint fk_id_chofer foreign key(id_chofer) references chofer(id_chofer),
	id_carro int constraint fk_id_carro foreign key(id_carro) references carro(id_carro),
	hora datetime not null,
	constraint pk_chofer_carro primary key(id_chofer,hora)
);
go
/*Insertando algunos datos*/
insert into chofer values(1,'Rayner','Abad Paredes',18,100);
go
insert into chofer values(2,'Lexica','Paredes',22,101);
go
insert into carro values(1,'Toyota','Camry',2011,'Gris');
go
insert into carro values(2,'Honda','Civic',2014,'Rojo');
go
insert into carro values(3,'Mercedes','CLA ',2015,'Negro');
go
insert into carro values(4,'Mini','Cooper S',2014,'Azul');
go
insert into chofer_carro values (1,1,'20131124 17:15:10');
go
insert into chofer_carro values (1,4,'20200426 18:35:59');
go
insert into chofer_carro values (1,3,'20200130 20:56:59');
go
insert into chofer_carro values (2,3,'20201031 11:11:11');
go

select * from chofer_carro order by id_chofer; 
select * from chofer; 
select * from carro; 
go
truncate table chofer
truncate table carro