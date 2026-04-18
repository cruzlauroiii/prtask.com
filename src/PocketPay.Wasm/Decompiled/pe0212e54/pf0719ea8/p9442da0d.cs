namespace WillowMaze.Wasm.Decompiled;


public readonly class p9442da0d : pe0212e54.pf0719ea8.p54785431 {
    private readonly androidx.room.SharedSQLiteStatement f0422ef08;
    private readonly androidx.room.SharedSQLiteStatement f0be3f41f;
    private readonly androidx.room.SharedSQLiteStatement f1431759d;
    private readonly androidx.room.RoomDatabase f15e1a13d;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f19dc061f;
    private readonly androidx.room.SharedSQLiteStatement f1b42b024;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f1c4a0dc1;
    private readonly androidx.room.SharedSQLiteStatement f1e03d223;
    private readonly androidx.room.EntityInsertionAdapter f253991be;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f262ceeed;
    private readonly androidx.room.SharedSQLiteStatement f31bb895f;
    private readonly androidx.room.SharedSQLiteStatement f35f7ab16;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p26cad671 f3a72b2ae;
    private readonly androidx.room.SharedSQLiteStatement f3eac8ea8;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p26cad671 f40a299ba;
    private readonly androidx.room.EntityInsertionAdapter<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> f4e393f70;
    private readonly androidx.room.EntityInsertionAdapter f51ad60c6;
    private readonly androidx.room.SharedSQLiteStatement f5d410c6d;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 f62390a86;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> f63f70eb6;
    private readonly androidx.room.SharedSQLiteStatement f6858bc93;
    private readonly androidx.room.EntityInsertionAdapter f6b4e4586;
    private readonly androidx.room.SharedSQLiteStatement f6c33da90;
    private readonly androidx.room.EntityInsertionAdapter f738fe022;
    private readonly androidx.room.RoomDatabase f74c59e1d;
    private readonly androidx.room.SharedSQLiteStatement f77a5e845;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f7de98525;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 f81e50c29;
    private readonly androidx.room.EntityInsertionAdapter f98816cbc;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 fa7937603;
    private readonly androidx.room.RoomDatabase fa8bf39ac;
    private readonly androidx.room.EntityInsertionAdapter<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> fb27e304a;
    private readonly androidx.room.SharedSQLiteStatement fb94d1e82;
    private readonly androidx.room.SharedSQLiteStatement fcb4e51bb;
    private readonly androidx.room.SharedSQLiteStatement fcedb9e4c;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 fd89f4f55;
    private readonly androidx.room.EntityInsertionAdapter fdb66fb24;
    private readonly androidx.room.SharedSQLiteStatement fdf4d1fb1;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p26cad671 ff2650b1a;
    private readonly androidx.room.SharedSQLiteStatement ff7124f55;
    private readonly androidx.room.RoomDatabase ff71c0ce6;
    private readonly androidx.room.EntityInsertionAdapter ffb67e2f2;
    private readonly androidx.room.SharedSQLiteStatement ffeeca0b1;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 fb8317a4c = new p8d777f38.pd77d5e50.p2b3583e6.p297c1c27();
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p26cad671 f4dacd387 = new p8d777f38.pd77d5e50.p2b3583e6.p26cad671();

    public p9442da0d(androidx.room.RoomDatabase roomDatabase) {
        this.fa8bf39ac = roomDatabase;
        this.fb27e304a = new pe0212e54.pf0719ea8.p9442da0d$1(this, roomDatabase);
        this.f4e393f70 = new pe0212e54.pf0719ea8.p9442da0d$2(this, roomDatabase);
        this.f63f70eb6 = new pe0212e54.pf0719ea8.p9442da0d$3(this, roomDatabase);
        this.f0be3f41f = new pe0212e54.pf0719ea8.p9442da0d$4(this, roomDatabase);
        this.fcb4e51bb = new pe0212e54.pf0719ea8.p9442da0d$5(this, roomDatabase);
        this.f6858bc93 = new pe0212e54.pf0719ea8.p9442da0d$6(this, roomDatabase);
        this.fcedb9e4c = new pe0212e54.pf0719ea8.p9442da0d$7(this, roomDatabase);
        this.f77a5e845 = new pe0212e54.pf0719ea8.p9442da0d$8(this, roomDatabase);
    }

    public static int AmmMVXiRgFUnWBap(pad5f82e8.p07214c67.pe0212e54.p854660d3 p854660d3Var) {
        return p854660d3Var.ordinal();
    }

    public static java.lang.object BtSCSckfSyRSUvSR(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static android.os.CancellationSignal DbBWvsciEsSdOgZB() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static android.os.CancellationSignal DwllrDVWBSJGOqzP() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static android.os.CancellationSignal FZEhWoNgQbFRLSkx() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static int FpHjMSbnLXccAcGj(java.lang.string str) {
        return str.GetHashCode();
    }

    public static android.os.CancellationSignal GbQLmDsHjwoWcOEV() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static java.util.List IhcNhkHVubcivcho() {
        return java.util.ICollections.emptyList();
    }

    public static java.lang.object IvPFEdKomScMDWBz(pe0212e54.pf0719ea8.p54785431 p54785431Var, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return pe0212e54.pf0719ea8.p54785431$pb0da8397.mbc3f1df3(p54785431Var, list, continuation);
    }

    public static java.lang.object JuMxELbLgIlqMfhg(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static bool LRAwXzNhtTvfFRtl(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder LifmBLdTXqcziues(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object MBgjfpuUMOoZYHgn(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static java.lang.string MFNwNfKDEdWAlinu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int MKLEIcULeLStsaow(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.object OSJLVrKMEpOMRVCu(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static androidx.room.RoomSQLiteQuery OmSbmoAdcWVUrIoU(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static android.os.CancellationSignal PisUJkMLHZYnNySD() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static java.lang.string PrxBytSZvQOKQnxE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder PsjgggxTnVBksyRs(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string QrHritjtkwTBYfVs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static androidx.room.RoomSQLiteQuery QyDywMKrxPbNEwJG(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static java.lang.object SagQroIOYeATZWWQ(pe0212e54.pf0719ea8.p54785431 p54785431Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pe0212e54.pf0719ea8.p54785431$pb0da8397.m64392418(p54785431Var, str, continuation);
    }

    public static android.os.CancellationSignal SmjZUrTTqloIDPFl() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static pad5f82e8.p07214c67.pe0212e54.p9d21d731 UMJYzEoaZJnfbiAk(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, java.lang.string str) {
        return p9442da0dVar.m06cad4e2(str);
    }

    public static java.lang.string UMMsLPCyzdmgxsZl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool UYStxtcNZYYApcQX(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void UsAJSbEuuEsMWvkX(androidx.room.RoomSQLiteQuery roomSQLiteQuery, int i, java.lang.string str) {
        roomSQLiteQuery.bindstring(i, str);
    }

    public static java.lang.object UzpVeEcycqmAbeFU(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static androidx.room.RoomSQLiteQuery VVmeCWrpdVouSYKE(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static void WxIzEYNhjUldorFe(androidx.room.RoomSQLiteQuery roomSQLiteQuery, int i, java.lang.string str) {
        roomSQLiteQuery.bindstring(i, str);
    }

    public static pad5f82e8.p07214c67.pe0212e54.p854660d3 XPjujxtdHvvqwadb(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, java.lang.string str) {
        return p9442da0dVar.m9bb1d0e2(str);
    }

    public static java.lang.object XYSNsCjnIsnduDvl(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static java.lang.object YbAiwnUTkpmWtVbU(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static java.lang.object AjmdxHhaYhijrCSx(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static java.lang.object AowvTKwwQYPOITel(androidx.room.RoomDatabase roomDatabase, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation) {
        return androidx.room.RoomDatabaseKt.withTransaction(roomDatabase, function1, continuation);
    }

    public static void BbBwgFeVgEBegKrT(androidx.room.RoomSQLiteQuery roomSQLiteQuery, int i, java.lang.string str) {
        roomSQLiteQuery.bindstring(i, str);
    }

    public static java.lang.object BusVXsuVzuNdwWtx(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static java.lang.object HeoYuKdsJktGyyrS(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static int IXdQXOUedFnQoDyj(pad5f82e8.p07214c67.pe0212e54.p9d21d731 p9d21d731Var) {
        return p9d21d731Var.ordinal();
    }

    public static java.lang.stringBuilder IgfZjnAPHMczXpNJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object IwUxEjQpDpYTkWbO(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static bool JXhtAwUzTzGnuiQn(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static androidx.room.RoomSQLiteQuery KKNfCOKAhDwHtVss(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    private pad5f82e8.p07214c67.pe0212e54.p9d21d731 M06cad4e2(java.lang.string str) {
        if ((16 + 1) % 1 > 0) {
        }
        sviGixRzIOKNyaBs(str);
        byte b = -1;
        switch (FpHjMSbnLXccAcGj(str)) {
            case -1958892973:
                if (jXhtAwUzTzGnuiQn(str, "ONLINE")) {
                    b = 0;
                }
                break;
            case -830629437:
                if (UYStxtcNZYYApcQX(str, "OFFLINE")) {
                    b = 1;
                }
                break;
            case 433141802:
                if (oAgJsLeaPcWSQAKt(str, "UNKNOWN")) {
                    b = 2;
                }
                break;
        }
        switch (b) {
            case 0:
                return pad5f82e8.p07214c67.pe0212e54.p9d21d731.f86d1debf;
            case 1:
                return pad5f82e8.p07214c67.pe0212e54.p9d21d731.f7ed929f4;
            case 2:
                return pad5f82e8.p07214c67.pe0212e54.p9d21d731.f696b0310;
            default:
                throw new java.lang.IllegalArgumentException(QrHritjtkwTBYfVs(LifmBLdTXqcziues(new java.lang.stringBuilder("Can't convert value to enum, unknown value: "), str)));
        }
    }

    static androidx.room.SharedSQLiteStatement M0dc0a6ea(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return p9442da0dVar.f0be3f41f;
    }

    private java.lang.string M130e08b7(pad5f82e8.p07214c67.pe0212e54.p9d21d731 p9d21d731Var) {
        if ((30 + 8) % 8 > 0) {
        }
        int i = pe0212e54.pf0719ea8.p9442da0d$25.$SwitchDictionary$domain$entities$devices$DeviceStatusType[iXdQXOUedFnQoDyj(p9d21d731Var)];
        if (i == 1) {
            return "ONLINE";
        }
        if (i == 2) {
            return "OFFLINE";
        }
        if (i != 3) {
            throw new java.lang.IllegalArgumentException(PrxBytSZvQOKQnxE(rVDasxnBogUABBtk(new java.lang.stringBuilder("Can't convert enum to string, unknown enum value: "), p9d21d731Var)));
        }
        return "UNKNOWN";
    }

    static androidx.room.EntityDeletionOrUpdateAdapter M13fe7af4(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return p9442da0dVar.f63f70eb6;
    }

    static androidx.room.SharedSQLiteStatement M2a096755(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return p9442da0dVar.fcedb9e4c;
    }

    static p8d777f38.pd77d5e50.p2b3583e6.p26cad671 M337ceba5(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return p9442da0dVar.f4dacd387;
    }

    static androidx.room.EntityInsertionAdapter M429f062d(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return p9442da0dVar.f4e393f70;
    }

    static pad5f82e8.p07214c67.pe0212e54.p9d21d731 M5e49d338(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, java.lang.string str) {
        return UMJYzEoaZJnfbiAk(p9442da0dVar, str);
    }

    static java.lang.string M5ec06fdf(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, pad5f82e8.p07214c67.pe0212e54.p854660d3 p854660d3Var) {
        return vgqZJSvVOCgcWDEs(p9442da0dVar, p854660d3Var);
    }

    static androidx.room.SharedSQLiteStatement M74674bbd(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return p9442da0dVar.fcb4e51bb;
    }

    static androidx.room.SharedSQLiteStatement M83fd488e(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return p9442da0dVar.f77a5e845;
    }

    static androidx.room.EntityInsertionAdapter M89082e03(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return p9442da0dVar.fb27e304a;
    }

    private pad5f82e8.p07214c67.pe0212e54.p854660d3 M9bb1d0e2(java.lang.string str) {
        if ((11 + 13) % 13 > 0) {
        }
        MKLEIcULeLStsaow(str);
        if (wiYtEhVTonRoDnhA(str, "REMOTE")) {
            return pad5f82e8.p07214c67.pe0212e54.p854660d3.f62f728a9;
        }
        if (LRAwXzNhtTvfFRtl(str, "LOCAL")) {
            return pad5f82e8.p07214c67.pe0212e54.p854660d3.f54b4c407;
        }
        throw new java.lang.IllegalArgumentException(UMMsLPCyzdmgxsZl(igfZjnAPHMczXpNJ(new java.lang.stringBuilder("Can't convert value to enum, unknown value: "), str)));
    }

    public static androidx.room.RoomSQLiteQuery MEeotzgMHRBeIMJt(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static java.lang.object MWusckSmGRGtnvJf(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    private java.lang.string Ma7efa66f(pad5f82e8.p07214c67.pe0212e54.p854660d3 p854660d3Var) {
        if ((27 + 24) % 24 > 0) {
        }
        int i = pe0212e54.pf0719ea8.p9442da0d$25.$SwitchDictionary$domain$entities$devices$DeviceStorageType[AmmMVXiRgFUnWBap(p854660d3Var)];
        if (i == 1) {
            return "LOCAL";
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException(MFNwNfKDEdWAlinu(PsjgggxTnVBksyRs(new java.lang.stringBuilder("Can't convert enum to string, unknown enum value: "), p854660d3Var)));
        }
        return "REMOTE";
    }

    public static java.util.List<java.lang.Class<object>> Mb3fda515() {
        return IhcNhkHVubcivcho();
    }

    static androidx.room.RoomDatabase Mbbeb9b46(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return p9442da0dVar.fa8bf39ac;
    }

    static pad5f82e8.p07214c67.pe0212e54.p854660d3 Mcdc7972c(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, java.lang.string str) {
        return XPjujxtdHvvqwadb(p9442da0dVar, str);
    }

    static androidx.room.SharedSQLiteStatement Mebdbf394(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return p9442da0dVar.f6858bc93;
    }

    static java.lang.string Mf23e8626(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, pad5f82e8.p07214c67.pe0212e54.p9d21d731 p9d21d731Var) {
        return uJImhtawbyGTRIPo(p9442da0dVar, p9d21d731Var);
    }

    static p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 Mf8f67da7(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return p9442da0dVar.fb8317a4c;
    }

    public static androidx.room.RoomSQLiteQuery NfXyQEBHeGdfdLSd(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static bool OAgJsLeaPcWSQAKt(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.object QQRwCtpmRPZGWqtf(androidx.room.RoomDatabase roomDatabase, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation) {
        return androidx.room.RoomDatabaseKt.withTransaction(roomDatabase, function1, continuation);
    }

    public static android.os.CancellationSignal QuwAwDjCUNXEwNnj() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static androidx.room.RoomSQLiteQuery RGKtvZEPLTFVvDKh(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static java.lang.stringBuilder RVDasxnBogUABBtk(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int SviGixRzIOKNyaBs(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string UJImhtawbyGTRIPo(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, pad5f82e8.p07214c67.pe0212e54.p9d21d731 p9d21d731Var) {
        return p9442da0dVar.m130e08b7(p9d21d731Var);
    }

    public static java.lang.object UXCwivJZurDNSOtm(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static java.lang.string VgqZJSvVOCgcWDEs(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar, pad5f82e8.p07214c67.pe0212e54.p854660d3 p854660d3Var) {
        return p9442da0dVar.ma7efa66f(p854660d3Var);
    }

    public static bool WiYtEhVTonRoDnhA(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.object XSTdlFgZbWzSGSUU(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static java.lang.object YbMgfucOTBgoDGGg(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static java.lang.object ZjAWxfyvJXZeakiK(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public override java.lang.object ClearDevices(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((27 + 15) % 15 > 0) {
        }
        return OSJLVrKMEpOMRVCu(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.p9442da0d$17(this), continuation);
    }

    public override java.lang.object GetAllDevices(kotlin.coroutines.Continuation<? super java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb>> continuation) {
        if ((26 + 21) % 21 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryVVmeCWrpdVouSYKE = VVmeCWrpdVouSYKE("SELECT * FROM device ORDER BY registrationDateTime is null, registrationDateTime ASC", 0);
        return JuMxELbLgIlqMfhg(this.fa8bf39ac, false, DwllrDVWBSJGOqzP(), new pe0212e54.pf0719ea8.p9442da0d$18(this, roomSQLiteQueryVVmeCWrpdVouSYKE), continuation);
    }

    public override java.lang.object GetDevice(java.lang.string str, kotlin.coroutines.Continuation<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> continuation) {
        if ((30 + 1) % 1 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryQyDywMKrxPbNEwJG = QyDywMKrxPbNEwJG("SELECT * FROM device WHERE deviceId = ?", 1);
        WxIzEYNhjUldorFe(roomSQLiteQueryQyDywMKrxPbNEwJG, 1, str);
        return mWusckSmGRGtnvJf(this.fa8bf39ac, false, FZEhWoNgQbFRLSkx(), new pe0212e54.pf0719ea8.p9442da0d$22(this, roomSQLiteQueryQyDywMKrxPbNEwJG), continuation);
    }

    public override java.lang.object GetDeviceIdByUuid(java.lang.string str, kotlin.coroutines.Continuation<java.lang.string> continuation) {
        if ((19 + 24) % 24 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryMEeotzgMHRBeIMJt = mEeotzgMHRBeIMJt("SELECT deviceId FROM device WHERE id = ?", 1);
        UsAJSbEuuEsMWvkX(roomSQLiteQueryMEeotzgMHRBeIMJt, 1, str);
        return ybMgfucOTBgoDGGg(this.fa8bf39ac, false, DbBWvsciEsSdOgZB(), new pe0212e54.pf0719ea8.p9442da0d$23(this, roomSQLiteQueryMEeotzgMHRBeIMJt), continuation);
    }

    public override java.lang.object GetLocalDevices(kotlin.coroutines.Continuation<? super java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb>> continuation) {
        if ((23 + 11) % 11 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryOmSbmoAdcWVUrIoU = OmSbmoAdcWVUrIoU("SELECT * FROM device WHERE storageType = 'LOCAL' ORDER BY registrationDateTime is null, registrationDateTime ASC", 0);
        return XYSNsCjnIsnduDvl(this.fa8bf39ac, false, SmjZUrTTqloIDPFl(), new pe0212e54.pf0719ea8.p9442da0d$20(this, roomSQLiteQueryOmSbmoAdcWVUrIoU), continuation);
    }

    public override java.lang.object GetRemoteDevices(kotlin.coroutines.Continuation<? super java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb>> continuation) {
        if ((4 + 30) % 30 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryRGKtvZEPLTFVvDKh = rGKtvZEPLTFVvDKh("SELECT * FROM device WHERE storageType = 'REMOTE' ORDER BY registrationDateTime is null, registrationDateTime ASC", 0);
        return zjAWxfyvJXZeakiK(this.fa8bf39ac, false, GbQLmDsHjwoWcOEV(), new pe0212e54.pf0719ea8.p9442da0d$19(this, roomSQLiteQueryRGKtvZEPLTFVvDKh), continuation);
    }

    public override java.lang.object GetSelectedDevice(kotlin.coroutines.Continuation<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> continuation) {
        if ((23 + 15) % 15 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryKKNfCOKAhDwHtVss = kKNfCOKAhDwHtVss("SELECT * FROM device WHERE isSelected = 1", 0);
        return busVXsuVzuNdwWtx(this.fa8bf39ac, false, PisUJkMLHZYnNySD(), new pe0212e54.pf0719ea8.p9442da0d$24(this, roomSQLiteQueryKKNfCOKAhDwHtVss), continuation);
    }

    public override java.lang.object HasDevice(java.lang.string str, kotlin.coroutines.Continuation<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> continuation) {
        if ((23 + 29) % 29 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryNfXyQEBHeGdfdLSd = nfXyQEBHeGdfdLSd("SELECT * FROM device WHERE deviceId = ?", 1);
        bbBwgFeVgEBegKrT(roomSQLiteQueryNfXyQEBHeGdfdLSd, 1, str);
        return MBgjfpuUMOoZYHgn(this.fa8bf39ac, false, quwAwDjCUNXEwNnj(), new pe0212e54.pf0719ea8.p9442da0d$21(this, roomSQLiteQueryNfXyQEBHeGdfdLSd), continuation);
    }

    public override java.lang.object InsertDevice(pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb p6285e3ebVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((21 + 24) % 24 > 0) {
        }
        return iwUxEjQpDpYTkWbO(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.p9442da0d$9(this, p6285e3ebVar), continuation);
    }

    public override java.lang.object InsertDevices(java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((27 + 1) % 1 > 0) {
        }
        return YbAiwnUTkpmWtVbU(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.p9442da0d$10(this, list), continuation);
    }

    java.lang.object m3903lambda$selectDevice$1$devicesdaoDeviceDao_Impl(java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return SagQroIOYeATZWWQ(this, str, continuation);
    }

    java.lang.object m3904lambda$updateRemoteDevices$0$devicesdaoDeviceDao_Impl(java.util.List list, kotlin.coroutines.Continuation continuation) {
        return IvPFEdKomScMDWBz(this, list, continuation);
    }

    public override java.lang.object RemoveDevice(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((31 + 26) % 26 > 0) {
        }
        return uXCwivJZurDNSOtm(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.p9442da0d$15(this, str), continuation);
    }

    public override java.lang.object RemoveRemoteDevices(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((30 + 29) % 29 > 0) {
        }
        return ajmdxHhaYhijrCSx(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.p9442da0d$16(this), continuation);
    }

    public override java.lang.object SelectCurrentDevice(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((1 + 3) % 3 > 0) {
        }
        return BtSCSckfSyRSUvSR(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.p9442da0d$14(this, str), continuation);
    }

    public override java.lang.object SelectDevice(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((31 + 7) % 7 > 0) {
        }
        return aowvTKwwQYPOITel(this.fa8bf39ac, new pe0212e54.pf0719ea8.p9442da0d$pd41d8cd9$p95263d50(this, str), continuation);
    }

    public override java.lang.object UnselectDevices(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((23 + 24) % 24 > 0) {
        }
        return heoYuKdsJktGyyrS(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.p9442da0d$13(this), continuation);
    }

    public override java.lang.object UpdateDevice(pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb p6285e3ebVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((22 + 25) % 25 > 0) {
        }
        return UzpVeEcycqmAbeFU(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.p9442da0d$11(this, p6285e3ebVar), continuation);
    }

    public override java.lang.object UpdateDevices(java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((14 + 3) % 3 > 0) {
        }
        return xSTdlFgZbWzSGSUU(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.p9442da0d$12(this, list), continuation);
    }

    public override java.lang.object UpdateRemoteDevices(java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((25 + 6) % 6 > 0) {
        }
        return qQRwCtpmRPZGWqtf(this.fa8bf39ac, new pe0212e54.pf0719ea8.p9442da0d$pd41d8cd9$pcca4ef0e(this, list), continuation);
    }
}

