CREATE DATABASE spabelleza;
GO

USE spabelleza;
GO

-- Tabla Roles
CREATE TABLE Roles (
    RolID INT PRIMARY KEY IDENTITY(1,1),
    NombreRol NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(255),
    AccesoProductos BIT NOT NULL DEFAULT 0,
    AccesoServicios BIT NOT NULL DEFAULT 0,
    AccesoCitas BIT NOT NULL DEFAULT 0,
    AccesoProgramacion BIT NOT NULL DEFAULT 0,
    AccesoPagos BIT NOT NULL DEFAULT 0,
    AccesoReporte BIT NOT NULL DEFAULT 0,
    AccesoRoles BIT NOT NULL DEFAULT 0,
    AccesoUsuarios BIT NOT NULL DEFAULT 0
);
GO

-- Tabla Usuarios
CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    Nombres NVARCHAR(50) NOT NULL,
    ApellidoPaterno NVARCHAR(50) NOT NULL,
    ApellidoMaterno NVARCHAR(50) NOT NULL,
    Gmail NVARCHAR(100) NOT NULL UNIQUE,
    DNI NVARCHAR(8) NOT NULL UNIQUE,
    Telefono NVARCHAR(15) NOT NULL,
    Estado NVARCHAR(10) CHECK (Estado IN ('Activo', 'Inactivo')) NOT NULL,
    Usuario NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL, -- Deberías usar hashing para almacenar la contraseña
    RolAsignado INT NOT NULL,
    Foto VARBINARY(MAX), -- Campo para almacenar la foto del usuario
    CONSTRAINT FK_RolUsuario FOREIGN KEY (RolAsignado) REFERENCES Roles(RolID)
);
GO

-- Tabla Servicios
CREATE TABLE Servicios (
    ServicioID INT PRIMARY KEY IDENTITY(1,1),
    NombreServicio NVARCHAR(50) NOT NULL,
    Costo DECIMAL(10,2) NOT NULL
);
GO

-- Tabla Productos
CREATE TABLE Productos (
    ProductoID INT PRIMARY KEY IDENTITY(1,1),
    NombreProducto NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(255),
    Stock INT NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Foto VARBINARY(MAX) -- Agregado el campo Foto
);
GO

-- Tabla Citas
CREATE TABLE Citas (
    CitaID INT PRIMARY KEY IDENTITY(1,1),
    Nombres NVARCHAR(50) NOT NULL,
    ApellidoPaterno NVARCHAR(50) NOT NULL,
    ApellidoMaterno NVARCHAR(50) NOT NULL,
    DNI NVARCHAR(8) NOT NULL,
    Telefono NVARCHAR(15) NOT NULL,
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    Estado NVARCHAR(10) CHECK (Estado IN ('Pendiente', 'Finalizado', 'Proceso')) NOT NULL,
    EspecialistaID INT NOT NULL,
    ServicioID INT NOT NULL,  -- Nueva referencia al servicio
    CONSTRAINT FK_Especialista FOREIGN KEY (EspecialistaID) REFERENCES Usuarios(UsuarioID),
    CONSTRAINT FK_Servicio FOREIGN KEY (ServicioID) REFERENCES Servicios(ServicioID)  -- Nueva clave foránea
);
GO

-- Tabla Programacion
CREATE TABLE Programacion (
    ProgramacionID INT PRIMARY KEY IDENTITY(1,1),
    CitaID INT NOT NULL,
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    Servicios NVARCHAR(255) NOT NULL,
    EspecialistaID INT NOT NULL,
    Nombres NVARCHAR(50) NOT NULL,
    ApellidoPaterno NVARCHAR(50) NOT NULL,
    ApellidoMaterno NVARCHAR(50) NOT NULL,
    CONSTRAINT FK_Programacion_Cita FOREIGN KEY (CitaID) REFERENCES Citas(CitaID)
);
GO

-- Tabla Pagos
CREATE TABLE Pagos (
    PagoID INT PRIMARY KEY IDENTITY(1,1),
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    ClienteNombre NVARCHAR(50) NOT NULL,
    DNI NVARCHAR(8) NOT NULL,
    CostoTotal DECIMAL(10,2) NOT NULL,
    MetodoPago NVARCHAR(10) CHECK (MetodoPago IN ('yape', 'plin', 'efectivo')) NOT NULL,
    ServicioID INT NOT NULL,  -- Relación directa con el servicio
    ProductoID INT,           -- Relación directa con el producto
    CONSTRAINT FK_Pago_Servicio FOREIGN KEY (ServicioID) REFERENCES Servicios(ServicioID),
    CONSTRAINT FK_Pago_Producto FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
);
GO

