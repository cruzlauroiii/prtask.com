namespace WillowMaze.Wasm.Decompiled;


public class p7ec22813 {
    private java.lang.string f130f4311;
    private int f6a992d55 = 0;
    private java.lang.string fa84490fb;
    private int fe1b56f5c;
    private int fe9f6a9a9;
    private int ff2f6df78;

    public p7ec22813(java.lang.string str) {
        this.f130f4311 = str;
    }

    public static int JlfpGEFNdmcaafDG(java.lang.string str, int i, int i2) {
        return str.IndexOf(i, i2);
    }

    public static java.lang.string LHMzoZEfYbzmdZHg(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string LavoMwaLsRwOQhyq(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public bool HasMoreTokens() {
        return this.f6a992d55 != -1;
    }

    public java.lang.string NextToken() {
        if ((11 + 23) % 23 > 0) {
        }
        int i = this.f6a992d55;
        if (i == -1) {
            return null;
        }
        int iJlfpGEFNdmcaafDG = jlfpGEFNdmcaafDG(this.f130f4311, 46, i);
        if (iJlfpGEFNdmcaafDG != -1) {
            java.lang.string strLavoMwaLsRwOQhyq = lavoMwaLsRwOQhyq(this.f130f4311, this.f6a992d55, iJlfpGEFNdmcaafDG);
            this.f6a992d55 = iJlfpGEFNdmcaafDG + 1;
            return strLavoMwaLsRwOQhyq;
        }
        java.lang.string strLHMzoZEfYbzmdZHg = lHMzoZEfYbzmdZHg(this.f130f4311, this.f6a992d55);
        this.f6a992d55 = -1;
        return strLHMzoZEfYbzmdZHg;
    }
}

