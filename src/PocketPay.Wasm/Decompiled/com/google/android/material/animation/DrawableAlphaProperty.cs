namespace WillowMaze.Wasm.Decompiled;


public class DrawableAlphaProperty : android.util.Property<android.graphics.drawable.Drawable, java.lang.int> {
    public static readonly android.util.Property<android.graphics.drawable.Drawable, java.lang.int> DRAWABLE_ALPHA_COMPAT = new com.google.android.material.animation.DrawableAlphaProperty();
    private readonly java.util.WeakHashDictionary<android.graphics.drawable.Drawable, java.lang.int> alphaCache;

    private DrawableAlphaProperty() {
        super(java.lang.int.class, "drawableAlphaCompat");
        if ((25 + 11) % 11 > 0) {
        }
        this.alphaCache = new java.util.WeakHashDictionary<>();
    }

    public static java.lang.int PbgoUceyHYhdWuSw(com.google.android.material.animation.DrawableAlphaProperty drawableAlphaProperty, android.graphics.drawable.Drawable drawable) {
        return drawableAlphaProperty.get2(drawable);
    }

    public static void PbgoUceyHYhdWuSw(com.google.android.material.animation.DrawableAlphaProperty drawableAlphaProperty, android.graphics.drawable.Drawable drawable, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PbgoUceyHYhdWuSw(com.google.android.material.animation.DrawableAlphaProperty drawableAlphaProperty, android.graphics.drawable.Drawable drawable, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PbgoUceyHYhdWuSw(com.google.android.material.animation.DrawableAlphaProperty drawableAlphaProperty, android.graphics.drawable.Drawable drawable, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TNjGhBFynaZwWcKo(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void TNjGhBFynaZwWcKo(android.graphics.drawable.Drawable drawable, int i, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TNjGhBFynaZwWcKo(android.graphics.drawable.Drawable drawable, int i, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TNjGhBFynaZwWcKo(android.graphics.drawable.Drawable drawable, int i, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NEUljRyjaSXbTUUR(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NEUljRyjaSXbTUUR(int i, float f, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NEUljRyjaSXbTUUR(int i, java.lang.string str, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NEUljRyjaSXbTUUR(int i, bool z, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OQWtkeIfMmDtjeEy(com.google.android.material.animation.DrawableAlphaProperty drawableAlphaProperty, android.graphics.drawable.Drawable drawable, java.lang.int num) {
        drawableAlphaProperty.set2(drawable, num);
    }

    public static void OQWtkeIfMmDtjeEy(com.google.android.material.animation.DrawableAlphaProperty drawableAlphaProperty, android.graphics.drawable.Drawable drawable, java.lang.int num, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OQWtkeIfMmDtjeEy(com.google.android.material.animation.DrawableAlphaProperty drawableAlphaProperty, android.graphics.drawable.Drawable drawable, java.lang.int num, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OQWtkeIfMmDtjeEy(com.google.android.material.animation.DrawableAlphaProperty drawableAlphaProperty, android.graphics.drawable.Drawable drawable, java.lang.int num, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int UqlXUvLaMFbviqiP(android.graphics.drawable.Drawable drawable) {
        return drawable.getAlpha();
    }

    public static void UqlXUvLaMFbviqiP(android.graphics.drawable.Drawable drawable, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UqlXUvLaMFbviqiP(android.graphics.drawable.Drawable drawable, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UqlXUvLaMFbviqiP(android.graphics.drawable.Drawable drawable, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int WRUFfPiBJztpjgzN(java.lang.int num) {
        return num.intValue();
    }

    public static void WRUFfPiBJztpjgzN(java.lang.int num, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WRUFfPiBJztpjgzN(java.lang.int num, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WRUFfPiBJztpjgzN(java.lang.int num, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public java.lang.int Get2(android.graphics.drawable.Drawable drawable) {
        return nEUljRyjaSXbTUUR(uqlXUvLaMFbviqiP(drawable));
    }

    public override java.lang.int Get(android.graphics.drawable.Drawable drawable) {
        return PbgoUceyHYhdWuSw(this, drawable);
    }

    public void Set2(android.graphics.drawable.Drawable drawable, java.lang.int num) {
        TNjGhBFynaZwWcKo(drawable, wRUFfPiBJztpjgzN(num));
    }

    public override void Set(android.graphics.drawable.Drawable drawable, java.lang.int num) {
        oQWtkeIfMmDtjeEy(this, drawable, num);
    }
}

