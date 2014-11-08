--tipos de documento
insert into GESTION_DE_INFARTOS.tipos_documento values ('DNI');
insert into GESTION_DE_INFARTOS.tipos_documento values ('CI');
insert into GESTION_DE_INFARTOS.tipos_documento values ('LE');
insert into GESTION_DE_INFARTOS.tipos_documento values ('LC');
insert into GESTION_DE_INFARTOS.tipos_documento values ('PAS');

--usuario administrador
insert into GESTION_DE_INFARTOS.usuarios values ('admin', 'w23e', 0, 1, 0, NULL);

--roles
insert into GESTION_DE_INFARTOS.roles values ('Administrador', 1);
insert into GESTION_DE_INFARTOS.roles values ('Recepcionista', 1);
insert into GESTION_DE_INFARTOS.roles values ('Guest', 1);
insert into GESTION_DE_INFARTOS.rol_usuario (rol, usuario) values (1, 1);

--funcionalidades
insert into GESTION_DE_INFARTOS.funcionalidad (codigo, descripcion) values
	('ROL1', 'alta de rol de usuario');
insert into GESTION_DE_INFARTOS.rol_funcionalidad(rol, funcionalidad) values
	(1, 'ROL1');

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
ru.usuario = u.codigo AND
u.nombre = @Usuario

----------------------------------------------------------------------------
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

----------------------------------------------------------------------------

CREATE PROCEDURE GESTION_DE_INFARTOS.alta_rol 
	@Descripcion varchar(50),
	@Estado bit,
	@Codigos_Funciones varchar(2000)
AS
	--Alta en entidad rol
	DECLARE @Rol_id numeric;
	INSERT INTO GESTION_DE_INFARTOS.roles (descripcion, estado) 
		values (@Descripcion, @Estado);
	SET @Rol_id = IDENT_CURRENT( 'GESTION_DE_INFARTOS.roles' );
	--alta de funcionalidades
	DECLARE @CODIGO_FUNCION varchar(10);
	DECLARE @DESCRIPCION_FUNCION varchar(50);
	
	DECLARE funciones_cursor CURSOR FOR  
	SELECT codigo 
		FROM GESTION_DE_INFARTOS.funcionalidad
		WHERE codigo IN 
			(Select * from GESTION_DE_INFARTOS.strToTable(@Codigos_Funciones))
	
	OPEN funciones_cursor
	FETCH NEXT FROM funciones_cursor INTO @CODIGO_FUNCION;
	

	
	WHILE @@FETCH_STATUS = 0   
	BEGIN
		SELECT @DESCRIPCION_FUNCION = descripcion FROM
			GESTION_DE_INFARTOS.funcionalidad WHERE
				codigo = @CODIGO_FUNCION;
		INSERT INTO rol_funcionalidad (rol, funcionalidad)
			VALUES (@Rol_id, @CODIGO_FUNCION);
		 
		   FETCH NEXT FROM funciones_cursor INTO @CODIGO_FUNCION
	END   

	CLOSE funciones_cursor   
	DEALLOCATE funciones_cursor	
GO