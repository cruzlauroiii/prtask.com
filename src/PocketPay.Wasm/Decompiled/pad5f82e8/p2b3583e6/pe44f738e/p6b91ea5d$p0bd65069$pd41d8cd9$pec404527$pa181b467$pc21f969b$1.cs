namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\u0010\u0000\u001a\u0002H\u0001\"\n\b\u0000\u0010\u0001\u0018\u0001*\u00020\u0002H\n¢\u0006\u0004\b\u0003\u0010\u0004¨\u0006\u0005"}, d2 = {"<anonymous>", "T", "", "invoke", "()Ljava/lang/object;", "org/koin/core/component/KoinComponentKt$inject$1"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p6b91ea5d$p0bd65069$pd41d8cd9$pec404527$pa181b467$pc21f969b$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<pad5f82e8.pac143fb7.p1e11b989.pa9d1cbf7.p36deed69> {
    readonly kotlin.jvm.functions.Function0 $parameters;
    readonly p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c $qualifier;
    readonly p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df $this_inject;

    public p6b91ea5d$p0bd65069$pd41d8cd9$pec404527$pa181b467$pc21f969b$1(p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df pcf4be4dfVar, p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c p75a47e1cVar, kotlin.jvm.functions.Function0 function0) {
        super(0);
        this.$this_inject = pcf4be4dfVar;
        this.$qualifier = p75a47e1cVar;
        this.$parameters = function0;
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.pf01db611 BlwTjzjyGLXNsdAm(p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df pcf4be4dfVar) {
        return pcf4be4dfVar.getKoin();
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 FyuSKbKRPWpFHAci(p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be p8c1de8beVar) {
        return p8c1de8beVar.getScope();
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.pa9205dcf.p96f637c9 GANsmwBzYBjIxlXi(p5a445d71.p514e2d7a.pa74ad8df.pf01db611 pf01db611Var) {
        return pf01db611Var.getScopeRegistry();
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 WbudyBVsfsIWSQCu(p5a445d71.p514e2d7a.pa74ad8df.pa9205dcf.p96f637c9 p96f637c9Var) {
        return p96f637c9Var.getRootScope();
    }

    public static kotlin.reflect.KClass ZDWHkEbSmoNxhphM(java.lang.Class cls) {
        return kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(cls);
    }

    public static java.lang.object WPcFqZgMebdtmLyA(p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 p5d113f20Var, kotlin.reflect.KClass kClass, p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c p75a47e1cVar, kotlin.jvm.functions.Function0 function0) {
        return p5d113f20Var[kClass, p75a47e1cVar, function0);
    }

    public override readonly pad5f82e8.pac143fb7.p1e11b989.pa9d1cbf7.p36deed69 Invoke() {
        if ((5 + 25) % 25 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df pcf4be4dfVar = this.$this_inject;
        return wPcFqZgMebdtmLyA(!(pcf4be4dfVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? WbudyBVsfsIWSQCu(GANsmwBzYBjIxlXi(BlwTjzjyGLXNsdAm(pcf4be4dfVar))) : FyuSKbKRPWpFHAci((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) pcf4be4dfVar), ZDWHkEbSmoNxhphM(pad5f82e8.pac143fb7.p1e11b989.pa9d1cbf7.p36deed69.class), this.$qualifier, this.$parameters);
    }
}

