namespace WillowMaze.Wasm.Decompiled;


class paf462909$1 : androidx.room.EntityInsertionAdapter<pad5f82e8.p07214c67.pd77d5e50.pa6b2262c> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;

    paf462909$1(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = paf462909Var;
    }

    public static int AicnRPclacrhZqsY(pad5f82e8.p07214c67.pd77d5e50.pa6b2262c pa6b2262cVar) {
        return pa6b2262cVar.getTotalCount();
    }

    public static java.lang.string HwsfUcsiiwfhpREs(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, pad5f82e8.p07214c67.pd77d5e50.p4446ba73 p4446ba73Var) {
        return p8d777f38.pd77d5e50.pf0719ea8.paf462909.mf23e8626(paf462909Var, p4446ba73Var);
    }

    public static void MPBnzrYxluVnnzam(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static void CNtPiXSmKpBpPXGG(p8d777f38.pd77d5e50.pf0719ea8.paf462909$1 paf462909_1, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.pa6b2262c pa6b2262cVar) {
        paf462909_1.bind2(supportSQLiteStatement, pa6b2262cVar);
    }

    public static pad5f82e8.p07214c67.pd77d5e50.p4446ba73 JThcgZRiIwBVkpIF(pad5f82e8.p07214c67.pd77d5e50.pa6b2262c pa6b2262cVar) {
        return pa6b2262cVar.getReceiptTotalCountType();
    }

    public static void WdSivqTZozkbngfC(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, long j) {
        supportSQLiteStatement.bindlong(i, j);
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.pa6b2262c pa6b2262cVar) {
        cNtPiXSmKpBpPXGG(this, supportSQLiteStatement, pa6b2262cVar);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.pa6b2262c pa6b2262cVar) {
        if ((10 + 21) % 21 > 0) {
        }
        MPBnzrYxluVnnzam(supportSQLiteStatement, 1, HwsfUcsiiwfhpREs(this.this$0, jThcgZRiIwBVkpIF(pa6b2262cVar)));
        wdSivqTZozkbngfC(supportSQLiteStatement, 2, AicnRPclacrhZqsY(pa6b2262cVar));
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR REPLACE INTO `receipt_total_count` (`receiptTotalCountType`,`totalCount`) VALUES (?,?)";
    }
}

