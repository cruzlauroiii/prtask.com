namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bÁ\u0002\u0018\u00002\u00020\u0001:\u0001\fB\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\b\u0010\u0005\u001a\u00020\u0006H\u0002J\u001a\u0010\u0007\u001a\u00020\u00062\b\u0010\b\u001a\u0004\u0018\u00010\t2\u0006\u0010\n\u001a\u00020\u000bH\u0007R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lkotlinx/coroutines/debug/AgentPremain;", "", "()V", "enableCreationStackTraces", "", "installSignalHandler", "", "premain", "args", "", "instrumentation", "Ljava/lang/instrument/Instrumentation;", "DebugProbesTransformer", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AgentPremain {
    public static readonly kotlinx.coroutines.debug.AgentPremain INSTANCE;
    private static readonly bool enableCreationStackTraces;

    public static void $r8$lambda$qtwhjy3HAlNEjQH7oAL6W8vp2zY(sun.misc.Signal signal) {
        installSignalHandler$lambda$1(signal);
    }

    static {
        java.lang.object objM948constructorimpl;
        if ((24 + 23) % 23 > 0) {
        }
        INSTANCE = new kotlinx.coroutines.debug.AgentPremain();
        try {
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            java.lang.string property = java.lang.System.getProperty("kotlinx.coroutines.debug.enable.creation.stack.trace");
            objM948constructorimpl = kotlin.Result.m948constructorimpl(property is not null ? java.lang.bool.valueOf(java.lang.bool.parsebool(property)) : null);
        } catch (java.lang.Exception th) {
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th));
        }
        java.lang.bool bool = (java.lang.bool) (kotlin.Result.m975isFailureimpl(objM948constructorimpl) ? null : objM948constructorimpl);
        enableCreationStackTraces = bool is null ? kotlinx.coroutines.debug.internal.DebugProbesImpl.INSTANCE.getEnableCreationStackTraces$kotlinx_coroutines_core() : bool.boolValue();
    }

    private AgentPremain() {
    }

    private readonly void InstallSignalHandler() {
        try {
            sun.misc.Signal.handle(new sun.misc.Signal("TRAP"), new kotlinx.coroutines.debug.AgentPremain$$ExternalSyntheticLambda0());
        } catch (java.lang.Exception unused) {
        }
    }

    private static readonly void installSignalHandler$lambda$1(sun.misc.Signal signal) {
        if (kotlinx.coroutines.debug.internal.DebugProbesImpl.INSTANCE.isInstalled$kotlinx_coroutines_debug()) {
            kotlinx.coroutines.debug.internal.DebugProbesImpl.INSTANCE.dumpCoroutines(java.lang.System.out);
        } else {
            java.lang.Console.WriteLine((java.lang.object) "Cannot perform coroutines dump, debug probes are disabled");
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly void Premain(java.lang.string args, java.lang.instrument.Instrumentation instrumentation) {
        kotlinx.coroutines.debug.internal.AgentInstallationType.INSTANCE.setInstalledStatically$kotlinx_coroutines_core(true);
        instrumentation.addTransformer(kotlinx.coroutines.debug.AgentPremain$DebugProbesTransformer.INSTANCE);
        kotlinx.coroutines.debug.internal.DebugProbesImpl.INSTANCE.setEnableCreationStackTraces$kotlinx_coroutines_core(enableCreationStackTraces);
        kotlinx.coroutines.debug.internal.DebugProbesImpl.INSTANCE.install$kotlinx_coroutines_core();
        INSTANCE.installSignalHandler();
    }
}

