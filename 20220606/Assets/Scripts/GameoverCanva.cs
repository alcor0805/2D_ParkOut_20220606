using TMPro;
using UnityEngine;
namespace Alcor 
{
    public class GameoverCanva: MonoBehaviour
    {
        [SerializeField, Header("�C���e��")]
        private CanvasGroup Finalcanvas;
        [SerializeField, Header("�C��������r")]
        private TextMeshProUGUI FinalText;
        private void Fadein()
        {
            Finalcanvas.alpha += 0.1f;
            if (Finalcanvas.alpha >= 1)
            {
                Finalcanvas.interactable = true;
                Finalcanvas.blocksRaycasts = true;
            }
        }

    }
}

