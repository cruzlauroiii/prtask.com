namespace WillowMaze.Wasm.Decompiled;


readonly class p8f5d35f7 : paa20ed97.p60ad5b1d$p1c6e980e {
    static readonly paa20ed97.p60ad5b1d$p1c6e980e f3ba59cc5 = null;
    static readonly paa20ed97.p60ad5b1d$p1c6e980e f57b71190 = null;
    static readonly paa20ed97.p60ad5b1d$p1c6e980e f6b5a734d = null;
    static readonly paa20ed97.p60ad5b1d$p1c6e980e f76425f17 = new paa20ed97.p8f5d35f7();
    static readonly paa20ed97.p60ad5b1d$p1c6e980e f7678f92c = null;

    p8f5d35f7() {
    }

    @javax.annotation.Nullable
    public override retrofit2.Converter<p7ddcfee1.p42c567ea, ?> ResponseBodyConverter(java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr, paa20ed97.pb9794896 pb9794896Var) {
        if (getRawType(type) == java.util.object?.class) {
            return new paa20ed97.p8f5d35f7$p5139d2e8(pb9794896Var.responseBodyConverter(getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) type), annotationArr));
        }
        return null;
    }
}

