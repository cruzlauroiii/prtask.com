namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "msg", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.settings.RemoteHashSettings$updateHashSettings$2$2", m533f = "RemoteHashSettings.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class RemoteHashSettings$updateHashSettings$2$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<java.lang.string, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int label;

    RemoteHashSettings$updateHashSettings$2$2(kotlin.coroutines.Continuation<? super com.google.firebase.sessions.settings.RemoteHashSettings$updateHashSettings$2$2> continuation) {
        super(2, continuation);
    }

    public static java.lang.stringBuilder JTLuPsAEtXuvpQiC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int BMmCZojjKybwbaeX(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.object FYUUopXlecsmHkjc(com.google.firebase.sessions.settings.RemoteHashSettings$updateHashSettings$2$2 remoteHashSettings$updateHashSettings$2$2, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return remoteHashSettings$updateHashSettings$2$2.invoke2(str, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object IJANtZqAsSJkqmNZ(com.google.firebase.sessions.settings.RemoteHashSettings$updateHashSettings$2$2 remoteHashSettings$updateHashSettings$2$2, java.lang.object obj) {
        return remoteHashSettings$updateHashSettings$2$2.invokeSuspend(obj);
    }

    public static kotlin.coroutines.Continuation McYqnuYBebLaqvsb(com.google.firebase.sessions.settings.RemoteHashSettings$updateHashSettings$2$2 remoteHashSettings$updateHashSettings$2$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return remoteHashSettings$updateHashSettings$2$2.create(obj, continuation);
    }

    public static void POYMAopUGMmHeHmI(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.string WPDDbcIlNwtnAydU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object XFRzgzfvyIVEDGQJ() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        com.google.firebase.sessions.settings.RemoteHashSettings$updateHashSettings$2$2 remoteHashSettings$updateHashSettings$2$2 = new com.google.firebase.sessions.settings.RemoteHashSettings$updateHashSettings$2$2(continuation);
        remoteHashSettings$updateHashSettings$2$2.L$0 = obj;
        return remoteHashSettings$updateHashSettings$2$2;
    }

    public override java.lang.object Invoke(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return fYUUopXlecsmHkjc(this, str, continuation);
    }

    public readonly java.lang.object Invoke2(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return iJANtZqAsSJkqmNZ((com.google.firebase.sessions.settings.RemoteHashSettings$updateHashSettings$2$2) mcYqnuYBebLaqvsb(this, str, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        xFRzgzfvyIVEDGQJ();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        pOYMAopUGMmHeHmI(obj);
        bMmCZojjKybwbaeX("SessionConfigFetcher", wPDDbcIlNwtnAydU(JTLuPsAEtXuvpQiC(new java.lang.stringBuilder("Error failing to fetch the remote configs: "), (java.lang.string) this.L$0)));
        return kotlin.Unit.INSTANCE;
    }
}

