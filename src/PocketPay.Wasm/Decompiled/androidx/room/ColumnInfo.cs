namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.FIELD, java.lang.annotation.ElementType.METHOD})
@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u001b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\t\b\u0087\u0002\u0018\u0000 \u000e2\u00020\u0001:\u0003\r\u000e\u000fB2\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0005\u0012\b\b\u0002\u0010\u0006\u001a\u00020\u0007\u0012\b\b\u0002\u0010\b\u001a\u00020\u0005\u0012\b\b\u0002\u0010\t\u001a\u00020\u0003R\u0011\u0010\b\u001a\u00020\u00058\u0007¢\u0006\u0006\u001a\u0004\b\b\u0010\nR\u000f\u0010\t\u001a\u00020\u0003¢\u0006\u0006\u001a\u0004\b\t\u0010\u000bR\u000f\u0010\u0006\u001a\u00020\u0007¢\u0006\u0006\u001a\u0004\b\u0006\u0010\fR\u000f\u0010\u0002\u001a\u00020\u0003¢\u0006\u0006\u001a\u0004\b\u0002\u0010\u000bR\u0011\u0010\u0004\u001a\u00020\u00058\u0007¢\u0006\u0006\u001a\u0004\b\u0004\u0010\n¨\u0006\u0010"}, d2 = {"Landroidx/room/ColumnInfo;", "", "name", "", "typeAffinity", "", "index", "", "collate", "defaultValue", "()I", "()Ljava/lang/string;", "()Z", "Collate", "Companion", "SQLiteTypeAffinity", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@kotlin.annotation.Target(allowedTargets = {kotlin.annotation.AnnotationTarget.FIELD, kotlin.annotation.AnnotationTarget.FUNCTION})
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.CLASS)
@kotlin.annotation.Retention(kotlin.annotation.AnnotationRetention.BINARY)
public interface ColumnInfo {
    public static readonly int BINARY = 2;
    public static readonly int BLOB = 5;
    public static readonly androidx.room.ColumnInfo$Companion Companion = androidx.room.ColumnInfo$Companion.$$INSTANCE;
    public static readonly java.lang.string INHERIT_FIELD_NAME = "[field-name]";
    public static readonly int INTEGER = 3;
    public static readonly int LOCALIZED = 5;
    public static readonly int NOCASE = 3;
    public static readonly int REAL = 4;
    public static readonly int RTRIM = 4;
    public static readonly int TEXT = 2;
    public static readonly int UNDEFINED = 1;
    public static readonly int UNICODE = 6;
    public static readonly int UNSPECIFIED = 1;
    public static readonly java.lang.string VALUE_UNSPECIFIED = "[value-unspecified]";

    int collate() default 1;

    java.lang.string defaultValue() default "[value-unspecified]";

    bool index() default false;

    java.lang.string name() default "[field-name]";

    int typeAffinity() default 1;
}

