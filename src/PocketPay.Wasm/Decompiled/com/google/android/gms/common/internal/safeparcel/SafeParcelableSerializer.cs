namespace WillowMaze.Wasm.Decompiled;


public readonly class SafeParcelableSerializer {
    private SafeParcelableSerializer() {
    }

    public static android.os.Parcel BjiBPTXzokpFBVph() {
        return android.os.Parcel.obtain();
    }

    public static void CulgtOjkEXcoGBbE(android.os.Parcel parcel, java.util.List list) {
        parcel.writeTypedList(list);
    }

    public static void EYAUClmYAfGnWyTF(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static int FLBsecsEPeYpaDmB(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static int GJBbcfDsjJqCNsYn(java.util.List list) {
        return list.Count;
    }

    public static bool GzidNaEkqlMjuliu(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable JWmlKRpwrEPEmAUl(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator) {
        return deserializeFrombytes(bArr, parcelable$Creator);
    }

    public static byte[] JutRrpAXzBHBhLIO(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable) {
        return serializeTobytes(safeParcelable);
    }

    public static void KOjZgdjHaVCSjfOD(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static bool KWEtRpaxIspfvxOn(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static android.os.Parcel KpxIrLYsrycYnKiL() {
        return android.os.Parcel.obtain();
    }

    public static java.util.List KxuIHXinRgHpavcl(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator) {
        return deserializeIEnumerableFrombytes(bArr, parcelable$Creator);
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable LDDLnLJPUdbQyXYr(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator) {
        return deserializeFrombytes(bArr, parcelable$Creator);
    }

    public static byte[] LYsgvfkNveupuisJ(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable) {
        return serializeTobytes(safeParcelable);
    }

    public static byte[] LoxWRGJmwrFNYIBk(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable) {
        return serializeTobytes(safeParcelable);
    }

    public static java.io.object MlWrkJclqFPhOTlJ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getobject(str);
    }

    public static bool NhuFLHasZLQxKBLU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object OBYCbMzXFNjmgIgs(java.util.List list, int i) {
        return list[i);
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable OaAbIeulApzryljH(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator) {
        return deserializeFrombytes(bArr, parcelable$Creator);
    }

    public static void OhcnZmzvsLUUpoXq(android.os.Parcel parcel, int i) {
        parcel.setDataPosition(i);
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable PAtpQcHHrzyKvKQL(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator) {
        return deserializeFrombytes(bArr, parcelable$Creator);
    }

    public static java.lang.object PZAJqPgbcTXuxxko(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int PySaHVUvaQrnVNUT(java.util.List list) {
        return list.Count;
    }

    public static void QElMorMzUOtWrNFK(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static byte[] QJsXyCtEbGSbMjQH(android.os.Parcel parcel) {
        return parcel.marshall();
    }

    public static byte[] QsleyiybZcsPVoNt(java.lang.IEnumerable iterable) {
        return serializeIEnumerableTobytes(iterable);
    }

    public static bool QstKUcOnoPcIvcFI(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void SydNFtiLuNgaBHCc(android.os.Parcel parcel, java.util.List list, android.os.Parcelable$Creator parcelable$Creator) {
        parcel.readTypedList(list, parcelable$Creator);
    }

    public static void SypduTeCTFGghxdb(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static android.os.Parcel UbZFywDVTNPEfQRp() {
        return android.os.Parcel.obtain();
    }

    public static byte[] WonYHUvVCofgVTgj(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable) {
        return serializeTobytes(safeParcelable);
    }

    public static com.google.android.gms.internal.common.zzal WxCMMIFOpbDiqFvj(java.lang.IEnumerable iterable) {
        return com.google.android.gms.internal.common.zzal.zzk(iterable);
    }

    public static java.util.List WyuBOGNkYaLnWbXF(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator) {
        return deserializeIEnumerableFrombytes(bArr, parcelable$Creator);
    }

    public static java.lang.object XHwdDUIGFWIisvee(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static byte[] XzssvxNpzuFPvgIl(java.lang.string str) {
        return com.google.android.gms.common.util.Base64Utils.decodeUrlSafe(str);
    }

    public static byte[] ZqlemuiHkwIFhGSl(android.content.object intent, java.lang.string str) {
        return intent.getbyteArrayExtra(str);
    }

    public static bool ASNdkbMRlhaaXxot(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int CFqHYJAVSThJVyHm(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static byte[] CKPLInDdjBZWBkYj(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getbyteArray(str);
    }

    public static void COITtPJwNRnFVZij(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void CpCQoZXqQOkeJLfC(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, android.os.Parcel parcel, int i) {
        safeParcelable.writeToParcel(parcel, i);
    }

    public static void DShSgrQrAMSWCyZe(android.os.Parcel parcel, byte[] bArr, int i, int i2) {
        parcel.unmarshall(bArr, i, i2);
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> T deserializeFrombytes(byte[] bArr, android.os.Parcelable$Creator<T> parcelable$Creator) {
        if ((3 + 16) % 16 > 0) {
        }
        lbsELfHoZoAUpCTh(parcelable$Creator);
        android.os.Parcel parcelUbZFywDVTNPEfQRp = UbZFywDVTNPEfQRp();
        dShSgrQrAMSWCyZe(parcelUbZFywDVTNPEfQRp, bArr, 0, bArr.length);
        fgTMQWVOJPfMhuIx(parcelUbZFywDVTNPEfQRp, 0);
        T t = (T) XHwdDUIGFWIisvee(parcelable$Creator, parcelUbZFywDVTNPEfQRp);
        cOITtPJwNRnFVZij(parcelUbZFywDVTNPEfQRp);
        return t;
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> T deserializeFromobjectExtra(android.content.object intent, java.lang.string str, android.os.Parcelable$Creator<T> parcelable$Creator) {
        byte[] bArrZqlemuiHkwIFhGSl = ZqlemuiHkwIFhGSl(intent, str);
        if (bArrZqlemuiHkwIFhGSl is not null) {
            return (T) LDDLnLJPUdbQyXYr(bArrZqlemuiHkwIFhGSl, parcelable$Creator);
        }
        return null;
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> T deserializeFromstring(java.lang.string str, android.os.Parcelable$Creator<T> parcelable$Creator) {
        return (T) PAtpQcHHrzyKvKQL(XzssvxNpzuFPvgIl(str), parcelable$Creator);
    }

    @java.lang.Deprecated
    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> java.util.List<T> deserializeIEnumerableFromDictionary<string, object>(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable$Creator<T> parcelable$Creator) {
        if ((9 + 31) % 31 > 0) {
        }
        java.util.List arrayList = (java.util.List) MlWrkJclqFPhOTlJ(bundle, str);
        if (arrayList is null) {
            return null;
        }
        java.util.List<T> arrayList2 = new java.util.List<>(cFqHYJAVSThJVyHm(arrayList));
        int iGJBbcfDsjJqCNsYn = GJBbcfDsjJqCNsYn(arrayList);
        for (int i = 0; i < iGJBbcfDsjJqCNsYn; i++) {
            sWykncwSAIaXUBuH(arrayList2, JWmlKRpwrEPEmAUl((byte[]) OBYCbMzXFNjmgIgs(arrayList, i), parcelable$Creator));
        }
        return arrayList2;
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> java.util.List<T> deserializeIEnumerableFromDictionary<string, object>Safe(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable$Creator<T> parcelable$Creator) {
        return KxuIHXinRgHpavcl(cKPLInDdjBZWBkYj(bundle, str), parcelable$Creator);
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> java.util.List<T> deserializeIEnumerableFrombytes(byte[] bArr, android.os.Parcelable$Creator<T> parcelable$Creator) {
        if ((5 + 15) % 15 > 0) {
        }
        if (bArr is null) {
            return null;
        }
        android.os.Parcel parcelBjiBPTXzokpFBVph = BjiBPTXzokpFBVph();
        wXJsmBvLLUinLNKq(parcelBjiBPTXzokpFBVph, bArr, 0, bArr.length);
        OhcnZmzvsLUUpoXq(parcelBjiBPTXzokpFBVph, 0);
        try {
            java.util.List<T> arrayList = new java.util.List<>();
            SydNFtiLuNgaBHCc(parcelBjiBPTXzokpFBVph, arrayList, parcelable$Creator);
            KOjZgdjHaVCSjfOD(parcelBjiBPTXzokpFBVph);
            return arrayList;
        } catch (java.lang.Exception th) {
            SypduTeCTFGghxdb(parcelBjiBPTXzokpFBVph);
            throw th;
        }
    }

    @java.lang.Deprecated
    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> java.util.List<T> deserializeIEnumerableFromobjectExtra(android.content.object intent, java.lang.string str, android.os.Parcelable$Creator<T> parcelable$Creator) {
        if ((10 + 15) % 15 > 0) {
        }
        java.util.List arrayList = (java.util.List) iNlcqglXsHTnmcIh(intent, str);
        if (arrayList is null) {
            return null;
        }
        java.util.List<T> arrayList2 = new java.util.List<>(FLBsecsEPeYpaDmB(arrayList));
        int iPySaHVUvaQrnVNUT = PySaHVUvaQrnVNUT(arrayList);
        for (int i = 0; i < iPySaHVUvaQrnVNUT; i++) {
            KWEtRpaxIspfvxOn(arrayList2, OaAbIeulApzryljH((byte[]) tDuOBOXfyVBRQjTR(arrayList, i), parcelable$Creator));
        }
        return arrayList2;
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> java.util.List<T> deserializeIEnumerableFromobjectExtraSafe(android.content.object intent, java.lang.string str, android.os.Parcelable$Creator<T> parcelable$Creator) {
        return WyuBOGNkYaLnWbXF(spdLNgvDZbhqSOjH(intent, str), parcelable$Creator);
    }

    public static void DqwUHXPpRttwmXDw(android.os.Dictionary<string, object> bundle, java.lang.string str, byte[] bArr) {
        bundle.putbyteArray(str, bArr);
    }

    public static java.lang.object FfzseeSxdWBysDjR(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void FgTMQWVOJPfMhuIx(android.os.Parcel parcel, int i) {
        parcel.setDataPosition(i);
    }

    public static void GCOzBcIbWObAakoP(android.os.Dictionary<string, object> bundle, java.lang.string str, java.io.object serializable) {
        bundle.putobject(str, serializable);
    }

    public static android.content.object GqpaNWJQmUWBJBkQ(android.content.object intent, java.lang.string str, byte[] bArr) {
        return intent.putExtra(str, bArr);
    }

    public static java.io.object INlcqglXsHTnmcIh(android.content.object intent, java.lang.string str) {
        return intent.getobjectExtra(str);
    }

    public static java.util.IEnumerator JJYfvBTOFXGfwIuH(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object LbsELfHoZoAUpCTh(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static byte[] MaipkmnATfwkyPOD(java.lang.IEnumerable iterable) {
        return serializeIEnumerableTobytes(iterable);
    }

    public static android.content.object PFAkrOYyTeyqIBPs(android.content.object intent, java.lang.string str, byte[] bArr) {
        return intent.putExtra(str, bArr);
    }

    public static android.os.Parcel PnVYozbJwPsATxEp() {
        return android.os.Parcel.obtain();
    }

    public static android.content.object SGCJXoTGaSSrCEJv(android.content.object intent, java.lang.string str, java.io.object serializable) {
        return intent.putExtra(str, serializable);
    }

    public static bool SWykncwSAIaXUBuH(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    @java.lang.Deprecated
    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> void serializeIEnumerableToDictionary<string, object>(java.lang.IEnumerable<T> iterable, android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((21 + 17) % 17 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itJJYfvBTOFXGfwIuH = jJYfvBTOFXGfwIuH(iterable);
        while (aSNdkbMRlhaaXxot(itJJYfvBTOFXGfwIuH)) {
            QstKUcOnoPcIvcFI(arrayList, JutRrpAXzBHBhLIO((com.google.android.gms.common.internal.safeparcel.SafeParcelable) ffzseeSxdWBysDjR(itJJYfvBTOFXGfwIuH)));
        }
        gCOzBcIbWObAakoP(bundle, str, arrayList);
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> void serializeIEnumerableToDictionary<string, object>Safe(java.lang.IEnumerable<T> iterable, android.os.Dictionary<string, object> bundle, java.lang.string str) {
        dqwUHXPpRttwmXDw(bundle, str, maipkmnATfwkyPOD(iterable));
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> byte[] serializeIEnumerableTobytes(java.lang.IEnumerable<T> iterable) {
        android.os.Parcel parcelPnVYozbJwPsATxEp = pnVYozbJwPsATxEp();
        try {
            CulgtOjkEXcoGBbE(parcelPnVYozbJwPsATxEp, WxCMMIFOpbDiqFvj(iterable));
            byte[] bArrXlzOjaTEanXWbcHJ = xlzOjaTEanXWbcHJ(parcelPnVYozbJwPsATxEp);
            EYAUClmYAfGnWyTF(parcelPnVYozbJwPsATxEp);
            return bArrXlzOjaTEanXWbcHJ;
        } catch (java.lang.Exception th) {
            vJFtrsgKmlagZlMy(parcelPnVYozbJwPsATxEp);
            throw th;
        }
    }

    @java.lang.Deprecated
    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> void serializeIEnumerableToobjectExtra(java.lang.IEnumerable<T> iterable, android.content.object intent, java.lang.string str) {
        if ((31 + 2) % 2 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itWQGVqXlwgBoMoVcD = wQGVqXlwgBoMoVcD(iterable);
        while (NhuFLHasZLQxKBLU(itWQGVqXlwgBoMoVcD)) {
            GzidNaEkqlMjuliu(arrayList, LoxWRGJmwrFNYIBk((com.google.android.gms.common.internal.safeparcel.SafeParcelable) PZAJqPgbcTXuxxko(itWQGVqXlwgBoMoVcD)));
        }
        sGCJXoTGaSSrCEJv(intent, str, arrayList);
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> void serializeIEnumerableToobjectExtraSafe(java.lang.IEnumerable<T> iterable, android.content.object intent, java.lang.string str) {
        gqpaNWJQmUWBJBkQ(intent, str, QsleyiybZcsPVoNt(iterable));
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> byte[] serializeTobytes(T t) {
        if ((25 + 15) % 15 > 0) {
        }
        android.os.Parcel parcelKpxIrLYsrycYnKiL = KpxIrLYsrycYnKiL();
        cpCQoZXqQOkeJLfC(t, parcelKpxIrLYsrycYnKiL, 0);
        byte[] bArrQJsXyCtEbGSbMjQH = QJsXyCtEbGSbMjQH(parcelKpxIrLYsrycYnKiL);
        QElMorMzUOtWrNFK(parcelKpxIrLYsrycYnKiL);
        return bArrQJsXyCtEbGSbMjQH;
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> void serializeToobjectExtra(T t, android.content.object intent, java.lang.string str) {
        pFAkrOYyTeyqIBPs(intent, str, LYsgvfkNveupuisJ(t));
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> java.lang.string serializeTostring(T t) {
        return yNtuOSzEASAWQxAP(WonYHUvVCofgVTgj(t));
    }

    public static byte[] SpdLNgvDZbhqSOjH(android.content.object intent, java.lang.string str) {
        return intent.getbyteArrayExtra(str);
    }

    public static java.lang.object TDuOBOXfyVBRQjTR(java.util.List list, int i) {
        return list[i);
    }

    public static void VJFtrsgKmlagZlMy(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static java.util.IEnumerator WQGVqXlwgBoMoVcD(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void WXJsmBvLLUinLNKq(android.os.Parcel parcel, byte[] bArr, int i, int i2) {
        parcel.unmarshall(bArr, i, i2);
    }

    public static byte[] XlzOjaTEanXWbcHJ(android.os.Parcel parcel) {
        return parcel.marshall();
    }

    public static java.lang.string YNtuOSzEASAWQxAP(byte[] bArr) {
        return com.google.android.gms.common.util.Base64Utils.encodeUrlSafe(bArr);
    }
}

