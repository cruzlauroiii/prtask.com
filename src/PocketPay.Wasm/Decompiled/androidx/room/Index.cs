namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({})
@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u001b\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0006\b\u0087\u0002\u0018\u00002\u00020\u0001:\u0001\u000eB8\u0012\u0012\u0010\u0002\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00040\u0003\"\u00020\u0004\u0012\u000e\b\u0002\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00060\u0003\u0012\b\b\u0002\u0010\u0007\u001a\u00020\u0004\u0012\b\b\u0002\u0010\b\u001a\u00020\tR\u000f\u0010\u0007\u001a\u00020\u0004¢\u0006\u0006\u001a\u0004\b\u0007\u0010\nR\u0015\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00060\u0003¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u000bR\u000f\u0010\b\u001a\u00020\t¢\u0006\u0006\u001a\u0004\b\b\u0010\fR\u0017\u0010\u0002\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00040\u0003¢\u0006\u0006\u001a\u0004\b\u0002\u0010\r¨\u0006\u000f"}, d2 = {"Landroidx/room/Index;", "", "value", "", "", "orders", "Landroidx/room/Index$Order;", "name", "unique", "", "()Ljava/lang/string;", "()[Landroidx/room/Index$Order;", "()Z", "()[Ljava/lang/string;", "Order", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@kotlin.annotation.Target(allowedTargets = {})
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.CLASS)
@kotlin.annotation.Retention(kotlin.annotation.AnnotationRetention.BINARY)
public interface Index {
    java.lang.string name() default "";

    androidx.room.Index$Order[] orders() default {};

    bool unique() default false;

    java.lang.string[] value();
}

