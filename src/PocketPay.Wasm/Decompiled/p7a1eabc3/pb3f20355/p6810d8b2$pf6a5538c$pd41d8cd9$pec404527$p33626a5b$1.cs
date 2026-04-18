namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u00012\u00020\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0016¨\u0006\t¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/CoroutineExceptionHandlerKt$CoroutineExceptionHandler$1", "Lkotlin/coroutines/AbstractCoroutineobjectElement;", "Lkotlinx/coroutines/CoroutineExceptionHandler;", "handleException", "", "context", "Lkotlin/coroutines/Coroutineobject;", "exception", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6810d8b2$pf6a5538c$pd41d8cd9$pec404527$p33626a5b$1 : kotlin.coroutines.AbstractCoroutineobjectElement : kotlinx.coroutines.CoroutineExceptionHandler {
    readonly kotlinx.coroutines.Deferred $previousDeferredCommodities$inlined;
    readonly p7a1eabc3.pb3f20355.p6810d8b2 this$0;

    public p6810d8b2$pf6a5538c$pd41d8cd9$pec404527$p33626a5b$1(kotlinx.coroutines.CoroutineExceptionHandler$Key coroutineExceptionHandler$Key, p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var, kotlinx.coroutines.Deferred deferred) {
        super(coroutineExceptionHandler$Key);
        this.this$0 = p6810d8b2Var;
        this.$previousDeferredCommodities$inlined = deferred;
    }

    public override void HandleException(kotlin.coroutines.Coroutineobject context, java.lang.Exception exception) {
        p7a1eabc3.pb3f20355.p6810d8b2.md2470313(this.this$0, this.$previousDeferredCommodities$inlined);
        com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(exception);
    }
}

