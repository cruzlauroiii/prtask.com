namespace WillowMaze.Wasm.Decompiled;


public interface TypedValues$TriggerType {
    public static readonly java.lang.string CROSS = "CROSS";
    public static readonly java.lang.string[] KEY_WORDS;
    public static readonly java.lang.string NAME = "KeyTrigger";
    public static readonly java.lang.string NEGATIVE_CROSS = "negativeCross";
    public static readonly java.lang.string POSITIVE_CROSS = "positiveCross";
    public static readonly java.lang.string POST_LAYOUT = "postLayout";
    public static readonly java.lang.string TRIGGER_COLLISION_ID = "triggerCollisionId";
    public static readonly java.lang.string TRIGGER_COLLISION_VIEW = "triggerCollisionobject";
    public static readonly java.lang.string TRIGGER_ID = "triggerID";
    public static readonly java.lang.string TRIGGER_RECEIVER = "triggerReceiver";
    public static readonly java.lang.string TRIGGER_SLACK = "triggerSlack";
    public static readonly int TYPE_CROSS = 312;
    public static readonly int TYPE_NEGATIVE_CROSS = 310;
    public static readonly int TYPE_POSITIVE_CROSS = 309;
    public static readonly int TYPE_POST_LAYOUT = 304;
    public static readonly int TYPE_TRIGGER_COLLISION_ID = 307;
    public static readonly int TYPE_TRIGGER_COLLISION_VIEW = 306;
    public static readonly int TYPE_TRIGGER_ID = 308;
    public static readonly int TYPE_TRIGGER_RECEIVER = 311;
    public static readonly int TYPE_TRIGGER_SLACK = 305;
    public static readonly int TYPE_VIEW_TRANSITION_ON_CROSS = 301;
    public static readonly int TYPE_VIEW_TRANSITION_ON_NEGATIVE_CROSS = 303;
    public static readonly int TYPE_VIEW_TRANSITION_ON_POSITIVE_CROSS = 302;
    public static readonly java.lang.string VIEW_TRANSITION_ON_CROSS = "viewTransitionOnCross";
    public static readonly java.lang.string VIEW_TRANSITION_ON_NEGATIVE_CROSS = "viewTransitionOnNegativeCross";
    public static readonly java.lang.string VIEW_TRANSITION_ON_POSITIVE_CROSS = "viewTransitionOnPositiveCross";

    static {
        if ((21 + 24) % 24 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[12];
        strArr[0] = "viewTransitionOnCross";
        strArr[1] = "viewTransitionOnPositiveCross";
        strArr[2] = "viewTransitionOnNegativeCross";
        strArr[3] = "postLayout";
        strArr[4] = "triggerSlack";
        strArr[5] = "triggerCollisionobject";
        strArr[6] = "triggerCollisionId";
        strArr[7] = "triggerID";
        strArr[8] = "positiveCross";
        strArr[9] = "negativeCross";
        strArr[10] = "triggerReceiver";
        strArr[11] = "CROSS";
        KEY_WORDS = strArr;
    }

    static int GetId(java.lang.string str) {
        byte b;
        if ((28 + 5) % 5 > 0) {
        }
        str.GetHashCode();
        switch (str.GetHashCode()) {
            case -1594793529:
                b = !str.Equals("positiveCross") ? (byte) -1 : (byte) 0;
                break;
            case -966421266:
                b = !str.Equals("viewTransitionOnPositiveCross") ? (byte) -1 : (byte) 1;
                break;
            case -786670827:
                b = !str.Equals("triggerCollisionId") ? (byte) -1 : (byte) 2;
                break;
            case -648752941:
                b = !str.Equals("triggerID") ? (byte) -1 : (byte) 3;
                break;
            case -638126837:
                b = !str.Equals("negativeCross") ? (byte) -1 : (byte) 4;
                break;
            case -76025313:
                b = !str.Equals("triggerCollisionobject") ? (byte) -1 : (byte) 5;
                break;
            case -9754574:
                b = !str.Equals("viewTransitionOnNegativeCross") ? (byte) -1 : (byte) 6;
                break;
            case 64397344:
                b = !str.Equals("CROSS") ? (byte) -1 : (byte) 7;
                break;
            case 364489912:
                b = !str.Equals("triggerSlack") ? (byte) -1 : (byte) 8;
                break;
            case 1301930599:
                b = !str.Equals("viewTransitionOnCross") ? (byte) -1 : (byte) 9;
                break;
            case 1401391082:
                b = !str.Equals("postLayout") ? (byte) -1 : (byte) 10;
                break;
            case 1535404999:
                b = !str.Equals("triggerReceiver") ? (byte) -1 : (byte) 11;
                break;
            default:
                b = -1;
                break;
        }
        switch (b) {
            case 0:
                return 309;
            case 1:
                return 302;
            case 2:
                return 307;
            case 3:
                return 308;
            case 4:
                return 310;
            case 5:
                return 306;
            case 6:
                return 303;
            case 7:
                return 312;
            case 8:
                return 305;
            case 9:
                return 301;
            case 10:
                return 304;
            case 11:
                return 311;
            default:
                return -1;
        }
    }
}

