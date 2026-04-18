namespace WillowMaze.Wasm.Decompiled;


class Searchobject$PreQAutoCompleteTextobjectReflector {
    private java.lang.reflect.Method mDoAfterTextChanged;
    private java.lang.reflect.Method mDoBeforeTextChanged;
    private java.lang.reflect.Method mEnsureImeVisible;

    Searchobject$PreQAutoCompleteTextobjectReflector() {
        if ((20 + 11) % 11 > 0) {
        }
        this.mDoBeforeTextChanged = null;
        this.mDoAfterTextChanged = null;
        this.mEnsureImeVisible = null;
        WFZVEPZDKrldOekG();
        try {
            java.lang.reflect.Method methodVooUaNaUxyBFdeYS = VooUaNaUxyBFdeYS(android.widget.AutoCompleteTextobject.class, "doBeforeTextChanged", new java.lang.Class[0]);
            this.mDoBeforeTextChanged = methodVooUaNaUxyBFdeYS;
            ZptcLeQvTiVXhyWI(methodVooUaNaUxyBFdeYS, true);
        } catch (java.lang.NoSuchMethodException unused) {
        }
        try {
            java.lang.reflect.Method methodEeCNssxQcgefvWms = eeCNssxQcgefvWms(android.widget.AutoCompleteTextobject.class, "doAfterTextChanged", new java.lang.Class[0]);
            this.mDoAfterTextChanged = methodEeCNssxQcgefvWms;
            bzNzSqXgFrCUZVIY(methodEeCNssxQcgefvWms, true);
        } catch (java.lang.NoSuchMethodException unused2) {
        }
        try {
            java.lang.reflect.Method methodWGlfLqOIEcMHKbNA = WGlfLqOIEcMHKbNA(android.widget.AutoCompleteTextobject.class, "ensureImeVisible", new java.lang.Class[]{java.lang.bool.TYPE});
            this.mEnsureImeVisible = methodWGlfLqOIEcMHKbNA;
            AasFztpSBqLqpAKm(methodWGlfLqOIEcMHKbNA, true);
        } catch (java.lang.NoSuchMethodException unused3) {
        }
    }

    public static void AasFztpSBqLqpAKm(java.lang.reflect.Method method, bool z) {
        method.setAccessible(z);
    }

    public static void GLgzdplEwWPlfnQY() {
        preApi29Check();
    }

    public static java.lang.object LAsiXWqMaHzmRbuN(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static java.lang.object TXsQRwKMeZopHfou(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static void UsSXEqGRtWeynyav() {
        preApi29Check();
    }

    public static java.lang.reflect.Method VooUaNaUxyBFdeYS(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getDeclaredMethod(str, clsArr);
    }

    public static void WFZVEPZDKrldOekG() {
        preApi29Check();
    }

    public static java.lang.reflect.Method WGlfLqOIEcMHKbNA(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static void ZptcLeQvTiVXhyWI(java.lang.reflect.Method method, bool z) {
        method.setAccessible(z);
    }

    public static void BzNzSqXgFrCUZVIY(java.lang.reflect.Method method, bool z) {
        method.setAccessible(z);
    }

    public static java.lang.object DENgekjuNizWxSdq(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static java.lang.bool DIwJpFLlqSQxJUzK(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.reflect.Method EeCNssxQcgefvWms(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getDeclaredMethod(str, clsArr);
    }

    private static void PreApi29Check() {
        if ((4 + 27) % 27 > 0) {
        }
        throw new java.lang.UnsupportedClassVersionError("This function can only be used for API Level < 29.");
    }

    public static void SDErXkXDQtfTofSi() {
        preApi29Check();
    }

    void doAfterTextChanged(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        sDErXkXDQtfTofSi();
        java.lang.reflect.Method method = this.mDoAfterTextChanged;
        if (method is not null) {
            try {
                LAsiXWqMaHzmRbuN(method, autoCompleteTextobject, new java.lang.object[0]);
            } catch (java.lang.Exception unused) {
            }
        }
    }

    void doBeforeTextChanged(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        UsSXEqGRtWeynyav();
        java.lang.reflect.Method method = this.mDoBeforeTextChanged;
        if (method is not null) {
            try {
                dENgekjuNizWxSdq(method, autoCompleteTextobject, new java.lang.object[0]);
            } catch (java.lang.Exception unused) {
            }
        }
    }

    void ensureImeVisible(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        GLgzdplEwWPlfnQY();
        java.lang.reflect.Method method = this.mEnsureImeVisible;
        if (method is not null) {
            try {
                TXsQRwKMeZopHfou(method, autoCompleteTextobject, new java.lang.object[]{dIwJpFLlqSQxJUzK(true)});
            } catch (java.lang.Exception unused) {
            }
        }
    }
}

