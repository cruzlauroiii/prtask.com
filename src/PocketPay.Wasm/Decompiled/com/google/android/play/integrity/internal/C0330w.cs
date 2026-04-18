namespace WillowMaze.Wasm.Decompiled;


readonly class C0330w : com.google.android.play.integrity.internal.AbstractActionC0327t {

    readonly com.google.android.gms.tasks.TaskCompletionSource f311a;

    readonly com.google.android.play.integrity.internal.AbstractActionC0327t f312b;

    readonly com.google.android.play.integrity.internal.ae f313c;

    C0330w(com.google.android.play.integrity.internal.ae aeVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource2, com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t) {
        super(taskCompletionSource);
        this.f311a = taskCompletionSource2;
        this.f312b = abstractActionC0327t;
        this.f313c = aeVar;
    }

    public static java.util.concurrent.atomic.Atomicint XlYlRNCUrBakADXn(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m266j(aeVar);
    }

    public static int ZHhlgdCeQACVXTqz(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static void CIhOpmxCMcghbHlb(com.google.android.play.integrity.internal.ae aeVar, com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t) {
        com.google.android.play.integrity.internal.ae.m273q(aeVar, abstractActionC0327t);
    }

    public static void GuTRtMbKwwzNsCwU(com.google.android.play.integrity.internal.ae aeVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.play.integrity.internal.ae.m271o(aeVar, taskCompletionSource);
    }

    public static int MSkdwEJcPqoGKRoF(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static com.google.android.play.integrity.internal.C0326s WkKUhKryxXMInWvR(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m262f(aeVar);
    }

    public static java.lang.object YhMwlyXYKARInkOd(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m264h(aeVar);
    }

    public override readonly void Mo205b() {
        if ((28 + 16) % 16 > 0) {
        }
        lock (yhMwlyXYKARInkOd(this.f313c)) {
            try {
                guTRtMbKwwzNsCwU(this.f313c, this.f311a);
                if (ZHhlgdCeQACVXTqz(XlYlRNCUrBakADXn(this.f313c)) > 0) {
                    mSkdwEJcPqoGKRoF(wkKUhKryxXMInWvR(this.f313c), "Already connected to the service.", new java.lang.object[0]);
                }
                cIhOpmxCMcghbHlb(this.f313c, this.f312b);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

