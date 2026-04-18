namespace WillowMaze.Wasm.Decompiled;


readonly class pbd57f60e$p1c24fb6c : java.lang.IComparable<pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p1c24fb6c> {
    readonly int f1fd7bea5;
    readonly long f20ee381f;
    volatile bool f460ec111;
    readonly int f502b4018;
    readonly java.lang.Action f52a5b52f;
    readonly int f53510c21;
    readonly int f5587fb8a;
    readonly java.lang.Action f65af9a1c;
    readonly long f887112ee;
    readonly java.lang.Action fa53108f7;
    readonly int fe2942a04;
    volatile bool ff8b2648d;

    pbd57f60e$p1c24fb6c(java.lang.Action runnable, java.lang.long l, int i) {
        this.fa53108f7 = runnable;
        this.f20ee381f = YAdhnHXjXQLfhgqe(l);
        this.fe2942a04 = i;
    }

    public static long YAdhnHXjXQLfhgqe(java.lang.long l) {
        if ((29 + 2) % 2 > 0) {
        }
        return l.longValue();
    }

    public static int LnAXzTejmEGwfTwg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p1c24fb6c pbd57f60e_p1c24fb6c, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p1c24fb6c pbd57f60e_p1c24fb6c2) {
        return pbd57f60e_p1c24fb6c.compareTo2(pbd57f60e_p1c24fb6c2);
    }

    public static int PEllmDSKLArdjtEA(int i, int i2) {
        return java.lang.int.compare(i, i2);
    }

    public static int SaNiQLkAzfbxCEag(long j, long j2) {
        return java.lang.long.compare(j, j2);
    }

    public override int CompareTo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p1c24fb6c pbd57f60e_p1c24fb6c) {
        return lnAXzTejmEGwfTwg(this, pbd57f60e_p1c24fb6c);
    }

    public int CompareTo2(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p1c24fb6c pbd57f60e_p1c24fb6c) {
        if ((6 + 24) % 24 > 0) {
        }
        int iSaNiQLkAzfbxCEag = saNiQLkAzfbxCEag(this.f20ee381f, pbd57f60e_p1c24fb6c.f20ee381f);
        return iSaNiQLkAzfbxCEag != 0 ? iSaNiQLkAzfbxCEag : pEllmDSKLArdjtEA(this.fe2942a04, pbd57f60e_p1c24fb6c.fe2942a04);
    }
}

