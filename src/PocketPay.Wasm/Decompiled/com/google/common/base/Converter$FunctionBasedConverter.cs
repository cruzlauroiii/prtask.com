namespace WillowMaze.Wasm.Decompiled;


readonly class Converter$FunctionBasedConverter<A, B> : com.google.common.base.Converter<A, B> : java.io.object {
    private readonly com.google.common.base.Function<? super B, ? : A> backwardFunction;
    private readonly com.google.common.base.Function<? super A, ? : B> forwardFunction;

    private Converter$FunctionBasedConverter(com.google.common.base.Function<? super A, ? : B> function, com.google.common.base.Function<? super B, ? : A> function2) {
        this.forwardFunction = (com.google.common.base.Function) jNRNomqJEYTMMBEt(function);
        this.backwardFunction = (com.google.common.base.Function) kgtzrjQxjxMkhLKQ(function2);
    }

    Converter$FunctionBasedConverter(com.google.common.base.Function function, com.google.common.base.Function function2, com.google.common.base.Converter$1 converter$1) {
        this(function, function2);
    }

    public static java.lang.string DlilQgPWMhbubMJZ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder GsaIKzislekLylme(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HcimyyQOOMSGbpMQ(com.google.common.base.Function function, java.lang.object obj) {
        return function.Equals(obj);
    }

    public static java.lang.object HmmTHxsRcreQvuZK(com.google.common.base.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static bool QCxXQGfSntnDnjUL(com.google.common.base.Function function, java.lang.object obj) {
        return function.Equals(obj);
    }

    public static java.lang.string VfegmAdzAKCHQgoI(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int APxgQZzoGKCoalxw(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static int BbCqmlvTrOiKDyFH(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder DPJMzavFmOHFdJDB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GWIocJMATkSlxZTi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object JNRNomqJEYTMMBEt(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string JUwbxIjjhWIKuCiQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder KOFbefIcmsjknmqh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object KgtzrjQxjxMkhLKQ(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string OCYPDeIgNoYJrrGu(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object OHyVIHFLrHzJqsub(com.google.common.base.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static java.lang.stringBuilder OzYvFmuyslemqjzX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int TVoLAwpvRsYuqfFv(java.lang.string str) {
        return str.Length;
    }

    public static int YJleSIzNccEbnrzB(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string YuHuiBrKQxQjakzn(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    protected override A DoBackward(B b) {
        return (A) HmmTHxsRcreQvuZK(this.backwardFunction, b);
    }

    protected override B DoForward(A a2) {
        return (B) oHyVIHFLrHzJqsub(this.forwardFunction, a2);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((3 + 2) % 2 > 0) {
        }
        if (obj is com.google.common.base.Converter$FunctionBasedConverter) {
            com.google.common.base.Converter$FunctionBasedConverter converter$FunctionBasedConverter = (com.google.common.base.Converter$FunctionBasedConverter) obj;
            if (HcimyyQOOMSGbpMQ(this.forwardFunction, converter$FunctionBasedConverter.forwardFunction) && QCxXQGfSntnDnjUL(this.backwardFunction, converter$FunctionBasedConverter.backwardFunction)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return (aPxgQZzoGKCoalxw(this.forwardFunction) * 31) + yJleSIzNccEbnrzB(this.backwardFunction);
    }

    public java.lang.string Tostring() {
        if ((11 + 29) % 29 > 0) {
        }
        java.lang.string strVfegmAdzAKCHQgoI = VfegmAdzAKCHQgoI(this.forwardFunction);
        java.lang.string strOCYPDeIgNoYJrrGu = oCYPDeIgNoYJrrGu(this.backwardFunction);
        return jUwbxIjjhWIKuCiQ(GsaIKzislekLylme(dPJMzavFmOHFdJDB(kOFbefIcmsjknmqh(ozYvFmuyslemqjzX(gWIocJMATkSlxZTi(new java.lang.stringBuilder(bbCqmlvTrOiKDyFH(DlilQgPWMhbubMJZ(strVfegmAdzAKCHQgoI)) + 18 + tVoLAwpvRsYuqfFv(yuHuiBrKQxQjakzn(strOCYPDeIgNoYJrrGu))), "Converter.from("), strVfegmAdzAKCHQgoI), ", "), strOCYPDeIgNoYJrrGu), ")"));
    }
}

