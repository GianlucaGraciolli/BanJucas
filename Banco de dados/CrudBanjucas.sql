use BanjucasDkt

insert into Cliente
values ('Rogerin querô','23496834052',null,'13981777435','rogerinzika@hotmail.com','rua jornalista donato ribeiro','343','11530190','Cubatão','SP','Masculino','06/12/2002',10000,'061202')

insert into Conta
values (2,500,20,'Corrente','Ativa','03/09/2009',5000,'000000')

create procedure ps_ValidarLogin
@cpf char (11),
@senhaLogin char (06)
as 
select * from cliente
where cpf = @cpf and senhaLogin = @senhaLogin

exec ps_ValidarLogin 

create procedure ps_buscaContasPorIdCliente
@idcliente int
as
select * from conta
where idcliente = @idcliente

exec ps_buscaContasPorIdCliente 1

create procedure pi_Cliente 
@nome varchar (120),
@cpf char (11),
@rg char (9),
@celular varchar (20),
@email varchar (200),
@logradouro varchar (200),
@numerologradouro varchar (5),
@cep char (8),
@cidade varchar (30),
@estado char (2),
@genero varchar (20),
@datanasc datetime,
@renda numeric (10,2),
@senhalogin char (6)
as 
insert into Cliente
values (@nome,@cpf,@rg,@celular,@email,@logradouro,@numerologradouro,@cep,@cidade,@estado,@genero,@datanasc,@renda,@senhalogin)

exec pi_Cliente ('baixo é ele','12345678900',null,'13921392193','baixo.baixola@senac.edu','rua do pequeno','30312','11290845','baixos','pequenote',''

select * from Cliente

/*criar conta*/
create procedure pi_Conta
@idcliente int,
@aberturaconta datetime,
@saldo numeric(10,2),
@statusconta varchar(10),
@tipoconta varchar(30),
@limite numeric(10,2),
@senhaconta char(8)
as
insert into conta (idcliente,aberturaconta,saldo,statusConta,tipoconta,limite,senhaconta)
values (@idcliente,@aberturaconta,@saldo,@statusConta,@tipoconta, @limite, @senhaconta)
select @@identity as 'ultimoID'

create procedure pu_AlterarSenha
@idCliente int,
@senhaLogin char (6)
as
update Cliente
set senhaLogin = @senhaLogin
where idCliente = @idCliente	

exec pu_AlterarSenha 1,'000000'

create procedure ps_ValidarSenhaConta
@idconta int,
@senhaConta char (6)
as
select * from Conta
where idconta = @idconta and senhaConta = @senhaConta

exec ps_AlterarContas 2,'000000'

drop procedure ps_AlterarContas
