namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$17 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;

    p7a2537aa$17(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        this.this$0 = p7a2537aaVar;
    }

    public static androidx.room.SharedSQLiteStatement CQZHZPWAKAuIDKGH(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m83fd488e(p7a2537aaVar);
    }

    public static androidx.room.SharedSQLiteStatement ERwxnbvhpPonRNgR(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m83fd488e(p7a2537aaVar);
    }

    public static void HLLZUAXDpXKWuiaY(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.SharedSQLiteStatement NBrHRUtOyMToaJZr(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m83fd488e(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase SJWNQHTmfKqSgriD(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase SgERklmExRQytvYS(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.sqlite.db.SupportSQLiteStatement VBKXtGgIeQsctkWX(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static void VJeotyabSxLntADe(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.RoomDatabase YeVnRKkXPfqENPEb(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static kotlin.Unit ZONmVsRtZnCoNtSt(p10348936.pf0719ea8.p7a2537aa$17 p7a2537aa_17) {
        return p7a2537aa_17.call2();
    }

    public static void AYqrjRewGJERlzvk(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static int CpxFuqxbKPDgtMNP(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static void DfPLpGExautwHrAm(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void GvCIbmdHOxLCtRlc(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static void JzfReNxheMKPqIAL(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase TEpEDLHOWvRwqjRC(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return ZONmVsRtZnCoNtSt(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((14 + 11) % 11 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementVBKXtGgIeQsctkWX = VBKXtGgIeQsctkWX(NBrHRUtOyMToaJZr(this.this$0));
        try {
            dfPLpGExautwHrAm(YeVnRKkXPfqENPEb(this.this$0));
            try {
                cpxFuqxbKPDgtMNP(supportSQLiteStatementVBKXtGgIeQsctkWX);
                gvCIbmdHOxLCtRlc(tEpEDLHOWvRwqjRC(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                HLLZUAXDpXKWuiaY(SJWNQHTmfKqSgriD(this.this$0));
                aYqrjRewGJERlzvk(ERwxnbvhpPonRNgR(this.this$0), supportSQLiteStatementVBKXtGgIeQsctkWX);
                return unit;
            } catch (java.lang.Exception th) {
                jzfReNxheMKPqIAL(SgERklmExRQytvYS(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            VJeotyabSxLntADe(CQZHZPWAKAuIDKGH(this.this$0), supportSQLiteStatementVBKXtGgIeQsctkWX);
            throw th2;
        }
    }
}

