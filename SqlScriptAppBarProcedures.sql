alter procedure sp_insert_clase
@descripcion nvarchar(50),
@abreviatura nvarchar(50),
@grupo int
as
insert into
	CLASE
values
	(@descripcion,@abreviatura,'A',@grupo)
-------------------------------------------------------------
alter procedure sp_update_clase
@codigo int,
@descripcion nvarchar(50),
@abreviatura nvarchar(50)
as
update
	CLASE
set
	descripcion=@descripcion,
	abreviatura=@abreviatura
where
	codigo=@codigo
-------------------------------------------------------------
alter procedure sp_delete_clase
@codigo int
as
update
	CLASE
set
	status='E'
where
	codigo=@codigo
-------------------------------------------------------------

alter procedure sp_insert_tipo
@codClase int,
@descripcion nvarchar(50),
@abreviatura nvarchar(50)
as
insert into
	TIPO
values
	(@codClase,@descripcion,@abreviatura,'A')
-------------------------------------------------------------
alter procedure sp_update_tipo
@codigo int,
@descripcion nvarchar(50),
@abreviatura nvarchar(50)
as
update
	TIPO
set
	descripcion=@descripcion,
	abreviatura=@abreviatura
where
	codigo=@codigo
-------------------------------------------------------------
alter procedure sp_delete_tipo
@codigo int
as
update
	TIPO
set
	status='E'
where
	codigo=@codigo
-------------------------------------------------------------
alter procedure sp_insert_subtipo
@codTipo int,
@descripcion nvarchar(50),
@abreviatura nvarchar(50),
@costo float(2),
@pvp float(2)
as
insert into
	[SUB-TIPO]
values
	(@codTipo,@descripcion,@abreviatura,@costo,@pvp,'A')
-------------------------------------------------------------
alter procedure sp_update_subtipo
@codigo int,
@descripcion nvarchar(50),
@abreviatura nvarchar(50),
@costo float(2),
@pvp float(2)
as
update
	[SUB-TIPO]
set
	descripcion=@descripcion,
	abreviatura=@abreviatura,
	costo=@costo,
	pvp=@pvp
where
	codigo=@codigo
-------------------------------------------------------------
alter procedure sp_delete_subtipo
@codigo int
as
update
	[SUB-TIPO]
set
	status='E'
where
	codigo=@codigo
-------------------------------------------------------------
alter procedure sp_insert_grupo
@descripcion nvarchar(50)
as
declare @orden int
select @orden = max(orden)+1
from GRUPOS
insert into
	GRUPOS
values
	(@descripcion,@orden,'A')
-------------------------------------------------------------
alter procedure sp_update_grupo
@codigo int,
@descripcion nvarchar(50)
as
update
	GRUPOS
set
	descripcion=@descripcion
where
	codigo=@codigo
-------------------------------------------------------------
create procedure sp_delete_grupo
@codigo int
as
update
	GRUPOS
set
	status='E'
where
	codigo=@codigo

-------------------------------------------------------------
alter procedure sp_update_ordenUp
@codigo1 int,
@codigo2 int,
@valor1 int,
@valor2 int
as
declare @valorTemp1 int,@valorTemp2 int
set @valorTemp1=@valor1
set @valorTemp2=@valor2
update
	GRUPOS
set
	orden=@valor1
where
	codigo=@codigo2;
update
	GRUPOS
set
	orden=@valor2
where
	codigo=@codigo1;

exec sp_update_ordenUp 3,7,6,7

select count(*)
from GRUPOS
where status='A'

select TIPO.codigo,TIPO.descripcion
from GRUPOS,CLASE,TIPO
where orden = 1 and GRUPOS.codigo=cod_grupo and CLASE.codigo = cod_clase
and CLASE.status='A' and TIPO.status='A'

select GRUPOS.codigo as 'codGrupo',GRUPOS.descripcion as 'descGrupo',
GRUPOS.orden as 'ordenGrupo',TIPO.codigo as 'codTipo',TIPO.descripcion as 'descTipo',
TIPO.abreviatura as 'abTipo',[SUB-TIPO].codigo as 'codSubTipo',[SUB-TIPO].descripcion as 'descSubTipo',
[SUB-TIPO].abreviatura as 'abSubTipo',[SUB-TIPO].costo as 'costSubTipo',[SUB-TIPO].pvp as 'pvpSubTipo'
from GRUPOS,CLASE,TIPO,[SUB-TIPO]
where GRUPOS.codigo=cod_grupo and CLASE.codigo = cod_clase and TIPO.codigo = cod_tipo
and CLASE.status='A' and TIPO.status='A' and [SUB-TIPO].status='A'
order by GRUPOS.orden


