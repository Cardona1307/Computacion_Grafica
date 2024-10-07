# Proyecto: **Optimización de Entorno en Unity**

## Descripción
Este README detalla las técnicas de optimización implementadas para mejorar el rendimiento de nuestro proyecto en Unity. La optimización se centró en reducir el uso de memoria, mejorar la eficiencia del renderizado y disminuir el consumo de recursos en general, manteniendo la calidad visual aceptable para la jugabilidad.

## Técnicas de Optimización Implementadas

### 1. **Cambio de Mesh Colliders a Box Colliders**
Los `Mesh Colliders` fueron reemplazados por `Box Colliders` en elementos estáticos como:
- Cajas
- Mesas
- Columnas
- Pisos
- Paredes

Esta modificación redujo significativamente la complejidad de los cálculos de colisión, disminuyendo el uso de la CPU.

### 2. **Simplificación de Materiales**
Se reemplazaron los materiales `Lit` por `Simple Lit`, reduciendo el número de operaciones realizadas en el `Shader` y simplificando el proceso de renderizado, especialmente en objetos con superficies complejas.

### 3. **Desactivación de Sombras**
Las sombras fueron desactivadas en todo el entorno para reducir el costo de procesamiento y la cantidad de draw calls generadas por la escena. Esto optimizó la cantidad de cálculos de iluminación en tiempo real.

### 4. **Reducción de Calidad de Texturas**
Se redujo la resolución de las texturas a `512x512` píxeles. Este ajuste permite:
- Reducir el tamaño de la memoria de textura (VRAM).
- Aumentar la eficiencia del uso de memoria.
- Mejorar el tiempo de carga de los recursos.

### 5. **Occlusion Culling**
Se implementó `Occlusion Culling` para que solo se rendericen los objetos visibles desde la perspectiva de la cámara. Esto reduce la cantidad de polígonos y objetos procesados fuera del campo de visión, disminuyendo el tiempo de procesamiento de renderizado.

### 6. **Marcado de Objetos Estáticos**
Los objetos que no se mueven (como edificios, decoraciones y algunos elementos del entorno) fueron marcados como `Static`. Esto permite que el motor de Unity optimice el cálculo de iluminación y renderizado de estos elementos, aplicando `Baked Lighting` y técnicas de culling más eficientes.

## Resultados de la Optimización
Estas técnicas han reducido el uso de memoria y el tiempo de procesamiento, mejorando los siguientes aspectos del rendimiento:
- Aumento de la tasa de fotogramas por segundo (FPS).
- Disminución del tiempo de carga inicial de la escena.
- Reducción del uso de CPU y GPU en dispositivos de bajo rendimiento.


Si tienes alguna pregunta o necesitas más detalles sobre estas implementaciones, no dudes en contactarnos.

---

Puedes modificar este README según la estructura de tu proyecto y agregar métricas específicas si has hecho pruebas de rendimiento.
