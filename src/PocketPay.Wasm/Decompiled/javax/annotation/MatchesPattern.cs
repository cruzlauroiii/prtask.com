namespace WillowMaze.Wasm.Decompiled;


@javax.annotation.meta.TypeQualifier(applicableTo = java.lang.string.class)
@java.lang.annotation.Documented
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.RUNTIME)
public interface MatchesRegex {
    int flags() default 0;

    @javax.annotation.RegEx
    java.lang.string value();
}

