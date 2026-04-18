namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0002J\u0010\u0010\t\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0002¨\u0006\n"}, d2 = {"Lp8d777f38/pd77d5e50/pb439f9bb/pdd1cee7a;", "Landroidx/room/migration/Migration;", "<init>", "()V", "migrate", "", "database", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "createReceiptTotalCountTable", "createReceiptobject", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pdd1cee7a : androidx.room.migration.Migration {
    public pdd1cee7a() {
        super(2, 3);
        if ((24 + 19) % 19 > 0) {
        }
    }

    public static void KsxZtuBQXBIvIHdK(p8d777f38.pd77d5e50.pb439f9bb.pdd1cee7a pdd1cee7aVar, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        pdd1cee7aVar.m296ce56c(supportSQLiteDatabase);
    }

    public static void SmzxVQoUUnKmbJKb(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    public static void ANuadKrbYWRFoRLD(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase, java.lang.string str) {
        supportSQLiteDatabase.execSQL(str);
    }

    private readonly void M296ce56c(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        SmzxVQoUUnKmbJKb(supportSQLiteDatabase, "CREATE TABLE receipt_total_count (\n    receiptTotalCountType TEXT PRIMARY KEY NOT NULL,\n    totalCount INTEGER NOT NULL\n)");
    }

    private readonly void Md647747f(androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        aNuadKrbYWRFoRLD(supportSQLiteDatabase, "CREATE VIEW `receipt_view` AS SELECT * FROM (\n    SELECT\n        SR.uuid,\n        NULL as sellReceiptUuid,\n        SR.employeeId,\n        SR.deviceId,\n        SR.clientEmail,\n        SR.clientPhone,\n        SR.paymentType,\n        SR.shouldPrintReceipt,\n        SR.operationType,\n        SR.paymentPlace,\n        SR.paymentAddress,\n        SR.receiptDiscount,\n        SR.tapOnPhoneRefId,\n        SR.extra,\n        SR.creationDateTimeTime,\n        SR.status,\n        SR.errorMessage,\n        SR.note\n    FROM sell_receipt SR\n    UNION ALL\n    SELECT\n        PR.uuid,\n        PR.sellReceiptUuid,\n        PR.employeeId,\n        PR.deviceId,\n        PR.clientEmail,\n        PR.clientPhone,\n        PR.paymentType,\n        PR.shouldPrintReceipt,\n        PR.operationType,\n        PR.paymentPlace,\n        PR.paymentAddress,\n        PR.receiptDiscount,\n        PR.tapOnPhoneRefId,\n        PR.extra,\n        PR.creationDateTimeTime,\n        PR.status,\n        PR.errorMessage,\n        PR.note\n    FROM payback_receipt PR\n)");
    }

    public static void UkTjfDUwYbPSvTrd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YIKDAkUSEnKkybFG(p8d777f38.pd77d5e50.pb439f9bb.pdd1cee7a pdd1cee7aVar, androidx.sqlite.db.SupportSQLiteDatabase supportSQLiteDatabase) {
        pdd1cee7aVar.md647747f(supportSQLiteDatabase);
    }

    public override void Migrate(androidx.sqlite.db.SupportSQLiteDatabase database) {
        ukTjfDUwYbPSvTrd(database, "database");
        KsxZtuBQXBIvIHdK(this, database);
        yIKDAkUSEnKkybFG(this, database);
    }
}

