namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a$\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00010\u0005H\u0080\bø\u0001\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0006"}, d2 = {"appendMediatorStatesIfNotNull", "", "mediatorStates", "Landroidx/paging/LoadStates;", "log", "Lkotlin/Function0;", "paging-common_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ConsoleUtilKt {
    public static readonly java.lang.string AppendMediatorStatesIfNotNull(androidx.paging.LoadStates loadStates, kotlin.jvm.functions.Function0<java.lang.string> log) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(log, "log");
        java.lang.string strInvoke = log.invoke();
        if (loadStates is not null) {
            strInvoke = strInvoke + "|   mediatorLoadStates: " + loadStates + '\n';
        }
        return kotlin.text.stringsKt.trimMargin$default(strInvoke + "|)", null, 1, null);
    }
}

