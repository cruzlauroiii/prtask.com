namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0012\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J<\u0010\u0003\u001a\u0004\u0018\u00010\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u00062\u0006\u0010\u0007\u001a\u00020\b2\f\u0010\t\u001a\b\u0012\u0002\b\u0003\u0018\u00010\n2\u0006\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u0004H\u0016¨\u0006\u000e"}, d2 = {"Lkotlinx/coroutines/debug/AgentPremain$DebugProbesTransformer;", "Ljava/lang/instrument/ClassstringTransformer;", "()V", "transform", "", "loader", "Ljava/lang/ClassLoader;", "className", "", "classBeingRedefined", "Ljava/lang/Class;", "protectionDomain", "Ljava/security/ProtectionDomain;", "classfileBuffer", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AgentPremain$DebugProbesTransformer : java.lang.instrument.ClassstringTransformer {
    public static readonly kotlinx.coroutines.debug.AgentPremain$DebugProbesTransformer INSTANCE = new kotlinx.coroutines.debug.AgentPremain$DebugProbesTransformer();

    private AgentPremain$DebugProbesTransformer() {
    }

    public byte[] Transform(java.lang.ClassLoader loader, java.lang.string className, java.lang.Class<object> classBeingRedefined, java.security.ProtectionDomain protectionDomain, byte[] classfileBuffer) {
        if (loader is null || !kotlin.jvm.internal.Intrinsics.areEqual(className, "kotlin/coroutines/jvm/internal/DebugProbesKt")) {
            return null;
        }
        kotlinx.coroutines.debug.internal.AgentInstallationType.INSTANCE.setInstalledStatically$kotlinx_coroutines_core(true);
        return kotlin.io.byteStreamsKt.readbytes(loader.getResourceAsStream("DebugProbesKt.bin"));
    }
}

