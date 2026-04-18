namespace WillowMaze.Wasm.Decompiled;


class pc3748b66$4 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p582ca3f7.pf0719ea8.pc3748b66 this$0;

    pc3748b66$4(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        this.this$0 = pc3748b66Var;
    }

    public static androidx.room.RoomDatabase BZbzaXoySBjwPYWP(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return p582ca3f7.pf0719ea8.pc3748b66.mf8f67da7(pc3748b66Var);
    }

    public static kotlin.Unit BixwrxMbsHjMQxBt(p582ca3f7.pf0719ea8.pc3748b66$4 pc3748b66_4) {
        return pc3748b66_4.call2();
    }

    public static androidx.room.RoomDatabase BmLLPARxtntjMwjy(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return p582ca3f7.pf0719ea8.pc3748b66.mf8f67da7(pc3748b66Var);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement GhtztsoAYLkUtrqJ(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.SharedSQLiteStatement JzilrInUoMRAAxcW(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return p582ca3f7.pf0719ea8.pc3748b66.m5ec06fdf(pc3748b66Var);
    }

    public static void KqDptLQJVyTiAGei(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void PUYBZBvIMTPDLTNO(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement XXZxjRZccvIuKJpj(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return p582ca3f7.pf0719ea8.pc3748b66.m5ec06fdf(pc3748b66Var);
    }

    public static androidx.room.RoomDatabase ZGXEjhQDlvZaluay(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return p582ca3f7.pf0719ea8.pc3748b66.mf8f67da7(pc3748b66Var);
    }

    public static int ZQIgEzxDPoBVHVkx(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static void ZydjaVwzhtLQVxbL(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.SharedSQLiteStatement PuCdRbHCePUBmwTH(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return p582ca3f7.pf0719ea8.pc3748b66.m5ec06fdf(pc3748b66Var);
    }

    public static void QBeWeQbBMGtjlfsf(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void TIgBhEVKLvlNuSie(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void TWvawtygWfcHdRPV(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase ZZBswRNnAkeBjvqL(p582ca3f7.pf0719ea8.pc3748b66 pc3748b66Var) {
        return p582ca3f7.pf0719ea8.pc3748b66.mf8f67da7(pc3748b66Var);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return BixwrxMbsHjMQxBt(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((20 + 10) % 10 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementGhtztsoAYLkUtrqJ = GhtztsoAYLkUtrqJ(JzilrInUoMRAAxcW(this.this$0));
        try {
            tIgBhEVKLvlNuSie(ZGXEjhQDlvZaluay(this.this$0));
            try {
                ZQIgEzxDPoBVHVkx(supportSQLiteStatementGhtztsoAYLkUtrqJ);
                ZydjaVwzhtLQVxbL(zZBswRNnAkeBjvqL(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                qBeWeQbBMGtjlfsf(BmLLPARxtntjMwjy(this.this$0));
                tWvawtygWfcHdRPV(XXZxjRZccvIuKJpj(this.this$0), supportSQLiteStatementGhtztsoAYLkUtrqJ);
                return unit;
            } catch (java.lang.Exception th) {
                PUYBZBvIMTPDLTNO(BZbzaXoySBjwPYWP(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            KqDptLQJVyTiAGei(puCdRbHCePUBmwTH(this.this$0), supportSQLiteStatementGhtztsoAYLkUtrqJ);
            throw th2;
        }
    }
}

