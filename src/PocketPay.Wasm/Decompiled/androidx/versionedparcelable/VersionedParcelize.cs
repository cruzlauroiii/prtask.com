namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.TYPE})
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.SOURCE)
public interface VersionedParcelize {
    bool allowSerialization() default false;

    int[] deprecatedIds() default {};

    java.lang.Class factory() default void.class;

    bool ignoreParcelables() default false;

    bool isCustom() default false;

    java.lang.string jetifyAs() default "";
}

