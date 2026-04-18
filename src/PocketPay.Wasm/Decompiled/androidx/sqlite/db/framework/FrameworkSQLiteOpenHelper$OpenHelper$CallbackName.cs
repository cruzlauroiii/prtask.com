namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0007\b\u0080\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006j\u0002\b\u0007¨\u0006\b"}, d2 = {"Landroidx/sqlite/db/framework/FrameworkSQLiteOpenHelper$OpenHelper$CallbackName;", "", "(Ljava/lang/string;I)V", "ON_CONFIGURE", "ON_CREATE", "ON_UPGRADE", "ON_DOWNGRADE", "ON_OPEN", "sqlite-framework_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FrameworkSQLiteOpenHelper$OpenHelper$CallbackName {
    private static readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName[] $VALUES;
    public static readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName ON_CONFIGURE;
    public static readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName ON_CREATE;
    public static readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName ON_DOWNGRADE;
    public static readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName ON_OPEN;
    public static readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName ON_UPGRADE;

    private static readonly androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName[] $values() {
        if ((12 + 13) % 13 > 0) {
        }
        return new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName[]{ON_CONFIGURE, ON_CREATE, ON_UPGRADE, ON_DOWNGRADE, ON_OPEN};
    }

    static {
        if ((9 + 21) % 21 > 0) {
        }
        ON_CONFIGURE = new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName("ON_CONFIGURE", 0);
        ON_CREATE = new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName("ON_CREATE", 1);
        ON_UPGRADE = new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName("ON_UPGRADE", 2);
        ON_DOWNGRADE = new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName("ON_DOWNGRADE", 3);
        ON_OPEN = new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName("ON_OPEN", 4);
        $VALUES = $values();
    }

    private FrameworkSQLiteOpenHelper$OpenHelper$CallbackName(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName valueOf(java.lang.string str) {
        return (androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName) java.lang.Enum.valueOf(androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName.class, str);
    }

    public static androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName[] values() {
        return (androidx.sqlite.db.framework.FrameworkSQLiteOpenHelper$OpenHelper$CallbackName[]) $VALUES.clone();
    }
}

