# MangOS Command Center - Stack y arquitectura técnica

Versión: 0.1  
Estado: Aprobado para MVP 1.0.0  
Fecha: 2026-06-24  
Proyecto: MangOS Command Center  
Documento relacionado:
- `docs/00_vision.md`
- `docs/01_roadmap_mvp_1_0_0.md`

---

## 1. Propósito del documento

Este documento define el stack técnico base de MangOS Command Center para el MVP 1.0.0.

Su objetivo es dejar claro:

- qué tecnologías se usarán;
- por qué se eligen;
- qué alternativas fueron consideradas;
- qué queda fuera del MVP;
- cómo se deja abierta la evolución futura hacia Rust, sincronización, TOSTARCHI y multiplataforma.

Este documento no pretende cerrar para siempre la arquitectura del proyecto. Su función es fijar una base estable para construir la primera versión funcional sin perder la visión de largo plazo.

---

## 2. Contexto del producto

MangOS Command Center será una aplicación nativa de Windows orientada a captura, organización personal, ejecución PEM, bitácora, aprendizaje y continuidad.

La prioridad del MVP 1.0.0 es construir una aplicación local-first que funcione de forma rápida, estable y sin depender de internet.

La primera gran victoria del producto será permitir que el usuario pueda capturar entradas, organizarlas, trabajar contratos PEM y cerrar el día generando bitácora, liquidados, arrastres y continuidad desde la propia app.

---

## 3. Principios técnicos

### 3.1. Local-first antes que cloud-first

MangOS debe funcionar aunque no haya internet.

La nube, la IA externa y la sincronización serán mejoras posteriores, no requisitos para capturar, revisar o cerrar PEM.

### 3.2. Nativo primero

El MVP se construirá como aplicación nativa de Windows.

No se usará una aplicación web empaquetada como escritorio. MangOS debe sentirse como una app real del sistema, no como una página web dentro de una ventana.

### 3.3. Simplicidad antes que arquitectura excesiva

La arquitectura debe permitir crecer, pero sin bloquear el primer MVP.

No se introducirá Rust, sincronización, servidor propio ni multiplataforma antes de tener una app local útil.

### 3.4. Separación estricta entre interfaz y lógica

La interfaz no debe contener reglas profundas de PEM.

Las reglas de contratos, estados, cierres, bitácoras y aprendizajes vivirán en capas internas separadas para permitir evolución futura.

### 3.5. Preparado para migrar, no obligado a migrar

El MVP se escribirá en C#/.NET, pero la lógica central se diseñará con límites claros para que, en una fase posterior, pueda extraerse parcial o totalmente a un core en Rust si el proyecto lo justifica.

---

## 4. Decisión técnica principal

Para el MVP 1.0.0, MangOS Command Center usará:

| Capa | Tecnología elegida | Estado |
|---|---|---|
| Aplicación principal | Windows nativo | Adoptado |
| Interfaz | WinUI 3 | Adoptado |
| Lenguaje principal | C# | Adoptado |
| Plataforma | .NET | Adoptado |
| Patrón de UI | MVVM | Adoptado |
| Base de datos local | SQLite | Adoptado |
| Arquitectura interna | Capas limpias | Adoptado |
| IA | API externa opcional | Diferido |
| Core Rust | Rust | Diferido |
| Sincronización | TOSTARCHI / servidor propio / alternativa futura | Post-1.0.0 |
| Multiplataforma | Avalonia, móvil nativo o core portable | Post-1.0.0 |

---

## 5. Stack aprobado para el MVP

```text
MangOS.App.Windows
├─ UI: WinUI 3
├─ Lenguaje: C#
├─ Runtime: .NET
├─ Patrón: MVVM
├─ Persistencia: SQLite
├─ Arquitectura: Presentation / Application / Domain / Infrastructure
└─ Plataforma objetivo: Windows 11
```

---

## 6. Justificación de tecnologías

### 6.1. WinUI 3

WinUI 3 se adopta como framework principal de interfaz para el MVP porque permite construir una aplicación moderna, nativa y alineada con Windows.

MangOS busca una experiencia minimalista, rápida y cercana al lenguaje visual de Windows 11. Por eso se prioriza WinUI 3 frente a alternativas web o multiplataforma desde el inicio.

WinUI 3 será responsable de:

- ventanas;
- vistas;
- controles visuales;
- navegación;
- barra de captura;
- paneles de inbox;
- paneles de contratos;
- pantallas de cierre PEM;
- experiencia visual general.

