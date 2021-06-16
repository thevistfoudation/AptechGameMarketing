using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace JinGroupUnityBase.Base.Plane
{
    public class GunController : MonoBehaviour
    {
        public GameObject TranShoot;
        public GameObject[] bullet;
        //public Vector3 pos;
        public float delay;
        public float BulletLevel;
        //BulletLevel dựa vào level ng chơi hoặc điểm số
        Transform player;
        //private Rigidbody2D rb;
       // private Vector2 movement;
        public static GunController instance;
        public Vector3 angle;
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(shoot());
           // player = GameObject.Find("Ship").transform;
           // rb = this.GetComponent<Rigidbody2D>();
            BulletLevel = 1;
        }
        IEnumerator shoot()
        {
            //ko sử dụng trong update vì gọi liên tục sẽ bị crash
            while (true)
            {
               // SoundsController.instance.playSound((int)AudioIndex.Shoot, 0.05f);
                if (BulletLevel == 1)
                {
                    Instantiate(bullet[0], TranShoot.transform.position, Quaternion.identity);
                    //Đạn Thẳng
                }
                if (BulletLevel == 1.5f)
                {
                    Instantiate(bullet[0], TranShoot.transform.position, Quaternion.identity);
                    Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, 49));
                    Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -49));
                    Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, 35));
                    Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -35));
                    Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, 15));
                    Instantiate(bullet[0], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -15));
                    //Đạn tỏa
                }
                if (BulletLevel == 2)
                {
                    Instantiate(bullet[1], TranShoot.transform.position, Quaternion.identity);
                    //Đạn Thẳng
                }
                if (BulletLevel == 2.5f)
                {
                    Instantiate(bullet[1], TranShoot.transform.position, Quaternion.identity);
                    Instantiate(bullet[1], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, 49));
                    Instantiate(bullet[1], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -49));
                    Instantiate(bullet[1], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, 35));
                    Instantiate(bullet[1], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -35));
                    Instantiate(bullet[1], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, 15));
                    Instantiate(bullet[1], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -15));
                    //Đạn tỏa
                }
                if (BulletLevel == 3)
                {
                    GameObject dan1 = Instantiate(bullet[2], TranShoot.transform.position, Quaternion.identity);
                    //Đạn Thẳng
                }
                if (BulletLevel == 3.5f)
                {
                    Instantiate(bullet[2], TranShoot.transform.position, Quaternion.identity);
                    Instantiate(bullet[2], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, 49));
                    Instantiate(bullet[2], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -49));
                    Instantiate(bullet[2], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, 35));
                    Instantiate(bullet[2], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -35));
                    Instantiate(bullet[2], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, 15));
                    Instantiate(bullet[2], TranShoot.transform.position, Quaternion.Euler(angle.x, angle.y, -15));
                    //Đạn tỏa
                }
                yield return new WaitForSeconds(delay);
                //delay đạn tránh trường hợp bắn liên tục
            }
        }
        IEnumerator c()
        {
            while (true)
            {
                yield return shoot();
            }
        }
        // Update is called once per frame
    }
}

