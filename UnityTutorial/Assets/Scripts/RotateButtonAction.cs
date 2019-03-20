using UnityEngine;

public class RotateButtonAction : MonoBehaviour
{

    public GameObject Cube;

    private void Start ()
    {
        Cube = GameObject.Find("Cube");
    }

    public void OnSelect()
    {
        Cube.GetComponent<RotateStructuresOnClick>().ToggleRotate();
    }
}