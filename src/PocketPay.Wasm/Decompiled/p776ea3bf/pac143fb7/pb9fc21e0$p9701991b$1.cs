namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.pac143fb7.pb9fc21e0", m533f = "IntegrationRegistrationUseCaseImpl.kt", m534i = {0, 0, 1, 1, 1, 1}, m535l = {28, 35}, m536m = "updateRegistrationUserData", m537n = {"this", "androidId", "this", "androidId", "$this$updateRegistrationUserData_u24lambda_u242", "localAuth"}, m538s = {"L$0", "L$1", "L$0", "L$1", "L$2", "L$3"})
readonly class pb9fc21e0$p9701991b$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object f2ed77780;
    int fa01ab416;
    int fa62402f9;
    java.lang.object fb4a88417;
    java.lang.object fcbf3f20e;
    int fd304ba20;
    java.lang.object fde89633c;
    java.lang.object fe91cff9f;
    readonly p776ea3bf.pac143fb7.pb9fc21e0 this$0;

    pb9fc21e0$p9701991b$1(p776ea3bf.pac143fb7.pb9fc21e0 pb9fc21e0Var, kotlin.coroutines.Continuation<? super p776ea3bf.pac143fb7.pb9fc21e0$p9701991b$1> continuation) {
        super(continuation);
        this.this$0 = pb9fc21e0Var;
    }

    public static java.lang.object CvjZTIPMZGgDXjJB(p776ea3bf.pac143fb7.pb9fc21e0 pb9fc21e0Var, kotlin.coroutines.Continuation continuation) {
        return pb9fc21e0Var.updateRegistrationUserData(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return CvjZTIPMZGgDXjJB(this.this$0, this);
    }
}

