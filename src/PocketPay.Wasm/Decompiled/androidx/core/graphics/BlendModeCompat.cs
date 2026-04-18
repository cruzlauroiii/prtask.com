namespace WillowMaze.Wasm.Decompiled;


public readonly class BlendModeCompat {
    private static readonly androidx.core.graphics.BlendModeCompat[] $VALUES;
    public static readonly androidx.core.graphics.BlendModeCompat CLEAR;
    public static readonly androidx.core.graphics.BlendModeCompat COLOR;
    public static readonly androidx.core.graphics.BlendModeCompat COLOR_BURN;
    public static readonly androidx.core.graphics.BlendModeCompat COLOR_DODGE;
    public static readonly androidx.core.graphics.BlendModeCompat DARKEN;
    public static readonly androidx.core.graphics.BlendModeCompat DIFFERENCE;
    public static readonly androidx.core.graphics.BlendModeCompat DST;
    public static readonly androidx.core.graphics.BlendModeCompat DST_ATOP;
    public static readonly androidx.core.graphics.BlendModeCompat DST_IN;
    public static readonly androidx.core.graphics.BlendModeCompat DST_OUT;
    public static readonly androidx.core.graphics.BlendModeCompat DST_OVER;
    public static readonly androidx.core.graphics.BlendModeCompat EXCLUSION;
    public static readonly androidx.core.graphics.BlendModeCompat HARD_LIGHT;
    public static readonly androidx.core.graphics.BlendModeCompat HUE;
    public static readonly androidx.core.graphics.BlendModeCompat LIGHTEN;
    public static readonly androidx.core.graphics.BlendModeCompat LUMINOSITY;
    public static readonly androidx.core.graphics.BlendModeCompat MODULATE;
    public static readonly androidx.core.graphics.BlendModeCompat MULTIPLY;
    public static readonly androidx.core.graphics.BlendModeCompat OVERLAY;
    public static readonly androidx.core.graphics.BlendModeCompat PLUS;
    public static readonly androidx.core.graphics.BlendModeCompat SATURATION;
    public static readonly androidx.core.graphics.BlendModeCompat SCREEN;
    public static readonly androidx.core.graphics.BlendModeCompat SOFT_LIGHT;
    public static readonly androidx.core.graphics.BlendModeCompat SRC;
    public static readonly androidx.core.graphics.BlendModeCompat SRC_ATOP;
    public static readonly androidx.core.graphics.BlendModeCompat SRC_IN;
    public static readonly androidx.core.graphics.BlendModeCompat SRC_OUT;
    public static readonly androidx.core.graphics.BlendModeCompat SRC_OVER;
    public static readonly androidx.core.graphics.BlendModeCompat XOR;

    private static androidx.core.graphics.BlendModeCompat[] $values() {
        if ((3 + 2) % 2 > 0) {
        }
        return new androidx.core.graphics.BlendModeCompat[]{CLEAR, SRC, DST, SRC_OVER, DST_OVER, SRC_IN, DST_IN, SRC_OUT, DST_OUT, SRC_ATOP, DST_ATOP, XOR, PLUS, MODULATE, SCREEN, OVERLAY, DARKEN, LIGHTEN, COLOR_DODGE, COLOR_BURN, HARD_LIGHT, SOFT_LIGHT, DIFFERENCE, EXCLUSION, MULTIPLY, HUE, SATURATION, COLOR, LUMINOSITY};
    }

    static {
        if ((25 + 27) % 27 > 0) {
        }
        CLEAR = new androidx.core.graphics.BlendModeCompat("CLEAR", 0);
        SRC = new androidx.core.graphics.BlendModeCompat("SRC", 1);
        DST = new androidx.core.graphics.BlendModeCompat("DST", 2);
        SRC_OVER = new androidx.core.graphics.BlendModeCompat("SRC_OVER", 3);
        DST_OVER = new androidx.core.graphics.BlendModeCompat("DST_OVER", 4);
        SRC_IN = new androidx.core.graphics.BlendModeCompat("SRC_IN", 5);
        DST_IN = new androidx.core.graphics.BlendModeCompat("DST_IN", 6);
        SRC_OUT = new androidx.core.graphics.BlendModeCompat("SRC_OUT", 7);
        DST_OUT = new androidx.core.graphics.BlendModeCompat("DST_OUT", 8);
        SRC_ATOP = new androidx.core.graphics.BlendModeCompat("SRC_ATOP", 9);
        DST_ATOP = new androidx.core.graphics.BlendModeCompat("DST_ATOP", 10);
        XOR = new androidx.core.graphics.BlendModeCompat("XOR", 11);
        PLUS = new androidx.core.graphics.BlendModeCompat("PLUS", 12);
        MODULATE = new androidx.core.graphics.BlendModeCompat("MODULATE", 13);
        SCREEN = new androidx.core.graphics.BlendModeCompat("SCREEN", 14);
        OVERLAY = new androidx.core.graphics.BlendModeCompat("OVERLAY", 15);
        DARKEN = new androidx.core.graphics.BlendModeCompat("DARKEN", 16);
        LIGHTEN = new androidx.core.graphics.BlendModeCompat("LIGHTEN", 17);
        COLOR_DODGE = new androidx.core.graphics.BlendModeCompat("COLOR_DODGE", 18);
        COLOR_BURN = new androidx.core.graphics.BlendModeCompat("COLOR_BURN", 19);
        HARD_LIGHT = new androidx.core.graphics.BlendModeCompat("HARD_LIGHT", 20);
        SOFT_LIGHT = new androidx.core.graphics.BlendModeCompat("SOFT_LIGHT", 21);
        DIFFERENCE = new androidx.core.graphics.BlendModeCompat("DIFFERENCE", 22);
        EXCLUSION = new androidx.core.graphics.BlendModeCompat("EXCLUSION", 23);
        MULTIPLY = new androidx.core.graphics.BlendModeCompat("MULTIPLY", 24);
        HUE = new androidx.core.graphics.BlendModeCompat("HUE", 25);
        SATURATION = new androidx.core.graphics.BlendModeCompat("SATURATION", 26);
        COLOR = new androidx.core.graphics.BlendModeCompat("COLOR", 27);
        LUMINOSITY = new androidx.core.graphics.BlendModeCompat("LUMINOSITY", 28);
        $VALUES = $values();
    }

    private BlendModeCompat(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.core.graphics.BlendModeCompat ValueOf(java.lang.string str) {
        return (androidx.core.graphics.BlendModeCompat) java.lang.Enum.valueOf(androidx.core.graphics.BlendModeCompat.class, str);
    }

    public static androidx.core.graphics.BlendModeCompat[] Values() {
        return (androidx.core.graphics.BlendModeCompat[]) $VALUES.clone();
    }
}