-- Tabla Reporte
CREATE TABLE Reporte (
    ReporteID INT PRIMARY KEY IDENTITY(1,1),
    PagoID INT NOT NULL,
    Fecha DATE NOT NULL,
    ServicioID INT NOT NULL,
    ProductoID INT,
    MetodoPago NVARCHAR(10) NOT NULL,
    CONSTRAINT FK_Reporte_Pago FOREIGN KEY (PagoID) REFERENCES Pagos(PagoID),
    CONSTRAINT FK_Reporte_Servicio FOREIGN KEY (ServicioID) REFERENCES Servicios(ServicioID),
    CONSTRAINT FK_Reporte_Producto FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
);
GO

--------------------------------------------------------------------------

--------Registro Roles 

INSERT INTO Roles (NombreRol, Descripcion, AccesoProductos, AccesoServicios, AccesoCitas, AccesoProgramacion, AccesoPagos, AccesoReporte, AccesoRoles, AccesoUsuarios)
VALUES 
('Administrador', 'Acceso a todo el sistema', 1, 1, 1, 1, 1, 1, 1, 1),
('Recepcionista', 'Acceso a citas, pagos y programación', 0, 0, 1, 1, 1, 0, 0, 0),
('Manicurista', 'Acceso solo a programación', 0, 0, 0, 1, 0, 0, 0, 0),
('Terapeuta', 'Acceso solo a programación', 0, 0, 0, 1, 0, 0, 0, 0),
('Esteticista', 'Acceso solo a programación', 0, 0, 0, 1, 0, 0, 0, 0),
('Masajista', 'Acceso solo a programación', 0, 0, 0, 1, 0, 0, 0, 0),
('Fisioterapeuta', 'Acceso solo a programación', 0, 0, 0, 1, 0, 0, 0, 0),
('Cosmetólogo', 'Acceso solo a programación', 0, 0, 0, 1, 0, 0, 0, 0);

----Registro Usuarios

INSERT INTO Usuarios (Nombres, ApellidoPaterno, ApellidoMaterno, Gmail, DNI, Telefono, Estado, Usuario, Password, RolAsignado, Foto)
VALUES 
('Rubi', 'Descalzi', 'Tenorio', 'rubidescalzi@gmail.com', '12345678', '987654321', 'Activo', 'rdescalzi', 'adminpass', 1, NULL),
('Ana', 'Lopez', 'Rodriguez', 'analopez@gmail.com', '23456789', '987654322', 'Activo', 'alopez', 'receppass', 2, NULL),
('Maria', 'Garcia', 'Martinez', 'mariagarcia@gmail.com', '34567890', '987654323', 'Activo', 'mgarcia', 'manicpass', 3, NULL),
('Pedro', 'Fernandez', 'Sanchez', 'pedro.fernandez@gmail.com', '45678901', '987654324', 'Activo', 'pfernandez', 'terapass', 4, NULL),
('Sofia', 'Gonzalez', 'Torres', 'sofiagonzalez@gmail.com', '56789012', '987654325', 'Activo', 'sgonzalez', 'estetipass', 5, NULL),
('Diego', 'Ramos', 'Castillo', 'diegoramos@gmail.com', '67890123', '987654326', 'Activo', 'dramos', 'masajispass', 6, NULL),
('Laura', 'Mendez', 'Gutierrez', 'lauramendez@gmail.com', '78901234', '987654327', 'Activo', 'lmendez', 'fisiopass', 7, NULL),
('Carlos', 'Vargas', 'Suarez', 'carlosvargas@gmail.com', '89012345', '987654328', 'Activo', 'cvargas', 'cosmepass', 8, NULL); 


----- Registro Servicios 

