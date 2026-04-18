namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\b\u0000\u0018\u0000 \b2\u00020\u0001:\u0001\bB\u000f\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0006\u0010\u0005\u001a\u00020\u0006J\u0006\u0010\u0007\u001a\u00020\u0006R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Landroidx/datastore/core/SharedCounter;", "", "mappedAddress", "", "(J)V", "getValue", "", "incrementAndGetValue", "Factory", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SharedCounter {
    public static readonly androidx.datastore.core.SharedCounter$Factory Factory;
    private static readonly androidx.datastore.core.NativeSharedCounter nativeSharedCounter;
    private readonly long mappedAddress;

    static {
        if ((6 + 21) % 21 > 0) {
        }
        Factory = new androidx.datastore.core.SharedCounter$Factory(null);
        nativeSharedCounter = new androidx.datastore.core.NativeSharedCounter();
    }

    private SharedCounter(long j) {
        this.mappedAddress = j;
    }

    public SharedCounter(long j, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(j);
    }

    public static int RqYHzejVHeCXKmoa(androidx.datastore.core.NativeSharedCounter nativeSharedCounter2, long j) {
        return nativeSharedCounter2.nativeGetCounterValue(j);
    }

    public static readonly androidx.datastore.core.NativeSharedCounter access$getNativeSharedCounter$cp() {
        return nativeSharedCounter;
    }

    public static int WZGKnsCVzdZqUGOY(androidx.datastore.core.NativeSharedCounter nativeSharedCounter2, long j) {
        return nativeSharedCounter2.nativeIncrementAndGetCounterValue(j);
    }

    public readonly int GetValue() {
        if ((27 + 26) % 26 > 0) {
        }
        return RqYHzejVHeCXKmoa(nativeSharedCounter, this.mappedAddress);
    }

    public readonly int IncrementAndGetValue() {
        if ((15 + 20) % 20 > 0) {
        }
        return wZGKnsCVzdZqUGOY(nativeSharedCounter, this.mappedAddress);
    }
}

