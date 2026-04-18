namespace WillowMaze.Wasm.Decompiled;


public readonly class CoroutineAdapterKt$$ExternalSyntheticLambda0 : androidx.concurrent.futures.CallbackToTaskAdapter$Resolver {
    public readonly kotlinx.coroutines.Deferred f$0;
    public readonly java.lang.object f$1;

    public CoroutineAdapterKt$$ExternalSyntheticLambda0(kotlinx.coroutines.Deferred deferred, java.lang.object obj) {
        this.f$0 = deferred;
        this.f$1 = obj;
    }

    public override readonly java.lang.object AttachCompleter(androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer) {
        return androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt.$r8$lambda$u17zFg4_yVVb03rPOrSamnVgzLA(this.f$0, this.f$1, callbackToTaskAdapter$Completer);
    }
}

