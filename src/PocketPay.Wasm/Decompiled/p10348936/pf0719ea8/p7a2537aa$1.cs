namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$1 : androidx.room.EntityInsertionAdapter<p10348936.pf5e638cc.pd77d5e50.p4582d01f> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;

    p7a2537aa$1(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p7a2537aaVar;
    }

    public static java.lang.long BUJNtCdTPYdhUQEV(p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 p297c1c27Var, java.sql.Timestamp timestamp) {
        return p297c1c27Var.dateToTimestamp(timestamp);
    }

    public static void KBaAQwXcYpFHpvHc(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, long j) {
        supportSQLiteStatement.bindlong(i, j);
    }

    public static void KTzVlgTLzhNaebwh(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static long LOaGktsQLRcRBJCY(java.lang.long l) {
        if ((9 + 28) % 28 > 0) {
        }
        return l.longValue();
    }

    public static p8d777f38.pd77d5e50.p2b3583e6.p297c1c27 MLyItqQqgdvHTjSb(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mf23e8626(p7a2537aaVar);
    }

    public static java.sql.Timestamp MkRohIOQwgHyrEAx(p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar) {
        return p4582d01fVar.getDateTime();
    }

    public static void RGEWjsPShDkuUqEL(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, long j) {
        supportSQLiteStatement.bindlong(i, j);
    }

    public static java.lang.string VbReHJenmlXssirD(p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar) {
        return p4582d01fVar.getUuid();
    }

    public static java.lang.string ASDQpGdxCTvgXYdO(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, p10348936.pf5e638cc.p14abd389 p14abd389Var) {
        return p10348936.pf0719ea8.p7a2537aa.mf8f67da7(p7a2537aaVar, p14abd389Var);
    }

    public static p10348936.pf5e638cc.p14abd389 McfgsTkyYXCGzxiZ(p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar) {
        return p4582d01fVar.getStatus();
    }

    public static void NDxloGazHcLgSTsQ(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static int OxwncvxKwKPPovJN(p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar) {
        return p4582d01fVar.getNumber();
    }

    public static void RDIIhxGiMLilxFXu(p10348936.pf0719ea8.p7a2537aa$1 p7a2537aa_1, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar) {
        p7a2537aa_1.bind2(supportSQLiteStatement, p4582d01fVar);
    }

    public static void SbTczkPvCQiNsVTF(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static void TokwUvYdfzNGjPJG(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string TyhuSDJtnAIBkvfp(p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar) {
        return p4582d01fVar.getEmployeeId();
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar) {
        rDIIhxGiMLilxFXu(this, supportSQLiteStatement, p4582d01fVar);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar) {
        if ((7 + 31) % 31 > 0) {
        }
        KTzVlgTLzhNaebwh(supportSQLiteStatement, 1, VbReHJenmlXssirD(p4582d01fVar));
        RGEWjsPShDkuUqEL(supportSQLiteStatement, 2, oxwncvxKwKPPovJN(p4582d01fVar));
        java.lang.long lBUJNtCdTPYdhUQEV = BUJNtCdTPYdhUQEV(MLyItqQqgdvHTjSb(this.this$0), MkRohIOQwgHyrEAx(p4582d01fVar));
        if (lBUJNtCdTPYdhUQEV is not null) {
            KBaAQwXcYpFHpvHc(supportSQLiteStatement, 3, LOaGktsQLRcRBJCY(lBUJNtCdTPYdhUQEV));
        } else {
            sbTczkPvCQiNsVTF(supportSQLiteStatement, 3);
        }
        nDxloGazHcLgSTsQ(supportSQLiteStatement, 4, tyhuSDJtnAIBkvfp(p4582d01fVar));
        tokwUvYdfzNGjPJG(supportSQLiteStatement, 5, aSDQpGdxCTvgXYdO(this.this$0, mcfgsTkyYXCGzxiZ(p4582d01fVar)));
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR REPLACE INTO `inventorization` (`uuid`,`number`,`date`,`employeeId`,`status`) VALUES (?,?,?,?,?)";
    }
}