Regla:

> WinUI 3 muestra y recibe interacción; no decide la lógica profunda de MangOS.

---

### 6.2. C# y .NET

C# se adopta como lenguaje principal del MVP porque permite avanzar rápido dentro del ecosistema Windows sin sacrificar estructura, legibilidad ni mantenibilidad.

C# será usado para:

- ViewModels;
- casos de uso;
- servicios de aplicación;
- modelos iniciales;
- conexión con SQLite;
- coordinación de eventos internos;
- generación de cierres PEM;
- lógica de negocio inicial.

La decisión permite construir primero el producto y dejar la optimización extrema para cuando existan cuellos de botella reales.

---

### 6.3. MVVM

MVVM se adopta como patrón base de interfaz porque separa la vista de la lógica de presentación.

Esto ayuda a evitar que las pantallas de WinUI se conviertan en archivos gigantes llenos de lógica PEM.

Estructura esperada:

```text
View
  Pantalla visible en WinUI.

ViewModel
  Estado de pantalla, comandos y coordinación.

Application
  Casos de uso reales del sistema.

Domain
  Entidades y reglas centrales.

Infrastructure
  SQLite, archivos, APIs y servicios externos.
```

---

### 6.4. SQLite

SQLite se adopta como base local para el MVP porque MangOS necesita funcionar sin servidor y guardar información estructurada de forma simple.

SQLite será usado para almacenar:

- entradas;
- contratos;
- estados PEM;
- bitácoras;
- cierres;
- aprendizajes;
- preguntas;
- eventos internos;
- configuración local.
- 
---

### 6.5. Rust diferido

Rust no se usará como requisito inicial del MVP.

Sin embargo, se mantiene como ruta futura para extraer un core portable y altamente optimizado si MangOS crece hacia múltiples plataformas o necesita lógica compartida de alto rendimiento.

Rust podría usarse posteriormente para:

- motor de reglas PEM;
- clasificación local;
- generación de cierres;
- sincronización;
- procesamiento de eventos;
- exportación/importación;
- core portable entre Windows, Linux, Android, iOS y macOS.

Decisión:

> Rust queda preparado arquitectónicamente.

---

## 7. Arquitectura interna propuesta

MangOS se organizará por capas.

```text
src/
└─ MangOS.App.Windows/
   ├─ Presentation/
   │  ├─ Views/
   │  ├─ ViewModels/
   │  ├─ Components/
   │  └─ Navigation/
   │
   ├─ Application/
   │  ├─ UseCases/
   │  ├─ Services/
   │  └─ DTOs/
   │
   ├─ Domain/
   │  ├─ Entities/
   │  ├─ ValueObjects/
   │  ├─ Enums/
   │  └─ Rules/
   │
   ├─ Infrastructure/
   │  ├─ Persistence/
   │  ├─ Repositories/
   │  ├─ Files/
   │  └─ External/
   │
   └─ App.xaml
```

---

## 8. Responsabilidad de cada capa

### 8.1. Presentation

Contiene la interfaz de usuario.

Incluye:

- vistas WinUI;
- componentes visuales;
- ViewModels;
- navegación;
- comandos visibles.

No debe contener:

- reglas de liquidación;
- lógica de cierre PEM;
- consultas SQL directas;
- reglas de clasificación;
- decisiones de sincronización.

---

### 8.2. Application

Contiene los casos de uso del sistema.

Ejemplos:

- crear entrada;
- clasificar entrada;
- crear contrato;
- mover contrato a En caza;
- liquidar contrato;
- arrastrar contrato;
- generar cierre PEM;
- generar continuidad;
- registrar aprendizaje.

Esta capa coordina el flujo, pero no depende de detalles visuales.

---

### 8.3. Domain

Contiene el corazón conceptual de MangOS.

Entidades iniciales:

- Entrada;
- Contrato;
- EstadoContrato;
- Bitacora;
- CierrePEM;
- Aprendizaje;
- Pregunta;
- EventoMangOS.

Esta capa debe mantenerse lo más pura posible.

No debe depender de WinUI, SQLite, archivos ni APIs externas.

---

### 8.4. Infrastructure

Contiene detalles técnicos.

Incluye:

- SQLite;
- repositorios;
- archivos locales;
- exportaciones;
- importaciones;
- clientes HTTP futuros;
- integración futura con IA;
- integración futura con sincronización.

---

## 9. Modelo técnico inicial

Entidades mínimas del MVP:

