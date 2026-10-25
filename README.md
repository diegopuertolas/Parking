# Parking

Crear una clase abstracta:

```csharp
Vehiculo
```

con:

- Matrícula.
- Marca.

Crear las clases:

```text
Vehiculo
 |
 +-- Coche
 |
 +-- Moto
 |
 +-- Furgoneta
```

Añadir al menos una propiedad específica a cada clase.

Crear varios vehículos y almacenarlos en:

```csharp
List<Vehiculo>
```

Crear un menú:

```text
=== PARKING ===

1. Ver vehículos
2. Buscar por matrícula
3. Mostrar coches
0. Salir
```

El programa deberá continuar funcionando hasta seleccionar la opción `0`.

Separar cada operación en un método.

#### Validar el menú

El programa deberá controlar entradas como:

```text
Pepe
-1
25
2.5
```

Utilizar `TryParse()`.

Una entrada incorrecta no deberá finalizar la aplicación.
