using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform Cube;//ע�ӵ�Ŀ��
    private float m1;//��������ƶ�
    private float m2;//��������ƶ�
    private int x = 0;//�ж�����x�������
    public float mo = 5;//����ģ��
    Vector3 c;
    private void Start()
    {
        c = (transform.position - Cube.position).normalized;//ָ��Ŀ��ĵ�λ����
    }
    private void LateUpdate()
    {
        Look();
    }
    private void Look()
    {
        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)//����ƶ������ˢ�£��������
        {
            c = (transform.position - Cube.position).normalized;//ָ��Ŀ��ĵ�λ����
        }
        Vector3 cc;//��ֱ����
        if (c.z == 0)
        {
            cc = new Vector3(0, 0, -1);
        }
        else
        {
            cc = new Vector3(-c.z / c.x, 0, 1).normalized;
        }
        //�ж�����x�� ������
        if (c.x > 0)
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        //��������y�᷶Χ
        if ((c.y > 0 && c.y * mo < 4) || (c.y <= 0 && Input.GetAxis("Mouse Y") < 0) || (c.y * mo >= 4 && Input.GetAxis("Mouse Y") > 0))
        {
            m1 = Input.GetAxis("Mouse Y") * x;

        }
        else
        {
            m1 = 0;
        }
        m2 = Input.GetAxis("Mouse X");
        Quaternion q = Quaternion.AngleAxis(m2, Vector3.up);//��������ƶ�������y����ת
        q *= Quaternion.AngleAxis(m1, cc);//��������ƶ���������������ֱ������ת
        transform.position = q * c * mo + Cube.position;//ȷ������λ��
        transform.LookAt(Cube); //ע��Ŀ��
    }
}
    
