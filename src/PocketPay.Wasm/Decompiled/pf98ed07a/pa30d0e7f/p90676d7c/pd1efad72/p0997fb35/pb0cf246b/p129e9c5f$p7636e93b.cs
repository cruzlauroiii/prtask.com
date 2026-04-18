namespace WillowMaze.Wasm.Decompiled;


readonly class p129e9c5f$p7636e93b<K, V> : io.reactivex.rxjava3.functions.Consumer<io.reactivex.rxjava3.internal.operators.flowable.FlowableGroupBy$GroupedUnicast<K, V>> {
    readonly java.util.Queue<io.reactivex.rxjava3.internal.operators.flowable.FlowableGroupBy$GroupedUnicast<K, V>> f03922e00;
    readonly java.util.Queue f1d3a969f;
    readonly java.util.Queue f83427eef;
    readonly java.util.Queue fcaf0cfc2;
    readonly java.util.Queue febb70a20;

    p129e9c5f$p7636e93b(java.util.Queue<io.reactivex.rxjava3.internal.operators.flowable.FlowableGroupBy$GroupedUnicast<K, V>> queue) {
        this.f03922e00 = queue;
    }

    public static bool RZGLYELlAmANfaUQ(java.util.Queue queue, java.lang.object obj) {
        return queue.offer(obj);
    }

    public static void SzRGzRWlmffmPSlZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p129e9c5f$p7636e93b p129e9c5f_p7636e93b, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p129e9c5f$pcae2b5bc p129e9c5f_pcae2b5bc) {
        p129e9c5f_p7636e93b.accept(p129e9c5f_pcae2b5bc);
    }

    public void Accept(java.lang.object obj) throws java.lang.Exception {
        szRGzRWlmffmPSlZ(this, (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p129e9c5f$pcae2b5bc) obj);
    }

    public void Accept(io.reactivex.rxjava3.internal.operators.flowable.FlowableGroupBy$GroupedUnicast<K, V> flowableGroupBy$GroupedUnicast) {
        RZGLYELlAmANfaUQ(this.f03922e00, flowableGroupBy$GroupedUnicast);
    }
}

