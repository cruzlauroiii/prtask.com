namespace WillowMaze.Wasm.Decompiled;

public interface Pa2806f4a
{
    bool Equals(object P0);
    int Get(p51c74e65 P0);
    p7bf898de GetChronology();
    long GetMillis();
    p34dacb78 GetZone();
    int HashCode();
    bool IsAfter(pa2806f4a P0);
    bool IsBefore(pa2806f4a P0);
    bool IsEqual(pa2806f4a P0);
    bool IsSupported(p51c74e65 P0);
    p54828f32 ToInstant();
    string ToString();
}