```text
Entrada
- Id
- Texto
- Tipo
- Estado
- FechaCreacion
- FechaActualizacion
- Tags

Contrato
- Id
- Titulo
- Objetivo
- PrimerPaso
- Estado
- LiquidadoCuando
- FechaCreacion
- FechaActualizacion

Bitacora
- Id
- Fecha
- Area
- Estado
- QueSeHizo
- Arrastre

Aprendizaje
- Id
- Error
- Correccion
- Ejemplo
- FechaCreacion

CierrePEM
- Id
- Fecha
- ResumenLiquidado
- ResumenParcial
- ResumenArrastrado
- ContinuidadManana
```

---

## 10. Flujo técnico principal del MVP

### 10.1. Captura

```text
Usuario escribe en barra central
↓
MangOS crea Entrada
↓
Entrada queda guardada en SQLite
↓
Entrada aparece en Inbox
```

### 10.2. Conversión a contrato

```text
Entrada seleccionada
↓
Usuario decide convertir en Contrato
↓
MangOS solicita objetivo, primer paso y condición de liquidación
↓
Contrato queda guardado
↓
Contrato aparece en panel PEM
```

### 10.3. Liquidación

```text
Contrato en caza
↓
Usuario marca como liquidado
↓
MangOS registra evento
↓
Contrato cambia de estado
↓
Dato queda disponible para cierre PEM
```

### 10.4. Cierre PEM

```text
MangOS revisa contratos, eventos y bitácoras del día
↓
Genera resumen
↓
Genera liquidados, parciales y arrastres
↓
Genera continuidad para mañana
↓
Guarda CierrePEM
```

---

## 11. Decisiones descartadas para el MVP

### 11.1. Electron

Electron queda descartado para el MVP porque MangOS no busca ser una aplicación web empaquetada.

Aunque Electron permite desarrollo rápido y multiplataforma, contradice la prioridad de app nativa, ligera y profundamente integrada con Windows.

Estado: descartado.

---

### 11.2. Tauri

Tauri queda en observación, pero no se adopta para el MVP.

Aunque es más ligero que Electron y usa Rust en el backend, su interfaz normalmente se construye con tecnologías web. Eso no encaja con la dirección nativa actual de MangOS.

Estado: no adoptado.

---

### 11.3. Avalonia

Avalonia se mantiene como alternativa futura si MangOS necesita escritorio multiplataforma.

No se adopta en el MVP porque la prioridad inmediata es una experiencia Windows nativa, no multiplataforma.

Estado: candidato futuro.

---

### 11.4. .NET MAUI

.NET MAUI se mantiene como alternativa futura para Android, iOS, macOS y Windows.

No se adopta en el MVP porque MangOS 1.0.0 no necesita móvil completo ni sincronización entre dispositivos.

Estado: candidato futuro.

---

### 11.5. Flutter

Flutter se descarta para el MVP porque prioriza una UI propia multiplataforma antes que una experiencia nativa Windows.

Puede ser útil para productos multiplataforma rápidos, pero no coincide con la dirección actual de MangOS.

Estado: descartado para MVP.

---

### 11.6. Qt

Qt queda descartado para el MVP por complejidad inicial.

Aunque es potente y multiplataforma, introduce más fricción técnica de la necesaria para construir la primera versión de MangOS.

Estado: descartado para MVP.

---

## 12. Radar técnico de MangOS

| Tecnología | Estado | Razón |
|---|---|---|
| WinUI 3 | Adoptar | Framework principal para Windows nativo |
| C# | Adoptar | Lenguaje principal del MVP |
| .NET | Adoptar | Plataforma base del desarrollo |
| SQLite | Adoptar | Persistencia local-first |
| MVVM | Adoptar | Separación entre UI y lógica |
| CommunityToolkit.Mvvm | Probar | Puede reducir código repetitivo en ViewModels |
| Rust | Evaluar después | Candidato para core portable |
| Avalonia | Evaluar después | Candidato multiplataforma desktop |
| TOSTARCHI Server | Post-1.0.0 | Nodo privado de sincronización futura |
| API externa de IA | Post-MVP local | Clasificación y resumen asistido |
| PowerSync | Investigar después | Sincronización local-first futura |
| Tauri | Mantener en observación | Ligero, pero UI web |
| Electron | Evitar | Demasiado pesado y contrario a app nativa |
| Flutter | Evitar para MVP | Multiplataforma, pero no Windows nativo |
| Qt | Evitar para MVP | Potente, pero costoso en complejidad |

---

