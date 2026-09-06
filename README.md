# Guía Práctica - DRS

Ejercicios de guia practica

---

## 📋 Requisitos Previos

Para compilar y ejecutar los programas de este repositorio, es necesario contar con **.NET SDK** instalado en tu sistema.

> [!IMPORTANT]
> Los proyectos están configurados para la versión de destino **.NET 10.0 (`net10.0`)**. Asegúrate de instalar el SDK correspondiente a .NET 10.0 o superior.

### 1. Descarga e Instalación

Puedes descargar el SDK oficial desde el sitio de Microsoft:
- [Descargar .NET SDK](https://dotnet.microsoft.com/download)

### 2. Verificar la Instalación

Abre una terminal o consola de comandos y ejecuta:

```bash
dotnet --version
```

Asegúrate de que la salida indique una versión `10.0.x` (o compatible con `net10.0`).

---

## 📁 Estructura del Proyecto

El repositorio contiene los siguientes proyectos de consola:

- `ejercicio 1/`: Ejercicio Práctico 1
- `ejercicio 2/`: Ejercicio Práctico 2
- `ejercicio 3/`: Ejercicio Práctico 3
- `ejercicio 4/`: Ejercicio Práctico 4
- `ejercicio 5/`: Ejercicio Práctico 5

---

## 🚀 Ejecución de los Programas

Puedes ejecutar cualquiera de los ejercicios de dos maneras:

### Opción 1: Desde la raíz del repositorio

```bash
dotnet run --project "ejercicio 1"
```
*(Reemplaza `"ejercicio 1"` por el ejercicio que desees ejecutar, por ejemplo: `"ejercicio 2"`, `"ejercicio 3"`, etc.)*

### Opción 2: Entrando a la carpeta del ejercicio

1. Navega al directorio del ejercicio correspondiente:
   ```bash
   cd "ejercicio 1"
   ```
2. Ejecuta el programa con:
   ```bash
   dotnet run
   ```
