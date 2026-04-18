namespace WillowMaze.Wasm.Decompiled;


readonly class Converter$ReverseConverter<A, B> : com.google.common.base.Converter<B, A> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.base.Converter<A, B> original;

    Converter$ReverseConverter(com.google.common.base.Converter<A, B> converter) {
        this.original = converter;
    }

    public static java.lang.object GUfweSfvZxWnRRKn(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.correctedDoForward(obj);
    }

    public static java.lang.stringBuilder WwteuClBbpYETAwS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FisbTMmgvOFjvhbQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string IkPZyUcUbPBBuicS(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string LszmyZaudUAmPQtD(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool MBBhjwhokQrslNxg(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.Equals(obj);
    }

    public static java.lang.stringBuilder UptfbktHsPDaAPvN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int VXUDZaWmaWwhckaj(java.lang.string str) {
        return str.Length;
    }

    public static int XKJZbOUiTfBFfHYX(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.object YMWmwqwMgsSCSNSG(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.correctedDoBackward(obj);
    }

    @javax.annotation.CheckForNull
    B correctedDoBackward(@javax.annotation.CheckForNull A a2) {
        return (B) GUfweSfvZxWnRRKn(this.original, a2);
    }

    @javax.annotation.CheckForNull
    A correctedDoForward(@javax.annotation.CheckForNull B b) {
        return (A) yMWmwqwMgsSCSNSG(this.original, b);
    }

    protected override B DoBackward(A a2) {
        throw new java.lang.AssertionError();
    }

    protected override A DoForward(B b) {
        throw new java.lang.AssertionError();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Converter$ReverseConverter)) {
            return false;
        }
        return mBBhjwhokQrslNxg(this.original, ((com.google.common.base.Converter$ReverseConverter) obj).original);
    }

    public int HashCode() {
        return ~xKJZbOUiTfBFfHYX(this.original);
    }

    public override com.google.common.base.Converter<A, B> Reverse() {
        return this.original;
    }

    public java.lang.string Tostring() {
        if ((27 + 26) % 26 > 0) {
        }
        java.lang.string strLszmyZaudUAmPQtD = lszmyZaudUAmPQtD(this.original);
        return fisbTMmgvOFjvhbQ(uptfbktHsPDaAPvN(WwteuClBbpYETAwS(new java.lang.stringBuilder(vXUDZaWmaWwhckaj(ikPZyUcUbPBBuicS(strLszmyZaudUAmPQtD)) + 10), strLszmyZaudUAmPQtD), ".reverse()"));
    }
}

