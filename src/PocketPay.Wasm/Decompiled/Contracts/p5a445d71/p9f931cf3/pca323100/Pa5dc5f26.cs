namespace WillowMaze.Wasm.Decompiled;

public interface Pa5dc5f26
{
    p0fd1bdf1 GetObjectParser(int P0, bool P1);
    int GetTagClass();
    int GetTagNo();
    bool HasContextTag(int P0);
    bool HasTag(int P0, int P1);
    p0fd1bdf1 ParseBaseUniversal(bool P0, int P1);
    p0fd1bdf1 ParseExplicitBaseObject();
    pa5dc5f26 ParseExplicitBaseTagged();
    pa5dc5f26 ParseImplicitBaseTagged(int P0, int P1);
}
