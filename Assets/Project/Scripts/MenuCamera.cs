using UnityEngine;

public class MenuCamera : MonoBehaviour
{
    // 固定旋轉畫面
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 2, 0);
    }
}
