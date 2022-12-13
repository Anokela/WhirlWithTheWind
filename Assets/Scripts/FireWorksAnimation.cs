using UnityEngine;
using UnityEngine.UI;

public class FireWorksAnimation : MonoBehaviour
{
    public float duration;

    [SerializeField] private Sprite[] sprites;

    private Image image;
    private int index = 0;
    private float timer = 0;
    private GameObject fireWorks;

    void Start()
    {
        image = GetComponent<Image>();
        fireWorks = this.gameObject;
    }
    private void Update()
    {
        if ((timer += Time.deltaTime) >= (duration / sprites.Length))
        {
            timer = 0;
            image.sprite = sprites[index];
            index = (index + 1) % sprites.Length;
            if (index == 30)
            {
                fireWorks.SetActive(false);
            }
        } 
    }
}
