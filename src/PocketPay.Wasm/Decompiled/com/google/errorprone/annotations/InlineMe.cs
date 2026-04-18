namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.METHOD, java.lang.annotation.ElementType.CONSTRUCTOR})
@java.lang.annotation.Documented
public interface InlineMe {
    java.lang.string[] imports() default {};

    java.lang.string replacement();

    java.lang.string[] staticImports() default {};
}

