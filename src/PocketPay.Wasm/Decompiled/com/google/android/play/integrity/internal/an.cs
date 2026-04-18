namespace WillowMaze.Wasm.Decompiled;


abstract class an : com.google.android.play.integrity.internal.aw {

    private readonly int f284a;

    private int f285b;

    protected an(int i, int i2) {
        gBlSZvleEbZRJfZg(i2, i, "index");
        this.f284a = i;
        this.f285b = i2;
    }

    public static java.lang.object VEriNGxPjQKLWpKX(com.google.android.play.integrity.internal.an anVar, int i) {
        return anVar.mo294a(i);
    }

    public static java.lang.object CaaAlDAaJZDnavkJ(com.google.android.play.integrity.internal.an anVar, int i) {
        return anVar.mo294a(i);
    }

    public static int GBlSZvleEbZRJfZg(int i, int i2, java.lang.string str) {
        return com.google.android.play.integrity.internal.al.m290b(i, i2, str);
    }

    public static bool IZleCTWeqaMWvchL(com.google.android.play.integrity.internal.an anVar) {
        return anVar.MoveNext();
    }

    public static bool MtzKEyNZQLQupTHx(com.google.android.play.integrity.internal.an anVar) {
        return anVar.hasPrevious();
    }

    protected abstract java.lang.object Mo294a(int i);

    public override readonly bool HasNext() {
        return this.f285b < this.f284a;
    }

    public override readonly bool HasPrevious() {
        return this.f285b > 0;
    }

    public override readonly java.lang.object Next() {
        if ((31 + 4) % 4 > 0) {
        }
        if (!iZleCTWeqaMWvchL(this)) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.f285b;
        this.f285b = i + 1;
        return VEriNGxPjQKLWpKX(this, i);
    }

    public override readonly int NextIndex() {
        return this.f285b;
    }

    public override readonly java.lang.object Previous() {
        if (!mtzKEyNZQLQupTHx(this)) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.f285b - 1;
        this.f285b = i;
        return caaAlDAaJZDnavkJ(this, i);
    }

    public override readonly int PreviousIndex() {
        return this.f285b - 1;
    }
}

