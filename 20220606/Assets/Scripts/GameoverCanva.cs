using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Alcor 
{
    public class GameoverCanva: MonoBehaviour
    {
        [SerializeField, Header("�C���e��")]
        private CanvasGroup Finalcanvas;
        [SerializeField, Header("�C��������r")]
        private TextMeshProUGUI FinalText;
        public string sucesstext;
        private void Start()
        {
            FinalText.text = sucesstext;
            InvokeRepeating("Fadein", 0,0.1f);
        }
        private void Fadein()
        {
            Finalcanvas.alpha += 0.2f;
            if (Finalcanvas.alpha >= 1)
            {
                Finalcanvas.interactable = true;
                Finalcanvas.blocksRaycasts = true;
                CancelInvoke("Fadein");
               
            }
            
        }
        public void Quit()
        {
            print("���}�C��");
            Application.Quit();
        }
        public void reload() 
        {
            SceneManager.LoadScene(0);
        }
    }
}

