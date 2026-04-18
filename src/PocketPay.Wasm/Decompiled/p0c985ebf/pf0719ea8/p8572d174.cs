namespace WillowMaze.Wasm.Decompiled;


public readonly class p8572d174 : p0c985ebf.pf0719ea8.p5ca98722 {
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f17f75100;
    private readonly androidx.room.SharedSQLiteStatement f1b92a4ce;
    private readonly androidx.room.EntityInsertionAdapter f1dd43ccc;
    private readonly androidx.room.EntityInsertionAdapter f20742e83;
    private readonly androidx.room.SharedSQLiteStatement f32f112e6;
    private readonly androidx.room.EntityInsertionAdapter<p0c985ebf.p07214c67.pd77d5e50.pf7c281bf> f35a8eda7;
    private readonly androidx.room.SharedSQLiteStatement f3d47d367;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f426d3047;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 f4eba725d;
    private readonly androidx.room.EntityInsertionAdapter<p0c985ebf.p07214c67.pd77d5e50.p1aa865ba> f58ecc6a4;
    private readonly androidx.room.SharedSQLiteStatement f671aeadc;
    private readonly androidx.room.RoomDatabase f6f24f6ab;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter<p0c985ebf.p07214c67.pd77d5e50.pf7c281bf> f74b60f71;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter<p0c985ebf.p07214c67.pd77d5e50.p1aa865ba> f80528cec;
    private readonly androidx.room.EntityInsertionAdapter f828df89c;
    private readonly androidx.room.SharedSQLiteStatement f8a01fa67;
    private readonly androidx.room.EntityInsertionAdapter fa35d858f;
    private readonly androidx.room.RoomDatabase fa8bf39ac;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 fa92cb57a = new p8d777f38.pd77d5e50.p2b3583e6.p35667ee1();
    private readonly androidx.room.EntityInsertionAdapter fa9799b29;
    private readonly androidx.room.EntityInsertionAdapter fc0902bf3;
    private readonly androidx.room.RoomDatabase fed8121ef;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter ffac43eca;
    private readonly androidx.room.EntityInsertionAdapter ffed88e9b;
    private readonly androidx.room.SharedSQLiteStatement fff24237f;

    public p8572d174(androidx.room.RoomDatabase roomDatabase) {
        this.fa8bf39ac = roomDatabase;
        this.f35a8eda7 = new p0c985ebf.pf0719ea8.p8572d174$1(this, roomDatabase);
        this.f58ecc6a4 = new p0c985ebf.pf0719ea8.p8572d174$2(this, roomDatabase);
        this.f74b60f71 = new p0c985ebf.pf0719ea8.p8572d174$3(this, roomDatabase);
        this.f80528cec = new p0c985ebf.pf0719ea8.p8572d174$4(this, roomDatabase);
        this.f671aeadc = new p0c985ebf.pf0719ea8.p8572d174$5(this, roomDatabase);
        this.f1b92a4ce = new p0c985ebf.pf0719ea8.p8572d174$6(this, roomDatabase);
    }

    public static pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 ATgEFiKTDiTmMKej(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, java.lang.string str) {
        return p8572d174Var.m914269ef(str);
    }

    public static bool AzUPnDCtpyFCeotv(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder BjFNjOzzCgGHbxhC() {
        return androidx.room.util.stringUtil.newstringBuilder();
    }

    public static java.lang.string CcBFZuQxnujAOMUH(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.object CqQvUXRBIElVaUaD(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static java.lang.string CzdkUBabivHvjTeE(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var) {
        return p8572d174Var.m6807eda8(pa1fa2777Var);
    }

    public static java.lang.string DIAGdIDPDfYZuftI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object DoQtquDRkGXFNxwi(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static bool EkIcoiiDopnGMhFt(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.os.CancellationSignal GpkYQotKxvCgbdXR() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static java.lang.stringBuilder HFbhofExGaYlcqgZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object HlkQSEvYXuAIKvdn(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static java.lang.string IDzOdHIBDLpZxRwm(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int JKytwCSLRxvcQUby(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder KJbhDcetwlIhUTSN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KumxbOusvzkYAxAP(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void MepOLrkqbYYxtKPW(java.lang.stringBuilder sb, int i) {
        androidx.room.util.stringUtil.appendPlaceholders(sb, i);
    }

    public static java.lang.object MgSwsbNGStDIjnKp(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static android.os.CancellationSignal NBTeDhxUHSvgKYef() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static java.lang.string OdFCKyjBpxMnskBH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object PANbmGnBqmxjtKUm(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static void PyLJjKXyQHQQLlop(androidx.room.RoomSQLiteQuery roomSQLiteQuery, int i, java.lang.string str) {
        roomSQLiteQuery.bindstring(i, str);
    }

    public static bool QcIFmCGzrgGxekty(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.string TnzwlgDjvdgguyIM(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static android.database.Cursor UUAKXfRbRKFZSPQo(androidx.room.RoomDatabase roomDatabase, androidx.sqlite.db.SupportSQLiteQuery supportSQLiteQuery, bool z, android.os.CancellationSignal cancellationSignal) {
        return androidx.room.util.DBUtil.query(roomDatabase, supportSQLiteQuery, z, cancellationSignal);
    }

    public static int UWpfdDvCeKAFLlHr(android.database.Cursor cursor, java.lang.string str) {
        return androidx.room.util.CursorUtil.getColumnIndex(cursor, str);
    }

    public static java.util.IEnumerator WXQcCtJoZfLfaPXf(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int WdNrBxtXTHxXaUZY(pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var) {
        return pa1fa2777Var.ordinal();
    }

    public static java.lang.string XMIgnOSbajVGknNk(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.stringBuilder AjbBRubtzSJTAwuG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder AuBFlqifRWzLHkfA(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool AxsjWTVhusjAEENG(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static java.lang.object BLTgesCjyZztQlWB(java.util.IEnumerator it) {
        return it.Current;
    }

    public static androidx.room.RoomSQLiteQuery CmtFyilKlgxoSYQF(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static androidx.room.RoomSQLiteQuery FEyVjLPTyELQYSFo(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static bool GTEQnnBanjtcVMfU(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static androidx.room.RoomSQLiteQuery GkaxlbqjExHxvYuJ(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static void HiIUAhkbLCvZERmd(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static bool ISMIJLVovjvPLJSv(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary.ContainsKey(obj);
    }

    public static java.lang.string IraqcBVBGWGDpPie(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.util.HashSet JJgroupSEGdRUaki(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.keyHashSet();
    }

    public static java.lang.object JgxsmbuaOJlgXojk(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static int JvbAfpGrmjUCxoGv(java.util.HashSet set) {
        return set.Count;
    }

    public static bool KRhMTFCfNAdtNtmg(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.util.List KsfnhhVrHIEYNjkE() {
        return java.util.ICollections.emptyList();
    }

    public static void KyShSHflXfhosTuG(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, androidx.collection.ArrayDictionary arrayDictionary) {
        p8572d174Var.m08f17002(arrayDictionary);
    }

    public static java.lang.string KzmGETOSdPVsEYjY(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string LznXvpxbqhLmTBnO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private void M08f17002(androidx.collection.ArrayDictionary<java.lang.string, pad5f82e8.p07214c67.pd77d5e50.pf22d65ed> arrayDictionary) {
        if ((10 + 11) % 11 > 0) {
        }
        java.util.HashSet setJJgroupSEGdRUaki = jJgroupSEGdRUaki(arrayDictionary);
        if (axsjWTVhusjAEENG(setJJgroupSEGdRUaki)) {
            return;
        }
        if (qdnFeaCnzHqVpzdi(arrayDictionary) > 999) {
            zwQYnUSPLdammtRi(arrayDictionary, false, new p0c985ebf.pf0719ea8.p8572d174$pd41d8cd9$p95263d50(this));
            return;
        }
        java.lang.stringBuilder sbBjFNjOzzCgGHbxhC = BjFNjOzzCgGHbxhC();
        HFbhofExGaYlcqgZ(sbBjFNjOzzCgGHbxhC, "SELECT `code`,`rate`,`type`,`subType`,`engName`,`arabName` FROM `tax` WHERE `code` IN (");
        int iJvbAfpGrmjUCxoGv = jvbAfpGrmjUCxoGv(setJJgroupSEGdRUaki);
        MepOLrkqbYYxtKPW(sbBjFNjOzzCgGHbxhC, iJvbAfpGrmjUCxoGv);
        ajbBRubtzSJTAwuG(sbBjFNjOzzCgGHbxhC, ")");
        androidx.room.RoomSQLiteQuery roomSQLiteQueryFEyVjLPTyELQYSFo = fEyVjLPTyELQYSFo(DIAGdIDPDfYZuftI(sbBjFNjOzzCgGHbxhC), iJvbAfpGrmjUCxoGv);
        java.util.IEnumerator itWXQcCtJoZfLfaPXf = WXQcCtJoZfLfaPXf(setJJgroupSEGdRUaki);
        int i = 1;
        while (EkIcoiiDopnGMhFt(itWXQcCtJoZfLfaPXf)) {
            PyLJjKXyQHQQLlop(roomSQLiteQueryFEyVjLPTyELQYSFo, i, (java.lang.string) bLTgesCjyZztQlWB(itWXQcCtJoZfLfaPXf));
            i++;
        }
        android.database.Cursor cursorUUAKXfRbRKFZSPQo = UUAKXfRbRKFZSPQo(this.fa8bf39ac, roomSQLiteQueryFEyVjLPTyELQYSFo, false, null);
        try {
            int iUWpfdDvCeKAFLlHr = UWpfdDvCeKAFLlHr(cursorUUAKXfRbRKFZSPQo, "code");
            if (iUWpfdDvCeKAFLlHr == -1) {
                hiIUAhkbLCvZERmd(cursorUUAKXfRbRKFZSPQo);
                return;
            }
            while (gTEQnnBanjtcVMfU(cursorUUAKXfRbRKFZSPQo)) {
                java.lang.string strIraqcBVBGWGDpPie = iraqcBVBGWGDpPie(cursorUUAKXfRbRKFZSPQo, iUWpfdDvCeKAFLlHr);
                if (iSMIJLVovjvPLJSv(arrayDictionary, strIraqcBVBGWGDpPie)) {
                    sALeofovPCEWYrBr(arrayDictionary, strIraqcBVBGWGDpPie, new pad5f82e8.p07214c67.pd77d5e50.pf22d65ed(kzmGETOSdPVsEYjY(cursorUUAKXfRbRKFZSPQo, 0), XMIgnOSbajVGknNk(cursorUUAKXfRbRKFZSPQo, 1), QcIFmCGzrgGxekty(cursorUUAKXfRbRKFZSPQo, 2) ? null : TnzwlgDjvdgguyIM(cursorUUAKXfRbRKFZSPQo, 2), rnHVpFtAGhVUHMOM(cursorUUAKXfRbRKFZSPQo, 3) ? null : IDzOdHIBDLpZxRwm(cursorUUAKXfRbRKFZSPQo, 3), ulTHelOaTHLMXqxa(cursorUUAKXfRbRKFZSPQo, 4), CcBFZuQxnujAOMUH(cursorUUAKXfRbRKFZSPQo, 5)));
                }
            }
            vsCEuLLRQqREphaZ(cursorUUAKXfRbRKFZSPQo);
        } catch (java.lang.Exception th) {
            KumxbOusvzkYAxAP(cursorUUAKXfRbRKFZSPQo);
            throw th;
        }
    }

    static androidx.room.SharedSQLiteStatement M0dc0a6ea(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p8572d174Var.f1b92a4ce;
    }

    static androidx.room.SharedSQLiteStatement M13fe7af4(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p8572d174Var.f671aeadc;
    }

    static androidx.room.RoomDatabase M337ceba5(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p8572d174Var.fa8bf39ac;
    }

    static androidx.room.EntityDeletionOrUpdateAdapter M429f062d(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p8572d174Var.f80528cec;
    }

    static androidx.room.EntityInsertionAdapter M5ec06fdf(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p8572d174Var.f35a8eda7;
    }

    private java.lang.string M6807eda8(pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var) {
        if ((9 + 31) % 31 > 0) {
        }
        int i = p0c985ebf.pf0719ea8.p8572d174$16.$SwitchDictionary$domain$entities$inventory$Type[WdNrBxtXTHxXaUZY(pa1fa2777Var)];
        if (i == 1) {
            return "NORMAL";
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException(OdFCKyjBpxMnskBH(auBFlqifRWzLHkfA(new java.lang.stringBuilder("Can't convert enum to string, unknown enum value: "), pa1fa2777Var)));
        }
        return "SERVICE";
    }

    static void M74674bbd(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, androidx.collection.ArrayDictionary arrayDictionary) {
        muqHjogHyyyVmnqY(p8572d174Var, arrayDictionary);
    }

    static androidx.room.EntityDeletionOrUpdateAdapter M89082e03(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p8572d174Var.f74b60f71;
    }

    private pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 M914269ef(java.lang.string str) {
        if ((9 + 7) % 7 > 0) {
        }
        JKytwCSLRxvcQUby(str);
        if (kRhMTFCfNAdtNtmg(str, "NORMAL")) {
            return pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777.f1e238528;
        }
        if (AzUPnDCtpyFCeotv(str, "SERVICE")) {
            return pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777.ff9e81a74;
        }
        throw new java.lang.IllegalArgumentException(lznXvpxbqhLmTBnO(KJbhDcetwlIhUTSN(new java.lang.stringBuilder("Can't convert value to enum, unknown value: "), str)));
    }

    public static java.util.List<java.lang.Class<object>> Mb3fda515() {
        return ksfnhhVrHIEYNjkE();
    }

    static androidx.room.EntityInsertionAdapter Mbbeb9b46(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p8572d174Var.f58ecc6a4;
    }

    static pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 Mebdbf394(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, java.lang.string str) {
        return ATgEFiKTDiTmMKej(p8572d174Var, str);
    }

    static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 Mf23e8626(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var) {
        return p8572d174Var.fa92cb57a;
    }

    static java.lang.string Mf8f67da7(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var) {
        return CzdkUBabivHvjTeE(p8572d174Var, pa1fa2777Var);
    }

    public static void MuqHjogHyyyVmnqY(p0c985ebf.pf0719ea8.p8572d174 p8572d174Var, androidx.collection.ArrayDictionary arrayDictionary) {
        p8572d174Var.m08f17002(arrayDictionary);
    }

    public static java.lang.object NNCAuapvnjTlPVSI(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static java.lang.object NrYOBsIaXKwFmLdD(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static int QdnFeaCnzHqVpzdi(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static java.lang.object RXJbrKnZblrSPBkz(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static bool RnHVpFtAGhVUHMOM(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.object SALeofovPCEWYrBr(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static java.lang.string UlTHelOaTHLMXqxa(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static void VsCEuLLRQqREphaZ(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void ZwQYnUSPLdammtRi(androidx.collection.ArrayDictionary arrayDictionary, bool z, kotlin.jvm.functions.Function1 function1) {
        androidx.room.util.RelationUtil.recursiveFetchArrayDictionary(arrayDictionary, z, function1);
    }

    public override java.lang.object ClearInspectedPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((4 + 25) % 25 > 0) {
        }
        return MgSwsbNGStDIjnKp(this.fa8bf39ac, true, new p0c985ebf.pf0719ea8.p8572d174$12(this), continuation);
    }

    public override java.lang.object CreateInspection(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((12 + 9) % 9 > 0) {
        }
        return PANbmGnBqmxjtKUm(this.fa8bf39ac, true, new p0c985ebf.pf0719ea8.p8572d174$7(this, pf7c281bfVar), continuation);
    }

    public override java.lang.object GetInspection(kotlin.coroutines.Continuation<p0c985ebf.p07214c67.pd77d5e50.pf7c281bf> continuation) {
        if ((15 + 32) % 32 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryGkaxlbqjExHxvYuJ = gkaxlbqjExHxvYuJ("SELECT * FROM current_inspection", 0);
        return CqQvUXRBIElVaUaD(this.fa8bf39ac, false, NBTeDhxUHSvgKYef(), new p0c985ebf.pf0719ea8.p8572d174$14(this, roomSQLiteQueryGkaxlbqjExHxvYuJ), continuation);
    }

    public override java.lang.object GetInspectionPositions(kotlin.coroutines.Continuation<? super java.util.List<p0c985ebf.p07214c67.pd77d5e50.p47704a69>> continuation) {
        if ((25 + 1) % 1 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryCmtFyilKlgxoSYQF = cmtFyilKlgxoSYQF("SELECT I.*, ifnull(C.price, '0') as commodityPrice, ifnull(C.purchasePrice, '0') as commodityPurchasePrice FROM current_inspection_position I LEFT JOIN commodity C ON I.commodityId = C.id", 0);
        return DoQtquDRkGXFNxwi(this.fa8bf39ac, false, GpkYQotKxvCgbdXR(), new p0c985ebf.pf0719ea8.p8572d174$15(this, roomSQLiteQueryCmtFyilKlgxoSYQF), continuation);
    }

    public override java.lang.object InsertInspectionPosition(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((7 + 24) % 24 > 0) {
        }
        return nNCAuapvnjTlPVSI(this.fa8bf39ac, true, new p0c985ebf.pf0719ea8.p8572d174$8(this, p1aa865baVar), continuation);
    }

    kotlin.Unit m552x18d02dbe(androidx.collection.ArrayDictionary arrayDictionary) {
        kyShSHflXfhosTuG(this, arrayDictionary);
        return kotlin.Unit.INSTANCE;
    }

    public override java.lang.object RemoveInspectedPosition(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((24 + 16) % 16 > 0) {
        }
        return rXJbrKnZblrSPBkz(this.fa8bf39ac, true, new p0c985ebf.pf0719ea8.p8572d174$13(this, str), continuation);
    }

    public override java.lang.object UpdateInspection(p0c985ebf.p07214c67.pd77d5e50.pf7c281bf pf7c281bfVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((10 + 1) % 1 > 0) {
        }
        return nrYOBsIaXKwFmLdD(this.fa8bf39ac, true, new p0c985ebf.pf0719ea8.p8572d174$9(this, pf7c281bfVar), continuation);
    }

    public override java.lang.object UpdateInspectionPosition(p0c985ebf.p07214c67.pd77d5e50.p1aa865ba p1aa865baVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((21 + 19) % 19 > 0) {
        }
        return HlkQSEvYXuAIKvdn(this.fa8bf39ac, true, new p0c985ebf.pf0719ea8.p8572d174$10(this, p1aa865baVar), continuation);
    }

    public override java.lang.object UpdateInspectionPositions(java.util.List<p0c985ebf.p07214c67.pd77d5e50.p1aa865ba> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((21 + 11) % 11 > 0) {
        }
        return jgxsmbuaOJlgXojk(this.fa8bf39ac, true, new p0c985ebf.pf0719ea8.p8572d174$11(this, list), continuation);
    }
}

