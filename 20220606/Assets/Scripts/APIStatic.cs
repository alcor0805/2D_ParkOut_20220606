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
            int count = Camera.allCamerasCount;
            print("�۾��ƶq:" + count);
            string mode = Application.platform.ToString();
            print("���Φb�Y�@���x"+mode);

        }
        private void Update()
        {

            if (Input.anyKeyDown)
            {
                print("�w�����N����");
            }
            #region �ǲ�
            int rangeInt = Random.Range(1, 3);
            print("�H����1-3:" + rangeInt);
            #endregion
        }
    }

}
