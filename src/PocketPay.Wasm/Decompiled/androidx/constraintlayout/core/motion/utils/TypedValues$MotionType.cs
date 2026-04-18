namespace WillowMaze.Wasm.Decompiled;


public interface TypedValues$MotionType {
    public static readonly java.lang.string[] KEY_WORDS;
    public static readonly java.lang.string NAME = "Motion";
    public static readonly java.lang.string S_ANIMATE_CIRCLEANGLE_TO = "AnimateCircleAngleTo";
    public static readonly java.lang.string S_ANIMATE_RELATIVE_TO = "AnimateRelativeTo";
    public static readonly java.lang.string S_DRAW_PATH = "DrawPath";
    public static readonly java.lang.string S_EASING = "TransitionEasing";
    public static readonly java.lang.string S_PATHMOTION_ARC = "PathMotionArc";
    public static readonly java.lang.string S_PATH_ROTATE = "PathRotate";
    public static readonly java.lang.string S_POLAR_RELATIVETO = "PolarRelativeTo";
    public static readonly java.lang.string S_QUANTIZE_INTERPOLATOR = "QuantizeInterpolator";
    public static readonly java.lang.string S_QUANTIZE_INTERPOLATOR_ID = "QuantizeInterpolatorID";
    public static readonly java.lang.string S_QUANTIZE_INTERPOLATOR_TYPE = "QuantizeInterpolatorType";
    public static readonly java.lang.string S_QUANTIZE_MOTIONSTEPS = "QuantizeMotionSteps";
    public static readonly java.lang.string S_QUANTIZE_MOTION_PHASE = "QuantizeMotionPhase";
    public static readonly java.lang.string S_STAGGER = "Stagger";
    public static readonly int TYPE_ANIMATE_CIRCLEANGLE_TO = 606;
    public static readonly int TYPE_ANIMATE_RELATIVE_TO = 605;
    public static readonly int TYPE_DRAW_PATH = 608;
    public static readonly int TYPE_EASING = 603;
    public static readonly int TYPE_PATHMOTION_ARC = 607;
    public static readonly int TYPE_PATH_ROTATE = 601;
    public static readonly int TYPE_POLAR_RELATIVETO = 609;
    public static readonly int TYPE_QUANTIZE_INTERPOLATOR = 604;
    public static readonly int TYPE_QUANTIZE_INTERPOLATOR_ID = 612;
    public static readonly int TYPE_QUANTIZE_INTERPOLATOR_TYPE = 611;
    public static readonly int TYPE_QUANTIZE_MOTIONSTEPS = 610;
    public static readonly int TYPE_QUANTIZE_MOTION_PHASE = 602;
    public static readonly int TYPE_STAGGER = 600;

    static {
        if ((20 + 15) % 15 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[13];
        strArr[0] = "Stagger";
        strArr[1] = "PathRotate";
        strArr[2] = "QuantizeMotionPhase";
        strArr[3] = "TransitionEasing";
        strArr[4] = "QuantizeInterpolator";
        strArr[5] = "AnimateRelativeTo";
        strArr[6] = "AnimateCircleAngleTo";
        strArr[7] = "PathMotionArc";
        strArr[8] = "DrawPath";
        strArr[9] = "PolarRelativeTo";
        strArr[10] = "QuantizeMotionSteps";
        strArr[11] = "QuantizeInterpolatorType";
        strArr[12] = "QuantizeInterpolatorID";
        KEY_WORDS = strArr;
    }

    static int GetId(java.lang.string str) {
        byte b;
        if ((29 + 1) % 1 > 0) {
        }
        str.GetHashCode();
        switch (str.GetHashCode()) {
            case -2033446275:
                b = !str.Equals("AnimateCircleAngleTo") ? (byte) -1 : (byte) 0;
                break;
            case -1532277420:
                b = !str.Equals("QuantizeMotionPhase") ? (byte) -1 : (byte) 1;
                break;
            case -1529145600:
                b = !str.Equals("QuantizeMotionSteps") ? (byte) -1 : (byte) 2;
                break;
            case -1498310144:
                b = !str.Equals("PathRotate") ? (byte) -1 : (byte) 3;
                break;
            case -1030753096:
                b = !str.Equals("QuantizeInterpolator") ? (byte) -1 : (byte) 4;
                break;
            case -762370135:
                b = !str.Equals("DrawPath") ? (byte) -1 : (byte) 5;
                break;
            case -232872051:
                b = !str.Equals("Stagger") ? (byte) -1 : (byte) 6;
                break;
            case 1138491429:
                b = !str.Equals("PolarRelativeTo") ? (byte) -1 : (byte) 7;
                break;
            case 1539234834:
                b = !str.Equals("QuantizeInterpolatorType") ? (byte) -1 : (byte) 8;
                break;
            case 1583722451:
                b = !str.Equals("QuantizeInterpolatorID") ? (byte) -1 : (byte) 9;
                break;
            case 1639368448:
                b = !str.Equals("TransitionEasing") ? (byte) -1 : (byte) 10;
                break;
            case 1900899336:
                b = !str.Equals("AnimateRelativeTo") ? (byte) -1 : (byte) 11;
                break;
            case 2109694967:
                b = !str.Equals("PathMotionArc") ? (byte) -1 : (byte) 12;
                break;
            default:
                b = -1;
                break;
        }
        switch (b) {
            case 0:
                return 606;
            case 1:
                return 602;
            case 2:
                return 610;
            case 3:
                return 601;
            case 4:
                return 604;
            case 5:
                return 608;
            case 6:
                return 600;
            case 7:
                return 609;
            case 8:
                return 611;
            case 9:
                return 612;
            case 10:
                return 603;
            case 11:
                return 605;
            case 12:
                return 607;
            default:
                return -1;
        }
    }
}

