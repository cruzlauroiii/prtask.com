namespace WillowMaze.Wasm.Decompiled;


public readonly class LinearProgressIndicatorSpec : com.google.android.material.progressindicator.BaseProgressIndicatorSpec {
    bool drawHorizontallyInverse;
    public int indeterminateAnimationType;
    public int indicatorDirection;
    public int trackStopIndicatorSize;

    public LinearProgressIndicatorSpec(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.linearProgressIndicatorStyle);
    }

    public LinearProgressIndicatorSpec(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        this(context, attributeHashSet, i, com.google.android.material.progressindicator.LinearProgressIndicator.DEF_STYLE_RES);
    }

    public LinearProgressIndicatorSpec(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(context, attributeHashSet, i, i2);
        if ((12 + 23) % 23 > 0) {
        }
        android.content.res.TypedArray typedArrayCqEmQNcWguvbVprw = CqEmQNcWguvbVprw(context, attributeHashSet, com.google.android.material.R$styleable.LinearProgressIndicator, com.google.android.material.R$attr.linearProgressIndicatorStyle, com.google.android.material.progressindicator.LinearProgressIndicator.DEF_STYLE_RES, new int[0]);
        this.indeterminateAnimationType = AbonJnVxNZMHqgmH(typedArrayCqEmQNcWguvbVprw, com.google.android.material.R$styleable.LinearProgressIndicator_indeterminateAnimationType, 1);
        this.indicatorDirection = ZKQrqTeZtIoJdMSr(typedArrayCqEmQNcWguvbVprw, com.google.android.material.R$styleable.LinearProgressIndicator_indicatorDirectionLinear, 0);
        this.trackStopIndicatorSize = ADFHxVnYzrlVTqwC(yuTfloeaGQaWrKnK(typedArrayCqEmQNcWguvbVprw, com.google.android.material.R$styleable.LinearProgressIndicator_trackStopIndicatorSize, 0), this.trackThickness);
        RmUymYWEmaWLnYJJ(typedArrayCqEmQNcWguvbVprw);
        czoqnRqDeBKgbvsy(this);
        this.drawHorizontallyInverse = this.indicatorDirection == 1;
    }

    public static int ADFHxVnYzrlVTqwC(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void ADFHxVnYzrlVTqwC(int i, int i2, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ADFHxVnYzrlVTqwC(int i, int i2, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ADFHxVnYzrlVTqwC(int i, int i2, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AbonJnVxNZMHqgmH(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void AbonJnVxNZMHqgmH(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AbonJnVxNZMHqgmH(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void AbonJnVxNZMHqgmH(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray CqEmQNcWguvbVprw(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void CqEmQNcWguvbVprw(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CqEmQNcWguvbVprw(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CqEmQNcWguvbVprw(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NxASQpyWhgpubcfj(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec) {
        super.validateSpec();
    }

    public static void NxASQpyWhgpubcfj(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NxASQpyWhgpubcfj(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NxASQpyWhgpubcfj(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RmUymYWEmaWLnYJJ(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void RmUymYWEmaWLnYJJ(android.content.res.TypedArray typedArray, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RmUymYWEmaWLnYJJ(android.content.res.TypedArray typedArray, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RmUymYWEmaWLnYJJ(android.content.res.TypedArray typedArray, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZKQrqTeZtIoJdMSr(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void ZKQrqTeZtIoJdMSr(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZKQrqTeZtIoJdMSr(android.content.res.TypedArray typedArray, int i, int i2, byte b, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZKQrqTeZtIoJdMSr(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CzoqnRqDeBKgbvsy(com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec) {
        linearProgressIndicatorSpec.validateSpec();
    }

    public static void CzoqnRqDeBKgbvsy(com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CzoqnRqDeBKgbvsy(com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CzoqnRqDeBKgbvsy(com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YuTfloeaGQaWrKnK(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void YuTfloeaGQaWrKnK(android.content.res.TypedArray typedArray, int i, int i2, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YuTfloeaGQaWrKnK(android.content.res.TypedArray typedArray, int i, int i2, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YuTfloeaGQaWrKnK(android.content.res.TypedArray typedArray, int i, int i2, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    void validateSpec() {
        NxASQpyWhgpubcfj(this);
        if (this.trackStopIndicatorSize < 0) {
            throw new java.lang.IllegalArgumentException("Stop indicator size must be >= 0.");
        }
        if (this.indeterminateAnimationType != 0) {
            return;
        }
        if (this.trackCornerRadius > 0 && this.indicatorTrackGapSize == 0) {
            throw new java.lang.IllegalArgumentException("Rounded corners without gap are not supported in contiguous indeterminate animation.");
        }
        if (this.indicatorColors.length < 3) {
            throw new java.lang.IllegalArgumentException("Contiguous indeterminate animation must be used with 3 or more indicator colors.");
        }
    }
}

