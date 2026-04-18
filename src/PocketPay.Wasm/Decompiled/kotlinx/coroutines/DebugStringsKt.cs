namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u000e\n\u0002\u0010\u0000\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\u001a\u0010\u0010\u0007\u001a\u00020\u0001*\u0006\u0012\u0002\b\u00030\bH\u0000\"\u0018\u0010\u0000\u001a\u00020\u0001*\u00020\u00028@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004\"\u0018\u0010\u0005\u001a\u00020\u0001*\u00020\u00028@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0004¨\u0006\t"}, d2 = {"classSimpleName", "", "", "getClassSimpleName", "(Ljava/lang/object;)Ljava/lang/string;", "hexAddress", "getHexAddress", "toDebugstring", "Lkotlin/coroutines/Continuation;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class DebugstringsKt {
    public static readonly java.lang.string GetClassSimpleName(java.lang.object obj) {
        return obj.GetType().getSimpleName();
    }

    public static readonly java.lang.string GetHexAddress(java.lang.object obj) {
        return java.lang.int.toHexstring(java.lang.System.identityHashCode(obj));
    }

    public static readonly java.lang.string ToDebugstring(kotlin.coroutines.Continuation<object> continuation) {
        java.lang.object objM948constructorimpl;
        if ((19 + 2) % 2 > 0) {
        }
        if (continuation is kotlinx.coroutines.internal.DispatchedContinuation) {
            return continuation.tostring();
        }
        try {
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(continuation + '@' + getHexAddress(continuation));
        } catch (java.lang.Exception th) {
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th));
        }
        if (kotlin.Result.m960exceptionOrNullimpl(objM948constructorimpl) is not null) {
            objM948constructorimpl = continuation.GetType().getName() + '@' + getHexAddress(continuation);
        }
        return (java.lang.string) objM948constructorimpl;
    }
}

