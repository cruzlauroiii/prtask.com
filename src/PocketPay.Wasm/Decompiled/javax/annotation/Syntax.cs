namespace WillowMaze.Wasm.Decompiled;


@javax.annotation.meta.TypeQualifier(applicableTo = java.lang.CharSequence.class)
@java.lang.annotation.Documented
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.RUNTIME)
public interface Syntax {
    java.lang.string value();

    javax.annotation.meta.When when() default javax.annotation.meta.When.ALWAYS;
}

