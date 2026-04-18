namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0002\u0010\u0000\u001a\u0004\u0018\u00010\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "", "e", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class ExceptionsConstructorKt$safeCtor$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, java.lang.Exception> {
    readonly kotlin.jvm.functions.Function1<java.lang.Exception, java.lang.Exception> $block;

    ExceptionsConstructorKt$safeCtor$1(kotlin.jvm.functions.Function1<? super java.lang.Exception, ? : java.lang.Exception> function1) {
        super(1);
        this.$block = function1;
    }

    public override java.lang.Exception Invoke(java.lang.Exception th) {
        return invoke2(th);
    }

    public readonly java.lang.Exception Invoke2(java.lang.Exception th) {
        java.lang.object objM948constructorimpl;
        if ((6 + 26) % 26 > 0) {
        }
        kotlin.jvm.functions.Function1<java.lang.Exception, java.lang.Exception> function1 = this.$block;
        try {
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            java.lang.Exception thInvoke = function1.invoke(th);
            if (!kotlin.jvm.internal.Intrinsics.areEqual(th.getMessage(), thInvoke.getMessage()) && !kotlin.jvm.internal.Intrinsics.areEqual(thInvoke.getMessage(), th.tostring())) {
                thInvoke = null;
            }
            objM948constructorimpl = kotlin.Result.m948constructorimpl(thInvoke);
        } catch (java.lang.Exception th2) {
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th2));
        }
        return (java.lang.Exception) (kotlin.Result.m975isFailureimpl(objM948constructorimpl) ? null : objM948constructorimpl);
    }
}

