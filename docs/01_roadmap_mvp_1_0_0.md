# Roadmap hacia MangOS Command Center 1.0.0

## Estado del roadmap

Este documento define los hitos funcionales necesarios para construir el MVP `1.0.0` de **MangOS Command Center**.

La versión `1.0.0` representa el primer MVP estable del producto descrito en el Documento de Visión. No incluye todavía inteligencia artificial avanzada, sincronización completa en la nube, automatizaciones profundas, aplicación móvil ni colaboración multiusuario.

El objetivo de este roadmap es avanzar por versiones pequeñas, cerrables y verificables.

---

## Criterio de versionamiento

MangOS Command Center usará una estrategia basada en versionamiento semántico:

```txt
MAJOR.MINOR.PATCH
```

Ejemplo:

```txt
1.0.0
0.3.0
0.3.1
```

### Regla general

- `MAJOR`: versión mayor del producto.
- `MINOR`: nuevo hito funcional.
- `PATCH`: corrección menor sobre un hito existente.

### Aplicación en MangOS

- `0.x.0`: hito funcional nuevo antes del MVP estable.
- `0.x.y`: corrección o ajuste menor del hito actual.
- `alpha`: versión experimental o incompleta.
- `beta`: versión funcional en prueba real.
- `rc`: release candidate o candidato a versión estable.
- `1.0.0`: primer MVP estable.

Ejemplos:

```txt
0.1.0-alpha
0.1.1-alpha
0.2.0-alpha
0.8.0-beta
1.0.0-rc.1
1.0.0
```

---

# Roadmap funcional

## 0.1.0-alpha — App viva

### Objetivo

Que MangOS exista como aplicación ejecutable.

### Debe permitir

- Abrir la aplicación.
- Ver una pantalla inicial.
- Mostrar el nombre del producto.
- Mostrar una barra o caja de captura visual.
- Cerrar la aplicación sin errores.

### Fuera de alcance

- Guardar información.
- Clasificar entradas.
- Gestionar tareas.
- Gestionar contratos.
- Generar cierres.

### Sentido del hito

Este hito planta la bandera inicial: MangOS deja de ser solo una idea y empieza a existir como aplicación.

---

## 0.2.0-alpha — Captura temporal

### Objetivo

Validar el gesto central del producto: escribir, capturar y ver aparecer una entrada.

### Debe permitir

- Escribir una entrada en la barra principal.
- Enviar la entrada con Enter o con un botón.
- Mostrar la entrada en una lista temporal.
- Limpiar la barra después de capturar.

### Fuera de alcance

- Persistencia local.
- Clasificación.
- Edición avanzada.
- Estados de trabajo.

### Sentido del hito

MangOS empieza a probar su interacción principal:

```txt
escribir → capturar → ver
```

---

## 0.3.0-alpha — Persistencia local

### Objetivo

Hacer que las entradas sobrevivan después de cerrar la aplicación.

### Debe permitir

- Guardar entradas localmente.
- Cerrar la aplicación.
- Abrir la aplicación nuevamente.
- Ver entradas creadas en sesiones anteriores.

### Fuera de alcance

- Clasificación avanzada.
- Contratos PEM.
- Cierre diario.
- Sincronización en la nube.

### Sentido del hito

MangOS empieza a tener memoria propia.

---

## 0.4.0-alpha — Inbox

### Objetivo

Convertir la captura en una bandeja de entrada organizada.

### Debe permitir

- Ver todas las entradas capturadas en una vista de Inbox.
- Marcar entradas como procesadas o no procesadas.
- Editar una entrada.
- Eliminar una entrada.

### Fuera de alcance

- Clasificación automática avanzada.
- Gestión completa de tareas.
- Gestión completa de contratos.
- Cierre PEM.

### Sentido del hito

Todo lo capturado cae en un lugar confiable que puede revisarse y procesarse después.

---

## 0.5.0-alpha — Clasificación básica

### Objetivo

Empezar a transformar entradas libres en tipos de información.

### Debe permitir

Clasificar entradas como:

- tarea
- idea
- pregunta
- aprendizaje
- recordatorio
- avance
- contrato
- sin clasificar

También debe permitir corregir manualmente la clasificación.

### Fuera de alcance

- Inteligencia artificial avanzada.
- Automatización profunda.
- Sincronización externa.
- Reglas complejas de productividad.

### Sentido del hito

MangOS deja de ser solo una lista de notas y empieza a convertir información libre en estructura útil.

---

## 0.6.0-alpha — Tareas y contratos

### Objetivo

Introducir el núcleo operativo de PEM dentro de MangOS.

### Debe permitir

Crear y gestionar elementos accionables como:

- tareas simples;
- contratos PEM.

Cada tarea o contrato debe poder tener:

- título;
- descripción;
- tipo;
- área;
- siguiente acción;
- estado.

### Estados mínimos

- inbox
- activo
- pausado
- liquidado
- descartado

### Fuera de alcance

- Cierre diario completo.
- Automatizaciones.
- Estadísticas avanzadas.
- Integraciones externas.

### Sentido del hito

MangOS empieza a servir para trabajar de verdad, no solo para capturar información.

---

## 0.7.0-alpha — Vista de trabajo diario

