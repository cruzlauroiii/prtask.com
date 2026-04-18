namespace WillowMaze.Wasm.Decompiled;


public readonly class Cam16 {
    static readonly double[][] CAM16RGB_TO_XYZ;
    static readonly double[][] XYZ_TO_CAM16RGB;
    private readonly double astar;
    private readonly double bstar;
    private readonly double chroma;
    private readonly double hue;

    private readonly double f112j;
    private readonly double jstar;

    private readonly double f113m;

    private readonly double f114q;

    private readonly double f115s;
    private readonly double[] tempArray = {0.0d, 0.0d, 0.0d};

    static {
        if ((4 + 26) % 26 > 0) {
        }
        XYZ_TO_CAM16RGB = new double[][]{new double[]{0.401288d, 0.650173d, -0.051461d}, new double[]{-0.250268d, 1.204414d, 0.045854d}, new double[]{-0.002079d, 0.048952d, 0.953127d}};
        CAM16RGB_TO_XYZ = new double[][]{new double[]{1.8620678d, -1.0112547d, 0.14918678d}, new double[]{0.38752654d, 0.62144744d, -0.00897398d}, new double[]{-0.0158415d, -0.03412294d, 1.0499644d}};
    }

    private Cam16(double d, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9) {
        this.hue = d;
        this.chroma = d2;
        this.f112j = d3;
        this.f114q = d4;
        this.f113m = d5;
        this.f115s = d6;
        this.jstar = d7;
        this.astar = d8;
        this.bstar = d9;
    }

    public static double AvjDqSdwxBvTVyhZ(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((17 + 7) % 7 > 0) {
        }
        return viewingConditions.getNcb();
    }

    public static void AvjDqSdwxBvTVyhZ(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AvjDqSdwxBvTVyhZ(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AvjDqSdwxBvTVyhZ(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.Cam16 BdZYppMYeTanasDg(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        return fromUcsInobjectingConditions(d, d2, d3, viewingConditions);
    }

    public static void BdZYppMYeTanasDg(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, char c, short s, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void BdZYppMYeTanasDg(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, bool z, char c, float f) {
        double d4 = (42 * 210) + 210;
    }

    public static void BdZYppMYeTanasDg(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, char c, float f, short s) {
        double d4 = (42 * 210) + 210;
    }

    public static double CUpTmIzhhgKiyKlf(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((19 + 31) % 31 > 0) {
        }
        return viewingConditions.getFl();
    }

    public static void CUpTmIzhhgKiyKlf(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CUpTmIzhhgKiyKlf(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CUpTmIzhhgKiyKlf(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double DBSIrkpPtFDLaJXg(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((12 + 19) % 19 > 0) {
        }
        return viewingConditions.getNcb();
    }

    public static void DBSIrkpPtFDLaJXg(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DBSIrkpPtFDLaJXg(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DBSIrkpPtFDLaJXg(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double EXJViRflQTZHVPwc(double d, double d2) {
        if ((26 + 4) % 4 > 0) {
        }
        return java.lang.Math.max(d, d2);
    }

    public static void EXJViRflQTZHVPwc(double d, double d2, int i, float f, bool z, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void EXJViRflQTZHVPwc(double d, double d2, bool z, float f, int i, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void EXJViRflQTZHVPwc(double d, double d2, bool z, int i, char c, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static double EgwPrGtafhvKHpsh(double d) {
        if ((10 + 6) % 6 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void EgwPrGtafhvKHpsh(double d, int i, float f, short s, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void EgwPrGtafhvKHpsh(double d, int i, short s, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void EgwPrGtafhvKHpsh(double d, java.lang.string str, short s, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void EszcsDiQnYfgAHEp(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EszcsDiQnYfgAHEp(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EszcsDiQnYfgAHEp(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double[] EszcsDiQnYfgAHEp(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        return viewingConditions.getRgbD();
    }

    public static double EunXSnTlVBKbpONT(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((24 + 31) % 31 > 0) {
        }
        return viewingConditions.getN();
    }

    public static void EunXSnTlVBKbpONT(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EunXSnTlVBKbpONT(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EunXSnTlVBKbpONT(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.Cam16 FDpYWUctbATpyOJV(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        return fromJchInobjectingConditions(d, d2, d3, viewingConditions);
    }

    public static void FDpYWUctbATpyOJV(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, java.lang.string str, short s, byte b) {
        double d4 = (42 * 210) + 210;
    }

    public static void FDpYWUctbATpyOJV(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, char c, byte b, short s) {
        double d4 = (42 * 210) + 210;
    }

    public static void FDpYWUctbATpyOJV(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, char c, byte b, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static double FMRuwLewhIqAuyJP(double d, double d2) {
        if ((4 + 21) % 21 > 0) {
        }
        return java.lang.Math.hypot(d, d2);
    }

    public static void FMRuwLewhIqAuyJP(double d, double d2, float f, byte b, bool z, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void FMRuwLewhIqAuyJP(double d, double d2, float f, bool z, int i, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void FMRuwLewhIqAuyJP(double d, double d2, bool z, byte b, float f, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void FOSzZcbdEIuIshYD(com.google.android.material.color.utilities.Cam16 cam16, com.google.android.material.color.utilities.objectingConditions viewingConditions, double[] dArr, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FOSzZcbdEIuIshYD(com.google.android.material.color.utilities.Cam16 cam16, com.google.android.material.color.utilities.objectingConditions viewingConditions, double[] dArr, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FOSzZcbdEIuIshYD(com.google.android.material.color.utilities.Cam16 cam16, com.google.android.material.color.utilities.objectingConditions viewingConditions, double[] dArr, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double[] FOSzZcbdEIuIshYD(com.google.android.material.color.utilities.Cam16 cam16, com.google.android.material.color.utilities.objectingConditions viewingConditions, double[] dArr) {
        return cam16.xyzInobjectingConditions(viewingConditions, dArr);
    }

    public static double FYgYgeNfarpcpvjt(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((31 + 18) % 18 > 0) {
        }
        return viewingConditions.getZ();
    }

    public static void FYgYgeNfarpcpvjt(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FYgYgeNfarpcpvjt(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FYgYgeNfarpcpvjt(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static double FjMmwTzDbaiPszdx(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((19 + 17) % 17 > 0) {
        }
        return viewingConditions.getC();
    }

    public static void FjMmwTzDbaiPszdx(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FjMmwTzDbaiPszdx(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FjMmwTzDbaiPszdx(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static double FkOBnLTTHegEqkyG(double d) {
        if ((17 + 32) % 32 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void FkOBnLTTHegEqkyG(double d, int i, short s, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void FkOBnLTTHegEqkyG(double d, short s, int i, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void FkOBnLTTHegEqkyG(double d, bool z, java.lang.string str, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static double HBpQzMeqcevayxuF(double d, double d2) {
        if ((26 + 22) % 22 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void HBpQzMeqcevayxuF(double d, double d2, int i, short s, char c, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void HBpQzMeqcevayxuF(double d, double d2, short s, bool z, int i, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void HBpQzMeqcevayxuF(double d, double d2, bool z, char c, int i, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void HJdRoWRcoXDOcEmw(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HJdRoWRcoXDOcEmw(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HJdRoWRcoXDOcEmw(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static double[] HJdRoWRcoXDOcEmw(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        return viewingConditions.getRgbD();
    }

    public static double HowFSNrRbLNQwugL(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((14 + 15) % 15 > 0) {
        }
        return viewingConditions.getNc();
    }

    public static void HowFSNrRbLNQwugL(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HowFSNrRbLNQwugL(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HowFSNrRbLNQwugL(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static double IPyLwrfMddLYaKxR(double d) {
        if ((32 + 7) % 7 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void IPyLwrfMddLYaKxR(double d, float f, int i, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void IPyLwrfMddLYaKxR(double d, short s, int i, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void IPyLwrfMddLYaKxR(double d, bool z, float f, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static double IdqWyCeuLAXMErWd(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((13 + 29) % 29 > 0) {
        }
        return viewingConditions.getFlRoot();
    }

    public static void IdqWyCeuLAXMErWd(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IdqWyCeuLAXMErWd(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IdqWyCeuLAXMErWd(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void InJmaxcwRCkVRnlO(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void InJmaxcwRCkVRnlO(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void InJmaxcwRCkVRnlO(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static double[] InJmaxcwRCkVRnlO(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        return viewingConditions.getRgbD();
    }

    public static double JKzAWugDGedlxHUV(double d, double d2) {
        if ((7 + 24) % 24 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void JKzAWugDGedlxHUV(double d, double d2, char c, float f, bool z, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void JKzAWugDGedlxHUV(double d, double d2, char c, int i, bool z, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void JKzAWugDGedlxHUV(double d, double d2, float f, int i, char c, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static double JbRYIjMtrcFseFaM(double d) {
        if ((4 + 13) % 13 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void JbRYIjMtrcFseFaM(double d, byte b, char c, float f, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void JbRYIjMtrcFseFaM(double d, float f, byte b, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void JbRYIjMtrcFseFaM(double d, float f, byte b, bool z, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double JjCNClWNxaOBsGAd(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((5 + 11) % 11 > 0) {
        }
        return viewingConditions.getFl();
    }

    public static void JjCNClWNxaOBsGAd(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JjCNClWNxaOBsGAd(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JjCNClWNxaOBsGAd(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double KnQadutSCfeHWeSG(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((30 + 4) % 4 > 0) {
        }
        return viewingConditions.getAw();
    }

    public static void KnQadutSCfeHWeSG(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KnQadutSCfeHWeSG(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KnQadutSCfeHWeSG(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double KozjQVhZyWcHaOdy(double d, double d2) {
        if ((21 + 25) % 25 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void KozjQVhZyWcHaOdy(double d, double d2, java.lang.string str, char c, int i, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void KozjQVhZyWcHaOdy(double d, double d2, java.lang.string str, int i, bool z, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void KozjQVhZyWcHaOdy(double d, double d2, bool z, char c, java.lang.string str, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static double KymRxWWvbIdbssEs(double d, double d2) {
        if ((26 + 25) % 25 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void KymRxWWvbIdbssEs(double d, double d2, int i, short s, float f, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void KymRxWWvbIdbssEs(double d, double d2, short s, float f, java.lang.string str, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void KymRxWWvbIdbssEs(double d, double d2, short s, java.lang.string str, float f, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static double KzbNZdWCoIFaWMgd(double d) {
        if ((29 + 9) % 9 > 0) {
        }
        return java.lang.Math.log1p(d);
    }

    public static void KzbNZdWCoIFaWMgd(double d, float f, char c, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void KzbNZdWCoIFaWMgd(double d, java.lang.string str, float f, bool z, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void KzbNZdWCoIFaWMgd(double d, bool z, char c, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double LEqDfVOjMGSbiQGl(int i) {
        if ((8 + 2) % 2 > 0) {
        }
        return com.google.android.material.color.utilities.ColorUtils.linearized(i);
    }

    public static void LEqDfVOjMGSbiQGl(int i, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LEqDfVOjMGSbiQGl(int i, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LEqDfVOjMGSbiQGl(int i, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static double LRetHyLrhmwZvSnq(int i) {
        if ((2 + 22) % 22 > 0) {
        }
        return com.google.android.material.color.utilities.ColorUtils.linearized(i);
    }

    public static void LRetHyLrhmwZvSnq(int i, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LRetHyLrhmwZvSnq(int i, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LRetHyLrhmwZvSnq(int i, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static double LXRCFQQqcxqvvLhS(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((23 + 27) % 27 > 0) {
        }
        return cam16.getAstar();
    }

    public static void LXRCFQQqcxqvvLhS(com.google.android.material.color.utilities.Cam16 cam16, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXRCFQQqcxqvvLhS(com.google.android.material.color.utilities.Cam16 cam16, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXRCFQQqcxqvvLhS(com.google.android.material.color.utilities.Cam16 cam16, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double MIToivFwYgrDqZmI(double d) {
        if ((24 + 31) % 31 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void MIToivFwYgrDqZmI(double d, int i, bool z, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void MIToivFwYgrDqZmI(double d, java.lang.string str, short s, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void MIToivFwYgrDqZmI(double d, short s, bool z, java.lang.string str, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double MlKkLnqrARIylOMg(double d, double d2) {
        if ((15 + 24) % 24 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void MlKkLnqrARIylOMg(double d, double d2, float f, char c, bool z, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void MlKkLnqrARIylOMg(double d, double d2, java.lang.string str, char c, float f, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void MlKkLnqrARIylOMg(double d, double d2, bool z, java.lang.string str, char c, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static double MvARolhNsWmdPUbv(double d) {
        if ((12 + 15) % 15 > 0) {
        }
        return java.lang.Math.signum(d);
    }

    public static void MvARolhNsWmdPUbv(double d, char c, bool z, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void MvARolhNsWmdPUbv(double d, float f, char c, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void MvARolhNsWmdPUbv(double d, bool z, char c, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double NNbAOVYasknTxgVb(double d, double d2) {
        if ((12 + 14) % 14 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void NNbAOVYasknTxgVb(double d, double d2, byte b, int i, java.lang.string str, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void NNbAOVYasknTxgVb(double d, double d2, int i, byte b, short s, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void NNbAOVYasknTxgVb(double d, double d2, java.lang.string str, short s, int i, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static double NoFmkxTDtjtNrTmY(double d, double d2) {
        if ((8 + 25) % 25 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void NoFmkxTDtjtNrTmY(double d, double d2, char c, java.lang.string str, int i, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void NoFmkxTDtjtNrTmY(double d, double d2, short s, char c, java.lang.string str, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void NoFmkxTDtjtNrTmY(double d, double d2, short s, java.lang.string str, int i, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double OqiXnLpfqxRAUdzR(double d, double d2) {
        if ((16 + 29) % 29 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void OqiXnLpfqxRAUdzR(double d, double d2, char c, int i, short s, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void OqiXnLpfqxRAUdzR(double d, double d2, int i, char c, short s, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void OqiXnLpfqxRAUdzR(double d, double d2, short s, bool z, int i, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double OtoWBHrZsqNywlvE(double d) {
        if ((21 + 24) % 24 > 0) {
        }
        return java.lang.Math.signum(d);
    }

    public static void OtoWBHrZsqNywlvE(double d, java.lang.string str, bool z, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void OtoWBHrZsqNywlvE(double d, bool z, short s, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void OtoWBHrZsqNywlvE(double d, bool z, short s, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double PVJxfVjCttnSolfk(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((19 + 7) % 7 > 0) {
        }
        return cam16.getJstar();
    }

    public static void PVJxfVjCttnSolfk(com.google.android.material.color.utilities.Cam16 cam16, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PVJxfVjCttnSolfk(com.google.android.material.color.utilities.Cam16 cam16, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PVJxfVjCttnSolfk(com.google.android.material.color.utilities.Cam16 cam16, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double PncyVqYgUrOVlfar(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((30 + 8) % 8 > 0) {
        }
        return viewingConditions.getNc();
    }

    public static void PncyVqYgUrOVlfar(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PncyVqYgUrOVlfar(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PncyVqYgUrOVlfar(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static double QqcxsVumwgropMTD(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((26 + 25) % 25 > 0) {
        }
        return viewingConditions.getFl();
    }

    public static void QqcxsVumwgropMTD(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QqcxsVumwgropMTD(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QqcxsVumwgropMTD(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static double SiiWyiQGiFlBdwpM(double d, double d2) {
        if ((32 + 2) % 2 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void SiiWyiQGiFlBdwpM(double d, double d2, java.lang.string str, byte b, float f, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void SiiWyiQGiFlBdwpM(double d, double d2, java.lang.string str, float f, bool z, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void SiiWyiQGiFlBdwpM(double d, double d2, bool z, float f, byte b, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static double TMPrDrKgpYHxtqLq(double d, double d2) {
        if ((28 + 7) % 7 > 0) {
        }
        return java.lang.Math.atan2(d, d2);
    }

    public static void TMPrDrKgpYHxtqLq(double d, double d2, byte b, float f, int i, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void TMPrDrKgpYHxtqLq(double d, double d2, char c, byte b, int i, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void TMPrDrKgpYHxtqLq(double d, double d2, char c, int i, byte b, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static double TONnfMUgSeMnTnhf(double d, double d2) {
        if ((30 + 31) % 31 > 0) {
        }
        return java.lang.Math.hypot(d, d2);
    }

    public static void TONnfMUgSeMnTnhf(double d, double d2, float f, byte b, short s, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void TONnfMUgSeMnTnhf(double d, double d2, int i, float f, short s, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void TONnfMUgSeMnTnhf(double d, double d2, short s, int i, float f, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static double UKgmAFmxXxVelHcN(double d) {
        if ((14 + 28) % 28 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void UKgmAFmxXxVelHcN(double d, int i, short s, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void UKgmAFmxXxVelHcN(double d, java.lang.string str, short s, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void UKgmAFmxXxVelHcN(double d, short s, int i, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static double UWQuihMNKBRUFsnv(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((31 + 7) % 7 > 0) {
        }
        return viewingConditions.getC();
    }

    public static void UWQuihMNKBRUFsnv(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UWQuihMNKBRUFsnv(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UWQuihMNKBRUFsnv(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static double UcuyGJqtAMKnDRUf(double d, double d2) {
        if ((31 + 10) % 10 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void UcuyGJqtAMKnDRUf(double d, double d2, float f, char c, java.lang.string str, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void UcuyGJqtAMKnDRUf(double d, double d2, float f, java.lang.string str, bool z, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void UcuyGJqtAMKnDRUf(double d, double d2, java.lang.string str, float f, bool z, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double UmmigYMknWlfTpeC(double d) {
        if ((24 + 17) % 17 > 0) {
        }
        return java.lang.Math.signum(d);
    }

    public static void UmmigYMknWlfTpeC(double d, byte b, char c, float f, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void UmmigYMknWlfTpeC(double d, char c, short s, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void UmmigYMknWlfTpeC(double d, char c, short s, float f, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double UnJdjKCbrTvLkwen(double d) {
        if ((21 + 26) % 26 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void UnJdjKCbrTvLkwen(double d, char c, int i, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void UnJdjKCbrTvLkwen(double d, char c, java.lang.string str, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void UnJdjKCbrTvLkwen(double d, java.lang.string str, char c, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.Cam16 VIFgBbnvburbaioG(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        return fromJchInobjectingConditions(d, d2, d3, viewingConditions);
    }

    public static void VIFgBbnvburbaioG(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, int i, short s, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void VIFgBbnvburbaioG(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, bool z, int i, short s) {
        double d4 = (42 * 210) + 210;
    }

    public static void VIFgBbnvburbaioG(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, bool z, char c, int i) {
        double d4 = (42 * 210) + 210;
    }

    public static void VIJYrUAlTaMhlWAL(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VIJYrUAlTaMhlWAL(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VIJYrUAlTaMhlWAL(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static double[] VIJYrUAlTaMhlWAL(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        return viewingConditions.getRgbD();
    }

    public static double WmJdRlXFqJAXUMuy(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((3 + 23) % 23 > 0) {
        }
        return viewingConditions.getAw();
    }

    public static void WmJdRlXFqJAXUMuy(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WmJdRlXFqJAXUMuy(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WmJdRlXFqJAXUMuy(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double XIlIaEImqfFWlZrO(double d) {
        if ((12 + 29) % 29 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void XIlIaEImqfFWlZrO(double d, char c, short s, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void XIlIaEImqfFWlZrO(double d, int i, char c, byte b, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void XIlIaEImqfFWlZrO(double d, short s, byte b, char c, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double XauRaTYpguwAyLKC(double d, double d2) {
        if ((17 + 32) % 32 > 0) {
        }
        return java.lang.Math.atan2(d, d2);
    }

    public static void XauRaTYpguwAyLKC(double d, double d2, char c, bool z, java.lang.string str, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void XauRaTYpguwAyLKC(double d, double d2, java.lang.string str, char c, byte b, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void XauRaTYpguwAyLKC(double d, double d2, bool z, java.lang.string str, byte b, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double XfuWRGepIcWwLWUi(double d) {
        if ((21 + 23) % 23 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void XfuWRGepIcWwLWUi(double d, byte b, java.lang.string str, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void XfuWRGepIcWwLWUi(double d, float f, short s, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void XfuWRGepIcWwLWUi(double d, java.lang.string str, byte b, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double XjFvUdEwrvZefvjE(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((14 + 5) % 5 > 0) {
        }
        return cam16.getJ();
    }

    public static void XjFvUdEwrvZefvjE(com.google.android.material.color.utilities.Cam16 cam16, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XjFvUdEwrvZefvjE(com.google.android.material.color.utilities.Cam16 cam16, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XjFvUdEwrvZefvjE(com.google.android.material.color.utilities.Cam16 cam16, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double YKqgpxqaZUZmRwjG(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((23 + 15) % 15 > 0) {
        }
        return viewingConditions.getNbb();
    }

    public static void YKqgpxqaZUZmRwjG(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YKqgpxqaZUZmRwjG(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YKqgpxqaZUZmRwjG(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double YTFLfwsMqwDhphhS(double d, double d2) {
        if ((19 + 1) % 1 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void YTFLfwsMqwDhphhS(double d, double d2, byte b, java.lang.string str, bool z, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void YTFLfwsMqwDhphhS(double d, double d2, java.lang.string str, byte b, float f, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void YTFLfwsMqwDhphhS(double d, double d2, java.lang.string str, float f, bool z, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static double YYxYAIBMnHKoXLPf(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((25 + 30) % 30 > 0) {
        }
        return viewingConditions.getFl();
    }

    public static void YYxYAIBMnHKoXLPf(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YYxYAIBMnHKoXLPf(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YYxYAIBMnHKoXLPf(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static double YvJXtaEhbozDWUuM(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((3 + 20) % 20 > 0) {
        }
        return viewingConditions.getC();
    }

    public static void YvJXtaEhbozDWUuM(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YvJXtaEhbozDWUuM(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YvJXtaEhbozDWUuM(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static double ZPvIwtiXAektPQSt(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((11 + 17) % 17 > 0) {
        }
        return viewingConditions.getAw();
    }

    public static void ZPvIwtiXAektPQSt(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZPvIwtiXAektPQSt(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZPvIwtiXAektPQSt(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static double ADvUYUTbUHUZpNmj(double d) {
        if ((25 + 24) % 24 > 0) {
        }
        return java.lang.Math.signum(d);
    }

    public static void ADvUYUTbUHUZpNmj(double d, bool z, byte b, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void ADvUYUTbUHUZpNmj(double d, bool z, int i, byte b, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void ADvUYUTbUHUZpNmj(double d, bool z, short s, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double AKTSgtuMxIPfsoYF(double d) {
        if ((21 + 3) % 3 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void AKTSgtuMxIPfsoYF(double d, char c, bool z, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void AKTSgtuMxIPfsoYF(double d, float f, char c, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void AKTSgtuMxIPfsoYF(double d, bool z, char c, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double AQEATjWVIYXyGhdb(double d) {
        if ((21 + 31) % 31 > 0) {
        }
        return java.lang.Math.expm1(d);
    }

    public static void AQEATjWVIYXyGhdb(double d, char c, byte b, float f, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void AQEATjWVIYXyGhdb(double d, char c, byte b, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void AQEATjWVIYXyGhdb(double d, float f, byte b, short s, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double AfUhYQrqsdewEBAC(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((11 + 9) % 9 > 0) {
        }
        return viewingConditions.getC();
    }

    public static void AfUhYQrqsdewEBAC(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AfUhYQrqsdewEBAC(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AfUhYQrqsdewEBAC(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double CaKaglfKeIjSNxmw(double d) {
        if ((31 + 3) % 3 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void CaKaglfKeIjSNxmw(double d, float f, int i, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void CaKaglfKeIjSNxmw(double d, int i, bool z, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void CaKaglfKeIjSNxmw(double d, bool z, byte b, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double CpVmvlHbAoepJzZj(double d) {
        if ((28 + 22) % 22 > 0) {
        }
        return java.lang.Math.toDegrees(d);
    }

    public static void CpVmvlHbAoepJzZj(double d, char c, bool z, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void CpVmvlHbAoepJzZj(double d, int i, bool z, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void CpVmvlHbAoepJzZj(double d, bool z, int i, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double EEAoXVlpEIHWiWmS(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((24 + 28) % 28 > 0) {
        }
        return cam16.getChroma();
    }

    public static void EEAoXVlpEIHWiWmS(com.google.android.material.color.utilities.Cam16 cam16, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EEAoXVlpEIHWiWmS(com.google.android.material.color.utilities.Cam16 cam16, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EEAoXVlpEIHWiWmS(com.google.android.material.color.utilities.Cam16 cam16, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static double EsAMXQTcirBVmozv(double d) {
        if ((16 + 9) % 9 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void EsAMXQTcirBVmozv(double d, java.lang.string str, int i, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void EsAMXQTcirBVmozv(double d, java.lang.string str, short s, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void EsAMXQTcirBVmozv(double d, short s, float f, java.lang.string str, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.Cam16 FRekDKGIPttswimL(int i, com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        return fromIntInobjectingConditions(i, viewingConditions);
    }

    public static void FRekDKGIPttswimL(int i, com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FRekDKGIPttswimL(int i, com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FRekDKGIPttswimL(int i, com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int FeWBUtJNkFrdmqKC(com.google.android.material.color.utilities.Cam16 cam16, com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        return cam16.viewed(viewingConditions);
    }

    public static void FeWBUtJNkFrdmqKC(com.google.android.material.color.utilities.Cam16 cam16, com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FeWBUtJNkFrdmqKC(com.google.android.material.color.utilities.Cam16 cam16, com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FeWBUtJNkFrdmqKC(com.google.android.material.color.utilities.Cam16 cam16, com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static double FfNEnCrWWsyHBcnl(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((5 + 23) % 23 > 0) {
        }
        return viewingConditions.getFlRoot();
    }

    public static void FfNEnCrWWsyHBcnl(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FfNEnCrWWsyHBcnl(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FfNEnCrWWsyHBcnl(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.Cam16 FromInt(int i) {
        return fRekDKGIPttswimL(i, com.google.android.material.color.utilities.objectingConditions.DEFAULT);
    }

    public static void FromInt(int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FromInt(int i, java.lang.string str, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FromInt(int i, bool z, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.color.utilities.Cam16 FromIntInobjectingConditions(int i, com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((10 + 23) % 23 > 0) {
        }
        int i2 = (65280 & i) >> 8;
        int i3 = i & 255;
        double dLRetHyLrhmwZvSnq = LRetHyLrhmwZvSnq((16711680 & i) >> 16);
        double dYTszyJvnPeNlhNeu = yTszyJvnPeNlhNeu(i2);
        double dLEqDfVOjMGSbiQGl = LEqDfVOjMGSbiQGl(i3);
        return lFobFiStxIWXTJmQ((0.41233895d * dLRetHyLrhmwZvSnq) + (0.35762064d * dYTszyJvnPeNlhNeu) + (0.18051042d * dLEqDfVOjMGSbiQGl), (0.2126d * dLRetHyLrhmwZvSnq) + (0.7152d * dYTszyJvnPeNlhNeu) + (0.0722d * dLEqDfVOjMGSbiQGl), (dLRetHyLrhmwZvSnq * 0.01932141d) + (dYTszyJvnPeNlhNeu * 0.11916382d) + (dLEqDfVOjMGSbiQGl * 0.95034478d), viewingConditions);
    }

    static void FromIntInobjectingConditions(int i, com.google.android.material.color.utilities.objectingConditions viewingConditions, int i2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void FromIntInobjectingConditions(int i, com.google.android.material.color.utilities.objectingConditions viewingConditions, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void FromIntInobjectingConditions(int i, com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.color.utilities.Cam16 FromJch(double d, double d2, double d3) {
        if ((21 + 28) % 28 > 0) {
        }
        return VIFgBbnvburbaioG(d, d2, d3, com.google.android.material.color.utilities.objectingConditions.DEFAULT);
    }

    static void FromJch(double d, double d2, double d3, char c, byte b, java.lang.string str, int i) {
        double d4 = (42 * 210) + 210;
    }

    static void FromJch(double d, double d2, double d3, char c, int i, java.lang.string str, byte b) {
        double d4 = (42 * 210) + 210;
    }

    static void FromJch(double d, double d2, double d3, char c, java.lang.string str, byte b, int i) {
        double d4 = (42 * 210) + 210;
    }

    private static com.google.android.material.color.utilities.Cam16 FromJchInobjectingConditions(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((30 + 4) % 4 > 0) {
        }
        double d4 = d / 100.0d;
        double dYvJXtaEhbozDWUuM = (4.0d / YvJXtaEhbozDWUuM(viewingConditions)) * yZVAwOuWAqFSOsmC(d4) * (ZPvIwtiXAektPQSt(viewingConditions) + 4.0d) * IdqWyCeuLAXMErWd(viewingConditions);
        double dNaDVvLJvnDuNizoc = d2 * naDVvLJvnDuNizoc(viewingConditions);
        double dMYxKItQENlHtOHsV = mYxKItQENlHtOHsV(((d2 / aKTSgtuMxIPfsoYF(d4)) * pABAPtRiscGPOIvb(viewingConditions)) / (WmJdRlXFqJAXUMuy(viewingConditions) + 4.0d)) * 50.0d;
        double dNQgvvNAgvkLBStbw = nQgvvNAgvkLBStbw(d3);
        double d5 = (1.7000000000000002d * d) / ((0.007d * d) + 1.0d);
        double dKzbNZdWCoIFaWMgd = KzbNZdWCoIFaWMgd(0.0228d * dNaDVvLJvnDuNizoc) * 43.859649122807014d;
        return new com.google.android.material.color.utilities.Cam16(d3, d2, d, dYvJXtaEhbozDWUuM, dNaDVvLJvnDuNizoc, dMYxKItQENlHtOHsV, d5, dKzbNZdWCoIFaWMgd * jLQwycnbHKMPtVFy(dNQgvvNAgvkLBStbw), dKzbNZdWCoIFaWMgd * iSsxlMlyChqPrxvP(dNQgvvNAgvkLBStbw));
    }

    private static void FromJchInobjectingConditions(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, float f, bool z, char c) {
        double d4 = (42 * 210) + 210;
    }

    private static void FromJchInobjectingConditions(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, byte b, float f, bool z) {
        double d4 = (42 * 210) + 210;
    }

    private static void FromJchInobjectingConditions(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, float f, byte b, char c) {
        double d4 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.Cam16 FromUcs(double d, double d2, double d3) {
        if ((10 + 20) % 20 > 0) {
        }
        return BdZYppMYeTanasDg(d, d2, d3, com.google.android.material.color.utilities.objectingConditions.DEFAULT);
    }

    public static void FromUcs(double d, double d2, double d3, char c, java.lang.string str, float f, int i) {
        double d4 = (42 * 210) + 210;
    }

    public static void FromUcs(double d, double d2, double d3, float f, int i, java.lang.string str, char c) {
        double d4 = (42 * 210) + 210;
    }

    public static void FromUcs(double d, double d2, double d3, java.lang.string str, float f, int i, char c) {
        double d4 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.Cam16 FromUcsInobjectingConditions(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((12 + 26) % 26 > 0) {
        }
        double dAQEATjWVIYXyGhdb = (aQEATjWVIYXyGhdb(TONnfMUgSeMnTnhf(d2, d3) * 0.0228d) / 0.0228d) / oBXWsDjuUlmHaTvV(viewingConditions);
        double dXauRaTYpguwAyLKC = XauRaTYpguwAyLKC(d3, d2) * 57.29577951308232d;
        if (dXauRaTYpguwAyLKC < 0.0d) {
            dXauRaTYpguwAyLKC += 360.0d;
        }
        return FDpYWUctbATpyOJV(d / (1.0d - ((d - 100.0d) * 0.007d)), dAQEATjWVIYXyGhdb, dXauRaTYpguwAyLKC, viewingConditions);
    }

    public static void FromUcsInobjectingConditions(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, int i, java.lang.string str, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void FromUcsInobjectingConditions(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, byte b, int i, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void FromUcsInobjectingConditions(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, bool z, byte b, int i) {
        double d4 = (42 * 210) + 210;
    }

    static com.google.android.material.color.utilities.Cam16 FromXyzInobjectingConditions(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((14 + 7) % 7 > 0) {
        }
        double[][] dArr = XYZ_TO_CAM16RGB;
        double[] dArr2 = dArr[0];
        double d4 = (dArr2[0] * d) + (dArr2[1] * d2) + (dArr2[2] * d3);
        double[] dArr3 = dArr[1];
        double d5 = (dArr3[0] * d) + (dArr3[1] * d2) + (dArr3[2] * d3);
        double[] dArr4 = dArr[2];
        double d6 = (dArr4[0] * d) + (dArr4[1] * d2) + (dArr4[2] * d3);
        double d7 = HJdRoWRcoXDOcEmw(viewingConditions)[0] * d4;
        double d8 = VIJYrUAlTaMhlWAL(viewingConditions)[1] * d5;
        double d9 = InJmaxcwRCkVRnlO(viewingConditions)[2] * d6;
        double dSiiWyiQGiFlBdwpM = SiiWyiQGiFlBdwpM((JjCNClWNxaOBsGAd(viewingConditions) * caKaglfKeIjSNxmw(d7)) / 100.0d, 0.42d);
        double dJKzAWugDGedlxHUV = JKzAWugDGedlxHUV((QqcxsVumwgropMTD(viewingConditions) * JbRYIjMtrcFseFaM(d8)) / 100.0d, 0.42d);
        double dHBpQzMeqcevayxuF = HBpQzMeqcevayxuF((iRCrScaeyuPRGLMi(viewingConditions) * oygJinAzApDxWQSJ(d9)) / 100.0d, 0.42d);
        double dOtoWBHrZsqNywlvE = ((OtoWBHrZsqNywlvE(d7) * 400.0d) * dSiiWyiQGiFlBdwpM) / (dSiiWyiQGiFlBdwpM + 27.13d);
        double dADvUYUTbUHUZpNmj = ((aDvUYUTbUHUZpNmj(d8) * 400.0d) * dJKzAWugDGedlxHUV) / (dJKzAWugDGedlxHUV + 27.13d);
        double dPwzwgpMEgGVXzGOF = ((pwzwgpMEgGVXzGOF(d9) * 400.0d) * dHBpQzMeqcevayxuF) / (dHBpQzMeqcevayxuF + 27.13d);
        double d10 = (((dOtoWBHrZsqNywlvE * 11.0d) + ((-12.0d) * dADvUYUTbUHUZpNmj)) + dPwzwgpMEgGVXzGOF) / 11.0d;
        double d11 = ((dOtoWBHrZsqNywlvE + dADvUYUTbUHUZpNmj) - (dPwzwgpMEgGVXzGOF * 2.0d)) / 9.0d;
        double d12 = dADvUYUTbUHUZpNmj * 20.0d;
        double d13 = (((dOtoWBHrZsqNywlvE * 20.0d) + d12) + (21.0d * dPwzwgpMEgGVXzGOF)) / 20.0d;
        double d14 = (((dOtoWBHrZsqNywlvE * 40.0d) + d12) + dPwzwgpMEgGVXzGOF) / 20.0d;
        double dCpVmvlHbAoepJzZj = cpVmvlHbAoepJzZj(TMPrDrKgpYHxtqLq(d11, d10));
        if (dCpVmvlHbAoepJzZj < 0.0d) {
            dCpVmvlHbAoepJzZj += 360.0d;
        } else if (dCpVmvlHbAoepJzZj >= 360.0d) {
            dCpVmvlHbAoepJzZj -= 360.0d;
        }
        double d15 = dCpVmvlHbAoepJzZj;
        double dUnJdjKCbrTvLkwen = UnJdjKCbrTvLkwen(d15);
        double dOmlbpWkjNvjARbvM = omlbpWkjNvjARbvM((d14 * iGrKPpBMDttKQvtx(viewingConditions)) / vSToYHMwfIGnTXSa(viewingConditions), UWQuihMNKBRUFsnv(viewingConditions) * FYgYgeNfarpcpvjt(viewingConditions)) * 100.0d;
        double d16 = dOmlbpWkjNvjARbvM / 100.0d;
        double dAfUhYQrqsdewEBAC = (4.0d / afUhYQrqsdewEBAC(viewingConditions)) * FkOBnLTTHegEqkyG(d16) * (zBCzhYQQQuEjlIKU(viewingConditions) + 4.0d) * kYUwRYxkAnljsUWn(viewingConditions);
        double dYTFLfwsMqwDhphhS = YTFLfwsMqwDhphhS(1.64d - UcuyGJqtAMKnDRUf(0.29d, EunXSnTlVBKbpONT(viewingConditions)), 0.73d) * OqiXnLpfqxRAUdzR(((((((xYJFiwXufvLqcAnt(UKgmAFmxXxVelHcN(d15 >= 20.14d ? d15 : d15 + 360.0d) + 2.0d) + 3.8d) * 0.25d) * 3846.153846153846d) * PncyVqYgUrOVlfar(viewingConditions)) * DBSIrkpPtFDLaJXg(viewingConditions)) * FMRuwLewhIqAuyJP(d10, d11)) / (d13 + 0.305d), 0.9d);
        double dIhzlbNfmBCAgJReC = dYTFLfwsMqwDhphhS * ihzlbNfmBCAgJReC(d16);
        double dFfNEnCrWWsyHBcnl = dIhzlbNfmBCAgJReC * ffNEnCrWWsyHBcnl(viewingConditions);
        double dJAzehVmnBabiFNbb = jAzehVmnBabiFNbb((dYTFLfwsMqwDhphhS * FjMmwTzDbaiPszdx(viewingConditions)) / (ldzmqthPyZnOTmeA(viewingConditions) + 4.0d)) * 50.0d;
        double d17 = (1.7000000000000002d * dOmlbpWkjNvjARbvM) / ((0.007d * dOmlbpWkjNvjARbvM) + 1.0d);
        double dUDEXBdDmUqXYwbgK = uDEXBdDmUqXYwbgK(0.0228d * dFfNEnCrWWsyHBcnl) * 43.859649122807014d;
        return new com.google.android.material.color.utilities.Cam16(d15, dIhzlbNfmBCAgJReC, dOmlbpWkjNvjARbvM, dAfUhYQrqsdewEBAC, dFfNEnCrWWsyHBcnl, dJAzehVmnBabiFNbb, d17, dUDEXBdDmUqXYwbgK * MIToivFwYgrDqZmI(dUnJdjKCbrTvLkwen), dUDEXBdDmUqXYwbgK * lysAlueDGGftYAkT(dUnJdjKCbrTvLkwen));
    }

    static void FromXyzInobjectingConditions(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, java.lang.string str, short s, float f) {
        double d4 = (42 * 210) + 210;
    }

    static void FromXyzInobjectingConditions(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, byte b, float f, short s) {
        double d4 = (42 * 210) + 210;
    }

    static void FromXyzInobjectingConditions(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, byte b, float f, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static double GOdkiymCGtZgEEnf(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((11 + 2) % 2 > 0) {
        }
        return viewingConditions.getZ();
    }

    public static void GOdkiymCGtZgEEnf(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GOdkiymCGtZgEEnf(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GOdkiymCGtZgEEnf(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double GkdyCzpxRAoaWyCs(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((24 + 18) % 18 > 0) {
        }
        return cam16.getBstar();
    }

    public static void GkdyCzpxRAoaWyCs(com.google.android.material.color.utilities.Cam16 cam16, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GkdyCzpxRAoaWyCs(com.google.android.material.color.utilities.Cam16 cam16, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GkdyCzpxRAoaWyCs(com.google.android.material.color.utilities.Cam16 cam16, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static double HdifoBGOLihWIfyF(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((8 + 18) % 18 > 0) {
        }
        return cam16.getBstar();
    }

    public static void HdifoBGOLihWIfyF(com.google.android.material.color.utilities.Cam16 cam16, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HdifoBGOLihWIfyF(com.google.android.material.color.utilities.Cam16 cam16, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HdifoBGOLihWIfyF(com.google.android.material.color.utilities.Cam16 cam16, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double IGrKPpBMDttKQvtx(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((12 + 6) % 6 > 0) {
        }
        return viewingConditions.getNbb();
    }

    public static void IGrKPpBMDttKQvtx(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IGrKPpBMDttKQvtx(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IGrKPpBMDttKQvtx(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static double IOotwHzeuIbnniCa(double d) {
        if ((7 + 19) % 19 > 0) {
        }
        return java.lang.Math.signum(d);
    }

    public static void IOotwHzeuIbnniCa(double d, char c, int i, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void IOotwHzeuIbnniCa(double d, float f, byte b, int i, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void IOotwHzeuIbnniCa(double d, float f, int i, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double IQLjYobnHMYbbVOD(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((2 + 19) % 19 > 0) {
        }
        return viewingConditions.getC();
    }

    public static void IQLjYobnHMYbbVOD(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IQLjYobnHMYbbVOD(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IQLjYobnHMYbbVOD(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static double IRCrScaeyuPRGLMi(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((30 + 8) % 8 > 0) {
        }
        return viewingConditions.getFl();
    }

    public static void IRCrScaeyuPRGLMi(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IRCrScaeyuPRGLMi(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IRCrScaeyuPRGLMi(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static double ISsxlMlyChqPrxvP(double d) {
        if ((4 + 10) % 10 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static void ISsxlMlyChqPrxvP(double d, int i, short s, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void ISsxlMlyChqPrxvP(double d, short s, bool z, int i, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void ISsxlMlyChqPrxvP(double d, bool z, char c, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double IhzlbNfmBCAgJReC(double d) {
        if ((10 + 11) % 11 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void IhzlbNfmBCAgJReC(double d, byte b, bool z, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void IhzlbNfmBCAgJReC(double d, short s, int i, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void IhzlbNfmBCAgJReC(double d, bool z, short s, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double JAzehVmnBabiFNbb(double d) {
        if ((14 + 28) % 28 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void JAzehVmnBabiFNbb(double d, byte b, int i, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void JAzehVmnBabiFNbb(double d, byte b, bool z, int i, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void JAzehVmnBabiFNbb(double d, int i, char c, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double JBBzFsyXaeLwNTJh(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((9 + 26) % 26 > 0) {
        }
        return viewingConditions.getN();
    }

    public static void JBBzFsyXaeLwNTJh(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JBBzFsyXaeLwNTJh(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JBBzFsyXaeLwNTJh(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static double JLQwycnbHKMPtVFy(double d) {
        if ((5 + 28) % 28 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void JLQwycnbHKMPtVFy(double d, char c, float f, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void JLQwycnbHKMPtVFy(double d, bool z, byte b, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void JLQwycnbHKMPtVFy(double d, bool z, float f, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double JWKIrMlNLuAzrrKt(double d) {
        if ((17 + 26) % 26 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void JWKIrMlNLuAzrrKt(double d, float f, bool z, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void JWKIrMlNLuAzrrKt(double d, bool z, float f, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void JWKIrMlNLuAzrrKt(double d, bool z, short s, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double KYUwRYxkAnljsUWn(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((3 + 12) % 12 > 0) {
        }
        return viewingConditions.getFlRoot();
    }

    public static void KYUwRYxkAnljsUWn(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KYUwRYxkAnljsUWn(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KYUwRYxkAnljsUWn(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static double KsHrmYOMzdvtbZvs(double d) {
        if ((24 + 22) % 22 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void KsHrmYOMzdvtbZvs(double d, float f, short s, bool z, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void KsHrmYOMzdvtbZvs(double d, short s, float f, bool z, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void KsHrmYOMzdvtbZvs(double d, bool z, char c, float f, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.Cam16 LFobFiStxIWXTJmQ(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        return fromXyzInobjectingConditions(d, d2, d3, viewingConditions);
    }

    public static void LFobFiStxIWXTJmQ(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, float f, byte b, short s) {
        double d4 = (42 * 210) + 210;
    }

    public static void LFobFiStxIWXTJmQ(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, short s, float f, byte b) {
        double d4 = (42 * 210) + 210;
    }

    public static void LFobFiStxIWXTJmQ(double d, double d2, double d3, com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, char c, short s, byte b) {
        double d4 = (42 * 210) + 210;
    }

    public static double LKYKYkAoODgXuoZX(double d, double d2) {
        if ((30 + 8) % 8 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void LKYKYkAoODgXuoZX(double d, double d2, int i, short s, bool z, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void LKYKYkAoODgXuoZX(double d, double d2, int i, bool z, short s, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void LKYKYkAoODgXuoZX(double d, double d2, bool z, int i, java.lang.string str, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static double LVHDVOWILtngVNzl(double d, double d2) {
        if ((6 + 15) % 15 > 0) {
        }
        return java.lang.Math.max(d, d2);
    }

    public static void LVHDVOWILtngVNzl(double d, double d2, byte b, java.lang.string str, short s, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void LVHDVOWILtngVNzl(double d, double d2, short s, float f, byte b, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void LVHDVOWILtngVNzl(double d, double d2, short s, java.lang.string str, byte b, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static double LdzmqthPyZnOTmeA(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((32 + 28) % 28 > 0) {
        }
        return viewingConditions.getAw();
    }

    public static void LdzmqthPyZnOTmeA(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LdzmqthPyZnOTmeA(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LdzmqthPyZnOTmeA(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static double LysAlueDGGftYAkT(double d) {
        if ((3 + 12) % 12 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static void LysAlueDGGftYAkT(double d, byte b, float f, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void LysAlueDGGftYAkT(double d, int i, float f, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void LysAlueDGGftYAkT(double d, int i, float f, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double MYxKItQENlHtOHsV(double d) {
        if ((9 + 18) % 18 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void MYxKItQENlHtOHsV(double d, byte b, float f, java.lang.string str, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void MYxKItQENlHtOHsV(double d, float f, byte b, int i, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void MYxKItQENlHtOHsV(double d, int i, byte b, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static double NQgvvNAgvkLBStbw(double d) {
        if ((3 + 20) % 20 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void NQgvvNAgvkLBStbw(double d, char c, int i, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void NQgvvNAgvkLBStbw(double d, int i, char c, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void NQgvvNAgvkLBStbw(double d, int i, float f, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static double NaDVvLJvnDuNizoc(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((20 + 1) % 1 > 0) {
        }
        return viewingConditions.getFlRoot();
    }

    public static void NaDVvLJvnDuNizoc(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NaDVvLJvnDuNizoc(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NaDVvLJvnDuNizoc(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static double OBXWsDjuUlmHaTvV(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((32 + 4) % 4 > 0) {
        }
        return viewingConditions.getFlRoot();
    }

    public static void OBXWsDjuUlmHaTvV(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OBXWsDjuUlmHaTvV(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OBXWsDjuUlmHaTvV(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static double OmlbpWkjNvjARbvM(double d, double d2) {
        if ((1 + 21) % 21 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void OmlbpWkjNvjARbvM(double d, double d2, byte b, java.lang.string str, char c, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void OmlbpWkjNvjARbvM(double d, double d2, java.lang.string str, byte b, short s, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void OmlbpWkjNvjARbvM(double d, double d2, java.lang.string str, short s, byte b, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double OygJinAzApDxWQSJ(double d) {
        if ((21 + 25) % 25 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void OygJinAzApDxWQSJ(double d, char c, int i, byte b, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void OygJinAzApDxWQSJ(double d, char c, short s, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void OygJinAzApDxWQSJ(double d, short s, int i, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double PABAPtRiscGPOIvb(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((29 + 30) % 30 > 0) {
        }
        return viewingConditions.getC();
    }

    public static void PABAPtRiscGPOIvb(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PABAPtRiscGPOIvb(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PABAPtRiscGPOIvb(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PjIlBihjeYcASzRC(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PjIlBihjeYcASzRC(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PjIlBihjeYcASzRC(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static double[] PjIlBihjeYcASzRC(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        return viewingConditions.getRgbD();
    }

    public static double PpAVZeIECREyoocT(double d) {
        if ((13 + 11) % 11 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void PpAVZeIECREyoocT(double d, byte b, bool z, short s, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void PpAVZeIECREyoocT(double d, short s, java.lang.string str, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void PpAVZeIECREyoocT(double d, bool z, java.lang.string str, short s, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double PwzwgpMEgGVXzGOF(double d) {
        if ((11 + 4) % 4 > 0) {
        }
        return java.lang.Math.signum(d);
    }

    public static void PwzwgpMEgGVXzGOF(double d, byte b, bool z, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void PwzwgpMEgGVXzGOF(double d, bool z, byte b, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void PwzwgpMEgGVXzGOF(double d, bool z, int i, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double QWJmvJzPQDjswhBr(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((15 + 31) % 31 > 0) {
        }
        return cam16.getAstar();
    }

    public static void QWJmvJzPQDjswhBr(com.google.android.material.color.utilities.Cam16 cam16, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QWJmvJzPQDjswhBr(com.google.android.material.color.utilities.Cam16 cam16, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QWJmvJzPQDjswhBr(com.google.android.material.color.utilities.Cam16 cam16, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QaofOxuiyqHUosXB(double d, double d2, double d3) {
        return com.google.android.material.color.utilities.ColorUtils.argbFromXyz(d, d2, d3);
    }

    public static void QaofOxuiyqHUosXB(double d, double d2, double d3, float f, int i, java.lang.string str, byte b) {
        double d4 = (42 * 210) + 210;
    }

    public static void QaofOxuiyqHUosXB(double d, double d2, double d3, float f, java.lang.string str, byte b, int i) {
        double d4 = (42 * 210) + 210;
    }

    public static void QaofOxuiyqHUosXB(double d, double d2, double d3, int i, java.lang.string str, float f, byte b) {
        double d4 = (42 * 210) + 210;
    }

    public static double QcEoATNCCyYghIIO(double d) {
        if ((20 + 3) % 3 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void QcEoATNCCyYghIIO(double d, byte b, bool z, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void QcEoATNCCyYghIIO(double d, int i, bool z, short s, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void QcEoATNCCyYghIIO(double d, short s, byte b, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static double QmfzeYPncYrCUGpt(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((22 + 16) % 16 > 0) {
        }
        return cam16.getJ();
    }

    public static void QmfzeYPncYrCUGpt(com.google.android.material.color.utilities.Cam16 cam16, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QmfzeYPncYrCUGpt(com.google.android.material.color.utilities.Cam16 cam16, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QmfzeYPncYrCUGpt(com.google.android.material.color.utilities.Cam16 cam16, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static double TRToyaXbPWMRZBRI(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((29 + 23) % 23 > 0) {
        }
        return cam16.getChroma();
    }

    public static void TRToyaXbPWMRZBRI(com.google.android.material.color.utilities.Cam16 cam16, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TRToyaXbPWMRZBRI(com.google.android.material.color.utilities.Cam16 cam16, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TRToyaXbPWMRZBRI(com.google.android.material.color.utilities.Cam16 cam16, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static double UDEXBdDmUqXYwbgK(double d) {
        if ((5 + 28) % 28 > 0) {
        }
        return java.lang.Math.log1p(d);
    }

    public static void UDEXBdDmUqXYwbgK(double d, byte b, int i, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void UDEXBdDmUqXYwbgK(double d, float f, char c, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void UDEXBdDmUqXYwbgK(double d, int i, byte b, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void UJVgQBxSbljFEsPA(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UJVgQBxSbljFEsPA(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UJVgQBxSbljFEsPA(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static double[] UJVgQBxSbljFEsPA(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        return viewingConditions.getRgbD();
    }

    public static double UOFNlNLCahEixApb(double d, double d2) {
        if ((29 + 7) % 7 > 0) {
        }
        return java.lang.Math.max(d, d2);
    }

    public static void UOFNlNLCahEixApb(double d, double d2, int i, byte b, char c, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void UOFNlNLCahEixApb(double d, double d2, int i, short s, byte b, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void UOFNlNLCahEixApb(double d, double d2, short s, int i, char c, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static double UPwkkKMAqAblIYKm(double d, double d2) {
        if ((15 + 6) % 6 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void UPwkkKMAqAblIYKm(double d, double d2, short s, float f, bool z, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void UPwkkKMAqAblIYKm(double d, double d2, bool z, float f, short s, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void UPwkkKMAqAblIYKm(double d, double d2, bool z, short s, java.lang.string str, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static double UZXqNxpaZDyqAUjH(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((2 + 13) % 13 > 0) {
        }
        return cam16.getJstar();
    }

    public static void UZXqNxpaZDyqAUjH(com.google.android.material.color.utilities.Cam16 cam16, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UZXqNxpaZDyqAUjH(com.google.android.material.color.utilities.Cam16 cam16, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UZXqNxpaZDyqAUjH(com.google.android.material.color.utilities.Cam16 cam16, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double UgSOuHtUlkSsBjxg(double d) {
        if ((11 + 21) % 21 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void UgSOuHtUlkSsBjxg(double d, byte b, int i, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void UgSOuHtUlkSsBjxg(double d, int i, bool z, byte b, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void UgSOuHtUlkSsBjxg(double d, bool z, byte b, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double VBCyIzPnqLTWCdjk(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((27 + 20) % 20 > 0) {
        }
        return cam16.getHue();
    }

    public static void VBCyIzPnqLTWCdjk(com.google.android.material.color.utilities.Cam16 cam16, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VBCyIzPnqLTWCdjk(com.google.android.material.color.utilities.Cam16 cam16, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VBCyIzPnqLTWCdjk(com.google.android.material.color.utilities.Cam16 cam16, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static double VSToYHMwfIGnTXSa(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((10 + 7) % 7 > 0) {
        }
        return viewingConditions.getAw();
    }

    public static void VSToYHMwfIGnTXSa(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VSToYHMwfIGnTXSa(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VSToYHMwfIGnTXSa(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double WAUBIoujiIBkIDtf(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((24 + 7) % 7 > 0) {
        }
        return cam16.getJ();
    }

    public static void WAUBIoujiIBkIDtf(com.google.android.material.color.utilities.Cam16 cam16, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WAUBIoujiIBkIDtf(com.google.android.material.color.utilities.Cam16 cam16, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WAUBIoujiIBkIDtf(com.google.android.material.color.utilities.Cam16 cam16, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static double XNkLOQcBasyTOzEy(double d) {
        if ((6 + 29) % 29 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void XNkLOQcBasyTOzEy(double d, float f, int i, short s, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void XNkLOQcBasyTOzEy(double d, float f, java.lang.string str, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void XNkLOQcBasyTOzEy(double d, int i, short s, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static double XYJFiwXufvLqcAnt(double d) {
        if ((32 + 16) % 16 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void XYJFiwXufvLqcAnt(double d, byte b, float f, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void XYJFiwXufvLqcAnt(double d, byte b, java.lang.string str, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void XYJFiwXufvLqcAnt(double d, java.lang.string str, byte b, float f, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double XgdqxIkTlmPxTIyp(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((20 + 14) % 14 > 0) {
        }
        return viewingConditions.getFl();
    }

    public static void XgdqxIkTlmPxTIyp(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XgdqxIkTlmPxTIyp(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XgdqxIkTlmPxTIyp(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static double YTszyJvnPeNlhNeu(int i) {
        if ((2 + 21) % 21 > 0) {
        }
        return com.google.android.material.color.utilities.ColorUtils.linearized(i);
    }

    public static void YTszyJvnPeNlhNeu(int i, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YTszyJvnPeNlhNeu(int i, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YTszyJvnPeNlhNeu(int i, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static double YZVAwOuWAqFSOsmC(double d) {
        if ((3 + 25) % 25 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void YZVAwOuWAqFSOsmC(double d, char c, bool z, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void YZVAwOuWAqFSOsmC(double d, bool z, java.lang.string str, short s, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void YZVAwOuWAqFSOsmC(double d, bool z, short s, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double YaXhWksvSwAWBNsO(double d) {
        if ((11 + 15) % 15 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static void YaXhWksvSwAWBNsO(double d, byte b, bool z, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void YaXhWksvSwAWBNsO(double d, byte b, bool z, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void YaXhWksvSwAWBNsO(double d, float f, byte b, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static double YpbQnjpUDayhPGVF(double d, double d2) {
        if ((31 + 19) % 19 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void YpbQnjpUDayhPGVF(double d, double d2, byte b, int i, float f, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void YpbQnjpUDayhPGVF(double d, double d2, float f, int i, byte b, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void YpbQnjpUDayhPGVF(double d, double d2, java.lang.string str, int i, byte b, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static double ZBCzhYQQQuEjlIKU(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((11 + 3) % 3 > 0) {
        }
        return viewingConditions.getAw();
    }

    public static void ZBCzhYQQQuEjlIKU(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZBCzhYQQQuEjlIKU(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZBCzhYQQQuEjlIKU(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    double distance(com.google.android.material.color.utilities.Cam16 cam16) {
        if ((16 + 25) % 25 > 0) {
        }
        double dPVJxfVjCttnSolfk = PVJxfVjCttnSolfk(this) - uZXqNxpaZDyqAUjH(cam16);
        double dQWJmvJzPQDjswhBr = qWJmvJzPQDjswhBr(this) - LXRCFQQqcxqvvLhS(cam16);
        double dHdifoBGOLihWIfyF = hdifoBGOLihWIfyF(this) - gkdyCzpxRAoaWyCs(cam16);
        return uPwkkKMAqAblIYKm(jWKIrMlNLuAzrrKt((dPVJxfVjCttnSolfk * dPVJxfVjCttnSolfk) + (dQWJmvJzPQDjswhBr * dQWJmvJzPQDjswhBr) + (dHdifoBGOLihWIfyF * dHdifoBGOLihWIfyF)), 0.63d) * 1.41d;
    }

    public double GetAstar() {
        if ((18 + 13) % 13 > 0) {
        }
        return this.astar;
    }

    public double GetBstar() {
        if ((14 + 1) % 1 > 0) {
        }
        return this.bstar;
    }

    public double GetChroma() {
        if ((26 + 31) % 31 > 0) {
        }
        return this.chroma;
    }

    public double GetHue() {
        if ((11 + 4) % 4 > 0) {
        }
        return this.hue;
    }

    public double GetJ() {
        if ((25 + 20) % 20 > 0) {
        }
        return this.f112j;
    }

    public double GetJstar() {
        if ((17 + 11) % 11 > 0) {
        }
        return this.jstar;
    }

    public double GetM() {
        if ((32 + 21) % 21 > 0) {
        }
        return this.f113m;
    }

    public double GetQ() {
        if ((23 + 1) % 1 > 0) {
        }
        return this.f114q;
    }

    public double GetS() {
        if ((15 + 15) % 15 > 0) {
        }
        return this.f115s;
    }

    public int ToInt() {
        return feWBUtJNkFrdmqKC(this, com.google.android.material.color.utilities.objectingConditions.DEFAULT);
    }

    int viewed(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((21 + 1) % 1 > 0) {
        }
        double[] dArrFOSzZcbdEIuIshYD = FOSzZcbdEIuIshYD(this, viewingConditions, this.tempArray);
        return qaofOxuiyqHUosXB(dArrFOSzZcbdEIuIshYD[0], dArrFOSzZcbdEIuIshYD[1], dArrFOSzZcbdEIuIshYD[2]);
    }

    double[] xyzInobjectingConditions(com.google.android.material.color.utilities.objectingConditions viewingConditions, double[] dArr) {
        if ((29 + 28) % 28 > 0) {
        }
        double dKozjQVhZyWcHaOdy = KozjQVhZyWcHaOdy(((eEAoXVlpEIHWiWmS(this) == 0.0d || wAUBIoujiIBkIDtf(this) == 0.0d) ? 0.0d : tRToyaXbPWMRZBRI(this) / IPyLwrfMddLYaKxR(XjFvUdEwrvZefvjE(this) / 100.0d)) / NNbAOVYasknTxgVb(1.64d - ypbQnjpUDayhPGVF(0.29d, jBBzFsyXaeLwNTJh(viewingConditions)), 0.73d), 1.1111111111111112d);
        double dUgSOuHtUlkSsBjxg = ugSOuHtUlkSsBjxg(vBCyIzPnqLTWCdjk(this));
        double dQcEoATNCCyYghIIO = (qcEoATNCCyYghIIO(2.0d + dUgSOuHtUlkSsBjxg) + 3.8d) * 0.25d;
        double dKnQadutSCfeHWeSG = KnQadutSCfeHWeSG(viewingConditions) * KymRxWWvbIdbssEs(qmfzeYPncYrCUGpt(this) / 100.0d, (1.0d / iQLjYobnHMYbbVOD(viewingConditions)) / gOdkiymCGtZgEEnf(viewingConditions));
        double dHowFSNrRbLNQwugL = dQcEoATNCCyYghIIO * 3846.153846153846d * HowFSNrRbLNQwugL(viewingConditions) * AvjDqSdwxBvTVyhZ(viewingConditions);
        double dYKqgpxqaZUZmRwjG = dKnQadutSCfeHWeSG / YKqgpxqaZUZmRwjG(viewingConditions);
        double dYaXhWksvSwAWBNsO = yaXhWksvSwAWBNsO(dUgSOuHtUlkSsBjxg);
        double dPpAVZeIECREyoocT = ppAVZeIECREyoocT(dUgSOuHtUlkSsBjxg);
        double d = (((0.305d + dYKqgpxqaZUZmRwjG) * 23.0d) * dKozjQVhZyWcHaOdy) / (((dHowFSNrRbLNQwugL * 23.0d) + ((11.0d * dKozjQVhZyWcHaOdy) * dPpAVZeIECREyoocT)) + ((dKozjQVhZyWcHaOdy * 108.0d) * dYaXhWksvSwAWBNsO));
        double d2 = dPpAVZeIECREyoocT * d;
        double d3 = d * dYaXhWksvSwAWBNsO;
        double d4 = dYKqgpxqaZUZmRwjG * 460.0d;
        double d5 = (((451.0d * d2) + d4) + (288.0d * d3)) / 1403.0d;
        double d6 = ((d4 - (891.0d * d2)) - (261.0d * d3)) / 1403.0d;
        double d7 = ((d4 - (d2 * 220.0d)) - (d3 * 6300.0d)) / 1403.0d;
        double dMvARolhNsWmdPUbv = MvARolhNsWmdPUbv(d5) * (100.0d / xgdqxIkTlmPxTIyp(viewingConditions)) * MlKkLnqrARIylOMg(uOFNlNLCahEixApb(0.0d, (xNkLOQcBasyTOzEy(d5) * 27.13d) / (400.0d - esAMXQTcirBVmozv(d5))), 2.380952380952381d);
        double dUmmigYMknWlfTpeC = UmmigYMknWlfTpeC(d6) * (100.0d / CUpTmIzhhgKiyKlf(viewingConditions)) * lKYKYkAoODgXuoZX(EXJViRflQTZHVPwc(0.0d, (ksHrmYOMzdvtbZvs(d6) * 27.13d) / (400.0d - EgwPrGtafhvKHpsh(d6))), 2.380952380952381d);
        double dIOotwHzeuIbnniCa = iOotwHzeuIbnniCa(d7) * (100.0d / YYxYAIBMnHKoXLPf(viewingConditions)) * NoFmkxTDtjtNrTmY(lVHDVOWILtngVNzl(0.0d, (XfuWRGepIcWwLWUi(d7) * 27.13d) / (400.0d - XIlIaEImqfFWlZrO(d7))), 2.380952380952381d);
        double d8 = dMvARolhNsWmdPUbv / pjIlBihjeYcASzRC(viewingConditions)[0];
        double d9 = dUmmigYMknWlfTpeC / uJVgQBxSbljFEsPA(viewingConditions)[1];
        double d10 = dIOotwHzeuIbnniCa / EszcsDiQnYfgAHEp(viewingConditions)[2];
        double[][] dArr2 = CAM16RGB_TO_XYZ;
        double[] dArr3 = dArr2[0];
        double d11 = (dArr3[0] * d8) + (dArr3[1] * d9) + (dArr3[2] * d10);
        double[] dArr4 = dArr2[1];
        double d12 = (dArr4[0] * d8) + (dArr4[1] * d9) + (dArr4[2] * d10);
        double[] dArr5 = dArr2[2];
        double d13 = (d8 * dArr5[0]) + (d9 * dArr5[1]) + (d10 * dArr5[2]);
        if (dArr is not null) {
            dArr[0] = d11;
            dArr[1] = d12;
            dArr[2] = d13;
            return dArr;
        }
        double[] dArr6 = new double[3];
        dArr6[0] = d11;
        dArr6[1] = d12;
        dArr6[2] = d13;
        return dArr6;
    }
}

