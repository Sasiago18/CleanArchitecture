Este proyecto implementa una arquitectura basada en Clean Architecture con el objetivo de desarrollar una aplicación backend organizada, escalable y mantenible. El sistema está enfocado en la gestión de inventario, permitiendo administrar diferentes entidades como productos, proveedores, categorías, unidades de medida y movimientos de inventario.

El desarrollo del proyecto sigue principios de ingeniería de software como separación de responsabilidades, bajo acoplamiento y reutilización de código, aplicando el patrón Repository para abstraer el acceso a datos y facilitar la interacción con la base de datos mediante Entity Framework Core.
Arquitectura del Proyecto

El proyecto está organizado siguiendo el enfoque de Clean Architecture, separando claramente las responsabilidades en diferentes capas.

1. Domain

Contiene las entidades principales del sistema y representa el núcleo del dominio del negocio.

Entidades implementadas:

Producto

Categoría

Proveedor

Existencia

MovimientoInventario

UnidadMedida

2. Application

Define las interfaces de los repositorios y la lógica de aplicación.
Esta capa no depende de la infraestructura, lo que permite mantener la arquitectura desacoplada.

Aquí se encuentran interfaces como:

IRepositoryBase

IProductoRepository

IProveedorRepository

IExistenciaRepository

IMovimientoInventarioRepository

3. Infrastructure

Contiene la implementación concreta del acceso a datos utilizando Entity Framework Core.

En esta capa se implementa:

RepositoryBase<T>: repositorio genérico que centraliza las operaciones CRUD.

Repositorios específicos para cada entidad.

Configuración de servicios e inyección de dependencias.

Patrón Repository

El proyecto implementa el Repository Pattern, el cual permite separar la lógica de acceso a datos de la lógica de negocio.

Se utiliza un repositorio genérico (RepositoryBase<T>) que implementa operaciones comunes como:

Add

Update

Delete

Get

GetAll

Los repositorios específicos de cada entidad heredan de este repositorio base, evitando duplicación de código y mejorando la mantenibilidad del sistema.
