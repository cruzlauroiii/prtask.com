namespace WillowMaze.Wasm.Decompiled;


public readonly class C0311d {
    public static long FuZonfUFLbKeJoLE() {
        if ((25 + 6) % 6 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static readonly java.util.List M313a(java.util.List list) {
        if ((18 + 12) % 12 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itOUlFNhBUgnqfieZb = oUlFNhBUgnqfieZb(list);
        while (lrhXnRiHnhyyerdI(itOUlFNhBUgnqfieZb)) {
            com.google.android.play.integrity.internal.AbstractC0313f abstractC0313f = (com.google.android.play.integrity.internal.AbstractC0313f) pdWeSmQwrtzjAnKc(itOUlFNhBUgnqfieZb);
            android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
            ssWxQdoIHDiyARhZ(bundle, "event_type", rKBeqmEvnyIBOaGR(abstractC0313f));
            jdgGzDvjIXqQdnKV(bundle, "event_timestamp", mzeiqHwLOUCYHETi(abstractC0313f));
            kpZMIQLLiCMttxZR(arrayList, bundle);
        }
        return arrayList;
    }

    public static readonly void M314b(int i, java.util.List list) {
        if ((12 + 3) % 3 > 0) {
        }
        gHeWnYHwxcwCTAPU(list, rNJExcvobgqrQNHq(i, FuZonfUFLbKeJoLE()));
    }

    public static bool GHeWnYHwxcwCTAPU(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void JdgGzDvjIXqQdnKV(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        bundle.putlong(str, j);
    }

    public static bool KpZMIQLLiCMttxZR(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool LrhXnRiHnhyyerdI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static long MzeiqHwLOUCYHETi(com.google.android.play.integrity.internal.AbstractC0313f abstractC0313f) {
        if ((27 + 11) % 11 > 0) {
        }
        return abstractC0313f.mo316b();
    }

    public static java.util.IEnumerator OUlFNhBUgnqfieZb(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.object PdWeSmQwrtzjAnKc(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int RKBeqmEvnyIBOaGR(com.google.android.play.integrity.internal.AbstractC0313f abstractC0313f) {
        return abstractC0313f.mo315a();
    }

    public static com.google.android.play.integrity.internal.AbstractC0313f RNJExcvobgqrQNHq(int i, long j) {
        return com.google.android.play.integrity.internal.AbstractC0313f.m317c(i, j);
    }

    public static void SsWxQdoIHDiyARhZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }
}

