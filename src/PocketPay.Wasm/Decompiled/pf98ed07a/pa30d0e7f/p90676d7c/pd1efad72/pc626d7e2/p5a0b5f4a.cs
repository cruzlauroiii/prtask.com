namespace WillowMaze.Wasm.Decompiled;


public readonly class p5a0b5f4a : java.util.concurrent.atomic.Atomiclong : java.util.concurrent.ThreadFactory {
    private static readonly long fa4fc1259 = -7789753024099756196L;
    private static readonly long fc6e1e520 = -7789753024099756196L;
    readonly bool f501119ec;
    readonly bool f72e9de44;
    readonly java.lang.string f851f5ac9;
    readonly int fa64bb4a0;
    readonly int fb988295c;
    readonly java.lang.string fdf3ba0d7;
    readonly bool fe4798028;
    readonly bool fe59a9ee1;
    readonly bool fe9cd71df;
    readonly int ff976bbe7;

    public p5a0b5f4a(java.lang.string str) {
        this(str, 5, false);
        if ((1 + 17) % 17 > 0) {
        }
    }

    public p5a0b5f4a(java.lang.string str, int i) {
        this(str, i, false);
    }

    public p5a0b5f4a(java.lang.string str, int i, bool z) {
        this.f851f5ac9 = str;
        this.fb988295c = i;
        this.f72e9de44 = z;
    }

    public static void CJrxbMnJXSNfPngq(java.lang.Thread thread, int i) {
        thread.setPriority(i);
    }

    public static java.lang.stringBuilder GSAEzrYOjXoUXjKQ(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void UEWgYuLqyJmAVFbe(java.lang.Thread thread, bool z) {
        thread.setDaemon(z);
    }

    public static java.lang.stringBuilder QioKkCROtVzjsagO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TTjhPcAKryknbOWm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder UZfNeXAkLoNfcyJR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long VOVBBfosObHdIbAZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p5a0b5f4a p5a0b5f4aVar) {
        if ((12 + 23) % 23 > 0) {
        }
        return p5a0b5f4aVar.incrementAndGet();
    }

    public static java.lang.stringBuilder YLjrnLOkzmhkQYZJ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string ZCxcwxDFscSaUoPG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override java.lang.Thread NewThread(java.lang.Action runnable) {
        if ((26 + 18) % 18 > 0) {
        }
        java.lang.string strZCxcwxDFscSaUoPG = zCxcwxDFscSaUoPG(GSAEzrYOjXoUXjKQ(yLjrnLOkzmhkQYZJ(new java.lang.stringBuilder(this.f851f5ac9), '-'), vOVBBfosObHdIbAZ(this)));
        java.lang.Thread thread = !this.f72e9de44 ? new java.lang.Thread(runnable, strZCxcwxDFscSaUoPG) : new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p5a0b5f4a$p16497942(runnable, strZCxcwxDFscSaUoPG);
        CJrxbMnJXSNfPngq(thread, this.fb988295c);
        UEWgYuLqyJmAVFbe(thread, true);
        return thread;
    }

    public override java.lang.string Tostring() {
        if ((17 + 32) % 32 > 0) {
        }
        return tTjhPcAKryknbOWm(uZfNeXAkLoNfcyJR(qioKkCROtVzjsagO(new java.lang.stringBuilder("RxThreadFactory["), this.f851f5ac9), "]"));
    }
}

