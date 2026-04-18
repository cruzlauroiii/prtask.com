namespace WillowMaze.Wasm.Decompiled;


class pff85ddca$6 : androidx.room.EntityInsertionAdapter<pad5f82e8.p07214c67.pd77d5e50.pf22d65ed> {
    readonly p7a1eabc3.pf0719ea8.pff85ddca this$0;

    pff85ddca$6(p7a1eabc3.pf0719ea8.pff85ddca pff85ddcaVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = pff85ddcaVar;
    }

    public static java.lang.string BScrkxcAWdJbpoaN(pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        return pf22d65edVar.getArabName();
    }

    public static java.lang.string LBIluCFRgrgSFHhz(pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        return pf22d65edVar.getSubType();
    }

    public static java.lang.string LkLLAudVlNaLJSCc(pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        return pf22d65edVar.getType();
    }

    public static void MgZfHaVdZgIRKhrH(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void MoTLeqLatIHImlWu(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    public static void OSzMTmSlJgsRzeoq(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string SnyWxZOjqDjcWeCW(pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        return pf22d65edVar.getRate();
    }

    public static void WnsyPAFZyKchmpXC(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void XENYfkAiFupfvGdJ(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string ZATSEmEicldIzArc(pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        return pf22d65edVar.getSubType();
    }

    public static java.lang.string GjhERAqGaNGJPycj(pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        return pf22d65edVar.getEngName();
    }

    public static java.lang.string HgObtrPzjiOaMbOq(pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        return pf22d65edVar.getCode();
    }

    public static void MtVReAIkmqDRmqII(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string SBJyXXFcUmidygaK(pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        return pf22d65edVar.getType();
    }

    public static void ZJWEfaUFLMPvvNDo(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void ZXvsAUXNiDyqsEEP(p7a1eabc3.pf0719ea8.pff85ddca$6 pff85ddca_6, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        pff85ddca_6.bind2(supportSQLiteStatement, pf22d65edVar);
    }

    public static void ZtwnhpVorQSDwBNI(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i) {
        supportSQLiteStatement.bindNull(i);
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        zXvsAUXNiDyqsEEP(this, supportSQLiteStatement, pf22d65edVar);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.pf22d65ed pf22d65edVar) {
        mtVReAIkmqDRmqII(supportSQLiteStatement, 1, hgObtrPzjiOaMbOq(pf22d65edVar));
        OSzMTmSlJgsRzeoq(supportSQLiteStatement, 2, SnyWxZOjqDjcWeCW(pf22d65edVar));
        if (LkLLAudVlNaLJSCc(pf22d65edVar) is not null) {
            WnsyPAFZyKchmpXC(supportSQLiteStatement, 3, sBJyXXFcUmidygaK(pf22d65edVar));
        } else {
            MoTLeqLatIHImlWu(supportSQLiteStatement, 3);
        }
        if (LBIluCFRgrgSFHhz(pf22d65edVar) is not null) {
            zJWEfaUFLMPvvNDo(supportSQLiteStatement, 4, ZATSEmEicldIzArc(pf22d65edVar));
        } else {
            ztwnhpVorQSDwBNI(supportSQLiteStatement, 4);
        }
        XENYfkAiFupfvGdJ(supportSQLiteStatement, 5, gjhERAqGaNGJPycj(pf22d65edVar));
        MgZfHaVdZgIRKhrH(supportSQLiteStatement, 6, BScrkxcAWdJbpoaN(pf22d65edVar));
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR ABORT INTO `tax` (`code`,`rate`,`type`,`subType`,`engName`,`arabName`) VALUES (?,?,?,?,?,?)";
    }
}

