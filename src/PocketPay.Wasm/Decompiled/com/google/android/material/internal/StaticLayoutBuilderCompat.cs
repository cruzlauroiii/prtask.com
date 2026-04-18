namespace WillowMaze.Wasm.Decompiled;


readonly class StaticLayoutBuilderCompat {
    static readonly int DEFAULT_HYPHENATION_FREQUENCY = 1;
    static readonly float DEFAULT_LINE_SPACING_ADD = 0.0f;
    static readonly float DEFAULT_LINE_SPACING_MULTIPLIER = 1.0f;
    private static readonly java.lang.string TEXT_DIRS_CLASS = "android.text.TextDirectionHeuristics";
    private static readonly java.lang.string TEXT_DIR_CLASS = "android.text.TextDirectionHeuristic";
    private static readonly java.lang.string TEXT_DIR_CLASS_LTR = "LTR";
    private static readonly java.lang.string TEXT_DIR_CLASS_RTL = "RTL";
    private static java.lang.reflect.Constructor<android.text.StaticLayout> constructor;
    private static bool initialized;
    private static java.lang.object textDirection;
    private int end;
    private bool isRtl;
    private readonly android.text.TextPaint paint;
    private java.lang.CharSequence source;
    private com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer;
    private readonly int width;
    private int start = 0;
    private android.text.Layout$Alignment alignment = android.text.Layout$Alignment.ALIGN_NORMAL;
    private int maxLines = int.MAX_VALUE;
    private float lineSpacingAdd = 0.0f;
    private float lineSpacingMultiplier = 1.0f;
    private int hyphenationFrequency = DEFAULT_HYPHENATION_FREQUENCY;
    private bool includePad = true;
    private android.text.TextUtils$TruncateAt ellipsize = null;

    private StaticLayoutBuilderCompat(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, int i) {
        this.source = charSequence;
        this.paint = textPaint;
        this.width = i;
        this.end = BWzSeisEQvwpZcYw(charSequence);
    }

    public static android.text.StaticLayout$Builder AVqpeXJEXGCObbNU(android.text.StaticLayout$Builder staticLayout$Builder, android.text.Layout$Alignment layout$Alignment) {
        return staticLayout$Builder.setAlignment(layout$Alignment);
    }

    public static void AVqpeXJEXGCObbNU(android.text.StaticLayout$Builder staticLayout$Builder, android.text.Layout$Alignment layout$Alignment, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AVqpeXJEXGCObbNU(android.text.StaticLayout$Builder staticLayout$Builder, android.text.Layout$Alignment layout$Alignment, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AVqpeXJEXGCObbNU(android.text.StaticLayout$Builder staticLayout$Builder, android.text.Layout$Alignment layout$Alignment, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.text.StaticLayout$Builder BLHLeTauCgXRuxhN(android.text.StaticLayout$Builder staticLayout$Builder, int i) {
        return staticLayout$Builder.setMaxLines(i);
    }

    public static void BLHLeTauCgXRuxhN(android.text.StaticLayout$Builder staticLayout$Builder, int i, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BLHLeTauCgXRuxhN(android.text.StaticLayout$Builder staticLayout$Builder, int i, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BLHLeTauCgXRuxhN(android.text.StaticLayout$Builder staticLayout$Builder, int i, short s, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int BWzSeisEQvwpZcYw(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void BWzSeisEQvwpZcYw(java.lang.CharSequence charSequence, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BWzSeisEQvwpZcYw(java.lang.CharSequence charSequence, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BWzSeisEQvwpZcYw(java.lang.CharSequence charSequence, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.text.StaticLayout$Builder EQhuewJorapOxCoX(android.text.StaticLayout$Builder staticLayout$Builder, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        return staticLayout$Builder.setEllipsize(textUtils$TruncateAt);
    }

    public static void EQhuewJorapOxCoX(android.text.StaticLayout$Builder staticLayout$Builder, android.text.TextUtils$TruncateAt textUtils$TruncateAt, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EQhuewJorapOxCoX(android.text.StaticLayout$Builder staticLayout$Builder, android.text.TextUtils$TruncateAt textUtils$TruncateAt, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EQhuewJorapOxCoX(android.text.StaticLayout$Builder staticLayout$Builder, android.text.TextUtils$TruncateAt textUtils$TruncateAt, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence NpsozKjCYOXRvBep(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, float f, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        return android.text.TextUtils.ellipsize(charSequence, textPaint, f, textUtils$TruncateAt);
    }

    public static void NpsozKjCYOXRvBep(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, float f, android.text.TextUtils$TruncateAt textUtils$TruncateAt, char c, byte b, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NpsozKjCYOXRvBep(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, float f, android.text.TextUtils$TruncateAt textUtils$TruncateAt, float f2, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NpsozKjCYOXRvBep(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, float f, android.text.TextUtils$TruncateAt textUtils$TruncateAt, float f2, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.reflect.Constructor OcdgqwqgdvheakVX(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getDeclaredConstructor(clsArr);
    }

    public static void OcdgqwqgdvheakVX(java.lang.Class cls, java.lang.Class[] clsArr, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OcdgqwqgdvheakVX(java.lang.Class cls, java.lang.Class[] clsArr, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OcdgqwqgdvheakVX(java.lang.Class cls, java.lang.Class[] clsArr, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.text.StaticLayout$Builder TKvOkmYnpBcbijAz(android.text.StaticLayout$Builder staticLayout$Builder, bool z) {
        return staticLayout$Builder.setIncludePad(z);
    }

    public static void TKvOkmYnpBcbijAz(android.text.StaticLayout$Builder staticLayout$Builder, bool z, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TKvOkmYnpBcbijAz(android.text.StaticLayout$Builder staticLayout$Builder, bool z, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TKvOkmYnpBcbijAz(android.text.StaticLayout$Builder staticLayout$Builder, bool z, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int TyXIAymDqJzAfQqL(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void TyXIAymDqJzAfQqL(int i, int i2, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TyXIAymDqJzAfQqL(int i, int i2, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TyXIAymDqJzAfQqL(int i, int i2, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VKnqxsOHmqiBkHbA(java.lang.reflect.Constructor constructor2, bool z) {
        constructor2.setAccessible(z);
    }

    public static void VKnqxsOHmqiBkHbA(java.lang.reflect.Constructor constructor2, bool z, char c, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VKnqxsOHmqiBkHbA(java.lang.reflect.Constructor constructor2, bool z, float f, char c, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VKnqxsOHmqiBkHbA(java.lang.reflect.Constructor constructor2, bool z, float f, java.lang.string str, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static android.text.StaticLayout ZGSZUCntkqTzpxtG(android.text.StaticLayout$Builder staticLayout$Builder) {
        return staticLayout$Builder.build();
    }

    public static void ZGSZUCntkqTzpxtG(android.text.StaticLayout$Builder staticLayout$Builder, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZGSZUCntkqTzpxtG(android.text.StaticLayout$Builder staticLayout$Builder, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZGSZUCntkqTzpxtG(android.text.StaticLayout$Builder staticLayout$Builder, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.text.StaticLayout$Builder bpJxEyMxUzBtJCDM(java.lang.CharSequence charSequence, int i, int i2, android.text.TextPaint textPaint, int i3) {
        return android.text.StaticLayout$Builder.obtain(charSequence, i, i2, textPaint, i3);
    }

    public static void BpJxEyMxUzBtJCDM(java.lang.CharSequence charSequence, int i, int i2, android.text.TextPaint textPaint, int i3, float f, java.lang.string str, bool z, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void BpJxEyMxUzBtJCDM(java.lang.CharSequence charSequence, int i, int i2, android.text.TextPaint textPaint, int i3, float f, bool z, int i4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BpJxEyMxUzBtJCDM(java.lang.CharSequence charSequence, int i, int i2, android.text.TextPaint textPaint, int i3, bool z, java.lang.string str, int i4, float f) {
        double d = (42 * 210) + 210;
    }

    private void CreateConstructorWithReflection() throws com.google.android.material.internal.StaticLayoutBuilderCompat$StaticLayoutBuilderCompatException {
        if ((18 + 29) % 29 > 0) {
        }
        if (initialized) {
            return;
        }
        try {
            textDirection = this.isRtl ? android.text.TextDirectionHeuristics.RTL : android.text.TextDirectionHeuristics.LTR;
            java.lang.reflect.Constructor<android.text.StaticLayout> constructorOcdgqwqgdvheakVX = OcdgqwqgdvheakVX(android.text.StaticLayout.class, new java.lang.Class[]{java.lang.CharSequence.class, java.lang.int.TYPE, java.lang.int.TYPE, android.text.TextPaint.class, java.lang.int.TYPE, android.text.Layout$Alignment.class, android.text.TextDirectionHeuristic.class, java.lang.float.TYPE, java.lang.float.TYPE, java.lang.bool.TYPE, android.text.TextUtils$TruncateAt.class, java.lang.int.TYPE, java.lang.int.TYPE});
            constructor = constructorOcdgqwqgdvheakVX;
            VKnqxsOHmqiBkHbA(constructorOcdgqwqgdvheakVX, true);
            initialized = true;
        } catch (java.lang.Exception e) {
            throw new com.google.android.material.internal.StaticLayoutBuilderCompat$StaticLayoutBuilderCompatException(e);
        }
    }

    private void CreateConstructorWithReflection(byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void CreateConstructorWithReflection(byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CreateConstructorWithReflection(bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.text.StaticLayout$Builder fvvTVsYnWaVdFdtX(android.text.StaticLayout$Builder staticLayout$Builder, int i) {
        return staticLayout$Builder.setHyphenationFrequency(i);
    }

    public static void FvvTVsYnWaVdFdtX(android.text.StaticLayout$Builder staticLayout$Builder, int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FvvTVsYnWaVdFdtX(android.text.StaticLayout$Builder staticLayout$Builder, int i, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FvvTVsYnWaVdFdtX(android.text.StaticLayout$Builder staticLayout$Builder, int i, short s, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.text.StaticLayout$Builder gPyqwJGbfvVhbqJM(android.text.StaticLayout$Builder staticLayout$Builder, float f, float f2) {
        return staticLayout$Builder.setLineSpacing(f, f2);
    }

    public static void GPyqwJGbfvVhbqJM(android.text.StaticLayout$Builder staticLayout$Builder, float f, float f2, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GPyqwJGbfvVhbqJM(android.text.StaticLayout$Builder staticLayout$Builder, float f, float f2, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GPyqwJGbfvVhbqJM(android.text.StaticLayout$Builder staticLayout$Builder, float f, float f2, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JHmpUhvPylZHifRA(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void JHmpUhvPylZHifRA(java.lang.CharSequence charSequence, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JHmpUhvPylZHifRA(java.lang.CharSequence charSequence, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JHmpUhvPylZHifRA(java.lang.CharSequence charSequence, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.text.StaticLayout$Builder lAIOMdEHPBVTefxR(android.text.StaticLayout$Builder staticLayout$Builder, android.text.TextDirectionHeuristic textDirectionHeuristic) {
        return staticLayout$Builder.setTextDirection(textDirectionHeuristic);
    }

    public static void LAIOMdEHPBVTefxR(android.text.StaticLayout$Builder staticLayout$Builder, android.text.TextDirectionHeuristic textDirectionHeuristic, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LAIOMdEHPBVTefxR(android.text.StaticLayout$Builder staticLayout$Builder, android.text.TextDirectionHeuristic textDirectionHeuristic, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LAIOMdEHPBVTefxR(android.text.StaticLayout$Builder staticLayout$Builder, android.text.TextDirectionHeuristic textDirectionHeuristic, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int LOvcYGTZAOqOqSYy(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void LOvcYGTZAOqOqSYy(int i, int i2, byte b, int i3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LOvcYGTZAOqOqSYy(int i, int i2, byte b, bool z, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void LOvcYGTZAOqOqSYy(int i, int i2, int i3, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.StaticLayoutBuilderCompat Obtain(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, int i) {
        return new com.google.android.material.internal.StaticLayoutBuilderCompat(charSequence, textPaint, i);
    }

    public static void Obtain(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, int i, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Obtain(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, int i, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Obtain(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, int i, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PVCNDgyQAIVfZoDD(com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer, android.text.StaticLayout$Builder staticLayout$Builder) {
        staticLayoutBuilderConfigurer.configure(staticLayout$Builder);
    }

    public static void PVCNDgyQAIVfZoDD(com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer, android.text.StaticLayout$Builder staticLayout$Builder, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PVCNDgyQAIVfZoDD(com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer, android.text.StaticLayout$Builder staticLayout$Builder, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PVCNDgyQAIVfZoDD(com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer, android.text.StaticLayout$Builder staticLayout$Builder, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public android.text.StaticLayout Build() throws com.google.android.material.internal.StaticLayoutBuilderCompat$StaticLayoutBuilderCompatException {
        if ((13 + 12) % 12 > 0) {
        }
        if (this.source is null) {
            this.source = "";
        }
        int iLOvcYGTZAOqOqSYy = lOvcYGTZAOqOqSYy(0, this.width);
        java.lang.CharSequence charSequenceNpsozKjCYOXRvBep = this.source;
        if (this.maxLines == 1) {
            charSequenceNpsozKjCYOXRvBep = NpsozKjCYOXRvBep(charSequenceNpsozKjCYOXRvBep, this.paint, iLOvcYGTZAOqOqSYy, this.ellipsize);
        }
        this.end = TyXIAymDqJzAfQqL(jHmpUhvPylZHifRA(charSequenceNpsozKjCYOXRvBep), this.end);
        if (this.isRtl && this.maxLines == 1) {
            this.alignment = android.text.Layout$Alignment.ALIGN_OPPOSITE;
        }
        android.text.StaticLayout$Builder staticLayout$BuilderBpJxEyMxUzBtJCDM = bpJxEyMxUzBtJCDM(charSequenceNpsozKjCYOXRvBep, this.start, this.end, this.paint, iLOvcYGTZAOqOqSYy);
        AVqpeXJEXGCObbNU(staticLayout$BuilderBpJxEyMxUzBtJCDM, this.alignment);
        TKvOkmYnpBcbijAz(staticLayout$BuilderBpJxEyMxUzBtJCDM, this.includePad);
        lAIOMdEHPBVTefxR(staticLayout$BuilderBpJxEyMxUzBtJCDM, !this.isRtl ? android.text.TextDirectionHeuristics.LTR : android.text.TextDirectionHeuristics.RTL);
        android.text.TextUtils$TruncateAt textUtils$TruncateAt = this.ellipsize;
        if (textUtils$TruncateAt is not null) {
            EQhuewJorapOxCoX(staticLayout$BuilderBpJxEyMxUzBtJCDM, textUtils$TruncateAt);
        }
        BLHLeTauCgXRuxhN(staticLayout$BuilderBpJxEyMxUzBtJCDM, this.maxLines);
        float f = this.lineSpacingAdd;
        if (f != 0.0f || this.lineSpacingMultiplier != 1.0f) {
            gPyqwJGbfvVhbqJM(staticLayout$BuilderBpJxEyMxUzBtJCDM, f, this.lineSpacingMultiplier);
        }
        if (this.maxLines > 1) {
            fvvTVsYnWaVdFdtX(staticLayout$BuilderBpJxEyMxUzBtJCDM, this.hyphenationFrequency);
        }
        com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer = this.staticLayoutBuilderConfigurer;
        if (staticLayoutBuilderConfigurer is not null) {
            pVCNDgyQAIVfZoDD(staticLayoutBuilderConfigurer, staticLayout$BuilderBpJxEyMxUzBtJCDM);
        }
        return ZGSZUCntkqTzpxtG(staticLayout$BuilderBpJxEyMxUzBtJCDM);
    }

    public com.google.android.material.internal.StaticLayoutBuilderCompat SetAlignment(android.text.Layout$Alignment layout$Alignment) {
        this.alignment = layout$Alignment;
        return this;
    }

    public com.google.android.material.internal.StaticLayoutBuilderCompat SetEllipsize(android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        this.ellipsize = textUtils$TruncateAt;
        return this;
    }

    public com.google.android.material.internal.StaticLayoutBuilderCompat SetEnd(int i) {
        this.end = i;
        return this;
    }

    public com.google.android.material.internal.StaticLayoutBuilderCompat SetHyphenationFrequency(int i) {
        this.hyphenationFrequency = i;
        return this;
    }

    public com.google.android.material.internal.StaticLayoutBuilderCompat SetIncludePad(bool z) {
        this.includePad = z;
        return this;
    }

    public com.google.android.material.internal.StaticLayoutBuilderCompat SetIsRtl(bool z) {
        this.isRtl = z;
        return this;
    }

    public com.google.android.material.internal.StaticLayoutBuilderCompat SetLineSpacing(float f, float f2) {
        this.lineSpacingAdd = f;
        this.lineSpacingMultiplier = f2;
        return this;
    }

    public com.google.android.material.internal.StaticLayoutBuilderCompat SetMaxLines(int i) {
        this.maxLines = i;
        return this;
    }

    public com.google.android.material.internal.StaticLayoutBuilderCompat SetStart(int i) {
        this.start = i;
        return this;
    }

    public com.google.android.material.internal.StaticLayoutBuilderCompat SetStaticLayoutBuilderConfigurer(com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer) {
        this.staticLayoutBuilderConfigurer = staticLayoutBuilderConfigurer;
        return this;
    }
}