INSERT INTO Servicios (NombreServicio, Costo)
VALUES 
('Corte de Cabello', 40.00),
('Coloración de Cabello', 150.00),
('Balayage', 200.00),
('Alisado Permanente', 250.00),
('Cejas y Pestañas', 45.00),
('Manicure Francesa', 50.00),
('Pedicure Spa', 60.00),
('Masaje Anticelulítico', 120.00),
('Masaje con Piedras Calientes', 130.00),
('Tratamiento Capilar', 85.00),
('Microblading', 300.00),
('Planchado de Cejas', 55.00),
('Extensiones de Pestañas', 180.00),
('Bronceado Express', 70.00),
('Terapia de Reflexología', 90.00),
('Drenaje Linfático', 140.00),
('Mascarilla Capilar', 50.00),
('Maquillaje Profesional', 100.00),
('Peinado para Eventos', 120.00),
('Tratamiento Anticaída', 95.00),
('Masaje Sueco', 95.00),
('Masaje Tailandés', 130.00),
('Terapia de Reiki', 110.00),
('Envoltura Corporal de Algas', 120.00),
('Pedicure con Parafina', 65.00),
('Manicure de Gel', 70.00),
('Depilación con Hilo', 45.00),
('Lifting de Pestañas', 90.00),
('Tratamiento Reafirmante', 150.00),
('Tratamiento Detox', 80.00),
('Exfoliación con Sales Marinas', 85.00),
('Masaje de Aromaterapia', 125.00),
('Tratamiento Antimanchas', 160.00),
('Crioterapia Facial', 200.00),
('Peeling Químico', 140.00),
('Radiofrecuencia Facial', 180.00),
('Tratamiento Antioxidante', 170.00),
('Tratamiento para Ojeras', 100.00),
('Masaje Reductor', 115.00),
('Microdermoabrasión', 190.00);


---- Registro Productos 

INSERT INTO Productos (NombreProducto, Descripcion, Stock, Precio, Foto)
VALUES 
('Crema Hidratante', 'Crema para hidratar la piel', 50, 20.00, NULL),
('Aceite Esencial', 'Aceite para masajes', 100, 15.00, NULL),
('Exfoliante', 'Exfoliante para el cuerpo', 30, 25.00, NULL),
('Mascarilla Facial', 'Mascarilla para el cuidado facial', 40, 10.00, NULL),
('Loción Relajante', 'Loción relajante para el cuerpo', 60, 18.00, NULL),
('Shampoo Nutritivo', 'Shampoo para todo tipo de cabello', 80, 22.00, NULL),
('Acondicionador', 'Acondicionador para cabello', 70, 19.00, NULL),
('Gel Exfoliante', 'Gel exfoliante con granos finos', 45, 28.00, NULL),
('Crema Antiedad', 'Crema antiarrugas para rostro', 35, 35.00, NULL),
('Protector Solar', 'Protector solar FPS 50+', 55, 40.00, NULL),
('Serum Vitamina C', 'Serum para iluminar y rejuvenecer la piel', 40, 45.00, NULL),
('Tónico Facial', 'Tónico para limpiar y refrescar la piel', 50, 18.00, NULL),
('Crema Anticelulítica', 'Crema para combatir la celulitis', 25, 32.00, NULL),
('Bálsamo Labial', 'Bálsamo hidratante para labios', 70, 8.00, NULL),
('Esponja Facial', 'Esponja para limpieza facial', 100, 5.00, NULL),
('Gel Aloe Vera', 'Gel hidratante de aloe vera', 60, 12.00, NULL),
('Mascarilla Capilar', 'Mascarilla para nutrir el cabello', 40, 30.00, NULL),
('Aceite de Argán', 'Aceite para hidratar cabello y piel', 50, 35.00, NULL),
('Agua Micelar', 'Agua micelar para desmaquillar', 80, 15.00, NULL),
('Espuma Limpiadora', 'Espuma suave para limpiar el rostro', 60, 22.00, NULL),
('Gel Reductor', 'Gel para reducir grasa localizada', 35, 38.00, NULL),
('Cepillo Facial', 'Cepillo exfoliante para el rostro', 25, 55.00, NULL),
('Crema para Manos', 'Crema hidratante para manos', 90, 12.00, NULL),
('Manteca Corporal', 'Manteca hidratante para el cuerpo', 50, 28.00, NULL),
('Esencia Facial', 'Esencia hidratante para la piel', 30, 50.00, NULL),
('Polvo Traslúcido', 'Polvo matificante para el rostro', 75, 18.00, NULL),
('Desmaquillante Bifásico', 'Desmaquillante suave para ojos y rostro', 45, 22.00, NULL),
('Peine Desenredante', 'Peine para desenredar el cabello', 100, 10.00, NULL),
('Ampollas Revitalizantes', 'Ampollas para revitalizar la piel', 20, 40.00, NULL),
('Jabón Facial', 'Jabón suave para el rostro', 50, 12.00, NULL);

