namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "preferences", "Landroidx/datastore/preferences/core/MutablePreferences;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$2", m533f = "HashSettingsCache.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class HashSettingsCache$updateConfigValue$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.datastore.preferences.core.MutablePreferences, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.datastore.preferences.core.Preferences$Key<T> $key;
    readonly T $value;
    java.lang.object L$0;
    int label;
    readonly com.google.firebase.sessions.settings.HashSettingsCache this$0;

    HashSettingsCache$updateConfigValue$2(T t, androidx.datastore.preferences.core.Preferences$Key<T> preferences$Key, com.google.firebase.sessions.settings.HashSettingsCache settingsCache, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$2> continuation) {
        super(2, continuation);
        this.$value = t;
        this.$key = preferences$Key;
        this.this$0 = settingsCache;
    }

    public static java.lang.object BKFerGxXozhwRAsD(com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$2 settingsCache$updateConfigValue$2, androidx.datastore.preferences.core.MutablePreferences mutablePreferences, kotlin.coroutines.Continuation continuation) {
        return settingsCache$updateConfigValue$2.invoke2(mutablePreferences, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static kotlin.coroutines.Continuation DbPwPdoxYbjLQMsl(com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$2 settingsCache$updateConfigValue$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return settingsCache$updateConfigValue$2.create(obj, continuation);
    }

    public static void VtYdfibHkwmJTDRX(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences preferences) {
        com.google.firebase.sessions.settings.HashSettingsCache.access$updateSessionConfigs(settingsCache, preferences);
    }

    public static java.lang.object ZlYJfyzmOGijFDVc() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void GKcXjHcMJIEvoxDp(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object KaCVUFDLXHqmlxiF(com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$2 settingsCache$updateConfigValue$2, java.lang.object obj) {
        return settingsCache$updateConfigValue$2.invokeSuspend(obj);
    }

    public static void MctCbAMTzgBieign(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static java.lang.object NaSbggOqJXpdRUZL(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key) {
        return mutablePreferences.Remove(preferences$Key);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((20 + 12) % 12 > 0) {
        }
        com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$2 settingsCache$updateConfigValue$2 = new com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$2(this.$value, this.$key, this.this$0, continuation);
        settingsCache$updateConfigValue$2.L$0 = obj;
        return settingsCache$updateConfigValue$2;
    }

    public readonly java.lang.object Invoke2(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kaCVUFDLXHqmlxiF((com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$2) DbPwPdoxYbjLQMsl(this, mutablePreferences, continuation), kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return BKFerGxXozhwRAsD(this, mutablePreferences, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((17 + 28) % 28 > 0) {
        }
        ZlYJfyzmOGijFDVc();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        gKcXjHcMJIEvoxDp(obj);
        androidx.datastore.preferences.core.MutablePreferences mutablePreferences = (androidx.datastore.preferences.core.MutablePreferences) this.L$0;
        T t = this.$value;
        if (t == 0) {
            naSbggOqJXpdRUZL(mutablePreferences, this.$key);
        } else {
            mctCbAMTzgBieign(mutablePreferences, this.$key, t);
        }
        VtYdfibHkwmJTDRX(this.this$0, mutablePreferences);
        return kotlin.Unit.INSTANCE;
    }
}

