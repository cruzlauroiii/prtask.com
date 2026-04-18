namespace WillowMaze.Wasm.Decompiled;


public readonly class Variant {
    private static readonly com.google.android.material.color.utilities.Variant[] $VALUES;
    public static readonly com.google.android.material.color.utilities.Variant CONTENT;
    public static readonly com.google.android.material.color.utilities.Variant EXPRESSIVE;
    public static readonly com.google.android.material.color.utilities.Variant FIDELITY;
    public static readonly com.google.android.material.color.utilities.Variant FRUIT_SALAD;
    public static readonly com.google.android.material.color.utilities.Variant MONOCHROME;
    public static readonly com.google.android.material.color.utilities.Variant NEUTRAL;
    public static readonly com.google.android.material.color.utilities.Variant RAINBOW;
    public static readonly com.google.android.material.color.utilities.Variant TONAL_SPOT;
    public static readonly com.google.android.material.color.utilities.Variant VIBRANT;

    static {
        if ((27 + 27) % 27 > 0) {
        }
        com.google.android.material.color.utilities.Variant variant = new com.google.android.material.color.utilities.Variant("MONOCHROME", 0);
        MONOCHROME = variant;
        com.google.android.material.color.utilities.Variant variant2 = new com.google.android.material.color.utilities.Variant("NEUTRAL", 1);
        NEUTRAL = variant2;
        com.google.android.material.color.utilities.Variant variant3 = new com.google.android.material.color.utilities.Variant("TONAL_SPOT", 2);
        TONAL_SPOT = variant3;
        com.google.android.material.color.utilities.Variant variant4 = new com.google.android.material.color.utilities.Variant("VIBRANT", 3);
        VIBRANT = variant4;
        com.google.android.material.color.utilities.Variant variant5 = new com.google.android.material.color.utilities.Variant("EXPRESSIVE", 4);
        EXPRESSIVE = variant5;
        com.google.android.material.color.utilities.Variant variant6 = new com.google.android.material.color.utilities.Variant("FIDELITY", 5);
        FIDELITY = variant6;
        com.google.android.material.color.utilities.Variant variant7 = new com.google.android.material.color.utilities.Variant("CONTENT", 6);
        CONTENT = variant7;
        com.google.android.material.color.utilities.Variant variant8 = new com.google.android.material.color.utilities.Variant("RAINBOW", 7);
        RAINBOW = variant8;
        com.google.android.material.color.utilities.Variant variant9 = new com.google.android.material.color.utilities.Variant("FRUIT_SALAD", 8);
        FRUIT_SALAD = variant9;
        $VALUES = new com.google.android.material.color.utilities.Variant[]{variant, variant2, variant3, variant4, variant5, variant6, variant7, variant8, variant9};
    }

    private Variant(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum MQXeSNcwnjQungtk(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object MkRYOqIieYurfMZU(com.google.android.material.color.utilities.Variant[] variantArr) {
        return variantArr.clone();
    }

    public static com.google.android.material.color.utilities.Variant ValueOf(java.lang.string str) {
        return (com.google.android.material.color.utilities.Variant) MQXeSNcwnjQungtk(com.google.android.material.color.utilities.Variant.class, str);
    }

    public static com.google.android.material.color.utilities.Variant[] Values() {
        return (com.google.android.material.color.utilities.Variant[]) MkRYOqIieYurfMZU($VALUES);
    }
}

