# Sistema de inventario

Sistema de escritorio desarrollado con C# y .NET para facilitar el control y seguimiento del inventario de un negocio.

El proyecto nace de una idea sencilla: evitar que el control de mercancía dependa de conteos manuales cada vez que se necesita conocer cuántos productos hay disponibles.

La aplicación centraliza el registro de productos, las cantidades disponibles y los movimientos de inventario, permitiendo tener una visión más clara del estado de la mercancía.

## Sobre el proyecto

El proyecto está pensado como un módulo de inventario que pueda formar parte de una solución más grande para la gestión de un negocio.

La aplicación permite registrar productos y mantener actualizada su cantidad disponible. Para facilitar este proceso, se implementa la identificación de productos mediante códigos de barras y códigos QR.

El flujo principal parte de la identificación del producto:

```text
Escanear código
      ↓
Buscar producto
      ↓
¿El producto existe?
   ↓              ↓
  No              Sí
   ↓              ↓
Registrar       Mostrar información
producto        y stock actual
   ↓              ↓
   └───────┬──────┘
           ↓
    Actualizar stock
           ↓
 Registrar movimiento
