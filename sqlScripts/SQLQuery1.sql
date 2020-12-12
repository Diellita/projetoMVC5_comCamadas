
create table Usuarios(
Id INT IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR (300) null,
Email VARCHAR(200) null,
ConfEmail VARCHAR(200)null,
Senha VARCHAR (255) null,
ConfSenha VARCHAR (255) null

)

drop table Usuarios

delete Usuarios where id = 1

select * from Usuarios

insert into Usuarios (Nome,Email,ConfEmail,Senha,ConfSenha) values ()