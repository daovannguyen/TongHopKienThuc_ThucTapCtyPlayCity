using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTranslate : MonoBehaviour
{
    private float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        Camera.main.transform.position = transform.position + new Vector3(0, 10, -2);
    }

    #region Study Collider
    //public void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(collision.transform.name);
    //}
    ////public void (Collision collision)
    ////{
    ////    if (collision.transform.name != "Plane")
    ////        Debug.Log("Trong quá trình va chạm");
    ////}
    //public void nCollisionExit(Collision collision)
    //{
    //    if (collision.transform.name != "Plane")
    //        Debug.Log("Kết thúc quá trình va chạm");
    //}
    //public void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log($"Đây là OnTriggerEnter: {other.transform.name}");
    //}
    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log("Kết thúc quá trình va chạm");
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("Kết thúc quá trình va chạm");
    //}
    #endregion

    #region Study Di chuyển, thêm lực

    #endregion
}
