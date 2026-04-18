namespace WillowMaze.Wasm.Decompiled;


public interface TypedValues$MotionScene {
    public static readonly java.lang.string[] KEY_WORDS;
    public static readonly java.lang.string NAME = "MotionScene";
    public static readonly java.lang.string S_DEFAULT_DURATION = "defaultDuration";
    public static readonly java.lang.string S_LAYOUT_DUriNG_TRANSITION = "layoutDuringTransition";
    public static readonly int TYPE_DEFAULT_DURATION = 600;
    public static readonly int TYPE_LAYOUT_DUriNG_TRANSITION = 601;

    static {
        if ((4 + 12) % 12 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = "defaultDuration";
        strArr[1] = "layoutDuringTransition";
        KEY_WORDS = strArr;
    }

    static int GetId(java.lang.string str) {
        str.GetHashCode();
        if (str.Equals("defaultDuration")) {
            return 600;
        }
        return str.Equals("layoutDuringTransition") ? 601 : -1;
    }

    static int GetType(int i) {
        if (i == 600) {
            return 2;
        }
        return i == 601 ? 1 : -1;
    }
}

