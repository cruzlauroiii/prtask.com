namespace WillowMaze.Wasm.Decompiled;


@kotlin.annotation.MustBeDocumented
@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u001b\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\b\u0087\u0002\u0018\u0000 \u00052\u00020\u0001:\u0001\u0005B\n\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003R\u000f\u0010\u0002\u001a\u00020\u0003¢\u0006\u0006\u001a\u0004\b\u0002\u0010\u0004¨\u0006\u0006"}, d2 = {"Landroidx/annotation/VisibleForTesting;", "", "otherwise", "", "()I", "Companion", "annotation"}, m527k = 1, mv = {1, 9, 0}, xi = 48)
@java.lang.annotation.Documented
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.CLASS)
@kotlin.annotation.Retention(kotlin.annotation.AnnotationRetention.BINARY)
public interface VisibleForTesting {
    public static readonly androidx.annotation.VisibleForTesting$Companion Companion = androidx.annotation.VisibleForTesting$Companion.$$INSTANCE;
    public static readonly int NONE = 5;
    public static readonly int PACKAGE_PRIVATE = 3;
    public static readonly int PRIVATE = 2;
    public static readonly int PROTECTED = 4;

    int otherwise() default 2;
}

