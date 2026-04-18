namespace WillowMaze.Wasm.Decompiled;


public interface pa2806f4a : java.lang.IComparable<p5a445d71.p228c1b3d.p07cc694b.pa2806f4a> {
    bool equals(java.lang.object obj);

    int get(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var);

    p5a445d71.p228c1b3d.p07cc694b.p7bf898de getChronology();

    long getMillis();

    p5a445d71.p228c1b3d.p07cc694b.p34dacb78 getZone();

    int hashCode();

    bool isAfter(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar);

    bool isBefore(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar);

    bool isEqual(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar);

    bool isSupported(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var);

    p5a445d71.p228c1b3d.p07cc694b.p54828f32 toInstant();

    java.lang.string tostring();
}