### Objetivo

Mostrar al usuario qué importa hoy.

### Debe incluir

Una vista diaria con información como:

- contrato activo;
- siguiente acción;
- pendientes importantes;
- entradas recientes;
- contratos pausados;
- contratos arrastrados.

### Fuera de alcance

- Cierre PEM completo.
- Reportes avanzados.
- Automatizaciones.
- Sincronización.

### Sentido del hito

Al abrir la aplicación, MangOS debe ayudar al usuario a ubicarse rápidamente y continuar su trabajo.

Este hito es clave porque acerca el producto a su propósito central: funcionar como centro de mando diario.

---

## 0.8.0-beta — Cierre PEM

### Objetivo

Implementar el cierre diario de trabajo.

### Debe permitir registrar

- Qué se hizo durante el día.
- Qué contratos se liquidaron.
- Qué quedó pendiente.
- Qué debe retomarse mañana.
- Energía del día.
- Notas libres.

También debe permitir consultar cierres anteriores.

### Fuera de alcance

- IA avanzada para generar cierres automáticamente.
- Reportes complejos.
- Integración con calendario.
- Integración con gestores externos.

### Sentido del hito

PEM deja de depender de chats, memoria o archivos sueltos. MangOS empieza a registrar continuidad real entre días.

---

## 0.9.0-beta — Flujo diario completo

### Objetivo

Probar MangOS como sistema real durante varios días.

### Debe permitir completar el ciclo completo

```txt
capturar
procesar inbox
crear tarea o contrato
trabajar con estados
consultar vista diaria
cerrar PEM
retomar al día siguiente
```

### Enfoque del hito

En esta versión no se deben agregar grandes funciones nuevas. El foco debe estar en:

- probar el flujo completo;
- corregir errores;
- mejorar fricción;
- ajustar la interfaz;
- revisar si el sistema realmente ayuda en la rutina diaria.

### Sentido del hito

Esta versión debe responder una pregunta central:

```txt
¿MangOS sirve realmente para mi rutina diaria?
```

---

## 1.0.0-rc.1 — Candidato estable

### Objetivo

Preparar el primer release estable del MVP.

### Debe tener

- Flujo completo funcionando.
- Datos persistentes.
- Interfaz estable.
- README actualizado.
- Changelog actualizado.
- Exportación básica.
- Sin errores graves conocidos.

### Reglas del hito

Durante esta fase no se deben agregar funciones grandes nuevas. Solo se deben aceptar:

- correcciones;
- ajustes de experiencia;
- mejoras necesarias para estabilidad;
- documentación;
- preparación del release.

### Sentido del hito

Congelar el alcance y preparar la publicación de `1.0.0`.

---

## 1.0.0 — MVP estable

### Objetivo

Publicar la primera versión estable de MangOS Command Center.

### Debe cumplir

- Captura rápida.
- Inbox.
- Clasificación básica.
- Tareas.
- Contratos PEM.
- Estados de trabajo.
- Vista diaria.
- Cierre PEM.
- Persistencia local.
- Exportación básica.
- Uso real en Windows.

### Fuera de alcance de 1.0.0

- Inteligencia artificial avanzada.
- Sincronización completa en la nube.
- Aplicación móvil.
- Colaboración multiusuario.
- Automatizaciones profundas.
- Marketplace de plugins.
- Integraciones completas con herramientas externas.

### Sentido del hito

MangOS Command Center alcanza su primer MVP estable: un centro de mando personal mínimo, usable y alineado con la visión del producto.

---

# Lectura general del roadmap

El roadmap puede entenderse en tres bloques:

## Bloque 1 — Existencia y memoria

Versiones:

```txt
0.1.0-alpha
0.2.0-alpha
0.3.0-alpha
```

Objetivo:

```txt
MangOS existe, captura y recuerda.
```

---

## Bloque 2 — Organización y PEM

Versiones:

```txt
0.4.0-alpha
0.5.0-alpha
0.6.0-alpha
```

Objetivo:

```txt
MangOS organiza información y convierte entradas en trabajo accionable.
```

---

## Bloque 3 — Rutina diaria y estabilidad

Versiones:

```txt
0.7.0-alpha
0.8.0-beta
0.9.0-beta
1.0.0-rc.1
1.0.0
```

Objetivo:

```txt
MangOS acompaña el trabajo diario, registra cierres y permite retomar contexto.
```

---

# Versiones posteriores

Las funciones más avanzadas quedan reservadas para versiones futuras, por ejemplo:

## Posible 2.0.0

- Inteligencia artificial avanzada.
- Clasificación asistida más inteligente.
- Generación automática de resúmenes.
- Sincronización en la nube.
- Aplicación móvil.
- Automatizaciones profundas.
- Integraciones con calendarios, gestores de tareas u otros sistemas.

Estas funciones no forman parte del MVP `1.0.0`.

---

# Principio rector

Cada versión debe responder a una pregunta:

```txt
¿Qué existe ahora que antes no existía?
```

Si una versión no agrega una capacidad clara, no debe considerarse un nuevo hito `MINOR`.

El objetivo es avanzar con hitos pequeños, cerrables y verificables, sin perder de vista que `1.0.0` representa el primer MVP estable de MangOS Command Center.
