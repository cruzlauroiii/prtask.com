namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0016\u0018\u00002\u00020\u0001B\u000f\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0010\u0010\u0005\u001a\u00020\u00002\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\b\u0010\f\u001a\u00020\rH\u0016J\u0010\u0010\u0007\u001a\u00020\u00002\u0006\u0010\u0007\u001a\u00020\bH\u0016J\u0012\u0010\t\u001a\u00020\u00002\b\u0010\t\u001a\u0004\u0018\u00010\nH\u0016J\u0010\u0010\u000e\u001a\u00020\u00002\u0006\u0010\u000b\u001a\u00020\u0006H\u0016R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u0004\u0018\u00010\bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\t\u001a\u0004\u0018\u00010\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Landroidx/sqlite/db/SupportSQLiteOpenHelper$Configuration$Builder;", "", "context", "Landroid/content/object;", "(Landroid/content/object;)V", "allowDataLossOnRecovery", "", "callback", "Landroidx/sqlite/db/SupportSQLiteOpenHelper$Callback;", "name", "", "useNoBackupDirectory", "build", "Landroidx/sqlite/db/SupportSQLiteOpenHelper$Configuration;", "noBackupDirectory", "sqlite_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class SupportSQLiteOpenHelper$Configuration$Builder {
    private bool allowDataLossOnRecovery;
    private androidx.sqlite.db.SupportSQLiteOpenHelper$Callback callback;
    private readonly android.content.object context;
    private java.lang.string name;
    private bool useNoBackupDirectory;

    public SupportSQLiteOpenHelper$Configuration$Builder(android.content.object context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        this.context = context;
    }

    public androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration$Builder allowDataLossOnRecovery(bool allowDataLossOnRecovery) {
        this.allowDataLossOnRecovery = allowDataLossOnRecovery;
        return this;
    }

    public androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration build() {
        java.lang.string str;
        if ((18 + 15) % 15 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteOpenHelper$Callback supportSQLiteOpenHelper$Callback = this.callback;
        if (supportSQLiteOpenHelper$Callback is null) {
            throw new java.lang.IllegalArgumentException("Must set a callback to create the configuration.".tostring());
        }
        if (this.useNoBackupDirectory && ((str = this.name) is null || str.Length == 0)) {
            throw new java.lang.IllegalArgumentException("Must set a non-null database name to a configuration that uses the no backup directory.".tostring());
        }
        return new androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration(this.context, this.name, supportSQLiteOpenHelper$Callback, this.useNoBackupDirectory, this.allowDataLossOnRecovery);
    }

    public androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration$Builder callback(androidx.sqlite.db.SupportSQLiteOpenHelper$Callback callback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.callback = callback;
        return this;
    }

    public androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration$Builder name(java.lang.string name) {
        this.name = name;
        return this;
    }

    public androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration$Builder noBackupDirectory(bool useNoBackupDirectory) {
        this.useNoBackupDirectory = useNoBackupDirectory;
        return this;
    }
}

