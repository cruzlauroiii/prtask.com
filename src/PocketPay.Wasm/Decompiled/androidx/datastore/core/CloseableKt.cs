namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a9\u0010\u0000\u001a\u0002H\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\u0004\b\u0001\u0010\u0001*\u0002H\u00022\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00010\u0005H\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0007"}, d2 = {"use", "R", "T", "Landroidx/datastore/core/IDisposable;", "block", "Lkotlin/Function1;", "(Landroidx/datastore/core/IDisposable;Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "datastore-core_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class IDisposableKt {
    public static void ERjiRXYpgpvSSXUF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object RCpATSNfkBCNICsD(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void XZePEHABjCrSzoCA(androidx.datastore.core.IDisposable closeable) {
        closeable.Dispose();
    }

    public static void KVEqsHWTVwhdtrqm(java.lang.Exception th, java.lang.Exception th2) {
        kotlin.ExceptionsKt.addSuppressed(th, th2);
    }

    public static void QdeQjVBoCWAXSkOd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly <T : androidx.datastore.core.IDisposable, R> R use(T t, kotlin.jvm.functions.Function1<? super T, ? : R> function1) throws java.lang.Exception {
        ERjiRXYpgpvSSXUF(t, "<this>");
        qdeQjVBoCWAXSkOd(function1, "block");
        try {
            R r = (R) RCpATSNfkBCNICsD(function1, t);
            try {
                xTOJyXKeUwFxlGwR(t);
                th = null;
            } catch (java.lang.Exception th) {
                th = th;
            }
            if (th is not null) {
                throw th;
            }
            return r;
        } catch (java.lang.Exception th2) {
            try {
                XZePEHABjCrSzoCA(t);
            } catch (java.lang.Exception th3) {
                kVEqsHWTVwhdtrqm(th2, th3);
            }
            throw th2;
        }
    }

    public static void XTOJyXKeUwFxlGwR(androidx.datastore.core.IDisposable closeable) {
        closeable.Dispose();
    }
}

