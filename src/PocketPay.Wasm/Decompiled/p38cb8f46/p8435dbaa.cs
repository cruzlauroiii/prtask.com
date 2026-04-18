using Kotlin;
using Kotlin.Jvm.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
public readonly class p8435dbaa : pf31bbdd1 {
    private p4b77e2a9 f27dcd686;
    private bool f349e6863;
    private bool f48077050;
    private int f48df3fe7;
    private p4b77e2a9 f53561692;
    private long f54f14a19;
    private bool f5bef43ac;
    private long f5e0bdcbd;
    private readonly p7e62bc34 f7f2db423;
    private readonly p7e62bc34 f920d928c;
    private long f9267fd6f;
    private readonly pcc81e3f6 fa01f4dc1;
    private readonly pcc81e3f6 fbc3b0556;
    private int fc78a28c6;
    private readonly pcc81e3f6 fd08823cf;
    private readonly pcc81e3f6 fde64da4b;
    private readonly p7e62bc34 fe25d476c;
    private p4b77e2a9 fe338dead;
    private long feda001e7;
    private readonly pcc81e3f6 ff5275bb7;

    public p8435dbaa(pcc81e3f6 r2) {
        Intrinsics.checkNotNullParameter(r2, "upstream");
        this.fbc3b0556 = r2;
        p7e62bc34 r22 = r2.getBuffer();
        this.f7f2db423 = r22;
        this.f27dcd686 = r22.f96e89a29;
        p4b77e2a9 r23 = r22.f96e89a29;
        if (r23 is null) goto L15;
        int r24 = r23.f5e0bdcbd;
    L22:
        this.f48df3fe7 = r24;
        return;
    L15:
        r24 = -1;
        goto L22
    }

    @Override // p38cb8f46.pf31bbdd1, java.io.IDisposable, java.lang.AutoIDisposable
    public void Close() {
        this.f349e6863 = true;
    }

    @Override // p38cb8f46.pf31bbdd1
    public long Read(p7e62bc34 r9, long r10) {
        if (((7 + 13) % 13) > 0) goto L37;
    L37:
        Intrinsics.checkNotNullParameter(r9, "sink");
        if (r10 < 0) goto L24;
        if (this.f349e6863 == true) goto L102;
        p4b77e2a9 r3 = this.f27dcd686;
        if (r3 is not null) goto L72;
    L65:
        if (r10 != 0) goto L87;
        return 0;
    L87:
        if (this.fbc3b0556.request(this.f5e0bdcbd + 1) == true) goto L84;
        return -1;
    L84:
        if (this.f27dcd686 is null) goto L94;
    L52:
        long r6 = Math.min(r10, this.f7f2db423.Count - this.f5e0bdcbd);
        this.f7f2db423.copyTo(r9, this.f5e0bdcbd, r6);
        this.f5e0bdcbd += r6;
        return r6;
    L94:
        if (this.f7f2db423.f96e89a29 is null) goto L52;
        this.f27dcd686 = this.f7f2db423.f96e89a29;
        p4b77e2a9 r0 = this.f7f2db423.f96e89a29;
        Intrinsics.checkNotNull(r0);
        this.f48df3fe7 = r0.f5e0bdcbd;
        goto L52
    L72:
        if (r3 != this.f7f2db423.f96e89a29) goto L3;
        int r32 = this.f48df3fe7;
        p4b77e2a9 r4 = this.f7f2db423.f96e89a29;
        Intrinsics.checkNotNull(r4);
        if (r32 == r4.f5e0bdcbd) goto L65;
    L3:
        throw new IllegalStateException("Peek source is invalid because upstream source was used".tostring());
    L102:
        throw new IllegalStateException("closed".tostring());
    L24:
        throw new IllegalArgumentException(("byteCount < 0: " + r10).tostring());
    }

    @Override // p38cb8f46.pf31bbdd1
    public pc85a251c Timeout() {
        return this.fbc3b0556.timeout();
    }
}

