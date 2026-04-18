namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u001a+\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\b\b\u0002\u0010\u0003\u001a\u00020\u00042\b\b\u0002\u0010\u0005\u001a\u00020\u0004ø\u0001\u0000ø\u0001\u0001¢\u0006\u0004\b\u0006\u0010\u0007\u0082\u0002\u000b\n\u0005\b¡\u001e0\u0001\n\u0002\b\u0019¨\u0006\b"}, d2 = {"WhileSubscribed", "Lkotlinx/coroutines/flow/SharingStarted;", "Lkotlinx/coroutines/flow/SharingStarted$Companion;", "stopTimeout", "Lkotlin/time/Duration;", "replayExpiration", "WhileSubscribed-5qebJ5I", "(Lkotlinx/coroutines/flow/SharingStarted$Companion;JJ)Lkotlinx/coroutines/flow/SharingStarted;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SharingStartedKt {
    public static readonly kotlinx.coroutines.flow.SharingStarted M3511WhileSubscribed5qebJ5I(kotlinx.coroutines.flow.SharingStarted$Companion sharingStarted$Companion, long j, long j2) {
        return new kotlinx.coroutines.flow.StartedWhileSubscribed(kotlin.time.Duration.m3333getInWholeMillisecondsimpl(j), kotlin.time.Duration.m3333getInWholeMillisecondsimpl(j2));
    }

    public static kotlinx.coroutines.flow.SharingStarted m3512WhileSubscribed5qebJ5I$default(kotlinx.coroutines.flow.SharingStarted$Companion sharingStarted$Companion, long j, long j2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            j = kotlin.time.Duration.Companion.m3413getZEROUwyO8pc();
        }
        if ((i & 2) != 0) {
            j2 = kotlin.time.Duration.Companion.m3411getINFINITEUwyO8pc();
        }
        return m3511WhileSubscribed5qebJ5I(sharingStarted$Companion, j, j2);
    }
}

