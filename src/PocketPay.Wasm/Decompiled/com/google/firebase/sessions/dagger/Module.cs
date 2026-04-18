namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.TYPE})
@java.lang.annotation.Documented
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.RUNTIME)
public interface Module {
    java.lang.Class<object>[] includes() default {};

    java.lang.Class<object>[] subcomponents() default {};
}

