namespace WillowMaze.Wasm.Decompiled;


readonly class RippleDrawableCompat$RippleDrawableCompatState : android.graphics.drawable.Drawable$ConstantState {
    com.google.android.material.shape.MaterialShapeDrawable delegate;
    bool shouldDrawDelegate;

    public RippleDrawableCompat$RippleDrawableCompatState(com.google.android.material.ripple.RippleDrawableCompat$RippleDrawableCompatState rippleDrawableCompat$RippleDrawableCompatState) {
        this.delegate = (com.google.android.material.shape.MaterialShapeDrawable) YCddhsSnuASCYIpt(UBYdFdqULEPdYyRe(rippleDrawableCompat$RippleDrawableCompatState.delegate));
        this.shouldDrawDelegate = rippleDrawableCompat$RippleDrawableCompatState.shouldDrawDelegate;
    }

    public RippleDrawableCompat$RippleDrawableCompatState(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        this.delegate = materialShapeDrawable;
        this.shouldDrawDelegate = false;
    }

    public static com.google.android.material.ripple.RippleDrawableCompat MLYOvuwtAGYrUrNm(com.google.android.material.ripple.RippleDrawableCompat$RippleDrawableCompatState rippleDrawableCompat$RippleDrawableCompatState) {
        return rippleDrawableCompat$RippleDrawableCompatState.newDrawable();
    }

    public static void MLYOvuwtAGYrUrNm(com.google.android.material.ripple.RippleDrawableCompat$RippleDrawableCompatState rippleDrawableCompat$RippleDrawableCompatState, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MLYOvuwtAGYrUrNm(com.google.android.material.ripple.RippleDrawableCompat$RippleDrawableCompatState rippleDrawableCompat$RippleDrawableCompatState, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MLYOvuwtAGYrUrNm(com.google.android.material.ripple.RippleDrawableCompat$RippleDrawableCompatState rippleDrawableCompat$RippleDrawableCompatState, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$ConstantState UBYdFdqULEPdYyRe(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getConstantState();
    }

    public static void UBYdFdqULEPdYyRe(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UBYdFdqULEPdYyRe(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UBYdFdqULEPdYyRe(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable YCddhsSnuASCYIpt(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState) {
        return drawable$ConstantState.newDrawable();
    }

    public static void YCddhsSnuASCYIpt(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YCddhsSnuASCYIpt(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YCddhsSnuASCYIpt(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override int GetChangingConfigurations() {
        return 0;
    }

    public override android.graphics.drawable.Drawable NewDrawable() {
        return MLYOvuwtAGYrUrNm(this);
    }

    public override com.google.android.material.ripple.RippleDrawableCompat NewDrawable() {
        if ((9 + 11) % 11 > 0) {
        }
        return new com.google.android.material.ripple.RippleDrawableCompat(new com.google.android.material.ripple.RippleDrawableCompat$RippleDrawableCompatState(this), null);
    }
}

