namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\u0010\u0000\u001a\u0002H\u0001\"\n\b\u0000\u0010\u0001\u0018\u0001*\u00020\u0002H\n¢\u0006\u0004\b\u0003\u0010\u0004¨\u0006\u0005"}, d2 = {"<anonymous>", "T", "", "invoke", "()Ljava/lang/object;", "org/koin/core/component/KoinComponentKt$inject$1"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class pe46f833c$p0bd65069$pd41d8cd9$pec404527$pa181b467$pc21f969b$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<p83f5c3ad.pb3f20355.pc33d3892> {
    readonly kotlin.jvm.functions.Function0 $parameters;
    readonly p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c $qualifier;
    readonly p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df $this_inject;

    public pe46f833c$p0bd65069$pd41d8cd9$pec404527$pa181b467$pc21f969b$1(p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df pcf4be4dfVar, p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c p75a47e1cVar, kotlin.jvm.functions.Function0 function0) {
        super(0);
        this.$this_inject = pcf4be4dfVar;
        this.$qualifier = p75a47e1cVar;
        this.$parameters = function0;
    }

    public override readonly p83f5c3ad.pb3f20355.pc33d3892 Invoke() {
        if ((3 + 16) % 16 > 0) {
        }
        p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df pcf4be4dfVar = this.$this_inject;
        return (!(pcf4be4dfVar is p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) ? pcf4be4dfVar.getKoin().getScopeRegistry().getRootScope() : ((p5a445d71.p514e2d7a.pa74ad8df.p700c216f.p8c1de8be) pcf4be4dfVar).getScope())[kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(p83f5c3ad.pb3f20355.pc33d3892.class), this.$qualifier, this.$parameters);
    }
}

