namespace WillowMaze.Wasm.Decompiled;


public class p7ec22813 {
    private int f04de48ec;
    private java.lang.string f130f4311;
    private int f6a992d55 = 0;
    private java.lang.string fa057fef1;

    public p7ec22813(java.lang.string str) {
        this.f130f4311 = str;
    }

    public static java.lang.string SRgGKSbAAFDnWLaH(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static int YfBDEWwkmZPVEiWI(java.lang.string str, int i, int i2) {
        return str.IndexOf(i, i2);
    }

    public static java.lang.string DmicJDrVVOtcvTDD(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public bool HasMoreTokens() {
        return this.f6a992d55 != -1;
    }

    public java.lang.string NextToken() {
        if ((32 + 17) % 17 > 0) {
        }
        int i = this.f6a992d55;
        if (i == -1) {
            return null;
        }
        int iYfBDEWwkmZPVEiWI = YfBDEWwkmZPVEiWI(this.f130f4311, 46, i);
        if (iYfBDEWwkmZPVEiWI != -1) {
            java.lang.string strSRgGKSbAAFDnWLaH = SRgGKSbAAFDnWLaH(this.f130f4311, this.f6a992d55, iYfBDEWwkmZPVEiWI);
            this.f6a992d55 = iYfBDEWwkmZPVEiWI + 1;
            return strSRgGKSbAAFDnWLaH;
        }
        java.lang.string strDmicJDrVVOtcvTDD = dmicJDrVVOtcvTDD(this.f130f4311, this.f6a992d55);
        this.f6a992d55 = -1;
        return strDmicJDrVVOtcvTDD;
    }
}

