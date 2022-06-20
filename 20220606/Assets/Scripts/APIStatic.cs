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


            #region 作業
            //相機數量
            int count = Camera.allCamerasCount;
            print("相機數量:" + count);

            //應用程式平台
            string mode = Application.platform.ToString();
            print("應用在某一平台"+mode);

            //去掉小數點
            print("去掉小數點:" + Mathf.Round(9.999f));

            //計算兩點距離
            Vector3 position1 = new Vector3(1, 1, 1);
            Vector3 position2 = new Vector3(22, 22, 22);
            print("兩點距離:" + Vector3.Distance(position1, position2));

            //3D物理睡眠臨界值
            Physics.sleepThreshold = 10;
            print("3D物理睡眠臨界值:"+Physics.sleepThreshold);

            //時間大小設定
            Time.timeScale = 0.5f;
            print("時間大小"+Time.timeScale);

            //開啟連結
            Application.OpenURL("https://unity.com/");
            #endregion

        }
        private void Update()
        {
            #region 作業
            //是否輸入任意鍵
            print("是否按下任意鍵:" + Input.anyKeyDown);

            //遊戲經過時間
            //print("遊戲經過時間:" + Time.timeSinceLevelLoad);

            //是否按下空白鍵
            print("是否按下空白鍵:" + Input.GetKeyDown(KeyCode.Space));
            #endregion


            #region 學習
            int rangeInt = Random.Range(1, 3);
            print("隨機數1-3:" + rangeInt);
            #endregion
        }
    }

}
