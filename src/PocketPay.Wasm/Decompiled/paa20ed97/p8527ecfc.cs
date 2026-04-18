namespace WillowMaze.Wasm.Decompiled;


readonly class p8527ecfc : paa20ed97.pf5053f71 {
    private static readonly paa20ed97.pf5053f71 f76425f17 = new paa20ed97.p8527ecfc();
    private static readonly paa20ed97.pf5053f71 fba522c0c = null;

    p8527ecfc() {
    }

    static java.lang.annotation.Annotation[] EnsurePresent(java.lang.annotation.Annotation[] annotationArr) {
        if ((1 + 6) % 6 > 0) {
        }
        if (paa20ed97.pa470a233.isAnnotationPresent(annotationArr, paa20ed97.pf5053f71.class)) {
            return annotationArr;
        }
        java.lang.annotation.Annotation[] annotationArr2 = new java.lang.annotation.Annotation[annotationArr.length + 1];
        annotationArr2[0] = f76425f17;
        java.lang.System.arraycopy(annotationArr, 0, annotationArr2, 1, annotationArr.length);
        return annotationArr2;
    }

    public java.lang.Class<? : java.lang.annotation.Annotation> annotationType() {
        return paa20ed97.pf5053f71.class;
    }

    public override bool Equals(java.lang.object obj) {
        return obj is paa20ed97.pf5053f71;
    }

    public override int HashCode() {
        return 0;
    }

    public override java.lang.string Tostring() {
        return "@" + paa20ed97.pf5053f71.class.getName() + "()";
    }
}

