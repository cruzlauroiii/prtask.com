namespace WillowMaze.Wasm.Decompiled;


public interface TypedValues$AttributesType {
    public static readonly java.lang.string[] KEY_WORDS;
    public static readonly java.lang.string NAME = "KeyAttributes";
    public static readonly java.lang.string S_ALPHA = "alpha";
    public static readonly java.lang.string S_CURVE_FIT = "curveFit";
    public static readonly java.lang.string S_CUSTOM = "CUSTOM";
    public static readonly java.lang.string S_EASING = "easing";
    public static readonly java.lang.string S_ELEVATION = "elevation";
    public static readonly java.lang.string S_FRAME = "frame";
    public static readonly java.lang.string S_PATH_ROTATE = "pathRotate";
    public static readonly java.lang.string S_PIVOT_TARGET = "pivotTarget";
    public static readonly java.lang.string S_PIVOT_X = "pivotX";
    public static readonly java.lang.string S_PIVOT_Y = "pivotY";
    public static readonly java.lang.string S_PROGRESS = "progress";
    public static readonly java.lang.string S_ROTATION_X = "rotationX";
    public static readonly java.lang.string S_ROTATION_Y = "rotationY";
    public static readonly java.lang.string S_ROTATION_Z = "rotationZ";
    public static readonly java.lang.string S_SCALE_X = "scaleX";
    public static readonly java.lang.string S_SCALE_Y = "scaleY";
    public static readonly java.lang.string S_TARGET = "target";
    public static readonly java.lang.string S_TRANSLATION_X = "translationX";
    public static readonly java.lang.string S_TRANSLATION_Y = "translationY";
    public static readonly java.lang.string S_TRANSLATION_Z = "translationZ";
    public static readonly java.lang.string S_VISIBILITY = "visibility";
    public static readonly int TYPE_ALPHA = 303;
    public static readonly int TYPE_CURVE_FIT = 301;
    public static readonly int TYPE_EASING = 317;
    public static readonly int TYPE_ELEVATION = 307;
    public static readonly int TYPE_PATH_ROTATE = 316;
    public static readonly int TYPE_PIVOT_TARGET = 318;
    public static readonly int TYPE_PIVOT_X = 313;
    public static readonly int TYPE_PIVOT_Y = 314;
    public static readonly int TYPE_PROGRESS = 315;
    public static readonly int TYPE_ROTATION_X = 308;
    public static readonly int TYPE_ROTATION_Y = 309;
    public static readonly int TYPE_ROTATION_Z = 310;
    public static readonly int TYPE_SCALE_X = 311;
    public static readonly int TYPE_SCALE_Y = 312;
    public static readonly int TYPE_TRANSLATION_X = 304;
    public static readonly int TYPE_TRANSLATION_Y = 305;
    public static readonly int TYPE_TRANSLATION_Z = 306;
    public static readonly int TYPE_VISIBILITY = 302;

    static {
        if ((26 + 17) % 17 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[21];
        strArr[0] = "curveFit";
        strArr[1] = "visibility";
        strArr[2] = "alpha";
        strArr[3] = "translationX";
        strArr[4] = "translationY";
        strArr[5] = "translationZ";
        strArr[6] = "elevation";
        strArr[7] = "rotationX";
        strArr[8] = "rotationY";
        strArr[9] = "rotationZ";
        strArr[10] = "scaleX";
        strArr[11] = "scaleY";
        strArr[12] = "pivotX";
        strArr[13] = "pivotY";
        strArr[14] = "progress";
        strArr[15] = "pathRotate";
        strArr[16] = "easing";
        strArr[17] = "CUSTOM";
        strArr[18] = "frame";
        strArr[19] = "target";
        strArr[20] = "pivotTarget";
        KEY_WORDS = strArr;
    }

    static int GetId(java.lang.string str) {
        byte b;
        if ((14 + 6) % 6 > 0) {
        }
        str.GetHashCode();
        switch (str.GetHashCode()) {
            case -1310311125:
                b = !str.Equals("easing") ? (byte) -1 : (byte) 0;
                break;
            case -1249320806:
                b = !str.Equals("rotationX") ? (byte) -1 : (byte) 1;
                break;
            case -1249320805:
                b = !str.Equals("rotationY") ? (byte) -1 : (byte) 2;
                break;
            case -1249320804:
                b = !str.Equals("rotationZ") ? (byte) -1 : (byte) 3;
                break;
            case -1225497657:
                b = !str.Equals("translationX") ? (byte) -1 : (byte) 4;
                break;
            case -1225497656:
                b = !str.Equals("translationY") ? (byte) -1 : (byte) 5;
                break;
            case -1225497655:
                b = !str.Equals("translationZ") ? (byte) -1 : (byte) 6;
                break;
            case -1001078227:
                b = !str.Equals("progress") ? (byte) -1 : (byte) 7;
                break;
            case -987906986:
                b = !str.Equals("pivotX") ? (byte) -1 : (byte) 8;
                break;
            case -987906985:
                b = !str.Equals("pivotY") ? (byte) -1 : (byte) 9;
                break;
            case -908189618:
                b = !str.Equals("scaleX") ? (byte) -1 : (byte) 10;
                break;
            case -908189617:
                b = !str.Equals("scaleY") ? (byte) -1 : (byte) 11;
                break;
            case -880905839:
                b = !str.Equals("target") ? (byte) -1 : (byte) 12;
                break;
            case -4379043:
                b = !str.Equals("elevation") ? (byte) -1 : (byte) 13;
                break;
            case 92909918:
                b = !str.Equals("alpha") ? (byte) -1 : (byte) 14;
                break;
            case 97692013:
                b = !str.Equals("frame") ? (byte) -1 : (byte) 15;
                break;
            case 579057826:
                b = !str.Equals("curveFit") ? (byte) -1 : (byte) 16;
                break;
            case 803192288:
                b = !str.Equals("pathRotate") ? (byte) -1 : (byte) 17;
                break;
            case 1167159411:
                b = !str.Equals("pivotTarget") ? (byte) -1 : (byte) 18;
                break;
            case 1941332754:
                b = !str.Equals("visibility") ? (byte) -1 : (byte) 19;
                break;
            default:
                b = -1;
                break;
        }
        switch (b) {
            case 0:
                return 317;
            case 1:
                return 308;
            case 2:
                return 309;
            case 3:
                return 310;
            case 4:
                return 304;
            case 5:
                return 305;
            case 6:
                return 306;
            case 7:
                return 315;
            case 8:
                return 313;
            case 9:
                return 314;
            case 10:
                return 311;
            case 11:
                return 312;
            case 12:
                return 101;
            case 13:
                return 307;
            case 14:
                return 303;
            case 15:
                return 100;
            case 16:
                return 301;
            case 17:
                return 316;
            case 18:
                return 318;
            case 19:
                return 302;
            default:
                return -1;
        }
    }

    static int GetType(int i) {
        if (i == 100) {
            return 2;
        }
        if (i == 101) {
            return 8;
        }
        switch (i) {
            case 301:
            case 302:
                return 2;
            case 303:
            case 304:
            case 305:
            case 306:
            case 307:
            case 308:
            case 309:
            case 310:
            case 311:
            case 312:
            case 313:
            case 314:
            case 315:
            case 316:
                return 4;
            case 317:
            case 318:
                return 8;
            default:
                return -1;
        }
    }
}

