using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alcor
{/// <summary>
/// API�R�A�ϥΤ�k
/// </summary>
    public class APIStatic : MonoBehaviour
    {
        private void Start()
        {
            #region �ǲ�
            print("�H����:" + Random.value);
            print("pi��:" + Mathf.PI);
            print("�L�a�j~" + Mathf.Infinity);
            Physics2D.gravity = new Vector2(0.2f, -0.2f);
            Time.timeScale = 0.5f;
            float range = Random.Range(0.5f, 100f);
            print("�H���d���:" + range);
            #endregion


            #region �@�~
            //�۾��ƶq
            int count = Camera.allCamerasCount;
            print("�۾��ƶq:" + count);

            //���ε{�����x
            string mode = Application.platform.ToString();
            print("���Φb�Y�@���x"+mode);

            //�h���p���I
            print("�h���p���I:" + Mathf.Round(9.999f));

            //�p����I�Z��
            Vector3 position1 = new Vector3(1, 1, 1);
            Vector3 position2 = new Vector3(22, 22, 22);
            print("���I�Z��:" + Vector3.Distance(position1, position2));

            //3D���z�ίv�{�ɭ�
            Physics.sleepThreshold = 10;
            print("3D���z�ίv�{�ɭ�:"+Physics.sleepThreshold);

            //�ɶ��j�p�]�w
            Time.timeScale = 0.5f;
            print("�ɶ��j�p"+Time.timeScale);

            //�}�ҳs��
            Application.OpenURL("https://unity.com/");
            #endregion

        }
        private void Update()
        {
            #region �@�~
            //�O�_��J���N��
            print("�O�_���U���N��:" + Input.anyKeyDown);

            //�C���g�L�ɶ�
            //print("�C���g�L�ɶ�:" + Time.timeSinceLevelLoad);

            //�O�_���U�ť���
            print("�O�_���U�ť���:" + Input.GetKeyDown(KeyCode.Space));
            #endregion


            #region �ǲ�
            int rangeInt = Random.Range(1, 3);
            print("�H����1-3:" + rangeInt);
            #endregion
        }
    }

}
