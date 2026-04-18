namespace WillowMaze.Wasm.Decompiled;


class TextScale$1 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly com.google.android.material.internal.TextScale this$0;
    readonly android.widget.Textobject val$view;

    TextScale$1(com.google.android.material.internal.TextScale textScale, android.widget.Textobject textobject) {
        this.this$0 = textScale;
        this.val$view = textobject;
    }

    public static void ATlfKHtJpjMFIuiN(android.widget.Textobject textobject, float f) {
        textobject.setScaleY(f);
    }

    public static void ATlfKHtJpjMFIuiN(android.widget.Textobject textobject, float f, float f2, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ATlfKHtJpjMFIuiN(android.widget.Textobject textobject, float f, int i, char c, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ATlfKHtJpjMFIuiN(android.widget.Textobject textobject, float f, int i, bool z, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LuOxcmyvsJUogzpb(android.widget.Textobject textobject, float f) {
        textobject.setScaleX(f);
    }

    public static void LuOxcmyvsJUogzpb(android.widget.Textobject textobject, float f, short s, float f2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LuOxcmyvsJUogzpb(android.widget.Textobject textobject, float f, short s, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void LuOxcmyvsJUogzpb(android.widget.Textobject textobject, float f, bool z, byte b, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TyXUSSypcpjfcMSF(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void TyXUSSypcpjfcMSF(android.animation.ValueAnimator valueAnimator, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TyXUSSypcpjfcMSF(android.animation.ValueAnimator valueAnimator, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TyXUSSypcpjfcMSF(android.animation.ValueAnimator valueAnimator, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ZmTBIFiSJKSusdDJ(java.lang.float f) {
        return f.floatValue();
    }

    public static void ZmTBIFiSJKSusdDJ(java.lang.float f, int i, byte b, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void ZmTBIFiSJKSusdDJ(java.lang.float f, int i, float f2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZmTBIFiSJKSusdDJ(java.lang.float f, bool z, byte b, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        float fZmTBIFiSJKSusdDJ = ZmTBIFiSJKSusdDJ((java.lang.float) TyXUSSypcpjfcMSF(valueAnimator));
        LuOxcmyvsJUogzpb(this.val$view, fZmTBIFiSJKSusdDJ);
        ATlfKHtJpjMFIuiN(this.val$view, fZmTBIFiSJKSusdDJ);
    }
}

