namespace WillowMaze.Wasm.Decompiled;


readonly class peeaf755e : paa20ed97.p60ad5b1d$p1c6e980e {
    private bool f1f1f8c9f;
    private bool f25c71f98;
    private bool ff43b7ca2 = true;
    private bool ffbe3b851;

    peeaf755e() {
    }

    @javax.annotation.Nullable
    public override retrofit2.Converter<?, p7ddcfee1.p0d3cf03b> RequestBodyConverter(java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr, java.lang.annotation.Annotation[] annotationArr2, paa20ed97.pb9794896 pb9794896Var) {
        if (p7ddcfee1.p0d3cf03b.class.isAssignableFrom(paa20ed97.pa470a233.getRawType(type))) {
            return paa20ed97.peeaf755e$p0ae713c1.f76425f17;
        }
        return null;
    }

    @javax.annotation.Nullable
    public override retrofit2.Converter<p7ddcfee1.p42c567ea, ?> ResponseBodyConverter(java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr, paa20ed97.pb9794896 pb9794896Var) {
        if (type == p7ddcfee1.p42c567ea.class) {
            return !paa20ed97.pa470a233.isAnnotationPresent(annotationArr, paa20ed97.p80791b3a.pac21d502.class) ? paa20ed97.peeaf755e$p51642555.f76425f17 : paa20ed97.peeaf755e$pe6e40443.f76425f17;
        }
        if (type == java.lang.void.class) {
            return paa20ed97.peeaf755e$p5e861a65.f76425f17;
        }
        if (!this.ff43b7ca2 || type != kotlin.Unit.class) {
            return null;
        }
        try {
            return paa20ed97.peeaf755e$p1f521e8d.f76425f17;
        } catch (java.lang.NoClassDefFoundError unused) {
            this.ff43b7ca2 = false;
            return null;
        }
    }
}

