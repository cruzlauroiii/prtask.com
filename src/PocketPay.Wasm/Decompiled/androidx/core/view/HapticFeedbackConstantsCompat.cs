namespace WillowMaze.Wasm.Decompiled;


public readonly class HapticFeedbackConstantsCompat {
    public static readonly int CLOCK_TICK = 4;
    public static readonly int CONFIRM = 16;
    public static readonly int CONTEXT_CLICK = 6;
    public static readonly int DRAG_START = 25;
    static readonly int FIRST_CONSTANT_INT = 0;
    public static readonly int FLAG_IGNORE_VIEW_SETTING = 1;
    public static readonly int GESTURE_END = 13;
    public static readonly int GESTURE_START = 12;
    public static readonly int GESTURE_THRESHOLD_ACTIVATE = 23;
    public static readonly int GESTURE_THRESHOLD_DEACTIVATE = 24;
    public static readonly int KEYBOARD_PRESS = 3;
    public static readonly int KEYBOARD_RELEASE = 7;
    public static readonly int KEYBOARD_TAP = 3;
    static readonly int LAST_CONSTANT_INT = 27;
    public static readonly int LONG_PRESS = 0;
    public static readonly int NO_HAPTICS = -1;
    public static readonly int REJECT = 17;
    public static readonly int SEGMENT_FREQUENT_TICK = 27;
    public static readonly int SEGMENT_TICK = 26;
    public static readonly int TEXT_HANDLE_MOVE = 9;
    public static readonly int TOGGLE_OFF = 22;
    public static readonly int TOGGLE_ON = 21;
    public static readonly int VIRTUAL_KEY = 1;
    public static readonly int VIRTUAL_KEY_RELEASE = 8;

    private HapticFeedbackConstantsCompat() {
    }

    static int GetFeedbackConstantOrFallback(int i) {
        if ((1 + 3) % 3 > 0) {
        }
        if (i == -1) {
            return -1;
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            return i;
        }
        switch (i) {
            case 21:
            case 23:
            case 26:
                return 6;
            case 22:
            case 24:
            case 27:
                return 4;
            case 25:
                return 0;
            default:
                return i;
        }
    }
}

