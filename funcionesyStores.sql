--get funciones
CREATE FUNCTION GESTION_DE_INFARTOS.getFuncionalidades(@Usuario varchar(50))
RETURNS table
AS
return SELECT f.codigo 
FROM GESTION_DE_INFARTOS.funcionalidad f, 
GESTION_DE_INFARTOS.rol_funcionalidad rf,
GESTION_DE_INFARTOS.roles r,
GESTION_DE_INFARTOS.rol_usuario ru,
GESTION_DE_INFARTOS.usuarios u
WHERE 
f.codigo = rf.funcionalidad AND
rf.rol = r.codigo AND
r.codigo = ru.rol AND
r.estado = 1 AND
ru.usuario = u.codigo AND
u.nombre = @Usuario

CREATE FUNCTION GESTION_DE_INFARTOS.strToTable ( @stringToSplit VARCHAR(MAX) )
RETURNS
 @returnList TABLE ([Name] [nvarchar] (500))
AS
BEGIN

 DECLARE @name NVARCHAR(255)
 DECLARE @pos INT

 WHILE CHARINDEX(',', @stringToSplit) > 0
 BEGIN
  SELECT @pos  = CHARINDEX(',', @stringToSplit)  
  SELECT @name = SUBSTRING(@stringToSplit, 1, @pos-1)

  INSERT INTO @returnList 
  SELECT @name

  SELECT @stringToSplit = SUBSTRING(@stringToSplit, @pos+1, LEN(@stringToSplit)-@pos)
 END

 INSERT INTO @returnList
 SELECT @stringToSplit

 RETURN
END

CREATE PROCEDURE GESTION_DE_INFARTOS.modificacion_rol 
	@Rol_id numeric,
	@Descripcion varchar(50),
	@Estado bit,
	@Codigos_Funciones varchar(2000)
AS
	--Edicion en entidad rol
	UPDATE GESTION_DE_INFARTOS.roles
	SET estado = @Estado, descripcion = @Descripcion
	WHERE codigo = @Rol_id;
	
	--Baja de rol_funcionalidades
	DECLARE @CODIGO_FUNCION varchar(10);
	
	--Trae un cursor con las filas a eliminar
	DECLARE funciones_baja_cursor CURSOR FOR  
	SELECT funcionalidad 
		FROM GESTION_DE_INFARTOS.rol_funcionalidad
		WHERE rol = @Rol_id AND funcionalidad NOT IN 
			(Select * from GESTION_DE_INFARTOS.strToTable(@Codigos_Funciones))
	
	OPEN funciones_baja_cursor
	FETCH NEXT FROM funciones_baja_cursor INTO @CODIGO_FUNCION;
	

	
	WHILE @@FETCH_STATUS = 0   
	BEGIN
		DELETE FROM GESTION_DE_INFARTOS.rol_funcionalidad
		WHERE rol = @Rol_id AND funcionalidad = @CODIGO_FUNCION;
		
		FETCH NEXT FROM funciones_baja_cursor INTO @CODIGO_FUNCION
	END   

	CLOSE funciones_baja_cursor   
	DEALLOCATE funciones_baja_cursor	
GO
---------------------------
CREATE PROCEDURE GESTION_DE_INFARTOS.modificacion_rol 
	@Rol_id numeric,
	@Descripcion varchar(50) = NULL,
	@Estado bit,
	@Codigos_Funciones varchar(2000)
AS
	--Edicion en entidad rol
	UPDATE GESTION_DE_INFARTOS.roles
	SET estado = @Estado, descripcion = @Descripcion
	WHERE codigo = @Rol_id;
	
	--Baja de rol_funcionalidades
	DECLARE @CODIGO_FUNCION varchar(10);
	DECLARE @DESCRIPCION_FUNCION varchar(50);
	--Trae un cursor con las filas a eliminar
	DECLARE funciones_baja_cursor CURSOR FOR  
	SELECT funcionalidad 
		FROM GESTION_DE_INFARTOS.rol_funcionalidad
		WHERE rol = @Rol_id AND funcionalidad NOT IN (Select * from GESTION_DE_INFARTOS.strToTable(@Codigos_Funciones))
	
	OPEN funciones_baja_cursor
	FETCH NEXT FROM funciones_baja_cursor INTO @CODIGO_FUNCION;
	
	WHILE @@FETCH_STATUS = 0   
	BEGIN
		DELETE FROM GESTION_DE_INFARTOS.rol_funcionalidad
		WHERE rol = @Rol_id AND funcionalidad = @CODIGO_FUNCION;
		
		FETCH NEXT FROM funciones_baja_cursor INTO @CODIGO_FUNCION
	END   

	CLOSE funciones_baja_cursor   
	DEALLOCATE funciones_baja_cursor
	
	--Trae un cursor con las filas a agregar
	DECLARE funciones_cursor CURSOR FOR  
	SELECT codigo 
		FROM GESTION_DE_INFARTOS.funcionalidad
		WHERE codigo IN (Select * from GESTION_DE_INFARTOS.strToTable(@Codigos_Funciones))
	
	OPEN funciones_cursor
	FETCH NEXT FROM funciones_cursor INTO @CODIGO_FUNCION;
	
	WHILE @@FETCH_STATUS = 0   
	BEGIN
		SELECT @DESCRIPCION_FUNCION = descripcion FROM
			GESTION_DE_INFARTOS.funcionalidad WHERE
				codigo = @CODIGO_FUNCION;
		IF not exists(SELECT * FROM GESTION_DE_INFARTOS.rol_funcionalidad WHERE rol = @Rol_id AND funcionalidad = @CODIGO_FUNCION)
			INSERT INTO rol_funcionalidad (rol, funcionalidad) VALUES (@Rol_id, @CODIGO_FUNCION);
		 
		FETCH NEXT FROM funciones_cursor INTO @CODIGO_FUNCION
	END   

	CLOSE funciones_cursor   
	DEALLOCATE funciones_cursor
		
GO