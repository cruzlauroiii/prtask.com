namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.settings.HashSettingsCache", m533f = "HashSettingsCache.kt", m534i = {}, m535l = {103}, m536m = "removeConfigs$com_google_firebase_firebase_sessions", m537n = {}, m538s = {})
readonly class HashSettingsCache$removeConfigs$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly com.google.firebase.sessions.settings.HashSettingsCache this$0;

    HashSettingsCache$removeConfigs$1(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$1> continuation) {
        super(continuation);
        this.this$0 = settingsCache;
    }

    public static java.lang.object NgcKVDDeLPXIJVKP(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, kotlin.coroutines.Continuation continuation) {
        return settingsCache.removeConfigs$com_google_firebase_firebase_sessions(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return NgcKVDDeLPXIJVKP(this.this$0, this);
    }
}

