namespace WillowMaze.Wasm.Decompiled;


public readonly class p9988fca9 : p8d777f38.pd77d5e50.pf0719ea8.pdc2c8d7c {
    private readonly androidx.room.SharedSQLiteStatement f2e551fcf;
    private readonly androidx.room.RoomDatabase f3a162908;
    private readonly androidx.room.EntityInsertionAdapter f4ce9d638;
    private readonly androidx.room.RoomDatabase f59898165;
    private readonly androidx.room.EntityInsertionAdapter f7989f1b1;
    private readonly androidx.room.EntityInsertionAdapter f7ab7943c;
    private readonly androidx.room.SharedSQLiteStatement f93ba7828;
    private readonly androidx.room.EntityInsertionAdapter f94b8b662;
    private readonly androidx.room.RoomDatabase fa8bf39ac;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 fa92cb57a = new p8d777f38.pd77d5e50.p2b3583e6.p35667ee1();
    private readonly androidx.room.EntityInsertionAdapter<pad5f82e8.p07214c67.pd77d5e50.p985d1fa1> fc0f1ffd0;
    private readonly androidx.room.SharedSQLiteStatement fc5e1e377;
    private readonly androidx.room.SharedSQLiteStatement fed12b836;
    private readonly p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 ffaaf0638;
    private readonly androidx.room.SharedSQLiteStatement ffbd37229;

    public p9988fca9(androidx.room.RoomDatabase roomDatabase) {
        this.fa8bf39ac = roomDatabase;
        this.fc0f1ffd0 = new p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$1(this, roomDatabase);
        this.fc5e1e377 = new p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$2(this, roomDatabase);
        this.f2e551fcf = new p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$3(this, roomDatabase);
    }

    public static java.lang.object CcYLuGWKdaOxUhga(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static void HRARSrNspOYAosVw(androidx.room.RoomSQLiteQuery roomSQLiteQuery, int i, java.lang.string str) {
        roomSQLiteQuery.bindstring(i, str);
    }

    public static java.util.List LbYQHfMbobQVDMKu() {
        return java.util.ICollections.emptyList();
    }

    public static androidx.room.RoomSQLiteQuery RDbmxMJohFmLdqme(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static java.lang.object TkbXCBnYZMiBajFP(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static void XjgBKmYUKpsLeplQ(androidx.room.RoomSQLiteQuery roomSQLiteQuery, int i, java.lang.string str) {
        roomSQLiteQuery.bindstring(i, str);
    }

    public static android.os.CancellationSignal ZJDBuTegypRnZdAL() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static android.os.CancellationSignal ArXQJAZTEcjDIqJM() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static java.lang.object IvrJwGqxbRKRmUKB(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    static androidx.room.EntityInsertionAdapter M337ceba5(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p9988fca9Var.fc0f1ffd0;
    }

    static androidx.room.SharedSQLiteStatement M5ec06fdf(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p9988fca9Var.fc5e1e377;
    }

    public static java.util.List<java.lang.Class<object>> Mb3fda515() {
        return LbYQHfMbobQVDMKu();
    }

    static androidx.room.SharedSQLiteStatement Mbbeb9b46(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p9988fca9Var.f2e551fcf;
    }

    static p8d777f38.pd77d5e50.p2b3583e6.p35667ee1 Mf23e8626(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p9988fca9Var.fa92cb57a;
    }

    static androidx.room.RoomDatabase Mf8f67da7(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p9988fca9Var.fa8bf39ac;
    }

    public static androidx.room.RoomSQLiteQuery WJuSwpbxJzltcoPm(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static java.lang.object XGLAEnDEmgEjqynQ(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static java.lang.object ZTOfCLAZqVSNfqGQ(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public override java.lang.object GetFastSellHashSettings(java.lang.string str, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.pd77d5e50.p985d1fa1> continuation) {
        if ((29 + 27) % 27 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryWJuSwpbxJzltcoPm = wJuSwpbxJzltcoPm("SELECT * FROM fast_sell_settings WHERE deviceId = ?", 1);
        XjgBKmYUKpsLeplQ(roomSQLiteQueryWJuSwpbxJzltcoPm, 1, str);
        return xGLAEnDEmgEjqynQ(this.fa8bf39ac, false, ZJDBuTegypRnZdAL(), new p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$7(this, roomSQLiteQueryWJuSwpbxJzltcoPm), continuation);
    }

    public override java.lang.object IsFirstTimeFastSellEnabled(java.lang.string str, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        if ((5 + 20) % 20 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryRDbmxMJohFmLdqme = RDbmxMJohFmLdqme("SELECT EXISTS (SELECT 1 FROM fast_sell_settings WHERE deviceId = ? AND boardingShown = 1)", 1);
        HRARSrNspOYAosVw(roomSQLiteQueryRDbmxMJohFmLdqme, 1, str);
        return CcYLuGWKdaOxUhga(this.fa8bf39ac, false, arXQJAZTEcjDIqJM(), new p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$8(this, roomSQLiteQueryRDbmxMJohFmLdqme), continuation);
    }

    public override java.lang.object SaveFastSellHashSettings(pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((6 + 4) % 4 > 0) {
        }
        return TkbXCBnYZMiBajFP(this.fa8bf39ac, true, new p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$4(this, p985d1fa1Var), continuation);
    }

    public override java.lang.object SetFirstTimeFastSellEnabled(java.lang.string str, bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((26 + 13) % 13 > 0) {
        }
        return zTOfCLAZqVSNfqGQ(this.fa8bf39ac, true, new p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$5(this, z, str), continuation);
    }

    public override java.lang.object UpdateFastSellHashSettings(java.lang.string str, bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((12 + 27) % 27 > 0) {
        }
        return ivrJwGqxbRKRmUKB(this.fa8bf39ac, true, new p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$6(this, z, str), continuation);
    }
}

