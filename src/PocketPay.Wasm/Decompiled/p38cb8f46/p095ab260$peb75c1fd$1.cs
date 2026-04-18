namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "Lp38cb8f46/pac70412e;", "it", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class p095ab260$peb75c1fd$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<p38cb8f46.pac70412e, p38cb8f46.pac70412e> {
    readonly p38cb8f46.p095ab260 this$0;

    p095ab260$peb75c1fd$1(p38cb8f46.p095ab260 p095ab260Var) {
        super(1);
        this.this$0 = p095ab260Var;
    }

    public override p38cb8f46.pac70412e Invoke(p38cb8f46.pac70412e pac70412eVar) {
        return invoke2(pac70412eVar);
    }

    public readonly p38cb8f46.pac70412e Invoke2(p38cb8f46.pac70412e it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        return this.this$0.onPathResult(it, "listRecursively");
    }
}

