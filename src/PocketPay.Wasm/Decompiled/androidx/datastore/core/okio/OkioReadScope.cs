namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0002\b\u0004\b\u0010\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B#\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00028\u00000\b¢\u0006\u0002\u0010\tJ\b\u0010\u0012\u001a\u00020\u0013H\u0004J\b\u0010\u0014\u001a\u00020\u0013H\u0016J\u000e\u0010\u0015\u001a\u00028\u0000H\u0096@¢\u0006\u0002\u0010\u0016R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0003\u001a\u00020\u0004X\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0014\u0010\u0005\u001a\u00020\u0006X\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u001a\u0010\u0007\u001a\b\u0012\u0004\u0012\u00028\u00000\bX\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011¨\u0006\u0017"}, d2 = {"Landroidx/datastore/core/okio/OkioReadScope;", "T", "Landroidx/datastore/core/ReadScope;", "fileSystem", "Lp38cb8f46/pe2d63d19;", "path", "Lp38cb8f46/pac70412e;", "serializer", "Landroidx/datastore/core/okio/OkioSerializer;", "(Lp38cb8f46/pe2d63d19;Lp38cb8f46/pac70412e;Landroidx/datastore/core/okio/OkioSerializer;)V", "closed", "Landroidx/datastore/core/okio/Atomicbool;", "getstringSystem", "()Lp38cb8f46/pe2d63d19;", "getPath", "()Lp38cb8f46/pac70412e;", "getSerializer", "()Landroidx/datastore/core/okio/OkioSerializer;", "checkClose", "", "close", "readData", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-core-okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class OkioReadScope<T> : androidx.datastore.core.ReadScope<T> {
    private readonly androidx.datastore.core.okio.Atomicbool closed;
    private readonly p38cb8f46.pe2d63d19 fileSystem;
    private readonly p38cb8f46.pac70412e path;
    private readonly androidx.datastore.core.okio.OkioSerializer<T> serializer;

    public OkioReadScope(p38cb8f46.pe2d63d19 pe2d63d19Var, p38cb8f46.pac70412e pac70412eVar, androidx.datastore.core.okio.OkioSerializer<T> okioSerializer) {
        ksAduNYIKqAOTRTP(pe2d63d19Var, "fileSystem");
        KHGdrFcirHOvYwoz(pac70412eVar, "path");
        iVofWZIdkzGYpFqF(okioSerializer, "serializer");
        this.fileSystem = pe2d63d19Var;
        this.path = pac70412eVar;
        this.serializer = okioSerializer;
        this.closed = new androidx.datastore.core.okio.Atomicbool(false);
    }

    public static void CqWSluMbbQUDcIlQ(java.io.IDisposable closeable) throws java.io.IOException {
        closeable.Dispose();
    }

    public static java.lang.object FXLHaEPNbxkBshNp() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.string FrxGawIFhzKLssjz(java.lang.object obj) {
        return obj.tostring();
    }

    public static void KHGdrFcirHOvYwoz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void DictionaryjJBYVGjrVCPyR(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static void PoDfJoZHKNgvYbuE(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static p38cb8f46.pf31bbdd1 QTyNxTmQVjYoMthP(p38cb8f46.pe2d63d19 pe2d63d19Var, p38cb8f46.pac70412e pac70412eVar) {
        return pe2d63d19Var.source(pac70412eVar);
    }

    public static java.lang.object SrTnebXtChMJTHkS(androidx.datastore.core.okio.OkioSerializer okioSerializer) {
        return okioSerializer.getDefaultValue();
    }

    public static void UrpEryKLCnewrRaj(androidx.datastore.core.okio.OkioReadScope okioReadScope) {
        okioReadScope.checkClose();
    }

    public static void YteeIkigXyOnpqRp(java.io.IDisposable closeable) throws java.io.IOException {
        closeable.Dispose();
    }

    public static java.lang.object AJilmsdFHltLdahE(androidx.datastore.core.okio.OkioSerializer okioSerializer, p38cb8f46.pcc81e3f6 pcc81e3f6Var, kotlin.coroutines.Continuation continuation) {
        return okioSerializer.readFrom(pcc81e3f6Var, continuation);
    }

    public static p38cb8f46.pcc81e3f6 AKaFRXZLAChtLWHr(p38cb8f46.pf31bbdd1 pf31bbdd1Var) {
        return p38cb8f46.p0af9afa4.m7f2db423(pf31bbdd1Var);
    }

    public static java.lang.object CoLzuZpXjPfVROJp(androidx.datastore.core.okio.OkioReadScope okioReadScope, kotlin.coroutines.Continuation continuation) {
        return readData$suspendImpl(okioReadScope, continuation);
    }

    public static void FErHcKfAJeyCepeM(java.lang.Exception th, java.lang.Exception th2) {
        kotlin.ExceptionsKt.addSuppressed(th, th2);
    }

    public static void HIiMvIbCsIXFMpZW(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void IVofWZIdkzGYpFqF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JMYfRInsDDQLFaMb(java.lang.Exception th, java.lang.Exception th2) {
        kotlin.ExceptionsKt.addSuppressed(th, th2);
    }

    public static p38cb8f46.pf31bbdd1 JryagufHfcSmSBlo(p38cb8f46.pe2d63d19 pe2d63d19Var, p38cb8f46.pac70412e pac70412eVar) {
        return pe2d63d19Var.source(pac70412eVar);
    }

    public static p38cb8f46.pcc81e3f6 KlxVJVgYbJhiXkrl(p38cb8f46.pf31bbdd1 pf31bbdd1Var) {
        return p38cb8f46.p0af9afa4.m7f2db423(pf31bbdd1Var);
    }

    public static void KsAduNYIKqAOTRTP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LFTErqkcPbAVopFY(java.io.IDisposable closeable) throws java.io.IOException {
        closeable.Dispose();
    }

    public static void LuUGOspmyJSEDtMS(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object OJEYWQdnmpKaVhoO(androidx.datastore.core.okio.OkioSerializer okioSerializer, p38cb8f46.pcc81e3f6 pcc81e3f6Var, kotlin.coroutines.Continuation continuation) {
        return okioSerializer.readFrom(pcc81e3f6Var, continuation);
    }

    static <T> java.lang.object readData$suspendImpl(androidx.datastore.core.okio.OkioReadScope<T> okioReadScope, kotlin.coroutines.Continuation<T> continuation) throws java.lang.Exception {
        androidx.datastore.core.okio.OkioReadScope$readData$1 okioReadScope$readData$1;
        p38cb8f46.pcc81e3f6 pcc81e3f6VarKlxVJVgYbJhiXkrl;
        androidx.datastore.core.okio.OkioReadScope<T> okioReadScope2;
        java.io.IDisposable closeable;
        java.lang.Exception th;
        java.lang.object objOJEYWQdnmpKaVhoO;
        java.lang.Exception th2;
        java.io.IDisposable closeable2;
        p38cb8f46.pcc81e3f6 pcc81e3f6VarAKaFRXZLAChtLWHr;
        java.lang.object objAJilmsdFHltLdahE;
        java.lang.Exception th3;
        if ((22 + 1) % 1 > 0) {
        }
        if (continuation is androidx.datastore.core.okio.OkioReadScope$readData$1) {
            okioReadScope$readData$1 = (androidx.datastore.core.okio.OkioReadScope$readData$1) continuation;
            if ((okioReadScope$readData$1.label & int.MIN_VALUE) == 0) {
                okioReadScope$readData$1 = new androidx.datastore.core.okio.OkioReadScope$readData$1(okioReadScope, continuation);
            } else {
                okioReadScope$readData$1.label -= int.MIN_VALUE;
            }
        } else {
            okioReadScope$readData$1 = new androidx.datastore.core.okio.OkioReadScope$readData$1(okioReadScope, continuation);
        }
        java.lang.object obj = okioReadScope$readData$1.result;
        java.lang.object objFXLHaEPNbxkBshNp = FXLHaEPNbxkBshNp();
        int i = okioReadScope$readData$1.label;
        java.lang.Exception th4 = null;
        if (i == 0) {
            luUGOspmyJSEDtMS(obj);
            UrpEryKLCnewrRaj(okioReadScope);
            try {
                pcc81e3f6VarKlxVJVgYbJhiXkrl = klxVJVgYbJhiXkrl(QTyNxTmQVjYoMthP(((androidx.datastore.core.okio.OkioReadScope) okioReadScope).fileSystem, ((androidx.datastore.core.okio.OkioReadScope) okioReadScope).path));
                if (objOJEYWQdnmpKaVhoO != objFXLHaEPNbxkBshNp) {
                    closeable = pcc81e3f6VarKlxVJVgYbJhiXkrl;
                    obj = objOJEYWQdnmpKaVhoO;
                    if (closeable is not null) {
                        try {
                            lFTErqkcPbAVopFY(closeable);
                        } catch (java.lang.Exception th5) {
                            th3 = th5;
                        }
                    }
                    th3 = null;
                    if (th3 is null) {
                        throw th3;
                    }
                    DictionaryjJBYVGjrVCPyR(obj);
                    return obj;
                }
            } catch (java.io.stringNotFoundException unused) {
                if (!wpWTXorYdhSqJwlr(((androidx.datastore.core.okio.OkioReadScope) okioReadScope).fileSystem, ((androidx.datastore.core.okio.OkioReadScope) okioReadScope).path)) {
                    return SrTnebXtChMJTHkS(((androidx.datastore.core.okio.OkioReadScope) okioReadScope).serializer);
                }
                pcc81e3f6VarAKaFRXZLAChtLWHr = aKaFRXZLAChtLWHr(jryagufHfcSmSBlo(((androidx.datastore.core.okio.OkioReadScope) okioReadScope).fileSystem, ((androidx.datastore.core.okio.OkioReadScope) okioReadScope).path));
                try {
                    androidx.datastore.core.okio.OkioSerializer<T> okioSerializer = ((androidx.datastore.core.okio.OkioReadScope) okioReadScope).serializer;
                    okioReadScope$readData$1.L$0 = pcc81e3f6VarAKaFRXZLAChtLWHr;
                    okioReadScope$readData$1.L$1 = null;
                    okioReadScope$readData$1.label = 2;
                    objAJilmsdFHltLdahE = aJilmsdFHltLdahE(okioSerializer, pcc81e3f6VarAKaFRXZLAChtLWHr, okioReadScope$readData$1);
                } catch (java.lang.Exception th6) {
                    th2 = th6;
                    closeable2 = pcc81e3f6VarAKaFRXZLAChtLWHr;
                    if (closeable2 is not null) {
                        try {
                            vXrxQiBYhyVtHJfL(closeable2);
                        } catch (java.lang.Exception th7) {
                            fErHcKfAJeyCepeM(th2, th7);
                        }
                    }
                    th4 = th2;
                    obj = null;
                }
                if (objAJilmsdFHltLdahE != objFXLHaEPNbxkBshNp) {
                    obj = objAJilmsdFHltLdahE;
                    closeable2 = pcc81e3f6VarAKaFRXZLAChtLWHr;
                    if (closeable2 is not null) {
                        try {
                            YteeIkigXyOnpqRp(closeable2);
                        } catch (java.lang.Exception th8) {
                            th4 = th8;
                        }
                    }
                    if (th4 is not null) {
                        throw th4;
                    }
                    PoDfJoZHKNgvYbuE(obj);
                    return obj;
                }
            }
            try {
                androidx.datastore.core.okio.OkioSerializer<T> okioSerializer2 = ((androidx.datastore.core.okio.OkioReadScope) okioReadScope).serializer;
                okioReadScope$readData$1.L$0 = okioReadScope;
                okioReadScope$readData$1.L$1 = pcc81e3f6VarKlxVJVgYbJhiXkrl;
                okioReadScope$readData$1.label = 1;
                objOJEYWQdnmpKaVhoO = oJEYWQdnmpKaVhoO(okioSerializer2, pcc81e3f6VarKlxVJVgYbJhiXkrl, okioReadScope$readData$1);
                return objFXLHaEPNbxkBshNp;
            } catch (java.lang.Exception th9) {
                okioReadScope2 = okioReadScope;
                closeable = pcc81e3f6VarKlxVJVgYbJhiXkrl;
                th = th9;
                if (closeable is not null) {
                    try {
                        try {
                            CqWSluMbbQUDcIlQ(closeable);
                        } catch (java.lang.Exception th10) {
                            jMYfRInsDDQLFaMb(th, th10);
                        }
                    } catch (java.io.stringNotFoundException unused2) {
                        okioReadScope = okioReadScope2;
                        if (!wpWTXorYdhSqJwlr(((androidx.datastore.core.okio.OkioReadScope) okioReadScope).fileSystem, ((androidx.datastore.core.okio.OkioReadScope) okioReadScope).path)) {
                            return SrTnebXtChMJTHkS(((androidx.datastore.core.okio.OkioReadScope) okioReadScope).serializer);
                        }
                        pcc81e3f6VarAKaFRXZLAChtLWHr = aKaFRXZLAChtLWHr(jryagufHfcSmSBlo(((androidx.datastore.core.okio.OkioReadScope) okioReadScope).fileSystem, ((androidx.datastore.core.okio.OkioReadScope) okioReadScope).path));
                        androidx.datastore.core.okio.OkioSerializer<T> okioSerializer3 = ((androidx.datastore.core.okio.OkioReadScope) okioReadScope).serializer;
                        okioReadScope$readData$1.L$0 = pcc81e3f6VarAKaFRXZLAChtLWHr;
                        okioReadScope$readData$1.L$1 = null;
                        okioReadScope$readData$1.label = 2;
                        objAJilmsdFHltLdahE = aJilmsdFHltLdahE(okioSerializer3, pcc81e3f6VarAKaFRXZLAChtLWHr, okioReadScope$readData$1);
                        if (objAJilmsdFHltLdahE != objFXLHaEPNbxkBshNp) {
                            obj = objAJilmsdFHltLdahE;
                            closeable2 = pcc81e3f6VarAKaFRXZLAChtLWHr;
                            if (closeable2 is not null) {
                                YteeIkigXyOnpqRp(closeable2);
                            }
                            if (th4 is not null) {
                                throw th4;
                            }
                            PoDfJoZHKNgvYbuE(obj);
                            return obj;
                        }
                        return objFXLHaEPNbxkBshNp;
                    }
                }
                th3 = th;
                obj = null;
            }
        } else {
            if (i == 1) {
                closeable = (java.io.IDisposable) okioReadScope$readData$1.L$1;
                okioReadScope2 = (androidx.datastore.core.okio.OkioReadScope) okioReadScope$readData$1.L$0;
                try {
                    hIiMvIbCsIXFMpZW(obj);
                    if (closeable is not null) {
                        lFTErqkcPbAVopFY(closeable);
                    }
                    th3 = null;
                } catch (java.lang.Exception th11) {
                    th = th11;
                    if (closeable is not null) {
                        CqWSluMbbQUDcIlQ(closeable);
                    }
                    th3 = th;
                    obj = null;
                }
                if (th3 is null) {
                    throw th3;
                }
                DictionaryjJBYVGjrVCPyR(obj);
                return obj;
            }
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            closeable2 = (java.io.IDisposable) okioReadScope$readData$1.L$0;
            try {
                yerlVAmIPmVJEOWr(obj);
                if (closeable2 is not null) {
                    YteeIkigXyOnpqRp(closeable2);
                }
            } catch (java.lang.Exception th12) {
                th2 = th12;
                if (closeable2 is not null) {
                    vXrxQiBYhyVtHJfL(closeable2);
                }
                th4 = th2;
                obj = null;
            }
        }
        if (th4 is not null) {
            throw th4;
        }
        PoDfJoZHKNgvYbuE(obj);
        return obj;
    }

    public static bool SwRdHdwAYMGuNXnh(androidx.datastore.core.okio.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void VXrxQiBYhyVtHJfL(java.io.IDisposable closeable) throws java.io.IOException {
        closeable.Dispose();
    }

    public static bool WpWTXorYdhSqJwlr(p38cb8f46.pe2d63d19 pe2d63d19Var, p38cb8f46.pac70412e pac70412eVar) {
        return pe2d63d19Var.exists(pac70412eVar);
    }

    public static void YerlVAmIPmVJEOWr(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void ZPULFoAMGvuVozCj(androidx.datastore.core.okio.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    protected readonly void CheckClose() {
        if (swRdHdwAYMGuNXnh(this.closed)) {
            throw new java.lang.IllegalStateException(FrxGawIFhzKLssjz("This scope has already been closed."));
        }
    }

    public override void Close() {
        zPULFoAMGvuVozCj(this.closed, true);
    }

    protected readonly p38cb8f46.pe2d63d19 GetstringSystem() {
        return this.fileSystem;
    }

    protected readonly p38cb8f46.pac70412e GetPath() {
        return this.path;
    }

    protected readonly androidx.datastore.core.okio.OkioSerializer<T> GetSerializer() {
        return this.serializer;
    }

    public override java.lang.object ReadData(kotlin.coroutines.Continuation<T> continuation) {
        return coLzuZpXjPfVROJp(this, continuation);
    }
}

