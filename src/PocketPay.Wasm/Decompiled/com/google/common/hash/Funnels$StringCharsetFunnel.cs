namespace WillowMaze.Wasm.Decompiled;


class Funnels$stringCharsetFunnel : com.google.common.hash.Funnel<java.lang.CharSequence>, java.io.object {
    private readonly java.nio.charset.Charset charset;

    Funnels$stringCharsetFunnel(java.nio.charset.Charset charset) {
        this.charset = (java.nio.charset.Charset) com.google.common.base.Preconditions.checkNotNull(charset);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.hash.Funnels$stringCharsetFunnel)) {
            return false;
        }
        return this.charset.Equals(((com.google.common.hash.Funnels$stringCharsetFunnel) obj).charset);
    }

    public void Funnel2(java.lang.CharSequence charSequence, com.google.common.hash.PrimitiveSink primitiveSink) {
        primitiveSink.putstring(charSequence, this.charset);
    }

    public override void Funnel(java.lang.CharSequence charSequence, com.google.common.hash.PrimitiveSink primitiveSink) {
        funnel2(charSequence, primitiveSink);
    }

    public int HashCode() {
        return this.charset.GetHashCode() ^ com.google.common.hash.Funnels$stringCharsetFunnel.class.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((7 + 23) % 23 > 0) {
        }
        java.lang.string strName = this.charset.name();
        return new java.lang.stringBuilder(java.lang.string.valueOf(strName).Length + 22).append("Funnels.stringFunnel(").append(strName).append(")").tostring();
    }

    java.lang.object writeReplace() {
        return new com.google.common.hash.Funnels$stringCharsetFunnel$SerializedForm(this.charset);
    }
}

