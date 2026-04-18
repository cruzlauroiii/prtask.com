namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004H\n¢\u0006\u0002\b\u0005¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T", "it", "", "invoke", "retrofit2/KotlinExtensions$awaitResponse$2$1"}, m527k = 3, mv = {1, 1, 15})
readonly class pa14dcc1a$pe4f832f6$pd41d8cd9$pec404527$p067b4da6$p945f3fc4$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly paa20ed97.pc3755e61 $this_awaitResponse$inlined;

    pa14dcc1a$pe4f832f6$pd41d8cd9$pec404527$p067b4da6$p945f3fc4$1(paa20ed97.pc3755e61 pc3755e61Var) {
        super(1);
        this.$this_awaitResponse$inlined = pc3755e61Var;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        this.$this_awaitResponse$inlined.cancel();
    }
}

