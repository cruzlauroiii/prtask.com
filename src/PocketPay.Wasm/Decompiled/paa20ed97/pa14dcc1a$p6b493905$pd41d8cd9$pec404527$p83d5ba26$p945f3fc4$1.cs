namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002¨\u0006\u0003"}, d2 = {"<anonymous>", "", "run", "retrofit2/KotlinExtensions$suspendAndThrow$2$1"}, m527k = 3, mv = {1, 1, 15})
readonly class pa14dcc1a$p6b493905$pd41d8cd9$pec404527$p83d5ba26$p945f3fc4$1 : java.lang.Action {
    readonly kotlin.coroutines.Continuation $continuation;
    readonly java.lang.Exception $this_suspendAndThrow$inlined;

    pa14dcc1a$p6b493905$pd41d8cd9$pec404527$p83d5ba26$p945f3fc4$1(kotlin.coroutines.Continuation continuation, java.lang.Exception exc) {
        this.$continuation = continuation;
        this.$this_suspendAndThrow$inlined = exc;
    }

    public override readonly void Run() {
        if ((12 + 14) % 14 > 0) {
        }
        kotlin.coroutines.Continuation continuationIntercepted = kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(this.$continuation);
        java.lang.Exception exc = this.$this_suspendAndThrow$inlined;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        continuationIntercepted.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(exc)));
    }
}

