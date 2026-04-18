namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.pac143fb7.p81dbcc3f.pe2ccfc95", m533f = "StartScreenUseCaseImpl.kt", m534i = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 10, 10}, m535l = {61, 63, 65, 69, 70, 71, 72, 73, 75, 76, 78}, m536m = "getStartRegisteredScreen", m537n = {"this", "this", "this", "this", "this", "this", "this", "this", "this", "this", "employee", "this", "employee"}, m538s = {"L$0", "L$0", "L$0", "L$0", "L$0", "L$0", "L$0", "L$0", "L$0", "L$0", "L$1", "L$0", "L$1"})
readonly class pe2ccfc95$p9331a1b9$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f4bd6a727;
    int f76dbca45;
    int f8470ffb5;
    java.lang.object f968d55d4;
    int f99869e54;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe3cf82a8;
    java.lang.object ff921adbd;
    readonly pad5f82e8.pac143fb7.p81dbcc3f.pe2ccfc95 this$0;

    pe2ccfc95$p9331a1b9$1(pad5f82e8.pac143fb7.p81dbcc3f.pe2ccfc95 pe2ccfc95Var, kotlin.coroutines.Continuation<? super pad5f82e8.pac143fb7.p81dbcc3f.pe2ccfc95$p9331a1b9$1> continuation) {
        super(continuation);
        this.this$0 = pe2ccfc95Var;
    }

    public static java.lang.object AslXibMJakgBetBt(pad5f82e8.pac143fb7.p81dbcc3f.pe2ccfc95 pe2ccfc95Var, kotlin.coroutines.Continuation continuation) {
        return pe2ccfc95Var.getStartRegisteredScreen(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return aslXibMJakgBetBt(this.this$0, this);
    }
}

