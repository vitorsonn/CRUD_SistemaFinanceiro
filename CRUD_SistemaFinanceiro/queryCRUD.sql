create database lancamentosBD
go
use lancamentosBD
go

create login usuario with password = 'senha';
create user usuario from login usuario;

exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';


create table lancamentos(
id int identity not null primary key,
descricao varchar(30) not null,
valor decimal(12,2) not null,
dataLancamento date default getdate(),
tipo varchar(9) CHECK (tipo IN ('entrada', 'saida')) NOT NULL
);

select * from lancamentos