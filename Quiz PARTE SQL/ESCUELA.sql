Create Table School
(
SchoolID int identity primary key,
SchoolName varchar(100)not null,
Descripcion varchar(1000),
Addres varchar(100),
Phone varchar(50),
PostCode varchar(50),
PostAddress varchar(50),
)

Create Table Class
(
ClassID int identity primary key,
SchoolID int foreign key references School (SchoolID)not null,
ClassName varchar(50)not null,
Descripcion varchar (1000),
)

------------PROCEDIMIENTOS ALMACENADOS------------SCHOOL------
--AGREGAR
Create procedure AddSchool
@SchoolName varchar(100),
@Descripcion varchar(1000),
@Addres varchar(100),
@Phone varchar(50),
@PostCode varchar(50),
@PostAddress varchar(50)

as
begin
insert into School values (@SchoolName, @Descripcion, @Addres, @Phone, @PostCode, @PostAddress)
end

--BORRAR
Create procedure DelSchool
@SchoolID int

as
begin
delete School where SchoolID=@SchoolID
end

--CONSULTAR
Create procedure ConsultarSchool
@SchoolID int
as
begin
select SchoolID, SchoolName from School where SchoolID=@SchoolID
end


--MODIFICAR
create procedure ModifSchool
@SchoolID int,
@SchoolName varchar(100),
@Descripcion varchar(1000),
@Addres varchar(100),
@Phone varchar(50),
@PostCode varchar(50),
@PostAddress varchar(50)

as
begin
update School set SchoolName =@SchoolName, Descripcion=@Descripcion, Addres=@Addres, Phone=@Phone, PostCode=@PostCode, PostAddress=@PostAddress where SchoolID =@SchoolID
end

------------PROCEDIMIENTOS ALMACENADOS------------CLASS------
--AGREGAR
create procedure AddClass
@SchoolID int,
@ClassName varchar(50),
@Descripcion varchar(1000)
as
begin
insert into Class values (@SchoolID, @ClassName, @Descripcion)
end

--BORRAR
create procedure DelClass
@ClassID int

as
begin
delete Class where ClassID=@ClassID
end

--CONSULTAR
Create procedure ConsultarClass
@ClassID int
as
begin
select ClassID, ClassName from Class where ClassID = @ClassID
end

--MODIFICAR
Create procedure ModifClass
@ClassID int,
@SchoolID int,
@ClassName varchar(50),
@Descripcion varchar(1000)
as
begin
update Class set SchoolID =@SchoolID, ClassName=@ClassName, Descripcion=@Descripcion where ClassID =@ClassID
end

Select *from Class