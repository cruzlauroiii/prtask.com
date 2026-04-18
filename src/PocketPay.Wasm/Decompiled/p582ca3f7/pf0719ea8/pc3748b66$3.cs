namespace WillowMaze.Wasm.Decompiled;


class pc3748b66$3 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p582ca3f7.pf0719ea8.pc3748b66 this$0;
    readonly p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49 val$employee;

    pc3748b66$3(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var, p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49 p3bdc8a49Var) {
        this.this$0 = pc3748b66Var;
        this.val$employee = p3bdc8a49Var;
    }

    public static void CdshXKREveockfDm(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void DCUbwpSeCfHPecFO(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit HGPiUSPxhpXyosFr(p582ca3f7.pf0719ea8.pc3748b66$3 pc3748b66_3) {
        return pc3748b66_3.call2();
    }

    public static void NJHcUZPghbfvZKPi(androidx.room.EntityInsertionAdapter entityInsertionAdapter, java.lang.object obj) {
        entityInsertionAdapter.insert(obj);
    }

    public static androidx.room.RoomDatabase OwYSlqnqiDLGpcBD(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return p582ca3f7.pf0719ea8.pc3748b66.mf8f67da7(pc3748b66Var);
    }

    public static androidx.room.RoomDatabase YTpuWcljJdsMJRtb(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return p582ca3f7.pf0719ea8.pc3748b66.mf8f67da7(pc3748b66Var);
    }

    public static androidx.room.EntityInsertionAdapter YjGIoNJnUAxaOQFR(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return p582ca3f7.pf0719ea8.pc3748b66.m337ceba5(pc3748b66Var);
    }

    public static void ZRKAsdvpCwNBuPgf(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase PSoNHaOSmjqNApwh(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return p582ca3f7.pf0719ea8.pc3748b66.mf8f67da7(pc3748b66Var);
    }

    public static androidx.room.RoomDatabase SvYheVSQptxZQMEZ(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return p582ca3f7.pf0719ea8.pc3748b66.mf8f67da7(pc3748b66Var);
    }

    public static void YONxrHCSDzDhBDDF(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return HGPiUSPxhpXyosFr(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((29 + 28) % 28 > 0) {
        }
        yONxrHCSDzDhBDDF(YTpuWcljJdsMJRtb(this.this$0));
        try {
            NJHcUZPghbfvZKPi(YjGIoNJnUAxaOQFR(this.this$0), this.val$employee);
            ZRKAsdvpCwNBuPgf(pSoNHaOSmjqNApwh(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            DCUbwpSeCfHPecFO(svYheVSQptxZQMEZ(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            CdshXKREveockfDm(OwYSlqnqiDLGpcBD(this.this$0));
            throw th;
        }
    }
}

