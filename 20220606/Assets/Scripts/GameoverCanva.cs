using TMPro;
using UnityEngine;
namespace Alcor 
{
    public class GameoverCanva: MonoBehaviour
    {
        [SerializeField, Header("遊戲畫布")]
        private CanvasGroup Finalcanvas;
        [SerializeField, Header("遊戲結束文字")]
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

