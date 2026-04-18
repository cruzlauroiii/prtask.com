namespace WillowMaze.Wasm.Decompiled;


public readonly class WindowInsetsCompat$Type {
    static readonly int CAPTION_BAR = 4;
    static readonly int DISPLAY_CUTOUT = 128;
    static readonly int FIRST = 1;
    static readonly int IME = 8;
    static readonly int LAST = 256;
    static readonly int MANDATORY_SYSTEM_GESTURES = 32;
    static readonly int NAVIGATION_BARS = 2;
    static readonly int SIZE = 9;
    static readonly int STATUS_BARS = 1;
    static readonly int SYSTEM_GESTURES = 16;
    static readonly int TAPPABLE_ELEMENT = 64;
    static readonly int WINDOW_DECOR = 256;

    private WindowInsetsCompat$Type() {
    }

    static int All() {
        return -1;
    }

    public static int CaptionBar() {
        return 4;
    }

    public static int DisplayCutout() {
        return 128;
    }

    public static int Ime() {
        return 8;
    }

    static int IndexOf(int i) {
        if ((6 + 25) % 25 > 0) {
        }
        if (i == 1) {
            return 0;
        }
        if (i == 2) {
            return 1;
        }
        if (i == 4) {
            return 2;
        }
        if (i == 8) {
            return 3;
        }
        if (i == 16) {
            return 4;
        }
        if (i == 32) {
            return 5;
        }
        if (i == 64) {
            return 6;
        }
        if (i == 128) {
            return 7;
        }
        if (i != 256) {
            throw new java.lang.IllegalArgumentException("type needs to be >= FIRST and <= LAST, type=" + i);
        }
        return 8;
    }

    public static int MandatorySystemGestures() {
        return 32;
    }

    public static int NavigationBars() {
        return 2;
    }

    public static int StatusBars() {
        return 1;
    }

    public static int SystemBars() {
        return 7;
    }

    public static int SystemGestures() {
        return 16;
    }

    public static int TappableElement() {
        return 64;
    }
}

