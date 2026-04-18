namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.FIELD, java.lang.annotation.ElementType.METHOD})
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.RUNTIME)
public interface p83f499a5 {
    public static readonly int f1b65502d = -1;
    public static readonly int f25ad424b = -1;
    public static readonly int fafefcf2c = -1;

    int arity() default -1;

    java.lang.Class<? : com.beust.jcommander.IstringConverter<object>> converter() default p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p939ef79a.class;

    java.lang.string description() default "";

    java.lang.string descriptionKey() default "";

    bool echoInput() default false;

    bool forceNonOverwritable() default false;

    bool help() default false;

    bool hidden() default false;

    java.lang.Class<? : com.beust.jcommander.IstringConverter<object>> listConverter() default p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p939ef79a.class;

    java.lang.string[] names() default {};

    int order() default -1;

    bool password() default false;

    bool required() default false;

    java.lang.Class<? : p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p391607e7> splitter() default p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p6fcc4d16.class;

    java.lang.Class<? : p4d236d9a.p2c8df876.pf9133214.pf145f134>[] validateValueWith() default {p4d236d9a.p2c8df876.pf9133214.p52d9906b.p6f205074.class};

    java.lang.Class<? : p4d236d9a.p2c8df876.pf9133214.pb3921e7a>[] validateWith() default {p4d236d9a.p2c8df876.pf9133214.p52d9906b.p5282afd4.class};

    bool variableArity() default false;
}

