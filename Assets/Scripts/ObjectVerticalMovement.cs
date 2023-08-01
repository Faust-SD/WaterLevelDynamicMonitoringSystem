using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVerticalMovement : MonoBehaviour
{
    public DataReaders dataReaders;
    public GameObject targetObject;
    public float verticalMovement = 0.0f;
    private void Start()
    {
        
    }
    void Update()
    {
        if (dataReaders.dataQueue.TryDequeue(out float result))
        {
            result = Mathf.SmoothStep(-0.2f, 0.2f, result / 1023.0f);
            verticalMovement = result;
        }
        if (targetObject != null)
        {
            Vector3 targetPosition = targetObject.transform.position;
            targetPosition.y = verticalMovement;
            targetObject.transform.position = targetPosition;
        }
    }
}
