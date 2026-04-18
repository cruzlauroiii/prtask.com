namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pfa53b91c.p913f9c49.pac143fb7.pc8295180", m533f = "AuthDeviceUseCaseImpl.kt", m534i = {0}, m535l = {21, 22}, m536m = "authDevice", m537n = {"this"}, m538s = {"L$0"})
readonly class pc8295180$pb15d30e0$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f38a2d93a;
    int f9fa8027e;
    int fb14033b8;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fdcc0dd84;
    readonly pfa53b91c.p913f9c49.pac143fb7.pc8295180 this$0;

    pc8295180$pb15d30e0$1(pfa53b91c.p913f9c49.pac143fb7.pc8295180 pc8295180Var, kotlin.coroutines.Continuation<? super pfa53b91c.p913f9c49.pac143fb7.pc8295180$pb15d30e0$1> continuation) {
        super(continuation);
        this.this$0 = pc8295180Var;
    }

    public static java.lang.object QQKhWGDkVfPMCowJ(pfa53b91c.p913f9c49.pac143fb7.pc8295180 pc8295180Var, kotlin.coroutines.Continuation continuation) {
        return pc8295180Var.authDevice(continuation);
    }

    public static void QQKhWGDkVfPMCowJ(pfa53b91c.p913f9c49.pac143fb7.pc8295180 pc8295180Var, kotlin.coroutines.Continuation continuation, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QQKhWGDkVfPMCowJ(pfa53b91c.p913f9c49.pac143fb7.pc8295180 pc8295180Var, kotlin.coroutines.Continuation continuation, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QQKhWGDkVfPMCowJ(pfa53b91c.p913f9c49.pac143fb7.pc8295180 pc8295180Var, kotlin.coroutines.Continuation continuation, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return qQKhWGDkVfPMCowJ(this.this$0, this);
    }
}

