using UnityEngine;
namespace Alcor 
{
    public class ManagerFail : MonoBehaviour
    {
        [SerializeField, Header("����W��")]
        private string deadobject = "����H";
        [SerializeField,Header("�����޲z��")]
        private GameoverCanva gameoverCanva;
        [SerializeField, Header("Cm�۾�")]
        private GameObject gocm;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            gameoverCanva.sucesstext = "�ڥ��ѩ�~~";
            gameoverCanva.enabled = true;
            gocm.SetActive(false);
        }

    }
}

