namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0018\u0010\b\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\nH\u0002¨\u0006\u000b"}, d2 = {"Lp8d777f38/pd77d5e50/pb439f9bb/p89124dee;", "Landroidx/room/migration/Migration;", "<init>", "()V", "migrate", "", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "alterPaymentTable", "tableName", "", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p89124dee : androidx.room.migration.Migration {
    public p89124dee() {
        super(9, 10);
        if ((17 + 4) % 4 > 0) {
        }
    }

    public static java.lang.stringBuilder BuLzkOnRkPEBdijI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FdKfgKxwJPdKyPAr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder KMHwRNFBfBSpxVhN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QFFoLKEsusAtHVvf(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void UVsDoQakeYVSlQqm(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void VMMrBxTLXaHCglLQ(p8d777f38.pd77d5e50.pb439f9bb.p89124dee p89124deeVar, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        p89124deeVar.mc51e0432(supportSQLiteDatabase, str);
    }

    public static java.lang.stringBuilder BaaDMSjICTeeJQzR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private readonly void Mc51e0432(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        if ((25 + 15) % 15 > 0) {
        }
        UVsDoQakeYVSlQqm(supportSQLiteDatabase, yOhKuLwAorybbLHL(KMHwRNFBfBSpxVhN(oDdAGxppurhLItjl(new java.lang.stringBuilder("ALTER TABLE "), str), " ADD COLUMN transaction_topRefUuid TEXT DEFAULT NULL")));
        QFFoLKEsusAtHVvf(supportSQLiteDatabase, zqvTZBpBYPIcUngh(BuLzkOnRkPEBdijI(tteniQroUwKpkzWj(new java.lang.stringBuilder("ALTER TABLE "), str), " ADD COLUMN transaction_terminalId TEXT DEFAULT NULL")));
        qQzuvNPNqdBuVzWh(supportSQLiteDatabase, FdKfgKxwJPdKyPAr(baaDMSjICTeeJQzR(qMCNPhobanRBPpOX(new java.lang.stringBuilder("ALTER TABLE "), str), " ADD COLUMN transaction_merchantId TEXT DEFAULT NULL")));
    }

    public static java.lang.stringBuilder ODdAGxppurhLItjl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QMCNPhobanRBPpOX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QNJuoYTRlcpQRHed(p8d777f38.pd77d5e50.pb439f9bb.p89124dee p89124deeVar, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        p89124deeVar.mc51e0432(supportSQLiteDatabase, str);
    }

    public static void QQzuvNPNqdBuVzWh(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void SOVKquDXzbiwjupt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder TteniQroUwKpkzWj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XXJhtoAsGobADZlp(p8d777f38.pd77d5e50.pb439f9bb.p89124dee p89124deeVar, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        p89124deeVar.mc51e0432(supportSQLiteDatabase, str);
    }

    public static java.lang.string YOhKuLwAorybbLHL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ZqvTZBpBYPIcUngh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase db) {
        sOVKquDXzbiwjupt(db, "db");
        xXJhtoAsGobADZlp(this, db, "payment");
        VMMrBxTLXaHCglLQ(this, db, "current_sell_payment");
        qNJuoYTRlcpQRHed(this, db, "current_payback_payment");
    }
}

