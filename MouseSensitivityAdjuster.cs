using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MouseSensitivityAdjuster : MonoBehaviour
{
    [Header("UI Elements")]
    public Slider sensitivitySlider; // Slider para ajustar la sensibilidad
    public TextMeshProUGUI sensitivityText; // TMP para mostrar el valor de la sensibilidad

    [Header("Mouse Settings")]
    public CameraController cameraController; // Referencia al script de la cámara
    [Range(10f, 500f)] public float minSensitivity = 50f; // Sensibilidad mínima
    [Range(10f, 500f)] public float maxSensitivity = 300f; // Sensibilidad máxima

    private void Start()
    {
        if (cameraController == null)
        {
            Debug.LogError("No se asignó el CameraController en MouseSensitivityAdjuster.");
            return;
        }

        if (sensitivitySlider != null)
        {
            // Configurar los límites del Slider
            sensitivitySlider.minValue = minSensitivity;
            sensitivitySlider.maxValue = maxSensitivity;

            // Inicializar el Slider con la sensibilidad actual
            sensitivitySlider.value = cameraController.mouseSensitivity;

            // Añadir un listener para detectar cambios en el Slider
            sensitivitySlider.onValueChanged.AddListener(OnSensitivitySliderChanged);
        }
        else
        {
            Debug.LogError("No se asignó el Slider en MouseSensitivityAdjuster.");
        }

        // Actualizar el TMP al inicio
        UpdateSensitivityText(cameraController.mouseSensitivity);
    }

    private void OnSensitivitySliderChanged(float value)
    {
        // Actualizar la sensibilidad del mouse en el script de la cámara
        if (cameraController != null)
        {
            cameraController.mouseSensitivity = value;
        }

        // Actualizar el TMP
        UpdateSensitivityText(value);
    }

    private void UpdateSensitivityText(float value)
    {
        if (sensitivityText != null)
        {
            sensitivityText.text = $"{Mathf.RoundToInt(value)}"; // Mostrar la sensibilidad como un número entero
        }
        else
        {
            Debug.LogError("No se asignó el TextMeshProUGUI en MouseSensitivityAdjuster.");
        }
    }

    private void OnDestroy()
    {
        // Remover el listener para evitar errores si el objeto es destruido
        if (sensitivitySlider != null)
        {
            sensitivitySlider.onValueChanged.RemoveListener(OnSensitivitySliderChanged);
        }
    }
}
