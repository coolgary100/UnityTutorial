using UnityEngine;

public class RotateStructuresOnClick : MonoBehaviour
{
    public bool IsRotating { get; private set; }

    private GameObject cube;

    private static class Constants
    {
        public const string CubeGameobjectName = "Cube";
        public const int RotationSpeed = 20;
    }

    private void Start()
    {
        cube = GameObject.Find(Constants.CubeGameobjectName);
        IsRotating = false;
    }

    private void Update()
    {
        if (IsRotating)
        {
            RotateForOneFrame();
        }
    }

    private void RotateForOneFrame()
    {
        cube.transform.Rotate(new Vector3(0, Time.deltaTime * Constants.RotationSpeed, 0));
    }

    public void ToggleRotate()
    {
        IsRotating = !IsRotating;
    }
}