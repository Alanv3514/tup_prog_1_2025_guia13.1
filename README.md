# Guía 13.1 - parcial 2 - 2025
Para la solucion del parcial se plantearon 4 opciones:
## 1- Ejercicio1: utilizando Vectores de Indice Comun dentro del formulario.
El manejo de las patentes y kilometrajes se hacen directamente en la clase Form1, asi como los metodos planteados por la consigna.

## 2- Ejercicio2: utilizando Clase Servicio.
El manejo de Vectores de Indice Comun se encapsula en una clase Servicio para separar la lógica de la parte visual.

###🛠️ Clase ServicioVehiculos (Ejercicio 2)
```plaintext
+----------------------------------------------------+
|        ServicioVehiculos                           |
+----------------------------------------------------+
| - patentes: string[15]                             |
| - kilometrajes: double[15]                         |
| - vehiculos: int                                   |
| - cantidadViajes: int                              |
+----------------------------------------------------+
| +CrearVehiculo(pat: string, km: double): void      |
| +CargarViaje(pat: string, km: double): void        |
| +VerKilometraje(idx: int): double                  |
| +VerPatente(idx: int): string                      |
| +VerCantidadViajes(): int                          |
| +VerCantidadVehiculos(): int                       |
| +BuscarVehiculo(pat: string): int                  |
| +Ordenar(): void                                   |
| +VerPromedioKm(): double                           |
+----------------------------------------------------+
```
## 3- Ejercicio 3: utilizano Vector de Objetos.
Se define la clase Vehiculo y se maneja la lógica del vector de vehiculos en la clase Form1.
### 🚗 Clase Vehiculo (Ejercicio 3)
```plaintext
+-------------------------------+
|          Vehiculo             |
+-------------------------------+
| - patente: string             |
| - kilometraje: double         |
+-------------------------------+
| +CrearVehiculo(pat, km): void |
| +CargarViaje(km): void        |
| +VerKilometraje(): double     |
| +VerPatente(): string         |
+-------------------------------+
```
## 3- Ejercicio 4: utilizano Vector de Objetos y Clase Servicio.
Se define la clase Vehiculo y se maneja la lógica del vector de vehiculos dentro de una Clase Servicio para poder encapsular la lógica y aislarla de la interfaz grafica..
### 🛠️ Clase Servicio (Ejercicio 4)
```plaintext
+------------------------------+
|          Servicio            |
+------------------------------+
| - vehiculos: Vehiculo[15]    |
| - cVehiculos: int            |
| - cViajes: int               |
+------------------------------+
| +CVehiculos: int             |
| +CViajes: int                |
| +CrearVehiculo(pat, km):bool |
| +CargarViaje(pat, km):bool   |
| +BuscarVehiculo(pat): int    |
| +Ordenar(): void             |
| +VerPromedioKm(): double     |
| +VerKilometraje(idx): double |
| +VerPatente(idx): string     |
+------------------------------+
```
### 🚗 Clase Vehiculo (Ejercicio 4)
```plaintext
+-----------------------------+
|         Vehiculo            |
+-----------------------------+
| - patente: string           |
| - kilometraje: double       |
+-----------------------------+
| +Vehiculo(pat, km)          |
| +VerPatente(): string       |
| +VerKilometraje(): double   |
| +CargarViaje(km): void      |
+-----------------------------+
