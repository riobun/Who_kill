using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform Cube;//注视的目标
    private float m1;//鼠标上下移动
    private float m2;//鼠标左右移动
    private int x = 0;//判断向量x轴的正负
    public float mo = 5;//向量模长
    Vector3 c;
    private void Start()
    {
        c = (transform.position - Cube.position).normalized;//指向目标的单位向量
    }
    private void LateUpdate()
    {
        Look();
    }
    private void Look()
    {
        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)//如果移动鼠标再刷新，否则跟随
        {
            c = (transform.position - Cube.position).normalized;//指向目标的单位向量
        }
        Vector3 cc;//垂直向量
        if (c.z == 0)
        {
            cc = new Vector3(0, 0, -1);
        }
        else
        {
            cc = new Vector3(-c.z / c.x, 0, 1).normalized;
        }
        //判断向量x轴 的正负
        if (c.x > 0)
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        //限制向量y轴范围
        if ((c.y > 0 && c.y * mo < 4) || (c.y <= 0 && Input.GetAxis("Mouse Y") < 0) || (c.y * mo >= 4 && Input.GetAxis("Mouse Y") > 0))
        {
            m1 = Input.GetAxis("Mouse Y") * x;

        }
        else
        {
            m1 = 0;
        }
        m2 = Input.GetAxis("Mouse X");
        Quaternion q = Quaternion.AngleAxis(m2, Vector3.up);//鼠标左右移动控制绕y轴旋转
        q *= Quaternion.AngleAxis(m1, cc);//鼠标上下移动控制绕与向量垂直的轴旋转
        transform.position = q * c * mo + Cube.position;//确定最终位置
        transform.LookAt(Cube); //注释目标
    }
}
    
