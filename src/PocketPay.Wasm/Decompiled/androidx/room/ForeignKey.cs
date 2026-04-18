namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({})
@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u001b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0007\b\u0087\u0002\u0018\u0000 \u00122\u00020\u0001:\u0002\u0011\u0012BF\u0012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005\u0012\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005\u0012\b\b\u0002\u0010\b\u001a\u00020\t\u0012\b\b\u0002\u0010\n\u001a\u00020\t\u0012\b\b\u0002\u0010\u000b\u001a\u00020\fR\u0015\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\u0006\u001a\u0004\b\u0007\u0010\rR\u000f\u0010\u000b\u001a\u00020\f¢\u0006\u0006\u001a\u0004\b\u000b\u0010\u000eR\u0013\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003¢\u0006\u0006\u001a\u0004\b\u0002\u0010\u000fR\u0011\u0010\b\u001a\u00020\t8\u0007¢\u0006\u0006\u001a\u0004\b\b\u0010\u0010R\u0011\u0010\n\u001a\u00020\t8\u0007¢\u0006\u0006\u001a\u0004\b\n\u0010\u0010R\u0015\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\u0006\u001a\u0004\b\u0004\u0010\r¨\u0006\u0013"}, d2 = {"Landroidx/room/ForeignKey;", "", "entity", "Lkotlin/reflect/KClass;", "parentColumns", "", "", "childColumns", "onDelete", "", "onUpdate", "deferred", "", "()[Ljava/lang/string;", "()Z", "()Ljava/lang/Class;", "()I", "Action", "Companion", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@kotlin.annotation.Target(allowedTargets = {})
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.CLASS)
@kotlin.annotation.Retention(kotlin.annotation.AnnotationRetention.BINARY)
public interface ForeignKey {
    public static readonly int CASCADE = 5;
    public static readonly androidx.room.ForeignKey$Companion Companion = androidx.room.ForeignKey$Companion.$$INSTANCE;
    public static readonly int NO_ACTION = 1;
    public static readonly int RESTRICT = 2;
    public static readonly int SET_DEFAULT = 4;
    public static readonly int SET_NULL = 3;

    java.lang.string[] childColumns();

    bool deferred() default false;

    java.lang.Class<object> entity();

    int onDelete() default 1;

    int onUpdate() default 1;

    java.lang.string[] parentColumns();
}

