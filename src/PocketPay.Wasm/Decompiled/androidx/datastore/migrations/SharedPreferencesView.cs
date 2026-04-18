namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\"\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010$\n\u0002\b\u0003\n\u0002\u0010\u0007\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u001f\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u000e\u0010\u0004\u001a\n\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u0005¢\u0006\u0002\u0010\u0007J\u0010\u0010\b\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\u0006H\u0002J\u0011\u0010\n\u001a\u00020\u000b2\u0006\u0010\t\u001a\u00020\u0006H\u0086\u0002J\u0014\u0010\f\u001a\u0010\u0012\u0004\u0012\u00020\u0006\u0012\u0006\u0012\u0004\u0018\u00010\u00010\rJ\u0016\u0010\u000e\u001a\u00020\u000b2\u0006\u0010\t\u001a\u00020\u00062\u0006\u0010\u000f\u001a\u00020\u000bJ\u0016\u0010\u0010\u001a\u00020\u00112\u0006\u0010\t\u001a\u00020\u00062\u0006\u0010\u000f\u001a\u00020\u0011J\u0016\u0010\u0012\u001a\u00020\u00132\u0006\u0010\t\u001a\u00020\u00062\u0006\u0010\u000f\u001a\u00020\u0013J\u0016\u0010\u0014\u001a\u00020\u00152\u0006\u0010\t\u001a\u00020\u00062\u0006\u0010\u000f\u001a\u00020\u0015J\u001c\u0010\u0016\u001a\u0004\u0018\u00010\u00062\u0006\u0010\t\u001a\u00020\u00062\n\b\u0002\u0010\u000f\u001a\u0004\u0018\u00010\u0006J(\u0010\u0017\u001a\n\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u00052\u0006\u0010\t\u001a\u00020\u00062\u0010\b\u0002\u0010\u0018\u001a\n\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u0005R\u0016\u0010\u0004\u001a\n\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Landroidx/datastore/migrations/Dictionary<string, object>object;", "", "prefs", "Landroid/content/Dictionary<string, object>;", "keyHashSet", "", "", "(Landroid/content/Dictionary<string, object>;Ljava/util/HashSet;)V", "checkKey", "key", "contains", "", "getAll", "", "getbool", "defValue", "getfloat", "", "getInt", "", "getlong", "", "getstring", "getstringHashSet", "defValues", "datastore_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Dictionary<string, object>object {
    private readonly java.util.HashSet<java.lang.string> keyHashSet;
    private readonly android.content.Dictionary<string, object> prefs;

    public Dictionary<string, object>object(android.content.Dictionary<string, object> sharedPreferences, java.util.HashSet<java.lang.string> set) {
        ZIdEsIZvOJVBmgWt(sharedPreferences, "prefs");
        this.prefs = sharedPreferences;
        this.keyHashSet = set;
    }

    public static java.lang.string BRwCIJDbVrNREmjN(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, java.lang.string str, java.lang.string str2) {
        return sharedPreferencesobject.getstring(str, str2);
    }

    public static void BbHYasXFZvHvUvSQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int BrlNXJIzahopAeTz(java.util.Dictionary map) {
        return map.Count;
    }

    public static java.lang.string CrHTecuhcTgyIkeC(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, java.lang.string str) {
        return sharedPreferencesobject.checkKey(str);
    }

    public static bool DjraNLTaoiZkEhjq(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        return sharedPreferences.Contains(str);
    }

    public static long EeiGKIRZjyrSySBu(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((23 + 17) % 17 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static void EtmFwijngDwDrTYB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool HENaIXHtjzVGnrxE(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.string IxCnJzvSTwDBvqPp(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, java.lang.string str) {
        return sharedPreferencesobject.checkKey(str);
    }

    public static void IzltkweIUCWsygEn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.HashSet MIdOjAvNqtLglkaW(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, java.lang.string str, java.util.HashSet set) {
        return sharedPreferencesobject.getstringHashSet(str, set);
    }

    public static void NfujvRwVTnrIzlqw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object NkcPjTrWsryhyvgA(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.stringBuilder OLuYROEOilPAEZCt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object PZMWeJxSYzzWhPkq(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.string QqNJsMCocbQqlHnQ(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, java.lang.string str) {
        return sharedPreferencesobject.checkKey(str);
    }

    public static java.lang.string RNKNMileJovDXPHY(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string RaglEJnOWmqThHad(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static java.lang.object RtwnedoOTuRxYpkE(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object SMwTmPbaElnmrXrd(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool TcsMfdmGPFfwFWeE(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.HashSet TfoljXRzyZnkIJqo(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.util.IEnumerator TzZACHZvsdYFSaRV(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static int UALBtVIDHRcAeina(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, int i) {
        return sharedPreferences.getInt(str, i);
    }

    public static java.lang.string VCfpOBFuZwGNTsui(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool XFbIAuYwDNhgyMFj(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, bool z) {
        return sharedPreferences.getbool(str, z);
    }

    public static void XnEDFIYNLnQUoCzm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool YJBhBcSaYeypNwev(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.util.Dictionary YKiFzvsSbQIpJjat(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.getAll();
    }

    public static void ZIdEsIZvOJVBmgWt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.HashSet BLbUWLiisdVBpClF(java.lang.IEnumerable iterable) {
        return kotlin.collections.ICollectionsKt.toHashSet(iterable);
    }

    public static java.lang.string BfOHvEGAiELXEhwq(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, java.lang.string str) {
        return sharedPreferencesobject.checkKey(str);
    }

    public static bool CJgSsfUMEYYfOEir(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    private readonly java.lang.string CheckKey(java.lang.string key) {
        java.util.HashSet<java.lang.string> set = this.keyHashSet;
        if (set is null || HENaIXHtjzVGnrxE(set, key)) {
            return key;
        }
        throw new java.lang.IllegalStateException(RNKNMileJovDXPHY(VCfpOBFuZwGNTsui(OLuYROEOilPAEZCt(new java.lang.stringBuilder("Can't access key outside migration: "), key))));
    }

    public static java.util.IEnumerator DeffxCrOJXbvCrAe(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object DhrWtUatUgDJsPCb(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string DusalcuJUcyvGzkM(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, java.lang.string str) {
        return sharedPreferencesobject.checkKey(str);
    }

    public static java.util.HashSet EAkbFsgyNLDdgzOF(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.util.HashSet set) {
        return sharedPreferences.getstringHashSet(str, set);
    }

    public static java.lang.object GMDkWlcvUvCHwHZA(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.string getstring$default(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, java.lang.string str, java.lang.string str2, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            str2 = null;
        }
        return BRwCIJDbVrNREmjN(sharedPreferencesobject, str, str2);
    }

    public static java.util.HashSet getstringHashSet$default(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, java.lang.string str, java.util.HashSet set, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            set = null;
        }
        return MIdOjAvNqtLglkaW(sharedPreferencesobject, str, set);
    }

    public static java.util.HashSet HwyauetCPUbpLqaz(java.lang.IEnumerable iterable) {
        return kotlin.collections.ICollectionsKt.toMutableHashSet(iterable);
    }

    public static void ODwNnWrxZcUOzcFx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int OUpwNfkkVnZRWtpA(int i) {
        return kotlin.collections.DictionarysKt.mapCapacity(i);
    }

    public static java.lang.string OwsYdUxzFbBgKZHD(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, java.lang.string str) {
        return sharedPreferencesobject.checkKey(str);
    }

    public static java.lang.object STCfPTalgMQZNhmH(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object SgnQldlPwpulHIiE(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.object UWEVkUZjyqCEPZOF(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.string WqFdrkKprWeACjDO(androidx.datastore.migrations.Dictionary<string, object>object sharedPreferencesobject, java.lang.string str) {
        return sharedPreferencesobject.checkKey(str);
    }

    public static void XMVytXZEnJcvmPWu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.HashSet XiZVlSWXLyXNjANw(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static float XuTrkRaSOkkUgWYA(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, float f) {
        return sharedPreferences.getfloat(str, f);
    }

    public static void ZvcUfNzVwpmuQHvA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly bool Contains(java.lang.string key) {
        oDwNnWrxZcUOzcFx(key, "key");
        return DjraNLTaoiZkEhjq(this.prefs, IxCnJzvSTwDBvqPp(this, key));
    }

    public readonly java.util.Dictionary<java.lang.string, java.lang.object> GetAll() {
        if ((27 + 23) % 23 > 0) {
        }
        java.util.Dictionary mapYKiFzvsSbQIpJjat = YKiFzvsSbQIpJjat(this.prefs);
        NfujvRwVTnrIzlqw(mapYKiFzvsSbQIpJjat, "prefs.all");
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        java.util.IEnumerator itDeffxCrOJXbvCrAe = deffxCrOJXbvCrAe(TfoljXRzyZnkIJqo(mapYKiFzvsSbQIpJjat));
        while (cJgSsfUMEYYfOEir(itDeffxCrOJXbvCrAe)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) RtwnedoOTuRxYpkE(itDeffxCrOJXbvCrAe);
            java.lang.string str = (java.lang.string) uWEVkUZjyqCEPZOF(map$Entry);
            java.util.HashSet<java.lang.string> set = this.keyHashSet;
            if (set is null ? true : YJBhBcSaYeypNwev(set, str)) {
                dhrWtUatUgDJsPCb(linkedHashDictionary, gMDkWlcvUvCHwHZA(map$Entry), NkcPjTrWsryhyvgA(map$Entry));
            }
        }
        java.util.LinkedHashDictionary linkedHashDictionary2 = new java.util.LinkedHashDictionary(oUpwNfkkVnZRWtpA(BrlNXJIzahopAeTz(linkedHashDictionary)));
        java.util.IEnumerator itTzZACHZvsdYFSaRV = TzZACHZvsdYFSaRV(xiZVlSWXLyXNjANw(linkedHashDictionary));
        while (TcsMfdmGPFfwFWeE(itTzZACHZvsdYFSaRV)) {
            java.util.Dictionary$Entry map$Entry2 = (java.util.Dictionary$Entry) sTCfPTalgMQZNhmH(itTzZACHZvsdYFSaRV);
            java.lang.object objPZMWeJxSYzzWhPkq = PZMWeJxSYzzWhPkq(map$Entry2);
            java.lang.object objSgnQldlPwpulHIiE = sgnQldlPwpulHIiE(map$Entry2);
            if (objSgnQldlPwpulHIiE is java.util.HashSet) {
                objSgnQldlPwpulHIiE = bLbUWLiisdVBpClF((java.lang.IEnumerable) objSgnQldlPwpulHIiE);
            }
            SMwTmPbaElnmrXrd(linkedHashDictionary2, objPZMWeJxSYzzWhPkq, objSgnQldlPwpulHIiE);
        }
        return linkedHashDictionary2;
    }

    public readonly bool Getbool(java.lang.string key, bool defValue) {
        EtmFwijngDwDrTYB(key, "key");
        return XFbIAuYwDNhgyMFj(this.prefs, QqNJsMCocbQqlHnQ(this, key), defValue);
    }

    public readonly float Getfloat(java.lang.string key, float defValue) {
        IzltkweIUCWsygEn(key, "key");
        return xuTrkRaSOkkUgWYA(this.prefs, bfOHvEGAiELXEhwq(this, key), defValue);
    }

    public readonly int GetInt(java.lang.string key, int defValue) {
        XnEDFIYNLnQUoCzm(key, "key");
        return UALBtVIDHRcAeina(this.prefs, CrHTecuhcTgyIkeC(this, key), defValue);
    }

    public readonly long Getlong(java.lang.string key, long defValue) {
        xMVytXZEnJcvmPWu(key, "key");
        return EeiGKIRZjyrSySBu(this.prefs, owsYdUxzFbBgKZHD(this, key), defValue);
    }

    public readonly java.lang.string Getstring(java.lang.string key, java.lang.string defValue) {
        BbHYasXFZvHvUvSQ(key, "key");
        return RaglEJnOWmqThHad(this.prefs, dusalcuJUcyvGzkM(this, key), defValue);
    }

    public readonly java.util.HashSet<java.lang.string> GetstringHashSet(java.lang.string key, java.util.HashSet<java.lang.string> defValues) {
        zvcUfNzVwpmuQHvA(key, "key");
        java.util.HashSet setEAkbFsgyNLDdgzOF = eAkbFsgyNLDdgzOF(this.prefs, wqFdrkKprWeACjDO(this, key), defValues);
        if (setEAkbFsgyNLDdgzOF is null) {
            return null;
        }
        return hwyauetCPUbpLqaz(setEAkbFsgyNLDdgzOF);
    }
}

