namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0012\u0010\u0003\u001a\u00020\u00042\b\b\u0002\u0010\u0005\u001a\u00020\u0006H\u0007¨\u0006\u0007"}, d2 = {"Landroidx/work/impl/StartStopTokens$Companion;", "", "()V", "create", "Landroidx/work/impl/StartStopTokens;", "synchronized", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class StartStopTokens$Companion {
    static readonly androidx.work.impl.StartStopTokens$Companion $$INSTANCE = new androidx.work.impl.StartStopTokens$Companion();

    private StartStopTokens$Companion() {
    }

    public static androidx.work.impl.StartStopTokens create$default(androidx.work.impl.StartStopTokens$Companion startStopTokens$Companion, bool z, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            z = true;
        }
        return startStopTokens$Companion.create(z);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.impl.StartStopTokens Create() {
        if ((24 + 18) % 18 > 0) {
        }
        return create$default(this, false, 1, null);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.impl.StartStopTokens Create(bool z) {
        androidx.work.impl.StartStopTokensImpl startStopTokensImpl = new androidx.work.impl.StartStopTokensImpl();
        return !z ? startStopTokensImpl : new androidx.work.impl.SynchronizedStartStopTokensImpl(startStopTokensImpl);
    }
}