select *
from [SUB-TIPO]
where cod_tipo=1 and codigo=1



alter procedure sp_insert_formaPago
@descripcion nvarchar(50)
as
insert into
	[FORMA-PAGO]
values
	(@descripcion,'A')

create procedure sp_update_formaPago
@codigo int,
@descripcion nvarchar(50)
as
update
	[FORMA-PAGO]
set
	descripcion=@descripcion
where
	codigo=@codigo

-------------------------------------------------
create procedure sp_delete_formaPago
@codigo int
as
update
	[FORMA-PAGO]
set
	status='E'
where
	codigo=@codigo
-------------------------------------------------
alter procedure sp_insert_infoCliente
@nombre nvarchar(50),
@fecha datetime,
@hombres int,
@mujeres int,
@idFormaPago int,
@valor float
as
insert into
	TARJETA
values
	(@nombre,@fecha,@hombres,@mujeres,@idFormaPago);
/**/
declare @numTarjeta int
select @numTarjeta =max(codigo)
from TARJETA

insert into
	[DETALLE-PAGO]
values
	(@numTarjeta,@idFormaPago,@valor);
-------------------------------------------------
alter procedure sp_obtener_numTarjeta
@numeroRetorna int output
as
select @numeroRetorna = max(codigo)+1
from TARJETA

--------------------------------------------------------------------
select GRUPOS.descripcion as 'descGrupo',
TIPO.descripcion as 'descTipo',
[SUB-TIPO].descripcion as 'descSubTipo',
[SUB-TIPO].abreviatura as 'abSubTipo',[SUB-TIPO].costo as 'costSubTipo',[SUB-TIPO].pvp as 'pvpSubTipo'
from GRUPOS,CLASE,TIPO,[SUB-TIPO]
where GRUPOS.codigo=cod_grupo and CLASE.codigo = cod_clase and TIPO.codigo = cod_tipo
and CLASE.status='A' and TIPO.status='A' and [SUB-TIPO].status='A'
order by GRUPOS.orden

-----------------------------------------------------------
alter procedure sp_cons_nombreCliente
@codigo int
as
select nombre
from TARJETA
where codigo=@codigo

------------------------------------------------------------
alter procedure sp_cons_ClaseByAb
@grupo int,
@abreviatura char(1)
as
select CLASE.codigo,CLASE.descripcion
from GRUPOS,CLASE
where GRUPOS.codigo=cod_grupo and GRUPOS.status='A' and 
CLASE.status='A' and GRUPOS.codigo=@grupo and abreviatura=@abreviatura
----------------------------------------------------------------

alter procedure sp_cons_TipoByAb
@clase int,
@abreviatura char(1)
as
select TIPO.codigo,TIPO.descripcion
from TIPO
where TIPO.status='A' and cod_clase=@clase and 
abreviatura=@abreviatura


----------------------------------------------------------------
alter procedure sp_cons_SubTipoByAb
@tipo int,
@abreviatura char(1)
as
select [SUB-TIPO].codigo,[SUB-TIPO].descripcion,[SUB-TIPO].pvp
from [SUB-TIPO]
where [SUB-TIPO].status='A' and cod_tipo=@tipo and 
abreviatura=@abreviatura
---------------------------------------------------------------
alter procedure sp_cons_receta_BySel
@clase int,
@tipo int,
@subTipo int
as
select RECETA.codigo,INVENTARIO.descripcion as 'Ingrediente',RECETA.cantidad
from RECETA,CLASE,TIPO,[SUB-TIPO],INVENTARIO
where CLASE.codigo=RECETA.cod_clase and 
INVENTARIO.codigo=cod_inventario and
TIPO.codigo=RECETA.cod_tipo and 
[SUB-TIPO].codigo = RECETA.cod_subtipo and
RECETA.cod_clase=@clase and RECETA.cod_tipo=@tipo and
RECETA.cod_subtipo=@subTipo
---------------------------------------------------------------

select RECETA.codigo,CLASE.descripcion as 'clase',TIPO.descripcion as 'tipo',
[SUB-TIPO].descripcion as 'subtipo',INVENTARIO.descripcion as 'Ingrediente',RECETA.cantidad
from RECETA,CLASE,TIPO,[SUB-TIPO],INVENTARIO
where CLASE.codigo=RECETA.cod_clase and INVENTARIO.codigo=cod_inventario and
TIPO.codigo=RECETA.cod_tipo and 
[SUB-TIPO].codigo = RECETA.cod_subtipo
order by 2,3,4,5,6


