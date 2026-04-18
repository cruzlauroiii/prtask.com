namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.settings.HashSettingsCache", m533f = "HashSettingsCache.kt", m534i = {}, m535l = {119}, m536m = "updateConfigValue", m537n = {}, m538s = {})
readonly class HashSettingsCache$updateConfigValue$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly com.google.firebase.sessions.settings.HashSettingsCache this$0;

    HashSettingsCache$updateConfigValue$1(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$1> continuation) {
        super(continuation);
        this.this$0 = settingsCache;
    }

    public static java.lang.object AnyWvMOGGjUOqvry(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return com.google.firebase.sessions.settings.HashSettingsCache.access$updateConfigValue(settingsCache, preferences$Key, obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return AnyWvMOGGjUOqvry(this.this$0, null, null, this);
    }
}

