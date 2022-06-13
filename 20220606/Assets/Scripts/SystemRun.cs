
using UnityEngine;//使用unity引擎API套件
namespace Alcor
{
    /// <summary>
    /// 跑步系統
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料:存放物件
        [SerializeField, Header("跑步速度"),Tooltip("調整角色的跑步速度"),Range(0,10)]//序列化欄位，顯示私人屬性
        private float speedRun = 3.5f;
        [SerializeField, Header("跳躍高度"),Tooltip("調整角色跳躍高度"),Range(300,1000)]
        private float height = 350; 
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region 功能:系統所需的功能
        #endregion

        #region 事件:程式入口
        private void Start()
        {
            print("Y●皿●Y");
        }
        #endregion

    }
}

