namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.ANNOTATION_TYPE})
@java.lang.annotation.Documented
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.CLASS)
public interface RequiredModifiers {
    com.google.errorprone.annotations.Modifier[] modifier() default {};

    @java.lang.Deprecated
    javax.lang.model.element.Modifier[] value() default {};
}

