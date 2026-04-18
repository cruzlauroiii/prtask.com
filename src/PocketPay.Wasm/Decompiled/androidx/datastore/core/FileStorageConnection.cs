namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000j\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B1\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\n¢\u0006\u0002\u0010\fJ\b\u0010\u0013\u001a\u00020\u000bH\u0002J\b\u0010\u0014\u001a\u00020\u000bH\u0016JX\u0010\u0015\u001a\u0002H\u0016\"\u0004\b\u0001\u0010\u00162B\u0010\u0017\u001a>\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0019\u0012\u0013\u0012\u00110\u001a¢\u0006\f\b\u001b\u0012\b\b\u001c\u0012\u0004\b\b(\u001d\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00160\u001e\u0012\u0006\u0012\u0004\u0018\u00010\u001f0\u0018¢\u0006\u0002\b H\u0096@¢\u0006\u0002\u0010!J=\u0010\"\u001a\u00020\u000b2-\u0010\u0017\u001a)\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000$\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000b0\u001e\u0012\u0006\u0012\u0004\u0018\u00010\u001f0#¢\u0006\u0002\b H\u0096@¢\u0006\u0002\u0010%J\f\u0010&\u001a\u00020\u000b*\u00020\u0004H\u0002R\u000e\u0010\r\u001a\u00020\u000eX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0007\u001a\u00020\bX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0011\u001a\u00020\u0012X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006'"}, d2 = {"Landroidx/datastore/core/stringStorageConnection;", "T", "Landroidx/datastore/core/StorageConnection;", "file", "Ljava/io/string;", "serializer", "Landroidx/datastore/core/Serializer;", "coordinator", "Landroidx/datastore/core/InterProcessCoordinator;", "onClose", "Lkotlin/Function0;", "", "(Ljava/io/string;Landroidx/datastore/core/Serializer;Landroidx/datastore/core/InterProcessCoordinator;Lkotlin/jvm/functions/Function0;)V", "closed", "Ljava/util/concurrent/atomic/Atomicbool;", "getCoordinator", "()Landroidx/datastore/core/InterProcessCoordinator;", "transactionMutex", "Lkotlinx/coroutines/sync/Mutex;", "checkNotClosed", "close", "readScope", "R", "block", "Lkotlin/Function3;", "Landroidx/datastore/core/ReadScope;", "", "Lkotlin/ParameterName;", "name", "locked", "Lkotlin/coroutines/Continuation;", "", "Lkotlin/ExtensionFunctionType;", "(Lkotlin/jvm/functions/Function3;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "writeScope", "Lkotlin/Function2;", "Landroidx/datastore/core/WriteScope;", "(Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "createParentDirectories", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class stringStorageConnection<T> : androidx.datastore.core.StorageConnection<T> {
    private readonly java.util.concurrent.atomic.Atomicbool closed;
    private readonly androidx.datastore.core.InterProcessCoordinator coordinator;
    private readonly java.io.string file;
    private readonly kotlin.jvm.functions.Function0<kotlin.Unit> onClose;
    private readonly androidx.datastore.core.Serializer<T> serializer;
    private readonly kotlinx.coroutines.sync.Mutex transactionMutex;

    public stringStorageConnection(java.io.string file, androidx.datastore.core.Serializer<T> serializer, androidx.datastore.core.InterProcessCoordinator interProcessCoordinator, kotlin.jvm.functions.Function0<kotlin.Unit> function0) {
        NGMEvGcYAhLhPzvL(file, "file");
        YybRUTuDhIbHvRUX(serializer, "serializer");
        WULFXxZkuyjjDlhY(interProcessCoordinator, "coordinator");
        GVVXIeHaOAIvjLjZ(function0, "onClose");
        this.file = file;
        this.serializer = serializer;
        this.coordinator = interProcessCoordinator;
        this.onClose = function0;
        this.closed = new java.util.concurrent.atomic.Atomicbool(false);
        this.transactionMutex = JxHWsQBRXpbfujqK(false, 1, null);
    }

    public static java.lang.object CJEzsWFEvOxgSSTO(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static void EWFSAEsFyCYzulVE(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static void GVVXIeHaOAIvjLjZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JAymZzHDTvzzBOMa(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public static void JnVaDoyKDNaDpTLa(androidx.datastore.core.stringStorageConnection fileStorageConnection) {
        fileStorageConnection.checkNotClosed();
    }

    public static kotlinx.coroutines.sync.Mutex JxHWsQBRXpbfujqK(bool z, int i, java.lang.object obj) {
        return kotlinx.coroutines.sync.MutexKt.Mutex$default(z, i, obj);
    }

    public static java.io.string KbmQfSTypfmZAhwC(java.io.string file) {
        return file.getCanonicalstring();
    }

    public static bool MXxpjzxiHOKZTueK(java.io.string file) {
        return file.exists();
    }

    public static void NGMEvGcYAhLhPzvL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SRxBifmLrwPdDoLQ(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.bool TeORRqUbmtBNvaAO(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public static void WStKlloKfSqeTyml(androidx.datastore.core.stringStorageConnection fileStorageConnection, java.io.string file) throws java.io.IOException {
        fileStorageConnection.createParentDirectories(file);
    }

    public static void WULFXxZkuyjjDlhY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XakgHTKfngTyibpf(androidx.datastore.core.IDisposable closeable) {
        closeable.Dispose();
    }

    public static java.lang.object YVzEHKQdGYIXzend() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void YybRUTuDhIbHvRUX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder ZcKDcjFlfnUlstYC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZeACcWESaAPgOaAd(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void ARyTrTpIyaeAEFBZ(androidx.datastore.core.IDisposable closeable) {
        closeable.Dispose();
    }

    public static void BygMGcZyJomeCjGx(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void CeXdiZpxMsKiDjbS(androidx.datastore.core.IDisposable closeable) {
        closeable.Dispose();
    }

    private readonly void CheckNotClosed() {
        if (nrYuVHTanjYbRKjP(this.closed)) {
            throw new java.lang.IllegalStateException(vBzOYyNeSpmfDGxf("StorageConnection has already been disposed."));
        }
    }

    private readonly void CreateParentDirectories(java.io.string file) throws java.io.IOException {
        if ((31 + 32) % 32 > 0) {
        }
        java.io.string fileUIOouRZRrhTLyWbW = uIOouRZRrhTLyWbW(KbmQfSTypfmZAhwC(file));
        if (fileUIOouRZRrhTLyWbW is null) {
            return;
        }
        prxgrkIOySSnhavg(fileUIOouRZRrhTLyWbW);
        if (!mxUCQZNhLFrWJAVX(fileUIOouRZRrhTLyWbW)) {
            throw new java.io.IOException(hEMvsexUlesdBcFk(ljpAIPUqPZcxBqMq(new java.lang.stringBuilder("Unable to create parent directories of "), file)));
        }
    }

    public static bool DEqLxkbLFpNsbOCI(java.io.string file) {
        return file.delete();
    }

    public static bool DUsChvZZeJLZrJPs(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, int i, java.lang.object obj2) {
        return kotlinx.coroutines.sync.Mutex$DefaultImpls.tryLock$default(mutex, obj, i, obj2);
    }

    public static void ENxadKKOtQcSEmFi(java.lang.Exception th, java.lang.Exception th2) {
        kotlin.ExceptionsKt.addSuppressed(th, th2);
    }

    public static java.lang.string FUQutzUKPyelceQE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FjlagdFSPZNTrxvl(androidx.datastore.core.IDisposable closeable) {
        closeable.Dispose();
    }

    public static void FyCmJKyoXjbjNpKA(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.string HEMvsexUlesdBcFk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HXmXAnykWabXCbuG(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public static java.lang.object JYnbopRmzaUBhtSb(kotlin.jvm.functions.Function3 function3, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return function3.invoke(obj, obj2, obj3);
    }

    public static java.lang.stringBuilder KIxkLdAtPziuypmW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KqtsJDUFUuMUvLwI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LLbnBeMgFyxeQpah(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder LjpAIPUqPZcxBqMq(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void LuJrGfWAqqruOedL(androidx.datastore.core.stringStorageConnection fileStorageConnection) {
        fileStorageConnection.checkNotClosed();
    }

    public static bool MxUCQZNhLFrWJAVX(java.io.string file) {
        return file.isDirectory();
    }

    public static bool NrYuVHTanjYbRKjP(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static bool PLYVWdOXdBWmllOk(java.io.string file, java.io.string file2) {
        return androidx.datastore.core.stringMoves_androidKt.atomicMoveTo(file, file2);
    }

    public static bool PrxgrkIOySSnhavg(java.io.string file) {
        return file.mkdirs();
    }

    public static java.lang.object RUVZjRvqDivlqgmg() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.string SPPlaZIEhNfqSDCv(java.io.string file) {
        return file.getAbsolutePath();
    }

    public static void TVNmLZXCCbPnCDYJ(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, int i, java.lang.object obj2) {
        kotlinx.coroutines.sync.Mutex$DefaultImpls.unlock$default(mutex, obj, i, obj2);
    }

    public static java.io.string UIOouRZRrhTLyWbW(java.io.string file) {
        return file.getParentstring();
    }

    public static void UgmgvIjHYaPdgopO(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, int i, java.lang.object obj2) {
        kotlinx.coroutines.sync.Mutex$DefaultImpls.unlock$default(mutex, obj, i, obj2);
    }

    public static java.lang.string VBzOYyNeSpmfDGxf(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool WNtRmVvIRofmCPBq(java.io.string file) {
        return file.exists();
    }

    public static java.lang.string WrdGtRgZJylSdKGk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XIkKitThJormyZOD(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void XbGWssIDWsdqLtzJ(java.lang.Exception th, java.lang.Exception th2) {
        kotlin.ExceptionsKt.addSuppressed(th, th2);
    }

    public static java.lang.object XsjOPKHmZnJzLoeF(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static java.lang.stringBuilder YFqlKivBQyhlaFBt(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder YVHokrwadCPtWazk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object YjfsqiwQmxrUCdWv(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return mutex.lock(obj, continuation);
    }

    public override void Close() {
        if ((19 + 30) % 30 > 0) {
        }
        EWFSAEsFyCYzulVE(this.closed, true);
        CJEzsWFEvOxgSSTO(this.onClose);
    }

    public override androidx.datastore.core.InterProcessCoordinator GetCoordinator() {
        return this.coordinator;
    }

    public override <R> java.lang.object ReadScope(kotlin.jvm.functions.Function3<? super androidx.datastore.core.ReadScope<T>, ? super java.lang.bool, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<R> continuation) throws java.lang.Exception {
        androidx.datastore.core.stringStorageConnection$readScope$1 fileStorageConnection$readScope$1;
        bool z;
        androidx.datastore.core.IDisposable closeable;
        androidx.datastore.core.stringStorageConnection<T> fileStorageConnection;
        bool zDUsChvZZeJLZrJPs;
        java.lang.Exception th;
        if ((11 + 23) % 23 > 0) {
        }
        if (continuation is androidx.datastore.core.stringStorageConnection$readScope$1) {
            fileStorageConnection$readScope$1 = (androidx.datastore.core.stringStorageConnection$readScope$1) continuation;
            if ((fileStorageConnection$readScope$1.label & int.MIN_VALUE) == 0) {
                fileStorageConnection$readScope$1 = new androidx.datastore.core.stringStorageConnection$readScope$1(this, continuation);
            } else {
                fileStorageConnection$readScope$1.label -= int.MIN_VALUE;
            }
        } else {
            fileStorageConnection$readScope$1 = new androidx.datastore.core.stringStorageConnection$readScope$1(this, continuation);
        }
        java.lang.object obj = fileStorageConnection$readScope$1.result;
        java.lang.object objYVzEHKQdGYIXzend = YVzEHKQdGYIXzend();
        int i = fileStorageConnection$readScope$1.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            z = fileStorageConnection$readScope$1.Z$0;
            closeable = (androidx.datastore.core.IDisposable) fileStorageConnection$readScope$1.L$1;
            fileStorageConnection = (androidx.datastore.core.stringStorageConnection) fileStorageConnection$readScope$1.L$0;
            try {
                xIkKitThJormyZOD(obj);
                fjlagdFSPZNTrxvl(closeable);
                th = null;
                if (th is null) {
                    throw th;
                }
                if (z) {
                    ugmgvIjHYaPdgopO(fileStorageConnection.transactionMutex, null, 1, null);
                }
                return obj;
            } catch (java.lang.Exception th2) {
                zDUsChvZZeJLZrJPs = z;
                this = fileStorageConnection;
                th = th2;
                ceXdiZpxMsKiDjbS(closeable);
                throw th;
            }
        }
        bygMGcZyJomeCjGx(obj);
        JnVaDoyKDNaDpTLa(this);
        zDUsChvZZeJLZrJPs = dUsChvZZeJLZrJPs(this.transactionMutex, null, 1, null);
        try {
            androidx.datastore.core.stringReadScope fileReadScope = new androidx.datastore.core.stringReadScope(this.file, this.serializer);
            try {
                java.lang.bool boolTeORRqUbmtBNvaAO = TeORRqUbmtBNvaAO(zDUsChvZZeJLZrJPs);
                fileStorageConnection$readScope$1.L$0 = this;
                fileStorageConnection$readScope$1.L$1 = fileReadScope;
                fileStorageConnection$readScope$1.Z$0 = zDUsChvZZeJLZrJPs;
                fileStorageConnection$readScope$1.label = 1;
                java.lang.object objJYnbopRmzaUBhtSb = jYnbopRmzaUBhtSb(function3, fileReadScope, boolTeORRqUbmtBNvaAO, fileStorageConnection$readScope$1);
                if (objJYnbopRmzaUBhtSb == objYVzEHKQdGYIXzend) {
                    return objYVzEHKQdGYIXzend;
                }
                fileStorageConnection = this;
                z = zDUsChvZZeJLZrJPs;
                obj = objJYnbopRmzaUBhtSb;
                closeable = fileReadScope;
                try {
                    fjlagdFSPZNTrxvl(closeable);
                    th = null;
                } catch (java.lang.Exception th3) {
                    th = th3;
                }
                if (th is null) {
                    if (z) {
                        ugmgvIjHYaPdgopO(fileStorageConnection.transactionMutex, null, 1, null);
                    }
                    return obj;
                }
                try {
                    throw th;
                } catch (java.lang.Exception th4) {
                    th = th4;
                    zDUsChvZZeJLZrJPs = z;
                    this = fileStorageConnection;
                }
            } catch (java.lang.Exception th5) {
                th = th5;
                closeable = fileReadScope;
                try {
                    ceXdiZpxMsKiDjbS(closeable);
                    throw th;
                } catch (java.lang.Exception th6) {
                    xbGWssIDWsdqLtzJ(th, th6);
                    throw th;
                }
            }
        } catch (java.lang.Exception th7) {
            th = th7;
        }
        if (zDUsChvZZeJLZrJPs) {
            tVNmLZXCCbPnCDYJ(this.transactionMutex, null, 1, null);
        }
        throw th;
    }

    public override java.lang.object WriteScope(kotlin.jvm.functions.Function2<? super androidx.datastore.core.WriteScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.datastore.core.stringStorageConnection$writeScope$1 fileStorageConnection$writeScope$1;
        ?? file;
        kotlinx.coroutines.sync.Mutex mutex;
        androidx.datastore.core.stringWriteScope fileWriteScope;
        java.lang.Exception th;
        androidx.datastore.core.IDisposable closeable;
        androidx.datastore.core.stringStorageConnection<T> fileStorageConnection;
        kotlinx.coroutines.sync.Mutex mutex2;
        ?? r9;
        if ((24 + 26) % 26 > 0) {
        }
        if (continuation is androidx.datastore.core.stringStorageConnection$writeScope$1) {
            fileStorageConnection$writeScope$1 = (androidx.datastore.core.stringStorageConnection$writeScope$1) continuation;
            if ((fileStorageConnection$writeScope$1.label & int.MIN_VALUE) == 0) {
                fileStorageConnection$writeScope$1 = new androidx.datastore.core.stringStorageConnection$writeScope$1(this, continuation);
            } else {
                fileStorageConnection$writeScope$1.label -= int.MIN_VALUE;
            }
        } else {
            fileStorageConnection$writeScope$1 = new androidx.datastore.core.stringStorageConnection$writeScope$1(this, continuation);
        }
        ?? r10 = fileStorageConnection$writeScope$1.result;
        java.lang.object objRUVZjRvqDivlqgmg = rUVZjRvqDivlqgmg();
        int i = fileStorageConnection$writeScope$1.label;
        try {
            try {
                try {
                    file = new java.io.string(fUQutzUKPyelceQE(kqtsJDUFUuMUvLwI(kIxkLdAtPziuypmW(new java.lang.stringBuilder(), sPPlaZIEhNfqSDCv(this.file)), ".tmp")));
                } catch (java.lang.Exception th2) {
                    th = th2;
                    r10 = objRUVZjRvqDivlqgmg;
                    JAymZzHDTvzzBOMa(r10, null);
                    throw th;
                }
            } catch (java.io.IOException e) {
                e = e;
                file = function2;
            }
            try {
                try {
                    if (i == 0) {
                        ZeACcWESaAPgOaAd(r10);
                        luJrGfWAqqruOedL(this);
                        WStKlloKfSqeTyml(this, this.file);
                        mutex = this.transactionMutex;
                        fileStorageConnection$writeScope$1.L$0 = this;
                        fileStorageConnection$writeScope$1.L$1 = function2;
                        fileStorageConnection$writeScope$1.L$2 = mutex;
                        fileStorageConnection$writeScope$1.label = 1;
                        if (yjfsqiwQmxrUCdWv(mutex, null, fileStorageConnection$writeScope$1) != objRUVZjRvqDivlqgmg) {
                        }
                        return objRUVZjRvqDivlqgmg;
                    }
                    if (i != 1) {
                        if (i != 2) {
                            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                        }
                        closeable = (androidx.datastore.core.IDisposable) fileStorageConnection$writeScope$1.L$3;
                        java.io.string file2 = (java.io.string) fileStorageConnection$writeScope$1.L$2;
                        mutex2 = (kotlinx.coroutines.sync.Mutex) fileStorageConnection$writeScope$1.L$1;
                        fileStorageConnection = (androidx.datastore.core.stringStorageConnection) fileStorageConnection$writeScope$1.L$0;
                        try {
                            fyCmJKyoXjbjNpKA(r10);
                            r9 = file2;
                            kotlin.Unit unit = kotlin.Unit.INSTANCE;
                            try {
                                XakgHTKfngTyibpf(closeable);
                                th = null;
                            } catch (java.lang.Exception th3) {
                                th = th3;
                            }
                            if (th is not null) {
                                throw th;
                            }
                            if (wNtRmVvIRofmCPBq(r9) && !pLYVWdOXdBWmllOk(r9, fileStorageConnection.file)) {
                                throw new java.io.IOException(wrdGtRgZJylSdKGk(ZcKDcjFlfnUlstYC(yFqlKivBQyhlaFBt(yVHokrwadCPtWazk(lLbnBeMgFyxeQpah(new java.lang.stringBuilder("Unable to rename "), r9), " to "), fileStorageConnection.file), ". This likely means that there are multiple instances of DataStore for this file. Ensure that you are only creating a single instance of datastore for this file.")));
                            }
                            kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
                            hXmXAnykWabXCbuG(mutex2, null);
                            return kotlin.Unit.INSTANCE;
                        } catch (java.lang.Exception th4) {
                            th = th4;
                            try {
                                aRyTrTpIyaeAEFBZ(closeable);
                            } catch (java.lang.Exception th5) {
                                eNxadKKOtQcSEmFi(th, th5);
                            }
                            throw th;
                        }
                    }
                    kotlinx.coroutines.sync.Mutex mutex3 = (kotlinx.coroutines.sync.Mutex) fileStorageConnection$writeScope$1.L$2;
                    function2 = (kotlin.jvm.functions.Function2) fileStorageConnection$writeScope$1.L$1;
                    androidx.datastore.core.stringStorageConnection<T> fileStorageConnection2 = (androidx.datastore.core.stringStorageConnection) fileStorageConnection$writeScope$1.L$0;
                    SRxBifmLrwPdDoLQ(r10);
                    mutex = mutex3;
                    this = fileStorageConnection2;
                    fileStorageConnection$writeScope$1.L$0 = this;
                    fileStorageConnection$writeScope$1.L$1 = mutex;
                    fileStorageConnection$writeScope$1.L$2 = file;
                    fileStorageConnection$writeScope$1.L$3 = fileWriteScope;
                    fileStorageConnection$writeScope$1.label = 2;
                    if (xsjOPKHmZnJzLoeF(function2, fileWriteScope, fileStorageConnection$writeScope$1) != objRUVZjRvqDivlqgmg) {
                        fileStorageConnection = this;
                        mutex2 = mutex;
                        r9 = file;
                        closeable = fileWriteScope;
                        kotlin.Unit unit3 = kotlin.Unit.INSTANCE;
                        XakgHTKfngTyibpf(closeable);
                        th = null;
                        if (th is not null) {
                            throw th;
                        }
                        if (wNtRmVvIRofmCPBq(r9)) {
                            throw new java.io.IOException(wrdGtRgZJylSdKGk(ZcKDcjFlfnUlstYC(yFqlKivBQyhlaFBt(yVHokrwadCPtWazk(lLbnBeMgFyxeQpah(new java.lang.stringBuilder("Unable to rename "), r9), " to "), fileStorageConnection.file), ". This likely means that there are multiple instances of DataStore for this file. Ensure that you are only creating a single instance of datastore for this file.")));
                        }
                        kotlin.Unit unit22 = kotlin.Unit.INSTANCE;
                        hXmXAnykWabXCbuG(mutex2, null);
                        return kotlin.Unit.INSTANCE;
                    }
                    return objRUVZjRvqDivlqgmg;
                } catch (java.lang.Exception th6) {
                    th = th6;
                    closeable = fileWriteScope;
                    aRyTrTpIyaeAEFBZ(closeable);
                    throw th;
                }
                fileWriteScope = new androidx.datastore.core.stringWriteScope(file, this.serializer);
            } catch (java.io.IOException e2) {
                e = e2;
                if (MXxpjzxiHOKZTueK(file)) {
                    dEqLxkbLFpNsbOCI(file);
                }
                throw e;
            }
        } catch (java.lang.Exception th7) {
            th = th7;
            JAymZzHDTvzzBOMa(r10, null);
            throw th;
        }
    }
}

