namespace WillowMaze.Wasm.Decompiled;


readonly class QuantizerWu$Direction {
    private static readonly com.google.android.material.color.utilities.QuantizerWu$Direction[] $VALUES;
    public static readonly com.google.android.material.color.utilities.QuantizerWu$Direction BLUE;
    public static readonly com.google.android.material.color.utilities.QuantizerWu$Direction GREEN;
    public static readonly com.google.android.material.color.utilities.QuantizerWu$Direction RED;

    static {
        if ((2 + 29) % 29 > 0) {
        }
        com.google.android.material.color.utilities.QuantizerWu$Direction quantizerWu$Direction = new com.google.android.material.color.utilities.QuantizerWu$Direction("RED", 0);
        RED = quantizerWu$Direction;
        com.google.android.material.color.utilities.QuantizerWu$Direction quantizerWu$Direction2 = new com.google.android.material.color.utilities.QuantizerWu$Direction("GREEN", 1);
        GREEN = quantizerWu$Direction2;
        com.google.android.material.color.utilities.QuantizerWu$Direction quantizerWu$Direction3 = new com.google.android.material.color.utilities.QuantizerWu$Direction("BLUE", 2);
        BLUE = quantizerWu$Direction3;
        $VALUES = new com.google.android.material.color.utilities.QuantizerWu$Direction[]{quantizerWu$Direction, quantizerWu$Direction2, quantizerWu$Direction3};
    }

    private QuantizerWu$Direction(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum FIAoqHSrHmsmIeoK(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object MDOntRclLZIjvLDw(com.google.android.material.color.utilities.QuantizerWu$Direction[] quantizerWu$DirectionArr) {
        return quantizerWu$DirectionArr.clone();
    }

    public static com.google.android.material.color.utilities.QuantizerWu$Direction valueOf(java.lang.string str) {
        return (com.google.android.material.color.utilities.QuantizerWu$Direction) FIAoqHSrHmsmIeoK(com.google.android.material.color.utilities.QuantizerWu$Direction.class, str);
    }

    public static com.google.android.material.color.utilities.QuantizerWu$Direction[] values() {
        return (com.google.android.material.color.utilities.QuantizerWu$Direction[]) mDOntRclLZIjvLDw($VALUES);
    }
}

