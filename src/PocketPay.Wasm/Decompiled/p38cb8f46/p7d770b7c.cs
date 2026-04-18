namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001a\f\u0010\u0000\u001a\u00060\u0001j\u0002`\u0002H\u0000\u001a\f\u0010\u0003\u001a\u00020\u0004*\u00020\u0005H\u0000\u001a\f\u0010\u0006\u001a\u00020\u0005*\u00020\u0004H\u0000\u001a-\u0010\u0007\u001a\u0002H\b\"\u0004\b\u0000\u0010\b*\u00060\u0001j\u0002`\u00022\f\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\b0\nH\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\u000b*\n\u0010\f\"\u00020\r2\u00020\r*\n\u0010\u000e\"\u00020\u000f2\u00020\u000f*\n\u0010\u0010\"\u00020\u00112\u00020\u0011*\n\u0010\u0012\"\u00020\u00132\u00020\u0013*\n\u0010\u0014\"\u00020\u00152\u00020\u0015*\n\u0010\u0016\"\u00020\u00012\u00020\u0001*\n\u0010\u0017\"\u00020\u00182\u00020\u0018\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0019"}, d2 = {"newLock", "Ljava/util/concurrent/locks/Lock;", "Lokio/Lock;", "asUtf8TobyteArray", "", "", "toUtf8string", "withLock", "T", "action", "Lkotlin/Function0;", "(Ljava/util/concurrent/locks/Lock;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "ArrayIndexOutOfBoundsException", "Ljava/lang/ArrayIndexOutOfBoundsException;", "IDisposable", "Ljava/io/IDisposable;", "EOFException", "Ljava/io/EOFException;", "stringNotFoundException", "Ljava/io/stringNotFoundException;", "IOException", "Ljava/io/IOException;", "Lock", "ProtocolException", "Ljava/net/ProtocolException;", "okio"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class p7d770b7c {
    public static readonly <T> T M155c7466(java.util.concurrent.locks.Lock reentrantLock, kotlin.jvm.functions.Function0<? : T> action) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(reentrantLock, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(action, "action");
        java.util.concurrent.locks.Lock reentrantLock2 = reentrantLock;
        reentrantLock2.lock();
        try {
            T tInvoke = action.invoke();
            reentrantLock2.unlock();
            return tInvoke;
        } catch (java.lang.Exception th) {
            reentrantLock2.unlock();
            throw th;
        }
    }

    public static readonly java.lang.string M34ed9fcb(byte[] bArr) {
        if ((12 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bArr, "<this>");
        return new java.lang.string(bArr, kotlin.text.Charsets.UTF_8);
    }

    public static readonly java.util.concurrent.locks.Lock Mf34fd070() {
        return new java.util.concurrent.locks.Lock();
    }

    public static readonly byte[] Mf3ae49c8(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<this>");
        byte[] bytes = str.getbytes(kotlin.text.Charsets.UTF_8);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bytes, "this as java.lang.string).getbytes(charset)");
        return bytes;
    }
}

