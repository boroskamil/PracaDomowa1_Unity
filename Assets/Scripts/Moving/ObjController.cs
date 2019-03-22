using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjController : MonoBehaviour
{
    private string Direction;

    public void Initialize(string direction)
    {
        this.Direction = direction;
    }

    void Update()
    {
        if (!Input.GetKey(KeyCode.Z))
        {
            if      (Direction == "left")   Move(Vector3.left);
            else if (Direction == "right")  Move(Vector3.right);
            else if (Direction == "up")     Move(Vector3.up);
            else                            Move(Vector3.down);
        }
    }

    private void Move(Vector3 direction) => transform.position += direction * Time.deltaTime;
}
