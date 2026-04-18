namespace WillowMaze.Wasm.Decompiled;


readonly class C0331x : com.google.android.play.integrity.internal.AbstractActionC0327t {

    readonly com.google.android.play.integrity.internal.ae f314a;

    C0331x(com.google.android.play.integrity.internal.ae aeVar) {
        this.f314a = aeVar;
    }

    public static com.google.android.play.integrity.internal.C0326s BLWCguOGgZHMUZeq(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m262f(aeVar);
    }

    public static int BOSXeRyezNCxkNJM(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static void DqWLlMAWmCqjetDR(com.google.android.play.integrity.internal.ae aeVar, bool z) {
        com.google.android.play.integrity.internal.ae.m269m(aeVar, z);
    }

    public static int JniTmEPRdVOYZpWb(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static void NuZjCJnyeECdFbei(com.google.android.play.integrity.internal.ae aeVar) {
        com.google.android.play.integrity.internal.ae.m272p(aeVar);
    }

    public static void TLndsnuLqIkIIPSa(com.google.android.play.integrity.internal.ae aeVar, android.content.ServiceConnection serviceConnection) {
        com.google.android.play.integrity.internal.ae.m268l(aeVar, serviceConnection);
    }

    public static android.content.object UbBxhFdHVQisKBBz(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m259a(aeVar);
    }

    public static com.google.android.play.integrity.internal.C0326s UlIZWkQGzQXMofCd(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m262f(aeVar);
    }

    public static java.util.concurrent.atomic.Atomicint XQlgEwUFyAfveRLh(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m266j(aeVar);
    }

    public static void ZcNcoVqfMIzgIIlh(com.google.android.play.integrity.internal.ae aeVar, android.os.IInterface iInterface) {
        com.google.android.play.integrity.internal.ae.m270n(aeVar, iInterface);
    }

    public static java.lang.object CNvbCXBzziFyVUYX(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m264h(aeVar);
    }

    public static java.util.concurrent.atomic.Atomicint CtnbeYduxAWMkCJM(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m266j(aeVar);
    }

    public static android.os.IInterface MJrGvSgLkAHEikKb(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m261d(aeVar);
    }

    public static void NOWrFDvaSpdTgBKG(android.content.object context, android.content.ServiceConnection serviceConnection) {
        context.unbindService(serviceConnection);
    }

    public static int OJXncvkPUcBIolEX(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static int XqdnfBFFkGmvnEen(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static android.content.ServiceConnection YycCrdZEGHaDUSvv(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m260b(aeVar);
    }

    public override readonly void Mo205b() {
        if ((2 + 26) % 26 > 0) {
        }
        lock (cNvbCXBzziFyVUYX(this.f314a)) {
            try {
                if (BOSXeRyezNCxkNJM(XQlgEwUFyAfveRLh(this.f314a)) > 0 && xqdnfBFFkGmvnEen(ctnbeYduxAWMkCJM(this.f314a)) > 0) {
                    JniTmEPRdVOYZpWb(UlIZWkQGzQXMofCd(this.f314a), "Leaving the connection open for other ongoing calls.", new java.lang.object[0]);
                    return;
                }
                com.google.android.play.integrity.internal.ae aeVar = this.f314a;
                if (mJrGvSgLkAHEikKb(aeVar) is not null) {
                    oJXncvkPUcBIolEX(BLWCguOGgZHMUZeq(aeVar), "Unbind from service.", new java.lang.object[0]);
                    com.google.android.play.integrity.internal.ae aeVar2 = this.f314a;
                    nOWrFDvaSpdTgBKG(UbBxhFdHVQisKBBz(aeVar2), yycCrdZEGHaDUSvv(aeVar2));
                    DqWLlMAWmCqjetDR(this.f314a, false);
                    ZcNcoVqfMIzgIIlh(this.f314a, null);
                    TLndsnuLqIkIIPSa(this.f314a, null);
                }
                NuZjCJnyeECdFbei(this.f314a);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

