using UnityEngine;
/// <summary>
/// API�D�R�A
/// 1.�����@�ӡu���骫��v
/// 2.�u���骫��v���C�����������C������(Game Object)
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
            print("����H���A"+mask.activeInHierarchy);//activceInHierarchy ��Ū��
            print("����H�w�]tag:"+mask.tag);
            print("����H�w�]layer:"+mask.layer);
            print("�_�I�w�]�y��:" + startPoint.transform.position);

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

