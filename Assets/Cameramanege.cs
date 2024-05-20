using UnityEngine;

public class CameraChange : MonoBehaviour
{

    public GameObject Camera1;
    public GameObject Camera2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeCamera();
        }
    }

    public void ChangeCamera()
    {
        if (Camera1.activeSelf)
        {
            Camera1.gameObject.SetActive(false);
            Camera2.gameObject.SetActive(true);
        }
        else
        {
            Camera1.gameObject.SetActive(true);
            Camera2.gameObject.SetActive(false);
        }
    }
}