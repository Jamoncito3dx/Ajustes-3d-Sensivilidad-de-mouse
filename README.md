# Unity Mouse Sensitivity Adjuster

Este proyecto contiene un script de Unity llamado `MouseSensitivityAdjuster` que permite ajustar la sensibilidad del mouse en tiempo real utilizando un `Slider` y un `TextMeshProUGUI`.

## 📋 Características

- Ajusta dinámicamente la sensibilidad del mouse en tiempo real.
- Configuración flexible de los valores mínimos y máximos de sensibilidad mediante parámetros expuestos en el Inspector.
- Muestra el valor de la sensibilidad actual mediante un texto de `TextMeshPro`.

## 🛠️ Requisitos

- **Unity** (versión recomendada: 2021.3 o superior).
- **TextMeshPro**: Asegúrate de que el paquete TextMeshPro esté instalado en tu proyecto de Unity.
- **CameraController**: Un script que controle la cámara y tenga una variable pública `mouseSensitivity`.

## 🚀 Cómo usar el script

1. **Agregar el script al proyecto:**
   - Copia el archivo `MouseSensitivityAdjuster.cs` y colócalo en la carpeta `Scripts` de tu proyecto de Unity.

2. **Configurar los elementos en la escena:**
   - **CameraController**: Asegúrate de tener un script llamado `CameraController` que contenga una variable pública `mouseSensitivity` para controlar la sensibilidad del mouse.
   - **Slider**:
     - Crea un `Slider` en la interfaz gráfica.
     - Configura sus valores mínimos y máximos automáticamente ajustándolos desde el script.
     - Asigna el `Slider` al campo `sensitivitySlider`.
   - **TextMeshPro**:
     - Crea un objeto de texto usando `TextMeshPro`.
     - Asigna el texto TMP al campo `sensitivityText`.
     - ![image](https://github.com/user-attachments/assets/5a65d431-f000-49b1-8b87-8a4bae90f79a)


3. **Configurar el rango de sensibilidad:**
   - Define los valores mínimos y máximos de sensibilidad en los campos `minSensitivity` y `maxSensitivity` en el Inspector.
   - ![image](https://github.com/user-attachments/assets/946e629c-986a-4d22-9bd6-9fe5551d6fe6)


4. **Ejecutar el proyecto:**
   - Al iniciar el juego, el `Slider` reflejará el valor actual de la sensibilidad del mouse.
   - Ajusta el `Slider` para cambiar la sensibilidad. El texto TMP se actualizará automáticamente con el valor.

## 📂 Estructura del proyecto

```plaintext
UnityMouseSensitivityAdjuster/
├── MouseSensitivityAdjuster.cs   # Script principal para ajustar la sensibilidad del mouse.
├── README.md                     # Documentación del proyecto.
