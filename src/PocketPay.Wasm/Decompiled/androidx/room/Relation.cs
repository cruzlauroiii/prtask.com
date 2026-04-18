namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.FIELD, java.lang.annotation.ElementType.METHOD})
@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u001b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0005\b\u0087\u0002\u0018\u00002\u00020\u0001B8\u0012\f\b\u0002\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0005\u0012\b\b\u0002\u0010\u0007\u001a\u00020\b\u0012\u000e\b\u0002\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00050\nR\u000f\u0010\u0007\u001a\u00020\b¢\u0006\u0006\u001a\u0004\b\u0007\u0010\u000bR\u0013\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003¢\u0006\u0006\u001a\u0004\b\u0002\u0010\fR\u000f\u0010\u0006\u001a\u00020\u0005¢\u0006\u0006\u001a\u0004\b\u0006\u0010\rR\u000f\u0010\u0004\u001a\u00020\u0005¢\u0006\u0006\u001a\u0004\b\u0004\u0010\rR\u0015\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00050\n¢\u0006\u0006\u001a\u0004\b\t\u0010\u000e¨\u0006\u000f"}, d2 = {"Landroidx/room/Relation;", "", "entity", "Lkotlin/reflect/KClass;", "parentColumn", "", "entityColumn", "associateBy", "Landroidx/room/Junction;", "projection", "", "()Landroidx/room/Junction;", "()Ljava/lang/Class;", "()Ljava/lang/string;", "()[Ljava/lang/string;", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@kotlin.annotation.Target(allowedTargets = {kotlin.annotation.AnnotationTarget.FIELD, kotlin.annotation.AnnotationTarget.FUNCTION})
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.CLASS)
@kotlin.annotation.Retention(kotlin.annotation.AnnotationRetention.BINARY)
public interface Relation {
    androidx.room.Junction associateBy() default @androidx.room.Junction(java.lang.object.class);

    java.lang.Class<object> entity() default java.lang.object.class;

    java.lang.string entityColumn();

    java.lang.string parentColumn();

    java.lang.string[] projection() default {};
}

