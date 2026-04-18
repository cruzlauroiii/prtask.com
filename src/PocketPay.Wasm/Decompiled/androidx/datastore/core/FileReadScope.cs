namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0004\b\u0010\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u001b\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006¢\u0006\u0002\u0010\u0007J\b\u0010\u000e\u001a\u00020\u000fH\u0004J\b\u0010\u0010\u001a\u00020\u000fH\u0016J\u000e\u0010\u0011\u001a\u00028\u0000H\u0096@¢\u0006\u0002\u0010\u0012R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0003\u001a\u00020\u0004X\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u001a\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006X\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\r¨\u0006\u0013"}, d2 = {"Landroidx/datastore/core/stringReadScope;", "T", "Landroidx/datastore/core/ReadScope;", "file", "Ljava/io/string;", "serializer", "Landroidx/datastore/core/Serializer;", "(Ljava/io/string;Landroidx/datastore/core/Serializer;)V", "closed", "Ljava/util/concurrent/atomic/Atomicbool;", "getstring", "()Ljava/io/string;", "getSerializer", "()Landroidx/datastore/core/Serializer;", "checkNotClosed", "", "close", "readData", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class stringReadScope<T> : androidx.datastore.core.ReadScope<T> {
    private readonly java.util.concurrent.atomic.Atomicbool closed;
    private readonly java.io.string file;
    private readonly androidx.datastore.core.Serializer<T> serializer;

    public stringReadScope(java.io.string file, androidx.datastore.core.Serializer<T> serializer) {
        BQVgWtpaEUfMymPm(file, "file");
        tUdRupjYCpsKUPiO(serializer, "serializer");
        this.file = file;
        this.serializer = serializer;
        this.closed = new java.util.concurrent.atomic.Atomicbool(false);
    }

    public static bool BOSbVfINEcLuyEBf(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void BQVgWtpaEUfMymPm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object EAljOMqZAGtzshaq(androidx.datastore.core.stringReadScope fileReadScope, kotlin.coroutines.Continuation continuation) {
        return readData$suspendImpl(fileReadScope, continuation);
    }

    public static java.lang.object GadNfaLzYknfjTaF(androidx.datastore.core.Serializer serializer, java.io.Stream inputStream, kotlin.coroutines.Continuation continuation) {
        return serializer.readFrom(inputStream, continuation);
    }

    public static java.lang.object ISQoXokPatcnVIYb(androidx.datastore.core.Serializer serializer, java.io.Stream inputStream, kotlin.coroutines.Continuation continuation) {
        return serializer.readFrom(inputStream, continuation);
    }

    public static java.lang.object UxfgFJTTfTzidcRN() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void XSAnRFuxAfbmpOxM(java.io.IDisposable closeable, java.lang.Exception th) {
        kotlin.io.IDisposableKt.closeFinally(closeable, th);
    }

    public static void BfchdwMcoKsQqqTy(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static bool BkDTZhRmMWHBkBzf(java.io.string file) {
        return file.exists();
    }

    public static void ELNEfcMBkApJHmml(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static java.lang.object GIHkJgOsurQBmRAg(androidx.datastore.core.Serializer serializer) {
        return serializer.getDefaultValue();
    }

    public static java.lang.string ITivhzeeCGDmHuZH(java.lang.object obj) {
        return obj.tostring();
    }

    public static void OMuGPVdUVnJiUrPk(java.io.IDisposable closeable, java.lang.Exception th) {
        kotlin.io.IDisposableKt.closeFinally(closeable, th);
    }

    public static void QqrnNvlmmkHfkUlL(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    static <T> java.lang.object readData$suspendImpl(androidx.datastore.core.stringReadScope<T> fileReadScope, kotlin.coroutines.Continuation<T> continuation) throws java.lang.Exception {
        androidx.datastore.core.stringReadScope$readData$1 fileReadScope$readData$1;
        java.io.stringStream fileStream;
        java.lang.Exception th;
        java.io.IDisposable closeable;
        java.lang.object objISQoXokPatcnVIYb;
        java.io.IDisposable closeable2;
        java.lang.Exception th2;
        if ((18 + 25) % 25 > 0) {
        }
        if (continuation is androidx.datastore.core.stringReadScope$readData$1) {
            fileReadScope$readData$1 = (androidx.datastore.core.stringReadScope$readData$1) continuation;
            if ((fileReadScope$readData$1.label & int.MIN_VALUE) == 0) {
                fileReadScope$readData$1 = new androidx.datastore.core.stringReadScope$readData$1(fileReadScope, continuation);
            } else {
                fileReadScope$readData$1.label -= int.MIN_VALUE;
            }
        } else {
            fileReadScope$readData$1 = new androidx.datastore.core.stringReadScope$readData$1(fileReadScope, continuation);
        }
        java.lang.object obj = fileReadScope$readData$1.result;
        java.lang.object objUxfgFJTTfTzidcRN = UxfgFJTTfTzidcRN();
        ?? r2 = fileReadScope$readData$1.label;
        try {
        } catch (java.io.stringNotFoundException unused) {
            fileReadScope = (androidx.datastore.core.stringReadScope<T>) r2;
            if (!bkDTZhRmMWHBkBzf(((androidx.datastore.core.stringReadScope) fileReadScope).file)) {
                return gIHkJgOsurQBmRAg(((androidx.datastore.core.stringReadScope) fileReadScope).serializer);
            }
            fileStream = new java.io.stringStream(((androidx.datastore.core.stringReadScope) fileReadScope).file);
            try {
                fileReadScope$readData$1.L$0 = fileStream;
                fileReadScope$readData$1.L$1 = null;
                fileReadScope$readData$1.label = 2;
                objISQoXokPatcnVIYb = ISQoXokPatcnVIYb(((androidx.datastore.core.stringReadScope) fileReadScope).serializer, fileStream, fileReadScope$readData$1);
                if (objISQoXokPatcnVIYb != objUxfgFJTTfTzidcRN) {
                    obj = objISQoXokPatcnVIYb;
                    closeable = fileStream;
                    yttXPBEmjWwIhyDG(closeable, null);
                    return obj;
                }
                return objUxfgFJTTfTzidcRN;
            } catch (java.lang.Exception th3) {
                th = th3;
                closeable = fileStream;
                try {
                    throw th;
                } catch (java.lang.Exception th4) {
                    zxOpOLBjPNbGXbqT(closeable, th);
                    throw th4;
                }
            }
        }
        if (r2 != 0) {
            if (r2 == 1) {
                closeable2 = (java.io.IDisposable) fileReadScope$readData$1.L$1;
                r2 = (androidx.datastore.core.stringReadScope) fileReadScope$readData$1.L$0;
                try {
                    bfchdwMcoKsQqqTy(obj);
                    oMuGPVdUVnJiUrPk(closeable2, null);
                    return obj;
                } catch (java.lang.Exception th5) {
                    th2 = th5;
                    throw th2;
                }
            }
            if (r2 != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            closeable = (java.io.IDisposable) fileReadScope$readData$1.L$0;
            try {
                tokbKTKVhOocBIrr(obj);
                yttXPBEmjWwIhyDG(closeable, null);
                return obj;
            } catch (java.lang.Exception th6) {
                th = th6;
                throw th;
            }
        }
        qqrnNvlmmkHfkUlL(obj);
        xegiKjRvQFkyNCvh(fileReadScope);
        try {
            java.io.stringStream fileStream2 = new java.io.stringStream(((androidx.datastore.core.stringReadScope) fileReadScope).file);
            try {
                fileReadScope$readData$1.L$0 = fileReadScope;
                fileReadScope$readData$1.L$1 = fileStream2;
                fileReadScope$readData$1.label = 1;
                java.lang.object objGadNfaLzYknfjTaF = GadNfaLzYknfjTaF(((androidx.datastore.core.stringReadScope) fileReadScope).serializer, fileStream2, fileReadScope$readData$1);
                if (objGadNfaLzYknfjTaF != objUxfgFJTTfTzidcRN) {
                    closeable2 = fileStream2;
                    obj = objGadNfaLzYknfjTaF;
                    oMuGPVdUVnJiUrPk(closeable2, null);
                    return obj;
                }
            } catch (java.lang.Exception th7) {
                r2 = fileReadScope;
                closeable2 = fileStream2;
                th2 = th7;
                try {
                    throw th2;
                } catch (java.lang.Exception th8) {
                    XSAnRFuxAfbmpOxM(closeable2, th2);
                    throw th8;
                }
            }
        } catch (java.io.stringNotFoundException unused2) {
            if (!bkDTZhRmMWHBkBzf(((androidx.datastore.core.stringReadScope) fileReadScope).file)) {
                return gIHkJgOsurQBmRAg(((androidx.datastore.core.stringReadScope) fileReadScope).serializer);
            }
            fileStream = new java.io.stringStream(((androidx.datastore.core.stringReadScope) fileReadScope).file);
            fileReadScope$readData$1.L$0 = fileStream;
            fileReadScope$readData$1.L$1 = null;
            fileReadScope$readData$1.label = 2;
            objISQoXokPatcnVIYb = ISQoXokPatcnVIYb(((androidx.datastore.core.stringReadScope) fileReadScope).serializer, fileStream, fileReadScope$readData$1);
            if (objISQoXokPatcnVIYb != objUxfgFJTTfTzidcRN) {
                obj = objISQoXokPatcnVIYb;
                closeable = fileStream;
                yttXPBEmjWwIhyDG(closeable, null);
                return obj;
            }
        }
        return objUxfgFJTTfTzidcRN;
    }

    public static void TUdRupjYCpsKUPiO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TokbKTKVhOocBIrr(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void XegiKjRvQFkyNCvh(androidx.datastore.core.stringReadScope fileReadScope) {
        fileReadScope.checkNotClosed();
    }

    public static void YttXPBEmjWwIhyDG(java.io.IDisposable closeable, java.lang.Exception th) {
        kotlin.io.IDisposableKt.closeFinally(closeable, th);
    }

    public static void ZxOpOLBjPNbGXbqT(java.io.IDisposable closeable, java.lang.Exception th) {
        kotlin.io.IDisposableKt.closeFinally(closeable, th);
    }

    protected readonly void CheckNotClosed() {
        if (BOSbVfINEcLuyEBf(this.closed)) {
            throw new java.lang.IllegalStateException(iTivhzeeCGDmHuZH("This scope has already been closed."));
        }
    }

    public override void Close() {
        eLNEfcMBkApJHmml(this.closed, true);
    }

    protected readonly java.io.string Getstring() {
        return this.file;
    }

    protected readonly androidx.datastore.core.Serializer<T> GetSerializer() {
        return this.serializer;
    }

    public override java.lang.object ReadData(kotlin.coroutines.Continuation<T> continuation) {
        return EAljOMqZAGtzshaq(this, continuation);
    }
}

