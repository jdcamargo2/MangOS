# MangOS Command Center

MangOS Command Center es una aplicación nativa de Windows diseñada para captura personal, organización, ejecución PEM, bitácora diaria, aprendizaje y continuidad.

El proyecto sigue una filosofía **local-first**: la aplicación debe funcionar sin internet, guardar información localmente y evolucionar hacia asistencia con IA, sincronización y flujos multidispositivo solo después de estabilizar la experiencia central.

> Estado actual: fase de documentación y arquitectura.  
> Objetivo del MVP: app nativa Windows con captura, inbox, contratos PEM, cierre diario, generación de bitácora y continuidad.

---

## Visión

MangOS Command Center busca convertirse en un centro de mando personal: tranquilo, minimalista y potente.

La idea base es simple:

> El usuario escribe primero. MangOS organiza después.

La primera gran victoria del producto será permitir cerrar PEM desde la app y generar automáticamente liquidados, avances parciales, arrastres, bitácora diaria y continuidad para mañana.

---

## Principios centrales

- **Captura primero, orden después**  
  Toda idea, tarea, pregunta o contrato entra desde un flujo único de escritura.

- **Cero doble escritura**  
  Si algo se liquida, el sistema debe generar bitácora, cierre y continuidad sin duplicar trabajo manual.

- **Local-first**  
  MangOS debe seguir siendo útil aunque no haya internet.

- **Windows nativo primero**  
  El MVP prioriza una experiencia rápida y nativa en Windows antes de web, nube o expansión móvil.

- **Interfaz mínima, estructura profunda**  
  La app debe verse simple, pero sostener una lógica interna ordenada.

---

## Alcance del MVP 1.0.0

El MVP 1.0.0 se enfoca en una aplicación nativa de Windows capaz de:

- capturar entradas desde una barra central;
- guardar entradas localmente;
- convertir entradas en contratos PEM;
- gestionar estados de contratos;
- generar un cierre PEM básico;
- registrar bitácora;
- preservar continuidad para el siguiente día;
- dejar una base clara para futuras funciones de IA y sincronización.

---

## ¿Qué es PEM?

PEM significa **Protocolo de Extracción Mercenaria Académica**.

Es un protocolo personal de ejecución usado para convertir obligaciones, tareas académicas, proyectos e ideas en acciones claras, realistas y ejecutables.

MangOS Command Center implementará PEM como uno de sus flujos centrales.

Conceptos principales:

| Concepto | Significado |
|---|---|
| Contrato | Tarea concreta con objetivo, primer paso y condición de cierre |
| En caza | Contrato activo |
| Liquidado | Terminado de forma suficiente para cerrarse |
| Arrastrado | No terminado, pero recuperable después |
| En bandeja | Idea o tarea que no debe interrumpir lo activo |

---

## Stack técnico

El stack aprobado para el MVP es:

| Capa | Tecnología |
|---|---|
| Plataforma | Windows nativo |
| Interfaz | WinUI 3 |
| Lenguaje | C# |
| Runtime | .NET |
| Patrón de interfaz | MVVM |
| Base local | SQLite |
| Arquitectura | Capas limpias |
| Core portable futuro | Rust, diferido |
| Sincronización futura | TOSTARCHI u otro nodo privado, post-1.0.0 |

MangOS no comienza como una aplicación web, Electron, Tauri ni cloud-first.

---

## Arquitectura prevista

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

Regla arquitectónica:

> WinUI muestra.  
> Application coordina.  
> Domain decide.  
> Infrastructure persiste.

---

## Estructura actual del repositorio

```text
MangOS/
├─ docs/
│  ├─ 00_vision.md
│  ├─ 01_roadmap_mvp_1_0_0.md
│  └─ 02_stack_arquitectura.md
│
├─ CHANGELOG.md
└─ README.md
```

Documentos actuales:

- `00_vision.md` — visión del producto y definición del problema.
- `01_roadmap_mvp_1_0_0.md` — roadmap, fases y contratos del MVP.
- `02_stack_arquitectura.md` — stack técnico y decisión de arquitectura.

---

## Roadmap

| Versión | Objetivo |
|---|---|
| 0.1.0 | Shell inicial Windows, captura local y persistencia SQLite |
| 0.2.0 | Inbox, entradas y clasificación básica |
| 0.3.0 | Contratos PEM y gestión de estados |
| 0.4.0 | Cierre PEM diario y generación de continuidad |
| 0.5.0 | Cuaderno de aprendizaje y sistema de preguntas |
| 0.6.0 | Pulido local y consistencia interna |
| 1.0.0 | MVP completo: MangOS Command Center local-first usable |

Posibilidades post-1.0.0:

- TOSTARCHI como servidor privado de sincronización;
- app compañera para Android/iOS;
- clasificación asistida con IA;
- core portable en Rust;
- expansión a Linux/macOS;
- automatizaciones avanzadas.

---

## Estado de desarrollo

MangOS Command Center se encuentra actualmente en fase de documentación y arquitectura.

Completado hasta ahora:

- visión del producto;
- roadmap del MVP;
- decisión de stack técnico;
- dirección arquitectónica;
- base documental del repositorio.

Siguiente paso:

> Comenzar la construcción del MVP nativo de Windows.

---

## Dirección de diseño

MangOS debe sentirse como:

- un centro de mando tranquilo;
- una interfaz minimalista centrada en escritura;
- una cabina personal de ejecución;
- un sistema que reduce fricción en lugar de crear más trabajo.

La dirección visual apunta a una experiencia simple: barra central, sidebar limpio, pocos elementos visibles y acciones estructuradas bajo el capó.

---

## Fuera del MVP 1.0.0

El MVP no incluirá:

- sincronización en la nube;
- servidor TOSTARCHI;
- apps móviles;
- soporte Linux/macOS;
- automatización profunda con IA;
- sistema de plugins;
- colaboración multiusuario;
- sincronización en tiempo real;
- dashboards complejos.

Estas funciones no se descartan. Se posponen hasta validar la experiencia local en Windows.

---

## Licencia

Licencia no definida todavía.

Este repositorio se mantiene como proyecto personal/privado durante la fase temprana de diseño y MVP.

---

## Autor

Construido por Mango como parte del ecosistema personal MangOS.
