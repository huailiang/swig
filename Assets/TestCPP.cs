using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class TestCPP : MonoBehaviour
{

#if UNITY_IPHONE || UNITY_XBOX360
	[DllImport("__Internal")]
#else
    [DllImport("Core")]
#endif
    public static extern int iAdd(int x, int y);


#if UNITY_IPHONE || UNITY_XBOX360
	[DllImport("__Internal")]
#else
    [DllImport("Core")]
#endif
    public static extern int iSub(IntPtr x, IntPtr y);



    public void OnGUI()
    {
        if (GUI.Button(new Rect(20,20,100,60),"Add"))
        {
            int i = iAdd(8, 7);
            Debug.Log("8+7=" + i);
        }

        if (GUI.Button(new Rect(20, 120, 100, 60), "Sub"))
        {
            int a = 8, b = 2;
            IntPtr p1 = Marshal.AllocCoTaskMem(Marshal.SizeOf(a));
            Marshal.StructureToPtr(a, p1, false);
            IntPtr p2 = Marshal.AllocCoTaskMem(Marshal.SizeOf(b));
            Marshal.StructureToPtr(b, p2, false);
            int rst = iSub(p1, p2);
            Debug.Log(a + "-" + b + "=" + rst);
        }

        if (GUI.Button(new Rect(20, 220, 100, 60), "Swig"))
        {
            int c = Invork.Div(4, 2);
            Debug.Log("div val:" + c);
            Invork ins = new Invork();
            c = ins.Mul(3, 5);
            Debug.Log("mul val:" + c);
            //ins.Dispose();
        }
    }
}
