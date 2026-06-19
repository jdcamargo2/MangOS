# Ficha de proyecto — Dell Inspiron Mini 10

Proyecto: Diagnóstico y restauración de Dell Inspiron Mini 10 / PP19S
Estado: Standby

## Contexto

Se abrió una Dell Inspiron Mini 10 funcional pero inestable. La máquina enciende solo bajo una condición específica: batería conectada + cargador conectado. Fue desmontada parcialmente, revisada visualmente y vuelta a armar correctamente.

## Hallazgos
- La laptop está visualmente bien conservada.
- No se observaron daños evidentes: corrosión, quemaduras o piezas rotas.
- Tiene disco duro original WD1600BEVT-75ZTC2, Western Digital Scorpio Blue, 160 GB.
- La placa base observada corresponde a una construcción compacta/fanless.
- No tiene ventilador; usa disipación pasiva.
- Pasta térmica y pads térmicos presentes, aparentemente funcionales.
- El teclado sale como módulo completo y la construcción interna es bastante modular.
- Se logró entrar a la BIOS después del rearmado.
- En BIOS duró aproximadamente 2 minutos 12 segundos antes de apagarse.
- No presentó calentamiento notable antes de apagarse.

La BIOS mostró advertencia:

- “The battery cannot be identified. This system will be unable to charge this battery.”
- La batería instalada es CS-DEM911NB, no original.
- Bajo la batería aparece etiqueta Dell:
- CN-0Y534N-12961-98U-26F4-A00 / DP/N 0Y534N.
- El cargador tampoco es original Dell.
- El cargador fue medido con multímetro y entrega voltaje, pero eso no confirma que       funcione correctamente bajo carga ni que sea reconocido por la laptop.

## Diagnóstico actual

El problema ya no apunta principalmente a disco, Windows o temperatura.

La hipótesis más fuerte es:

Falla de alimentación por cargador/batería no originales o no reconocidos por Dell.

El dato crítico es:

La laptop debería poder encender solo con cargador y sin batería, pero no lo hace.

Esto sugiere revisar primero el adaptador de corriente antes de comprar batería o seguir desmontando.

## Sospechosos principales

- Cargador genérico/no reconocido por Dell.
- Pin central de identificación Dell ausente o fallando.
- Batería no original incompatible, dañada o con chip de identificación no válido.
- Circuito interno de carga/alimentación, solo si falla también con cargador Dell original.

### Siguiente acción

- Probar con un cargador Dell original compatible.

Condiciones mínimas:

- voltaje compatible, probablemente 19V–19.5V;
- amperaje igual o mayor al requerido;
- punta compatible;
- preferiblemente Dell original, no universal genérico.

### Prueba a realizar:

1. Retirar batería.
2. Conectar cargador Dell original compatible.
3. Encender la laptop.
4. Entrar a BIOS.
5. Dejarla encendida al menos 10 minutos.

### Criterio de avance

- Si enciende sin batería y aguanta en BIOS: el cargador actual era el principal culpable.
- Si no enciende sin batería incluso con cargador Dell original: revisar DC-in, línea de identificación o circuito de alimentación en placa.
- No comprar batería todavía hasta confirmar que la laptop puede funcionar solo con cargador.

## Estado final

Standby.
No se sigue desmontando por ahora. El próximo movimiento es conseguir/probar cargador Dell original compatible.