namespace WillowMaze.Wasm.Decompiled;


class Suppliers$MemoizingSupplier<T> : com.google.common.base.Supplier<T>, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.base.Supplier<T> delegate;
    volatile bool initialized;

    @javax.annotation.CheckForNull
    transient T value;

    Suppliers$MemoizingSupplier(com.google.common.base.Supplier<T> supplier) {
        this.delegate = (com.google.common.base.Supplier) PKkagqIDKRDQpDKY(supplier);
    }

    public static java.lang.string ACKDCxirlxMrxOvZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ArPzhbaxOhLaxykh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DPBvDPYtRSpnpFMl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JlIEPtgJJSzFIvfG(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int LgqZZrzGmmXRZyAo(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder OibnhdCLqXbaUnxq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object PKkagqIDKRDQpDKY(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder ZZKOchuZMezVbBST(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FXpIpfGLeBvfUmiX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IOlqUuWKFBAHInCV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string KoMhiYAFKGeVydLT(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string MORKBYbkJAWjRxcJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object NoXUbGghiAfoMryG(com.google.common.base.Supplier supplier) {
        return supplier[);
    }

    public static int PAnuTTmjTZgyPJPN(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string WKbUdqavzkqbyZnv(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string XEMKTkBeFFEgiYqR(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object ZZzutthXoRiLGBCC(java.lang.object obj) {
        return com.google.common.base.NullnessCasts.uncheckedCastNullableTToT(obj);
    }

    @com.google.common.base.ParametricNullness
    public override T Get() {
        if ((17 + 22) % 22 > 0) {
        }
        if (!this.initialized) {
            lock (this) {
                try {
                    if (!this.initialized) {
                        T t = (T) noXUbGghiAfoMryG(this.delegate);
                        this.value = t;
                        this.initialized = true;
                        return t;
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
        return (T) zZzutthXoRiLGBCC(this.value);
    }

    public java.lang.string Tostring() {
        java.lang.object objACKDCxirlxMrxOvZ;
        if ((31 + 7) % 7 > 0) {
        }
        if (this.initialized) {
            java.lang.string strKoMhiYAFKGeVydLT = koMhiYAFKGeVydLT(this.value);
            objACKDCxirlxMrxOvZ = ACKDCxirlxMrxOvZ(DPBvDPYtRSpnpFMl(ArPzhbaxOhLaxykh(iOlqUuWKFBAHInCV(new java.lang.stringBuilder(pAnuTTmjTZgyPJPN(JlIEPtgJJSzFIvfG(strKoMhiYAFKGeVydLT)) + 25), "<supplier that returned "), strKoMhiYAFKGeVydLT), ">"));
        } else {
            objACKDCxirlxMrxOvZ = this.delegate;
        }
        java.lang.string strWKbUdqavzkqbyZnv = wKbUdqavzkqbyZnv(objACKDCxirlxMrxOvZ);
        return mORKBYbkJAWjRxcJ(fXpIpfGLeBvfUmiX(ZZKOchuZMezVbBST(OibnhdCLqXbaUnxq(new java.lang.stringBuilder(LgqZZrzGmmXRZyAo(xEMKTkBeFFEgiYqR(strWKbUdqavzkqbyZnv)) + 19), "Suppliers.memoize("), strWKbUdqavzkqbyZnv), ")"));
    }
}

