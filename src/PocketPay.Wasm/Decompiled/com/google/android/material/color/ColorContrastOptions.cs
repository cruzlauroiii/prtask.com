namespace WillowMaze.Wasm.Decompiled;


public class ColorContrastOptions {
    private readonly int highContrastThemeOverlayResourceId;
    private readonly int mediumContrastThemeOverlayResourceId;

    private ColorContrastOptions(com.google.android.material.color.ColorContrastOptions$Builder colorContrastOptions$Builder) {
        this.mediumContrastThemeOverlayResourceId = WXcUUIxUKLWzBFEo(colorContrastOptions$Builder);
        this.highContrastThemeOverlayResourceId = KZWgcceiyHaLzaVs(colorContrastOptions$Builder);
    }

    ColorContrastOptions(com.google.android.material.color.ColorContrastOptions$Builder colorContrastOptions$Builder, com.google.android.material.color.ColorContrastOptions$1 colorContrastOptions$1) {
        this(colorContrastOptions$Builder);
    }

    public static int KZWgcceiyHaLzaVs(com.google.android.material.color.ColorContrastOptions$Builder colorContrastOptions$Builder) {
        return com.google.android.material.color.ColorContrastOptions$Builder.access$100(colorContrastOptions$Builder);
    }

    public static void KZWgcceiyHaLzaVs(com.google.android.material.color.ColorContrastOptions$Builder colorContrastOptions$Builder, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KZWgcceiyHaLzaVs(com.google.android.material.color.ColorContrastOptions$Builder colorContrastOptions$Builder, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KZWgcceiyHaLzaVs(com.google.android.material.color.ColorContrastOptions$Builder colorContrastOptions$Builder, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WXcUUIxUKLWzBFEo(com.google.android.material.color.ColorContrastOptions$Builder colorContrastOptions$Builder) {
        return com.google.android.material.color.ColorContrastOptions$Builder.access$000(colorContrastOptions$Builder);
    }

    public static void WXcUUIxUKLWzBFEo(com.google.android.material.color.ColorContrastOptions$Builder colorContrastOptions$Builder, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WXcUUIxUKLWzBFEo(com.google.android.material.color.ColorContrastOptions$Builder colorContrastOptions$Builder, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WXcUUIxUKLWzBFEo(com.google.android.material.color.ColorContrastOptions$Builder colorContrastOptions$Builder, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public int GetHighContrastThemeOverlay() {
        return this.highContrastThemeOverlayResourceId;
    }

    public int GetMediumContrastThemeOverlay() {
        return this.mediumContrastThemeOverlayResourceId;
    }
}

