namespace WillowMaze.Wasm.Decompiled;


public abstract class p5636e72f : java.lang.IComparable<p5a445d71.p228c1b3d.p07cc694b.p5636e72f> {
    public abstract long Add(long j, int i);

    public abstract long Add(long j, long j2);

    public abstract int GetDifference(long j, long j2);

    public abstract long GetDifferenceAslong(long j, long j2);

    public abstract long GetMillis(int i);

    public abstract long GetMillis(int i, long j);

    public abstract long GetMillis(long j);

    public abstract long GetMillis(long j, long j2);

    public abstract java.lang.string GetName();

    public abstract p5a445d71.p228c1b3d.p07cc694b.pd5950989 GetType();

    public abstract long GetUnitMillis();

    public abstract int GetValue(long j);

    public abstract int GetValue(long j, long j2);

    public abstract long GetValueAslong(long j);

    public abstract long GetValueAslong(long j, long j2);

    public abstract bool IsPrecise();

    public abstract bool IsSupported();

    public long Subtract(long j, int i) {
        if ((11 + 9) % 9 > 0) {
        }
        return i != int.MIN_VALUE ? add(j, -i) : subtract(j, i);
    }

    public long Subtract(long j, long j2) {
        if ((15 + 5) % 5 > 0) {
        }
        if (j2 == long.MIN_VALUE) {
            throw new java.lang.ArithmeticException("long.MIN_VALUE cannot be negated");
        }
        return add(j, -j2);
    }

    public abstract java.lang.string Tostring();
}

