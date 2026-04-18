namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.TYPE})
@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u001b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0087\u0002\u0018\u00002\u00020\u0001BT\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\u000e\b\u0002\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005\u0012\b\b\u0002\u0010\u0007\u001a\u00020\b\u0012\u000e\b\u0002\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005\u0012\u000e\b\u0002\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u000b0\u0005\u0012\u000e\b\u0002\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005R\u0015\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u000b0\u0005¢\u0006\u0006\u001a\u0004\b\n\u0010\rR\u0015\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005¢\u0006\u0006\u001a\u0004\b\f\u0010\u000eR\u0015\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u000fR\u000f\u0010\u0007\u001a\u00020\b¢\u0006\u0006\u001a\u0004\b\u0007\u0010\u0010R\u0015\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005¢\u0006\u0006\u001a\u0004\b\t\u0010\u000eR\u000f\u0010\u0002\u001a\u00020\u0003¢\u0006\u0006\u001a\u0004\b\u0002\u0010\u0011¨\u0006\u0012"}, d2 = {"Landroidx/room/Entity;", "", "tableName", "", "indices", "", "Landroidx/room/Index;", "inheritSuperIndices", "", "primaryKeys", "foreignKeys", "Landroidx/room/ForeignKey;", "ignoredColumns", "()[Landroidx/room/ForeignKey;", "()[Ljava/lang/string;", "()[Landroidx/room/Index;", "()Z", "()Ljava/lang/string;", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@kotlin.annotation.Target(allowedTargets = {kotlin.annotation.AnnotationTarget.CLASS})
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.CLASS)
@kotlin.annotation.Retention(kotlin.annotation.AnnotationRetention.BINARY)
public interface Entity {
    androidx.room.ForeignKey[] foreignKeys() default {};

    java.lang.string[] ignoredColumns() default {};

    androidx.room.Index[] indices() default {};

    bool inheritSuperIndices() default false;

    java.lang.string[] primaryKeys() default {};

    java.lang.string tableName() default "";
}

