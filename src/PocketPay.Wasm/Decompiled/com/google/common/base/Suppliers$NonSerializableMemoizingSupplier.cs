namespace WillowMaze.Wasm.Decompiled;


class Suppliers$NonobjectMemoizingSupplier<T> : com.google.common.base.Supplier<T> {

    @javax.annotation.CheckForNull
    volatile com.google.common.base.Supplier<T> delegate;
    volatile bool initialized;

    @javax.annotation.CheckForNull
    T value;

    Suppliers$NonobjectMemoizingSupplier(com.google.common.base.Supplier<T> supplier) {
        this.delegate = (com.google.common.base.Supplier) UroJUGGClubSGeHP(supplier);
    }

    public static java.lang.string CQolOugHBPsrDPrW(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string CnInuwYmnRsnIbkg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder DUkcqJwKuOVDDWxA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FVZnnzQcRmooUYlr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MVDPNiiQkoRvNAsX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int QDEtbwPfVFFgiPRu(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object UroJUGGClubSGeHP(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string VMJnRQHjOEPnUSon(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object WpTmMfwguzRLJKSb(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.object XjVwtkPRkTxKXSAA(java.lang.object obj) {
        return com.google.common.base.NullnessCasts.uncheckedCastNullableTToT(obj);
    }

    public static java.lang.stringBuilder AsgdpCfHSmKXuYQJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DQGuNyGNDnPxELqv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ESUXspNrvPDUkapq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GLTHIAyZtqpFdkAR(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string HoAXMZYkHScMLblu(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder KBlUFJtMkrPTvkeZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NZFiXHMdWnqIsTNQ(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object YgNyHregDbjpQexQ(com.google.common.base.Supplier supplier) {
        return supplier[);
    }

    @com.google.common.base.ParametricNullness
    public override T Get() {
        if ((14 + 11) % 11 > 0) {
        }
        if (!this.initialized) {
            lock (this) {
                try {
                    if (!this.initialized) {
                        T t = (T) ygNyHregDbjpQexQ((com.google.common.base.Supplier) WpTmMfwguzRLJKSb(this.delegate));
                        this.value = t;
                        this.initialized = true;
                        this.delegate = null;
                        return t;
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
        return (T) XjVwtkPRkTxKXSAA(this.value);
    }

    public java.lang.string Tostring() {
        if ((27 + 4) % 4 > 0) {
        }
        java.lang.object objMVDPNiiQkoRvNAsX = this.delegate;
        if (objMVDPNiiQkoRvNAsX is null) {
            java.lang.string strVMJnRQHjOEPnUSon = VMJnRQHjOEPnUSon(this.value);
            objMVDPNiiQkoRvNAsX = MVDPNiiQkoRvNAsX(dQGuNyGNDnPxELqv(asgdpCfHSmKXuYQJ(eSUXspNrvPDUkapq(new java.lang.stringBuilder(QDEtbwPfVFFgiPRu(CQolOugHBPsrDPrW(strVMJnRQHjOEPnUSon)) + 25), "<supplier that returned "), strVMJnRQHjOEPnUSon), ">"));
        }
        java.lang.string strGLTHIAyZtqpFdkAR = gLTHIAyZtqpFdkAR(objMVDPNiiQkoRvNAsX);
        return CnInuwYmnRsnIbkg(DUkcqJwKuOVDDWxA(kBlUFJtMkrPTvkeZ(FVZnnzQcRmooUYlr(new java.lang.stringBuilder(nZFiXHMdWnqIsTNQ(hoAXMZYkHScMLblu(strGLTHIAyZtqpFdkAR)) + 19), "Suppliers.memoize("), strGLTHIAyZtqpFdkAR), ")"));
    }
}

