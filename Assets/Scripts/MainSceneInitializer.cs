using System.Collections;
using UnityEngine;

public class MainSceneInitializer : MonoBehaviour
{
    [Header("Objects")]
    [SerializeField]    private GameObject spherePrefab;
    [SerializeField]    private GameObject cubePrefab;

    [Header("Initialize menu")]
    [SerializeField] private float rangeSize;
    [SerializeField] private float initQuantity;

    void Awake()
    {
        New(spherePrefab, "left");
        New(spherePrefab, "down");
        New(cubePrefab, "right");
        New(cubePrefab, "up");  
    }

    private void New(GameObject obj, string direction)
    {
        for (int i = 0; i < initQuantity; i++)
        {
            GameObject ship = Instantiate(obj);
            ship.transform.position = new Vector3(Random.Range(-rangeSize, rangeSize),Random.Range(-rangeSize, rangeSize),Random.Range(-rangeSize, rangeSize));
            
            ship.GetComponent<ObjController>().Initialize(direction);
        }
    }
}
