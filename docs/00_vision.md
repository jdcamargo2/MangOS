# Documento de Visión del Producto

## 1. Nombre del producto

**MangOS Command Center**

## 2. Resumen ejecutivo

MangOS Command Center es una aplicación nativa de Windows para capturar, organizar y gestionar información personal de trabajo, estudio y proyectos desde una interfaz simple basada en escritura natural.

El producto busca resolver un problema común: las personas generan ideas, tareas, preguntas, aprendizajes y pendientes en distintos momentos, pero esa información suele quedar dispersa en notas, chats, calendarios, gestores de tareas y documentos. Esto obliga al usuario a clasificar manualmente, copiar información entre herramientas y recordar qué debe retomarse después.

MangOS Command Center propone una experiencia centralizada: el usuario escribe una entrada en una barra principal y el sistema la registra, clasifica y convierte en el tipo de elemento correspondiente: tarea, idea, pregunta, aprendizaje, recordatorio, proyecto o registro de avance.

La visión del producto es construir un centro de mando personal que reduzca el trabajo administrativo de organizarse y permita que el usuario se concentre en pensar, decidir y ejecutar.

## 3. Problema

Las herramientas actuales de productividad suelen resolver partes separadas del flujo personal:

- los gestores de tareas guardan pendientes;
- las aplicaciones de notas almacenan ideas;
- los calendarios organizan horarios;
- los sistemas de estudio guardan aprendizajes;
- los documentos registran avances;
- los chats capturan pensamientos rápidos.

El problema aparece cuando el usuario necesita conectar todo eso. Una idea puede convertirse en proyecto. Una pregunta puede convertirse en aprendizaje. Una tarea terminada debería generar un registro. Una sesión de trabajo debería dejar continuidad para el día siguiente.

Cuando estas conexiones dependen totalmente del usuario, el sistema se vuelve difícil de mantener. La organización termina requiriendo tanto esfuerzo que interrumpe el flujo de trabajo.

## 4. Oportunidad

Existe una oportunidad para crear una aplicación que funcione como una capa superior de organización personal: una herramienta que no reemplace necesariamente todas las aplicaciones existentes, sino que conecte captura, clasificación, ejecución y revisión desde un mismo entorno.

El valor principal no está en crear “otra app de tareas”, sino en crear un sistema que transforme entradas libres en estructura útil.

La oportunidad inicial se concentra en usuarios que trabajan con múltiples proyectos, estudian, investigan, programan o necesitan registrar avances de forma constante.

## 5. Usuarios objetivo

### Usuario principal

Personas que gestionan varios proyectos personales, académicos o técnicos al mismo tiempo y necesitan capturar ideas, organizar tareas, registrar avances y retomar contexto sin perderse entre herramientas.

Ejemplos:

- estudiantes universitarios;
- desarrolladores;
- investigadores autodidactas;
- creadores de proyectos personales;
- personas que trabajan con sistemas de notas, tareas y documentación.

### Usuario secundario

Personas que no necesitan un sistema avanzado, pero sí una herramienta simple para registrar pendientes, notas, preguntas, recordatorios y pequeños avances diarios.

Este usuario necesita una interfaz clara, con poco vocabulario técnico y funciones visibles solo cuando sean necesarias.

## 6. Propuesta de valor

MangOS Command Center permite que el usuario capture información en lenguaje natural y la convierta en organización accionable.

La propuesta de valor se resume en cinco puntos:

1. **Captura rápida:** el usuario escribe sin decidir primero dónde guardar cada cosa.
2. **Clasificación asistida:** el sistema identifica si una entrada parece tarea, idea, pregunta, aprendizaje, recordatorio o proyecto.
3. **Ejecución organizada:** las tareas y proyectos pueden moverse por estados claros de trabajo.
4. **Cierre automático:** el sistema puede generar resúmenes, registros y continuidad después de una sesión de trabajo.
5. **Interfaz mínima:** la aplicación muestra poco ruido visual, pero mantiene estructura profunda bajo el capó.

## 7. Declaración de visión

**MangOS Command Center será una aplicación nativa de Windows que permita capturar ideas, tareas, preguntas y aprendizajes desde una sola interfaz, transformándolos automáticamente en estructura útil para ejecutar, revisar y continuar el trabajo sin fricción.**

