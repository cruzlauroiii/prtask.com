namespace WillowMaze.Wasm.Decompiled;

public interface P6fb9e512
{
    bool Contains(p6fb9e512 P0);
    bool Contains(pa2806f4a P0);
    bool Equals(object P0);
    p7bf898de GetChronology();
    p8cf10d23 GetEnd();
    long GetEndMillis();
    p8cf10d23 GetStart();
    long GetStartMillis();
    int HashCode();
    bool IsAfter(p6fb9e512 P0);
    bool IsAfter(pa2806f4a P0);
    bool IsBefore(p6fb9e512 P0);
    bool IsBefore(pa2806f4a P0);
    bool Overlaps(p6fb9e512 P0);
    pe02d2ae0 ToDuration();
    long ToDurationMillis();
    pd16dd01a ToInterval();
    p1bc4e102 ToMutableInterval();
    p1901606e ToPeriod();
    p1901606e ToPeriod(p8349feac P0);
    string ToString();
}
