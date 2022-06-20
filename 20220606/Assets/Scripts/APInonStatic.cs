using UnityEngine;
/// <summary>
/// API非靜態
/// 1.須有一個「實體物件」
/// 2.「實體物件」為遊戲場景中的遊戲物件(Game Object)
/// </summary>
namespace Alcor
{
    public class APInonStatic : MonoBehaviour
    {
        [SerializeField]
        private GameObject mask;
        [SerializeField]
        private GameObject startPoint;
        private void Start()
        {  
            print("面具人狀態"+mask.activeInHierarchy);//activceInHierarchy 唯讀檔
            print("面具人預設tag:"+mask.tag);
            print("面具人預設layer:"+mask.layer);
            print("起點預設座標:" + startPoint.transform.position);

            startPoint.transform.Translate(0, 2, 0);
            mask.tag = "Player";
            mask.layer = 4;
            mask.SetActive(false);
        }
        private void Update()
        {
            startPoint.transform.Translate(0.5f,0,0);
            startPoint.transform.Rotate(0, 0, 3.5f);
        }
    }
}

