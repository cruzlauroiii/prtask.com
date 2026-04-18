namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0001H\u008a@"}, d2 = {"<anonymous>", "Landroidx/datastore/preferences/core/Preferences;", "sharedPrefs", "Landroidx/datastore/migrations/Dictionary<string, object>object;", "currentData"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getMigrationFunction$1", m533f = "Dictionary<string, object>Migration.android.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class Dictionary<string, object>MigrationKt$getMigrationFunction$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<androidx.datastore.migrations.Dictionary<string, object>object, androidx.datastore.preferences.core.Preferences, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences>, java.lang.object> {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;

    Dictionary<string, object>MigrationKt$getMigrationFunction$1(kotlin.coroutines.Continuation<? super androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getMigrationFunction$1> continuation) {
        super(3, continuation);
    }

    public static java.util.Dictionary ARdrPCjXPYYqmCEP(androidx.datastore.preferences.core.Preferences preferences) {
        return preferences.asDictionary();
    }

    public static androidx.datastore.preferences.core.Preferences$Key AtwIqEXfmrGPMbJc(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.stringKey(str);
    }

    public static androidx.datastore.preferences.core.Preferences$Key CHxbJHlOGfhKesDY(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.floatKey(str);
    }

    public static java.lang.object ClpdGxOeDvPKfbsh(java.util.IEnumerator it) {
        return it.Current;
    }

    public static androidx.datastore.preferences.core.Preferences$Key EfnPlVhAGrAieAyW(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.intKey(str);
    }

    public static java.lang.object FipMOnePewduibQD(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.object FjlRysSPytipfwOJ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void GRUTLduHgeNvvHNG(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static java.lang.string GndvuyGyWwKlSShP(androidx.datastore.preferences.core.Preferences$Key preferences$Key) {
        return preferences$Key.getName();
    }

    public static androidx.datastore.preferences.core.Preferences GuyQOlloIbCZDRLd(androidx.datastore.preferences.core.MutablePreferences mutablePreferences) {
        return mutablePreferences.toPreferences();
    }

    public static bool MnzhFvSoWWCZAlfJ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object MwWGLnNfwLvybfyI(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void PyXUvobndIJQOAdq(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static java.lang.object RqdOxMeebQCZJjpD(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static bool SEtRkpUYiuvZqPOW(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator TVDrltyrGnvkMLHc(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void UiNicsHQZQGHUZEA(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.util.IEnumerator UpoYQQHSsRAXmhWi(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object WQyYMohyGXRPmbZF(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.util.HashSet XIsQMjTCBDcGbPJP(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static androidx.datastore.preferences.core.MutablePreferences AAEnPTxXvXWaIiKE(androidx.datastore.preferences.core.Preferences preferences) {
        return preferences.toMutablePreferences();
    }

    public static androidx.datastore.preferences.core.Preferences$Key anOfsmaPzYKhPvOA(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.longKey(str);
    }

    public static java.util.HashSet BVBZFktoCjsMmYfb(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.lang.object BfKhNGhNALtHzusm(androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getMigrationFunction$1 sharedPreferencesMigrationKt$getMigrationFunction$1, androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, androidx.datastore.preferences.core.Preferences preferences, kotlin.coroutines.Continuation continuation) {
        return sharedPreferencesMigrationKt$getMigrationFunction$1.invoke2(sharedPreferencesobject, preferences, (kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences>) continuation);
    }

    public static void BjTbCxPufwzIDfuh(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static bool DsMttKiOlFzCpYoR(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool GLhSTfUvyWNQjhnA(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.object GzakZRekSOzZCDCJ() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object IaTXvJdntGprUwNC(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object LZHdiKSYadnrZIBs(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.util.HashSet NtxeIkUrCRvcJLTC(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static bool PVxMUqdbTzTzacEL(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static void QFqHJAJesOhagGiE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static java.util.Dictionary QFxnJeBYgVSbxywF(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject) {
        return sharedPreferencesobject.getAll();
    }

    public static void RBOpewmQfcvoZwMW(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static java.util.IEnumerator TBteYtXuijRIEIUv(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void UFPDVLDTalXaHcOM(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static java.lang.object UWNGEuZMCdicUddm(androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getMigrationFunction$1 sharedPreferencesMigrationKt$getMigrationFunction$1, java.lang.object obj) {
        return sharedPreferencesMigrationKt$getMigrationFunction$1.invokeSuspend(obj);
    }

    public static androidx.datastore.preferences.core.Preferences$Key vdMxelnCZnGAfxxp(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.stringHashSetKey(str);
    }

    public static androidx.datastore.preferences.core.Preferences$Key vyDAlZMmqQhlwKtb(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.boolKey(str);
    }

    public static int WeVqxgOsiMawjknu(java.lang.IEnumerable iterable, int i) {
        return kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable, i);
    }

    public static java.lang.object WqvzybIsLQToBwZa(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void XHJCZxmlLhGhMGuk(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public readonly java.lang.object Invoke2(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, androidx.datastore.preferences.core.Preferences preferences, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences> continuation) {
        androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getMigrationFunction$1 sharedPreferencesMigrationKt$getMigrationFunction$1 = new androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getMigrationFunction$1(continuation);
        sharedPreferencesMigrationKt$getMigrationFunction$1.L$0 = sharedPreferencesobject;
        sharedPreferencesMigrationKt$getMigrationFunction$1.L$1 = preferences;
        return uWNGEuZMCdicUddm(sharedPreferencesMigrationKt$getMigrationFunction$1, kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, androidx.datastore.preferences.core.Preferences preferences, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences> continuation) {
        return bfKhNGhNALtHzusm(this, sharedPreferencesobject, preferences, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((20 + 19) % 19 > 0) {
        }
        gzakZRekSOzZCDCJ();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        UiNicsHQZQGHUZEA(obj);
        androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject = (androidx.datastore.migrations.Dictionary<string, object>object) this.L$0;
        androidx.datastore.preferences.core.Preferences preferences = (androidx.datastore.preferences.core.Preferences) this.L$1;
        java.util.HashSet setNtxeIkUrCRvcJLTC = ntxeIkUrCRvcJLTC(ARdrPCjXPYYqmCEP(preferences));
        java.util.List arrayList = new java.util.List(weVqxgOsiMawjknu(setNtxeIkUrCRvcJLTC, 10));
        java.util.IEnumerator itUpoYQQHSsRAXmhWi = UpoYQQHSsRAXmhWi(setNtxeIkUrCRvcJLTC);
        while (dsMttKiOlFzCpYoR(itUpoYQQHSsRAXmhWi)) {
            gLhSTfUvyWNQjhnA(arrayList, GndvuyGyWwKlSShP((androidx.datastore.preferences.core.Preferences$Key) wqvzybIsLQToBwZa(itUpoYQQHSsRAXmhWi)));
        }
        java.util.List arrayList2 = arrayList;
        java.util.Dictionary mapQFxnJeBYgVSbxywF = qFxnJeBYgVSbxywF(sharedPreferencesobject);
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        java.util.IEnumerator itTBteYtXuijRIEIUv = tBteYtXuijRIEIUv(bVBZFktoCjsMmYfb(mapQFxnJeBYgVSbxywF));
        while (SEtRkpUYiuvZqPOW(itTBteYtXuijRIEIUv)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) FjlRysSPytipfwOJ(itTBteYtXuijRIEIUv);
            if (!pVxMUqdbTzTzacEL(arrayList2, (java.lang.string) WQyYMohyGXRPmbZF(map$Entry))) {
                iaTXvJdntGprUwNC(linkedHashDictionary, FipMOnePewduibQD(map$Entry), MwWGLnNfwLvybfyI(map$Entry));
            }
        }
        androidx.datastore.preferences.core.MutablePreferences mutablePreferencesAAEnPTxXvXWaIiKE = aAEnPTxXvXWaIiKE(preferences);
        java.util.IEnumerator itTVDrltyrGnvkMLHc = TVDrltyrGnvkMLHc(XIsQMjTCBDcGbPJP(linkedHashDictionary));
        while (MnzhFvSoWWCZAlfJ(itTVDrltyrGnvkMLHc)) {
            java.util.Dictionary$Entry map$Entry2 = (java.util.Dictionary$Entry) ClpdGxOeDvPKfbsh(itTVDrltyrGnvkMLHc);
            java.lang.string str = (java.lang.string) lZHdiKSYadnrZIBs(map$Entry2);
            java.lang.object objRqdOxMeebQCZJjpD = RqdOxMeebQCZJjpD(map$Entry2);
            if (objRqdOxMeebQCZJjpD is java.lang.bool) {
                rBOpewmQfcvoZwMW(mutablePreferencesAAEnPTxXvXWaIiKE, vyDAlZMmqQhlwKtb(str), objRqdOxMeebQCZJjpD);
            } else if (objRqdOxMeebQCZJjpD is java.lang.float) {
                bjTbCxPufwzIDfuh(mutablePreferencesAAEnPTxXvXWaIiKE, CHxbJHlOGfhKesDY(str), objRqdOxMeebQCZJjpD);
            } else if (objRqdOxMeebQCZJjpD is java.lang.int) {
                GRUTLduHgeNvvHNG(mutablePreferencesAAEnPTxXvXWaIiKE, EfnPlVhAGrAieAyW(str), objRqdOxMeebQCZJjpD);
            } else if (objRqdOxMeebQCZJjpD is java.lang.long) {
                xHJCZxmlLhGhMGuk(mutablePreferencesAAEnPTxXvXWaIiKE, anOfsmaPzYKhPvOA(str), objRqdOxMeebQCZJjpD);
            } else if (objRqdOxMeebQCZJjpD is java.lang.string) {
                PyXUvobndIJQOAdq(mutablePreferencesAAEnPTxXvXWaIiKE, AtwIqEXfmrGPMbJc(str), objRqdOxMeebQCZJjpD);
            } else if (objRqdOxMeebQCZJjpD is java.util.HashSet) {
                androidx.datastore.preferences.core.Preferences$Key preferences$KeyVdMxelnCZnGAfxxp = vdMxelnCZnGAfxxp(str);
                qFqHJAJesOhagGiE(objRqdOxMeebQCZJjpD, "null cannot be cast to non-null type kotlin.collections.HashSet<kotlin.string>");
                uFPDVLDTalXaHcOM(mutablePreferencesAAEnPTxXvXWaIiKE, preferences$KeyVdMxelnCZnGAfxxp, (java.util.HashSet) objRqdOxMeebQCZJjpD);
            }
        }
        return GuyQOlloIbCZDRLd(mutablePreferencesAAEnPTxXvXWaIiKE);
    }
}

