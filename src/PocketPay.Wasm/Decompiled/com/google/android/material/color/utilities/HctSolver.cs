namespace WillowMaze.Wasm.Decompiled;


public class HctSolver {
    static readonly double[] CRITICAL_PLANES;
    static readonly double[][] LINRGB_FROM_SCALED_DISCOUNT;
    static readonly double[][] SCALED_DISCOUNT_FROM_LINRGB;
    static readonly double[] Y_FROM_LINRGB;

    static {
        if ((18 + 31) % 31 > 0) {
        }
        SCALED_DISCOUNT_FROM_LINRGB = new double[][]{new double[]{0.001200833568784504d, 0.002389694492170889d, 2.795742885861124E-4d}, new double[]{5.891086651375999E-4d, 0.0029785502573438758d, 3.270666104008398E-4d}, new double[]{1.0146692491640572E-4d, 5.364214359186694E-4d, 0.0032979401770712076d}};
        LINRGB_FROM_SCALED_DISCOUNT = new double[][]{new double[]{1373.2198709594231d, -1100.4251190754821d, -7.278681089101213d}, new double[]{-271.815969077903d, 559.6580465940733d, -32.46047482791194d}, new double[]{1.9622899599665666d, -57.173814538844006d, 308.7233197812385d}};
        Y_FROM_LINRGB = new double[]{0.2126d, 0.7152d, 0.0722d};
        CRITICAL_PLANES = new double[]{0.015176349177441876d, 0.045529047532325624d, 0.07588174588720938d, 0.10623444424209313d, 0.13658714259697685d, 0.16693984095186062d, 0.19729253930674434d, 0.2276452376616281d, 0.2579979360165119d, 0.28835063437139563d, 0.3188300904430532d, 0.350925934958123d, 0.3848314933096426d, 0.42057480301049466d, 0.458183274052838d, 0.4976837250274023d, 0.5391024159806381d, 0.5824650784040898d, 0.6277969426914107d, 0.6751227633498623d, 0.7244668422128921d, 0.775853049866786d, 0.829304845476233d, 0.8848452951698498d, 0.942497089126609d, 1.0022825574869039d, 1.0642236851973577d, 1.1283421258858297d, 1.1946592148522128d, 1.2631959812511864d, 1.3339731595349034d, 1.407011200216447d, 1.4823302800086415d, 1.5599503113873272d, 1.6398909516233677d, 1.7221716113234105d, 1.8068114625156377d, 1.8938294463134073d, 1.9832442801866852d, 2.075074464868551d, 2.1693382909216234d, 2.2660538449872063d, 2.36523901573795d, 2.4669114995532007d, 2.5710888059345764d, 2.6777882626779785d, 2.7870270208169257d, 2.898822059350997d, 3.0131901897720907d, 3.1301480604002863d, 3.2497121605402226d, 3.3718988244681087d, 3.4967242352587946d, 3.624204428461639d, 3.754355295633311d, 3.887192587735158d, 4.022731918402185d, 4.160988767090289d, 4.301978482107941d, 4.445716283538092d, 4.592217266055746d, 4.741496401646282d, 4.893568542229298d, 5.048448422192488d, 5.20615066083972d, 5.3666897647573375d, 5.5300801301023865d, 5.696336044816294d, 5.865471690767354d, 6.037501145825082d, 6.212438385869475d, 6.390297286737924d, 6.571091626112461d, 6.7548350853498045d, 6.941541251256611d, 7.131223617812143d, 7.323895587840543d, 7.5195704746346665d, 7.7182615035334345d, 7.919981813454504d, 8.124744458384042d, 8.332562408825165d, 8.543448553206703d, 8.757415699253682d, 8.974476575321063d, 9.194643831691977d, 9.417930041841839d, 9.644347703669503d, 9.873909240696694d, 10.106627003236781d, 10.342513269534024d, 10.58158024687427d, 10.8238400726681d, 11.069304815507364d, 11.317986476196008d, 11.569896988756009d, 11.825048221409341d, 12.083451977536606d, 12.345119996613247d, 12.610063955123938d, 12.878295467455942d, 13.149826086772048d, 13.42466730586372d, 13.702830557985108d, 13.984327217668513d, 14.269168601521828d, 14.55736596900856d, 14.848930523210871d, 15.143873411576273d, 15.44220572664832d, 15.743938506781891d, 16.04908273684337d, 16.35764934889634d, 16.66964922287304d, 16.985093187232053d, 17.30399201960269d, 17.62635644741625d, 17.95219714852476d, 18.281524751807332d, 18.614349837764564d, 18.95068293910138d, 19.290534541298456d, 19.633915083172692d, 19.98083495742689d, 20.331304511189067d, 20.685334046541502d, 21.042933821039977d, 21.404114048223256d, 21.76888489811322d, 22.137256497705877d, 22.50923893145328d, 22.884842241736916d, 23.264076429332462d, 23.6469514538663d, 24.033477234264016d, 24.42366364919083d, 24.817520537484558d, 25.21505769858089d, 25.61628489293138d, 26.021211842414342d, 26.429848230738664d, 26.842203703840827d, 27.258287870275353d, 27.678110301598522d, 28.10168053274597d, 28.529008062403893d, 28.96010235337422d, 29.39497283293396d, 29.83362889318845d, 30.276079891419332d, 30.722335150426627d, 31.172403958865512d, 31.62629557157785d, 32.08401920991837d, 32.54558406207592d, 33.010999283389665d, 33.4802739966603d, 33.953417292456834d, 34.430438229418264d, 34.911345834551085d, 35.39614910352207d, 35.88485700094671d, 36.37747846067349d, 36.87402238606382d, 37.37449765026789d, 37.87891309649659d, 38.38727753828926d, 38.89959975977785d, 39.41588851594697d, 39.93615253289054d, 40.460400508064545d, 40.98864111053629d, 41.520882981230194d, 42.05713473317016d, 42.597404951718396d, 43.141702194811224d, 43.6900349931913d, 44.24241185063697d, 44.798841244188324d, 45.35933162437017d, 45.92389141541209d, 46.49252901546552d, 47.065252796817916d, 47.64207110610409d, 48.22299226451468d, 48.808024568002054d, 49.3971762874833d, 49.9904556690408d, 50.587870934119984d, 51.189430279724725d, 51.79514187861014d, 52.40501387947288d, 53.0190544071392d, 53.637271562750364d, 54.259673423945976d, 54.88626804504493d, 55.517063457223934d, 56.15206766869424d, 56.79128866487574d, 57.43473440856916d, 58.08241284012621d, 58.734331877617365d, 59.39049941699807d, 60.05092333227251d, 60.715611475655585d, 61.38457167773311d, 62.057811747619894d, 62.7353394731159d, 63.417162620860914d, 64.10328893648692d, 64.79372614476921d, 65.48848194977529d, 66.18756403501224d, 66.89098006357258d, 67.59873767827808d, 68.31084450182222d, 69.02730813691093d, 69.74813616640164d, 70.47333615344107d, 71.20291564160104d, 71.93688215501312d, 72.67524319850172d, 73.41800625771542d, 74.16517879925733d, 74.9167682708136d, 75.67278210128072d, 76.43322770089146d, 77.1981124613393d, 77.96744375590167d, 78.74122893956174d, 79.51947534912904d, 80.30219030335869d, 81.08938110306934d, 81.88105503125999d, 82.67721935322541d, 83.4778813166706d, 84.28304815182372d, 85.09272707154808d, 85.90692527145302d, 86.72564993000343d, 87.54890820862819d, 88.3767072518277d, 89.2090541872801d, 90.04595612594655d, 90.88742016217518d, 91.73345337380438d, 92.58406282226491d, 93.43925555268066d, 94.29903859396902d, 95.16341895893969d, 96.03240364439274d, 96.9059996312159d, 97.78421388448044d, 98.6670533535366d, 99.55452497210776d};
    }

