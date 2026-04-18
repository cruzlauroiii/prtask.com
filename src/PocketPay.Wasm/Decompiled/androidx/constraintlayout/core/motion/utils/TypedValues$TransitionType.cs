namespace WillowMaze.Wasm.Decompiled;


public interface TypedValues$TransitionType {
    public static readonly java.lang.string[] KEY_WORDS;
    public static readonly java.lang.string NAME = "Transitions";
    public static readonly java.lang.string S_AUTO_TRANSITION = "autoTransition";
    public static readonly java.lang.string S_DURATION = "duration";
    public static readonly java.lang.string S_FROM = "from";
    public static readonly java.lang.string S_INTERPOLATOR = "motionInterpolator";
    public static readonly java.lang.string S_PATH_MOTION_ARC = "pathMotionArc";
    public static readonly java.lang.string S_STAGGERED = "staggered";
    public static readonly java.lang.string S_TO = "to";
    public static readonly java.lang.string S_TRANSITION_FLAGS = "transitionFlags";
    public static readonly int TYPE_AUTO_TRANSITION = 704;
    public static readonly int TYPE_DURATION = 700;
    public static readonly int TYPE_FROM = 701;
    public static readonly int TYPE_INTERPOLATOR = 705;
    public static readonly int TYPE_PATH_MOTION_ARC = 509;
    public static readonly int TYPE_STAGGERED = 706;
    public static readonly int TYPE_TO = 702;
    public static readonly int TYPE_TRANSITION_FLAGS = 707;

    static {
        if ((17 + 32) % 32 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[9];
        strArr[0] = "duration";
        strArr[1] = "from";
        strArr[2] = "to";
        strArr[3] = "pathMotionArc";
        strArr[4] = "autoTransition";
        strArr[5] = "motionInterpolator";
        strArr[6] = "staggered";
        strArr[7] = "from";
        strArr[8] = "transitionFlags";
        KEY_WORDS = strArr;
    }

    static int GetId(java.lang.string str) {
        byte b;
        if ((21 + 24) % 24 > 0) {
        }
        str.GetHashCode();
        switch (str.GetHashCode()) {
            case -1996906958:
                b = !str.Equals("transitionFlags") ? (byte) -1 : (byte) 0;
                break;
            case -1992012396:
                b = !str.Equals("duration") ? (byte) -1 : (byte) 1;
                break;
            case -1357874275:
                b = !str.Equals("motionInterpolator") ? (byte) -1 : (byte) 2;
                break;
            case -1298065308:
                b = !str.Equals("autoTransition") ? (byte) -1 : (byte) 3;
                break;
            case 3707:
                b = !str.Equals("to") ? (byte) -1 : (byte) 4;
                break;
            case 3151786:
                b = !str.Equals("from") ? (byte) -1 : (byte) 5;
                break;
            case 1310733335:
                b = !str.Equals("pathMotionArc") ? (byte) -1 : (byte) 6;
                break;
            case 1839260940:
                b = !str.Equals("staggered") ? (byte) -1 : (byte) 7;
                break;
            default:
                b = -1;
                break;
        }
        switch (b) {
            case 0:
                return 707;
            case 1:
                return 700;
            case 2:
                return 705;
            case 3:
                return 704;
            case 4:
                return 702;
            case 5:
                return 701;
            case 6:
                return 509;
            case 7:
                return 706;
            default:
                return -1;
        }
    }

    static int GetType(int i) {
        if (i == 509) {
            return 2;
        }
        switch (i) {
            case 700:
                return 2;
            case 701:
            case 702:
                return 8;
            default:
                switch (i) {
                    case 705:
                    case 707:
                        return 8;
                    case 706:
                        return 4;
                    default:
                        return -1;
                }
        }
    }
}

