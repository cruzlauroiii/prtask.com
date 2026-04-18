namespace WillowMaze.Wasm.Decompiled;


public interface pa5dc5f26 : p5a445d71.p9f931cf3.pca323100.p0fd1bdf1, p5a445d71.p9f931cf3.pca323100.p1e3b7dbf {
    p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 getobjectParser(int i, bool z) throws java.io.IOException;

    int getTagClass();

    int getTagNo();

    bool hasobjectTag(int i);

    bool hasTag(int i, int i2);

    p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 parseBaseUniversal(bool z, int i) throws java.io.IOException;

    p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 parseExplicitBaseobject() throws java.io.IOException;

    p5a445d71.p9f931cf3.pca323100.pa5dc5f26 parseExplicitBaseTagged() throws java.io.IOException;

    p5a445d71.p9f931cf3.pca323100.pa5dc5f26 parseImplicitBaseTagged(int i, int i2) throws java.io.IOException;
}

