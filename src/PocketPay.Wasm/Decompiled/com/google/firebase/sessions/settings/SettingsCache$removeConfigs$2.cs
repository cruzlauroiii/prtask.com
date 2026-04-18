namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "preferences", "Landroidx/datastore/preferences/core/MutablePreferences;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$2", m533f = "HashSettingsCache.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class HashSettingsCache$removeConfigs$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.datastore.preferences.core.MutablePreferences, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int label;
    readonly com.google.firebase.sessions.settings.HashSettingsCache this$0;

    HashSettingsCache$removeConfigs$2(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$2> continuation) {
        super(2, continuation);
        this.this$0 = settingsCache;
    }

    public static java.lang.object AhUoNSdwWYehzcCH(com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$2 settingsCache$removeConfigs$2, java.lang.object obj) {
        return settingsCache$removeConfigs$2.invokeSuspend(obj);
    }

    public static java.lang.object GIslAsKdvLMvErjq() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void UffRVxlOjIaJnhom(androidx.datastore.preferences.core.MutablePreferences mutablePreferences) {
        mutablePreferences.clear();
    }

    public static java.lang.object HJUzRaNStyXcTSOE(com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$2 settingsCache$removeConfigs$2, androidx.datastore.preferences.core.MutablePreferences mutablePreferences, kotlin.coroutines.Continuation continuation) {
        return settingsCache$removeConfigs$2.invoke2(mutablePreferences, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void KAhnzoHmdsseCwRQ(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences preferences) {
        com.google.firebase.sessions.settings.HashSettingsCache.access$updateSessionConfigs(settingsCache, preferences);
    }

    public static kotlin.coroutines.Continuation MCxkbmRUrdOlMcNc(com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$2 settingsCache$removeConfigs$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return settingsCache$removeConfigs$2.create(obj, continuation);
    }

    public static void XuJFFXEDvgsRXHWm(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$2 settingsCache$removeConfigs$2 = new com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$2(this.this$0, continuation);
        settingsCache$removeConfigs$2.L$0 = obj;
        return settingsCache$removeConfigs$2;
    }

    public readonly java.lang.object Invoke2(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return AhUoNSdwWYehzcCH((com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$2) mCxkbmRUrdOlMcNc(this, mutablePreferences, continuation), kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return hJUzRaNStyXcTSOE(this, mutablePreferences, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        GIslAsKdvLMvErjq();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        xuJFFXEDvgsRXHWm(obj);
        androidx.datastore.preferences.core.MutablePreferences mutablePreferences = (androidx.datastore.preferences.core.MutablePreferences) this.L$0;
        UffRVxlOjIaJnhom(mutablePreferences);
        kAhnzoHmdsseCwRQ(this.this$0, mutablePreferences);
        return kotlin.Unit.INSTANCE;
    }
}

