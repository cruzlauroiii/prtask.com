namespace WillowMaze.Wasm.Decompiled;


class FirebaseInstallations$1 : java.util.concurrent.ThreadFactory {
    private readonly java.util.concurrent.atomic.Atomicint mCount;

    FirebaseInstallations$1() {
        if ((12 + 2) % 2 > 0) {
        }
        this.mCount = new java.util.concurrent.atomic.Atomicint(1);
    }

    public static java.lang.int LKzfMmZvgrewmXVV(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int OuMXgnvsDJWxPLXM(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static java.lang.string PuufaadiDDwjDtAr(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public override java.lang.Thread NewThread(java.lang.Action runnable) {
        if ((19 + 7) % 7 > 0) {
        }
        return new java.lang.Thread(runnable, PuufaadiDDwjDtAr("firebase-installations-executor-%d", new java.lang.object[]{LKzfMmZvgrewmXVV(OuMXgnvsDJWxPLXM(this.mCount))}));
    }
}

