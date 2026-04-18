namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.activity.FullyDrawnReporterKt", m533f = "FullyDrawnReporter.kt", m534i = {0}, m535l = {185}, m536m = "reportWhenComplete", m537n = {"$this$reportWhenComplete"}, m538s = {"L$0"})
readonly class FullyDrawnReporterKt$reportWhenComplete$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;

    FullyDrawnReporterKt$reportWhenComplete$1(kotlin.coroutines.Continuation<? super androidx.activity.FullyDrawnReporterKt$reportWhenComplete$1> continuation) {
        super(continuation);
    }

    public static java.lang.object WZKqGHmERXPPgUhs(androidx.activity.FullyDrawnReporter fullyDrawnReporter, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation) {
        return androidx.activity.FullyDrawnReporterKt.reportWhenComplete(fullyDrawnReporter, function1, continuation);
    }

    public static void WZKqGHmERXPPgUhs(androidx.activity.FullyDrawnReporter fullyDrawnReporter, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WZKqGHmERXPPgUhs(androidx.activity.FullyDrawnReporter fullyDrawnReporter, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WZKqGHmERXPPgUhs(androidx.activity.FullyDrawnReporter fullyDrawnReporter, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return WZKqGHmERXPPgUhs(null, null, this);
    }
}

