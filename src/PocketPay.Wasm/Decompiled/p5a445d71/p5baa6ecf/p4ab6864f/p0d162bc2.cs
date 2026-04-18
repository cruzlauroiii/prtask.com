namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.METHOD, java.lang.annotation.ElementType.FIELD, java.lang.annotation.ElementType.PARAMETER, java.lang.annotation.ElementType.LOCAL_VARIABLE, java.lang.annotation.ElementType.TYPE_USE})
@java.lang.annotation.Documented
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.CLASS)
public interface p0d162bc2 {
    java.lang.Class<? : java.lang.Exception> exception() default java.lang.Exception.class;

    java.lang.string value() default "";
}

