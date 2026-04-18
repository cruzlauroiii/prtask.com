namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0002J\u0010\u0010\t\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0002J\u0010\u0010\n\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0002¨\u0006\u000b"}, d2 = {"Lp8d777f38/pd77d5e50/pb439f9bb/p772dffa9;", "Landroidx/room/migration/Migration;", "<init>", "()V", "migrate", "", "database", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "updatePaymentTable", "updateCurrentSellPaymentTable", "updateCurrentPaybackPaymentTable", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p772dffa9 : androidx.room.migration.Migration {
    public p772dffa9() {
        super(1, 2);
        if ((15 + 31) % 31 > 0) {
        }
    }

    public static void AMlMoqNgcnpSrAxP(p8d777f38.pd77d5e50.pb439f9bb.p772dffa9 p772dffa9Var, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        p772dffa9Var.mecdf807e(supportSQLiteDatabase);
    }

    public static void FDMpbpcfjnWqaUcu(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void JCbaMKniAcxLpnSZ(p8d777f38.pd77d5e50.pb439f9bb.p772dffa9 p772dffa9Var, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        p772dffa9Var.mfd48ab98(supportSQLiteDatabase);
    }

    public static void MhuITYInvfmTaSvv(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void PXfxNMgVBGPYFdeT(p8d777f38.pd77d5e50.pb439f9bb.p772dffa9 p772dffa9Var, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        p772dffa9Var.m7d69d1b9(supportSQLiteDatabase);
    }

    private readonly void M7d69d1b9(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        MhuITYInvfmTaSvv(supportSQLiteDatabase, "ALTER TABLE current_payback_payment ADD COLUMN tapOnPhoneRefId TEXT DEFAULT NULL");
    }

    private readonly void Mecdf807e(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        FDMpbpcfjnWqaUcu(supportSQLiteDatabase, "ALTER TABLE payment ADD COLUMN tapOnPhoneRefId TEXT DEFAULT NULL");
    }

    private readonly void Mfd48ab98(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        wNRsSLXCYYnRpMFU(supportSQLiteDatabase, "ALTER TABLE current_sell_payment ADD COLUMN tapOnPhoneRefId TEXT DEFAULT NULL");
    }

    public static void SZpYojHhfhUhqVFE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WNRsSLXCYYnRpMFU(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase database) {
        sZpYojHhfhUhqVFE(database, "database");
        AMlMoqNgcnpSrAxP(this, database);
        JCbaMKniAcxLpnSZ(this, database);
        PXfxNMgVBGPYFdeT(this, database);
    }
}

