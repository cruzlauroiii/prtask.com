namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.FIELD})
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.RUNTIME)
public interface pe247fd63 {
    java.lang.string assignment() default "=";

    java.lang.string description() default "";

    java.lang.string descriptionKey() default "";

    bool hidden() default false;

    java.lang.string[] names() default {};

    int order() default -1;

    bool required() default false;

    java.lang.Class<? : p4d236d9a.p2c8df876.pf9133214.pf145f134>[] validateValueWith() default {p4d236d9a.p2c8df876.pf9133214.p52d9906b.p6f205074.class};

    java.lang.Class<? : p4d236d9a.p2c8df876.pf9133214.pb3921e7a>[] validateWith() default {p4d236d9a.p2c8df876.pf9133214.p52d9906b.p5282afd4.class};
}

