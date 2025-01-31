public class PyPrint {
    public static void pyPrint(params object[] objs)
    {
        string printr = "";
        int ind = 0;
        foreach (object jbo in objs)
        {
            if(objs.Length > 1)
            {
                if(ind == 0)
                {
                    printr += jbo;
                }
                else
                {
                    printr += ", " + jbo;
                }
            }
            ind++;
        }
        UnityEngine.MonoBehaviour.print(printr);
    }
}