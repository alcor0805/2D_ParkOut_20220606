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
        private void Start()
        {  
            print("����H���A"+mask.activeInHierarchy);//activceInHierarchy ��Ū��
            print("����H�w�]tag:"+mask.tag);
            print("����H�w�]layer:"+mask.layer);
            mask.tag = "Player";
            mask.layer = 4;
            mask.SetActive(false);
        }      
    }
}

