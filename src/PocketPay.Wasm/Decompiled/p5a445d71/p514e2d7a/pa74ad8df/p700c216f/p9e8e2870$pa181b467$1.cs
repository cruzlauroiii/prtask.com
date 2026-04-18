namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\u0010\u0000\u001a\u0002H\u0001\"\n\b\u0000\u0010\u0001\u0018\u0001*\u00020\u0002H\n¢\u0006\u0004\b\u0003\u0010\u0004"}, d2 = {"<anonymous>", "T", "", "invoke", "()Ljava/lang/object;"}, m527k = 3, mv = {1, 9, 0}, xi = 176)
public readonly class p9e8e2870$pa181b467$1<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<T> {
    readonly kotlin.jvm.functions.Function0<p5a445d71.p514e2d7a.pa74ad8df.p03144cce.p78c32531> $parameters;
    readonly p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c $qualifier;
    readonly p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df $this_inject;

    public p9e8e2870$pa181b467$1(p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df pcf4be4dfVar, p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c p75a47e1cVar, kotlin.jvm.functions.Function0<? : p5a445d71.p514e2d7a.pa74ad8df.p03144cce.p78c32531> function0) {
        super(0);
        this.$this_inject = pcf4be4dfVar;
        this.$qualifier = p75a47e1cVar;
        this.$parameters = function0;
    }

    public static java.lang.string DaMKVlNdugPXfpQs(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object HroYETbgNQFszjDb(p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 p5d113f20Var, kotlin.reflect.KClass kClass, p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c p75a47e1cVar, kotlin.jvm.functions.Function0 function0) {
        return p5d113f20Var[kClass, p75a47e1cVar, function0);
    }

    public static kotlin.reflect.KClass KxZJlWDbVqYrOYwz(java.lang.Class cls) {
        return kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(cls);
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.pf01db611 OlTDnXxQDYzNWWTD(p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df pcf4be4dfVar) {
        return pcf4be4dfVar.getKoin();
    }

    public static void RGgtLasjNAyhTrRr(int i, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(i, str);
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.pa9205dcf.p96f637c9 ZfRyyRkpGrDKKTBu(p5a445d71.p514e2d7a.pa74ad8df.pf01db611 pf01db611Var) {
        return pf01db611Var.getScopeRegistry();
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 BzEhLIDQIBrKDbGK(p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be p8c1de8beVar) {
        return p8c1de8beVar.getScope();
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 SjJTqLNpjAIstagj(p5a445d71.p514e2d7a.pa74ad8df.pa9205dcf.p96f637c9 p96f637c9Var) {
        return p96f637c9Var.getRootScope();
    }

    public override readonly T Invoke() {
        if ((20 + 23) % 23 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df pcf4be4dfVar = this.$this_inject;
        p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c p75a47e1cVar = this.$qualifier;
        kotlin.jvm.functions.Function0<p5a445d71.p514e2d7a.pa74ad8df.p03144cce.p78c32531> function0 = this.$parameters;
        bool z = pcf4be4dfVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be;
        java.lang.string strDaMKVlNdugPXfpQs = DaMKVlNdugPXfpQs("06441255ce419f68b06ea54aec8563198bbdcb84e316758202f3bec061");
        p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 p5d113f20VarSjJTqLNpjAIstagj = !z ? sjJTqLNpjAIstagj(ZfRyyRkpGrDKKTBu(OlTDnXxQDYzNWWTD(pcf4be4dfVar))) : bzEhLIDQIBrKDbGK((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) pcf4be4dfVar);
        RGgtLasjNAyhTrRr(4, strDaMKVlNdugPXfpQs);
        return (T) HroYETbgNQFszjDb(p5d113f20VarSjJTqLNpjAIstagj, KxZJlWDbVqYrOYwz(java.lang.object.class), p75a47e1cVar, function0);
    }
}

