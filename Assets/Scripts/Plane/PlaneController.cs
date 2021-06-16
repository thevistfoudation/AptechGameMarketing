using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
namespace JinGroupUnityBase.Base.Plane
{
    public class PlaneController : MonoBehaviour
    {
        public float deltaX, deltaY;
        public Vector3 pos;
        Vector2 touchDeltaPosition;
        Touch touch;
        // Start is called before the first frame update
        void Start()
        {
            deltaX = 0;
            deltaY = 0;
        }
        // Update is called once per frame
        void Update()
        {
            pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            touch1();
        }
        public void move(Vector3 pos)
        {
            this.transform.position = Vector3.Lerp(transform.position, pos, 5);
            // hàm di chuyển
        }
        public void touch1()
        {
            //hàm chạm di chuyển
            if (Input.touchCount > 0)
            {

                touch = Input.GetTouch(0);
                Vector2 touchpos = Camera.main.ScreenToWorldPoint(touch.position);
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        deltaX = touchpos.x - transform.position.x;
                        deltaY = touchpos.y - transform.position.y;
                        break;
                    case TouchPhase.Moved:
                        this.transform.position = new Vector2(touchpos.x - deltaX, touchpos.y - deltaY);
                        //rigidbody.MovePosition(new Vector2(touchpos.x - deltaX, touchpos.y - deltaY));
                        break;
                    case TouchPhase.Ended:
                        transform.position = transform.position;
                        //rigidbody.velocity = Vector2.zero;
                        break;
                }
            }
        }
    }

}

