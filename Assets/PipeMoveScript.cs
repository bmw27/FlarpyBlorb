using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 10;
    private Camera _mainCamera;

    // Start is called before the first frame update
    private void Start()
    {
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    private void Update()
    {
        var cameraOrthographicSize = _mainCamera.orthographicSize;

        // Debug.Log("Camera size: " + cameraOrthographicSize);

        // If pipe is off screen, destroy it
        if (transform.position.x < _mainCamera.transform.position.x - (cameraOrthographicSize - 10))
        {
            Destroy(gameObject);
        }

        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
