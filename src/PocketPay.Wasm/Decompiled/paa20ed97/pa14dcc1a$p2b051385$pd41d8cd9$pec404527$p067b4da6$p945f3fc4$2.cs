namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\n¢\u0006\u0002\b\u0006¨\u0006\u0007"}, d2 = {"<anonymous>", "", "T", "", "it", "", "invoke", "retrofit2/KotlinExtensions$await$4$1"}, m527k = 3, mv = {1, 1, 15})
readonly class pa14dcc1a$p2b051385$pd41d8cd9$pec404527$p067b4da6$p945f3fc4$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly paa20ed97.pc3755e61 $this_await$inlined;

    pa14dcc1a$p2b051385$pd41d8cd9$pec404527$p067b4da6$p945f3fc4$2(paa20ed97.pc3755e61 pc3755e61Var) {
        super(1);
        this.$this_await$inlined = pc3755e61Var;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        this.$this_await$inlined.cancel();
    }
}

