namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.FIELD, java.lang.annotation.ElementType.PARAMETER, java.lang.annotation.ElementType.LOCAL_VARIABLE, java.lang.annotation.ElementType.ANNOTATION_TYPE, java.lang.annotation.ElementType.METHOD})
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.SOURCE)
public interface pccf34704 {
    long[] flags() default {};

    java.lang.Class<object> flagsFromClass() default void.class;

    long[] intValues() default {};

    java.lang.string[] stringValues() default {};

    java.lang.Class<object> valuesFromClass() default void.class;
}

