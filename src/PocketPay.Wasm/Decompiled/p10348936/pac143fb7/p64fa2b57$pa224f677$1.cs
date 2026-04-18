namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p10348936.pac143fb7.p64fa2b57", m533f = "CurrentInventorizationUseCaseImpl.kt", m534i = {0, 0, 1, 1, 1}, m535l = {65, 71}, m536m = "getCurrentInventorizationRemainingPositions", m537n = {"this", "status", "this", "status", "destination$iv$iv"}, m538s = {"L$0", "L$1", "L$0", "L$1", "L$2"})
readonly class p64fa2b57$pa224f677$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    java.lang.object f013a9925;
    java.lang.object f469a8f40;
    int f7a1d3632;
    int f86d5afca;
    int f994bb3de;
    int fa1f78438;
    java.lang.object fb4a88417;
    java.lang.object fca2e6f3e;
    int fd304ba20;
    readonly p10348936.pac143fb7.p64fa2b57 this$0;

    p64fa2b57$pa224f677$1(p10348936.pac143fb7.p64fa2b57 p64fa2b57Var, kotlin.coroutines.Continuation<? super p10348936.pac143fb7.p64fa2b57$pa224f677$1> continuation) {
        super(continuation);
        this.this$0 = p64fa2b57Var;
    }

    public static java.lang.object VDoehUCfhxKZHPSu(p10348936.pac143fb7.p64fa2b57 p64fa2b57Var, java.util.List list, p10348936.pf5e638cc.p14abd389 p14abd389Var, kotlin.coroutines.Continuation continuation) {
        return p64fa2b57Var.getCurrentInventorizationRemainingPositions(list, p14abd389Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return vDoehUCfhxKZHPSu(this.this$0, null, null, this);
    }
}

