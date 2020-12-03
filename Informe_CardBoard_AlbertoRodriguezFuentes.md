# Práctica: Escenas CardBoard
## 1. Hacer el programa una aplicación VR.
	 Para hacer que la aplicación sea VR debemos instalar el package de Google VR, acto seguido ir a Build Settings, cambiar la plataforma a Android y en Player Settings habilitar la opción de CardBoard.  
	Tras esto añadi el GvrEditorEmulator para poder probar el programa desde el ordenador, además de añadirle un GvrReticlePointer y un GvrEventSystem para poder hacer uso de un puntero.
## 2. Creación UI
	Para hacer la UI utilice un canvas que se quedará estatico. En dicho canvas coloqué tres botones que dan la posibilidad de elegir el color al que van a tranformar al clickear sobre una esfera. Además, también añadi un texto en el cual se va actualizando un contador con el número de cubos recogidos hasta el momento.
## 3. Cambiar de color las esferas.
	Las esferas cambiaran de color cuando el jugador las clicke, este color es decidido por el usuario desde un botón en la UI, al clickear en dicho botón una variable global cambia al valor necesario para que luego en un switch situado en un script de la esfera este sea capaz de hacerlo correctamente.
	Para poder hacer uso de esta funcionalidad tuve que añadirle a la esfera un Event Trigger que funcionara con el uso de un Pointer Click, asociando el script y la funcion necesaria en este.
![Gif](https://github.com/alu0101017396/CardBoardGif/blob/main/1.gif)
## 4. Recoger cubos. 
	Para recoger los cubos volví a hacer uso de una variable global la cual va sumando cada vez que se clickea encima de uno de estos. Además, cada vez que se clickea un cubo este spawnea otro en una posición aleatoria dentro de un rango y se destruye el cubo clickeado.
![Gif](https://github.com/alu0101017396/CardBoardGif/blob/main/2.gif)
