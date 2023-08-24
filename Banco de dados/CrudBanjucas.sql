use BanjucasDkt

insert into Cliente
values ('Rogerin querô','23496834052',null,'13981777435','rogerinzika@hotmail.com','rua jornalista donato ribeiro','343','11530190','Cubatão','São Paulo','Masculino','06/12/2002',10000,'061202')

create procedure ps_ValidarLogin
@cpf char (11),
@senhaLogin char (06)
as 
select * from cliente
where cpf = @cpf and senhaLogin = @senhaLogin