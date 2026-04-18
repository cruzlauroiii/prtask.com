namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.CONSTRUCTOR, java.lang.annotation.ElementType.METHOD})
public interface RestrictedApi {
    java.lang.string allowedOnPath() default "";

    java.lang.Class<? : java.lang.annotation.Annotation>[] allowlistAnnotations() default {};

    java.lang.Class<? : java.lang.annotation.Annotation>[] allowlistWithWarningAnnotations() default {};

    java.lang.string explanation();

    java.lang.string link() default "";
}

