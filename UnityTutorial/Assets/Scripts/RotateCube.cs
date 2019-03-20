using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private GameObject cube;

    private static class Constants
    {
        public const string CubeGameobjectName = "Cube";
        public const int RotationSpeed = 50;
    }

    private void Start()
    {
        cube = GameObject.Find(Constants.CubeGameobjectName);
    }

    private void Update()
    {
        RotateForOneFrame();
    }

    private void RotateForOneFrame()
    {
        cube.transform.Rotate(new Vector3(0, Time.deltaTime * Constants.RotationSpeed, 0));
    }
}