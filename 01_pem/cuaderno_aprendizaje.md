# Cuaderno de aprendizaje

Error:
Telegram devolvió 409 Conflict.

Corrección:
Solo puede haber una instancia del bot usando getUpdates. Apagar contenedores o scripts viejos.

Ejemplo:
docker compose down
pkill -f "bot.py"

---

Error:
Mezclar arquitectura local y arquitectura Docker causó errores de conexión bot → API.

Corrección:
Dentro de Docker, el bot debe llamar al servicio por nombre:
API_BASE_URL=http://app:8000

Fuera de Docker, en local, se usa:
API_BASE_URL=http://127.0.0.1:8010

Ejemplo:
bot container → http://app:8000/items → app container

---

Aprendizaje:

Enseñar obliga a ordenar el conocimiento, recortar lo innecesario y construir una narrativa clara. Una clase técnica funciona mejor cuando parte de una demo simple, usa analogías y luego aplica el concepto a un caso real.

---