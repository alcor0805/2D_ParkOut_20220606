using UnityEngine;
namespace Alcor 
{
    public class ManagerFail : MonoBehaviour
    {
        [SerializeField, Header("物件名稱")]
        private string deadobject = "面具人";
        [SerializeField,Header("結束管理器")]
        private GameoverCanva gameoverCanva;
        [SerializeField, Header("Cm相機")]
        private GameObject gocm;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            gameoverCanva.sucesstext = "啊失敗拉~~";
            gameoverCanva.enabled = true;
            gocm.SetActive(false);
        }

    }
}

