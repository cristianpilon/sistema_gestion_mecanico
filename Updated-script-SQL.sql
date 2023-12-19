use SGestionMecanico
INSERT INTO dbo.Insumos (Nombre, Stock, Precio)
VALUES
    ('Pistón', 10, 19.99),
    ('Cilindro', 15, 29.99),
    ('Biela', 20, 9.99),
    ('Cárter', 8, 49.99),
    ('Árbol de levas', 12, 39.99),
    ('Válvula de admisión', 25, 14.99),
    ('Válvula de escape', 25, 14.99),
    ('Árbol de transmisión', 5, 79.99),
    ('Bujía', 30, 2.99),
    ('Polea', 18, 8.99),
    ('Radiador', 10, 69.99),
    ('Filtro de aire', 40, 4.99),
    ('Cojinete', 15, 6.99),
    ('Embrague', 12, 49.99),
    ('Bomba de agua', 8, 39.99),
    ('Junta de culata', 6, 19.99),
    ('Sistema de escape', 10, 29.99),
    ('Cadena de distribución', 15, 19.99),
    ('Sensor de oxígeno', 20, 34.99),
    ('Árbol de levas', 12, 29.99),
    ('Polea del cigüeñal', 10, 9.99),
    ('Sistema de dirección', 5, 59.99),
    ('Bomba de aceite', 8, 29.99),
    ('Válvula EGR', 15, 39.99),
    ('Termostato', 12, 14.99),
    ('Sistema de frenos', 20, 49.99),
    ('Sonda lambda', 15, 24.99),
    ('Turbocompresor', 8, 149.99),
    ('Correa de distribución', 10, 12.99),
    ('Aceite del motor', 50, 7.99);

INSERT INTO dbo.Estados (Descripcion)
VALUES
('Ingresado'),
('Taller'),
('Completo');

INSERT INTO dbo.EstadoEnvios(Descripcion)
VALUES
('Pendiente'),
('Para despacho'),
('Despachado');

INSERT INTO dbo.Provincias( Nombre_prov)
VALUES
('Santa fe' ),
('Entre rios');

INSERT INTO dbo.Localidades(Nombre_loc, ProvinciaId)
VALUES
('Rosario', 1),
('Victoria', 2);

INSERT INTO dbo.Clientes (Nombre, Apellido, Direccion, Dni, Email, LocalidadId)
VALUES
('Lautaro', 'Cabral', 'sgto cabral 576', '39505005', 'lautacabral96@gmail.com', 2),
('Florencia', 'Montini', 'Maipu 2090', '39505005', 'florenciamontini@gmail.com', 1);
INSERT INTO dbo.Operarios (Nombre, Apellido, Dni, Fecha)
VALUES
('Juan', 'Ubieta', '39505006', '2023-04-04'),
('Franco', 'Acocella', '39506006', '2023-04-04');

INSERT INTO dbo.Proveedores (Nombre)
VALUES
('Honda'),
('BMW');

INSERT INTO dbo.Empleados(Nombre,Apellido, Dni, Cargo )
VALUES
('Negocio 1', 'Op', '39505005', 'Caja'),
('Negocio 2', 'Op', '39505005', 'Caja');

INSERT INTO dbo.Transportistas(RazonSocial,Cuil, Email, Telefono )
VALUES
('Viacargo', '2039505005', 'Viacargo@gmail.com', '3412621001'),
('PackageGo', '2039505225', 'PackageGo@gmail.com', '3412621001');

INSERT INTO dbo.Permisos(Descripcion, NombrePermiso )
VALUES
('Modulo rectificado', 'Rectificados'),
('Modulo venta', 'Ventas'),
('Modulo pedido', 'Pedidos'),
('Modulo envio', 'Envios'),
('Modulo grupos', 'Grupos'),
('Modulo usuarios', 'Usuarios'),
('Modulo operarios', 'Operarios');

INSERT INTO dbo.Grupos(Descripcion )
VALUES
('Admin'),
('Empleado'),
('Operario');

INSERT INTO dbo.Usuarios(Nombre,[User],[Password], Email )
VALUES
('Lautaro operario', 'lautarocabral','lautaro123', 'lautacabral96@gmail.com'),
('Florencia admin', 'florenciamontini','florencia123', 'flomontini@gmail.com'),
('Florencia empleada', 'florenciamontiniemp','floremp123', 'flomontini@gmail.com');

INSERT INTO dbo.GrupoUsuario(GrupoId, UsuariosId )
VALUES
(1, 2),
(3,1),
(2, 3);

INSERT INTO dbo.GrupoPermiso(GruposId, PermisosId )
VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(1, 7),
(2,2),
(3, 7);

--INSERT INTO dbo.Rectificados(ClienteId, OperarioId, Fecha, EstadoId, Total,ParaEnvio)
--VALUES
--(1, 1,'2023-04-04',1,4000.99, true),
--(2, 2,'2023-04-04',1,45000.99, false);

--INSERT INTO dbo.Motores (NroMotorId, Marca, Modelo, Fabricacion, RectificadoId)
--VALUES
--('A142LJU', 'Jawa', '350ts', '1991-01-01', 1),
--('AAA456', 'Honda', 'xr150', '1996-01-01', 2),
--('Pnr903', 'RoyalEnfield', 'himalayan', '2021-01-01', 1);
--use SGestionMecanico
--INSERT INTO dbo.Pedidos(ProveedorId, Fecha, RectificadoId)
--VALUES
--(1, '2023-09-25', 1),
--(2, '2023-09-25', 1);

--INSERT INTO dbo.LineaPedidos(InsumoId,Cantidad, PedidoId)
--VALUES
--(15, 10, 1),
--(26, 2, 1);
