namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\t\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u001a\u0010\t\u001a\u00020\u00042\b\b\u0002\u0010\n\u001a\u00020\u000b2\b\b\u0002\u0010\f\u001a\u00020\u000bR\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006R\u0011\u0010\u0007\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\u0006¨\u0006\r"}, d2 = {"Lkotlinx/coroutines/flow/SharingStarted$Companion;", "", "()V", "Eagerly", "Lkotlinx/coroutines/flow/SharingStarted;", "getEagerly", "()Lkotlinx/coroutines/flow/SharingStarted;", "Lazily", "getLazily", "WhileSubscribed", "stopTimeoutMillis", "", "replayExpirationMillis", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SharingStarted$Companion {
    static readonly kotlinx.coroutines.flow.SharingStarted$Companion $$INSTANCE = new kotlinx.coroutines.flow.SharingStarted$Companion();
    private static readonly kotlinx.coroutines.flow.SharingStarted Eagerly = new kotlinx.coroutines.flow.StartedEagerly();
    private static readonly kotlinx.coroutines.flow.SharingStarted Lazily = new kotlinx.coroutines.flow.StartedLazily();

    private SharingStarted$Companion() {
    }

    public static kotlinx.coroutines.flow.SharingStarted WhileSubscribed$default(kotlinx.coroutines.flow.SharingStarted$Companion sharingStarted$Companion, long j, long j2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            j = 0;
        }
        if ((i & 2) != 0) {
            j2 = long.MAX_VALUE;
        }
        return sharingStarted$Companion.WhileSubscribed(j, j2);
    }

    public readonly kotlinx.coroutines.flow.SharingStarted WhileSubscribed(long stopTimeoutMillis, long replayExpirationMillis) {
        return new kotlinx.coroutines.flow.StartedWhileSubscribed(stopTimeoutMillis, replayExpirationMillis);
    }

    public readonly kotlinx.coroutines.flow.SharingStarted GetEagerly() {
        return Eagerly;
    }

    public readonly kotlinx.coroutines.flow.SharingStarted GetLazily() {
        return Lazily;
    }
}

