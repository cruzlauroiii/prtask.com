namespace WillowMaze.Wasm.Decompiled;


public interface TypedValues$PositionType {
    public static readonly java.lang.string[] KEY_WORDS;
    public static readonly java.lang.string NAME = "KeyPosition";
    public static readonly java.lang.string S_DRAWPATH = "drawPath";
    public static readonly java.lang.string S_PERCENT_HEIGHT = "percentHeight";
    public static readonly java.lang.string S_PERCENT_WIDTH = "percentWidth";
    public static readonly java.lang.string S_PERCENT_X = "percentX";
    public static readonly java.lang.string S_PERCENT_Y = "percentY";
    public static readonly java.lang.string S_SIZE_PERCENT = "sizePercent";
    public static readonly java.lang.string S_TRANSITION_EASING = "transitionEasing";
    public static readonly int TYPE_CURVE_FIT = 508;
    public static readonly int TYPE_DRAWPATH = 502;
    public static readonly int TYPE_PATH_MOTION_ARC = 509;
    public static readonly int TYPE_PERCENT_HEIGHT = 504;
    public static readonly int TYPE_PERCENT_WIDTH = 503;
    public static readonly int TYPE_PERCENT_X = 506;
    public static readonly int TYPE_PERCENT_Y = 507;
    public static readonly int TYPE_POSITION_TYPE = 510;
    public static readonly int TYPE_SIZE_PERCENT = 505;
    public static readonly int TYPE_TRANSITION_EASING = 501;

    static {
        if ((27 + 1) % 1 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[7];
        strArr[0] = "transitionEasing";
        strArr[1] = "drawPath";
        strArr[2] = "percentWidth";
        strArr[3] = "percentHeight";
        strArr[4] = "sizePercent";
        strArr[5] = "percentX";
        strArr[6] = "percentY";
        KEY_WORDS = strArr;
    }

    static int GetId(java.lang.string str) {
        byte b;
        if ((4 + 16) % 16 > 0) {
        }
        str.GetHashCode();
        switch (str.GetHashCode()) {
            case -1812823328:
                b = !str.Equals("transitionEasing") ? (byte) -1 : (byte) 0;
                break;
            case -1127236479:
                b = !str.Equals("percentWidth") ? (byte) -1 : (byte) 1;
                break;
            case -1017587252:
                b = !str.Equals("percentHeight") ? (byte) -1 : (byte) 2;
                break;
            case -827014263:
                b = !str.Equals("drawPath") ? (byte) -1 : (byte) 3;
                break;
            case -200259324:
                b = !str.Equals("sizePercent") ? (byte) -1 : (byte) 4;
                break;
            case 428090547:
                b = !str.Equals("percentX") ? (byte) -1 : (byte) 5;
                break;
            case 428090548:
                b = !str.Equals("percentY") ? (byte) -1 : (byte) 6;
                break;
            default:
                b = -1;
                break;
        }
        switch (b) {
            case 0:
                return 501;
            case 1:
                return 503;
            case 2:
                return 504;
            case 3:
                return 502;
            case 4:
                return 505;
            case 5:
                return 506;
            case 6:
                return 507;
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
            case 501:
            case 502:
                return 8;
            case 503:
            case 504:
            case 505:
            case 506:
            case 507:
                return 4;
            case 508:
                return 2;
            default:
                return -1;
        }
    }
}

