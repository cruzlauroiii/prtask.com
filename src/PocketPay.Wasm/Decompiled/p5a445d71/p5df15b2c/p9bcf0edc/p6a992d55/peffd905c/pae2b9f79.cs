namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Target({java.lang.annotation.ElementType.METHOD, java.lang.annotation.ElementType.CONSTRUCTOR})
@p5a445d71.p5df15b2c.p756457dc.peffd905c.pd1bb8d00(qualifier = p5a445d71.p5df15b2c.p9bcf0edc.p6a992d55.peffd905c.p8e081f69.class)
@p5a445d71.p5df15b2c.p756457dc.peffd905c.p4c9eb976
@java.lang.annotation.Documented
@java.lang.annotation.Repeatable(p5a445d71.p5df15b2c.p9bcf0edc.p6a992d55.peffd905c.pae2b9f79$p4ee29ca1.class)
@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.RUNTIME)
public interface pae2b9f79 {
    java.lang.string[] expression();

    @p5a445d71.p5df15b2c.p756457dc.peffd905c.p73622c2c
    @p5a445d71.p5df15b2c.p756457dc.peffd905c.p20117890("offset")
    java.lang.string[] offset() default {};

    bool result();

    @p5a445d71.p5df15b2c.p756457dc.peffd905c.p73622c2c
    @p5a445d71.p5df15b2c.p756457dc.peffd905c.p20117890("value")
    java.lang.string[] targetValue();
}

