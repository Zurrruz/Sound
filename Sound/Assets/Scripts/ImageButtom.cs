using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageButtom : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Sprite _onSprite;
    [SerializeField] private Sprite _offSprite;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    public void Change(bool Enable)
    {
        _image.sprite = !Enable ? _onSprite : _offSprite;
    }
}
