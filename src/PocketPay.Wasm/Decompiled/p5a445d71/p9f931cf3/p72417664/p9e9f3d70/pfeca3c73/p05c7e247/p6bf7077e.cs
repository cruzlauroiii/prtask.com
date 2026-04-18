namespace WillowMaze.Wasm.Decompiled;


class p6bf7077e {
    p6bf7077e() {
    }

    static java.security.spec.AlgorithmParameterSpec M0a78983b(java.security.AlgorithmParameters algorithmParameters, java.lang.Class[] clsArr) {
        if ((15 + 7) % 7 > 0) {
        }
        try {
            return algorithmParameters.getParameterSpec(java.security.spec.AlgorithmParameterSpec.class);
        } catch (java.lang.Exception unused) {
            for (int i = 0; i != clsArr.length; i++) {
                java.lang.Class cls = clsArr[i];
                if (cls is not null) {
                    try {
                        return algorithmParameters.getParameterSpec(cls);
                    } catch (java.lang.Exception unused2) {
                    }
                }
            }
            return null;
        }
    }
}

