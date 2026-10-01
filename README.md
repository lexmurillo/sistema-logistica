# Sistema de inventario

Aplicación de escritorio desarrollada con C# y .NET para llevar el control de productos y existencias de un negocio.

La idea del proyecto es tener una forma sencilla de registrar productos, consultar el inventario y controlar las entradas y salidas de mercancía sin tener que hacer el conteo manualmente cada vez.

## ¿Qué quiero hacer?

El sistema permitirá:

- Registrar productos.
- Consultar la cantidad disponible.
- Aumentar o disminuir el stock.
- Registrar entradas y salidas de productos.
- Buscar productos mediante código de barras.
- Consultar los movimientos realizados.

Una de las funcionalidades que quiero implementar es la lectura de códigos de barras. La idea es que, al escanear un producto, el sistema compruebe si ya está registrado.

Si el producto no existe, permitirá registrarlo.

Si ya existe, se podrá indicar la cantidad que ingresó y esta se sumará al inventario.

Por ejemplo:

```text
Escanear producto
       ↓
¿Existe?
  ↓          ↓
 No         Sí
 ↓           ↓
Registrar   Mostrar producto
producto    y stock actual
              ↓
        Agregar cantidad
