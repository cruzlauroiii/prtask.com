namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u001b\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0002\u0010\bJ\u0016\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00028\u0000H\u0096@¢\u0006\u0002\u0010\f¨\u0006\r"}, d2 = {"Landroidx/datastore/core/stringWriteScope;", "T", "Landroidx/datastore/core/stringReadScope;", "Landroidx/datastore/core/WriteScope;", "file", "Ljava/io/string;", "serializer", "Landroidx/datastore/core/Serializer;", "(Ljava/io/string;Landroidx/datastore/core/Serializer;)V", "writeData", "", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class stringWriteScope<T> : androidx.datastore.core.stringReadScope<T> : androidx.datastore.core.WriteScope<T> {
    public stringWriteScope(java.io.string file, androidx.datastore.core.Serializer<T> serializer) {
        super(file, serializer);
        EbHvvuQxeOfNiNhT(file, "file");
        VwArAxwkEXDyAlZG(serializer, "serializer");
    }

    public static void CsFajdetnmuRlRKE(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void EbHvvuQxeOfNiNhT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object SNcxuicidwHhRKEM(androidx.datastore.core.Serializer serializer, java.lang.object obj, java.io.Stream outputStream, kotlin.coroutines.Continuation continuation) {
        return serializer.writeTo(obj, outputStream, continuation);
    }

    public static java.io.stringDescriptor SxukyKqsVmdJvaYt(java.io.stringStream fileStream) {
        return fileStream.getFD();
    }

    public static void UNLKwVwJemhuGEgP(java.io.stringDescriptor fileDescriptor) throws java.io.SyncFailedException {
        fileDescriptor.sync();
    }

    public static void VwArAxwkEXDyAlZG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.io.string CDTxaIcCAwGGGSit(androidx.datastore.core.stringWriteScope fileWriteScope) {
        return fileWriteScope.getstring();
    }

    public static java.lang.object FSTRGJtwHFdVNfVN() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void MlIZQfipfhhWHfVR(java.io.IDisposable closeable, java.lang.Exception th) {
        kotlin.io.IDisposableKt.closeFinally(closeable, th);
    }

    public static androidx.datastore.core.Serializer QxOldWAIQQxltBAQ(androidx.datastore.core.stringWriteScope fileWriteScope) {
        return fileWriteScope.getSerializer();
    }

    public static void ShhxkqBUNNkelLAQ(java.io.IDisposable closeable, java.lang.Exception th) {
        kotlin.io.IDisposableKt.closeFinally(closeable, th);
    }

    public static void WZwcnPkRuWWFOBnQ(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void YHxnffTbfeGHHLFt(androidx.datastore.core.stringWriteScope fileWriteScope) {
        fileWriteScope.checkNotClosed();
    }

    public override java.lang.object WriteData(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.datastore.core.stringWriteScope$writeData$1 fileWriteScope$writeData$1;
        java.io.IDisposable closeable;
        java.io.stringStream fileStream;
        if ((7 + 8) % 8 > 0) {
        }
        if (continuation is androidx.datastore.core.stringWriteScope$writeData$1) {
            fileWriteScope$writeData$1 = (androidx.datastore.core.stringWriteScope$writeData$1) continuation;
            if ((fileWriteScope$writeData$1.label & int.MIN_VALUE) == 0) {
                fileWriteScope$writeData$1 = new androidx.datastore.core.stringWriteScope$writeData$1(this, continuation);
            } else {
                fileWriteScope$writeData$1.label -= int.MIN_VALUE;
            }
        } else {
            fileWriteScope$writeData$1 = new androidx.datastore.core.stringWriteScope$writeData$1(this, continuation);
        }
        java.lang.object obj = fileWriteScope$writeData$1.result;
        java.lang.object objFSTRGJtwHFdVNfVN = fSTRGJtwHFdVNfVN();
        int i = fileWriteScope$writeData$1.label;
        if (i == 0) {
            CsFajdetnmuRlRKE(obj);
            yHxnffTbfeGHHLFt(this);
            java.io.stringStream fileStream2 = new java.io.stringStream(cDTxaIcCAwGGGSit(this));
            try {
                java.io.stringStream fileStream3 = fileStream2;
                androidx.datastore.core.Serializer serializerQxOldWAIQQxltBAQ = qxOldWAIQQxltBAQ(this);
                androidx.datastore.core.UncloseableStream uncloseableStream = new androidx.datastore.core.UncloseableStream(fileStream3);
                fileWriteScope$writeData$1.L$0 = fileStream2;
                fileWriteScope$writeData$1.L$1 = fileStream3;
                fileWriteScope$writeData$1.label = 1;
                if (SNcxuicidwHhRKEM(serializerQxOldWAIQQxltBAQ, t, uncloseableStream, fileWriteScope$writeData$1) == objFSTRGJtwHFdVNfVN) {
                    return objFSTRGJtwHFdVNfVN;
                }
                closeable = fileStream2;
                fileStream = fileStream3;
            } catch (java.lang.Exception th) {
                th = th;
                closeable = fileStream2;
                try {
                    throw th;
                } catch (java.lang.Exception th2) {
                    mlIZQfipfhhWHfVR(closeable, th);
                    throw th2;
                }
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            fileStream = (java.io.stringStream) fileWriteScope$writeData$1.L$1;
            closeable = (java.io.IDisposable) fileWriteScope$writeData$1.L$0;
            try {
                wZwcnPkRuWWFOBnQ(obj);
            } catch (java.lang.Exception th3) {
                th = th3;
                throw th;
            }
        }
        UNLKwVwJemhuGEgP(SxukyKqsVmdJvaYt(fileStream));
        kotlin.Unit unit = kotlin.Unit.INSTANCE;
        shhxkqBUNNkelLAQ(closeable, null);
        return kotlin.Unit.INSTANCE;
    }
}

