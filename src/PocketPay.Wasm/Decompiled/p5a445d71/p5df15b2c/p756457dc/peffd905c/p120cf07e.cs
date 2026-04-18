namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.PACKAGE, java.lang.annotation.ElementType.TYPE, java.lang.annotation.ElementType.CONSTRUCTOR, java.lang.annotation.ElementType.METHOD, java.lang.annotation.ElementType.FIELD, java.lang.annotation.ElementType.LOCAL_VARIABLE, java.lang.annotation.ElementType.PARAMETER})
@java.lang.annotation.Documented
@java.lang.annotation.Repeatable(p5a445d71.p5df15b2c.p756457dc.peffd905c.p120cf07e$p4ee29ca1.class)
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.SOURCE)
public interface p120cf07e {
    p5a445d71.p5df15b2c.p756457dc.peffd905c.pc37d5155[] locations() default {p5a445d71.p5df15b2c.p756457dc.peffd905c.pc37d5155.ALL};

    java.lang.Class<? : java.lang.annotation.Annotation> value();
}

