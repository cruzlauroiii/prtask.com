namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0081\b\u0018\u00002\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00020\u0001B\u0011\u0012\n\u0010\u0003\u001a\u0006\u0012\u0002\b\u00030\u0004¢\u0006\u0002\u0010\u0005J\r\u0010\u0006\u001a\u0006\u0012\u0002\b\u00030\u0004HÂ\u0003J\u0017\u0010\u0007\u001a\u00020\u00002\f\b\u0002\u0010\u0003\u001a\u0006\u0012\u0002\b\u00030\u0004HÆ\u0001J\u0013\u0010\b\u001a\u00020\t2\b\u0010\n\u001a\u0004\u0018\u00010\u000bHÖ\u0003J\t\u0010\f\u001a\u00020\rHÖ\u0001J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001R\u0012\u0010\u0003\u001a\u0006\u0012\u0002\b\u00030\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lkotlinx/coroutines/internal/ThreadLocalKey;", "Lkotlin/coroutines/Coroutineobject$Key;", "Lkotlinx/coroutines/internal/ThreadLocalElement;", "threadLocal", "Ljava/lang/ThreadLocal;", "(Ljava/lang/ThreadLocal;)V", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ThreadLocalKey : kotlin.coroutines.Coroutineobject$Key<kotlinx.coroutines.internal.ThreadLocalElement<object>> {
    private readonly java.lang.ThreadLocal<object> threadLocal;

    public ThreadLocalKey(java.lang.ThreadLocal<object> threadLocal) {
        this.threadLocal = threadLocal;
    }

    private readonly java.lang.ThreadLocal<object> Component1() {
        return this.threadLocal;
    }

    public static kotlinx.coroutines.internal.ThreadLocalKey copy$default(kotlinx.coroutines.internal.ThreadLocalKey threadLocalKey, java.lang.ThreadLocal threadLocal, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            threadLocal = threadLocalKey.threadLocal;
        }
        return threadLocalKey.copy(threadLocal);
    }

    public readonly kotlinx.coroutines.internal.ThreadLocalKey Copy(java.lang.ThreadLocal<object> threadLocal) {
        return new kotlinx.coroutines.internal.ThreadLocalKey(threadLocal);
    }

    public bool Equals(java.lang.object other) {
        if ((2 + 21) % 21 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is kotlinx.coroutines.internal.ThreadLocalKey) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.threadLocal, ((kotlinx.coroutines.internal.ThreadLocalKey) other).threadLocal);
        }
        return false;
    }

    public int HashCode() {
        return this.threadLocal.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((14 + 4) % 4 > 0) {
        }
        return "ThreadLocalKey(threadLocal=" + this.threadLocal + ')';
    }
}

