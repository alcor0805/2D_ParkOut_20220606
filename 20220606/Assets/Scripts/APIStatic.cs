using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alcor
{/// <summary>
/// API靜態使用方法
/// </summary>
    public class APIStatic : MonoBehaviour
    {
        private void Start()
        {
            #region 學習
            print("隨機值:" + Random.value);
            print("pi值:" + Mathf.PI);
            print("無窮大~" + Mathf.Infinity);
            Physics2D.gravity = new Vector2(0.2f, -0.2f);
            Time.timeScale = 0.5f;
            float range = Random.Range(0.5f, 100f);
            print("隨機範圍值:" + range);
            #endregion
            int count = Camera.allCamerasCount;
            print("相機數量:" + count);
            string mode = Application.platform.ToString();
            print("應用在某一平台"+mode);

        }
        private void Update()
        {

            if (Input.anyKeyDown)
            {
                print("已按任意按鍵");
            }
            #region 學習
            int rangeInt = Random.Range(1, 3);
            print("隨機數1-3:" + rangeInt);
            #endregion
        }
    }

}