## 13. Reglas de implementación

### 13.1. Regla de frontera

Toda lógica PEM debe vivir fuera de la vista.

Incorrecto:

```text
MainWindow.xaml.cs decide si un contrato está liquidado.
```

Correcto:

```text
LiquidarContratoUseCase ejecuta la decisión.
MainWindow solo muestra el resultado.
```

---

### 13.2. Regla de persistencia

La UI no debe hablar directamente con SQLite.

Incorrecto:

```text
ViewModel ejecuta SQL.
```

Correcto:

```text
ViewModel llama caso de uso.
Caso de uso llama repositorio.
Repositorio usa SQLite.
```

---

### 13.3. Regla de eventos

Las acciones importantes deben poder convertirse en eventos.

Ejemplos:

```text
EntradaCreada
ContratoCreado
ContratoMovidoAEnCaza
ContratoLiquidado
ContratoArrastrado
CierreGenerado
AprendizajeRegistrado
```

Esto permitirá que, en el futuro, MangOS pueda generar bitácoras, sincronizar datos y reconstruir historial con menor fricción.

---

### 13.4. Regla anti-sobreingeniería

No se implementará una abstracción compleja si no desbloquea el MVP.

Si una tecnología, patrón o módulo no ayuda a capturar, organizar, trabajar contratos o cerrar PEM, queda fuera del MVP.

---

## 14. Qué queda fuera del MVP 1.0.0

No entra todavía:

- servidor TOSTARCHI;
- sincronización entre dispositivos;
- app móvil;
- Linux/macOS;
- IA obligatoria;
- Rust obligatorio;
- cifrado avanzado;
- plugins;
- automatizaciones profundas;
- integración TickTick;
- integración calendario;
- multiusuario;
- colaboración en tiempo real.

Estos elementos no se descartan. Se posponen para no destruir el foco del MVP.

---

## 15. Ruta de evolución técnica

### 15.1. MVP 1.0.0

```text
WinUI 3 + C# + SQLite
Captura
Inbox
Contratos
Cierre PEM básico
Bitácora
Continuidad
```

### 15.2. Después de 1.0.0

```text
TOSTARCHI como servidor personal
Sincronización entre Windows y celular
IA para clasificación
Backups automáticos
Exportaciones
```

### 15.3. Evolución mayor futura

```text
Core Rust portable
App móvil
Linux/macOS
Sync robusta
IA local
Automatizaciones profundas
```

---

## 16. Riesgos técnicos

| Riesgo | Impacto | Mitigación |
|---|---|---|
| Sobrearquitectura temprana | Alto | Construir primero flujo local mínimo |
| Mezclar UI con lógica PEM | Alto | Respetar capas desde el inicio |
| SQLite mal modelado | Medio | Empezar con modelo simple y migraciones controladas |
| Querer meter Rust demasiado pronto | Medio/alto | Diseñar frontera, no implementarla aún |
| Perder foco por sync/TOSTARCHI | Alto | Mantenerlo post-1.0.0 |
| UI demasiado compleja | Medio | Priorizar barra central, inbox y contratos |
| IA antes de reglas simples | Medio | Primero clasificación manual/reglas básicas |

---

## 17. Criterio de aceptación del stack

El stack queda validado si permite construir:

- una ventana Windows funcional;
- una barra de captura;
- persistencia local en SQLite;
- una lista de entradas;
- contratos PEM con estados;
- cierre PEM básico;
- bitácora guardada;
- continuidad para mañana;
- estructura interna clara para crecer.

---

## 18. Decisión final

MangOS Command Center MVP 1.0.0 se construirá con:

```text
WinUI 3 + C# + .NET + MVVM + SQLite
```

La arquitectura se diseñará con capas limpias para permitir que, después de validar el producto, se evalúe:

```text
Rust core
TOSTARCHI server
Sincronización
Multiplataforma
IA avanzada
```

Decisión aprobada:

> Construir primero una app Windows local-first, nativa, útil y mantenible.  
> Preparar el futuro sin cargarlo sobre el MVP.

---

## 19. Referencias consultadas

Este documento toma como inspiración prácticas de documentación técnica usadas en ingeniería de software profesional:

- Google Cloud: Architecture Decision Records.
- Martin Fowler: Architecture Decision Record.
- Microsoft Azure Well-Architected Framework: Maintain an Architecture Decision Record.
- Thoughtworks Technology Radar: Lightweight Architecture Decision Records.
- Thoughtworks Technology Radar FAQ.
