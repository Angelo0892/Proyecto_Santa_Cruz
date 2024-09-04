-- Tabla Productos
CREATE TABLE Productos (
    IDProducto INT PRIMARY KEY IDENTITY(1,1),  -- Auto-incrementación
    NombreProd VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(255) NULL,
    PrecioCompra DECIMAL(10, 2) NOT NULL,   -- Precio de compra/costo
    PrecioVenta DECIMAL(10, 2) NOT NULL,   -- Precio de venta
    CantidadDisponible INT NOT NULL,         -- Cantidad disponible
    FechaIngreso DATE NOT NULL,
    Categoria VARCHAR(50) NULL
);

-- Tabla IngresoProductos
CREATE TABLE IngresoProductos (
    IDIngreso INT PRIMARY KEY IDENTITY(1,1),  -- Auto-incrementación
    IDProducto INT NOT NULL,
    CantidadIngresada INT NOT NULL,
    Fecha DATE NOT NULL,
    FOREIGN KEY (IDProducto) REFERENCES Productos(IDProducto)
);

-- Tabla Ventas
CREATE TABLE Ventas (
    IDVenta INT PRIMARY KEY IDENTITY(1,1),  -- Auto-incrementación
    FechaVenta DATE NOT NULL,
    TotalVenta DECIMAL(10, 2) NOT NULL
);

-- Tabla DetalleVenta
CREATE TABLE DetalleVenta (
    IDVenta INT NOT NULL,
    IDProducto INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (IDVenta, IDProducto),  -- Clave primaria compuesta
    FOREIGN KEY (IDVenta) REFERENCES Ventas(IDVenta),
    FOREIGN KEY (IDProducto) REFERENCES Productos(IDProducto)
);

SELECT * FROM Productos;