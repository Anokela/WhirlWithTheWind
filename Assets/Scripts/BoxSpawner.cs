using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    private GameObject box;
    void Start()
    {
        CreateBox();
    }

    public void CreateBox()
    {
        box = BoxPool.SharedInstance.GetPooledObject();
        if (box != null)
        {
            box.transform.position = new Vector3(0f, -4f, 0f);
            box.SetActive(true);
        }
    }
}
