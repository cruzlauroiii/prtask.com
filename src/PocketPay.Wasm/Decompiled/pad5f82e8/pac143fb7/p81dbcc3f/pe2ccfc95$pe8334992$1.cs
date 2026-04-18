namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.pac143fb7.p81dbcc3f.pe2ccfc95", m533f = "StartScreenUseCaseImpl.kt", m534i = {}, m535l = {114}, m536m = "hasDevice", m537n = {}, m538s = {})
readonly class pe2ccfc95$pe8334992$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f24c8a258;
    int f2ca0962f;
    int f6d83e878;
    java.lang.object fb4a88417;
    java.lang.object fc28de8f6;
    int fd304ba20;
    int fd91c8a45;
    readonly pad5f82e8.pac143fb7.p81dbcc3f.pe2ccfc95 this$0;

    pe2ccfc95$pe8334992$1(pad5f82e8.pac143fb7.p81dbcc3f.pe2ccfc95 pe2ccfc95Var, kotlin.coroutines.Continuation<? super pad5f82e8.pac143fb7.p81dbcc3f.pe2ccfc95$pe8334992$1> continuation) {
        super(continuation);
        this.this$0 = pe2ccfc95Var;
    }

    public static java.lang.object FDUqpGiYGSVDyZWc(pad5f82e8.pac143fb7.p81dbcc3f.pe2ccfc95 pe2ccfc95Var, kotlin.coroutines.Continuation continuation) {
        return pad5f82e8.pac143fb7.p81dbcc3f.pe2ccfc95.mdf8b800a(pe2ccfc95Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return fDUqpGiYGSVDyZWc(this.this$0, this);
    }
}

