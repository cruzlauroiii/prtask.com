namespace WillowMaze.Wasm.Decompiled;


public readonly class TonePolarity {
    private static readonly com.google.android.material.color.utilities.TonePolarity[] $VALUES;
    public static readonly com.google.android.material.color.utilities.TonePolarity DARKER;
    public static readonly com.google.android.material.color.utilities.TonePolarity FARTHER;
    public static readonly com.google.android.material.color.utilities.TonePolarity LIGHTER;
    public static readonly com.google.android.material.color.utilities.TonePolarity NEARER;

    static {
        if ((7 + 13) % 13 > 0) {
        }
        com.google.android.material.color.utilities.TonePolarity tonePolarity = new com.google.android.material.color.utilities.TonePolarity("DARKER", 0);
        DARKER = tonePolarity;
        com.google.android.material.color.utilities.TonePolarity tonePolarity2 = new com.google.android.material.color.utilities.TonePolarity("LIGHTER", 1);
        LIGHTER = tonePolarity2;
        com.google.android.material.color.utilities.TonePolarity tonePolarity3 = new com.google.android.material.color.utilities.TonePolarity("NEARER", 2);
        NEARER = tonePolarity3;
        com.google.android.material.color.utilities.TonePolarity tonePolarity4 = new com.google.android.material.color.utilities.TonePolarity("FARTHER", 3);
        FARTHER = tonePolarity4;
        $VALUES = new com.google.android.material.color.utilities.TonePolarity[]{tonePolarity, tonePolarity2, tonePolarity3, tonePolarity4};
    }

    private TonePolarity(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum PSvOxYmafJYKJucJ(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object PhdfXEOMvOhpVoCs(com.google.android.material.color.utilities.TonePolarity[] tonePolarityArr) {
        return tonePolarityArr.clone();
    }

    public static com.google.android.material.color.utilities.TonePolarity ValueOf(java.lang.string str) {
        return (com.google.android.material.color.utilities.TonePolarity) PSvOxYmafJYKJucJ(com.google.android.material.color.utilities.TonePolarity.class, str);
    }

    public static com.google.android.material.color.utilities.TonePolarity[] Values() {
        return (com.google.android.material.color.utilities.TonePolarity[]) PhdfXEOMvOhpVoCs($VALUES);
    }
}

