namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.METHOD, java.lang.annotation.ElementType.CONSTRUCTOR})
@p5a445d71.p5df15b2c.p756457dc.peffd905c.pd1bb8d00(qualifier = p5a445d71.p5df15b2c.p9efab239.p2063c160.peffd905c.pf1754479.class)
@p5a445d71.p5df15b2c.p756457dc.peffd905c.p4c9eb976
@java.lang.annotation.Documented
@java.lang.annotation.Repeatable(p5a445d71.p5df15b2c.p9efab239.p2063c160.peffd905c.p8ef4f937$p4ee29ca1.class)
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.RUNTIME)
public interface p8ef4f937 {
    java.lang.string[] expression();

    bool result();

    @p5a445d71.p5df15b2c.p756457dc.peffd905c.p20117890("value")
    int targetValue() default 0;
}

