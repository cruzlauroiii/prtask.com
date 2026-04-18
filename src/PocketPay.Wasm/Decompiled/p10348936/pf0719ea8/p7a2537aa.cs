namespace WillowMaze.Wasm.Decompiled;


public readonly class p7a2537aa : p10348936.pf0719ea8.p4447a398 {
    private readonly androidx.room.SharedSQLiteStatement f00f78f9c;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f0c890f8c;
    private readonly androidx.room.EntityInsertionAdapter f2969798c;
    private readonly androidx.room.SharedSQLiteStatement f2b03bc5d;
    private readonly androidx.room.SharedSQLiteStatement f2b38790a;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 f2fe89a7f;
    private readonly androidx.room.SharedSQLiteStatement f3392e244;
    private readonly androidx.room.SharedSQLiteStatement f4b9ef68a;
    private readonly androidx.room.SharedSQLiteStatement f4c800510;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 f4ed728c4;
    private readonly androidx.room.EntityInsertionAdapter<p10348936.pf5e638cc.pd77d5e50.p4582d01f> f51d05837;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 f5c5ccaed;
    private readonly androidx.room.SharedSQLiteStatement f5fbd7c5c;
    private readonly androidx.room.SharedSQLiteStatement f6c923a1d;
    private readonly androidx.room.EntityInsertionAdapter f72690c6a;
    private readonly androidx.room.SharedSQLiteStatement f750b29e6;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f75212725;
    private readonly androidx.room.EntityInsertionAdapter<p10348936.pf5e638cc.pd77d5e50.p12e406c7> f7860905a;
    private readonly androidx.room.EntityInsertionAdapter f78a6dace;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter<p10348936.pf5e638cc.pd77d5e50.p0ed7807b> f7c3af5a1;
    private readonly androidx.room.SharedSQLiteStatement f7f62fd99;
    private readonly androidx.room.SharedSQLiteStatement f855f23db;
    private readonly androidx.room.SharedSQLiteStatement f864fd09b;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 f89a8a4ce;
    private readonly androidx.room.EntityInsertionAdapter<p10348936.pf5e638cc.pd77d5e50.p0ed7807b> f89c4256c;
    private readonly androidx.room.SharedSQLiteStatement f8bd7da14;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 f8d3a9439;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 f94b5db6a;
    private readonly androidx.room.EntityInsertionAdapter<p10348936.pf5e638cc.pd77d5e50.p555020e1> f95362d42;
    private readonly androidx.room.RoomDatabase fa8bf39ac;
    private readonly androidx.room.SharedSQLiteStatement fade50827;
    private readonly androidx.room.EntityInsertionAdapter fb5749873;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 fbafbb476;
    private readonly androidx.room.EntityInsertionAdapter fc2c98397;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 fc4bb457a;
    private readonly androidx.room.RoomDatabase fcaf1eed5;
    private readonly androidx.room.SharedSQLiteStatement fd0ec25f0;
    private readonly androidx.room.SharedSQLiteStatement fe0337741;
    private readonly androidx.room.EntityInsertionAdapter fe5471c4b;
    private readonly androidx.room.EntityInsertionAdapter ff3b0e3d9;
    private readonly androidx.room.RoomDatabase ffbf3fbf2;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 fb8317a4c = new p8d777f38.pd77d5e50.p2b3583e6.p297c1c27();
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 fa92cb57a = new p8d777f38.pd77d5e50.p2b3583e6.p35667ee1();

    public p7a2537aa(androidx.room.RoomDatabase roomDatabase) {
        this.fa8bf39ac = roomDatabase;
        this.f51d05837 = new p10348936.pf0719ea8.p7a2537aa$1(this, roomDatabase);
        this.f95362d42 = new p10348936.pf0719ea8.p7a2537aa$2(this, roomDatabase);
        this.f7860905a = new p10348936.pf0719ea8.p7a2537aa$3(this, roomDatabase);
        this.f89c4256c = new p10348936.pf0719ea8.p7a2537aa$4(this, roomDatabase);
        this.f7c3af5a1 = new p10348936.pf0719ea8.p7a2537aa$5(this, roomDatabase);
        this.fe0337741 = new p10348936.pf0719ea8.p7a2537aa$6(this, roomDatabase);
        this.f4c800510 = new p10348936.pf0719ea8.p7a2537aa$7(this, roomDatabase);
        this.f3392e244 = new p10348936.pf0719ea8.p7a2537aa$8(this, roomDatabase);
        this.fade50827 = new p10348936.pf0719ea8.p7a2537aa$9(this, roomDatabase);
    }

    public static int AJUtrLBMonBZYOOv(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.math.decimal AKOWPpsMeiLEKuRs(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static java.lang.object ASSXZjPTXQJIlPfj(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static void AVMaZWMyMkpHyoiK(androidx.room.RoomSQLiteQuery roomSQLiteQuery, int i, java.lang.string str) {
        roomSQLiteQuery.bindstring(i, str);
    }

    public static double AYRJbAHuxWbNcmOS(android.database.Cursor cursor, int i) {
        if ((30 + 6) % 6 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static java.math.decimal BFlBQNHcABPpNJDB(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static java.lang.object BUsjotbCqNmzubni(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary[obj);
    }

    public static bool BVXHodWxQXcmhcFv(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static bool BXpwdDJfVskznRHm(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static bool BZUEESisbOsmDmmr(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static java.lang.string BdleDRTeRIklhbHT(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.double BxCGbapOTXdyXGRt(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.util.IEnumerator CHYtUxfxtajrDheG(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object CMdppmBfHDoPttmA(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static int CSJPsUBYSWWNZsde(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static void CXpVXNDHMslXzHMX(androidx.collection.ArrayDictionary arrayDictionary, bool z, kotlin.jvm.functions.Function1 function1) {
        androidx.room.util.RelationUtil.recursiveFetchArrayDictionary(arrayDictionary, z, function1);
    }

    public static java.lang.string CbFryemkPupapeii(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string CbGnBfCznrmBrjhX(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static bool CcFBFyglEjfKBOid(android.database.Cursor cursor, int i) {
        return cursor.moveToPosition(i);
    }

    public static java.lang.string CnbaRQnrPkmzsVUd(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, p10348936.pf5e638cc.p14abd389 p14abd389Var) {
        return p7a2537aaVar.m7c9f4115(p14abd389Var);
    }

    public static void DPDXSVADtYAgWDcy(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static android.os.CancellationSignal DRhuZqEfOtHBXaOF() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static int DUFSDJxDEAEHFpcJ(java.util.HashSet set) {
        return set.Count;
    }

    public static java.lang.string DZHXFwbKwQGFNlZZ(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static void DwrOMMoKDkhhVWWN(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.collection.ArrayDictionary arrayDictionary) {
        p7a2537aaVar.mb69804d7(arrayDictionary);
    }

    public static java.lang.double DxCOLVAIWQwbfJPo(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.lang.string EFFCHVuNzJqEPEfp(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static bool EKbDVNiKmnLlcujx(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static java.lang.string ENuAnvauhRtAgFPl(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int EOsuBLuKKvXJuGxu(java.lang.string str) {
        return str.GetHashCode();
    }

    public static android.database.Cursor EgUuaKZoNjuDiPPh(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static java.lang.string FStYxJbgVcbRRLNW(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static void GQcQKZlRDogdrVnQ(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int GokVqdSucYgJJdRY(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndex(cursor, str);
    }

    public static java.lang.stringBuilder HEPGazOVEceWfHbg() {
        return androidx.room.util.stringUtil.newstringBuilder();
    }

    public static java.lang.stringBuilder HVItUrLxrBGpWRDd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HbSZyWdmhizlrYrx(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.double HnmVZnjbtPRzzzYv(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.lang.object HpaRhRpPnpQxpFHt(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static java.lang.double HpazdCkJYkaTPYNl(double d) {
        return java.lang.double.valueOf(d);
    }

    public static androidx.room.RoomSQLiteQuery HviojUQcPxdbRcfV(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static java.lang.object IPLTpizqdAQrXGbS(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static bool IUlCZqrbyvdDTPLf(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.object IjDHpvwcJAdPdLks(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static bool IskpslcxGtStjRoc(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.double JHvsuiXnOCLDUQxA(double d) {
        return java.lang.double.valueOf(d);
    }

    public static int JJBAHPDSWexXPLDQ(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndex(cursor, str);
    }

    public static java.math.decimal JmMaeBtDjvhKarwY(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static bool KAKyJpILEqKYBpXF(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static java.lang.stringBuilder KEAifMrwVGUjFomo() {
        return androidx.room.util.stringUtil.newstringBuilder();
    }

    public static int KEuYrpdOvpgyqRBV(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndex(cursor, str);
    }

    public static void KqdWmKjcQVzKbBYI(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static double KzYwJLHZFybdMGFf(android.database.Cursor cursor, int i) {
        if ((12 + 26) % 26 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static java.lang.string LCPFvLnsOMsSVoxN(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var) {
        return p7a2537aaVar.m6807eda8(pa1fa2777Var);
    }

    public static bool LYlpibGVRbKGyGtm(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.object LfJCTYaYWwdYrKMu(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static bool LvpTxmGCnZAEvPlk(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.object MGEtCrhVKPocZlzw(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static double MUigRKIbRVuGHfnJ(android.database.Cursor cursor, int i) {
        if ((1 + 32) % 32 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static double MkGtgKUaIxCwXVTn(android.database.Cursor cursor, int i) {
        if ((10 + 23) % 23 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static void MnLsjpPtJWmTGnJG(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.collection.ArrayDictionary arrayDictionary) {
        p7a2537aaVar.m08f17002(arrayDictionary);
    }

    public static bool MpGWDOSXDUbkYLjC(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.util.List NDFViZYLLGDuzqbU() {
        return java.util.ICollections.emptyList();
    }

    public static void NPnhtVNGFHLQaKNA(androidx.collection.ArrayDictionary arrayDictionary, bool z, kotlin.jvm.functions.Function1 function1) {
        androidx.room.util.RelationUtil.recursiveFetchArrayDictionary(arrayDictionary, z, function1);
    }

    public static java.lang.string NuAZxvlutctJQBxS(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string OVZTrrIXPGrgqLiZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object OXBzgZuvnMlZqLNr(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static java.lang.object OrSjYSeaUhJZUcuZ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary[obj);
    }

    public static java.math.decimal PPgbrhvGQGUHxwIz(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static java.lang.string PxPJeJUHqRPLWlbW(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.object QPoOEYzBMmkyjMCT(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.stringBuilder QobdtleooIeAHUFc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QyhlNvbjiAtxkTKU(java.util.HashSet set) {
        return set.Count;
    }

    public static int RITdctwCnbvafHid(pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var) {
        return pa1fa2777Var.ordinal();
    }

    public static java.math.decimal ROzANAxNJhTVbkKx(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static bool RtYdzntsZeIJnpGC(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static bool RwIHEORANqQRuwtC(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.object SDbKWEPHKWYaZSeP(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary[obj);
    }

    public static bool SLRyHDLojlildKSx(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static bool SdymLcDHqQNoCvcw(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static bool StIgbGRKkflmfDqY(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static java.lang.double SuUWKCYFOgNJuzQV(double d) {
        return java.lang.double.valueOf(d);
    }

    public static double TEUOBWnQBzsRLNkT(android.database.Cursor cursor, int i) {
        if ((8 + 2) % 2 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static java.lang.stringBuilder TFdPpcPRyAzIxNhr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static androidx.room.RoomSQLiteQuery TNSHXTaUNrehKwsX(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static bool TjfpjFItMbrrfazd(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static void TpVtgfXprzNXyzbF(androidx.room.RoomSQLiteQuery roomSQLiteQuery, int i, java.lang.string str) {
        roomSQLiteQuery.bindstring(i, str);
    }

    public static java.math.decimal TsNGcUTAdEMJxCBw(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static java.lang.object UYoUicBepfMgDoWQ(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static java.lang.stringBuilder VHEibYVnVGcqLTXv(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string VKZrIDqEryPpeyyO(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string VSEkHjkCQYYerXXP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool VfQkVyrRaEtorooA(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static double VjsfsvKkuGTtKVvP(android.database.Cursor cursor, int i) {
        if ((4 + 21) % 21 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static bool WFhKiMlcMLQJRBgI(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int WPLtOvguUdApNPll(java.util.HashSet set) {
        return set.Count;
    }

    public static androidx.room.RoomSQLiteQuery WikvxvsOSPAUEFNO(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static java.lang.string WjMwlUpLnBzjDQtx(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.object XCBIBZMHevVkbaQI(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool XTEFCxAoTuDvZiAd(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void XVrcldFKEgJTXXBq(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static bool XgojgfBDCLiNtxoP(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static double XhHYmcoFomgAQVLN(android.database.Cursor cursor, int i) {
        if ((27 + 19) % 19 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static java.lang.object XuAAdPtwvHSXHpJq(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 XvkcuVVwBDuLpBCT(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, java.lang.string str) {
        return p7a2537aaVar.m914269ef(str);
    }

    public static java.lang.double YPHubRpkwRXITKSc(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.lang.stringBuilder YTKOqapQApSBjlzb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YePXQdbUFCUtBUcf(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.string YfNSReGrpxDfChPu(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.double YjtPSJdxdqrRadVd(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.lang.string YxwLejIPrYCCbnbo(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.object ZJsDGaDLKthcKEZD(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static bool ZQzYyeHzvrFBwXNa(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.double ZeErOKQcbxqWroMw(double d) {
        return java.lang.double.valueOf(d);
    }

    public static bool ZxHvNhiVYGPAPRrI(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.stringBuilder AOkWHBNpjFTERzvm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.math.decimal AbaFANigkdEybtdR(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static double AkgdabiKsKGlOnsq(android.database.Cursor cursor, int i) {
        if ((15 + 5) % 5 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static bool AkrvzVJTOWsJcKyp(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static bool AzZOSpxIaMfYIxfH(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.string BITkynluiCoBkKhI(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static double BQRjTyJmiUfyHlPc(android.database.Cursor cursor, int i) {
        if ((11 + 18) % 18 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static void BTuvJUnzyOvWZOTV(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.stringBuilder BYnocUGZgmapWHII(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.math.decimal BbiBTaJzjvOCgqmx(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static androidx.room.RoomSQLiteQuery BrEUQyGUnvmUBqYs(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static java.lang.string CeVraAglwZCLbkdb(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.util.IEnumerator DEpVVgTaAGtWzVIn(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void DXwrdXOTwkLQqIeW(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void DYpzSoOeLWOxXeXM(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.collection.ArrayDictionary arrayDictionary) {
        p7a2537aaVar.mf235816b(arrayDictionary);
    }

    public static void DbVNmFBRaSmXOtNy(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.collection.ArrayDictionary arrayDictionary) {
        p7a2537aaVar.m08f17002(arrayDictionary);
    }

    public static int DkIqHUjmYnFZYqiH(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static bool DqYfjlpHcxBwlrJp(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.double EFLgsUkuIHOcLbVL(double d) {
        return java.lang.double.valueOf(d);
    }

    public static double EXccLFAdMpKlVPSY(android.database.Cursor cursor, int i) {
        if ((19 + 2) % 2 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static java.util.HashSet EZTtBvnvNmVBZKNE(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.keyHashSet();
    }

    public static bool EcNJLkDmpVTNhNEx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void EtlUEAXeOBTQTxMa(java.lang.stringBuilder sb, int i) {
        androidx.room.util.stringUtil.appendPlaceholders(sb, i);
    }

    public static void FUWESvCKTnklKSZG(androidx.collection.ArrayDictionary arrayDictionary, bool z, kotlin.jvm.functions.Function1 function1) {
        androidx.room.util.RelationUtil.recursiveFetchArrayDictionary(arrayDictionary, z, function1);
    }

    public static java.lang.string FjkQdxsGaNYbqSIE(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static double FqDpVgDsFUGsWYec(android.database.Cursor cursor, int i) {
        if ((30 + 23) % 23 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static java.lang.string FtWXAkcDvBOKPNBW(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.util.HashSet GCRuMAxsOmouzbPf(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.keyHashSet();
    }

    public static androidx.room.RoomSQLiteQuery GVDedTOCGGJvLVZY(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static android.os.CancellationSignal GxPqGOElAfXtVBeF() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static bool HAKucpeoEsNKIKoJ(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.string HPxCqEydTygZRYYn(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.math.decimal HWXNOulLtvbaSNQW(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static java.lang.object HZzOeGAZvarOkySl(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string HbPaiIdbrWMnIIAq(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.double HiOrwXPYaKYQCVcA(double d) {
        return java.lang.double.valueOf(d);
    }

    public static bool IAkcMsktBzZpPKnN(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.string IYFZacMjlFfGmJay(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string IhzrOmChQNGVIfRw(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.math.decimal IityFpqLZneXnRGO(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static void IlTlGQAHBTaUwhyt(androidx.room.RoomSQLiteQuery roomSQLiteQuery, int i, java.lang.string str) {
        roomSQLiteQuery.bindstring(i, str);
    }

    public static java.lang.object JjehGdrUXxDahomO(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static bool KIQiwupIhaIGsTct(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string KUYAIMnqZVkSgvGJ(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.object LBPlUMVYYSklCshS(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static void LKXmtUzufrvDpaax(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.collection.ArrayDictionary arrayDictionary) {
        p7a2537aaVar.m08f17002(arrayDictionary);
    }

    public static java.math.decimal LLmKFmmpJMIPqpPj(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static int LYAZCpPuGgrovUih(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static android.database.Cursor LdbKdPsMWXtKuYmZ(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    private p10348936.pf5e638cc.p14abd389 M03b27896(java.lang.string str) {
        if ((17 + 9) % 9 > 0) {
        }
        AJUtrLBMonBZYOOv(str);
        if (kIQiwupIhaIGsTct(str, "SAVED_QUANTITY")) {
            return p10348936.pf5e638cc.p14abd389.f66f73e50;
        }
        if (XTEFCxAoTuDvZiAd(str, "RESET_QUANTITY")) {
            return p10348936.pf5e638cc.p14abd389.fe24a0a67;
        }
        throw new java.lang.IllegalArgumentException(xBvHYqqjYQPMrYlL(YTKOqapQApSBjlzb(new java.lang.stringBuilder("Can't convert value to enum, unknown value: "), str)));
    }

    private void M08f17002(androidx.collection.ArrayDictionary<java.lang.string, pad5f82e8.p07214c67.pd77d5e50.pf22d65ed> arrayDictionary) {
        if ((32 + 30) % 30 > 0) {
        }
        java.util.HashSet setOhdmACWvddVlGdTJ = ohdmACWvddVlGdTJ(arrayDictionary);
        if (akrvzVJTOWsJcKyp(setOhdmACWvddVlGdTJ)) {
            return;
        }
        if (tzJqzZLXHCEiPkKh(arrayDictionary) > 999) {
            fUWESvCKTnklKSZG(arrayDictionary, false, new p10348936.pf0719ea8.p7a2537aa$pd41d8cd9$pcca4ef0e(this));
            return;
        }
        java.lang.stringBuilder sbKEAifMrwVGUjFomo = KEAifMrwVGUjFomo();
        bYnocUGZgmapWHII(sbKEAifMrwVGUjFomo, "SELECT `code`,`rate`,`type`,`subType`,`engName`,`arabName` FROM `tax` WHERE `code` IN (");
        int iDUFSDJxDEAEHFpcJ = DUFSDJxDEAEHFpcJ(setOhdmACWvddVlGdTJ);
        wMuCUaMtkZhSjvoi(sbKEAifMrwVGUjFomo, iDUFSDJxDEAEHFpcJ);
        QobdtleooIeAHUFc(sbKEAifMrwVGUjFomo, ")");
        androidx.room.RoomSQLiteQuery roomSQLiteQueryHviojUQcPxdbRcfV = HviojUQcPxdbRcfV(VSEkHjkCQYYerXXP(sbKEAifMrwVGUjFomo), iDUFSDJxDEAEHFpcJ);
        java.util.IEnumerator itDEpVVgTaAGtWzVIn = dEpVVgTaAGtWzVIn(setOhdmACWvddVlGdTJ);
        int i = 1;
        while (IskpslcxGtStjRoc(itDEpVVgTaAGtWzVIn)) {
            AVMaZWMyMkpHyoiK(roomSQLiteQueryHviojUQcPxdbRcfV, i, (java.lang.string) QPoOEYzBMmkyjMCT(itDEpVVgTaAGtWzVIn));
            i++;
        }
        android.database.Cursor cursorEgUuaKZoNjuDiPPh = EgUuaKZoNjuDiPPh(this.fa8bf39ac, roomSQLiteQueryHviojUQcPxdbRcfV, false, null);
        try {
            int iKEuYrpdOvpgyqRBV = KEuYrpdOvpgyqRBV(cursorEgUuaKZoNjuDiPPh, "code");
            if (iKEuYrpdOvpgyqRBV == -1) {
                DPDXSVADtYAgWDcy(cursorEgUuaKZoNjuDiPPh);
                return;
            }
            while (RtYdzntsZeIJnpGC(cursorEgUuaKZoNjuDiPPh)) {
                java.lang.string strYxwLejIPrYCCbnbo = YxwLejIPrYCCbnbo(cursorEgUuaKZoNjuDiPPh, iKEuYrpdOvpgyqRBV);
                if (vlJGdkEOXwqUywXk(arrayDictionary, strYxwLejIPrYCCbnbo)) {
                    pOEnpxIaKNykuAFR(arrayDictionary, strYxwLejIPrYCCbnbo, new pad5f82e8.p07214c67.pd77d5e50.pf22d65ed(ftWXAkcDvBOKPNBW(cursorEgUuaKZoNjuDiPPh, 0), ENuAnvauhRtAgFPl(cursorEgUuaKZoNjuDiPPh, 1), MpGWDOSXDUbkYLjC(cursorEgUuaKZoNjuDiPPh, 2) ? null : stlUjKecACJqGleS(cursorEgUuaKZoNjuDiPPh, 2), BXpwdDJfVskznRHm(cursorEgUuaKZoNjuDiPPh, 3) ? null : iYFZacMjlFfGmJay(cursorEgUuaKZoNjuDiPPh, 3), WjMwlUpLnBzjDQtx(cursorEgUuaKZoNjuDiPPh, 4), NuAZxvlutctJQBxS(cursorEgUuaKZoNjuDiPPh, 5)));
                }
            }
            dXwrdXOTwkLQqIeW(cursorEgUuaKZoNjuDiPPh);
        } catch (java.lang.Exception th) {
            HbSZyWdmhizlrYrx(cursorEgUuaKZoNjuDiPPh);
            throw th;
        }
    }

    static androidx.room.EntityInsertionAdapter M0dc0a6ea(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p7a2537aaVar.f89c4256c;
    }

    static androidx.room.EntityInsertionAdapter M13fe7af4(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p7a2537aaVar.f7860905a;
    }

    static void M1740fbc7(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.collection.ArrayDictionary arrayDictionary) {
        rwdKlNwvWKzcpdlt(p7a2537aaVar, arrayDictionary);
    }

    static androidx.room.SharedSQLiteStatement M2a096755(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p7a2537aaVar.f4c800510;
    }

    static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 M337ceba5(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p7a2537aaVar.fa92cb57a;
    }

    static androidx.room.EntityInsertionAdapter M429f062d(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p7a2537aaVar.f95362d42;
    }

    static androidx.room.SharedSQLiteStatement M5e49d338(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p7a2537aaVar.fade50827;
    }

    static java.lang.string M5ec06fdf(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var) {
        return LCPFvLnsOMsSVoxN(p7a2537aaVar, pa1fa2777Var);
    }

    static pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 M649493cb(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, java.lang.string str) {
        return zWEePcbptNlneWVQ(p7a2537aaVar, str);
    }

    private java.lang.string M6807eda8(pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var) {
        if ((10 + 3) % 3 > 0) {
        }
        int i = p10348936.pf0719ea8.p7a2537aa$23.$SwitchDictionary$domain$entities$inventory$Type[RITdctwCnbvafHid(pa1fa2777Var)];
        if (i == 1) {
            return "NORMAL";
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException(OVZTrrIXPGrgqLiZ(VHEibYVnVGcqLTXv(new java.lang.stringBuilder("Can't convert enum to string, unknown enum value: "), pa1fa2777Var)));
        }
        return "SERVICE";
    }

    static androidx.room.EntityDeletionOrUpdateAdapter M74674bbd(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p7a2537aaVar.f7c3af5a1;
    }

    private java.lang.string M7c9f4115(p10348936.pf5e638cc.p14abd389 p14abd389Var) {
        if ((18 + 18) % 18 > 0) {
        }
        int i = p10348936.pf0719ea8.p7a2537aa$23.$SwitchDictionary$inventorization$entity$InventorizationStatus[ndqMMHudSlbhhral(p14abd389Var)];
        if (i == 1) {
            return "SAVED_QUANTITY";
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException(CbFryemkPupapeii(yIuIAOmyOyrxGJYK(new java.lang.stringBuilder("Can't convert enum to string, unknown enum value: "), p14abd389Var)));
        }
        return "RESET_QUANTITY";
    }

    static androidx.room.SharedSQLiteStatement M83fd488e(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p7a2537aaVar.f3392e244;
    }

    static androidx.room.EntityInsertionAdapter M89082e03(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p7a2537aaVar.f51d05837;
    }

    private pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 M914269ef(java.lang.string str) {
        if ((31 + 12) % 12 > 0) {
        }
        EOsuBLuKKvXJuGxu(str);
        if (RwIHEORANqQRuwtC(str, "NORMAL")) {
            return pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777.f1e238528;
        }
        if (WFhKiMlcMLQJRBgI(str, "SERVICE")) {
            return pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777.ff9e81a74;
        }
        throw new java.lang.IllegalArgumentException(mfTsROMqZISVCnQn(pideQeyHqXmIxLdU(new java.lang.stringBuilder("Can't convert value to enum, unknown value: "), str)));
    }

    public static int MFhwGfNEuDMmgXAx(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static java.lang.string MNkOCuSxMlZStKEd(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    static void Ma5940f5e(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.collection.ArrayDictionary arrayDictionary) {
        qSflLzkKcgtMwPCD(p7a2537aaVar, arrayDictionary);
    }

    public static java.util.List<java.lang.Class<object>> Mb3fda515() {
        return NDFViZYLLGDuzqbU();
    }

    private void Mb69804d7(androidx.collection.ArrayDictionary<java.lang.string, java.util.List<p10348936.pf5e638cc.pd77d5e50.p741b1ba9>> arrayDictionary) {
        if ((12 + 13) % 13 > 0) {
        }
        java.util.HashSet setEZTtBvnvNmVBZKNE = eZTtBvnvNmVBZKNE(arrayDictionary);
        if (StIgbGRKkflmfDqY(setEZTtBvnvNmVBZKNE)) {
            return;
        }
        if (dkIqHUjmYnFZYqiH(arrayDictionary) > 999) {
            CXpVXNDHMslXzHMX(arrayDictionary, true, new p10348936.pf0719ea8.p7a2537aa$pd41d8cd9$p95263d50(this));
            return;
        }
        java.lang.stringBuilder sbHEPGazOVEceWfHbg = HEPGazOVEceWfHbg();
        TFdPpcPRyAzIxNhr(sbHEPGazOVEceWfHbg, "SELECT `uuid`,`inventorizationUuid`,`receiptUuid`,`price`,`purchasePrice`,`name`,`measure`,`precision`,`quantity`,`initialQuantity`,`tax`,`commodityId`,`type`,`tareVolume`,`priceWithDiscount` FROM `inventorization_position` WHERE `inventorizationUuid` IN (");
        int iWPLtOvguUdApNPll = WPLtOvguUdApNPll(setEZTtBvnvNmVBZKNE);
        vZKclRTOXctKVnJr(sbHEPGazOVEceWfHbg, iWPLtOvguUdApNPll);
        aOkWHBNpjFTERzvm(sbHEPGazOVEceWfHbg, ")");
        androidx.room.RoomSQLiteQuery roomSQLiteQueryWikvxvsOSPAUEFNO = WikvxvsOSPAUEFNO(qBqxUPjuHkvMBOHQ(sbHEPGazOVEceWfHbg), iWPLtOvguUdApNPll);
        java.util.IEnumerator itQOKbTDWXFaYlNhkA = qOKbTDWXFaYlNhkA(setEZTtBvnvNmVBZKNE);
        int i = 1;
        while (ecNJLkDmpVTNhNEx(itQOKbTDWXFaYlNhkA)) {
            ilTlGQAHBTaUwhyt(roomSQLiteQueryWikvxvsOSPAUEFNO, i, (java.lang.string) XCBIBZMHevVkbaQI(itQOKbTDWXFaYlNhkA));
            i++;
        }
        java.lang.double d = null;
        android.database.Cursor cursorLdbKdPsMWXtKuYmZ = ldbKdPsMWXtKuYmZ(this.fa8bf39ac, roomSQLiteQueryWikvxvsOSPAUEFNO, true, null);
        try {
            int iGokVqdSucYgJJdRY = GokVqdSucYgJJdRY(cursorLdbKdPsMWXtKuYmZ, "inventorizationUuid");
            if (iGokVqdSucYgJJdRY == -1) {
                bTuvJUnzyOvWZOTV(cursorLdbKdPsMWXtKuYmZ);
                return;
            }
            androidx.collection.ArrayDictionary arrayDictionary2 = new androidx.collection.ArrayDictionary();
            while (KAKyJpILEqKYBpXF(cursorLdbKdPsMWXtKuYmZ)) {
                java.lang.string strFStYxJbgVcbRRLNW = TjfpjFItMbrrfazd(cursorLdbKdPsMWXtKuYmZ, 10) ? null : FStYxJbgVcbRRLNW(cursorLdbKdPsMWXtKuYmZ, 10);
                if (strFStYxJbgVcbRRLNW is not null) {
                    HpaRhRpPnpQxpFHt(arrayDictionary2, strFStYxJbgVcbRRLNW, null);
                }
            }
            CcFBFyglEjfKBOid(cursorLdbKdPsMWXtKuYmZ, -1);
            dbVNmFBRaSmXOtNy(this, arrayDictionary2);
            while (SdymLcDHqQNoCvcw(cursorLdbKdPsMWXtKuYmZ)) {
                java.util.List arrayList = (java.util.List) pfGPHKbeTLbClXbe(arrayDictionary, EFFCHVuNzJqEPEfp(cursorLdbKdPsMWXtKuYmZ, iGokVqdSucYgJJdRY));
                if (arrayList is not null) {
                    java.lang.string strCbGnBfCznrmBrjhX = CbGnBfCznrmBrjhX(cursorLdbKdPsMWXtKuYmZ, 0);
                    java.lang.string strKUYAIMnqZVkSgvGJ = kUYAIMnqZVkSgvGJ(cursorLdbKdPsMWXtKuYmZ, 1);
                    java.lang.string strDZHXFwbKwQGFNlZZ = DZHXFwbKwQGFNlZZ(cursorLdbKdPsMWXtKuYmZ, 2);
                    java.math.decimal bigDecimalBbiBTaJzjvOCgqmx = bbiBTaJzjvOCgqmx(this.fa92cb57a, XgojgfBDCLiNtxoP(cursorLdbKdPsMWXtKuYmZ, 3) ? d : DxCOLVAIWQwbfJPo(akgdabiKsKGlOnsq(cursorLdbKdPsMWXtKuYmZ, 3)));
                    if (bigDecimalBbiBTaJzjvOCgqmx is null) {
                        throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                    }
                    java.math.decimal bigDecimalAbaFANigkdEybtdR = abaFANigkdEybtdR(this.fa92cb57a, BVXHodWxQXcmhcFv(cursorLdbKdPsMWXtKuYmZ, 4) ? d : JHvsuiXnOCLDUQxA(TEUOBWnQBzsRLNkT(cursorLdbKdPsMWXtKuYmZ, 4)));
                    if (bigDecimalAbaFANigkdEybtdR is null) {
                        throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                    }
                    java.lang.string strVKZrIDqEryPpeyyO = VKZrIDqEryPpeyyO(cursorLdbKdPsMWXtKuYmZ, 5);
                    java.lang.string strBdleDRTeRIklhbHT = BdleDRTeRIklhbHT(cursorLdbKdPsMWXtKuYmZ, 6);
                    int iLYAZCpPuGgrovUih = lYAZCpPuGgrovUih(cursorLdbKdPsMWXtKuYmZ, 7);
                    java.math.decimal bigDecimalLLmKFmmpJMIPqpPj = lLmKFmmpJMIPqpPj(this.fa92cb57a, ZQzYyeHzvrFBwXNa(cursorLdbKdPsMWXtKuYmZ, 8) ? d : YPHubRpkwRXITKSc(KzYwJLHZFybdMGFf(cursorLdbKdPsMWXtKuYmZ, 8)));
                    if (bigDecimalLLmKFmmpJMIPqpPj is null) {
                        throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                    }
                    java.math.decimal bigDecimalPPgbrhvGQGUHxwIz = PPgbrhvGQGUHxwIz(this.fa92cb57a, ofCkHTacSVbVzSVE(cursorLdbKdPsMWXtKuYmZ, 9) ? null : sxMUoPfZgZWmjSIi(wlDaYdVOxCyBjAJf(cursorLdbKdPsMWXtKuYmZ, 9)));
                    if (bigDecimalPPgbrhvGQGUHxwIz is null) {
                        throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                    }
                    p10348936.pf5e638cc.pd77d5e50.p555020e1 p555020e1Var = new p10348936.pf5e638cc.pd77d5e50.p555020e1(strCbGnBfCznrmBrjhX, strKUYAIMnqZVkSgvGJ, strDZHXFwbKwQGFNlZZ, bigDecimalBbiBTaJzjvOCgqmx, bigDecimalAbaFANigkdEybtdR, strVKZrIDqEryPpeyyO, strBdleDRTeRIklhbHT, iLYAZCpPuGgrovUih, bigDecimalLLmKFmmpJMIPqpPj, bigDecimalPPgbrhvGQGUHxwIz, iAkcMsktBzZpPKnN(cursorLdbKdPsMWXtKuYmZ, 10) ? null : bITkynluiCoBkKhI(cursorLdbKdPsMWXtKuYmZ, 10), yMCWREUBQYJeRRoB(cursorLdbKdPsMWXtKuYmZ, 11) ? null : qkTCcAFMDrxdqQlH(cursorLdbKdPsMWXtKuYmZ, 11), rSTuiiDRjwjuNohZ(cursorLdbKdPsMWXtKuYmZ, 12) ? null : wQaEjiEGZATjdnPY(this, hPxCqEydTygZRYYn(cursorLdbKdPsMWXtKuYmZ, 12)), qaBZrlShzKkTIvco(this.fa92cb57a, uNKbBjITXYWqaUtu(cursorLdbKdPsMWXtKuYmZ, 13) ? null : hiOrwXPYaKYQCVcA(bQRjTyJmiUfyHlPc(cursorLdbKdPsMWXtKuYmZ, 13))), AKOWPpsMeiLEKuRs(this.fa92cb57a, hAKucpeoEsNKIKoJ(cursorLdbKdPsMWXtKuYmZ, 14) ? null : YjtPSJdxdqrRadVd(AYRJbAHuxWbNcmOS(cursorLdbKdPsMWXtKuYmZ, 14))));
                    java.lang.string strMNkOCuSxMlZStKEd = azZOSpxIaMfYIxfH(cursorLdbKdPsMWXtKuYmZ, 10) ? null : mNkOCuSxMlZStKEd(cursorLdbKdPsMWXtKuYmZ, 10);
                    wGGkSPiOzpqgIboH(arrayList, new p10348936.pf5e638cc.pd77d5e50.p741b1ba9(p555020e1Var, strMNkOCuSxMlZStKEd is not null ? (pad5f82e8.p07214c67.pd77d5e50.pf22d65ed) BUsjotbCqNmzubni(arrayDictionary2, strMNkOCuSxMlZStKEd) : null));
                }
                d = null;
            }
            KqdWmKjcQVzKbBYI(cursorLdbKdPsMWXtKuYmZ);
        } catch (java.lang.Exception th) {
            GQcQKZlRDogdrVnQ(cursorLdbKdPsMWXtKuYmZ);
            throw th;
        }
    }

    static androidx.room.RoomDatabase Mbbeb9b46(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p7a2537aaVar.fa8bf39ac;
    }

    static p10348936.pf5e638cc.p14abd389 Mc7321d99(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, java.lang.string str) {
        return pWuRUPwUDjbyCKyM(p7a2537aaVar, str);
    }

    static void Mcdc7972c(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.collection.ArrayDictionary arrayDictionary) {
        nHWofkILTVccnlbc(p7a2537aaVar, arrayDictionary);
    }

    static androidx.room.SharedSQLiteStatement Mebdbf394(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p7a2537aaVar.fe0337741;
    }

    private void Mf235816b(androidx.collection.ArrayDictionary<java.lang.string, java.util.List<p10348936.pf5e638cc.pd77d5e50.p5e3e4f48>> arrayDictionary) {
        if ((27 + 11) % 11 > 0) {
        }
        java.util.HashSet setGCRuMAxsOmouzbPf = gCRuMAxsOmouzbPf(arrayDictionary);
        if (BZUEESisbOsmDmmr(setGCRuMAxsOmouzbPf)) {
            return;
        }
        if (mFhwGfNEuDMmgXAx(arrayDictionary) > 999) {
            NPnhtVNGFHLQaKNA(arrayDictionary, true, new p10348936.pf0719ea8.p7a2537aa$pd41d8cd9$p144e4630(this));
            return;
        }
        java.lang.stringBuilder sbUYkskdZfnYiCXNtD = uYkskdZfnYiCXNtD();
        uMIuSioaHsNVAptF(sbUYkskdZfnYiCXNtD, "SELECT `uuid`,`inventorizationUuid`,`receiptUuid`,`price`,`purchasePrice`,`name`,`measure`,`precision`,`quantity`,`initialQuantity`,`tax`,`commodityId`,`type`,`tareVolume`,`priceWithDiscount` FROM `current_inventorization_position` WHERE `inventorizationUuid` IN (");
        int iQyhlNvbjiAtxkTKU = QyhlNvbjiAtxkTKU(setGCRuMAxsOmouzbPf);
        etlUEAXeOBTQTxMa(sbUYkskdZfnYiCXNtD, iQyhlNvbjiAtxkTKU);
        HVItUrLxrBGpWRDd(sbUYkskdZfnYiCXNtD, ")");
        androidx.room.RoomSQLiteQuery roomSQLiteQueryBrEUQyGUnvmUBqYs = brEUQyGUnvmUBqYs(rWiTwQEeDWbvSWlm(sbUYkskdZfnYiCXNtD), iQyhlNvbjiAtxkTKU);
        java.util.IEnumerator itCHYtUxfxtajrDheG = CHYtUxfxtajrDheG(setGCRuMAxsOmouzbPf);
        int i = 1;
        while (nstMMkyaiIfQkCQc(itCHYtUxfxtajrDheG)) {
            TpVtgfXprzNXyzbF(roomSQLiteQueryBrEUQyGUnvmUBqYs, i, (java.lang.string) hZzOeGAZvarOkySl(itCHYtUxfxtajrDheG));
            i++;
        }
        java.lang.double d = null;
        android.database.Cursor cursorYvLIFWneNwqcKClp = yvLIFWneNwqcKClp(this.fa8bf39ac, roomSQLiteQueryBrEUQyGUnvmUBqYs, true, null);
        try {
            int iJJBAHPDSWexXPLDQ = JJBAHPDSWexXPLDQ(cursorYvLIFWneNwqcKClp, "inventorizationUuid");
            if (iJJBAHPDSWexXPLDQ == -1) {
                XVrcldFKEgJTXXBq(cursorYvLIFWneNwqcKClp);
                return;
            }
            androidx.collection.ArrayDictionary arrayDictionary2 = new androidx.collection.ArrayDictionary();
            while (EKbDVNiKmnLlcujx(cursorYvLIFWneNwqcKClp)) {
                java.lang.string strFjkQdxsGaNYbqSIE = dqYfjlpHcxBwlrJp(cursorYvLIFWneNwqcKClp, 10) ? null : fjkQdxsGaNYbqSIE(cursorYvLIFWneNwqcKClp, 10);
                if (strFjkQdxsGaNYbqSIE is not null) {
                    IjDHpvwcJAdPdLks(arrayDictionary2, strFjkQdxsGaNYbqSIE, null);
                }
            }
            wUlrShbJmWZZlQLf(cursorYvLIFWneNwqcKClp, -1);
            lKXmtUzufrvDpaax(this, arrayDictionary2);
            while (xzHKhduTIbIqnJcz(cursorYvLIFWneNwqcKClp)) {
                java.util.List arrayList = (java.util.List) SDbKWEPHKWYaZSeP(arrayDictionary, ihzrOmChQNGVIfRw(cursorYvLIFWneNwqcKClp, iJJBAHPDSWexXPLDQ));
                if (arrayList is not null) {
                    java.lang.string strUtXbbDqwWzTyTSes = utXbbDqwWzTyTSes(cursorYvLIFWneNwqcKClp, 0);
                    java.lang.string strHbPaiIdbrWMnIIAq = hbPaiIdbrWMnIIAq(cursorYvLIFWneNwqcKClp, 1);
                    java.lang.string strUCjAFYgJkNyZEszL = uCjAFYgJkNyZEszL(cursorYvLIFWneNwqcKClp, 2);
                    java.math.decimal bigDecimalHWXNOulLtvbaSNQW = hWXNOulLtvbaSNQW(this.fa92cb57a, vylfDBdQFiCvmBOR(cursorYvLIFWneNwqcKClp, 3) ? d : SuUWKCYFOgNJuzQV(fqDpVgDsFUGsWYec(cursorYvLIFWneNwqcKClp, 3)));
                    if (bigDecimalHWXNOulLtvbaSNQW is null) {
                        throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                    }
                    java.math.decimal bigDecimalROzANAxNJhTVbkKx = ROzANAxNJhTVbkKx(this.fa92cb57a, zXyavxOXTuJXXcUc(cursorYvLIFWneNwqcKClp, 4) ? d : ZeErOKQcbxqWroMw(eXccLFAdMpKlVPSY(cursorYvLIFWneNwqcKClp, 4)));
                    if (bigDecimalROzANAxNJhTVbkKx is null) {
                        throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                    }
                    java.lang.string strYwpzPFiJkyRRgquX = ywpzPFiJkyRRgquX(cursorYvLIFWneNwqcKClp, 5);
                    java.lang.string strPxPJeJUHqRPLWlbW = PxPJeJUHqRPLWlbW(cursorYvLIFWneNwqcKClp, 6);
                    int iCSJPsUBYSWWNZsde = CSJPsUBYSWWNZsde(cursorYvLIFWneNwqcKClp, 7);
                    java.math.decimal bigDecimalBFlBQNHcABPpNJDB = BFlBQNHcABPpNJDB(this.fa92cb57a, yNSwPMLynFQZJWOb(cursorYvLIFWneNwqcKClp, 8) ? d : HpazdCkJYkaTPYNl(VjsfsvKkuGTtKVvP(cursorYvLIFWneNwqcKClp, 8)));
                    if (bigDecimalBFlBQNHcABPpNJDB is null) {
                        throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                    }
                    java.math.decimal bigDecimalIityFpqLZneXnRGO = iityFpqLZneXnRGO(this.fa92cb57a, LvpTxmGCnZAEvPlk(cursorYvLIFWneNwqcKClp, 9) ? null : HnmVZnjbtPRzzzYv(XhHYmcoFomgAQVLN(cursorYvLIFWneNwqcKClp, 9)));
                    if (bigDecimalIityFpqLZneXnRGO is null) {
                        throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                    }
                    p10348936.pf5e638cc.pd77d5e50.p0ed7807b p0ed7807bVar = new p10348936.pf5e638cc.pd77d5e50.p0ed7807b(strUtXbbDqwWzTyTSes, strHbPaiIdbrWMnIIAq, strUCjAFYgJkNyZEszL, bigDecimalHWXNOulLtvbaSNQW, bigDecimalROzANAxNJhTVbkKx, strYwpzPFiJkyRRgquX, strPxPJeJUHqRPLWlbW, iCSJPsUBYSWWNZsde, bigDecimalBFlBQNHcABPpNJDB, bigDecimalIityFpqLZneXnRGO, zTUGAtlVGjLJCoeA(cursorYvLIFWneNwqcKClp, 10) ? null : ceVraAglwZCLbkdb(cursorYvLIFWneNwqcKClp, 10), LYlpibGVRbKGyGtm(cursorYvLIFWneNwqcKClp, 11) ? null : qvuznVBzTPHJkCSH(cursorYvLIFWneNwqcKClp, 11), ZxHvNhiVYGPAPRrI(cursorYvLIFWneNwqcKClp, 12) ? null : XvkcuVVwBDuLpBCT(this, vMDjtFzExfpuThCS(cursorYvLIFWneNwqcKClp, 12)), TsNGcUTAdEMJxCBw(this.fa92cb57a, qkExitIILyQeXnDS(cursorYvLIFWneNwqcKClp, 13) ? null : eFLgsUkuIHOcLbVL(MkGtgKUaIxCwXVTn(cursorYvLIFWneNwqcKClp, 13))), JmMaeBtDjvhKarwY(this.fa92cb57a, SLRyHDLojlildKSx(cursorYvLIFWneNwqcKClp, 14) ? null : BxCGbapOTXdyXGRt(MUigRKIbRVuGHfnJ(cursorYvLIFWneNwqcKClp, 14))));
                    java.lang.string strYfNSReGrpxDfChPu = VfQkVyrRaEtorooA(cursorYvLIFWneNwqcKClp, 10) ? null : YfNSReGrpxDfChPu(cursorYvLIFWneNwqcKClp, 10);
                    IUlCZqrbyvdDTPLf(arrayList, new p10348936.pf5e638cc.pd77d5e50.p5e3e4f48(p0ed7807bVar, strYfNSReGrpxDfChPu is not null ? (pad5f82e8.p07214c67.pd77d5e50.pf22d65ed) OrSjYSeaUhJZUcuZ(arrayDictionary2, strYfNSReGrpxDfChPu) : null));
                }
                d = null;
            }
            nPqoJvqZYvSHeThq(cursorYvLIFWneNwqcKClp);
        } catch (java.lang.Exception th) {
            YePXQdbUFCUtBUcf(cursorYvLIFWneNwqcKClp);
            throw th;
        }
    }

    static p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 Mf23e8626(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p7a2537aaVar.fb8317a4c;
    }

    static java.lang.string Mf8f67da7(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, p10348936.pf5e638cc.p14abd389 p14abd389Var) {
        return CnbaRQnrPkmzsVUd(p7a2537aaVar, p14abd389Var);
    }

    public static java.lang.string MfTsROMqZISVCnQn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void NHWofkILTVccnlbc(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.collection.ArrayDictionary arrayDictionary) {
        p7a2537aaVar.mb69804d7(arrayDictionary);
    }

    public static java.lang.object NHySraOFopJWGVdp(androidx.room.RoomDatabase roomDatabase, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation) {
        return androidx.room.RoomDatabaseKt.withTransaction(roomDatabase, function1, continuation);
    }

    public static void NPqoJvqZYvSHeThq(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int NdqMMHudSlbhhral(p10348936.pf5e638cc.p14abd389 p14abd389Var) {
        return p14abd389Var.ordinal();
    }

    public static bool NstMMkyaiIfQkCQc(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool OfCkHTacSVbVzSVE(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.util.HashSet OhdmACWvddVlGdTJ(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.keyHashSet();
    }

    public static java.lang.object POEnpxIaKNykuAFR(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static p10348936.pf5e638cc.p14abd389 PWuRUPwUDjbyCKyM(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, java.lang.string str) {
        return p7a2537aaVar.m03b27896(str);
    }

    public static java.lang.object PfGPHKbeTLbClXbe(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary[obj);
    }

    public static java.lang.stringBuilder PideQeyHqXmIxLdU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QBqxUPjuHkvMBOHQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.IEnumerator QOKbTDWXFaYlNhkA(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void QSflLzkKcgtMwPCD(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.collection.ArrayDictionary arrayDictionary) {
        p7a2537aaVar.mf235816b(arrayDictionary);
    }

    public static java.math.decimal QaBZrlShzKkTIvco(p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 p35667ee1Var, java.lang.double d) {
        return p35667ee1Var.doubleTodecimal(d);
    }

    public static bool QkExitIILyQeXnDS(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.string QkTCcAFMDrxdqQlH(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string QvuznVBzTPHJkCSH(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static bool RSTuiiDRjwjuNohZ(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.string RWiTwQEeDWbvSWlm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object RqnPYLyYHArSmBRl(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static void RwdKlNwvWKzcpdlt(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.collection.ArrayDictionary arrayDictionary) {
        p7a2537aaVar.m08f17002(arrayDictionary);
    }

    public static java.lang.string StlUjKecACJqGleS(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.double SxMUoPfZgZWmjSIi(double d) {
        return java.lang.double.valueOf(d);
    }

    public static android.os.CancellationSignal TCkiIjuuFKqgHECk() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static androidx.room.RoomSQLiteQuery TpzFUgpDKwqgCkqa(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static int TzJqzZLXHCEiPkKh(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static java.lang.string UCjAFYgJkNyZEszL(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.stringBuilder UMIuSioaHsNVAptF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool UNKbBjITXYWqaUtu(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.stringBuilder UYkskdZfnYiCXNtD() {
        return androidx.room.util.stringUtil.newstringBuilder();
    }

    public static java.lang.string UtXbbDqwWzTyTSes(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string VMDjtFzExfpuThCS(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static void VZKclRTOXctKVnJr(java.lang.stringBuilder sb, int i) {
        androidx.room.util.stringUtil.appendPlaceholders(sb, i);
    }

    public static android.os.CancellationSignal VamqjXQDTUxiwLHp() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static bool VlJGdkEOXwqUywXk(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary.ContainsKey(obj);
    }

    public static bool VylfDBdQFiCvmBOR(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static bool WGGkSPiOzpqgIboH(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void WMuCUaMtkZhSjvoi(java.lang.stringBuilder sb, int i) {
        androidx.room.util.stringUtil.appendPlaceholders(sb, i);
    }

    public static pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 WQaEjiEGZATjdnPY(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, java.lang.string str) {
        return p7a2537aaVar.m914269ef(str);
    }

    public static bool WUlrShbJmWZZlQLf(android.database.Cursor cursor, int i) {
        return cursor.moveToPosition(i);
    }

    public static double WlDaYdVOxCyBjAJf(android.database.Cursor cursor, int i) {
        if ((11 + 23) % 23 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static java.lang.string XBvHYqqjYQPMrYlL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool XzHKhduTIbIqnJcz(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static java.lang.stringBuilder YIuIAOmyOyrxGJYK(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool YMCWREUBQYJeRRoB(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static bool YNSwPMLynFQZJWOb(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static androidx.room.RoomSQLiteQuery YmxEvwTSeSMCgnMN(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static android.database.Cursor YvLIFWneNwqcKClp(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static java.lang.string YwpzPFiJkyRRgquX(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static bool ZTUGAtlVGjLJCoeA(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 ZWEePcbptNlneWVQ(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, java.lang.string str) {
        return p7a2537aaVar.m914269ef(str);
    }

    public static bool ZXyavxOXTuJXXcUc(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.object ZrYeJyenJYTEmEOT(p10348936.pf0719ea8.p4447a398 p4447a398Var, p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return p10348936.pf0719ea8.p4447a398$pb0da8397.m3a2c4d23(p4447a398Var, p4582d01fVar, list, continuation);
    }

    public static java.lang.object ZyDWJXRZpwzPVNjQ(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public override java.lang.object ClearCurrentInventorizationPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((17 + 29) % 29 > 0) {
        }
        return ASSXZjPTXQJIlPfj(this.fa8bf39ac, true, new p10348936.pf0719ea8.p7a2537aa$17(this), continuation);
    }

    public override java.lang.object ClearCurrentInventorizations(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((8 + 5) % 5 > 0) {
        }
        return rqnPYLyYHArSmBRl(this.fa8bf39ac, true, new p10348936.pf0719ea8.p7a2537aa$16(this), continuation);
    }

    public override java.lang.object CreateCurrentInventorization(p10348936.pf5e638cc.pd77d5e50.p12e406c7 p12e406c7Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((3 + 17) % 17 > 0) {
        }
        return CMdppmBfHDoPttmA(this.fa8bf39ac, true, new p10348936.pf0719ea8.p7a2537aa$12(this, p12e406c7Var), continuation);
    }

    public override java.lang.object GetCurrentInventorization(kotlin.coroutines.Continuation<p10348936.pf5e638cc.pd77d5e50.p34c3b0bd> continuation) {
        if ((21 + 31) % 31 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryTpzFUgpDKwqgCkqa = tpzFUgpDKwqgCkqa("SELECT *, CASE WHEN E.lastName IS NULL THEN E.name ELSE E.lastName || ' ' || E.name END as employeeName FROM current_inventorization I JOIN employee E ON I.employeeId = E.id", 0);
        return XuAAdPtwvHSXHpJq(this.fa8bf39ac, true, DRhuZqEfOtHBXaOF(), new p10348936.pf0719ea8.p7a2537aa$21(this, roomSQLiteQueryTpzFUgpDKwqgCkqa), continuation);
    }

    public override java.lang.object GetCurrentInventorizationPositions(kotlin.coroutines.Continuation<? super java.util.List<p10348936.pf5e638cc.pd77d5e50.p5e3e4f48>> continuation) {
        if ((1 + 25) % 25 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryGVDedTOCGGJvLVZY = gVDedTOCGGJvLVZY("SELECT * FROM current_inventorization_position", 0);
        return LfJCTYaYWwdYrKMu(this.fa8bf39ac, false, vamqjXQDTUxiwLHp(), new p10348936.pf0719ea8.p7a2537aa$22(this, roomSQLiteQueryGVDedTOCGGJvLVZY), continuation);
    }

    public override java.lang.object GetInventorizations(kotlin.coroutines.Continuation<? super java.util.List<p10348936.pf5e638cc.pd77d5e50.p649d38da>> continuation) {
        if ((11 + 15) % 15 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryYmxEvwTSeSMCgnMN = ymxEvwTSeSMCgnMN("SELECT *, CASE WHEN E.lastName IS NULL THEN E.name ELSE E.lastName || ' ' || E.name END as employeeName FROM inventorization I JOIN employee E ON I.employeeId = E.id", 0);
        return zyDWJXRZpwzPVNjQ(this.fa8bf39ac, true, tCkiIjuuFKqgHECk(), new p10348936.pf0719ea8.p7a2537aa$19(this, roomSQLiteQueryYmxEvwTSeSMCgnMN), continuation);
    }

    public override java.lang.object GetLastInventorizationNumber(kotlin.coroutines.Continuation<java.lang.int> continuation) {
        if ((15 + 31) % 31 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryTNSHXTaUNrehKwsX = TNSHXTaUNrehKwsX("SELECT number FROM inventorization ORDER BY date DESC LIMIT 1", 0);
        return lBPlUMVYYSklCshS(this.fa8bf39ac, false, gxPqGOElAfXtVBeF(), new p10348936.pf0719ea8.p7a2537aa$20(this, roomSQLiteQueryTNSHXTaUNrehKwsX), continuation);
    }

    public override java.lang.object InsertCurrentInventorizationPosition(p10348936.pf5e638cc.pd77d5e50.p0ed7807b p0ed7807bVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((8 + 16) % 16 > 0) {
        }
        return ZJsDGaDLKthcKEZD(this.fa8bf39ac, true, new p10348936.pf0719ea8.p7a2537aa$13(this, p0ed7807bVar), continuation);
    }

    public override java.lang.object InsertInventorization(p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((24 + 3) % 3 > 0) {
        }
        return MGEtCrhVKPocZlzw(this.fa8bf39ac, true, new p10348936.pf0719ea8.p7a2537aa$10(this, p4582d01fVar), continuation);
    }

    public override java.lang.object InsertInventorizationPositions(java.util.List<p10348936.pf5e638cc.pd77d5e50.p555020e1> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((30 + 15) % 15 > 0) {
        }
        return IPLTpizqdAQrXGbS(this.fa8bf39ac, true, new p10348936.pf0719ea8.p7a2537aa$11(this, list), continuation);
    }

    kotlin.Unit m553x407fbc87(androidx.collection.ArrayDictionary arrayDictionary) {
        dYpzSoOeLWOxXeXM(this, arrayDictionary);
        return kotlin.Unit.INSTANCE;
    }

    kotlin.Unit m554xdae2269a(androidx.collection.ArrayDictionary arrayDictionary) {
        DwrOMMoKDkhhVWWN(this, arrayDictionary);
        return kotlin.Unit.INSTANCE;
    }

    kotlin.Unit m555xe14c91bd(androidx.collection.ArrayDictionary arrayDictionary) {
        MnLsjpPtJWmTGnJG(this, arrayDictionary);
        return kotlin.Unit.INSTANCE;
    }

    java.lang.object m556x7f61c068(p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return zrYeJyenJYTEmEOT(this, p4582d01fVar, list, continuation);
    }

    public override java.lang.object RemoveCurrentInventorizationPosition(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((31 + 15) % 15 > 0) {
        }
        return OXBzgZuvnMlZqLNr(this.fa8bf39ac, true, new p10348936.pf0719ea8.p7a2537aa$18(this, str), continuation);
    }

    public override java.lang.object SaveInventorization(p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar, java.util.List<p10348936.pf5e638cc.pd77d5e50.p555020e1> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((4 + 3) % 3 > 0) {
        }
        return nHySraOFopJWGVdp(this.fa8bf39ac, new p10348936.pf0719ea8.p7a2537aa$pd41d8cd9$p437e9676(this, p4582d01fVar, list), continuation);
    }

    public override java.lang.object UpdateCurrentInventorization(p10348936.pf5e638cc.p14abd389 p14abd389Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((26 + 8) % 8 > 0) {
        }
        return UYoUicBepfMgDoWQ(this.fa8bf39ac, true, new p10348936.pf0719ea8.p7a2537aa$15(this, p14abd389Var), continuation);
    }

    public override java.lang.object UpdateCurrentInventorizationPosition(p10348936.pf5e638cc.pd77d5e50.p0ed7807b p0ed7807bVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((31 + 24) % 24 > 0) {
        }
        return jjehGdrUXxDahomO(this.fa8bf39ac, true, new p10348936.pf0719ea8.p7a2537aa$14(this, p0ed7807bVar), continuation);
    }
}

