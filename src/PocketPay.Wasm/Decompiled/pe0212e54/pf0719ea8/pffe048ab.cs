namespace WillowMaze.Wasm.Decompiled;


public readonly class pffe048ab : pe0212e54.pf0719ea8.p3305d4f2 {
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f0da4d3c5;
    private readonly androidx.room.RoomDatabase f297f7dbb;
    private readonly androidx.room.EntityInsertionAdapter<pe0212e54.pf5e638cc.pd77d5e50.p94db0041> f467b8a1d;
    private readonly androidx.room.RoomDatabase f66df2e9d;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f7e9b15b0;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter f7f4de603;
    private readonly androidx.room.EntityInsertionAdapter f88a8f338;
    private readonly androidx.room.RoomDatabase fa8bf39ac;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter<pe0212e54.pf5e638cc.pd77d5e50.p94db0041> fb9b746cf;
    private readonly androidx.room.EntityDeletionOrUpdateAdapter fcd029bc1;
    private readonly androidx.room.RoomDatabase fe198fd90;

    public pffe048ab(androidx.room.RoomDatabase roomDatabase) {
        this.fa8bf39ac = roomDatabase;
        this.f467b8a1d = new pe0212e54.pf0719ea8.pffe048ab$1(this, roomDatabase);
        this.fb9b746cf = new pe0212e54.pf0719ea8.pffe048ab$2(this, roomDatabase);
    }

    public static java.lang.object FwlJOEeejbmDusRz(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static java.util.List CZLZtLNDtrijSCna() {
        return java.util.ICollections.emptyList();
    }

    public static java.lang.object FyZEQxTWwJxeiWHr(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static void GYbpjzNQrQyZcSPM(androidx.room.RoomSQLiteQuery roomSQLiteQuery, int i, java.lang.string str) {
        roomSQLiteQuery.bindstring(i, str);
    }

    static androidx.room.EntityDeletionOrUpdateAdapter M337ceba5(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pffe048abVar.fb9b746cf;
    }

    public static java.util.List<java.lang.Class<object>> Mb3fda515() {
        return cZLZtLNDtrijSCna();
    }

    static androidx.room.RoomDatabase Mf23e8626(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pffe048abVar.fa8bf39ac;
    }

    static androidx.room.EntityInsertionAdapter Mf8f67da7(pe0212e54.pf0719ea8.pffe048ab pffe048abVar) {
        return pffe048abVar.f467b8a1d;
    }

    public static androidx.room.RoomSQLiteQuery STjtNYGqOSLWDeoG(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static android.os.CancellationSignal UVdbuCScwglqhblq() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static java.lang.object ZCXbnPhZqfhzsjhZ(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public override java.lang.object GetDeviceStatusByDeviceId(java.lang.string str, kotlin.coroutines.Continuation<pe0212e54.pf5e638cc.pd77d5e50.p94db0041> continuation) {
        if ((16 + 3) % 3 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQuerySTjtNYGqOSLWDeoG = sTjtNYGqOSLWDeoG("SELECT * FROM device_status WHERE deviceId = ?", 1);
        gYbpjzNQrQyZcSPM(roomSQLiteQuerySTjtNYGqOSLWDeoG, 1, str);
        return zCXbnPhZqfhzsjhZ(this.fa8bf39ac, false, uVdbuCScwglqhblq(), new pe0212e54.pf0719ea8.pffe048ab$5(this, roomSQLiteQuerySTjtNYGqOSLWDeoG), continuation);
    }

    public override java.lang.object InsertDeviceStatus(pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((13 + 26) % 26 > 0) {
        }
        return fyZEQxTWwJxeiWHr(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.pffe048ab$3(this, p94db0041Var), continuation);
    }

    public override java.lang.object UpdateDeviceStatus(pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((13 + 20) % 20 > 0) {
        }
        return FwlJOEeejbmDusRz(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.pffe048ab$4(this, p94db0041Var), continuation);
    }
}

