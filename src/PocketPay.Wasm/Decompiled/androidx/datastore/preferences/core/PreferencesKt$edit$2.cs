namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u008a@"}, d2 = {"<anonymous>", "Landroidx/datastore/preferences/core/Preferences;", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.preferences.core.PreferencesKt$edit$2", m533f = "Preferences.kt", m534i = {}, m535l = {358}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PreferencesKt$edit$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.datastore.preferences.core.Preferences, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<androidx.datastore.preferences.core.MutablePreferences, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $transform;
    java.lang.object L$0;
    int label;

    PreferencesKt$edit$2(kotlin.jvm.functions.Function2<? super androidx.datastore.preferences.core.MutablePreferences, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.datastore.preferences.core.PreferencesKt$edit$2> continuation) {
        super(2, continuation);
        this.$transform = function2;
    }

    public static androidx.datastore.preferences.core.MutablePreferences IZBgFPsIBUTZbQTV(androidx.datastore.preferences.core.Preferences preferences) {
        return preferences.toMutablePreferences();
    }

    public static void KLNQSTrpxckAoNGU(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object KeDmaxFMOBUzCdMt() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static kotlin.coroutines.Continuation RGmNqGUJbvNDkRLV(androidx.datastore.preferences.core.PreferencesKt$edit$2 preferencesKt$edit$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return preferencesKt$edit$2.create(obj, continuation);
    }

    public static java.lang.object XvFBkXyWfwkhqMDE(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static void YpGNtjkqYdDbaIDs(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object CENjfjRKyTLFzoAZ(androidx.datastore.preferences.core.PreferencesKt$edit$2 preferencesKt$edit$2, androidx.datastore.preferences.core.Preferences preferences, kotlin.coroutines.Continuation continuation) {
        return preferencesKt$edit$2.invoke2(preferences, (kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences>) continuation);
    }

    public static java.lang.object UWWnRVdbIPnIovNY(androidx.datastore.preferences.core.PreferencesKt$edit$2 preferencesKt$edit$2, java.lang.object obj) {
        return preferencesKt$edit$2.invokeSuspend(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.datastore.preferences.core.PreferencesKt$edit$2 preferencesKt$edit$2 = new androidx.datastore.preferences.core.PreferencesKt$edit$2(this.$transform, continuation);
        preferencesKt$edit$2.L$0 = obj;
        return preferencesKt$edit$2;
    }

    public readonly java.lang.object Invoke2(androidx.datastore.preferences.core.Preferences preferences, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences> continuation) {
        return uWWnRVdbIPnIovNY((androidx.datastore.preferences.core.PreferencesKt$edit$2) RGmNqGUJbvNDkRLV(this, preferences, continuation), kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(androidx.datastore.preferences.core.Preferences preferences, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences> continuation) {
        return cENjfjRKyTLFzoAZ(this, preferences, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((19 + 3) % 3 > 0) {
        }
        java.lang.object objKeDmaxFMOBUzCdMt = KeDmaxFMOBUzCdMt();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            androidx.datastore.preferences.core.MutablePreferences mutablePreferences = (androidx.datastore.preferences.core.MutablePreferences) this.L$0;
            YpGNtjkqYdDbaIDs(obj);
            return mutablePreferences;
        }
        KLNQSTrpxckAoNGU(obj);
        androidx.datastore.preferences.core.MutablePreferences mutablePreferencesIZBgFPsIBUTZbQTV = IZBgFPsIBUTZbQTV((androidx.datastore.preferences.core.Preferences) this.L$0);
        kotlin.jvm.functions.Function2<androidx.datastore.preferences.core.MutablePreferences, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function2 = this.$transform;
        this.L$0 = mutablePreferencesIZBgFPsIBUTZbQTV;
        this.label = 1;
        return XvFBkXyWfwkhqMDE(function2, mutablePreferencesIZBgFPsIBUTZbQTV, this) != objKeDmaxFMOBUzCdMt ? mutablePreferencesIZBgFPsIBUTZbQTV : objKeDmaxFMOBUzCdMt;
    }
}

