Reporte Técnico de Cátedra - Fase 1
Juego Asignado: [Super Mario]
Número de Grupo: Grupo 01

1. Integrantes del Equipo
Coronel Juan Facundo - Legajo 67116 (Rol / Rama: dev-JuanFacundoCoronel-67116)
Soria Nestor Legajo - Legajo 67109- (Rol / Rama: dev-NestorJoaquinSoria-67109)
Oviedo Nicolas Gabriel - Legajo 67118 (Rol / Rama: Nicolas-Oviedo-67118)
Bruno Nicolas Matias Nieva - Legajo 67131 
Enrique Gaston Cangro Chavez Legajo 67104
Albornoz Lautaro Uriel - Legajo 67108
Fausto Salustiano Alvarez


2. Diagnóstico y Arquitectura Inicial
Se concibió una clase base PersonajeMario con los datos comunes (nombre, vida, monedas) como atributos
protected y el comportamiento común como métodos virtual (Saltar, RecibirDanio, RecibirPowerUp).
Mario y Luigi heredan de ella y especializan el comportamiento con override. BloqueInterrogacion
interactúa con cualquier PersonajeMario sin conocer su tipo concreto, aprovechando el polimorfismo.
3. Módulos y Clases Implementadas (Mínimo 4)
- PersonajeMario.cs: clase base con propiedad Vidas validada (Game Over), propiedad Monedas validada y método AgregarMonedas, que otorga una vida extra al llegar a 100 monedas.
- Mario.cs: atributo privado estadoTransformacion (Normal, Super o Fuego) con propiedad validada. Saltar() alcanza 2 bloques de altura. RecibirPowerUp y RecibirDanio modifican el estado de transformación.
- Luigi.cs: Saltar() con mayor altura (3 bloques) pero menor tracción.
- BloqueInterrogacion.cs: atributo privado abierto. El método Golpear(PersonajeMario pj) entrega una moneda o un power-up aleatorio una sola vez.
- Program.cs: Main() con el array polimórfico PersonajeMario[] hermanos, recorrido con bucles for.
- Correcciones sobre la primera versión: se eliminó una variable no declarada, se corrigieron llaves sobrantes, se hicieron privados los atributos del bloque y el power-up ahora se aplica realmente al personaje.

4. Control de Errores y Validaciones
- nombre, vida y monedas son protected: solo se modifican mediante propiedades y métodos validados.
- La propiedad Vidas nunca queda negativa y el Game Over se dispara una sola vez gracias al campo privado gameOver.
- El atributo abierto es privado y de solo lectura desde afuera, por lo que un bloque no puede reabrirse ni cobrarse dos veces.
- La propiedad Estado de Mario tiene set privado y valida con value, por lo que solo admite los valores Normal, Super o Fuego.
- El constructor corrige valores inválidos (vida menor a 1, monedas negativas) y el método Golpear valida que el personaje no sea null.
5. Guía de Ejecución en Consola
Ejecutar el proyecto con F5 en Visual Studio. El Main() muestra, en orden:

1. Saltos polimórficos de Mario (2 bloques) y Luigi (3 bloques).
2. Tres bloques golpeados por ambos hermanos: el primero en golpear cobra el premio (aleatorio) y el segundo encuentra el bloque ya consumido.
3. Cuatro rondas de daño: Mario baja de estado (Fuego, Super, Normal) antes de perder vidas, y Luigi pierde vidas directamente.
4. Asignar Vidas = -5 a Luigi lo deja en 0 y muestra Game Over.