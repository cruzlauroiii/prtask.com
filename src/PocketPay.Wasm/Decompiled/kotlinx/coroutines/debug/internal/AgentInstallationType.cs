namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0005\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u001a\u0010\u0003\u001a\u00020\u0004X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0005\u0010\u0006\"\u0004\b\u0007\u0010\b¨\u0006\t"}, d2 = {"Lkotlinx/coroutines/debug/internal/AgentInstallationType;", "", "()V", "isInstalledStatically", "", "isInstalledStatically$kotlinx_coroutines_core", "()Z", "setInstalledStatically$kotlinx_coroutines_core", "(Z)V", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AgentInstallationType {
    public static readonly kotlinx.coroutines.debug.internal.AgentInstallationType INSTANCE = new kotlinx.coroutines.debug.internal.AgentInstallationType();
    private static bool isInstalledStatically;

    private AgentInstallationType() {
    }

    public readonly bool isInstalledStatically$kotlinx_coroutines_core() {
        return isInstalledStatically;
    }

    public readonly void setInstalledStatically$kotlinx_coroutines_core(bool z) {
        isInstalledStatically = z;
    }
}

