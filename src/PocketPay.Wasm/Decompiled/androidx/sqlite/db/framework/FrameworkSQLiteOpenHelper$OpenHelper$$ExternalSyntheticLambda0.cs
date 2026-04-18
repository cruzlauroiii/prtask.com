namespace WillowMaze.Wasm.Decompiled;


public readonly class FrameworkSQLiteOpenHelper$OpenHelper$$ExternalSyntheticLambda0 : android.database.DatabaseErrorHandler {
    public readonly androidx.sqlite.db.SupportSQLiteOpenHelper$Callback f$0;
    public readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$DBRefHolder f$1;

    public FrameworkSQLiteOpenHelper$OpenHelper$$ExternalSyntheticLambda0(androidx.sqlite.db.SupportSQLiteOpenHelper$Callback supportSQLiteOpenHelper$Callback, androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$DBRefHolder frameworkSQLiteOpenHelper$DBRefHolder) {
        this.f$0 = supportSQLiteOpenHelper$Callback;
        this.f$1 = frameworkSQLiteOpenHelper$DBRefHolder;
    }

    public override readonly void OnCorruption(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper.m849$r8$lambda$HkATHkNnDWiWKR94KFirzR7ST8(this.f$0, this.f$1, sQLiteDatabase);
    }
}

