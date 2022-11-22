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
        SetShopButtonIcon();
    }

    public void SetShopButtonIcon()
    {
        if (PowerUps.PowerUpsPrice <= PlayerInfo.LightPoints)
        {
            shopButton.image.sprite = newItemsButtonIcon;
        }
        else
        {
            shopButton.image.sprite = normalButtonIcon;
        }
    }
}