## 8. Principios del producto

### 8.1 Captura primero, orden después

El usuario no debe decidir desde el inicio si algo es una tarea, idea, nota o pregunta. Primero captura. Luego el sistema ayuda a clasificar.

### 8.2 Cero doble escritura

La misma información no debe copiarse manualmente en varios lugares. Si una tarea se completa, el sistema debe registrar el avance y actualizar las vistas necesarias.

### 8.3 Minimalismo operativo

La interfaz debe ser simple y tranquila. La pantalla principal debe mostrar lo esencial: saludo, barra de captura, resumen del día y acciones principales.

### 8.4 Local-first con conexión a red

La aplicación debe funcionar en Windows aunque no haya conexión a internet para capturar y consultar información local. La conexión web se usará para integraciones externas, sincronización, APIs y clasificación asistida.

### 8.5 Usuario en control

El sistema puede sugerir clasificaciones, destinos y acciones, pero el usuario debe poder corregir, editar o descartar cualquier decisión.

### 8.6 Progresión por capas

El producto debe poder usarse de forma simple al inicio y revelar funciones avanzadas solo cuando el usuario las necesite.

## 9. Alcance inicial

La primera versión del producto se concentrará en:

- aplicación nativa de Windows;
- barra de captura principal;
- registro local de entradas;
- clasificación básica de entradas;
- vista de inbox;
- gestión básica de tareas o contratos;
- estados de trabajo;
- resumen diario o cierre de sesión;
- almacenamiento local con posibilidad de exportación.

## 10. Fuera de alcance inicial

La primera versión no intentará incluir:

- sincronización completa en la nube;
- aplicación móvil;
- colaboración multiusuario;
- inteligencia artificial avanzada obligatoria;
- integración completa con todos los calendarios o gestores de tareas;
- sistema complejo de metas;
- automatizaciones profundas;
- marketplace de plugins.

Estas funciones pueden explorarse en fases posteriores, pero no forman parte del primer producto mínimo.

## 11. Experiencia deseada

Al abrir MangOS Command Center, el usuario debe encontrar una pantalla limpia y amable.

La interacción principal debe ser escribir:

- “recordar pagar mañana”;
- “idea para proyecto de app de eventos”;
- “pregunta sobre WebAssembly”;
- “terminé el resumen de investigación”;
- “crear tarea para revisar documentos”.

El sistema debe registrar la entrada, sugerir una clasificación y permitir que el usuario confirme o corrija la acción.

La experiencia debe sentirse más cercana a una conversación ordenada que a una hoja de cálculo o tablero saturado.

## 12. Diferenciación

MangOS Command Center se diferencia de una app tradicional de tareas porque no parte de listas manuales, sino de captura libre y clasificación asistida.

Se diferencia de una app de notas porque no solo guarda información: intenta convertirla en acción, seguimiento o aprendizaje.

Se diferencia de un calendario porque no se limita al tiempo: también organiza contexto, estados y continuidad.

Se diferencia de un chatbot porque no solo responde: estructura y conserva el flujo de trabajo del usuario.

## 13. Indicadores de éxito

El producto será exitoso si logra:

- reducir el tiempo dedicado a organizar manualmente información;
- permitir capturar ideas o tareas sin interrumpir el trabajo;
- generar resúmenes útiles al cierre de una sesión;
- mostrar claramente qué está pendiente, en progreso o terminado;
- permitir retomar contexto después de varios días;
- ser usable por un usuario avanzado y también por un usuario simple;
- mantener una interfaz limpia aunque el sistema crezca.

## 14. Riesgos iniciales

Los principales riesgos del producto son:

- construir demasiadas funciones antes de validar el flujo principal;
- crear una interfaz más compleja que el problema original;
- depender demasiado pronto de servicios externos;
- usar vocabulario interno que usuarios nuevos no entiendan;
- convertir la organización en otra carga manual;
- perder el enfoque de aplicación simple y fluida.

## 15. Primera meta del producto

La primera meta es construir una versión mínima que permita:

1. abrir la aplicación;
2. escribir una entrada en una barra principal;
3. guardar esa entrada localmente;
4. clasificarla de forma básica;
5. verla en una lista organizada;
6. mover una tarea entre estados;
7. generar un resumen simple del día.
