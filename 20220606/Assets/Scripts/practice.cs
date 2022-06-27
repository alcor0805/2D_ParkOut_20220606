using UnityEngine;

namespace Alcor 
{
    public class practice : MonoBehaviour
    {

        #region 資料
        [SerializeField]
        private Camera came;
        [SerializeField]
        private SphereCollider coll;
        [SerializeField]
        private CapsuleCollider cap;
        [SerializeField]
        private Collider cube;
        private Rigidbody rig;

        #endregion

        #region 功能
        private void up()
        {
            rig.AddForce(new Vector3(0, 10, 0));
        }
        #endregion
        private Color color1 = Color.blue;
        private Color color2 = Color.red;
        private Vector3 scaleChange;
        private float duration = 3f;

        #region 事件
        private void Awake()
        {
            rig = GetComponent<Rigidbody>();
            scaleChange = new Vector3(3, 2, 1);
        }
        private void Start()
        {
            print("相機深度:"+Camera.main.depth);
            print("半徑:" + coll.radius);
            print("相機顏色:" + came.backgroundColor);
            cap.transform.localScale = scaleChange;
            came.clearFlags = CameraClearFlags.SolidColor;
        }
        private void Update()
        {
            //up();
            rig.AddForce(new Vector3(0, 10, 0));

            float t =Mathf.PingPong (Time.time, duration) / duration;
            came.backgroundColor = Color.Lerp(color1, color2,t);
            cube.transform.RotateAround(coll.transform.localPosition, Vector3.up, 20);

        }

        #endregion
    }

}
