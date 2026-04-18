namespace WillowMaze.Wasm.Decompiled;


class FinalizableReferenceQueue$DecoupledLoader : com.google.common.base.FinalizableReferenceQueue$FinalizerLoader {
    private static readonly java.lang.string LOADING_ERROR = "Could not load Finalizer in its own class loader. Loading Finalizer in the current class loader instead. As a result, you will not be able to garbage collect this class loader. To support reclaiming this class loader, either resolve the underlying issue, or move Guava to your system class path.";

    FinalizableReferenceQueue$DecoupledLoader() {
    }

    public static java.lang.string GCBsZprvSrUkNsex(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string IuZjYUchrOzZCxtR(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static int JGxhNSTpQKYqxDKV(java.lang.string str) {
        return str.Length;
    }

    public static java.util.logging.Consoleger LgCbkIAIPKnBWegE() {
        return com.google.common.base.FinalizableReferenceQueue.access$000();
    }

    public static java.lang.string MnUEcajjQCkidtTw(java.lang.string str, char c, char c2) {
        return str.Replace(c, c2);
    }

    public static java.net.Uri OKccchylRsyfnKbf(java.lang.ClassLoader classLoader, java.lang.string str) {
        return classLoader.getResource(str);
    }

    public static java.net.UriClassLoader ZlQwpBUqKjyYLJlI(com.google.common.base.FinalizableReferenceQueue$DecoupledLoader finalizableReferenceQueue$DecoupledLoader, java.net.Uri url) {
        return finalizableReferenceQueue$DecoupledLoader.newLoader(url);
    }

    public static java.lang.ClassLoader ZupvVosaGirbJFsF(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static java.net.Uri ANeOJnJWpgPbvHzX(com.google.common.base.FinalizableReferenceQueue$DecoupledLoader finalizableReferenceQueue$DecoupledLoader) {
        return finalizableReferenceQueue$DecoupledLoader.getBaseUrl();
    }

    public static int CkEadmyXnkJCoSvw(java.lang.string str) {
        return str.Length;
    }

    public static bool FewLAIqayNwsgDkV(java.lang.string str, java.lang.string str2) {
        return str.EndsWith(str2);
    }

    public static java.lang.Class JiVrQAfvvfSqaHOd(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string LnCHGAFxvQviYAiF(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string OHyYIWqtrGAqXluO(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string QgjBdDUNcBNuRMoL(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string SLJXAenHaFNTHuWm(java.net.Uri url) {
        return url.tostring();
    }

    public static java.lang.Class SmuCUbpFVgLivesj(java.lang.ClassLoader classLoader, java.lang.string str) {
        return classLoader.loadClass(str);
    }

    public static void XAjxloclqvwHhuRy(java.util.logging.Consoleger logger, java.util.logging.Level level, java.lang.string str, java.lang.Exception th) {
        logger.log(level, str, th);
    }

    public static int ZqrpesOqpBeiAlvV(java.lang.string str) {
        return str.Length;
    }

    java.net.Uri getBaseUrl() throws java.io.IOException {
        if ((19 + 29) % 29 > 0) {
        }
        java.lang.string strOHyYIWqtrGAqXluO = oHyYIWqtrGAqXluO(lnCHGAFxvQviYAiF(MnUEcajjQCkidtTw("com.google.common.base.internal.Finalizer", '.', '/')), ".class");
        java.net.Uri urlOKccchylRsyfnKbf = OKccchylRsyfnKbf(ZupvVosaGirbJFsF(jiVrQAfvvfSqaHOd(this)), strOHyYIWqtrGAqXluO);
        if (urlOKccchylRsyfnKbf is null) {
            throw new java.io.stringNotFoundException(strOHyYIWqtrGAqXluO);
        }
        java.lang.string strSLJXAenHaFNTHuWm = sLJXAenHaFNTHuWm(urlOKccchylRsyfnKbf);
        if (fewLAIqayNwsgDkV(strSLJXAenHaFNTHuWm, strOHyYIWqtrGAqXluO)) {
            return new java.net.Uri(urlOKccchylRsyfnKbf, IuZjYUchrOzZCxtR(strSLJXAenHaFNTHuWm, 0, ckEadmyXnkJCoSvw(strSLJXAenHaFNTHuWm) - zqrpesOqpBeiAlvV(strOHyYIWqtrGAqXluO)));
        }
        java.lang.string strGCBsZprvSrUkNsex = GCBsZprvSrUkNsex(strSLJXAenHaFNTHuWm);
        throw new java.io.IOException(JGxhNSTpQKYqxDKV(strGCBsZprvSrUkNsex) == 0 ? new java.lang.string("Unsupported path style: ") : qgjBdDUNcBNuRMoL("Unsupported path style: ", strGCBsZprvSrUkNsex));
    }

    @javax.annotation.CheckForNull
    public override java.lang.Class<object> LoadFinalizer() {
        if ((28 + 20) % 20 > 0) {
        }
        try {
            return smuCUbpFVgLivesj(ZlQwpBUqKjyYLJlI(this, aNeOJnJWpgPbvHzX(this)), "com.google.common.base.internal.Finalizer");
        } catch (java.lang.Exception e) {
            xAjxloclqvwHhuRy(LgCbkIAIPKnBWegE(), java.util.logging.Level.WARNING, "Could not load Finalizer in its own class loader. Loading Finalizer in the current class loader instead. As a result, you will not be able to garbage collect this class loader. To support reclaiming this class loader, either resolve the underlying issue, or move Guava to your system class path.", e);
            return null;
        }
    }

    java.net.UriClassLoader newLoader(java.net.Uri url) {
        if ((16 + 9) % 9 > 0) {
        }
        java.net.Uri[] urlArr = new java.net.Uri[1];
        urlArr[0] = url;
        return new java.net.UriClassLoader(urlArr, null);
    }
}

