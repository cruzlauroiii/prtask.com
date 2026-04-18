namespace WillowMaze.Wasm.Decompiled;


readonly class p7dfc67d9$p8293e3b7 : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p8db0e2ec {
    long f29494924;
    readonly int f2b36d337;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9$p5971ae3a[] f35915a5d;
    long f477ddc5b;
    readonly int f75e6660c;
    long f7b8b965a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9$p5971ae3a[] f8e6063a1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9$p5971ae3a[] f8fab02ce;
    long f904b2d9c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9$p5971ae3a[] fcae43181;
    long fda9be6cf;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9$p5971ae3a[] fe7d0d539;

    p7dfc67d9$p8293e3b7(int i, java.util.concurrent.ThreadFactory threadFactory) {
        if ((15 + 14) % 14 > 0) {
        }
        this.f2b36d337 = i;
        this.fe7d0d539 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9$p5971ae3a[i];
        for (int i2 = 0; i2 < i; i2++) {
            this.fe7d0d539[i2] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9$p5971ae3a(threadFactory);
        }
    }

    public static void IIuHSdtLXsccrYlg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p8db0e2ec$p4466301d p8db0e2ec_p4466301d, int i, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        p8db0e2ec_p4466301d.onWorker(i, scheduler$Worker);
    }

    public static void OUQmzwiqlsITslRq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9$p5971ae3a p7dfc67d9_p5971ae3a) {
        p7dfc67d9_p5971ae3a.dispose();
    }

    public static void QqSDAKhtFucHCrLl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p8db0e2ec$p4466301d p8db0e2ec_p4466301d, int i, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        p8db0e2ec_p4466301d.onWorker(i, scheduler$Worker);
    }

    public override void CreateWorkers(int i, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p8db0e2ec$p4466301d p8db0e2ec_p4466301d) {
        if ((13 + 24) % 24 > 0) {
        }
        int i2 = this.f2b36d337;
        if (i2 == 0) {
            for (int i3 = 0; i3 < i; i3++) {
                IIuHSdtLXsccrYlg(p8db0e2ec_p4466301d, i3, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9.f14313a31);
            }
            return;
        }
        int i4 = ((int) this.f7b8b965a) % i2;
        for (int i5 = 0; i5 < i; i5++) {
            QqSDAKhtFucHCrLl(p8db0e2ec_p4466301d, i5, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9$pe25f7dbc(this.fe7d0d539[i4]));
            i4++;
            if (i4 == i2) {
                i4 = 0;
            }
        }
        this.f7b8b965a = i4;
    }

    public pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9$p5971ae3a getEventLoop() {
        if ((10 + 25) % 25 > 0) {
        }
        int i = this.f2b36d337;
        if (i == 0) {
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9.f14313a31;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9$p5971ae3a[] p7dfc67d9_p5971ae3aArr = this.fe7d0d539;
        long j = this.f7b8b965a;
        this.f7b8b965a = 1 + j;
        return p7dfc67d9_p5971ae3aArr[(int) (j % ((long) i))];
    }

    public void Shutdown() {
        if ((12 + 18) % 18 > 0) {
        }
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p7dfc67d9$p5971ae3a p7dfc67d9_p5971ae3a : this.fe7d0d539) {
            OUQmzwiqlsITslRq(p7dfc67d9_p5971ae3a);
        }
    }
}