------- Registro citas

INSERT INTO Citas (Nombres, ApellidoPaterno, ApellidoMaterno, DNI, Telefono, Fecha, Hora, Estado, EspecialistaID, ServicioID)
VALUES 
('Carla', 'Perez', 'Garcia', '11223344', '999123456', '2024-09-21', '10:00', 'Pendiente', 3, 1),
('Luis', 'Ramos', 'Lopez', '22334455', '999123457', '2024-09-21', '11:00', 'Pendiente', 6, 10),
('Sofia', 'Castillo', 'Vargas', '33445566', '999123458', '2024-09-22', '09:00', 'Pendiente', 8, 12),
('Andres', 'Mejia', 'Rojas', '44556677', '999123459', '2024-09-22', '10:30', 'Pendiente', 7, 5),
('Lucia', 'Navarro', 'Diaz', '55667788', '999123460', '2024-09-22', '12:00', 'Pendiente', 5, 14),
('Raul', 'Mendoza', 'Torres', '66778899', '999123461', '2024-09-23', '14:00', 'Pendiente', 6, 20),
('Natalia', 'Cruz', 'Serrano', '77889900', '999123462', '2024-09-23', '15:00', 'Pendiente', 4, 7),
('Ricardo', 'Flores', 'Mendez', '88990011', '999123463', '2024-09-24', '10:00', 'Pendiente', 7, 30),
('Paula', 'Suarez', 'Alvarez', '99001122', '999123464', '2024-09-24', '11:00', 'Pendiente', 8, 31),
('Jorge', 'Salinas', 'Ortega', '10111213', '999123465', '2024-09-25', '09:30', 'Pendiente', 5, 28),
('Fernanda', 'Gutierrez', 'Perez', '11121314', '999123466', '2024-09-25', '11:00', 'Pendiente', 3, 15),
('Pedro', 'Vega', 'Gomez', '12131415', '999123467', '2024-09-26', '10:00', 'Pendiente', 6, 9),
('Lorena', 'Rios', 'Jimenez', '13141516', '999123468', '2024-09-26', '12:30', 'Pendiente', 4, 25),
('Esteban', 'Palacios', 'Martinez', '14151617', '999123469', '2024-09-27', '09:00', 'Pendiente', 7, 19),
('Clara', 'Silva', 'Nunez', '15161718', '999123470', '2024-09-27', '10:30', 'Pendiente', 8, 33),
('Santiago', 'Ramos', 'Ortiz', '16171819', '999123471', '2024-09-28', '11:00', 'Pendiente', 6, 23),
('Beatriz', 'Paredes', 'Fuentes', '17181920', '999123472', '2024-09-28', '12:30', 'Pendiente', 5, 36),
('Victor', 'Morales', 'Reyes', '18192021', '999123473', '2024-09-29', '09:00', 'Pendiente', 3, 22),
('Andrea', 'Gomez', 'Cabrera', '19202122', '999123474', '2024-09-29', '10:30', 'Pendiente', 7, 17),
('Juliana', 'Torre', 'Montes', '20212223', '999123475', '2024-09-30', '11:00', 'Pendiente', 8, 13);


-----------Registro Programacion 

