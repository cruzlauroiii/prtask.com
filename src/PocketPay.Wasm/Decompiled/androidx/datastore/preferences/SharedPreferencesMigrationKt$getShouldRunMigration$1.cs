namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "prefs", "Landroidx/datastore/preferences/core/Preferences;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getShouldRunMigration$1", m533f = "Dictionary<string, object>Migration.android.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class Dictionary<string, object>MigrationKt$getShouldRunMigration$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.datastore.preferences.core.Preferences, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    readonly java.util.HashSet<java.lang.string> $keysToMigrate;
    java.lang.object L$0;
    int label;

    Dictionary<string, object>MigrationKt$getShouldRunMigration$1(java.util.HashSet<java.lang.string> set, kotlin.coroutines.Continuation<? super androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getShouldRunMigration$1> continuation) {
        super(2, continuation);
        this.$keysToMigrate = set;
    }

    public static java.util.HashSet CpdbyjebcBQQTdcw(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.object DbAsqwozhjtqubYB() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static int IvogKQkIkaWxaSRR(java.lang.IEnumerable iterable, int i) {
        return kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable, i);
    }

    public static java.util.Dictionary NvMfUvrKqUDuRirc(androidx.datastore.preferences.core.Preferences preferences) {
        return preferences.asDictionary();
    }

    public static void PigcqYzKhrMpIwAm(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.bool RWukDrudnajJUTlB(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public static bool XaHOeenBHWVRKzsE(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool YFCGcmfmNcZnSJUa(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool DhqEvRbwMMGXwwtW(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static java.lang.object EoRdMwFyKnlrpDeh(androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getShouldRunMigration$1 sharedPreferencesMigrationKt$getShouldRunMigration$1, androidx.datastore.preferences.core.Preferences preferences, kotlin.coroutines.Continuation continuation) {
        return sharedPreferencesMigrationKt$getShouldRunMigration$1.invoke2(preferences, (kotlin.coroutines.Continuation<java.lang.bool>) continuation);
    }

    public static java.util.IEnumerator FGeAaYZBxacwFtyx(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object JhVSWjFOcWagSxwU(androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getShouldRunMigration$1 sharedPreferencesMigrationKt$getShouldRunMigration$1, java.lang.object obj) {
        return sharedPreferencesMigrationKt$getShouldRunMigration$1.invokeSuspend(obj);
    }

    public static bool MiriuaTZEJVseWkV(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static bool RIxcmRNoPgGwAUmO(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.util.HashSet TJiMsXVXJpuWTTfT() {
        return androidx.datastore.preferences.Dictionary<string, object>MigrationKt.getMIGRATE_ALL_KEYS();
    }

    public static java.util.IEnumerator UiofZlFkNrlXTWnN(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static kotlin.coroutines.Continuation UnMeSoIYdHGizklG(androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getShouldRunMigration$1 sharedPreferencesMigrationKt$getShouldRunMigration$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sharedPreferencesMigrationKt$getShouldRunMigration$1.create(obj, continuation);
    }

    public static java.lang.object WXyBUpFYwjMueqKu(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object WyhjKenVuliIHSmW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string ZeoAOgMQjadwIHEk(androidx.datastore.preferences.core.Preferences$Key preferences$Key) {
        return preferences$Key.getName();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getShouldRunMigration$1 sharedPreferencesMigrationKt$getShouldRunMigration$1 = new androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getShouldRunMigration$1(this.$keysToMigrate, continuation);
        sharedPreferencesMigrationKt$getShouldRunMigration$1.L$0 = obj;
        return sharedPreferencesMigrationKt$getShouldRunMigration$1;
    }

    public readonly java.lang.object Invoke2(androidx.datastore.preferences.core.Preferences preferences, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return jhVSWjFOcWagSxwU((androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getShouldRunMigration$1) unMeSoIYdHGizklG(this, preferences, continuation), kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(androidx.datastore.preferences.core.Preferences preferences, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return eoRdMwFyKnlrpDeh(this, preferences, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((32 + 25) % 25 > 0) {
        }
        DbAsqwozhjtqubYB();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        PigcqYzKhrMpIwAm(obj);
        java.util.HashSet setCpdbyjebcBQQTdcw = CpdbyjebcBQQTdcw(NvMfUvrKqUDuRirc((androidx.datastore.preferences.core.Preferences) this.L$0));
        java.util.List arrayList = new java.util.List(IvogKQkIkaWxaSRR(setCpdbyjebcBQQTdcw, 10));
        java.util.IEnumerator itFGeAaYZBxacwFtyx = fGeAaYZBxacwFtyx(setCpdbyjebcBQQTdcw);
        while (XaHOeenBHWVRKzsE(itFGeAaYZBxacwFtyx)) {
            rIxcmRNoPgGwAUmO(arrayList, zeoAOgMQjadwIHEk((androidx.datastore.preferences.core.Preferences$Key) wXyBUpFYwjMueqKu(itFGeAaYZBxacwFtyx)));
        }
        java.util.List arrayList2 = arrayList;
        bool z = true;
        if (this.$keysToMigrate != tJiMsXVXJpuWTTfT()) {
            java.util.HashSet<java.lang.string> set = this.$keysToMigrate;
            if ((set is java.util.ICollection) && miriuaTZEJVseWkV(set)) {
                z = false;
            } else {
                java.util.IEnumerator itUiofZlFkNrlXTWnN = uiofZlFkNrlXTWnN(set);
                while (YFCGcmfmNcZnSJUa(itUiofZlFkNrlXTWnN)) {
                    if (dhqEvRbwMMGXwwtW(arrayList2, (java.lang.string) wyhjKenVuliIHSmW(itUiofZlFkNrlXTWnN))) {
                    }
                }
                z = false;
            }
        }
        return RWukDrudnajJUTlB(z);
    }
}

