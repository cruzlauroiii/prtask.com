namespace WillowMaze.Wasm.Decompiled;


public readonly class pea6979f9 : pe0212e54.pf0719ea8.pae06b677 {
    private readonly androidx.room.SharedSQLiteStatement f3f36a023;
    private readonly androidx.room.RoomDatabase f4057df33;
    private readonly androidx.room.RoomDatabase f4d169abf;
    private readonly androidx.room.SharedSQLiteStatement f4deb0cea;
    private readonly androidx.room.EntityInsertionAdapter f53431dbd;
    private readonly androidx.room.EntityInsertionAdapter<pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a> f70ed25be;
    private readonly androidx.room.RoomDatabase fa8bf39ac;
    private readonly androidx.room.RoomDatabase fcf0b62be;
    private readonly androidx.room.RoomDatabase fd2a9238e;

    public pea6979f9(androidx.room.RoomDatabase roomDatabase) {
        this.fa8bf39ac = roomDatabase;
        this.f70ed25be = new pe0212e54.pf0719ea8.pea6979f9$1(this, roomDatabase);
        this.f4deb0cea = new pe0212e54.pf0719ea8.pea6979f9$2(this, roomDatabase);
    }

    public static java.lang.object CaAqldLvnYuKGdMh(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static android.os.CancellationSignal IcadoWtyMUGyZHPl() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static java.lang.object KopIgvtALKUtMcHz(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static androidx.room.RoomSQLiteQuery UHhLfqAxnaGLNLRD(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    static androidx.room.SharedSQLiteStatement M337ceba5(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pea6979f9Var.f4deb0cea;
    }

    public static java.util.List<java.lang.Class<object>> Mb3fda515() {
        return xxrfbRQFPADrToRD();
    }

    static androidx.room.RoomDatabase Mf23e8626(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pea6979f9Var.fa8bf39ac;
    }

    static androidx.room.EntityInsertionAdapter Mf8f67da7(pe0212e54.pf0719ea8.pea6979f9 pea6979f9Var) {
        return pea6979f9Var.f70ed25be;
    }

    public static java.util.List XxrfbRQFPADrToRD() {
        return java.util.ICollections.emptyList();
    }

    public static java.lang.object YeJydFRfrIzMQRhi(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public override java.lang.object ClearShops(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((2 + 25) % 25 > 0) {
        }
        return KopIgvtALKUtMcHz(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.pea6979f9$4(this), continuation);
    }

    public override java.lang.object GetShops(kotlin.coroutines.Continuation<? super java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a>> continuation) {
        if ((31 + 8) % 8 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryUHhLfqAxnaGLNLRD = UHhLfqAxnaGLNLRD("SELECT * FROM shop ORDER BY name", 0);
        return CaAqldLvnYuKGdMh(this.fa8bf39ac, false, IcadoWtyMUGyZHPl(), new pe0212e54.pf0719ea8.pea6979f9$5(this, roomSQLiteQueryUHhLfqAxnaGLNLRD), continuation);
    }

    public override java.lang.object UpdateShops(java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((12 + 26) % 26 > 0) {
        }
        return yeJydFRfrIzMQRhi(this.fa8bf39ac, true, new pe0212e54.pf0719ea8.pea6979f9$3(this, list), continuation);
    }
}

