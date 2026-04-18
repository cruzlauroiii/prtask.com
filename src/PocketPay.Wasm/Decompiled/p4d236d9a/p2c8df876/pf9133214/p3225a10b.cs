namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Inherited
@java.lang.annotation.Target({java.lang.annotation.ElementType.TYPE})
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.RUNTIME)
public interface p3225a10b {
    java.lang.string commandDescription() default "";

    java.lang.string commandDescriptionKey() default "";

    java.lang.string[] commandNames() default {};

    bool hidden() default false;

    java.lang.string resourceDictionary<string, object>() default "";

    java.lang.string separators() default " ";
}

