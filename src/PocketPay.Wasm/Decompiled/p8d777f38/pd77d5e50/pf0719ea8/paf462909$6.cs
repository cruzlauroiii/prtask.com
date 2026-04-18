namespace WillowMaze.Wasm.Decompiled;


class paf462909$6 : androidx.room.EntityInsertionAdapter<pad5f82e8.p07214c67.pd77d5e50.p25a7e996> {
    readonly p8d777f38.pd77d5e50.pf0719ea8.paf462909 this$0;

    paf462909$6(p8d777f38.pd77d5e50.pf0719ea8.paf462909 paf462909Var, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = paf462909Var;
    }

    public static void OVPGjhzkjfhLYCXC(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, long j) {
        supportSQLiteStatement.bindlong(i, j);
    }

    public static int TIMbuhPIEiscudZn(pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var) {
        return p25a7e996Var.getId();
    }

    public static void TwmcfHYdfpEixwOA(p8d777f38.pd77d5e50.pf0719ea8.paf462909$6 paf462909_6, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var) {
        paf462909_6.bind2(supportSQLiteStatement, p25a7e996Var);
    }

    public static void UEMQvKICGUHqHEdi(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, int i, java.lang.string str) {
        supportSQLiteStatement.bindstring(i, str);
    }

    public static java.lang.string YYXsLiONHBLbiJAb(pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var) {
        return p25a7e996Var.getReceiptUuid();
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var) {
        twmcfHYdfpEixwOA(this, supportSQLiteStatement, p25a7e996Var);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, pad5f82e8.p07214c67.pd77d5e50.p25a7e996 p25a7e996Var) {
        if ((32 + 12) % 12 > 0) {
        }
        OVPGjhzkjfhLYCXC(supportSQLiteStatement, 1, TIMbuhPIEiscudZn(p25a7e996Var));
        uEMQvKICGUHqHEdi(supportSQLiteStatement, 2, yYXsLiONHBLbiJAb(p25a7e996Var));
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR ABORT INTO `queue_receipt` (`id`,`receiptUuid`) VALUES (nullif(?, 0),?)";
    }
}

