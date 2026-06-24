# Changelog

Todos los cambios notables de este proyecto se documentarán en este archivo.

El formato sigue la idea general de mantener un registro legible, cronológico y orientado a personas.

## [Unreleased]

### Added

- Se agregó `docs/00_vision.md` con la visión inicial de MangOS Command Center.
- Se agregó `docs/01_roadmap_mvp_1_0_0.md` con el roadmap, fases y contratos del MVP 1.0.0.
- Se agregó `docs/02_stack_arquitectura.md` con el stack técnico aprobado y la dirección arquitectónica.
- Se amplió `README.md` con visión del proyecto, alcance del MVP, conceptos PEM, stack técnico, roadmap, estructura del repositorio y estado actual de desarrollo.

### Decided

- MangOS MVP 1.0.0 se construirá como aplicación nativa de Windows.
- Stack aprobado: WinUI 3, C#, .NET, MVVM, SQLite y arquitectura por capas limpias.
- Rust queda diferido como posible core portable futuro.
- TOSTARCHI, sincronización, apps móviles y soporte multiplataforma quedan fuera del MVP 1.0.0.
- La app seguirá una filosofía local-first: primero debe funcionar localmente; la nube y la sincronización vendrán después.

### Deferred

- Servidor privado en TOSTARCHI.
- Sincronización entre dispositivos.
- App Android/iOS.
- Soporte Linux/macOS.
- IA avanzada.
- Plugins y automatizaciones profundas.