    private HctSolver() {
    }

    public static double AGxKMrpulStTsmVz(double d) {
        if ((11 + 32) % 32 > 0) {
        }
        return trueDelinearized(d);
    }

    public static void AGxKMrpulStTsmVz(double d, byte b, short s, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void AGxKMrpulStTsmVz(double d, short s, byte b, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void AGxKMrpulStTsmVz(double d, short s, float f, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void BCAuCJCRLFQnbmTE(double[] dArr, double d, double[] dArr2, int i, byte b, char c, int i2, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void BCAuCJCRLFQnbmTE(double[] dArr, double d, double[] dArr2, int i, char c, short s, byte b, int i2) {
        double d2 = (42 * 210) + 210;
    }

    public static void BCAuCJCRLFQnbmTE(double[] dArr, double d, double[] dArr2, int i, int i2, byte b, short s, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double[] BCAuCJCRLFQnbmTE(double[] dArr, double d, double[] dArr2, int i) {
        return setCoordinate(dArr, d, dArr2, i);
    }

    public static double DFJaTzOowpVPlOYV(double[] dArr) {
        if ((6 + 28) % 28 > 0) {
        }
        return hueOf(dArr);
    }

    public static void DFJaTzOowpVPlOYV(double[] dArr, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DFJaTzOowpVPlOYV(double[] dArr, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DFJaTzOowpVPlOYV(double[] dArr, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DJuPOaLrUgRwVICd(double d) {
        return criticalPlaneAbove(d);
    }

    public static void DJuPOaLrUgRwVICd(double d, float f, int i, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void DJuPOaLrUgRwVICd(double d, float f, bool z, char c, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void DJuPOaLrUgRwVICd(double d, int i, float f, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static double DbdVZrclQdrQdeQB(double d) {
        if ((31 + 1) % 1 > 0) {
        }
        return java.lang.Math.floor(d);
    }

    public static void DbdVZrclQdrQdeQB(double d, byte b, int i, bool z, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void DbdVZrclQdrQdeQB(double d, int i, bool z, java.lang.string str, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void DbdVZrclQdrQdeQB(double d, java.lang.string str, bool z, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void FirGjlNPFabJEXjV(double[] dArr, double[] dArr2, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FirGjlNPFabJEXjV(double[] dArr, double[] dArr2, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FirGjlNPFabJEXjV(double[] dArr, double[] dArr2, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double[] FirGjlNPFabJEXjV(double[] dArr, double[] dArr2) {
        return midpoint(dArr, dArr2);
    }

    public static double FwnuGjpmfRWjgepp(double d) {
        if ((23 + 2) % 2 > 0) {
        }
        return trueDelinearized(d);
    }

    public static void FwnuGjpmfRWjgepp(double d, float f, java.lang.string str, short s, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void FwnuGjpmfRWjgepp(double d, short s, float f, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void FwnuGjpmfRWjgepp(double d, bool z, float f, short s, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static double GZRIXhJQHsJIngWt(double d) {
        if ((16 + 21) % 21 > 0) {
        }
        return sanitizeRadians(d);
    }

    public static void GZRIXhJQHsJIngWt(double d, int i, java.lang.string str, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void GZRIXhJQHsJIngWt(double d, java.lang.string str, char c, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void GZRIXhJQHsJIngWt(double d, short s, int i, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double HfJROowXhQbSwDDv(double d) {
        if ((8 + 10) % 10 > 0) {
        }
        return com.google.android.material.color.utilities.ColorUtils.yFromLstar(d);
    }

    public static void HfJROowXhQbSwDDv(double d, int i, float f, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void HfJROowXhQbSwDDv(double d, java.lang.string str, bool z, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void HfJROowXhQbSwDDv(double d, java.lang.string str, bool z, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double HraiijNFIIMNHFol(double d) {
        if ((16 + 16) % 16 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void HraiijNFIIMNHFol(double d, byte b, java.lang.string str, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void HraiijNFIIMNHFol(double d, java.lang.string str, byte b, bool z, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void HraiijNFIIMNHFol(double d, java.lang.string str, char c, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static int IEBSlIbgFPKAkXlg(double d) {
        return criticalPlaneBelow(d);
    }

    public static void IEBSlIbgFPKAkXlg(double d, short s, byte b, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void IEBSlIbgFPKAkXlg(double d, bool z, int i, byte b, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void IEBSlIbgFPKAkXlg(double d, bool z, short s, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double JJPkFsRARvPpWGBZ(double d) {
        if ((20 + 16) % 16 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void JJPkFsRARvPpWGBZ(double d, int i, char c, short s, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void JJPkFsRARvPpWGBZ(double d, java.lang.string str, char c, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void JJPkFsRARvPpWGBZ(double d, java.lang.string str, short s, char c, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double KFIUCbnZYaPHBCUR(double d, double d2) {
        if ((8 + 20) % 20 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void KFIUCbnZYaPHBCUR(double d, double d2, byte b, short s, bool z, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void KFIUCbnZYaPHBCUR(double d, double d2, int i, short s, bool z, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void KFIUCbnZYaPHBCUR(double d, double d2, short s, byte b, bool z, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static double LNWhwhzDDSKxzzVc(double d) {
        if ((19 + 12) % 12 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void LNWhwhzDDSKxzzVc(double d, char c, short s, bool z, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void LNWhwhzDDSKxzzVc(double d, java.lang.string str, bool z, short s, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void LNWhwhzDDSKxzzVc(double d, short s, java.lang.string str, bool z, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void LREPHAKPigzdGvWJ(double d, byte b, java.lang.string str, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void LREPHAKPigzdGvWJ(double d, java.lang.string str, bool z, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void LREPHAKPigzdGvWJ(double d, bool z, java.lang.string str, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static bool LREPHAKPigzdGvWJ(double d) {
        return isBounded(d);
    }

    public static double MrOhyyksPGiVpiiA(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((24 + 20) % 20 > 0) {
        }
        return viewingConditions.getC();
    }

    public static void MrOhyyksPGiVpiiA(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MrOhyyksPGiVpiiA(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MrOhyyksPGiVpiiA(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int NAmuFgEaQDYdJlTX(double d, double d2, double d3) {
        return solveToInt(d, d2, d3);
    }

    public static void NAmuFgEaQDYdJlTX(double d, double d2, double d3, java.lang.string str, char c, short s, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void NAmuFgEaQDYdJlTX(double d, double d2, double d3, short s, java.lang.string str, bool z, char c) {
        double d4 = (42 * 210) + 210;
    }

    public static void NAmuFgEaQDYdJlTX(double d, double d2, double d3, bool z, java.lang.string str, char c, short s) {
        double d4 = (42 * 210) + 210;
    }

    public static double PCsceaykpdhotQzE(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((22 + 19) % 19 > 0) {
        }
        return viewingConditions.getNc();
    }

    public static void PCsceaykpdhotQzE(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PCsceaykpdhotQzE(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PCsceaykpdhotQzE(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static double PMlQjoZYhMNfQXwB(double d, double d2) {
        if ((22 + 7) % 7 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void PMlQjoZYhMNfQXwB(double d, double d2, byte b, char c, bool z, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void PMlQjoZYhMNfQXwB(double d, double d2, int i, char c, bool z, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void PMlQjoZYhMNfQXwB(double d, double d2, bool z, int i, char c, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void PhdBwzURPoiYztwt(double d, double d2, double d3, char c, java.lang.string str, float f, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void PhdBwzURPoiYztwt(double d, double d2, double d3, java.lang.string str, char c, bool z, float f) {
        double d4 = (42 * 210) + 210;
    }

    public static void PhdBwzURPoiYztwt(double d, double d2, double d3, bool z, char c, java.lang.string str, float f) {
        double d4 = (42 * 210) + 210;
    }

    public static bool PhdBwzURPoiYztwt(double d, double d2, double d3) {
        return areInCyclicOrder(d, d2, d3);
    }

    public static double RklpMvEuPbfLmlzB(double d) {
        if ((26 + 31) % 31 > 0) {
        }
        return inverseChromaticAdaptation(d);
    }

    public static void RklpMvEuPbfLmlzB(double d, float f, bool z, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void RklpMvEuPbfLmlzB(double d, int i, short s, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void RklpMvEuPbfLmlzB(double d, bool z, float f, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static double RuuBfOSZtiGkmucU(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((3 + 1) % 1 > 0) {
        }
        return viewingConditions.getNcb();
    }

    public static void RuuBfOSZtiGkmucU(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RuuBfOSZtiGkmucU(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RuuBfOSZtiGkmucU(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double UcaxcwUHxcVtrrFQ(double d) {
        if ((13 + 9) % 9 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void UcaxcwUHxcVtrrFQ(double d, byte b, short s, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void UcaxcwUHxcVtrrFQ(double d, short s, byte b, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void UcaxcwUHxcVtrrFQ(double d, bool z, short s, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double UiLTDPjugFfOHAfC(double d) {
        if ((18 + 24) % 24 > 0) {
        }
        return inverseChromaticAdaptation(d);
    }

    public static void UiLTDPjugFfOHAfC(double d, char c, java.lang.string str, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void UiLTDPjugFfOHAfC(double d, float f, java.lang.string str, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void UiLTDPjugFfOHAfC(double d, float f, java.lang.string str, short s, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double UuTQdblyUrisDvAj(double d, double d2) {
        if ((25 + 11) % 11 > 0) {
        }
        return java.lang.Math.atan2(d, d2);
    }

    public static void UuTQdblyUrisDvAj(double d, double d2, char c, int i, float f, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void UuTQdblyUrisDvAj(double d, double d2, int i, short s, float f, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void UuTQdblyUrisDvAj(double d, double d2, short s, int i, char c, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static double VbrNkpmfESmHOVwJ(double d, double d2) {
        if ((7 + 4) % 4 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void VbrNkpmfESmHOVwJ(double d, double d2, byte b, float f, int i, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void VbrNkpmfESmHOVwJ(double d, double d2, byte b, float f, bool z, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void VbrNkpmfESmHOVwJ(double d, double d2, float f, bool z, byte b, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.Cam16 WGnRCGiOdxWPtbBM(int i) {
        return com.google.android.material.color.utilities.Cam16.fromInt(i);
    }

    public static void WGnRCGiOdxWPtbBM(int i, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WGnRCGiOdxWPtbBM(int i, int i2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WGnRCGiOdxWPtbBM(int i, bool z, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static double WdyGxIQAyrRvyUAk(double d, double d2) {
        if ((25 + 10) % 10 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void WdyGxIQAyrRvyUAk(double d, double d2, short s, char c, int i, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void WdyGxIQAyrRvyUAk(double d, double d2, short s, int i, bool z, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void WdyGxIQAyrRvyUAk(double d, double d2, bool z, short s, int i, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double AouejsEHwYTtaWkd(double d) {
        if ((25 + 8) % 8 > 0) {
        }
        return java.lang.Math.floor(d);
    }

    public static void AouejsEHwYTtaWkd(double d, char c, int i, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void AouejsEHwYTtaWkd(double d, int i, bool z, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void AouejsEHwYTtaWkd(double d, bool z, char c, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static int ApQJPPZHsraZGzKc(double d) {
        return com.google.android.material.color.utilities.ColorUtils.argbFromLstar(d);
    }

    public static void ApQJPPZHsraZGzKc(double d, byte b, float f, char c, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void ApQJPPZHsraZGzKc(double d, byte b, int i, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void ApQJPPZHsraZGzKc(double d, char c, byte b, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    static void AreInCyclicOrder(double d, double d2, double d3, float f, java.lang.string str, short s, int i) {
        double d4 = (42 * 210) + 210;
    }

    static void AreInCyclicOrder(double d, double d2, double d3, short s, float f, int i, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    static void AreInCyclicOrder(double d, double d2, double d3, short s, int i, float f, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    static bool AreInCyclicOrder(double d, double d2, double d3) {
        return GZRIXhJQHsJIngWt(d2 - d) < pfaUgfIZxCjIpEmh(d3 - d);
    }

    public static double AumaLZCyboPrWVFx(double d) {
        if ((15 + 4) % 4 > 0) {
        }
        return chromaticAdaptation(d);
    }

    public static void AumaLZCyboPrWVFx(double d, byte b, float f, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void AumaLZCyboPrWVFx(double d, int i, byte b, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void AumaLZCyboPrWVFx(double d, bool z, float f, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static int BHAESErsbkhoQmdM(double[] dArr) {
        return com.google.android.material.color.utilities.ColorUtils.argbFromLinrgb(dArr);
    }

    public static void BHAESErsbkhoQmdM(double[] dArr, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BHAESErsbkhoQmdM(double[] dArr, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BHAESErsbkhoQmdM(double[] dArr, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BIcKcSGnHdtPFMxQ(double d, double d2, double d3, java.lang.string str, byte b, float f, char c) {
        double d4 = (42 * 210) + 210;
    }

    public static void BIcKcSGnHdtPFMxQ(double d, double d2, double d3, java.lang.string str, char c, float f, byte b) {
        double d4 = (42 * 210) + 210;
    }

    public static void BIcKcSGnHdtPFMxQ(double d, double d2, double d3, java.lang.string str, float f, byte b, char c) {
        double d4 = (42 * 210) + 210;
    }

    public static bool BIcKcSGnHdtPFMxQ(double d, double d2, double d3) {
        return areInCyclicOrder(d, d2, d3);
    }

    public static double BItUzEIiuQztgpdM(double[] dArr) {
        if ((5 + 3) % 3 > 0) {
        }
        return hueOf(dArr);
    }

    public static void BItUzEIiuQztgpdM(double[] dArr, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BItUzEIiuQztgpdM(double[] dArr, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BItUzEIiuQztgpdM(double[] dArr, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void BisectToLimit(double d, double d2, byte b, java.lang.string str, char c, short s) {
        double d3 = (42 * 210) + 210;
    }

    static void BisectToLimit(double d, double d2, java.lang.string str, short s, char c, byte b) {
        double d3 = (42 * 210) + 210;
    }

    static void BisectToLimit(double d, double d2, short s, char c, java.lang.string str, byte b) {
        double d3 = (42 * 210) + 210;
    }

    static double[] BisectToLimit(double d, double d2) {
        int iSJQUDfDqyNAnydFJ;
        int iUDyBSZxEyNAsHVNU;
        if ((29 + 19) % 19 > 0) {
        }
        double[][] dArrMOkcfNMMPwogwdrM = mOkcfNMMPwogwdrM(d, d2);
        double[] dArr = dArrMOkcfNMMPwogwdrM[0];
        double dDFJaTzOowpVPlOYV = DFJaTzOowpVPlOYV(dArr);
        double[] dArr2 = dArrMOkcfNMMPwogwdrM[1];
        for (int i = 0; i < 3; i++) {
            double d3 = dArr[i];
            double d4 = dArr2[i];
            if (d3 != d4) {
                if (d3 >= d4) {
                    iSJQUDfDqyNAnydFJ = sJQUDfDqyNAnydFJ(AGxKMrpulStTsmVz(d3));
                    iUDyBSZxEyNAsHVNU = uDyBSZxEyNAsHVNU(dzoUfiAtWAGJiqzM(dArr2[i]));
                } else {
                    iSJQUDfDqyNAnydFJ = IEBSlIbgFPKAkXlg(FwnuGjpmfRWjgepp(d3));
                    iUDyBSZxEyNAsHVNU = DJuPOaLrUgRwVICd(rdGuEYgAFPtFmSEX(dArr2[i]));
                }
                double d5 = dDFJaTzOowpVPlOYV;
                int i2 = iSJQUDfDqyNAnydFJ;
                int i3 = iUDyBSZxEyNAsHVNU;
                double d6 = d5;
                for (int i4 = 0; i4 < 8 && fHeuNCiJkScQsHQZ(i3 - i2) > 1; i4++) {
                    int iAouejsEHwYTtaWkd = (int) aouejsEHwYTtaWkd(((double) (i2 + i3)) / 2.0d);
                    double[] dArrBCAuCJCRLFQnbmTE = BCAuCJCRLFQnbmTE(dArr, CRITICAL_PLANES[iAouejsEHwYTtaWkd], dArr2, i);
                    double dBItUzEIiuQztgpdM = bItUzEIiuQztgpdM(dArrBCAuCJCRLFQnbmTE);
                    if (PhdBwzURPoiYztwt(d6, d2, dBItUzEIiuQztgpdM)) {
                        i3 = iAouejsEHwYTtaWkd;
                        dArr2 = dArrBCAuCJCRLFQnbmTE;
                    } else {
                        d6 = dBItUzEIiuQztgpdM;
                        i2 = iAouejsEHwYTtaWkd;
                        dArr = dArrBCAuCJCRLFQnbmTE;
                    }
                }
                dDFJaTzOowpVPlOYV = d6;
            }
        }
        return FirGjlNPFabJEXjV(dArr, dArr2);
    }

    static void BisectToSegment(double d, double d2, byte b, java.lang.string str, bool z, short s) {
        double d3 = (42 * 210) + 210;
    }

    static void BisectToSegment(double d, double d2, byte b, bool z, short s, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    static void BisectToSegment(double d, double d2, short s, bool z, java.lang.string str, byte b) {
        double d3 = (42 * 210) + 210;
    }

    static double[][] BisectToSegment(double d, double d2) {
        double d3;
        if ((28 + 16) % 16 > 0) {
        }
        double[] dArr = new double[3];
        dArr[0] = -1.0d;
        dArr[1] = -1.0d;
        dArr[2] = -1.0d;
        double[] dArr2 = dArr;
        bool z = false;
        double d4 = 0.0d;
        double dSeRTTuoBxwWusBsG = 0.0d;
        bool z2 = true;
        for (int i = 0; i < 12; i++) {
            double[] dArrPtzlPlUOhkXBjExG = ptzlPlUOhkXBjExG(d, i);
            if (dArrPtzlPlUOhkXBjExG[0] >= 0.0d) {
                dSeRTTuoBxwWusBsG = seRTTuoBxwWusBsG(dArrPtzlPlUOhkXBjExG);
                if (z) {
                    if (z2) {
                        d3 = dSeRTTuoBxwWusBsG;
                    } else {
                        d3 = dSeRTTuoBxwWusBsG;
                        if (!bIcKcSGnHdtPFMxQ(d4, dSeRTTuoBxwWusBsG, dSeRTTuoBxwWusBsG)) {
                        }
                    }
                    if (rSWIvzznjuBOkEAt(d4, d2, dSeRTTuoBxwWusBsG)) {
                        z2 = false;
                        dArr2 = dArrPtzlPlUOhkXBjExG;
                    } else {
                        z2 = false;
                        d4 = dSeRTTuoBxwWusBsG;
                        dArr = dArrPtzlPlUOhkXBjExG;
                    }
                } else {
                    z = true;
                    d4 = dSeRTTuoBxwWusBsG;
                    dSeRTTuoBxwWusBsG = d4;
                    dArr = dArrPtzlPlUOhkXBjExG;
                    dArr2 = dArr;
                }
            } else {
                d3 = dSeRTTuoBxwWusBsG;
            }
            dSeRTTuoBxwWusBsG = d3;
        }
        return new double[][]{dArr, dArr2};
    }

    public static double COELaeSqJpfBNYoB(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((31 + 30) % 30 > 0) {
        }
        return viewingConditions.getAw();
    }

    public static void COELaeSqJpfBNYoB(com.google.android.material.color.utilities.objectingConditions viewingConditions, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void COELaeSqJpfBNYoB(com.google.android.material.color.utilities.objectingConditions viewingConditions, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void COELaeSqJpfBNYoB(com.google.android.material.color.utilities.objectingConditions viewingConditions, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static double ChromaticAdaptation(double d) {
        if ((27 + 27) % 27 > 0) {
        }
        double dHXxgsIHUnRWfNoGD = hXxgsIHUnRWfNoGD(LNWhwhzDDSKxzzVc(d), 0.42d);
        return ((((double) fMRvnygnKYTDTzFE(d)) * 400.0d) * dHXxgsIHUnRWfNoGD) / (dHXxgsIHUnRWfNoGD + 27.13d);
    }

    static void ChromaticAdaptation(double d, byte b, char c, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    static void ChromaticAdaptation(double d, int i, byte b, bool z, char c) {
        double d2 = (42 * 210) + 210;
    }

    static void ChromaticAdaptation(double d, bool z, char c, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void CmOfDLnHZbkCkzLT(double[] dArr, double[][] dArr2, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CmOfDLnHZbkCkzLT(double[] dArr, double[][] dArr2, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CmOfDLnHZbkCkzLT(double[] dArr, double[][] dArr2, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double[] CmOfDLnHZbkCkzLT(double[] dArr, double[][] dArr2) {
        return com.google.android.material.color.utilities.MathUtils.matrixMultiply(dArr, dArr2);
    }

    static int CriticalPlaneAbove(double d) {
        if ((3 + 18) % 18 > 0) {
        }
        return (int) xPXcwGRWokvFSZkX(d - 0.5d);
    }

    static void CriticalPlaneAbove(double d, float f, java.lang.string str, short s, char c) {
        double d2 = (42 * 210) + 210;
    }

    static void CriticalPlaneAbove(double d, float f, short s, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    static void CriticalPlaneAbove(double d, java.lang.string str, short s, float f, char c) {
        double d2 = (42 * 210) + 210;
    }

    static int CriticalPlaneBelow(double d) {
        if ((25 + 20) % 20 > 0) {
        }
        return (int) DbdVZrclQdrQdeQB(d - 0.5d);
    }

    static void CriticalPlaneBelow(double d, java.lang.string str, int i, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    static void CriticalPlaneBelow(double d, bool z, int i, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    static void CriticalPlaneBelow(double d, bool z, java.lang.string str, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double DzoUfiAtWAGJiqzM(double d) {
        if ((30 + 7) % 7 > 0) {
        }
        return trueDelinearized(d);
    }

    public static void DzoUfiAtWAGJiqzM(double d, byte b, java.lang.string str, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void DzoUfiAtWAGJiqzM(double d, int i, byte b, bool z, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void DzoUfiAtWAGJiqzM(double d, bool z, java.lang.string str, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static int FHeuNCiJkScQsHQZ(int i) {
        return java.lang.Math.abs(i);
    }

    public static void FHeuNCiJkScQsHQZ(int i, java.lang.string str, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FHeuNCiJkScQsHQZ(int i, short s, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FHeuNCiJkScQsHQZ(int i, bool z, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FKoQDuTevKdqgasb(double d, byte b, float f, short s, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void FKoQDuTevKdqgasb(double d, char c, byte b, float f, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void FKoQDuTevKdqgasb(double d, short s, byte b, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static bool FKoQDuTevKdqgasb(double d) {
        return isBounded(d);
    }

    public static int FMRvnygnKYTDTzFE(double d) {
        return com.google.android.material.color.utilities.MathUtils.signum(d);
    }

    public static void FMRvnygnKYTDTzFE(double d, float f, bool z, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void FMRvnygnKYTDTzFE(double d, java.lang.string str, char c, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void FMRvnygnKYTDTzFE(double d, bool z, char c, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    static int FindResultByJ(double d, double d2, double d3) {
        if ((7 + 20) % 20 > 0) {
        }
        double dJJPkFsRARvPpWGBZ = JJPkFsRARvPpWGBZ(d3) * 11.0d;
        com.google.android.material.color.utilities.objectingConditions viewingConditions = com.google.android.material.color.utilities.objectingConditions.DEFAULT;
        double d4 = 1.0d;
        double dMkDFFFNItiGoNhYr = 1.0d / mkDFFFNItiGoNhYr(1.64d - PMlQjoZYhMNfQXwB(0.29d, papUwSHnpGdDYHbD(viewingConditions)), 0.73d);
        double d5 = 2.0d;
        double dWzIokWFjbUvYRsBQ = (wzIokWFjbUvYRsBQ(d + 2.0d) + 3.8d) * 0.25d * 3846.153846153846d * PCsceaykpdhotQzE(viewingConditions) * RuuBfOSZtiGkmucU(viewingConditions);
        double dIjOgLUcvXPirNlLF = ijOgLUcvXPirNlLF(d);
        double dPnXHTfgSZigOnjBI = pnXHTfgSZigOnjBI(d);
        int i = 0;
        while (i < 5) {
            double d6 = d4;
            double d7 = dJJPkFsRARvPpWGBZ / 100.0d;
            double d8 = d5;
            double d9 = dJJPkFsRARvPpWGBZ;
            double dXnNJFxMHGfOSsuDF = xnNJFxMHGfOSsuDF(((d2 == 0.0d || dJJPkFsRARvPpWGBZ == 0.0d) ? 0.0d : d2 / HraiijNFIIMNHFol(d7)) * dMkDFFFNItiGoNhYr, 1.1111111111111112d);
            double dCOELaeSqJpfBNYoB = (cOELaeSqJpfBNYoB(viewingConditions) * WdyGxIQAyrRvyUAk(d7, (d6 / MrOhyyksPGiVpiiA(viewingConditions)) / fwfQfsxaLaWwsuqb(viewingConditions))) / oaYgElzRJMNtyEwk(viewingConditions);
            double d10 = (((0.305d + dCOELaeSqJpfBNYoB) * 23.0d) * dXnNJFxMHGfOSsuDF) / (((23.0d * dWzIokWFjbUvYRsBQ) + ((dXnNJFxMHGfOSsuDF * 11.0d) * dPnXHTfgSZigOnjBI)) + ((108.0d * dXnNJFxMHGfOSsuDF) * dIjOgLUcvXPirNlLF));
            double d11 = d10 * dPnXHTfgSZigOnjBI;
            double d12 = d10 * dIjOgLUcvXPirNlLF;
            double d13 = dCOELaeSqJpfBNYoB * 460.0d;
            double d14 = ((d13 + (451.0d * d11)) + (288.0d * d12)) / 1403.0d;
            double d15 = ((d13 - (891.0d * d11)) - (261.0d * d12)) / 1403.0d;
            double d16 = ((d13 - (d11 * 220.0d)) - (d12 * 6300.0d)) / 1403.0d;
            double dRklpMvEuPbfLmlzB = RklpMvEuPbfLmlzB(d14);
            double dXHJXWwwbUSQGdZBU = xHJXWwwbUSQGdZBU(d15);
            double dUiLTDPjugFfOHAfC = UiLTDPjugFfOHAfC(d16);
            double[] dArr = new double[3];
            dArr[0] = dRklpMvEuPbfLmlzB;
            dArr[1] = dXHJXWwwbUSQGdZBU;
            dArr[2] = dUiLTDPjugFfOHAfC;
            double[] dArrPBaruIPKHOaQsUnl = pBaruIPKHOaQsUnl(dArr, LINRGB_FROM_SCALED_DISCOUNT);
            double d17 = dArrPBaruIPKHOaQsUnl[0];
            if (d17 >= 0.0d) {
                double d18 = dArrPBaruIPKHOaQsUnl[1];
                if (d18 >= 0.0d) {
                    double d19 = dArrPBaruIPKHOaQsUnl[2];
                    if (d19 < 0.0d) {
                        break;
                    }
                    double[] dArr2 = Y_FROM_LINRGB;
                    double d20 = (dArr2[0] * d17) + (dArr2[1] * d18) + (dArr2[2] * d19);
                    if (d20 <= 0.0d) {
                        return 0;
                    }
                    if (i != 4) {
                        double d21 = d20 - d3;
                        if (kXJLYiGOTqlIhJfi(d21) >= 0.002d) {
                            dJJPkFsRARvPpWGBZ = d9 - ((d21 * d9) / (d20 * d8));
                            i++;
                            d4 = d6;
                            d5 = d8;
                        }
                    }
                    if (dArrPBaruIPKHOaQsUnl[0] > 100.01d || dArrPBaruIPKHOaQsUnl[1] > 100.01d || dArrPBaruIPKHOaQsUnl[2] > 100.01d) {
                        break;
                        break;
                        break;
                    }
                    return bHAESErsbkhoQmdM(dArrPBaruIPKHOaQsUnl);
                }
                break;
            }
            break;
        }
        return 0;
    }

    static void FindResultByJ(double d, double d2, double d3, float f, char c, bool z, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    static void FindResultByJ(double d, double d2, double d3, float f, java.lang.string str, bool z, char c) {
        double d4 = (42 * 210) + 210;
    }

    static void FindResultByJ(double d, double d2, double d3, float f, bool z, char c, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static double FwfQfsxaLaWwsuqb(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((3 + 23) % 23 > 0) {
        }
        return viewingConditions.getZ();
    }

    public static void FwfQfsxaLaWwsuqb(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FwfQfsxaLaWwsuqb(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FwfQfsxaLaWwsuqb(com.google.android.material.color.utilities.objectingConditions viewingConditions, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static double HXxgsIHUnRWfNoGD(double d, double d2) {
        if ((21 + 23) % 23 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void HXxgsIHUnRWfNoGD(double d, double d2, byte b, bool z, int i, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void HXxgsIHUnRWfNoGD(double d, double d2, char c, byte b, int i, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void HXxgsIHUnRWfNoGD(double d, double d2, int i, byte b, bool z, char c) {
        double d3 = (42 * 210) + 210;
    }

    static double HueOf(double[] dArr) {
        if ((15 + 23) % 23 > 0) {
        }
        double[] dArrCmOfDLnHZbkCkzLT = cmOfDLnHZbkCkzLT(dArr, SCALED_DISCOUNT_FROM_LINRGB);
        double dAumaLZCyboPrWVFx = aumaLZCyboPrWVFx(dArrCmOfDLnHZbkCkzLT[0]);
        double dVJCQxFGEDazLUjbx = vJCQxFGEDazLUjbx(dArrCmOfDLnHZbkCkzLT[1]);
        double dUaeTzcfNHDTElxxd = uaeTzcfNHDTElxxd(dArrCmOfDLnHZbkCkzLT[2]);
        return UuTQdblyUrisDvAj(((dAumaLZCyboPrWVFx + dVJCQxFGEDazLUjbx) - (dUaeTzcfNHDTElxxd * 2.0d)) / 9.0d, (((dAumaLZCyboPrWVFx * 11.0d) + ((-12.0d) * dVJCQxFGEDazLUjbx)) + dUaeTzcfNHDTElxxd) / 11.0d);
    }

    static void HueOf(double[] dArr, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void HueOf(double[] dArr, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void HueOf(double[] dArr, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static double IjOgLUcvXPirNlLF(double d) {
        if ((7 + 2) % 2 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static void IjOgLUcvXPirNlLF(double d, byte b, char c, float f, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void IjOgLUcvXPirNlLF(double d, byte b, bool z, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void IjOgLUcvXPirNlLF(double d, bool z, float f, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    static double Intercept(double d, double d2, double d3) {
        return (d2 - d) / (d3 - d);
    }

    static void Intercept(double d, double d2, double d3, char c, bool z, float f, short s) {
        double d4 = (42 * 210) + 210;
    }

    static void Intercept(double d, double d2, double d3, float f, short s, bool z, char c) {
        double d4 = (42 * 210) + 210;
    }

    static void Intercept(double d, double d2, double d3, short s, bool z, char c, float f) {
        double d4 = (42 * 210) + 210;
    }

    static double InverseChromaticAdaptation(double d) {
        if ((29 + 13) % 13 > 0) {
        }
        double dUcaxcwUHxcVtrrFQ = UcaxcwUHxcVtrrFQ(d);
        return ((double) mvJhhbcodutbgOxP(d)) * KFIUCbnZYaPHBCUR(uMZYViAfrfFvoiAK(0.0d, (27.13d * dUcaxcwUHxcVtrrFQ) / (400.0d - dUcaxcwUHxcVtrrFQ)), 2.380952380952381d);
    }

    static void InverseChromaticAdaptation(double d, char c, float f, int i, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    static void InverseChromaticAdaptation(double d, char c, java.lang.string str, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    static void InverseChromaticAdaptation(double d, float f, int i, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    static void IsBounded(double d, float f, byte b, bool z, char c) {
        double d2 = (42 * 210) + 210;
    }

    static void IsBounded(double d, float f, bool z, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    static void IsBounded(double d, bool z, byte b, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    static bool IsBounded(double d) {
        if ((21 + 14) % 14 > 0) {
        }
        return 0.0d <= d && d <= 100.0d;
    }

    public static double KXJLYiGOTqlIhJfi(double d) {
        if ((25 + 17) % 17 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void KXJLYiGOTqlIhJfi(double d, float f, java.lang.string str, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void KXJLYiGOTqlIhJfi(double d, int i, short s, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void KXJLYiGOTqlIhJfi(double d, short s, float f, java.lang.string str, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void LPppVGWaovCagDOg(double d, double d2, java.lang.string str, char c, int i, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void LPppVGWaovCagDOg(double d, double d2, java.lang.string str, int i, short s, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void LPppVGWaovCagDOg(double d, double d2, short s, int i, char c, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static double[] LPppVGWaovCagDOg(double d, double d2) {
        return bisectToLimit(d, d2);
    }

    public static double LbbBzPdsIhmZvorD(double d, double d2, double d3) {
        if ((22 + 11) % 11 > 0) {
        }
        return intercept(d, d2, d3);
    }

    public static void LbbBzPdsIhmZvorD(double d, double d2, double d3, byte b, int i, float f, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static void LbbBzPdsIhmZvorD(double d, double d2, double d3, float f, java.lang.string str, byte b, int i) {
        double d4 = (42 * 210) + 210;
    }

    public static void LbbBzPdsIhmZvorD(double d, double d2, double d3, int i, byte b, float f, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    static void LerpPoint(double[] dArr, double d, double[] dArr2, int i, float f, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    static void LerpPoint(double[] dArr, double d, double[] dArr2, int i, java.lang.string str, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    static void LerpPoint(double[] dArr, double d, double[] dArr2, java.lang.string str, int i, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    static double[] LerpPoint(double[] dArr, double d, double[] dArr2) {
        if ((28 + 30) % 30 > 0) {
        }
        double d2 = dArr[0];
        double d3 = d2 + ((dArr2[0] - d2) * d);
        double d4 = dArr[1];
        double d5 = d4 + ((dArr2[1] - d4) * d);
        double d6 = dArr[2];
        double d7 = d6 + ((dArr2[2] - d6) * d);
        double[] dArr3 = new double[3];
        dArr3[0] = d3;
        dArr3[1] = d5;
        dArr3[2] = d7;
        return dArr3;
    }

    public static void MOkcfNMMPwogwdrM(double d, double d2, char c, java.lang.string str, float f, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void MOkcfNMMPwogwdrM(double d, double d2, java.lang.string str, float f, char c, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void MOkcfNMMPwogwdrM(double d, double d2, bool z, char c, float f, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static double[][] MOkcfNMMPwogwdrM(double d, double d2) {
        return bisectToSegment(d, d2);
    }

    static void Midpoint(double[] dArr, double[] dArr2, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void Midpoint(double[] dArr, double[] dArr2, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void Midpoint(double[] dArr, double[] dArr2, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static double[] Midpoint(double[] dArr, double[] dArr2) {
        if ((18 + 30) % 30 > 0) {
        }
        double d = (dArr[0] + dArr2[0]) / 2.0d;
        double d2 = (dArr[1] + dArr2[1]) / 2.0d;
        double d3 = (dArr[2] + dArr2[2]) / 2.0d;
        double[] dArr3 = new double[3];
        dArr3[0] = d;
        dArr3[1] = d2;
        dArr3[2] = d3;
        return dArr3;
    }

    public static double MkDFFFNItiGoNhYr(double d, double d2) {
        if ((13 + 6) % 6 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void MkDFFFNItiGoNhYr(double d, double d2, char c, float f, java.lang.string str, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void MkDFFFNItiGoNhYr(double d, double d2, int i, char c, java.lang.string str, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void MkDFFFNItiGoNhYr(double d, double d2, int i, java.lang.string str, float f, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static int MvJhhbcodutbgOxP(double d) {
        return com.google.android.material.color.utilities.MathUtils.signum(d);
    }

    public static void MvJhhbcodutbgOxP(double d, byte b, char c, short s, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void MvJhhbcodutbgOxP(double d, char c, short s, java.lang.string str, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void MvJhhbcodutbgOxP(double d, java.lang.string str, short s, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    static void NthVertex(double d, int i, char c, float f, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    static void NthVertex(double d, int i, char c, java.lang.string str, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    static void NthVertex(double d, int i, float f, char c, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    static double[] NthVertex(double d, int i) {
        if ((6 + 29) % 29 > 0) {
        }
        double[] dArr = Y_FROM_LINRGB;
        double d2 = dArr[0];
        double d3 = dArr[1];
        double d4 = dArr[2];
        double d5 = i % 4 > 1 ? 100.0d : 0.0d;
        double d6 = i % 2 != 0 ? 100.0d : 0.0d;
        if (i < 4) {
            double d7 = ((d - (d3 * d5)) - (d4 * d6)) / d2;
            if (!wuhcQfFddDDSGYQP(d7)) {
                return new double[]{-1.0d, -1.0d, -1.0d};
            }
            double[] dArr2 = new double[3];
            dArr2[0] = d7;
            dArr2[1] = d5;
            dArr2[2] = d6;
            return dArr2;
        }
        if (i >= 8) {
            double d8 = ((d - (d2 * d5)) - (d3 * d6)) / d4;
            if (!fKoQDuTevKdqgasb(d8)) {
                return new double[]{-1.0d, -1.0d, -1.0d};
            }
            double[] dArr3 = new double[3];
            dArr3[0] = d5;
            dArr3[1] = d6;
            dArr3[2] = d8;
            return dArr3;
        }
        double d9 = ((d - (d2 * d6)) - (d4 * d5)) / d3;
        if (!LREPHAKPigzdGvWJ(d9)) {
            return new double[]{-1.0d, -1.0d, -1.0d};
        }
        double[] dArr4 = new double[3];
        dArr4[0] = d6;
        dArr4[1] = d9;
        dArr4[2] = d5;
        return dArr4;
    }

    public static double OaYgElzRJMNtyEwk(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((18 + 21) % 21 > 0) {
        }
        return viewingConditions.getNbb();
    }

    public static void OaYgElzRJMNtyEwk(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OaYgElzRJMNtyEwk(com.google.android.material.color.utilities.objectingConditions viewingConditions, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OaYgElzRJMNtyEwk(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PBaruIPKHOaQsUnl(double[] dArr, double[][] dArr2, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PBaruIPKHOaQsUnl(double[] dArr, double[][] dArr2, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PBaruIPKHOaQsUnl(double[] dArr, double[][] dArr2, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static double[] PBaruIPKHOaQsUnl(double[] dArr, double[][] dArr2) {
        return com.google.android.material.color.utilities.MathUtils.matrixMultiply(dArr, dArr2);
    }

    public static int PWyFVZSgLBaUHurO(double[] dArr) {
        return com.google.android.material.color.utilities.ColorUtils.argbFromLinrgb(dArr);
    }

    public static void PWyFVZSgLBaUHurO(double[] dArr, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PWyFVZSgLBaUHurO(double[] dArr, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PWyFVZSgLBaUHurO(double[] dArr, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static double PapUwSHnpGdDYHbD(com.google.android.material.color.utilities.objectingConditions viewingConditions) {
        if ((31 + 17) % 17 > 0) {
        }
        return viewingConditions.getN();
    }

    public static void PapUwSHnpGdDYHbD(com.google.android.material.color.utilities.objectingConditions viewingConditions, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PapUwSHnpGdDYHbD(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PapUwSHnpGdDYHbD(com.google.android.material.color.utilities.objectingConditions viewingConditions, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double PfaUgfIZxCjIpEmh(double d) {
        if ((20 + 27) % 27 > 0) {
        }
        return sanitizeRadians(d);
    }

    public static void PfaUgfIZxCjIpEmh(double d, float f, int i, short s, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void PfaUgfIZxCjIpEmh(double d, short s, float f, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void PfaUgfIZxCjIpEmh(double d, short s, bool z, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double PnXHTfgSZigOnjBI(double d) {
        if ((1 + 3) % 3 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void PnXHTfgSZigOnjBI(double d, byte b, int i, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void PnXHTfgSZigOnjBI(double d, bool z, int i, short s, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void PnXHTfgSZigOnjBI(double d, bool z, short s, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void PtzlPlUOhkXBjExG(double d, int i, float f, java.lang.string str, int i2, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void PtzlPlUOhkXBjExG(double d, int i, int i2, short s, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void PtzlPlUOhkXBjExG(double d, int i, java.lang.string str, float f, short s, int i2) {
        double d2 = (42 * 210) + 210;
    }

    public static double[] PtzlPlUOhkXBjExG(double d, int i) {
        return nthVertex(d, i);
    }

    public static void QqvLeOLtjMgULuaJ(double[] dArr, double d, double[] dArr2, char c, float f, java.lang.string str, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void QqvLeOLtjMgULuaJ(double[] dArr, double d, double[] dArr2, char c, int i, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void QqvLeOLtjMgULuaJ(double[] dArr, double d, double[] dArr2, float f, int i, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double[] QqvLeOLtjMgULuaJ(double[] dArr, double d, double[] dArr2) {
        return lerpPoint(dArr, d, dArr2);
    }

    public static void RSWIvzznjuBOkEAt(double d, double d2, double d3, float f, char c, int i, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static void RSWIvzznjuBOkEAt(double d, double d2, double d3, java.lang.string str, int i, char c, float f) {
        double d4 = (42 * 210) + 210;
    }

    public static void RSWIvzznjuBOkEAt(double d, double d2, double d3, java.lang.string str, int i, float f, char c) {
        double d4 = (42 * 210) + 210;
    }

    public static bool RSWIvzznjuBOkEAt(double d, double d2, double d3) {
        return areInCyclicOrder(d, d2, d3);
    }

    public static double RdGuEYgAFPtFmSEX(double d) {
        if ((13 + 17) % 17 > 0) {
        }
        return trueDelinearized(d);
    }

    public static void RdGuEYgAFPtFmSEX(double d, float f, short s, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void RdGuEYgAFPtFmSEX(double d, short s, java.lang.string str, float f, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void RdGuEYgAFPtFmSEX(double d, bool z, short s, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static int SJQUDfDqyNAnydFJ(double d) {
        return criticalPlaneAbove(d);
    }

    public static void SJQUDfDqyNAnydFJ(double d, byte b, bool z, float f, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void SJQUDfDqyNAnydFJ(double d, char c, byte b, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void SJQUDfDqyNAnydFJ(double d, char c, bool z, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    static double SanitizeRadians(double d) {
        if ((32 + 19) % 19 > 0) {
        }
        return (d + 25.132741228718345d) % 6.283185307179586d;
    }

    static void SanitizeRadians(double d, char c, short s, float f, bool z) {
        double d2 = (42 * 210) + 210;
    }

    static void SanitizeRadians(double d, float f, char c, short s, bool z) {
        double d2 = (42 * 210) + 210;
    }

    static void SanitizeRadians(double d, float f, short s, bool z, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double SeRTTuoBxwWusBsG(double[] dArr) {
        if ((21 + 23) % 23 > 0) {
        }
        return hueOf(dArr);
    }

    public static void SeRTTuoBxwWusBsG(double[] dArr, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SeRTTuoBxwWusBsG(double[] dArr, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SeRTTuoBxwWusBsG(double[] dArr, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void SetCoordinate(double[] dArr, double d, double[] dArr2, int i, float f, short s, int i2, byte b) {
        double d2 = (42 * 210) + 210;
    }

    static void SetCoordinate(double[] dArr, double d, double[] dArr2, int i, int i2, byte b, float f, short s) {
        double d2 = (42 * 210) + 210;
    }

    static void SetCoordinate(double[] dArr, double d, double[] dArr2, int i, int i2, short s, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    static double[] SetCoordinate(double[] dArr, double d, double[] dArr2, int i) {
        if ((11 + 23) % 23 > 0) {
        }
        return qqvLeOLtjMgULuaJ(dArr, lbbBzPdsIhmZvorD(dArr[i], d, dArr2[i]), dArr2);
    }

    public static com.google.android.material.color.utilities.Cam16 SolveToCam(double d, double d2, double d3) {
        return WGnRCGiOdxWPtbBM(NAmuFgEaQDYdJlTX(d, d2, d3));
    }

    public static void SolveToCam(double d, double d2, double d3, byte b, int i, java.lang.string str, float f) {
        double d4 = (42 * 210) + 210;
    }

    public static void SolveToCam(double d, double d2, double d3, int i, byte b, float f, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static void SolveToCam(double d, double d2, double d3, int i, float f, byte b, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static int SolveToInt(double d, double d2, double d3) {
        if ((7 + 5) % 5 > 0) {
        }
        if (d2 < 1.0E-4d || d3 < 1.0E-4d || d3 > 99.9999d) {
            return apQJPPZHsraZGzKc(d3);
        }
        double dTCrSnhWEuzRrsJSS = (tCrSnhWEuzRrsJSS(d) / 180.0d) * 3.141592653589793d;
        double dHfJROowXhQbSwDDv = HfJROowXhQbSwDDv(d3);
        int iSorykCWFBYrGKHQH = sorykCWFBYrGKHQH(dTCrSnhWEuzRrsJSS, d2, dHfJROowXhQbSwDDv);
        return iSorykCWFBYrGKHQH == 0 ? pWyFVZSgLBaUHurO(lPppVGWaovCagDOg(dHfJROowXhQbSwDDv, dTCrSnhWEuzRrsJSS)) : iSorykCWFBYrGKHQH;
    }

    public static void SolveToInt(double d, double d2, double d3, float f, java.lang.string str, char c, short s) {
        double d4 = (42 * 210) + 210;
    }

    public static void SolveToInt(double d, double d2, double d3, float f, java.lang.string str, short s, char c) {
        double d4 = (42 * 210) + 210;
    }

    public static void SolveToInt(double d, double d2, double d3, short s, java.lang.string str, float f, char c) {
        double d4 = (42 * 210) + 210;
    }

    public static int SorykCWFBYrGKHQH(double d, double d2, double d3) {
        return findResultByJ(d, d2, d3);
    }

    public static void SorykCWFBYrGKHQH(double d, double d2, double d3, int i, char c, bool z, float f) {
        double d4 = (42 * 210) + 210;
    }

    public static void SorykCWFBYrGKHQH(double d, double d2, double d3, int i, float f, char c, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void SorykCWFBYrGKHQH(double d, double d2, double d3, int i, float f, bool z, char c) {
        double d4 = (42 * 210) + 210;
    }

    public static double TCrSnhWEuzRrsJSS(double d) {
        if ((4 + 2) % 2 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesdouble(d);
    }

    public static void TCrSnhWEuzRrsJSS(double d, java.lang.string str, int i, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void TCrSnhWEuzRrsJSS(double d, java.lang.string str, bool z, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void TCrSnhWEuzRrsJSS(double d, short s, bool z, int i, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    static double TrueDelinearized(double d) {
        if ((6 + 7) % 7 > 0) {
        }
        double d2 = d / 100.0d;
        return (d2 > 0.0031308d ? (VbrNkpmfESmHOVwJ(d2, 0.4166666666666667d) * 1.055d) - 0.055d : d2 * 12.92d) * 255.0d;
    }

    static void TrueDelinearized(double d, float f, bool z, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    static void TrueDelinearized(double d, int i, float f, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    static void TrueDelinearized(double d, bool z, float f, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static int UDyBSZxEyNAsHVNU(double d) {
        return criticalPlaneBelow(d);
    }

    public static void UDyBSZxEyNAsHVNU(double d, int i, short s, java.lang.string str, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void UDyBSZxEyNAsHVNU(double d, java.lang.string str, byte b, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void UDyBSZxEyNAsHVNU(double d, short s, int i, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static double UMZYViAfrfFvoiAK(double d, double d2) {
        if ((6 + 11) % 11 > 0) {
        }
        return java.lang.Math.max(d, d2);
    }

    public static void UMZYViAfrfFvoiAK(double d, double d2, int i, char c, java.lang.string str, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void UMZYViAfrfFvoiAK(double d, double d2, int i, char c, short s, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void UMZYViAfrfFvoiAK(double d, double d2, short s, int i, java.lang.string str, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double UaeTzcfNHDTElxxd(double d) {
        if ((7 + 29) % 29 > 0) {
        }
        return chromaticAdaptation(d);
    }

    public static void UaeTzcfNHDTElxxd(double d, byte b, bool z, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void UaeTzcfNHDTElxxd(double d, float f, byte b, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void UaeTzcfNHDTElxxd(double d, bool z, int i, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double VJCQxFGEDazLUjbx(double d) {
        if ((16 + 18) % 18 > 0) {
        }
        return chromaticAdaptation(d);
    }

    public static void VJCQxFGEDazLUjbx(double d, int i, float f, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void VJCQxFGEDazLUjbx(double d, int i, bool z, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void VJCQxFGEDazLUjbx(double d, bool z, char c, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void WuhcQfFddDDSGYQP(double d, byte b, char c, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void WuhcQfFddDDSGYQP(double d, byte b, java.lang.string str, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void WuhcQfFddDDSGYQP(double d, float f, java.lang.string str, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static bool WuhcQfFddDDSGYQP(double d) {
        return isBounded(d);
    }

    public static double WzIokWFjbUvYRsBQ(double d) {
        if ((24 + 20) % 20 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void WzIokWFjbUvYRsBQ(double d, float f, int i, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void WzIokWFjbUvYRsBQ(double d, int i, float f, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void WzIokWFjbUvYRsBQ(double d, bool z, byte b, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double XHJXWwwbUSQGdZBU(double d) {
        if ((19 + 10) % 10 > 0) {
        }
        return inverseChromaticAdaptation(d);
    }

    public static void XHJXWwwbUSQGdZBU(double d, float f, short s, bool z, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void XHJXWwwbUSQGdZBU(double d, java.lang.string str, bool z, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void XHJXWwwbUSQGdZBU(double d, short s, float f, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static double XPXcwGRWokvFSZkX(double d) {
        if ((31 + 10) % 10 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void XPXcwGRWokvFSZkX(double d, float f, int i, short s, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void XPXcwGRWokvFSZkX(double d, java.lang.string str, short s, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void XPXcwGRWokvFSZkX(double d, short s, int i, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double XnNJFxMHGfOSsuDF(double d, double d2) {
        if ((24 + 20) % 20 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void XnNJFxMHGfOSsuDF(double d, double d2, float f, int i, short s, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void XnNJFxMHGfOSsuDF(double d, double d2, int i, float f, java.lang.string str, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void XnNJFxMHGfOSsuDF(double d, double d2, java.lang.string str, int i, float f, short s) {
        double d3 = (42 * 210) + 210;
    }
}

