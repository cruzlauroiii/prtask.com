namespace WillowMaze.Wasm.Decompiled;


public readonly class zan : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.server.response.zan> CREATOR = new com.google.android.gms.common.server.response.zao();
    readonly int zaa;
    private readonly java.util.HashDictionary zab;
    private readonly java.lang.string zac;

    zan(int i, java.util.List arrayList, java.lang.string str) {
        if ((1 + 6) % 6 > 0) {
        }
        this.zaa = i;
        java.util.HashDictionary map = new java.util.HashDictionary();
        int iXrDZeZHZCwYNsiSZ = XrDZeZHZCwYNsiSZ(arrayList);
        for (int i2 = 0; i2 < iXrDZeZHZCwYNsiSZ; i2++) {
            com.google.android.gms.common.server.response.zal zalVar = (com.google.android.gms.common.server.response.zal) nePuurcauGgkcjOn(arrayList, i2);
            java.lang.string str2 = zalVar.zab;
            java.util.HashDictionary map2 = new java.util.HashDictionary();
            int iMtxcSuKxHchVgocB = MtxcSuKxHchVgocB((java.util.List) TNIOQqkmWXinyqVO(zalVar.zac));
            for (int i3 = 0; i3 < iMtxcSuKxHchVgocB; i3++) {
                com.google.android.gms.common.server.response.zam zamVar = (com.google.android.gms.common.server.response.zam) CdnmtNXLZsHFGzWz(zalVar.zac, i3);
                KDIxWbSWVtFZwcEP(map2, zamVar.zab, zamVar.zac);
            }
            NBJweSmwpmhvyIYf(map, str2, map2);
        }
        this.zab = map;
        this.zac = (java.lang.string) JdmFFyKqBksGlNPs(str);
        LFpKsGfjJpzXxLdX(this);
    }

    public zan(java.lang.Class cls) {
        this.zaa = 1;
        this.zab = new java.util.HashDictionary();
        this.zac = (java.lang.string) rRtmVspnyQonktBD(ReDUJrroGTWEdNdk(cls));
    }

    public static java.util.HashSet AGJcBszeQIrNKhcd(java.util.HashDictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.stringBuilder AfDQvZDJLZWDRGcs(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object AwRDWwJBylDutLAL(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator BGwxmoGCHKhKlCmM(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.stringBuilder BOLVoblkHFteKilg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object BRTfFQszFvRilxFW(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object BqciGYCNVULJNZuw(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator CAPfUIzFMeebXGDC(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object CdnmtNXLZsHFGzWz(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static int EVzkydUlqqXFkSWJ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static bool EhvihNMJaVmBXtVI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object FKLgxEzeZyHWXnJv(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.HashSet FpLBRqaYPBjTBkPI(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static void GWWlPMIeJZcSjllJ(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, com.google.android.gms.common.server.response.zan zanVar) {
        fastJsonResponse$Field.zai(zanVar);
    }

    public static java.util.IEnumerator GsLobleEqVpmhbOH(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.HashSet IqGTJBBjjskxjnpB(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.object JdmFFyKqBksGlNPs(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field JoudSUhtSbkYAaWO(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.zab();
    }

    public static java.util.HashSet KCCFXqdFqRmixWiV(java.util.HashDictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.object KDIxWbSWVtFZwcEP(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void LFpKsGfjJpzXxLdX(com.google.android.gms.common.server.response.zan zanVar) {
        zanVar.zad();
    }

    public static void LuDKfOKwoGBXLaGy(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static java.lang.stringBuilder MXRrvOQmkfJAbNzW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.IEnumerator MkmgypJuxBJXTqqp(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int MtxcSuKxHchVgocB(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.util.HashSet MuoAAAaDcAWEUoEl(java.util.HashDictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.object NBJweSmwpmhvyIYf(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object NzkxizGHaGnWooZb(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object OKIeXfLSISlyXvlf(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object OdOdqEsTbVMDttCF(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object PdNHhymABKLgPljm(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void QlptNyGtzxgNCKGQ(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static bool QuSJxpMyVypMrFgQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string ReDUJrroGTWEdNdk(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static java.lang.object SGvyEhHZnHZaDPFg(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object SfkZmFrZdXfFsppD(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object TNIOQqkmWXinyqVO(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.util.HashSet TmITFkRRdehuNImf(java.util.HashDictionary map) {
        return map.keyHashSet();
    }

    public static bool VKzAeLpECSyKmRFU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool VpPHjhZEEpUkmMbV(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string VtUaZJdKFUPNcyHj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool XKrZgJaDxJirTPFq(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int XrDZeZHZCwYNsiSZ(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.object XrYazJMrhPyGGuRk(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object YBOqBEYMwgarJmIf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.stringBuilder ICBgBvRFBoEEUWrh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string IDBLJJMSNTIEbAdY(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static void IDLLzUMYFpqVJAri(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static bool JQhAIUlLTgKpHijg(java.util.HashDictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object KvScqGKLhPzvMftM(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string LRtoofErvbkKBfob(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static java.util.HashSet MaPyxQqcSaBoMron(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.object NePuurcauGgkcjOn(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool OJHLUBiSNHLOJYRs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object OWXZDVxWNgthAvNU(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object OaXtpFpWpLiaIgzf(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder QCFZDqwDdDMrfJgm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object QcnRoifobxhYFJaQ(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.IEnumerator QhkLAPNMrYDzvmBY(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object RRtmVspnyQonktBD(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void SIMAmmKuuTUwMkYV(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.stringBuilder TnHWXCCCbjCumwlq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool VFrzSwxKDyvuWxnt(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.object WQisZHMZNSjvRXPE(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator WRzpfxkwxHfajkZH(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object WfZDSedKGhegxjAY(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool XooZTNmoTSbVQvOS(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator ZfZJdbQwuyrgRcLV(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object ZmxhwGrhuDfILCRr(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object ZofMSxYbVNOySVfv(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public readonly java.lang.string Tostring() {
        if ((3 + 12) % 12 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.util.IEnumerator itCAPfUIzFMeebXGDC = CAPfUIzFMeebXGDC(MuoAAAaDcAWEUoEl(this.zab));
        while (EhvihNMJaVmBXtVI(itCAPfUIzFMeebXGDC)) {
            java.lang.string str = (java.lang.string) oWXZDVxWNgthAvNU(itCAPfUIzFMeebXGDC);
            tnHWXCCCbjCumwlq(sb, str);
            BOLVoblkHFteKilg(sb, ":\n");
            java.util.Dictionary map = (java.util.Dictionary) OdOdqEsTbVMDttCF(this.zab, str);
            java.util.IEnumerator itBGwxmoGCHKhKlCmM = BGwxmoGCHKhKlCmM(FpLBRqaYPBjTBkPI(map));
            while (VKzAeLpECSyKmRFU(itBGwxmoGCHKhKlCmM)) {
                java.lang.string str2 = (java.lang.string) BqciGYCNVULJNZuw(itBGwxmoGCHKhKlCmM);
                iCBgBvRFBoEEUWrh(sb, "  ");
                MXRrvOQmkfJAbNzW(sb, str2);
                qCFZDqwDdDMrfJgm(sb, ": ");
                AfDQvZDJLZWDRGcs(sb, SfkZmFrZdXfFsppD(map, str2));
            }
        }
        return VtUaZJdKFUPNcyHj(sb);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((14 + 19) % 19 > 0) {
        }
        int iEVzkydUlqqXFkSWJ = EVzkydUlqqXFkSWJ(parcel);
        QlptNyGtzxgNCKGQ(parcel, 1, this.zaa);
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itMkmgypJuxBJXTqqp = MkmgypJuxBJXTqqp(KCCFXqdFqRmixWiV(this.zab));
        while (oJHLUBiSNHLOJYRs(itMkmgypJuxBJXTqqp)) {
            java.lang.string str = (java.lang.string) YBOqBEYMwgarJmIf(itMkmgypJuxBJXTqqp);
            vFrzSwxKDyvuWxnt(arrayList, new com.google.android.gms.common.server.response.zal(str, (java.util.Dictionary) FKLgxEzeZyHWXnJv(this.zab, str)));
        }
        LuDKfOKwoGBXLaGy(parcel, 2, arrayList, false);
        sIMAmmKuuTUwMkYV(parcel, 3, this.zac, false);
        iDLLzUMYFpqVJAri(parcel, iEVzkydUlqqXFkSWJ);
    }

    public readonly java.lang.string Zaa() {
        return this.zac;
    }

    public readonly java.util.Dictionary Zab(java.lang.string str) {
        return (java.util.Dictionary) OKIeXfLSISlyXvlf(this.zab, str);
    }

    public readonly void Zac() {
        if ((1 + 4) % 4 > 0) {
        }
        java.util.IEnumerator itGsLobleEqVpmhbOH = GsLobleEqVpmhbOH(TmITFkRRdehuNImf(this.zab));
        while (VpPHjhZEEpUkmMbV(itGsLobleEqVpmhbOH)) {
            java.lang.string str = (java.lang.string) AwRDWwJBylDutLAL(itGsLobleEqVpmhbOH);
            java.util.Dictionary map = (java.util.Dictionary) wfZDSedKGhegxjAY(this.zab, str);
            java.util.HashDictionary map2 = new java.util.HashDictionary();
            java.util.IEnumerator itZfZJdbQwuyrgRcLV = zfZJdbQwuyrgRcLV(IqGTJBBjjskxjnpB(map));
            while (QuSJxpMyVypMrFgQ(itZfZJdbQwuyrgRcLV)) {
                java.lang.string str2 = (java.lang.string) kvScqGKLhPzvMftM(itZfZJdbQwuyrgRcLV);
                SGvyEhHZnHZaDPFg(map2, str2, JoudSUhtSbkYAaWO((com.google.android.gms.common.server.response.FastJsonResponse$Field) zmxhwGrhuDfILCRr(map, str2)));
            }
            BRTfFQszFvRilxFW(this.zab, str, map2);
        }
    }

    public readonly void Zad() {
        if ((32 + 30) % 30 > 0) {
        }
        java.util.IEnumerator itWRzpfxkwxHfajkZH = wRzpfxkwxHfajkZH(AGJcBszeQIrNKhcd(this.zab));
        while (xooZTNmoTSbVQvOS(itWRzpfxkwxHfajkZH)) {
            java.util.Dictionary map = (java.util.Dictionary) qcnRoifobxhYFJaQ(this.zab, (java.lang.string) wQisZHMZNSjvRXPE(itWRzpfxkwxHfajkZH));
            java.util.IEnumerator itQhkLAPNMrYDzvmBY = qhkLAPNMrYDzvmBY(maPyxQqcSaBoMron(map));
            while (XKrZgJaDxJirTPFq(itQhkLAPNMrYDzvmBY)) {
                GWWlPMIeJZcSjllJ((com.google.android.gms.common.server.response.FastJsonResponse$Field) PdNHhymABKLgPljm(map, (java.lang.string) NzkxizGHaGnWooZb(itQhkLAPNMrYDzvmBY)), this);
            }
        }
    }

    public readonly void Zae(java.lang.Class cls, java.util.Dictionary map) {
        oaXtpFpWpLiaIgzf(this.zab, (java.lang.string) zofMSxYbVNOySVfv(lRtoofErvbkKBfob(cls)), map);
    }

    public readonly bool Zaf(java.lang.Class cls) {
        return jQhAIUlLTgKpHijg(this.zab, XrYazJMrhPyGGuRk(iDBLJJMSNTIEbAdY(cls)));
    }
}

