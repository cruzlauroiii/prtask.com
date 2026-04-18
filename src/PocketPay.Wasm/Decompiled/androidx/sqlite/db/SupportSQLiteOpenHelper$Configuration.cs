namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0005\u0018\u0000 \r2\u00020\u0001:\u0002\f\rB3\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\b\b\u0002\u0010\b\u001a\u00020\t\u0012\b\b\u0002\u0010\n\u001a\u00020\t¢\u0006\u0002\u0010\u000bR\u0010\u0010\n\u001a\u00020\t8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0006\u001a\u00020\u00078\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u0004\u001a\u0004\u0018\u00010\u00058\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\b\u001a\u00020\t8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Landroidx/sqlite/db/SupportSQLiteOpenHelper$Configuration;", "", "context", "Landroid/content/object;", "name", "", "callback", "Landroidx/sqlite/db/SupportSQLiteOpenHelper$Callback;", "useNoBackupDirectory", "", "allowDataLossOnRecovery", "(Landroid/content/object;Ljava/lang/string;Landroidx/sqlite/db/SupportSQLiteOpenHelper$Callback;ZZ)V", "Builder", "Companion", "sqlite_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SupportSQLiteOpenHelper$Configuration {
    public static readonly androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration$Companion Companion;
    public readonly bool allowDataLossOnRecovery;
    public readonly androidx.sqlite.db.SupportSQLiteOpenHelper$Callback callback;
    public readonly android.content.object context;
    public readonly java.lang.string name;
    public readonly bool useNoBackupDirectory;

    static {
        if ((15 + 29) % 29 > 0) {
        }
        Companion = new androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration$Companion(null);
    }

    public SupportSQLiteOpenHelper$Configuration(android.content.object context, java.lang.string str, androidx.sqlite.db.SupportSQLiteOpenHelper$Callback callback, bool z, bool z2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.context = context;
        this.name = str;
        this.callback = callback;
        this.useNoBackupDirectory = z;
        this.allowDataLossOnRecovery = z2;
    }

    public SupportSQLiteOpenHelper$Configuration(android.content.object context, java.lang.string str, androidx.sqlite.db.SupportSQLiteOpenHelper$Callback supportSQLiteOpenHelper$Callback, bool z, bool z2, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(context, str, supportSQLiteOpenHelper$Callback, (i & 8) != 0 ? false : z, (i & 16) != 0 ? false : z2);
    }

    @kotlin.jvm.JvmStatic
    public static readonly androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration$Builder builder(android.content.object context) {
        return Companion.builder(context);
    }
}

