# LogisticsFactory

Este proyecto demuestra el uso del patrón de diseño **Factory Method** implementado en una API ASP.NET Core Web API.

## Cómo probar

1. Ejecuta la API localmente o con Docker.
2. Usa Postman para hacer un POST a `/api/logistics/deliver` con el contenido:
```json
"road"
3. La respuesta será
Delivering cargo by land in a truck.
Estructura del proyecto
Controllers/: Controlador de la API
Models/: Clases Truck, Ship y ITransport
Services/: Clases Logistics, RoadLogistics, SeaLogistics
Autor
Jhon B. — Proyecto educativo basado en Refactoring.guru


### 🔹 2. Guardar y verificar que esté en la carpeta correcta

Debe estar al mismo nivel que:

- `LogisticsFactory.sln`
- `.gitignore`
- La carpeta `LogisticsApp/`
