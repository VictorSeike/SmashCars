using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0f, 2f, -10f);
    public float smoothSpeed = 5f;
    public float maxY = 11.5f; // Altura máxima
    public float minY = 8.5f; // Altura mínima

    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

            // Verifique se a coordenada Y da posição desejada é maior que maxY
            if (smoothedPosition.y > maxY)
            {
                smoothedPosition.y = maxY;
            }
            // Verifique se a coordenada Y da posição desejada é menor que minY
            else if (smoothedPosition.y < minY)
            {
                smoothedPosition.y = minY;
            }

            transform.position = smoothedPosition;
        }
    }
}
