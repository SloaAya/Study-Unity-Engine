using System;

namespace Lesson2_一维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 基本概念
            //数组是存储一组相同类型数据的集合
            //数组分为 一维 多维 交错数组
            //一般情况 一维数组 就简称为 数组
            #endregion

            #region 知识点二 数组的申明

            // 变量类型 [] 数组名; // 只是申明了一个数组 但是并没有开房
            // 变量类型 可以是我们学过的 或者 没学过的所有变量类型
            int[] arr1;

            //变量类型 [] 数组名 = new 变量类型[数组的长度];
            int[] arr2 = new int[5]; //这种方式 相当于开了5个房间 但是房间里面的int值 默认为0

            #endregion

        }
    }
}