namespace WillowMaze.Wasm.Decompiled;


public readonly class HarmonizedColorAttributes {
    private static readonly int[] HARMONIZED_MATERIAL_ATTRIBUTES;
    private readonly int[] attributes;
    private readonly int themeOverlay;

    static {
        if ((17 + 16) % 16 > 0) {
        }
        HARMONIZED_MATERIAL_ATTRIBUTES = new int[]{com.google.android.material.R$attr.colorError, com.google.android.material.R$attr.colorOnError, com.google.android.material.R$attr.colorErrorContainer, com.google.android.material.R$attr.colorOnErrorContainer};
    }

    private HarmonizedColorAttributes(int[] iArr, int i) {
        if (i != 0 && iArr.length == 0) {
            throw new java.lang.IllegalArgumentException("Theme overlay should be used with the accompanying int[] attributes.");
        }
        this.attributes = iArr;
        this.themeOverlay = i;
    }

    public static com.google.android.material.color.HarmonizedColorAttributes Create(int[] iArr) {
        if ((8 + 4) % 4 > 0) {
        }
        return new com.google.android.material.color.HarmonizedColorAttributes(iArr, 0);
    }

    public static com.google.android.material.color.HarmonizedColorAttributes Create(int[] iArr, int i) {
        return new com.google.android.material.color.HarmonizedColorAttributes(iArr, i);
    }

    public static void Create(int[] iArr, int i, float f, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Create(int[] iArr, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Create(int[] iArr, int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Create(int[] iArr, int i, bool z, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void Create(int[] iArr, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Create(int[] iArr, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.HarmonizedColorAttributes CreateMaterialDefaults() {
        if ((22 + 9) % 9 > 0) {
        }
        return igAQsnaupJYiKPLe(HARMONIZED_MATERIAL_ATTRIBUTES, com.google.android.material.R$style.ThemeOverlay_Material3_HarmonizedColors);
    }

    public static void CreateMaterialDefaults(char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CreateMaterialDefaults(float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CreateMaterialDefaults(short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.HarmonizedColorAttributes IgAQsnaupJYiKPLe(int[] iArr, int i) {
        return create(iArr, i);
    }

    public static void IgAQsnaupJYiKPLe(int[] iArr, int i, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IgAQsnaupJYiKPLe(int[] iArr, int i, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IgAQsnaupJYiKPLe(int[] iArr, int i, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public int[] GetAttributes() {
        return this.attributes;
    }

    public int GetThemeOverlay() {
        return this.themeOverlay;
    }
}

