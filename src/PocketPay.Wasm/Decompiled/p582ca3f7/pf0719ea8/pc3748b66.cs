namespace WillowMaze.Wasm.Decompiled;


public readonly class pc3748b66 : p582ca3f7.pf0719ea8.p54b2feb4 {
    private readonly androidx.room.RoomDatabase f06068726;
    private readonly androidx.room.SharedSQLiteStatement f3b043c33;
    private readonly androidx.room.EntityInsertionAdapter f4f7fdec9;
    private readonly androidx.room.EntityInsertionAdapter<p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49> f6842c3be;
    private readonly androidx.room.EntityInsertionAdapter f74a5fbbc;
    private readonly androidx.room.SharedSQLiteStatement f7ba8b510;
    private readonly androidx.room.RoomDatabase fa8bf39ac;
    private readonly androidx.room.SharedSQLiteStatement faf7fa2a1;
    private readonly androidx.room.SharedSQLiteStatement fb32e0787;
    private readonly androidx.room.RoomDatabase fb9b46d68;
    private readonly androidx.room.EntityInsertionAdapter fc9f8b0ed;
    private readonly androidx.room.SharedSQLiteStatement fdc15902f;

    public pc3748b66(androidx.room.RoomDatabase roomDatabase) {
        this.fa8bf39ac = roomDatabase;
        this.f6842c3be = new p582ca3f7.pf0719ea8.pc3748b66$1(this, roomDatabase);
        this.f7ba8b510 = new p582ca3f7.pf0719ea8.pc3748b66$2(this, roomDatabase);
    }

    public static bool DshynrviXdTvoRPC(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.object JiXTTSqmGORgRsIw(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static int VnwOSVRWcYpbjrmO(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.util.List XUbqBUiEzmbAwZEL() {
        return java.util.ICollections.emptyList();
    }

    public static android.os.CancellationSignal XmpOzpWWnVPvJCmE() {
        return androidx.room.util.DBUtil.createCancellationSignal();
    }

    public static int YyOwdyfHTNpFrGym(pad5f82e8.p07214c67.pfa547353.p34fb9cfc p34fb9cfcVar) {
        return p34fb9cfcVar.ordinal();
    }

    public static androidx.room.RoomSQLiteQuery AApxfvJrdyQERzOm(java.lang.string str, int i) {
        return androidx.room.RoomSQLiteQuery.acquire(str, i);
    }

    public static java.lang.stringBuilder AtSlKpgMpkMnnubW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static pad5f82e8.p07214c67.pfa547353.p34fb9cfc BFMPFxRULvlGWkkC(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var, java.lang.string str) {
        return pc3748b66Var.m5ad3a7ee(str);
    }

    public static bool BVLuatxZMMpknapA(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.object JFUuZOcoWUAepIuY(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, callable, continuation);
    }

    public static java.lang.string KBXZUHPbZSxOIFZE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static androidx.room.EntityInsertionAdapter M337ceba5(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return pc3748b66Var.f6842c3be;
    }

    private java.lang.string M3aa9448a(pad5f82e8.p07214c67.pfa547353.p34fb9cfc p34fb9cfcVar) {
        if ((17 + 22) % 22 > 0) {
        }
        int i = p582ca3f7.pf0719ea8.pc3748b66$6.$SwitchDictionary$domain$entities$employee$EmployeeRole[YyOwdyfHTNpFrGym(p34fb9cfcVar)];
        if (i == 1) {
            return "CASHIER";
        }
        if (i == 2) {
            return "ADMIN";
        }
        if (i != 3) {
            throw new java.lang.IllegalArgumentException(kBXZUHPbZSxOIFZE(poOiUuPbvcPVdSWQ(new java.lang.stringBuilder("Can't convert enum to string, unknown enum value: "), p34fb9cfcVar)));
        }
        return "PERSONAL";
    }

    private pad5f82e8.p07214c67.pfa547353.p34fb9cfc M5ad3a7ee(java.lang.string str) {
        if ((30 + 9) % 9 > 0) {
        }
        VnwOSVRWcYpbjrmO(str);
        byte b = -1;
        switch (nORJmODwmkOBsdOI(str)) {
            case 62130991:
                if (DshynrviXdTvoRPC(str, "ADMIN")) {
                    b = 0;
                }
                break;
            case 1225791040:
                if (bVLuatxZMMpknapA(str, "PERSONAL")) {
                    b = 1;
                }
                break;
            case 1272968867:
                if (zdmJNNkoljSxEUyk(str, "CASHIER")) {
                    b = 2;
                }
                break;
        }
        switch (b) {
            case 0:
                return pad5f82e8.p07214c67.pfa547353.p34fb9cfc.f73acd9a5;
            case 1:
                return pad5f82e8.p07214c67.pfa547353.p34fb9cfc.fcfcf2719;
            case 2:
                return pad5f82e8.p07214c67.pfa547353.p34fb9cfc.f8304dc30;
            default:
                throw new java.lang.IllegalArgumentException(pNeWmxtTVgxlYDQe(atSlKpgMpkMnnubW(new java.lang.stringBuilder("Can't convert value to enum, unknown value: "), str)));
        }
    }

    static androidx.room.SharedSQLiteStatement M5ec06fdf(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return pc3748b66Var.f7ba8b510;
    }

    public static java.lang.object MGkeoBfjdAHtDyoT(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func callable, kotlin.coroutines.Continuation continuation) {
        return androidx.room.CoroutinesRoom.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    public static java.util.List<java.lang.Class<object>> Mb3fda515() {
        return XUbqBUiEzmbAwZEL();
    }

    static pad5f82e8.p07214c67.pfa547353.p34fb9cfc Mbbeb9b46(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var, java.lang.string str) {
        return bFMPFxRULvlGWkkC(pc3748b66Var, str);
    }

    static java.lang.string Mf23e8626(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var, pad5f82e8.p07214c67.pfa547353.p34fb9cfc p34fb9cfcVar) {
        return ngJWzGibShYTZppt(pc3748b66Var, p34fb9cfcVar);
    }

    static androidx.room.RoomDatabase Mf8f67da7(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return pc3748b66Var.fa8bf39ac;
    }

    public static int NORJmODwmkOBsdOI(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string NgJWzGibShYTZppt(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var, pad5f82e8.p07214c67.pfa547353.p34fb9cfc p34fb9cfcVar) {
        return pc3748b66Var.m3aa9448a(p34fb9cfcVar);
    }

    public static java.lang.string PNeWmxtTVgxlYDQe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object PjevvxGHxJpOlQif(p582ca3f7.pf0719ea8.p54b2feb4 p54b2feb4Var, p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49 p3bdc8a49Var, kotlin.coroutines.Continuation continuation) {
        return p582ca3f7.pf0719ea8.p54b2feb4$pb0da8397.mf2fcad63(p54b2feb4Var, p3bdc8a49Var, continuation);
    }

    public static java.lang.stringBuilder PoOiUuPbvcPVdSWQ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object XfLnVjVFeGyBanUW(androidx.room.RoomDatabase roomDatabase, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation) {
        return androidx.room.RoomDatabaseKt.withTransaction(roomDatabase, function1, continuation);
    }

    public static bool ZdmJNNkoljSxEUyk(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public override java.lang.object ClearEmployees(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((30 + 18) % 18 > 0) {
        }
        return JiXTTSqmGORgRsIw(this.fa8bf39ac, true, new p582ca3f7.pf0719ea8.pc3748b66$4(this), continuation);
    }

    public override java.lang.object GetSelectedEmployee(kotlin.coroutines.Continuation<p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49> continuation) {
        if ((24 + 10) % 10 > 0) {
        }
        androidx.room.RoomSQLiteQuery roomSQLiteQueryAApxfvJrdyQERzOm = aApxfvJrdyQERzOm("SELECT * FROM employee WHERE isSelected = 1", 0);
        return mGkeoBfjdAHtDyoT(this.fa8bf39ac, false, XmpOzpWWnVPvJCmE(), new p582ca3f7.pf0719ea8.pc3748b66$5(this, roomSQLiteQueryAApxfvJrdyQERzOm), continuation);
    }

    java.lang.object m3724lambda$selectEmployee$0$employeesdaoEmployeeDao_Impl(p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49 p3bdc8a49Var, kotlin.coroutines.Continuation continuation) {
        return pjevvxGHxJpOlQif(this, p3bdc8a49Var, continuation);
    }

    public override java.lang.object SelectCurrentEmployee(p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49 p3bdc8a49Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((30 + 17) % 17 > 0) {
        }
        return jFUuZOcoWUAepIuY(this.fa8bf39ac, true, new p582ca3f7.pf0719ea8.pc3748b66$3(this, p3bdc8a49Var), continuation);
    }

    public override java.lang.object SelectEmployee(p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49 p3bdc8a49Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((19 + 15) % 15 > 0) {
        }
        return xfLnVjVFeGyBanUW(this.fa8bf39ac, new p582ca3f7.pf0719ea8.pc3748b66$pd41d8cd9$p95263d50(this, p3bdc8a49Var), continuation);
    }
}

