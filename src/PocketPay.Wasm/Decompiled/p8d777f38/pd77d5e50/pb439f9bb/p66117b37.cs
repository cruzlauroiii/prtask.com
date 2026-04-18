namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0018\u0010\b\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\nH\u0002¨\u0006\u000b"}, d2 = {"Lp8d777f38/pd77d5e50/pb439f9bb/p66117b37;", "Landroidx/room/migration/Migration;", "<init>", "()V", "migrate", "", "db", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "alterPaymentTable", "tableName", "", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p66117b37 : androidx.room.migration.Migration {
    public p66117b37() {
        super(8, 9);
        if ((23 + 10) % 10 > 0) {
        }
    }

    public static java.lang.string AlQJZUiLMdmZCxFm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BdWkqWKXadItAWzv(p8d777f38.pd77d5e50.pb439f9bb.p66117b37 p66117b37Var, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        p66117b37Var.mc51e0432(supportSQLiteDatabase, str);
    }

    public static java.lang.stringBuilder DMNvzCCvJxhJnxph(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LOGDedmZkvQdJdKm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder QDHyDFLaZoXIqoUB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SMXJiuNEHxPADcrp(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static java.lang.stringBuilder TkYDXEwhAbyGWeyC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WPYdKvrrGAWqIyag(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static java.lang.string ZcpjNethJOVCnXrp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder BAeBErCnLSHteFji(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CzdUYgQnhxaWOdTc(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static java.lang.stringBuilder DdziQiQYzFxiJYjd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DeUirkJaFEwUqqcU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private readonly void Mc51e0432(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        if ((1 + 17) % 17 > 0) {
        }
        oseYlHpIqSPvbquz(supportSQLiteDatabase, yKVeaXHSlAqojklX(TkYDXEwhAbyGWeyC(bAeBErCnLSHteFji(new java.lang.stringBuilder("ALTER TABLE "), str), " ADD COLUMN transaction_rrn TEXT DEFAULT NULL")));
        WPYdKvrrGAWqIyag(supportSQLiteDatabase, ZcpjNethJOVCnXrp(QDHyDFLaZoXIqoUB(DMNvzCCvJxhJnxph(new java.lang.stringBuilder("ALTER TABLE "), str), " ADD COLUMN transaction_stan TEXT DEFAULT NULL")));
        SMXJiuNEHxPADcrp(supportSQLiteDatabase, AlQJZUiLMdmZCxFm(vTzvAjCSqTHuQjmr(oGaFfjsDTmAclJot(new java.lang.stringBuilder("ALTER TABLE "), str), " ADD COLUMN transaction_authCode TEXT DEFAULT NULL")));
        czdUYgQnhxaWOdTc(supportSQLiteDatabase, LOGDedmZkvQdJdKm(deUirkJaFEwUqqcU(ddziQiQYzFxiJYjd(new java.lang.stringBuilder("ALTER TABLE "), str), " ADD COLUMN transaction_responseCode TEXT DEFAULT NULL")));
    }

    public static java.lang.stringBuilder OGaFfjsDTmAclJot(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OseYlHpIqSPvbquz(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void TYyWyFUjnWypVllt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder VTzvAjCSqTHuQjmr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string YKVeaXHSlAqojklX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ZHaIGWftzJYraPGB(p8d777f38.pd77d5e50.pb439f9bb.p66117b37 p66117b37Var, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        p66117b37Var.mc51e0432(supportSQLiteDatabase, str);
    }

    public static void ZmCLSmEnoTUujkBw(p8d777f38.pd77d5e50.pb439f9bb.p66117b37 p66117b37Var, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        p66117b37Var.mc51e0432(supportSQLiteDatabase, str);
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase db) {
        tYyWyFUjnWypVllt(db, "db");
        zHaIGWftzJYraPGB(this, db, "payment");
        zmCLSmEnoTUujkBw(this, db, "current_sell_payment");
        BdWkqWKXadItAWzv(this, db, "current_payback_payment");
    }
}

