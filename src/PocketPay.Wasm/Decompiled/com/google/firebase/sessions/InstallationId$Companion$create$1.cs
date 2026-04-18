namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.InstallationId$Companion", m533f = "InstallationId.kt", m534i = {0, 1}, m535l = {32, 40}, m536m = "create", m537n = {"firebaseInstallations", "authToken"}, m538s = {"L$0", "L$0"})
readonly class InstallationId$Companion$create$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly com.google.firebase.sessions.InstallationId$Companion this$0;

    InstallationId$Companion$create$1(com.google.firebase.sessions.InstallationId$Companion installationId$Companion, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.InstallationId$Companion$create$1> continuation) {
        super(continuation);
        this.this$0 = installationId$Companion;
    }

    public static java.lang.object IbMsaXBFWsybdwbF(com.google.firebase.sessions.InstallationId$Companion installationId$Companion, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, kotlin.coroutines.Continuation continuation) {
        return installationId$Companion.create(firebaseInstallationsApi, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return IbMsaXBFWsybdwbF(this.this$0, null, this);
    }
}

