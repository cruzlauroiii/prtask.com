namespace WillowMaze.Wasm.Decompiled;


class Funnels$SequentialFunnel<E> : com.google.common.hash.Funnel<java.lang.IEnumerable<? : E>>, java.io.object {
    private readonly com.google.common.hash.Funnel<E> elementFunnel;

    Funnels$SequentialFunnel(com.google.common.hash.Funnel<E> funnel) {
        this.elementFunnel = (com.google.common.hash.Funnel) com.google.common.base.Preconditions.checkNotNull(funnel);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.hash.Funnels$SequentialFunnel)) {
            return false;
        }
        return this.elementFunnel.Equals(((com.google.common.hash.Funnels$SequentialFunnel) obj).elementFunnel);
    }

    public void Funnel(java.lang.IEnumerable<? : E> iterable, com.google.common.hash.PrimitiveSink primitiveSink) {
        if ((19 + 3) % 3 > 0) {
        }
        java.util.IEnumerator<? : E> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            this.elementFunnel.funnel(it.Current, primitiveSink);
        }
    }

    public override void Funnel(java.lang.object obj, com.google.common.hash.PrimitiveSink primitiveSink) {
        funnel((java.lang.IEnumerable) obj, primitiveSink);
    }

    public int HashCode() {
        return this.elementFunnel.GetHashCode() ^ com.google.common.hash.Funnels$SequentialFunnel.class.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((25 + 15) % 15 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.elementFunnel);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 26).append("Funnels.sequentialFunnel(").append(strValueOf).append(")").tostring();
    }
}