------------------------------------------------------------------
alter procedure sp_insert_receta
@clase int,
@tipo int,
@subTipo int,
@inventario int,
@cantidad float
as
insert into
	RECETA
values
(@clase,@tipo,@subTipo,@inventario,@cantidad)

------------------------------------------------------------------
alter procedure sp_update_receta
@codigo int,
@cantidad float
as
update
	RECETA
set
	cantidad=@cantidad
where
	codigo=@codigo

-------------------------------------------------------------------
create procedure sp_delete_receta
@codigo int
as
delete from
	RECETA
where
	codigo=@codigo

-------------------------------------------------------------------

alter procedure sp_cons_inventarioIngreso_BySel
@inventario int
as
select [INVENTARIO-INGRESO].codigo,[INVENTARIO-INGRESO].fecha,
[INVENTARIO-INGRESO].cantidad
from [INVENTARIO-INGRESO],INVENTARIO
where [INVENTARIO-INGRESO].cod_inventario=@inventario and 
INVENTARIO.codigo=[INVENTARIO-INGRESO].cod_inventario

-------------------------------------------------------------------

alter procedure sp_insert_RegInventario
@inventario int,
@cantidad int,
@fecha as datetime
as
insert into
	[INVENTARIO-INGRESO]
values
	(@inventario,@cantidad,@fecha);
-------------------------------------------------------------------
update
	INVENTARIO
set
	cantidad=cantidad+@cantidad
where
codigo=@Inventario
----------------------------------------------------------
/**/
alter procedure sp_insert_inventario
@descripcion nvarchar(50),
@cantidad int,
@fecha datetime
as
insert into
	INVENTARIO
values
	(@descripcion,@cantidad);
-----------------------------------------------------------
declare @lastInventario int
select @lastInventario = max(codigo)
from INVENTARIO
-----------------------------------------------------------
insert into
	[INVENTARIO-INGRESO]
values
	(@lastInventario,@cantidad,@fecha);
/**/
alter procedure sp_insert_consumo
@tarjeta int,
@clase int,
@tipo int,
@subTipo int,
@cantidad int
as
insert into
	CONSUMO
values
	(@tarjeta,@clase,@tipo,@subTipo,@cantidad)
-----------------------------------------------------------

alter procedure sp_cons_detallePago_BySel
@tarjeta int
as
select [DETALLE-PAGO].codigo,[FORMA-PAGO].descripcion,[DETALLE-PAGO].valor
from [DETALLE-PAGO],[FORMA-PAGO]
where cod_tarjeta=@tarjeta and [FORMA-PAGO].codigo=cod_formapago
and [DETALLE-PAGO].cod_formapago=[FORMA-PAGO].codigo


/**/

create procedure sp_insert_Detalle_Pago
@tarjeta int,
@formaPago int,
@valor float
as
insert into
	[DETALLE-PAGO]
values
	(@tarjeta,@formaPago,@valor)
----------------------------------------------------------------------------

select *,(select max(codigo)
from CONSUMO)
from CONSUMO



alter procedure sp_cons_consumo_BySel
@tarjeta int
as
select TIPO.descripcion,[SUB-TIPO].descripcion,CONSUMO.cantidad,
sum(pvp)*cantidad as 'Pvp'
from TIPO,[SUB-TIPO],CONSUMO
where cod_tarjeta=@tarjeta and TIPO.codigo=CONSUMO.cod_tipo and 
[SUB-TIPO].codigo=CONSUMO.cod_subtipo
group by CONSUMO.codigo,TIPO.descripcion,[SUB-TIPO].descripcion,
CONSUMO.cantidad

-------------------------------------------------------------------------
select CONSUMO.codigo as 'NºConsumo',TIPO.descripcion,
[SUB-TIPO].descripcion,CONSUMO.cantidad,sum(pvp)*cantidad as 'Pvp'
from TIPO,[SUB-TIPO],CONSUMO
where cod_tarjeta=1 and TIPO.codigo=CONSUMO.cod_tipo and 
[SUB-TIPO].codigo=CONSUMO.cod_subtipo
group by CONSUMO.codigo,TIPO.descripcion,[SUB-TIPO].descripcion,
CONSUMO.cantidad


/*union
select null,null,null,null,sum([SUB-TIPO].pvp*CONSUMO.cantidad)
from CONSUMO,[SUB-TIPO]
where CONSUMO.cod_subtipo=[SUB-TIPO].codigo and 
cod_tarjeta=1
order by 1 desc*/



select *
from CONSUMO
----------------------------------------------------------------------
create procedure sp_insert_venta
as
