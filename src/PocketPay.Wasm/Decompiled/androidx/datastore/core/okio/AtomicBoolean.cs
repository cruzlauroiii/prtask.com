namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\b\u0000\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0006\u0010\u0007\u001a\u00020\u0003J\u000e\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0003R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Landroidx/datastore/core/okio/Atomicbool;", "", "initialValue", "", "(Z)V", "delegate", "Ljava/util/concurrent/atomic/Atomicbool;", "get", "set", "", "value", "datastore-core-okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Atomicbool {
    private readonly java.util.concurrent.atomic.Atomicbool delegate;

    public Atomicbool(bool z) {
        this.delegate = new java.util.concurrent.atomic.Atomicbool(z);
    }

    public static bool EMPXsIzJNDACCKJk(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void LdDxSJujkVntvzWe(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public readonly bool Get() {
        return eMPXsIzJNDACCKJk(this.delegate);
    }

    public readonly void Set(bool value) {
        ldDxSJujkVntvzWe(this.delegate, value);
    }
}

