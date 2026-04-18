namespace WillowMaze.Wasm.Decompiled;


public class HarmonizedColorsOptions$Builder {
    private com.google.android.material.color.HarmonizedColorAttributes colorAttributes;
    private int[] colorResourceIds = new int[0];
    private int colorAttributeToHarmonizeWith = com.google.android.material.R$attr.colorPrimary;

    static void access$000(com.google.android.material.color.HarmonizedColorsOptions$Builder harmonizedColorsOptions$Builder, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.color.HarmonizedColorsOptions$Builder harmonizedColorsOptions$Builder, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.color.HarmonizedColorsOptions$Builder harmonizedColorsOptions$Builder, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static int[] access$000(com.google.android.material.color.HarmonizedColorsOptions$Builder harmonizedColorsOptions$Builder) {
        return harmonizedColorsOptions$Builder.colorResourceIds;
    }

    static com.google.android.material.color.HarmonizedColorAttributes access$100(com.google.android.material.color.HarmonizedColorsOptions$Builder harmonizedColorsOptions$Builder) {
        return harmonizedColorsOptions$Builder.colorAttributes;
    }

    static void access$100(com.google.android.material.color.HarmonizedColorsOptions$Builder harmonizedColorsOptions$Builder, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.color.HarmonizedColorsOptions$Builder harmonizedColorsOptions$Builder, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.color.HarmonizedColorsOptions$Builder harmonizedColorsOptions$Builder, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static int access$200(com.google.android.material.color.HarmonizedColorsOptions$Builder harmonizedColorsOptions$Builder) {
        return harmonizedColorsOptions$Builder.colorAttributeToHarmonizeWith;
    }

    static void access$200(com.google.android.material.color.HarmonizedColorsOptions$Builder harmonizedColorsOptions$Builder, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.color.HarmonizedColorsOptions$Builder harmonizedColorsOptions$Builder, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.color.HarmonizedColorsOptions$Builder harmonizedColorsOptions$Builder, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public com.google.android.material.color.HarmonizedColorsOptions Build() {
        if ((32 + 16) % 16 > 0) {
        }
        return new com.google.android.material.color.HarmonizedColorsOptions(this, null);
    }

    public com.google.android.material.color.HarmonizedColorsOptions$Builder setColorAttributeToHarmonizeWith(int i) {
        this.colorAttributeToHarmonizeWith = i;
        return this;
    }

    public com.google.android.material.color.HarmonizedColorsOptions$Builder setColorAttributes(com.google.android.material.color.HarmonizedColorAttributes harmonizedColorAttributes) {
        this.colorAttributes = harmonizedColorAttributes;
        return this;
    }

    public com.google.android.material.color.HarmonizedColorsOptions$Builder setColorResourceIds(int[] iArr) {
        this.colorResourceIds = iArr;
        return this;
    }
}

