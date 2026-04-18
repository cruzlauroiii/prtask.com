namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u008a@"}, d2 = {"<anonymous>", "Landroidx/datastore/preferences/core/Preferences;", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.preferences.core.PreferenceDataStore$updateData$2", m533f = "PreferenceDataStoreFactory.kt", m534i = {}, m535l = {94}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PreferenceDataStore$updateData$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.datastore.preferences.core.Preferences, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<androidx.datastore.preferences.core.Preferences, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences>, java.lang.object> $transform;
    java.lang.object L$0;
    int label;

    PreferenceDataStore$updateData$2(kotlin.jvm.functions.Function2<? super androidx.datastore.preferences.core.Preferences, ? super kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.datastore.preferences.core.PreferenceDataStore$updateData$2> continuation) {
        super(2, continuation);
        this.$transform = function2;
    }

    public static void IPWXaLSfbhFFvYpG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static java.lang.object YxEayEOMCYDJsbzC(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static void ZHDSqFjdRjvLAksu(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void JfQDrVAsNBJIjuZD(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object OTdsQXOMbttNFTuE(androidx.datastore.preferences.core.PreferenceDataStore$updateData$2 preferenceDataStore$updateData$2, java.lang.object obj) {
        return preferenceDataStore$updateData$2.invokeSuspend(obj);
    }

    public static java.lang.object QwIxkEaZjPFmYnBJ() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void YSwBiHZKkhtGHiQH(androidx.datastore.preferences.core.MutablePreferences mutablePreferences) {
        mutablePreferences.freeze$datastore_preferences_core();
    }

    public static kotlin.coroutines.Continuation YTvUpLbZGbiONsov(androidx.datastore.preferences.core.PreferenceDataStore$updateData$2 preferenceDataStore$updateData$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return preferenceDataStore$updateData$2.create(obj, continuation);
    }

    public static java.lang.object ZzDdxtPfJCMeqGYW(androidx.datastore.preferences.core.PreferenceDataStore$updateData$2 preferenceDataStore$updateData$2, androidx.datastore.preferences.core.Preferences preferences, kotlin.coroutines.Continuation continuation) {
        return preferenceDataStore$updateData$2.invoke2(preferences, (kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences>) continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.datastore.preferences.core.PreferenceDataStore$updateData$2 preferenceDataStore$updateData$2 = new androidx.datastore.preferences.core.PreferenceDataStore$updateData$2(this.$transform, continuation);
        preferenceDataStore$updateData$2.L$0 = obj;
        return preferenceDataStore$updateData$2;
    }

    public readonly java.lang.object Invoke2(androidx.datastore.preferences.core.Preferences preferences, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences> continuation) {
        return oTdsQXOMbttNFTuE((androidx.datastore.preferences.core.PreferenceDataStore$updateData$2) yTvUpLbZGbiONsov(this, preferences, continuation), kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(androidx.datastore.preferences.core.Preferences preferences, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences> continuation) {
        return zzDdxtPfJCMeqGYW(this, preferences, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((29 + 18) % 18 > 0) {
        }
        java.lang.object objQwIxkEaZjPFmYnBJ = qwIxkEaZjPFmYnBJ();
        int i = this.label;
        if (i == 0) {
            ZHDSqFjdRjvLAksu(obj);
            androidx.datastore.preferences.core.Preferences preferences = (androidx.datastore.preferences.core.Preferences) this.L$0;
            kotlin.jvm.functions.Function2<androidx.datastore.preferences.core.Preferences, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences>, java.lang.object> function2 = this.$transform;
            this.label = 1;
            obj = YxEayEOMCYDJsbzC(function2, preferences, this);
            if (obj == objQwIxkEaZjPFmYnBJ) {
                return objQwIxkEaZjPFmYnBJ;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            jfQDrVAsNBJIjuZD(obj);
        }
        androidx.datastore.preferences.core.Preferences preferences2 = (androidx.datastore.preferences.core.Preferences) obj;
        IPWXaLSfbhFFvYpG(preferences2, "null cannot be cast to non-null type androidx.datastore.preferences.core.MutablePreferences");
        ySwBiHZKkhtGHiQH((androidx.datastore.preferences.core.MutablePreferences) preferences2);
        return preferences2;
    }
}

