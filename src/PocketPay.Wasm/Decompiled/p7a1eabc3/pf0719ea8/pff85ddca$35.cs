namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$35 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;
    readonly java.lang.string val$groupId;

    pff85ddca$35(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, java.lang.string str) {
        this.this$0 = pff85ddcaVar;
        this.val$groupId = str;
    }

    public static void DioubJrkGEasLxNv(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void FLzuDLgdZyGbjrmo(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit IiEbwoUxJfoawpEu(p7a1eabc3.pf0719ea8.pff85ddca$35 pff85ddca_35) {
        return pff85ddca_35.call2();
    }

    public static androidx.room.SharedSQLiteStatement KFdpuUOjsvhpWbrX(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m74faefcd(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase MaOYMqNqoWdUSShi(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void NIBPqunJmZowLZiI(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void OBXdQPrIxoXAzkSf(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static int ORciJLqiCrbuCnGN(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement RisfdHOdeHpkVsWv(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static androidx.room.RoomDatabase AljXwlOSFFaZYpTU(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void EdYjZbIurMfcqmvg(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase GMfolYuQyZzpMLDZ(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void IgjPMboPZaLCTeez(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.SharedSQLiteStatement PHxlqMzDEVOMAgNx(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m74faefcd(pff85ddcaVar);
    }

    public static androidx.room.RoomDatabase PqLlMJMjZNUHyPpa(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m5ec06fdf(pff85ddcaVar);
    }

    public static void TGKdeUbggGvoNrpZ(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.SharedSQLiteStatement UXKrzeADDINxeBBi(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar) {
        return p7a1eabc3.pf0719ea8.pff85ddca.m74faefcd(pff85ddcaVar);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return IiEbwoUxJfoawpEu(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((29 + 7) % 7 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementRisfdHOdeHpkVsWv = RisfdHOdeHpkVsWv(uXKrzeADDINxeBBi(this.this$0));
        DioubJrkGEasLxNv(supportSQLiteStatementRisfdHOdeHpkVsWv, 1, this.val$groupId);
        try {
            tGKdeUbggGvoNrpZ(aljXwlOSFFaZYpTU(this.this$0));
            try {
                ORciJLqiCrbuCnGN(supportSQLiteStatementRisfdHOdeHpkVsWv);
                NIBPqunJmZowLZiI(pqLlMJMjZNUHyPpa(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                edYjZbIurMfcqmvg(gMfolYuQyZzpMLDZ(this.this$0));
                igjPMboPZaLCTeez(pHxlqMzDEVOMAgNx(this.this$0), supportSQLiteStatementRisfdHOdeHpkVsWv);
                return unit;
            } catch (java.lang.Exception th) {
                FLzuDLgdZyGbjrmo(MaOYMqNqoWdUSShi(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            OBXdQPrIxoXAzkSf(KFdpuUOjsvhpWbrX(this.this$0), supportSQLiteStatementRisfdHOdeHpkVsWv);
            throw th2;
        }
    }
}

