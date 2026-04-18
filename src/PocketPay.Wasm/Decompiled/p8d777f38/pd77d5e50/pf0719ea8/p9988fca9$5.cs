namespace WillowMaze.Wasm.Decompiled;


class p9988fca9$5 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 this$0;
    readonly java.lang.string val$deviceId;
    readonly bool val$isFirstTime;

    p9988fca9$5(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var, bool z, java.lang.string str) {
        this.this$0 = p9988fca9Var;
        this.val$isFirstTime = z;
        this.val$deviceId = str;
    }

    public static void HesvlQzeHOyNXnVj(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void LnlFWskjzvOKBles(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.SharedSQLiteStatement LuuTfvYGoylIvnws(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.m5ec06fdf(p9988fca9Var);
    }

    public static void McXyelIqlppWgIOl(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void NgEfEfutHAVXnMrK(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.RoomDatabase NqXpWzBntHDDKIHY(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static androidx.room.RoomDatabase OhOHABOUrzWSCaQX(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static void RsQZUHAQuDeMeqVa(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, long j) {
        supportSQLiteStatement.bindlong(i, j);
    }

    public static void SjusWeYRgJNMSTuG(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase VwNYrzOLCuVjhgxb(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static void KSwhPbovEJaRXYld(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement LXWGZMZBrVxByaHX(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.SharedSQLiteStatement LZwyftSDUkbpFTah(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.m5ec06fdf(p9988fca9Var);
    }

    public static int LgjGLYknKZgpsBIS(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static kotlin.Unit NROkeZhnNFPcMIIL(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9$5 p9988fca9_5) {
        return p9988fca9_5.call2();
    }

    public static androidx.room.SharedSQLiteStatement OndTaKdoMbMNSKkb(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.m5ec06fdf(p9988fca9Var);
    }

    public static androidx.room.RoomDatabase QEejIKYGlUsYaBxP(p8d777f38.pd77d5e50.pf0719ea8.p9988fca9 p9988fca9Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.p9988fca9.mf8f67da7(p9988fca9Var);
    }

    public static void UcKTHVrSJMrMgqOX(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return nROkeZhnNFPcMIIL(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((32 + 22) % 22 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementLXWGZMZBrVxByaHX = lXWGZMZBrVxByaHX(ondTaKdoMbMNSKkb(this.this$0));
        RsQZUHAQuDeMeqVa(supportSQLiteStatementLXWGZMZBrVxByaHX, 1, this.val$isFirstTime ? 1L : 0L);
        McXyelIqlppWgIOl(supportSQLiteStatementLXWGZMZBrVxByaHX, 2, this.val$deviceId);
        try {
            NgEfEfutHAVXnMrK(NqXpWzBntHDDKIHY(this.this$0));
            try {
                lgjGLYknKZgpsBIS(supportSQLiteStatementLXWGZMZBrVxByaHX);
                LnlFWskjzvOKBles(qEejIKYGlUsYaBxP(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                HesvlQzeHOyNXnVj(VwNYrzOLCuVjhgxb(this.this$0));
                ucKTHVrSJMrMgqOX(lZwyftSDUkbpFTah(this.this$0), supportSQLiteStatementLXWGZMZBrVxByaHX);
                return unit;
            } catch (java.lang.Exception th) {
                kSwhPbovEJaRXYld(OhOHABOUrzWSCaQX(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            SjusWeYRgJNMSTuG(LuuTfvYGoylIvnws(this.this$0), supportSQLiteStatementLXWGZMZBrVxByaHX);
            throw th2;
        }
    }
}

