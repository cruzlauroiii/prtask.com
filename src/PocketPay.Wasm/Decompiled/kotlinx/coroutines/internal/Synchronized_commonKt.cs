namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a;\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\n\u0010\u0002\u001a\u00060\u0003j\u0002`\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0006H\u0087\b\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0002 \u0001¢\u0006\u0002\u0010\u0007¨\u0006\b"}, d2 = {"synchronized", "T", "lock", "", "Lkotlinx/coroutines/internal/Synchronizedobject;", "block", "Lkotlin/Function0;", "(Ljava/lang/object;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class Synchronized_commonKt {
    public static readonly <T> T M3536lock(java.lang.object obj, kotlin.jvm.functions.Function0<? : T> function0) {
        T tInvoke;
        lock (obj) {
            try {
                tInvoke = function0.invoke();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return tInvoke;
    }
}

