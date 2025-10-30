# ☕ Coffee Store App

> Aplicación moderna desarrollada en **C#** con **.NET** que impulsa una experiencia digital única para cafeterías, implementando **arquitecturas limpias**, **principios SOLID** y diversos frameworks para escalar y mantener con facilidad.

---

## 🧩 Descripción General

La **Coffee Store App** es una aplicación enfocada en la **gestión integral de ventas, inventario y clientes** en entornos de cafetería.  
Su objetivo es ofrecer una interfaz intuitiva y un backend sólido, garantizando **rendimiento, mantenibilidad y extensibilidad**.

---

## 🚀 Tecnologías Utilizadas

- 🧠 **Lenguaje:** C#  
- 🛠️ **Framework principal:** .NET 9  
- 🧱 **Arquitectura:** Limpia (Clean Architecture)  
- 🧩 **Patrones de diseño:** SOLID  
- ⚙️ **Frameworks complementarios:**
  - Entity Framework Core (ORM)
  - AutoMapper (Mapeo de objetos)
  - MediatR (Manejo de comandos y consultas)
  - xUnit / NUnit (Pruebas automatizadas)

---

## 🧱 Estructura del Proyecto

CoffeeStoreApp/
│
├── Core/ # Entidades, Interfaces, Casos de uso
├── Infrastructure/ # Persistencia, repositorios y adaptadores
├── Application/ # Lógica de negocio, servicios y validaciones
├── WebAPI/ # Endpoints RESTful y controladores
└── Tests/ # Pruebas unitarias y de integración

text

---

## 🧭 Principios Implementados

- **Single Responsibility:** Cada clase cumple una única función específica.  
- **Open/Closed:** Código abierto para extensión, cerrado para modificación.  
- **Liskov Substitution:** Subtipos pueden reemplazar sus tipos base sin romper el sistema.  
- **Interface Segregation:** Interfaces específicas, no genéricas.  
- **Dependency Inversion:** Dependencias hacia abstracciones, no implementaciones concretas.

---

## 🎯 Objetivos del Proyecto

- Optimizar los procesos de venta y facturación.  
- Mejorar la experiencia del cliente a través de una interfaz clara y responsiva.  
- Facilitar el mantenimiento del código siguiendo buenas prácticas.  
- Escalar fácilmente nuevas funcionalidades o módulos.

---

## 💡 Características Principales

- 🏪 Gestión de productos, inventario y precios.  
- 👤 Módulo de clientes con historial de compras.  
- 💳 Integración con sistemas de pago.  
- 📈 Reportes visuales y métricas de rendimiento.  
- 🔒 Seguridad basada en autenticación JWT y roles.

---

## 🔄 Flujo de Trabajo

1. El cliente realiza un pedido desde la interfaz web.  
2. El backend procesa la orden aplicando lógica de negocio.  
3. Se actualiza el inventario y se registra la transacción.  
4. El sistema genera reportes y estadísticas automáticas.

---
