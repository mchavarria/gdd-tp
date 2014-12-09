CREATE PROCEDURE hotel.SP_GETREGIMENporHOTEL
	@hotel numeric
AS
BEGIN
	select re.codigo, re.descripcion from hotel.Regimen_Hotel r
	join hotel.Regimen re ON r.cod_regimen = re.codigo AND @hotel = r.cod_hotel
	order by 2
END
GO

CREATE PROCEDURE hotel.SP_GETTIPOHABITACIONporHOTEL
	@hotel numeric
AS
BEGIN
	select ha.cod_tipo_habitacion as codigo, ta.descripcion from hotel.Habitacion ha
	join hotel.Hotel ho ON ho.codigo = @hotel AND ha.cod_hotel = @hotel AND ha.estado = 1
	join hotel.Tipo_Habitacion ta ON ha.cod_tipo_habitacion = ta.codigo
	group by ha.cod_tipo_habitacion, ta.descripcion
	order by 2
END
GO

CREATE PROCEDURE hotel.SP_GETREGIMENporHOTELyHabilitado
	@hotel numeric
AS
BEGIN
	select re.codigo, re.descripcion from hotel.Regimen_Hotel r
	join hotel.Regimen re ON r.cod_regimen = re.codigo AND @hotel = r.cod_hotel AND r.estado = 1
	order by 2
END
GO

CREATE PROCEDURE hotel.SP_GETHAB_DISPporHotel
	@hotel varchar(10), @desde varchar(10), @hasta varchar(10)
AS
BEGIN
	select cod_habitacion, tha.descripcion
	from hotel.Reserva r
	join hotel.Reserva_Habitacion rh ON rh.cod_reserva = r.codigo 
		AND (r.cod_estado = 1 or r.cod_estado = 2) 
		AND (CONVERT(char(10), r.fecha_hasta,126) < CONVERT(varchar(20), CAST(@desde as DATE),126)
		OR CONVERT(char(10), r.fecha_desde,126) >CONVERT(varchar(20), CAST(@hasta as DATE),126))
	join hotel.Habitacion ha ON ha.codigo = rh.cod_habitacion AND ha.cod_hotel = @hotel AND ha.estado = 1
	join hotel.Tipo_Habitacion tha ON ha.cod_tipo_habitacion = tha.codigo
	group by cod_habitacion, tha.descripcion
	order by 2
END
GO

CREATE FUNCTION hotel.FN_GET_PRECIO_BASE(@habitacion integer, @hotel integer, @regimen integer)
RETURNS integer
AS
BEGIN
RETURN ISNULL((SELECT ho.precio_base
		FROM hotel.Habitacion ha
		JOIN hotel.Hotel h ON h.codigo = @hotel AND ha.codigo = @habitacion
		JOIN hotel.Regimen_Hotel ho ON ho.cod_hotel = @hotel 
			AND ho.cod_regimen = @regimen AND ho.estado = 1),0)
END
GO

CREATE PROCEDURE hotel.SP_GETHAB_BY_RESERVA
	@hotel varchar(10), @reserva varchar(20)
AS
BEGIN
	select cod_habitacion, tha.descripcion
	from hotel.Reserva_Habitacion rh 
	join hotel.Habitacion ha ON ha.codigo = rh.cod_habitacion 
		AND ha.cod_hotel = @hotel 
		AND rh.cod_reserva = @reserva 
	join hotel.Tipo_Habitacion tha ON ha.cod_tipo_habitacion = tha.codigo
	group by cod_habitacion, tha.descripcion
	order by 2
END
GO


CREATE PROCEDURE hotel.SP_UPDRESERVA
(
@codigo numeric,
@cod_hotel numeric,
@fecha_desde datetime,
@fecha_hasta datetime,
@cant_huespedes numeric,
@cod_tipo_regimen numeric,
@cod_estado numeric,
@cod_usuario_carga numeric,
@cant_noches numeric,
@cod_persona numeric,
@fecha_creacion datetime

)AS 
BEGIN
	update hotel.Reserva
	set
		cod_hotel = @cod_hotel,
		fecha_desde = @fecha_desde,
		fecha_hasta = @fecha_hasta,
		cant_huespedes = @cant_huespedes,
		cod_tipo_regimen = @cod_tipo_regimen,
		cod_estado = @cod_estado,
		cod_usuario_carga = @cod_usuario_carga,
		cant_noches = @cant_noches,
		cod_persona = @cod_persona,
		fecha_creacion = @fecha_creacion
	WHERE codigo = @codigo
END
GO

CREATE PROCEDURE hotel.SP_UPDESTADIA
(
@codigo numeric,
@fecha_out datetime,
@cod_user_out numeric
)AS 
BEGIN
	update hotel.Check_In_Out
	set
		fecha_hora_out = @fecha_out,
		cod_usuario_carga_out = @cod_user_out,
		cant_noches_estadia = DATEDIFF(day, fecha_hora_in, @fecha_out)
	WHERE codigo = @codigo
END
GO
