namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0002\u0010\u0004R\u001c\u0010\u0002\u001a\u0004\u0018\u00010\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0005\u0010\u0006\"\u0004\b\u0007\u0010\u0004¨\u0006\b"}, d2 = {"Landroidx/sqlite/db/framework/FrameworkSQLiteOpenHelper$DBRefHolder;", "", "db", "Landroidx/sqlite/db/framework/FrameworkSQLiteDatabase;", "(Landroidx/sqlite/db/framework/FrameworkSQLiteDatabase;)V", "getDb", "()Landroidx/sqlite/db/framework/FrameworkSQLiteDatabase;", "setDb", "sqlite-framework_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class FrameworkSQLiteOpenHelper$DBRefHolder {
    private androidx.sqlite.db.framework.FrameworkSQLiteDatabase db;

    public FrameworkSQLiteOpenHelper$DBRefHolder(androidx.sqlite.db.framework.FrameworkSQLiteDatabase frameworkSQLiteDatabase) {
        this.db = frameworkSQLiteDatabase;
    }

    public readonly androidx.sqlite.db.framework.FrameworkSQLiteDatabase GetDb() {
        return this.db;
    }

    public readonly void SetDb(androidx.sqlite.db.framework.FrameworkSQLiteDatabase frameworkSQLiteDatabase) {
        this.db = frameworkSQLiteDatabase;
    }
}

