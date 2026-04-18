namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532", m533f = "ReceiptsRemoteMediator.kt", m534i = {0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3}, m535l = {43, 48, 53, 54}, m536m = "load", m537n = {"this", "size", "this", "receiptsResponse", "deviceDictionary", "destination$iv$iv", "receipt", "deviceUuid", "$this$getOrPut$iv", "size", "this", "receipts", "size", "receipts", "size"}, m538s = {"L$0", "I$0", "L$0", "L$1", "L$2", "L$3", "L$5", "L$6", "L$8", "I$0", "L$0", "L$1", "I$0", "L$0", "I$0"})
readonly class pd2d24532$pec4d1eb3$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    java.lang.object L$5;
    java.lang.object L$6;
    java.lang.object L$7;
    java.lang.object L$8;
    java.lang.object L$9;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe509708e;
    java.lang.object ff674a0d4;
    int fffd43d55;
    readonly p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532 this$0;

    pd2d24532$pec4d1eb3$1(p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532 pd2d24532Var, kotlin.coroutines.Continuation<? super p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532$pec4d1eb3$1> continuation) {
        super(continuation);
        this.this$0 = pd2d24532Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.load(null, null, this);
    }
}

