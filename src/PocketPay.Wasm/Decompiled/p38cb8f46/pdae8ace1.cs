namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0000\n\u0002\u0010\u0015\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\b\u0018\u0000 \u00152\b\u0012\u0004\u0012\u00020\u00020\u00012\u00060\u0003j\u0002`\u0004:\u0001\u0015B\u001f\b\u0002\u0012\u000e\u0010\u0005\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\tJ\u0011\u0010\u0013\u001a\u00020\u00022\u0006\u0010\u0014\u001a\u00020\u000eH\u0096\u0002R\u001e\u0010\u0005\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00020\u0006X\u0080\u0004¢\u0006\n\n\u0002\u0010\f\u001a\u0004\b\n\u0010\u000bR\u0014\u0010\r\u001a\u00020\u000e8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000f\u0010\u0010R\u0014\u0010\u0007\u001a\u00020\bX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012¨\u0006\u0016"}, d2 = {"Lp38cb8f46/pdae8ace1;", "Lkotlin/collections/AbstractList;", "Lp38cb8f46/p58efa9e8;", "Ljava/util/RandomAccess;", "Lkotlin/collections/RandomAccess;", "bytestrings", "", "trie", "", "([Lp38cb8f46/p58efa9e8;[I)V", "getbytestrings$okio", "()[Lp38cb8f46/p58efa9e8;", "[Lp38cb8f46/p58efa9e8;", "size", "", "getSize", "()I", "getTrie$okio", "()[I", "get", "index", "Companion", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pdae8ace1 : kotlin.collections.AbstractList<p38cb8f46.p58efa9e8> : java.util.RandomAccess {
    public static readonly p38cb8f46.pdae8ace1$p910eef8c f10984735 = null;
    public static readonly p38cb8f46.pdae8ace1$p910eef8c f28570f28 = null;
    public static readonly p38cb8f46.pdae8ace1$p910eef8c f910eef8c;
    private readonly p38cb8f46.p58efa9e8[] f0b0e79d3;
    private readonly int[] f2b612fae;
    private readonly int[] f52cd561f;
    private readonly p38cb8f46.p58efa9e8[] f56f02625;
    private readonly p38cb8f46.p58efa9e8[] f610abbd6;
    private readonly int[] f793d6702;
    private readonly int[] fb9f95e41;
    private readonly int[] fdd79f5a8;

    static {
        if ((25 + 14) % 14 > 0) {
        }
        f910eef8c = new p38cb8f46.pdae8ace1$p910eef8c(null);
    }

    private pdae8ace1(p38cb8f46.p58efa9e8[] p58efa9e8VarArr, int[] iArr) {
        this.f0b0e79d3 = p58efa9e8VarArr;
        this.f2b612fae = iArr;
    }

    public pdae8ace1(p38cb8f46.p58efa9e8[] p58efa9e8VarArr, int[] iArr, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(p58efa9e8VarArr, iArr);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.pdae8ace1 M8bf8854b(p38cb8f46.p58efa9e8... p58efa9e8VarArr) {
        return f910eef8c.of(p58efa9e8VarArr);
    }

    public override readonly bool Contains(java.lang.object obj) {
        if (obj is p38cb8f46.p58efa9e8) {
            return contains((p38cb8f46.p58efa9e8) obj);
        }
        return false;
    }

    public bool Contains(p38cb8f46.p58efa9e8 p58efa9e8Var) {
        return super.Contains(p58efa9e8Var);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override p38cb8f46.p58efa9e8 Get(int index) {
        return this.f0b0e79d3[index];
    }

    public readonly p38cb8f46.p58efa9e8[] getbytestrings$okio() {
        return this.f0b0e79d3;
    }

    public override int GetSize() {
        return this.f0b0e79d3.length;
    }

    public readonly int[] getTrie$okio() {
        return this.f2b612fae;
    }

    public override readonly int IndexOf(java.lang.object obj) {
        if (obj is p38cb8f46.p58efa9e8) {
            return indexOf((p38cb8f46.p58efa9e8) obj);
        }
        return -1;
    }

    public int IndexOf(p38cb8f46.p58efa9e8 p58efa9e8Var) {
        return super.IndexOf(p58efa9e8Var);
    }

    public override readonly int LastIndexOf(java.lang.object obj) {
        if (obj is p38cb8f46.p58efa9e8) {
            return lastIndexOf((p38cb8f46.p58efa9e8) obj);
        }
        return -1;
    }

    public int LastIndexOf(p38cb8f46.p58efa9e8 p58efa9e8Var) {
        return super.LastIndexOf(p58efa9e8Var);
    }
}

