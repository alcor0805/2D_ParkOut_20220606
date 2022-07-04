using UnityEngine;
namespace Alcor
{
    public class Managersucess : MonoBehaviour
    {
        [SerializeField, Header("物件名稱")]
        private string objectname = "面具人";
        [SerializeField, Header("跑步控制")]
        private SystemRun systemRun;
        [SerializeField, Header("跳躍控制")]
        private SystemJump systemJump;

        #region Trigger
        /// <summary>
        /// 其中一個物件有勾選is trigger
        /// </summary>
        //兩物件碰撞時執行一次
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(objectname))
            {
                systemJump.enabled = false;
                systemRun.enabled = false;
            }
        }

        //兩物件碰撞離開時執行一次
        private void OnTriggerExit2D(Collider2D collision)
        {

        }
        //兩物件碰撞停留持續執行
        private void OnTriggerStay2D(Collider2D collision)
        {

        }
        #endregion

        #region collision
        /// <summary>
        /// 兩個物件都沒有勾選is trigger
        /// </summary>
        private void OnCollisionEnter2D(Collision2D collision)
        {

        }
        private void OnCollisionExit2D(Collision2D collision)
        {

        }
        private void OnCollisionStay2D(Collision2D collision)
        {

        }
        #endregion
    }
}

