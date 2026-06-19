# Inspiron Mini 10

Proyecto de diagnóstico, documentación y posible restauración de una Dell Inspiron Mini 10 / PP19S.

## Estado

Standby.

## Diagnóstico actual

La laptop enciende solo con batería + cargador, pero se apaga después de unos minutos incluso en BIOS. No presenta calentamiento notable.

La BIOS muestra:

> The battery cannot be identified. This system will be unable to charge this battery.

La batería instalada es CS-DEM911NB, no original. El cargador tampoco es original Dell.

## Hipótesis principal

Problema de alimentación por cargador/batería no originales o no reconocidos por Dell.

## Próxima acción

Probar con cargador Dell original compatible, sin batería instalada.

Criterio:

- Si enciende sin batería y aguanta en BIOS: el cargador actual era el principal sospechoso.
- Si no enciende sin batería: revisar DC-in, identificación del cargador o circuito de alimentación.