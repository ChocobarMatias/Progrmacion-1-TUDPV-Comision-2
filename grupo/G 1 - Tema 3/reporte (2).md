# Reporte Técnico – Fase 2: De la Consola al Motor Gráfico

**Cátedra:** Programación de Videojuegos I – UTN FRT
**Grupo:** 1
**Tema asignado:** Pokémon 2D (semana 2)
**Tema heredado:** Tema 1 (Super Mario Bros 2D, Semana 1)

---

## 1. Integrantes y legajos

| Nombre y apellido | Legajo | Rama de trabajo |
|---|---|---|
| Juan Facundo Coronel | 67116 | dev-JuanFacundoCoronel-67116 |
| Nestor Joaquin Soria | 67109 | dev-NestorJoaquinSoria-67109 |
| Nicolas Gabriel Oviedo | 67118 | Nicolas-Oviedo-67118 |
| Lautaro Uriel Albornoz | 67108 
Bruno Nicolas Matias Nieva - Legajo 67131 
Enrique Gaston Cangro Chavez Legajo 67104	
Fausto Salustiano Alvarez


---

## 2. Diagnóstico del proyecto heredado


Compilación al importar:  sin errores 
Clases encontradas: Pokemon, Entrenador, Charizard, Empoleon. 
Faltantes o incompletas: ninguna
Orden y documentación: ordenado 
Contenido que no aplicaba a Pokémon: lógica propia de Mario (monedas, salto, bloques), que se dejó sin usar. No se importó Program.cs porque Unity no usa Main.

---

## 3. Refactorizaciones y arreglos

Lista de cambios hechos sobre el código recibido:

Se excluyó Program.cs (punto de entrada de consola) al importar las clases a Unity.
Se corrigió un error de sintaxis (falta de ;) en un script de prueba creado por defecto (NewMonoBehaviourScript), que luego se eliminó.

---

## 4. Integración C# con Unity

Se mantuvo la separación entre lógica pura (C#) y control en el motor (MonoBehaviour), cumpliendo la Regla 1.

Lógica pura (sin MonoBehaviour):

EncuentroSalvaje: decide si ocurre un encuentro según una probabilidad por paso y, si ocurre, elige el Pokémon con 50 % de chances para Charizard y 50 % para Empoleon. Devuelve el nombre, o null si no hubo encuentro. No depende de Unity.

Puente con Unity (MonoBehaviour):

Movimiento: lee el input en Update(), aplica la velocidad al Rigidbody2D en FixedUpdate() y detecta el pasto con OnTriggerEnter2D / OnTriggerExit2D. Mientras el jugador camina dentro del pasto acumula la distancia recorrida; cada paso completo llama a IntentarEncuentro() y, si devuelve un nombre, lo imprime por consola.

Cumplimiento de las reglas de la cátedra:

Regla 1: la lógica de probabilidad vive en una clase C# pura.
Regla 2: el movimiento usa velocidad del Rigidbody2D, no transform.position.
Regla 3: input en Update(), físicas en FixedUpdate().
Regla 4: Freeze Rotation Z activado en el jugador.
Regla 5: no aplica 

Configuración de la escena:

Jugador: Rigidbody2D Dynamic, Gravity Scale = 0, Freeze Rotation Z, CapsuleCollider2D.
Pasto: BoxCollider2D con Is Trigger y tag Yuyito
---

## 5. Guía de prueba de la escena

1. Abrir el proyecto en Unity 
2. Abrir la escena `Assets/Scenes/SampleScene`.
3. Presionar **Play** y hacer clic en la ventana **Game**.
4. Moverse con **WASD** o las **flechas**. El personaje se desliza sin caerse ni rotar y choca con las paredes.
5. Entrar al área verde (pasto alto) y caminar dentro.
6. Observar la pestaña **Console**: cada tanto aparece `¡Un pokemon salvaje apareció!`. Fuera del pasto no debe aparecer nada.

**Valores ajustables (Inspector):** velocidad, distancia por paso y probabilidad de encuentro.

---

## 6. Problemas conocidos

-No pudimos hacer que al aparecer un pokemon, diga el nombre del pokemon que apareció. 
