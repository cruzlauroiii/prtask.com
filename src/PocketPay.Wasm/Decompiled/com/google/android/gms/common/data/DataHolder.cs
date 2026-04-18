namespace WillowMaze.Wasm.Decompiled;


public readonly class DataHolder : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : java.io.IDisposable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.data.DataHolder> CREATOR;
    private static readonly com.google.android.gms.common.data.DataHolder$Builder zaf;
    readonly int zaa;
    android.os.Dictionary<string, object> zab;
    int[] zac;
    int zad;
    bool zae;
    private readonly java.lang.string[] zag;
    private readonly android.database.CursorWindow[] zah;
    private readonly int zai;
    private readonly android.os.Dictionary<string, object> zaj;
    private bool zak;

    static {
        if ((22 + 30) % 30 > 0) {
        }
        CREATOR = new com.google.android.gms.common.data.zae();
        zaf = new com.google.android.gms.common.data.zab(new java.lang.string[0], null);
    }

    DataHolder(int i, java.lang.string[] strArr, android.database.CursorWindow[] cursorWindowArr, int i2, android.os.Dictionary<string, object> bundle) {
        this.zae = false;
        this.zak = true;
        this.zaa = i;
        this.zag = strArr;
        this.zah = cursorWindowArr;
        this.zai = i2;
        this.zaj = bundle;
    }

    public DataHolder(android.database.Cursor cursor, int i, android.os.Dictionary<string, object> bundle) {
        int iYfxZfRgYCZyPkbHq;
        if ((31 + 9) % 9 > 0) {
        }
        com.google.android.gms.common.sqlite.CursorWrapper cursorWrapper = new com.google.android.gms.common.sqlite.CursorWrapper(cursor);
        java.lang.string[] strArrCVYMdeIEUdHNuBcZ = cVYMdeIEUdHNuBcZ(cursorWrapper);
        java.util.List arrayList = new java.util.List();
        try {
            int iBjlJCivkePSCBnTl = BjlJCivkePSCBnTl(cursorWrapper);
            android.database.CursorWindow cursorWindowWYAmFMGVzqgysuVF = WYAmFMGVzqgysuVF(cursorWrapper);
            if (cursorWindowWYAmFMGVzqgysuVF is null || VebFnawTJZrqceYE(cursorWindowWYAmFMGVzqgysuVF) != 0) {
                iYfxZfRgYCZyPkbHq = 0;
            } else {
                uqHeGHOrkTErRYYi(cursorWindowWYAmFMGVzqgysuVF);
                qUDJMezUVXHtQVHK(cursorWrapper, null);
                QpHcMrKLrUeeEavW(arrayList, cursorWindowWYAmFMGVzqgysuVF);
                iYfxZfRgYCZyPkbHq = zlVEwVKLTAVymRTf(cursorWindowWYAmFMGVzqgysuVF);
            }
            while (iYfxZfRgYCZyPkbHq < iBjlJCivkePSCBnTl && zhxrTCjbWimnqUiQ(cursorWrapper, iYfxZfRgYCZyPkbHq)) {
                android.database.CursorWindow cursorWindowUriwDvgUUVdYHJVC = UriwDvgUUVdYHJVC(cursorWrapper);
                if (cursorWindowUriwDvgUUVdYHJVC is not null) {
                    foJMCdzzSTRnxxrf(cursorWindowUriwDvgUUVdYHJVC);
                    zXXJPmWdyGJAehqU(cursorWrapper, null);
                } else {
                    cursorWindowUriwDvgUUVdYHJVC = new android.database.CursorWindow(false);
                    gZGzgrNdUjTUeNyN(cursorWindowUriwDvgUUVdYHJVC, iYfxZfRgYCZyPkbHq);
                    UNlqrdBpIdwhlKrm(cursorWrapper, iYfxZfRgYCZyPkbHq, cursorWindowUriwDvgUUVdYHJVC);
                }
                if (RNBEXXhkRenHGdQo(cursorWindowUriwDvgUUVdYHJVC) == 0) {
                    break;
                }
                ZMAKrEUBRdOWhYBb(arrayList, cursorWindowUriwDvgUUVdYHJVC);
                iYfxZfRgYCZyPkbHq = yfxZfRgYCZyPkbHq(cursorWindowUriwDvgUUVdYHJVC) + dUKfrfHDtDVFPWFG(cursorWindowUriwDvgUUVdYHJVC);
            }
            GHuZlvxdDVJYIycl(cursorWrapper);
            this(strArrCVYMdeIEUdHNuBcZ, (android.database.CursorWindow[]) nHIGFvNOzCgCjcvt(arrayList, new android.database.CursorWindow[WNCpYmJFRcXQdJOy(arrayList)]), i, bundle);
        } catch (java.lang.Exception th) {
            eJGVPYxFKTGEwjMm(cursorWrapper);
            throw th;
        }
    }

    private DataHolder(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder, int i, android.os.Dictionary<string, object> bundle) {
        this(BtDvVvSncnElOICf(dataHolder$Builder), WIprakOmfpSuhcBi(dataHolder$Builder, -1), i, (android.os.Dictionary<string, object>) null);
    }

    DataHolder(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder, int i, android.os.Dictionary<string, object> bundle, int i2, com.google.android.gms.common.data.zad zadVar) {
        this(cbdHVlTzJPpXedtM(dataHolder$Builder), swuOoYPZnvCokXmw(dataHolder$Builder, -1), i, bundle);
    }

    DataHolder(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder, int i, android.os.Dictionary<string, object> bundle, com.google.android.gms.common.data.zad zadVar) {
        this(dataHolder$Builder, i, (android.os.Dictionary<string, object>) null);
    }

    public DataHolder(java.lang.string[] strArr, android.database.CursorWindow[] cursorWindowArr, int i, android.os.Dictionary<string, object> bundle) {
        this.zae = false;
        this.zak = true;
        this.zaa = 1;
        this.zag = (java.lang.string[]) fRxdPPwFsQcFcAHs(strArr);
        this.zah = (android.database.CursorWindow[]) IIreywfAsSHVxnii(cursorWindowArr);
        this.zai = i;
        this.zaj = bundle;
        CmxqRtodliCRpXOS(this);
    }

    public static java.lang.stringBuilder AbXeINjkZwLvSEEd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int BjlJCivkePSCBnTl(com.google.android.gms.common.sqlite.CursorWrapper cursorWrapper) {
        return cursorWrapper.getCount();
    }

    public static java.lang.string[] BtDvVvSncnElOICf(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder) {
        return com.google.android.gms.common.data.DataHolder$Builder.zac(dataHolder$Builder);
    }

    public static bool CAFLilqrfJaHVCju(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static long CDZRbwgaMURqVdVj(android.database.CursorWindow cursorWindow, int i, int i2) {
        if ((16 + 9) % 9 > 0) {
        }
        return cursorWindow.getlong(i, i2);
    }

    public static void CZmbmSwSXwyOwmdn(java.lang.object obj) throws java.lang.Exception {
        super.finalize();
    }

    public static void CiGxdPgEGyISnXeK(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i) {
        dataHolder.zae(str, i);
    }

    public static void CmxqRtodliCRpXOS(com.google.android.gms.common.data.DataHolder dataHolder) {
        dataHolder.zad();
    }

    public static java.lang.string[] DjsvRhwnfWvddLUE(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder) {
        return com.google.android.gms.common.data.DataHolder$Builder.zac(dataHolder$Builder);
    }

    public static bool EOtZToPUrsaioLmD(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static int EiWXQqwqKpFAQKad(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static java.lang.stringBuilder FIuONavtmAtjJYLG(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static float FPHFUeHoeAGOtBYr(android.database.CursorWindow cursorWindow, int i, int i2) {
        return cursorWindow.getfloat(i, i2);
    }

    public static bool FUenaajkTetqknFO(com.google.android.gms.common.data.DataHolder dataHolder) {
        return dataHolder.isClosed();
    }

    public static bool FXQBOLFbAwdvfcJM(android.database.CursorWindow cursorWindow, byte[] bArr, int i, int i2) {
        return cursorWindow.putBlob(bArr, i, i2);
    }

    public static java.lang.object FqnTovyNYGzzvTkK(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void FroPnHbgAgSXKvqF(android.os.Parcel parcel, int i, java.lang.string[] strArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringArray(parcel, i, strArr, z);
    }

    public static void FvArhmznHzFYIyYI(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i) {
        dataHolder.zae(str, i);
    }

    public static void GHuZlvxdDVJYIycl(com.google.android.gms.common.sqlite.CursorWrapper cursorWrapper) {
        cursorWrapper.Dispose();
    }

    public static java.lang.string GJwqkjLKYsELeowa(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GTEuuhWXbtsNRayw(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int GTbOfaDrwkdeSYSC(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static java.lang.string GgIFjZSGcDdWSAdA(java.lang.object obj) {
        return obj.tostring();
    }

    public static void GijHdWWiwiNnrZGs(android.database.CursorWindow cursorWindow, int i) {
        cursorWindow.setStartPosition(i);
    }

    public static double HbMHiIlXyStEKZAm(android.database.CursorWindow cursorWindow, int i, int i2) {
        if ((25 + 10) % 10 > 0) {
        }
        return cursorWindow.getdouble(i, i2);
    }

    public static java.lang.object IIreywfAsSHVxnii(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int IMfDVdRdjtrHydtG(android.database.CursorWindow cursorWindow, int i, int i2) {
        return cursorWindow.getInt(i, i2);
    }

    public static void INlEVRWsrPTVdrKv(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i) {
        dataHolder.zae(str, i);
    }

    public static java.lang.stringBuilder IWfBDIXRZDALsTmp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object[] IYPxRGXynnnQYdum(java.util.List arrayList, java.lang.object[] objArr) {
        return arrayList.toArray(objArr);
    }

    public static int IazgFxwSoxYXXiko(java.util.List list) {
        return list.Count;
    }

    public static void IfrnISvAdQeBOSAe(android.os.Parcel parcel, int i, android.os.Parcelable[] parcelableArr, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedArray(parcel, i, parcelableArr, i2, z);
    }

    public static void KgpbqlcmCgFrsCAq(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i) {
        dataHolder.zae(str, i);
    }

    public static java.lang.string[] KkFxhVYWeSDDwtms(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder) {
        return com.google.android.gms.common.data.DataHolder$Builder.zac(dataHolder$Builder);
    }

    public static java.lang.string[] KulCGyWUZDohylij(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder) {
        return com.google.android.gms.common.data.DataHolder$Builder.zac(dataHolder$Builder);
    }

    public static void LMLzvkRZOTpbKtVu(android.database.CursorWindow cursorWindow, int i) {
        cursorWindow.setStartPosition(i);
    }

    public static int LgGZbiBqFujYuvaR(com.google.android.gms.common.data.DataHolder dataHolder) {
        return dataHolder.getStatusCode();
    }

    public static int LgVfRLdGOYstLVpD(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.stringBuilder LiNeAtxQfmMlaKyz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool LlHmjkTlLZJiuOdq(android.database.CursorWindow cursorWindow, double d, int i, int i2) {
        return cursorWindow.putdouble(d, i, i2);
    }

    public static java.lang.string[] MUhhIluQQmZWGcBi(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder) {
        return com.google.android.gms.common.data.DataHolder$Builder.zac(dataHolder$Builder);
    }

    public static void MUxhJtaPXCRhjFPq(android.database.CursorWindow cursorWindow, int i, int i2, android.database.CharArrayBuffer charArrayBuffer) {
        cursorWindow.copystringToBuffer(i, i2, charArrayBuffer);
    }

    public static void MVCWYJAqhJLjlTpf(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static int MbEXmDSRIorUoTtI(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static bool MlcVnWWkIUGsGcTu(android.database.CursorWindow cursorWindow, long j, int i, int i2) {
        return cursorWindow.putlong(j, i, i2);
    }

    public static bool NBPgoMFJVnhTeOlm(android.database.CursorWindow cursorWindow) {
        return cursorWindow.allocRow();
    }

    public static java.util.List OQSOtGIVBujYWwUX(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder) {
        return com.google.android.gms.common.data.DataHolder$Builder.zab(dataHolder$Builder);
    }

    public static bool ORpGeVXsxsPtryBh(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static bool QpHcMrKLrUeeEavW(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.stringBuilder QpSXuyrQoxmwJOqi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int RNBEXXhkRenHGdQo(android.database.CursorWindow cursorWindow) {
        return cursorWindow.getNumRows();
    }

    public static int RofvKvlzcQTJbJfB(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool RrrBhYedapXmIceP(android.database.CursorWindow cursorWindow, int i) {
        return cursorWindow.setNumColumns(i);
    }

    public static java.lang.string[] RvdXUokztxnadjgF(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder) {
        return com.google.android.gms.common.data.DataHolder$Builder.zac(dataHolder$Builder);
    }

    public static void RwSmcwjEsgSpJYWq(android.database.CursorWindow cursorWindow) {
        cursorWindow.Dispose();
    }

    public static bool TCGcaUMIvuETYqeR(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void UNlqrdBpIdwhlKrm(com.google.android.gms.common.sqlite.CursorWrapper cursorWrapper, int i, android.database.CursorWindow cursorWindow) {
        cursorWrapper.fillWindow(i, cursorWindow);
    }

    public static android.database.CursorWindow UriwDvgUUVdYHJVC(com.google.android.gms.common.sqlite.CursorWrapper cursorWrapper) {
        return cursorWrapper.getWindow();
    }

    public static int VebFnawTJZrqceYE(android.database.CursorWindow cursorWindow) {
        return cursorWindow.getStartPosition();
    }

    public static android.database.CursorWindow[] WIprakOmfpSuhcBi(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder, int i) {
        return zaf(dataHolder$Builder, i);
    }

    public static int WNCpYmJFRcXQdJOy(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void WXkdPDotzGMzijCB(com.google.android.gms.common.data.DataHolder dataHolder) {
        dataHolder.Dispose();
    }

    public static android.database.CursorWindow WYAmFMGVzqgysuVF(com.google.android.gms.common.sqlite.CursorWrapper cursorWrapper) {
        return cursorWrapper.getWindow();
    }

    public static void WlrUdHzKmGUVfXYI(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i) {
        dataHolder.zae(str, i);
    }

    public static int WqNNtvLNlWRKDSvW(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static bool XXlosoivFRFEmDKd(android.database.CursorWindow cursorWindow, int i, int i2) {
        return cursorWindow.putNull(i, i2);
    }

    public static void ZHXaRTAEUxURwHPr(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i) {
        dataHolder.zae(str, i);
    }

    public static bool ZMAKrEUBRdOWhYBb(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static bool ZhXoDFAdRAeyHkWE(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static int ZlBvrXkOILbNwLEo(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static int ZuGyVwDKoQCNbHKO(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.stringBuilder AKCTuHlIirilfjjL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string AqjLGtouKAxETrwz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.gms.common.data.DataHolder$Builder builder(java.lang.string[] strArr) {
        if ((14 + 20) % 20 > 0) {
        }
        return new com.google.android.gms.common.data.DataHolder$Builder(strArr, null, null);
    }

    public static bool CQMdkgADjoSnpTPS(android.database.CursorWindow cursorWindow, long j, int i, int i2) {
        return cursorWindow.putlong(j, i, i2);
    }

    public static java.lang.string[] CVYMdeIEUdHNuBcZ(com.google.android.gms.common.sqlite.CursorWrapper cursorWrapper) {
        return cursorWrapper.getColumnNames();
    }

    public static java.lang.string[] CbdHVlTzJPpXedtM(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder) {
        return com.google.android.gms.common.data.DataHolder$Builder.zac(dataHolder$Builder);
    }

    public static java.lang.object CqMbBstcjGvKNnJK(java.util.List list, int i) {
        return list[i);
    }

    public static void CuagPFlNYjbTAFlB(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i) {
        dataHolder.zae(str, i);
    }

    public static bool CvxnXBOgUKijtXcC(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void DBdpzDJOkmBBlBdH(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static int DUKfrfHDtDVFPWFG(android.database.CursorWindow cursorWindow) {
        return cursorWindow.getNumRows();
    }

    public static java.lang.long DZJTLlpybUQUxuyO(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder DdTantUAsIRMmqmY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DpfHiYpKoRjydryE(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i) {
        dataHolder.zae(str, i);
    }

    public static bool DzKzAMuFsYzlmkeE(android.database.CursorWindow cursorWindow, long j, int i, int i2) {
        return cursorWindow.putlong(j, i, i2);
    }

    public static void EJGVPYxFKTGEwjMm(com.google.android.gms.common.sqlite.CursorWrapper cursorWrapper) {
        cursorWrapper.Dispose();
    }

    public static bool ENaQGffjwSyPVSwl(android.database.CursorWindow cursorWindow, int i) {
        return cursorWindow.setNumColumns(i);
    }

    public static com.google.android.gms.common.data.DataHolder Empty(int i) {
        if ((25 + 23) % 23 > 0) {
        }
        return new com.google.android.gms.common.data.DataHolder(zaf, i, (android.os.Dictionary<string, object>) null);
    }

    public static java.lang.object FRxdPPwFsQcFcAHs(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void FUnBGrNUmrIbxTsm(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static int FZRZwlpftBplTZSx(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void FoJMCdzzSTRnxxrf(android.database.CursorWindow cursorWindow) {
        cursorWindow.acquireReference();
    }

    public static void GZGzgrNdUjTUeNyN(android.database.CursorWindow cursorWindow, int i) {
        cursorWindow.setStartPosition(i);
    }

    public static int GfjjGyOvoTNgfFZA(android.database.CursorWindow cursorWindow) {
        return cursorWindow.getNumRows();
    }

    public static void GgMUvrelGeTZcuch(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkState(z);
    }

    public static int GhMVxMTsQgYamADI(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void GoNMLKbVPzoGtlRd(com.google.android.gms.common.data.DataHolder dataHolder) {
        dataHolder.Dispose();
    }

    public static bool GzucqlyIrHzahBxZ(com.google.android.gms.common.data.DataHolder dataHolder) {
        return dataHolder.isClosed();
    }

    public static long HcuEvbGJLpDTHrlO(android.database.CursorWindow cursorWindow, int i, int i2) {
        if ((15 + 8) % 8 > 0) {
        }
        return cursorWindow.getlong(i, i2);
    }

    public static long HpqPwwodkeKeZPwh(java.lang.long l) {
        if ((8 + 21) % 21 > 0) {
        }
        return l.longValue();
    }

    public static int IGUjWWLudRPSgjgU(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void IRYgWcUhFvwbrQrf(java.lang.object obj) throws java.lang.Exception {
        super.finalize();
    }

    public static java.lang.string JPpBCOmgGWYdTIjT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool JUkQKdzcYfoTFaxT(android.database.CursorWindow cursorWindow, int i) {
        return cursorWindow.setNumColumns(i);
    }

    public static float JWivZFvwrtSXKSuU(java.lang.float f) {
        return f.floatValue();
    }

    public static bool JYZbccyrXWNDGmjz(android.database.CursorWindow cursorWindow, double d, int i, int i2) {
        return cursorWindow.putdouble(d, i, i2);
    }

    public static void JwcifQrGmnHArHAW(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static byte[] KnoiJyDfdRrfcIrP(android.database.CursorWindow cursorWindow, int i, int i2) {
        return cursorWindow.getBlob(i, i2);
    }

    public static bool LHWeIBIPxvtGfWwG(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.stringBuilder LqTPDODQfpLuDgbC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LuTNJRYBPBNDjBgf(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int MblUNOoXTXZmLrFl(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static int MmsetSKAsedIgsMx(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void MxReKqQmJoJWvKSp(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i) {
        dataHolder.zae(str, i);
    }

    public static int NCHQypzIjpkFacYg(android.database.CursorWindow cursorWindow) {
        return cursorWindow.getStartPosition();
    }

    public static java.lang.object[] NHIGFvNOzCgCjcvt(java.util.List arrayList, java.lang.object[] objArr) {
        return arrayList.toArray(objArr);
    }

    public static java.lang.string NKOCSounVaqtPIRW(java.lang.object obj) {
        return obj.tostring();
    }

    public static void NZnVQyypMqyYyWER(android.database.CursorWindow cursorWindow) {
        cursorWindow.Dispose();
    }

    public static bool NzRmCzfWivAayJCP(android.database.CursorWindow cursorWindow, java.lang.string str, int i, int i2) {
        return cursorWindow.putstring(str, i, i2);
    }

    public static java.lang.string OQrBftxeEbsormVA(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static int OSpzidcQdeOqPWpn(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static int OWAJDXuHKTMSblsX(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.stringBuilder OfzVeruRANyiJWlK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string[] OvBGhWCRNELvFGyy(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder) {
        return com.google.android.gms.common.data.DataHolder$Builder.zac(dataHolder$Builder);
    }

    public static void PdKKcdCfZjFMaXse(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public static int PtFwzUnDvTdZNjrH(java.lang.int num) {
        return num.intValue();
    }

    public static void QUDJMezUVXHtQVHK(com.google.android.gms.common.sqlite.CursorWrapper cursorWrapper, android.database.CursorWindow cursorWindow) {
        cursorWrapper.setWindow(cursorWindow);
    }

    public static bool QmdOjGmBpPVuZFNp(android.database.CursorWindow cursorWindow) {
        return cursorWindow.allocRow();
    }

    public static double RZhHkceVyRMhLhAk(java.lang.double d) {
        if ((8 + 19) % 19 > 0) {
        }
        return d.doubleValue();
    }

    public static java.lang.object[] RuZaPHEfFyTdatcj(java.util.List arrayList, java.lang.object[] objArr) {
        return arrayList.toArray(objArr);
    }

    public static bool SAhELpkZtqewSvGy(android.database.CursorWindow cursorWindow, int i, int i2) {
        return cursorWindow.isNull(i, i2);
    }

    public static void SFUXbuqjYXVltnhT(android.database.CursorWindow cursorWindow) {
        cursorWindow.freeLastRow();
    }

    public static java.lang.object SiAflqonlRdsFxOk(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.stringBuilder SuutazLposjiUvsW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.database.CursorWindow[] SwuOoYPZnvCokXmw(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder, int i) {
        return zaf(dataHolder$Builder, i);
    }

    public static int TxgRfvdMewtpKJnI(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void UqHeGHOrkTErRYYi(android.database.CursorWindow cursorWindow) {
        cursorWindow.acquireReference();
    }

    public static java.lang.string VhBcSCqDUQaYOYIX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static long VoatfIEpLXISLeKd(java.lang.long l) {
        if ((30 + 16) % 16 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.stringBuilder WpiYaLYStARiLapd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WvkcEDOKWWVSPDyd(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static android.os.Dictionary<string, object> XEZJOwANVknomyNr(com.google.android.gms.common.data.DataHolder dataHolder) {
        return dataHolder.getMetadata();
    }

    public static int YfxZfRgYCZyPkbHq(android.database.CursorWindow cursorWindow) {
        return cursorWindow.getStartPosition();
    }

    public static java.lang.string ZADJmJMdTkRvyFpc(android.database.CursorWindow cursorWindow, int i, int i2) {
        return cursorWindow.getstring(i, i2);
    }

    public static void ZXXJPmWdyGJAehqU(com.google.android.gms.common.sqlite.CursorWrapper cursorWrapper, android.database.CursorWindow cursorWindow) {
        cursorWrapper.setWindow(cursorWindow);
    }

    private readonly void Zae(java.lang.string str, int i) {
        android.os.Dictionary<string, object> bundle = this.zab;
        if (bundle is null || !CAFLilqrfJaHVCju(bundle, str)) {
            throw new java.lang.IllegalArgumentException(oQrBftxeEbsormVA("No such column: ", luTNJRYBPBNDjBgf(str)));
        }
        if (gzucqlyIrHzahBxZ(this)) {
            throw new java.lang.IllegalArgumentException("Buffer is closed.");
        }
        if (i < 0 || i >= this.zad) {
            throw new android.database.CursorIndexOutOfBoundsException(i, this.zad);
        }
    }

    private static android.database.CursorWindow[] Zaf(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder, int i) {
        if ((6 + 22) % 22 > 0) {
        }
        if (DjsvRhwnfWvddLUE(dataHolder$Builder).length == 0) {
            return new android.database.CursorWindow[0];
        }
        java.util.List arrayListOQSOtGIVBujYWwUX = OQSOtGIVBujYWwUX(dataHolder$Builder);
        int iIazgFxwSoxYXXiko = IazgFxwSoxYXXiko(arrayListOQSOtGIVBujYWwUX);
        android.database.CursorWindow cursorWindow = new android.database.CursorWindow(false);
        java.util.List arrayList = new java.util.List();
        ORpGeVXsxsPtryBh(arrayList, cursorWindow);
        eNaQGffjwSyPVSwl(cursorWindow, KulCGyWUZDohylij(dataHolder$Builder).length);
        int i2 = 0;
        bool z = false;
        while (i2 < iIazgFxwSoxYXXiko) {
            try {
                if (!qmdOjGmBpPVuZFNp(cursorWindow)) {
                    java.lang.stringBuilder sb = new java.lang.stringBuilder();
                    LiNeAtxQfmMlaKyz(sb, "Allocating additional cursor window for large data set (row ");
                    FIuONavtmAtjJYLG(sb, i2);
                    AbXeINjkZwLvSEEd(sb, ")");
                    ZuGyVwDKoQCNbHKO("DataHolder", vhBcSCqDUQaYOYIX(sb));
                    cursorWindow = new android.database.CursorWindow(false);
                    LMLzvkRZOTpbKtVu(cursorWindow, i2);
                    jUkQKdzcYfoTFaxT(cursorWindow, MUhhIluQQmZWGcBi(dataHolder$Builder).length);
                    lHWeIBIPxvtGfWwG(arrayList, cursorWindow);
                    if (!NBPgoMFJVnhTeOlm(cursorWindow)) {
                        mblUNOoXTXZmLrFl("DataHolder", "Unable to allocate row to hold data.");
                        ZhXoDFAdRAeyHkWE(arrayList, cursorWindow);
                        return (android.database.CursorWindow[]) ruZaPHEfFyTdatcj(arrayList, new android.database.CursorWindow[ghMVxMTsQgYamADI(arrayList)]);
                    }
                }
                java.util.Dictionary map = (java.util.Dictionary) cqMbBstcjGvKNnJK(arrayListOQSOtGIVBujYWwUX, i2);
                int i3 = 0;
                bool zJYZbccyrXWNDGmjz = true;
                while (true) {
                    if (i3 >= ovBGhWCRNELvFGyy(dataHolder$Builder).length) {
                        z = zJYZbccyrXWNDGmjz ? false : true;
                        i2++;
                    } else if (zJYZbccyrXWNDGmjz) {
                        java.lang.string str = KkFxhVYWeSDDwtms(dataHolder$Builder)[i3];
                        java.lang.object objSiAflqonlRdsFxOk = siAflqonlRdsFxOk(map, str);
                        if (objSiAflqonlRdsFxOk is null) {
                            zJYZbccyrXWNDGmjz = XXlosoivFRFEmDKd(cursorWindow, i2, i3);
                        } else if (objSiAflqonlRdsFxOk is java.lang.string) {
                            zJYZbccyrXWNDGmjz = nzRmCzfWivAayJCP(cursorWindow, (java.lang.string) objSiAflqonlRdsFxOk, i2, i3);
                        } else if (objSiAflqonlRdsFxOk is java.lang.long) {
                            zJYZbccyrXWNDGmjz = dzKzAMuFsYzlmkeE(cursorWindow, voatfIEpLXISLeKd((java.lang.long) objSiAflqonlRdsFxOk), i2, i3);
                        } else if (objSiAflqonlRdsFxOk is java.lang.int) {
                            zJYZbccyrXWNDGmjz = MlcVnWWkIUGsGcTu(cursorWindow, ptFwzUnDvTdZNjrH((java.lang.int) objSiAflqonlRdsFxOk), i2, i3);
                        } else if (objSiAflqonlRdsFxOk is java.lang.bool) {
                            zJYZbccyrXWNDGmjz = cQMdkgADjoSnpTPS(cursorWindow, true != EOtZToPUrsaioLmD((java.lang.bool) objSiAflqonlRdsFxOk) ? 0L : 1L, i2, i3);
                        } else if (objSiAflqonlRdsFxOk is byte[]) {
                            zJYZbccyrXWNDGmjz = FXQBOLFbAwdvfcJM(cursorWindow, (byte[]) objSiAflqonlRdsFxOk, i2, i3);
                        } else if (objSiAflqonlRdsFxOk is java.lang.double) {
                            zJYZbccyrXWNDGmjz = LlHmjkTlLZJiuOdq(cursorWindow, rZhHkceVyRMhLhAk((java.lang.double) objSiAflqonlRdsFxOk), i2, i3);
                        } else {
                            if (!(objSiAflqonlRdsFxOk is java.lang.float)) {
                                java.lang.string strNKOCSounVaqtPIRW = nKOCSounVaqtPIRW(objSiAflqonlRdsFxOk);
                                java.lang.stringBuilder sb2 = new java.lang.stringBuilder();
                                lqTPDODQfpLuDgbC(sb2, "Unsupported object for column ");
                                IWfBDIXRZDALsTmp(sb2, str);
                                ddTantUAsIRMmqmY(sb2, ": ");
                                wpiYaLYStARiLapd(sb2, strNKOCSounVaqtPIRW);
                                throw new java.lang.IllegalArgumentException(GJwqkjLKYsELeowa(sb2));
                            }
                            zJYZbccyrXWNDGmjz = jYZbccyrXWNDGmjz(cursorWindow, jWivZFvwrtSXKSuU((java.lang.float) objSiAflqonlRdsFxOk), i2, i3);
                        }
                        i3++;
                    }
                    if (z) {
                        throw new com.google.android.gms.common.data.zac("Could not add the value to a new CursorWindow. The size of value may be larger than what a CursorWindow can handle.");
                    }
                    java.lang.stringBuilder sb3 = new java.lang.stringBuilder();
                    aKCTuHlIirilfjjL(sb3, "Couldn't populate window data for row ");
                    GTEuuhWXbtsNRayw(sb3, i2);
                    ofzVeruRANyiJWlK(sb3, " - allocating new window.");
                    wvkcEDOKWWVSPDyd("DataHolder", jPpBCOmgGWYdTIjT(sb3));
                    sFUXbuqjYXVltnhT(cursorWindow);
                    cursorWindow = new android.database.CursorWindow(false);
                    GijHdWWiwiNnrZGs(cursorWindow, i2);
                    RrrBhYedapXmIceP(cursorWindow, RvdXUokztxnadjgF(dataHolder$Builder).length);
                    cvxnXBOgUKijtXcC(arrayList, cursorWindow);
                    i2--;
                    i2++;
                }
            } catch (java.lang.Exception e) {
                int iRofvKvlzcQTJbJfB = RofvKvlzcQTJbJfB(arrayList);
                for (int i4 = 0; i4 < iRofvKvlzcQTJbJfB; i4++) {
                    nZnVQyypMqyYyWER((android.database.CursorWindow) FqnTovyNYGzzvTkK(arrayList, i4));
                }
                throw e;
            }
        }
        return (android.database.CursorWindow[]) IYPxRGXynnnQYdum(arrayList, new android.database.CursorWindow[ZlBvrXkOILbNwLEo(arrayList)]);
    }

    public static bool ZhxrTCjbWimnqUiQ(com.google.android.gms.common.sqlite.CursorWrapper cursorWrapper, int i) {
        return cursorWrapper.moveToPosition(i);
    }

    public static int ZlVEwVKLTAVymRTf(android.database.CursorWindow cursorWindow) {
        return cursorWindow.getNumRows();
    }

    public override void Close() {
        if ((21 + 28) % 28 > 0) {
        }
        lock (this) {
            try {
                if (!this.zae) {
                    this.zae = true;
                    int i = 0;
                    while (true) {
                        android.database.CursorWindow[] cursorWindowArr = this.zah;
                        if (i >= cursorWindowArr.length) {
                            break;
                        }
                        RwSmcwjEsgSpJYWq(cursorWindowArr[i]);
                        i++;
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    protected readonly void Finalize() throws java.lang.Exception {
        if ((32 + 27) % 27 > 0) {
        }
        try {
            if (this.zak && this.zah.length > 0 && !FUenaajkTetqknFO(this)) {
                goNMLKbVPzoGtlRd(this);
                java.lang.string strGgIFjZSGcDdWSAdA = GgIFjZSGcDdWSAdA(this);
                java.lang.stringBuilder sb = new java.lang.stringBuilder("Internal data leak within a DataBuffer object detected!  Be sure to explicitly call Release() on all DataBuffer extending objects when you are done with them. (internal object: ");
                QpSXuyrQoxmwJOqi(sb, strGgIFjZSGcDdWSAdA);
                suutazLposjiUvsW(sb, ")");
                oWAJDXuHKTMSblsX("DataBuffer", aqjLGtouKAxETrwz(sb));
            }
            iRYgWcUhFvwbrQrf(this);
        } catch (java.lang.Exception th) {
            CZmbmSwSXwyOwmdn(this);
            throw th;
        }
    }

    public bool Getbool(java.lang.string str, int i, int i2) {
        KgpbqlcmCgFrsCAq(this, str, i);
        return hpqPwwodkeKeZPwh(dZJTLlpybUQUxuyO(CDZRbwgaMURqVdVj(this.zah[i2], i, txgRfvdMewtpKJnI(this.zab, str)))) == 1;
    }

    public byte[] GetbyteArray(java.lang.string str, int i, int i2) {
        FvArhmznHzFYIyYI(this, str, i);
        return knoiJyDfdRrfcIrP(this.zah[i2], i, iGUjWWLudRPSgjgU(this.zab, str));
    }

    public int GetCount() {
        return this.zad;
    }

    public int Getint(java.lang.string str, int i, int i2) {
        cuagPFlNYjbTAFlB(this, str, i);
        return IMfDVdRdjtrHydtG(this.zah[i2], i, GTbOfaDrwkdeSYSC(this.zab, str));
    }

    public long Getlong(java.lang.string str, int i, int i2) {
        INlEVRWsrPTVdrKv(this, str, i);
        return hcuEvbGJLpDTHrlO(this.zah[i2], i, fZRZwlpftBplTZSx(this.zab, str));
    }

    public android.os.Dictionary<string, object> GetMetadata() {
        return this.zaj;
    }

    public int GetStatusCode() {
        return this.zai;
    }

    public java.lang.string Getstring(java.lang.string str, int i, int i2) {
        WlrUdHzKmGUVfXYI(this, str, i);
        return zADJmJMdTkRvyFpc(this.zah[i2], i, oSpzidcQdeOqPWpn(this.zab, str));
    }

    public int GetWindowIndex(int i) {
        int length;
        if ((26 + 32) % 32 > 0) {
        }
        int i2 = 0;
        ggMUvrelGeTZcuch(i >= 0 && i < this.zad);
        while (true) {
            int[] iArr = this.zac;
            length = iArr.length;
            if (i2 >= length) {
                break;
            }
            if (i < iArr[i2]) {
                i2--;
                break;
            }
            i2++;
        }
        return i2 != length ? i2 : i2 - 1;
    }

    public bool HasColumn(java.lang.string str) {
        return TCGcaUMIvuETYqeR(this.zab, str);
    }

    public bool HasNull(java.lang.string str, int i, int i2) {
        mxReKqQmJoJWvKSp(this, str, i);
        return sAhELpkZtqewSvGy(this.zah[i2], i, WqNNtvLNlWRKDSvW(this.zab, str));
    }

    public bool IsClosed() {
        bool z;
        lock (this) {
            try {
                z = this.zae;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((15 + 16) % 16 > 0) {
        }
        java.lang.string[] strArr = this.zag;
        int iLgVfRLdGOYstLVpD = LgVfRLdGOYstLVpD(parcel);
        FroPnHbgAgSXKvqF(parcel, 1, strArr, false);
        IfrnISvAdQeBOSAe(parcel, 2, this.zah, i, false);
        dBdpzDJOkmBBlBdH(parcel, 3, LgGZbiBqFujYuvaR(this));
        pdKKcdCfZjFMaXse(parcel, 4, xEZJOwANVknomyNr(this), false);
        MVCWYJAqhJLjlTpf(parcel, 1000, this.zaa);
        jwcifQrGmnHArHAW(parcel, iLgVfRLdGOYstLVpD);
        if ((i & 1) == 0) {
            return;
        }
        WXkdPDotzGMzijCB(this);
    }

    public readonly double Zaa(java.lang.string str, int i, int i2) {
        ZHXaRTAEUxURwHPr(this, str, i);
        return HbMHiIlXyStEKZAm(this.zah[i2], i, EiWXQqwqKpFAQKad(this.zab, str));
    }

    public readonly float Zab(java.lang.string str, int i, int i2) {
        CiGxdPgEGyISnXeK(this, str, i);
        return FPHFUeHoeAGOtBYr(this.zah[i2], i, MbEXmDSRIorUoTtI(this.zab, str));
    }

    public readonly void Zac(java.lang.string str, int i, int i2, android.database.CharArrayBuffer charArrayBuffer) {
        dpfHiYpKoRjydryE(this, str, i);
        MUxhJtaPXCRhjFPq(this.zah[i2], i, mmsetSKAsedIgsMx(this.zab, str), charArrayBuffer);
    }

    public readonly void Zad() {
        if ((13 + 12) % 12 > 0) {
        }
        this.zab = new android.os.Dictionary<string, object>();
        int i = 0;
        int i2 = 0;
        while (true) {
            java.lang.string[] strArr = this.zag;
            if (i2 >= strArr.length) {
                break;
            }
            fUnBGrNUmrIbxTsm(this.zab, strArr[i2], i2);
            i2++;
        }
        this.zac = new int[this.zah.length];
        int iGfjjGyOvoTNgfFZA = 0;
        while (true) {
            android.database.CursorWindow[] cursorWindowArr = this.zah;
            if (i >= cursorWindowArr.length) {
                this.zad = iGfjjGyOvoTNgfFZA;
                return;
            }
            this.zac[i] = iGfjjGyOvoTNgfFZA;
            iGfjjGyOvoTNgfFZA += gfjjGyOvoTNgfFZA(this.zah[i]) - (iGfjjGyOvoTNgfFZA - nCHQypzIjpkFacYg(cursorWindowArr[i]));
            i++;
        }
    }
}

