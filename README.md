### Punto 1

a. Crear una Tabla “ObraDeArte” en SQL Server con los siguientes campos (id integer, nombre nvarchar(20), AnioCreacion int). 

b. Crear una solución [ApellidoInicialNombre]-2doParcial.sln (ejemplo SanchezP-2doParcial.sln y agregar un proyecto biblioteca de clases llamado BD.

c. Dentro del proyecto BD y Utilizando EF Core, Enfoque DatabaseFirst, crear el modelo conceptual, en una carpeta llamada “ModeloEF”.

### Punto 2

a. Agregar un proyecto ASP.Net Core donde solamente exista un controller llamado ObrasDeArteController, y el mismo permita crear nuevas Obras de Arte, esta página o vista tendrá los controles Nombre obra de arte, año de creación, con un botón grabar nueva obra de arte.

b. Generar el código necesario para almacenar una nueva Obra de arte por medio del botón grabar.

### Punto 3

Una vez grabada, se debe redirigir a una acción llamada /ObrasDeArte/sigloxix que muestre:

a. todas las obras de arte cuyo año de creación haya sido dentro del siglo XIX (1800-1899).

b. Los campos a visualizar son Nombre y Año de Creación.

c. Ordenadas por Año de creación de manera descendente (ej: se visualizará primero en la lista una obra de arte de 1890 antes que una de 1810)

| Nombre obra de arte |	Año creación |
| ------------------- | ------------ |
| La noche estrellada |		1889     |
| Entierro en Ornans  |	    1849     |

### Punto 4

Agregar un proyecto web api a la solución y agregue un controlador para que el endpoint o url http://localhost:4444/obrasdearte/1 devuelva el JSON correspondiente a la obra de arte con id=1 (el nro de puerto 4444 en la url es solo a modo de ejemplo).

### Punto 5

Calidad de código

a. Separar al menos la capa de Servicios (Lógica de negocio) en un proyecto de biblioteca de clases para que pueda ser utilizado tanto en la aplicación asp.net como en el proyecto web api.

b. Utilizar interfaces e implementa la inyección de dependencias en la clase Startup.cs.

c. Remover aquellos archivos no necesarios para esta aplicación como HomeController y sus vistas.

### Aclaraciones: 

- Se debe utilizar EF Core 5 y LINQ/Expresiones Lambda sin excepción.
- No es obligatorio controlar las validaciones de ingreso de información.