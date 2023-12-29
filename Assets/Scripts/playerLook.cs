using UnityEngine;
using UnityEngine.InputSystem;

public class playerLook : MonoBehaviour
{
    [SerializeField] private GameObject camera;
    [SerializeField] float sensitivityX = 8.0f;
    [SerializeField] float sensitivityY = 0.5f;

    private float rotateX, rotateY;

    private void Update()
    {
        camera.transform.Rotate(Vector3.up, rotateX * Time.deltaTime);
        camera.transform.Rotate(Vector3.left, mouseDelta.y);
    }

    public void OnLookX (Vector2 mouseInput)
    {
        rotateX = mouseInput.x * sensitivityX;
    }
    public void OnLookY(Vector2 mouseInput)
    {
        rotateY = mouseInput.y * sensitivityY;
    }


}