INSERT INTO Programacion (CitaID, Fecha, Hora, Servicios, EspecialistaID, Nombres, ApellidoPaterno, ApellidoMaterno)
VALUES 
(1, '2024-09-21', '10:00', 'Corte de Cabello', 3, 'Carla', 'Perez', 'Garcia'),
(2, '2024-09-21', '11:00', 'Tratamiento Capilar', 6, 'Luis', 'Ramos', 'Lopez'),
(3, '2024-09-22', '09:00', 'Planchado de Cejas', 8, 'Sofia', 'Castillo', 'Vargas'),
(4, '2024-09-22', '10:30', 'Manicure Francesa', 7, 'Andres', 'Mejia', 'Rojas'),
(5, '2024-09-22', '12:00', 'Bronceado Express', 5, 'Lucia', 'Navarro', 'Diaz'),
(6, '2024-09-23', '14:00', 'Masaje Sueco', 6, 'Raul', 'Mendoza', 'Torres'),
(7, '2024-09-23', '15:00', 'Pedicure Spa', 4, 'Natalia', 'Cruz', 'Serrano'),
(8, '2024-09-24', '10:00', 'Masaje Reductor', 7, 'Ricardo', 'Flores', 'Mendez'),
(9, '2024-09-24', '11:00', 'Terapia de Reiki', 8, 'Paula', 'Suarez', 'Alvarez'),
(10, '2024-09-25', '09:30', 'Tratamiento Detox', 5, 'Jorge', 'Salinas', 'Ortega'),
(11, '2024-09-25', '11:00', 'Drenaje Linfático', 3, 'Fernanda', 'Gutierrez', 'Perez'),
(12, '2024-09-26', '10:00', 'Masaje con Piedras Calientes', 6, 'Pedro', 'Vega', 'Gomez'),
(13, '2024-09-26', '12:30', 'Pedicure con Parafina', 4, 'Lorena', 'Rios', 'Jimenez'),
(14, '2024-09-27', '09:00', 'Peinado para Eventos', 7, 'Esteban', 'Palacios', 'Martinez'),
(15, '2024-09-27', '10:30', 'Crioterapia Facial', 8, 'Clara', 'Silva', 'Nunez'),
(16, '2024-09-28', '11:00', 'Exfoliación con Sales Marinas', 6, 'Santiago', 'Ramos', 'Ortiz'),
(17, '2024-09-28', '12:30', 'Radiofrecuencia Facial', 5, 'Beatriz', 'Paredes', 'Fuentes'),
(18, '2024-09-29', '09:00', 'Terapia de Reflexología', 3, 'Victor', 'Morales', 'Reyes'),
(19, '2024-09-29', '10:30', 'Mascarilla Capilar', 7, 'Andrea', 'Gomez', 'Cabrera'),
(20, '2024-09-30', '11:00', 'Microblading', 8, 'Juliana', 'Torre', 'Montes');


------ Pago 

INSERT INTO Pagos (Fecha, Hora, ClienteNombre, DNI, CostoTotal, MetodoPago, ServicioID, ProductoID)
VALUES 
('2024-09-21', '10:30', 'Carla Perez Garcia', '11223344', 40.00, 'yape', 1, NULL),
('2024-09-21', '11:30', 'Luis Ramos Lopez', '22334455', 85.00, 'plin', 10, 2),
('2024-09-22', '09:30', 'Sofia Castillo Vargas', '33445566', 55.00, 'efectivo', 12, 4),
('2024-09-22', '11:00', 'Andres Mejia Rojas', '44556677', 50.00, 'yape', 5, NULL),
('2024-09-22', '12:30', 'Lucia Navarro Diaz', '55667788', 70.00, 'plin', 14, 8),
('2024-09-23', '14:30', 'Raul Mendoza Torres', '66778899', 95.00, 'efectivo', 20, 9),
('2024-09-23', '15:30', 'Natalia Cruz Serrano', '77889900', 60.00, 'efectivo', 7, 7),
('2024-09-24', '10:30', 'Ricardo Flores Mendez', '88990011', 100.00, 'yape', 30, 3),
('2024-09-24', '11:30', 'Paula Suarez Alvarez', '99001122', 120.00, 'efectivo', 31, 11),
('2024-09-25', '10:00', 'Jorge Salinas Ortega', '10111213', 65.00, 'plin', 28, 10),
('2024-09-25', '11:30', 'Fernanda Gutierrez Perez', '11121314', 80.00, 'yape', 15, 12),
('2024-09-26', '10:30', 'Pedro Vega Gomez', '12131415', 150.00, 'yape', 9, NULL),
('2024-09-26', '13:00', 'Lorena Rios Jimenez', '13141516', 90.00, 'plin', 25, 5),
('2024-09-27', '09:30', 'Esteban Palacios Martinez', '14151617', 45.00, 'efectivo', 19, 14),
('2024-09-27', '11:00', 'Clara Silva Nunez', '15161718', 85.00, 'plin', 33, 6),
('2024-09-28', '11:30', 'Santiago Ramos Ortiz', '16171819', 60.00, 'plin', 23, 13),
('2024-09-28', '13:00', 'Beatriz Paredes Fuentes', '17181920', 120.00, 'yape', 36, 4),
('2024-09-29', '09:30', 'Victor Morales Reyes', '18192021', 110.00, 'efectivo', 22, 7),
('2024-09-29', '11:00', 'Andrea Gomez Cabrera', '19202122', 95.00, 'efectivo', 17, NULL),
('2024-09-30', '11:30', 'Juliana Torre Montes', '20212223', 130.00, 'yape', 13, NULL);


---- Reporte 

