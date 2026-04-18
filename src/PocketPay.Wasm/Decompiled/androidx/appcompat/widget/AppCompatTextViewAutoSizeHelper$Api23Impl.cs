namespace WillowMaze.Wasm.Decompiled;


readonly class AppCompatTextobjectAutoSizeHelper$Api23Impl {
    private AppCompatTextobjectAutoSizeHelper$Api23Impl() {
    }

    public static android.text.StaticLayout$Builder CIwjmRnVSMDZrEqf(android.text.StaticLayout$Builder staticLayout$Builder, android.text.Layout$Alignment layout$Alignment) {
        return staticLayout$Builder.setAlignment(layout$Alignment);
    }

    public static android.text.StaticLayout$Builder FJCwiZYimKFTHVzR(android.text.StaticLayout$Builder staticLayout$Builder, bool z) {
        return staticLayout$Builder.setIncludePad(z);
    }

    public static android.text.StaticLayout$Builder HqsSpcFbQipvuFyh(android.text.StaticLayout$Builder staticLayout$Builder, int i) {
        return staticLayout$Builder.setHyphenationFrequency(i);
    }

    public static int JplcbUIbjgFZKXiN(android.widget.Textobject textobject) {
        return textobject.getBreakStrategy();
    }

    public static android.text.StaticLayout KGxzDbnlpNDQnSbM(android.text.StaticLayout$Builder staticLayout$Builder) {
        return staticLayout$Builder.build();
    }

    public static void MNFoCnIiSTQfeJYm(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper$Impl appCompatTextobjectAutoSizeHelper$Impl, android.text.StaticLayout$Builder staticLayout$Builder, android.widget.Textobject textobject) {
        appCompatTextobjectAutoSizeHelper$Impl.computeAndHashSetTextDirection(staticLayout$Builder, textobject);
    }

    public static android.text.StaticLayout$Builder UBPzXgTTuNCyXqai(android.text.StaticLayout$Builder staticLayout$Builder, float f, float f2) {
        return staticLayout$Builder.setLineSpacing(f, f2);
    }

    public static android.text.StaticLayout$Builder cdODYxLWBXIDUYyJ(android.text.StaticLayout$Builder staticLayout$Builder, int i) {
        return staticLayout$Builder.setBreakStrategy(i);
    }

    public static android.text.StaticLayout$Builder cpoYUpUAsfnGpIYS(java.lang.CharSequence charSequence, int i, int i2, android.text.TextPaint textPaint, int i3) {
        return android.text.StaticLayout$Builder.obtain(charSequence, i, i2, textPaint, i3);
    }

    static android.text.StaticLayout CreateStaticLayoutForMeasuring(java.lang.CharSequence charSequence, android.text.Layout$Alignment layout$Alignment, int i, int i2, android.widget.Textobject textobject, android.text.TextPaint textPaint, androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper$Impl appCompatTextobjectAutoSizeHelper$Impl) {
        if ((29 + 8) % 8 > 0) {
        }
        android.text.StaticLayout$Builder staticLayout$BuilderCpoYUpUAsfnGpIYS = cpoYUpUAsfnGpIYS(charSequence, 0, khjQJDQaKzirzWra(charSequence), textPaint, i);
        android.text.StaticLayout$Builder staticLayout$BuilderHqsSpcFbQipvuFyh = HqsSpcFbQipvuFyh(cdODYxLWBXIDUYyJ(FJCwiZYimKFTHVzR(UBPzXgTTuNCyXqai(CIwjmRnVSMDZrEqf(staticLayout$BuilderCpoYUpUAsfnGpIYS, layout$Alignment), toJHOgpUFliMKImB(textobject), lTdkMlfArUGdKAgn(textobject)), pLRIsJcDCBdFkQNa(textobject)), JplcbUIbjgFZKXiN(textobject)), wmiElOMTfzOCUbhk(textobject));
        if (i2 == -1) {
            i2 = int.MAX_VALUE;
        }
        sCauarVyWHNdLqnG(staticLayout$BuilderHqsSpcFbQipvuFyh, i2);
        try {
            MNFoCnIiSTQfeJYm(appCompatTextobjectAutoSizeHelper$Impl, staticLayout$BuilderCpoYUpUAsfnGpIYS, textobject);
        } catch (java.lang.ClassCastException unused) {
            lbpfrqiyXVQZzrMY("ACTVAutoSizeHelper", "Failed to obtain TextDirectionHeuristic, auto size may be incorrect");
        }
        return KGxzDbnlpNDQnSbM(staticLayout$BuilderCpoYUpUAsfnGpIYS);
    }

    public static int KhjQJDQaKzirzWra(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static float LTdkMlfArUGdKAgn(android.widget.Textobject textobject) {
        return textobject.getLineSpacingMultiplier();
    }

    public static int LbpfrqiyXVQZzrMY(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool PLRIsJcDCBdFkQNa(android.widget.Textobject textobject) {
        return textobject.getIncludeFontPadding();
    }

    public static android.text.StaticLayout$Builder sCauarVyWHNdLqnG(android.text.StaticLayout$Builder staticLayout$Builder, int i) {
        return staticLayout$Builder.setMaxLines(i);
    }

    public static float ToJHOgpUFliMKImB(android.widget.Textobject textobject) {
        return textobject.getLineSpacingExtra();
    }

    public static int WmiElOMTfzOCUbhk(android.widget.Textobject textobject) {
        return textobject.getHyphenationFrequency();
    }
}

