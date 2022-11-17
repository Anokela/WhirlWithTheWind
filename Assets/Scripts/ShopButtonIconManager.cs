using UnityEngine;
using UnityEngine.UI;

public class ShopButtonIconManager : MonoBehaviour
{
    public Sprite normalButtonIcon;
    public Sprite newItemsButtonIcon;
    public Button shopButton;
    // Start is called before the first frame update

    private void Start()
    {
        shopButton.image.sprite = normalButtonIcon;
        Debug.Log(PowerUps.PowerUpsPrice);
        Debug.Log(PlayerInfo.LightPoints);
    }
    // Update is called once per frame
    void Update()
    {
        if (PowerUps.PowerUpsPrice < PlayerInfo.LightPoints)
        {
            shopButton.image.sprite = newItemsButtonIcon;
        }
        else
        {
            shopButton.image.sprite = normalButtonIcon;
        }
    }
}
