using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manage.Model
{
    enum Classify
    {
        Resistance,//电阻
        Capacity,//电容
        Inductance,//电感
        Friday,//磁珠保险
        Thursday,//晶体管
        Saturday//放大器
        //Sunday,//电源ic
        //Sunday,//微控制器
        //Sunday,//数模器件
        //Sunday,//接口芯片
        //Sunday,//连接器
        //Sunday,//开关按钮
        //Sunday,//声光电机器件
        //Sunday,//晶体振荡器
        //Sunday,//存储器
        //Sunday,//隔离器
        //Sunday,//传感器
        //Sunday//功能模块
    }

    public class Resistance : Component
    {
    }
    public class Capacity : Component
    {

    }

}
