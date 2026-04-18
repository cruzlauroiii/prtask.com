namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public class Joiner {
    private readonly java.lang.string separator;

    private Joiner(com.google.common.base.Joiner joiner) {
        this.separator = joiner.separator;
    }

    Joiner(com.google.common.base.Joiner joiner, com.google.common.base.Joiner$1 joiner$1) {
        this(joiner);
    }

    private Joiner(java.lang.string str) {
        this.separator = (java.lang.string) LWwfNlGpvLiMgttM(str);
    }

    public static java.lang.Appendable ACZbiUIlhjnCQueE(com.google.common.base.Joiner joiner, java.lang.Appendable appendable, java.util.IEnumerator it) {
        return joiner.appendTo(appendable, (java.util.IEnumerator<? : java.lang.object>) it);
    }

    public static java.lang.string AOVGcXKbxkbxHsCg(char c) {
        return java.lang.string.valueOf(c);
    }

    public static java.lang.Appendable AwQfDWhfFpIOTiZg(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static java.lang.Appendable BlCWSCoLRvVZztot(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static java.lang.Appendable CgwXABPQwIOsTNbb(com.google.common.base.Joiner joiner, java.lang.Appendable appendable, java.lang.IEnumerable iterable) {
        return joiner.appendTo(appendable, (java.lang.IEnumerable<? : java.lang.object>) iterable);
    }

    public static java.lang.string DGfKZdGoAdiWgEMH(com.google.common.base.Joiner joiner, java.lang.IEnumerable iterable) {
        return joiner.join((java.lang.IEnumerable<? : java.lang.object>) iterable);
    }

    public static java.lang.Appendable DIccDtrXbbnbUEUU(com.google.common.base.Joiner joiner, java.lang.Appendable appendable, java.util.IEnumerator it) {
        return joiner.appendTo(appendable, (java.util.IEnumerator<? : java.lang.object>) it);
    }

    public static java.lang.object HFdDfSWOLYeihfvs(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object JYezkhXEgrUQpzxv(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.object LWwfNlGpvLiMgttM(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.IEnumerable NdEKvvutDGFvoRim(java.lang.object obj, java.lang.object obj2, java.lang.object[] objArr) {
        return iterable(obj, obj2, objArr);
    }

    public static java.lang.string OKxzLhUFRzcJhcAT(com.google.common.base.Joiner joiner, java.util.IEnumerator it) {
        return joiner.join((java.util.IEnumerator<? : java.lang.object>) it);
    }

    public static java.lang.IEnumerable OaAWHCsCZWeOvXbl(java.lang.object obj, java.lang.object obj2, java.lang.object[] objArr) {
        return iterable(obj, obj2, objArr);
    }

    public static java.util.List QTovvPqJdeTycQGz(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.string QbdeUMOzcxhSFIOO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.List RYFzjMjGRclzPjwj(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.CharSequence RuzlDsAIUMxuJZxP(com.google.common.base.Joiner joiner, java.lang.object obj) {
        return joiner.tostring(obj);
    }

    public static java.lang.stringBuilder VVtKYzFOfbVcbvks(com.google.common.base.Joiner joiner, java.lang.stringBuilder sb, java.lang.IEnumerable iterable) {
        return joiner.appendTo(sb, (java.lang.IEnumerable<? : java.lang.object>) iterable);
    }

    public static java.lang.CharSequence XynPGVuwMopBCGKI(com.google.common.base.Joiner joiner, java.lang.object obj) {
        return joiner.tostring(obj);
    }

    static java.lang.string access$100(com.google.common.base.Joiner joiner) {
        return joiner.separator;
    }

    public static java.lang.object BambqXTSbADwJLFS(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder EBOkdchmLPSmihnP(com.google.common.base.Joiner joiner, java.lang.stringBuilder sb, java.lang.IEnumerable iterable) {
        return joiner.appendTo(sb, (java.lang.IEnumerable<? : java.lang.object>) iterable);
    }

    public static bool EsvPGLLLXCVdWiEg(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.Appendable FIpCMTCkiTRAAWVu(com.google.common.base.Joiner joiner, java.lang.Appendable appendable, java.lang.IEnumerable iterable) {
        return joiner.appendTo(appendable, (java.lang.IEnumerable<? : java.lang.object>) iterable);
    }

    public static java.util.IEnumerator FQhTthweUZgrCLfa(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object GtvBDboYWmZscPnn(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder HIkpxaUJwsKkzNlD(com.google.common.base.Joiner joiner, java.lang.stringBuilder sb, java.util.IEnumerator it) {
        return joiner.appendTo(sb, (java.util.IEnumerator<? : java.lang.object>) it);
    }

    private static java.lang.IEnumerable<java.lang.object> Iterable(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2, java.lang.object[] objArr) {
        HFdDfSWOLYeihfvs(objArr);
        return new com.google.common.base.Joiner$3(objArr, obj, obj2);
    }

    public static java.lang.object KQnydTXtkXPwnxVz(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string LdQAWWdMTQDrROIc(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.IEnumerable LsOWWwdMZpOCzPAe(java.lang.object obj, java.lang.object obj2, java.lang.object[] objArr) {
        return iterable(obj, obj2, objArr);
    }

    public static java.util.IEnumerator MddJoSNIspBynwSF(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object MuZUTvZapFfjYzDm(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.common.base.Joiner$DictionaryJoiner neXKhSvqhaqDLEjU(com.google.common.base.Joiner joiner, java.lang.string str) {
        return joiner.withKeyValueSeparator(str);
    }

    public static com.google.common.base.Joiner On(char c) {
        return new com.google.common.base.Joiner(AOVGcXKbxkbxHsCg(c));
    }

    public static com.google.common.base.Joiner On(java.lang.string str) {
        return new com.google.common.base.Joiner(str);
    }

    public static java.util.List QCzFyyDzPnarylmG(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.Appendable QXOiGKlxBUoaYFLK(java.lang.Appendable appendable, java.lang.CharSequence charSequence) {
        return appendable.append(charSequence);
    }

    public static java.lang.string RmvNjMrvrdeuvnst(char c) {
        return java.lang.string.valueOf(c);
    }

    public static java.lang.stringBuilder VllsxbDoyPRJENKB(com.google.common.base.Joiner joiner, java.lang.stringBuilder sb, java.util.IEnumerator it) {
        return joiner.appendTo(sb, (java.util.IEnumerator<? : java.lang.object>) it);
    }

    public static java.util.IEnumerator XjqmgeXRcgIQMKQQ(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool XnzeLPIwCJXIQgoQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string YkZdaPbcXlrDqSlW(com.google.common.base.Joiner joiner, java.lang.IEnumerable iterable) {
        return joiner.join((java.lang.IEnumerable<? : java.lang.object>) iterable);
    }

    public <A : java.lang.Appendable> A appendTo(A a2, java.lang.IEnumerable<? : java.lang.object> iterable) throws java.io.IOException {
        return (A) DIccDtrXbbnbUEUU(this, a2, fQhTthweUZgrCLfa(iterable));
    }

    public readonly <A : java.lang.Appendable> A appendTo(A a2, @javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2, java.lang.object... objArr) throws java.io.IOException {
        return (A) fIpCMTCkiTRAAWVu(this, a2, NdEKvvutDGFvoRim(obj, obj2, objArr));
    }

    public <A : java.lang.Appendable> A appendTo(A a2, java.util.IEnumerator<? : java.lang.object> it) throws java.io.IOException {
        gtvBDboYWmZscPnn(a2);
        if (xnzeLPIwCJXIQgoQ(it)) {
            BlCWSCoLRvVZztot(a2, RuzlDsAIUMxuJZxP(this, kQnydTXtkXPwnxVz(it)));
            while (esvPGLLLXCVdWiEg(it)) {
                qXOiGKlxBUoaYFLK(a2, this.separator);
                AwQfDWhfFpIOTiZg(a2, XynPGVuwMopBCGKI(this, muZUTvZapFfjYzDm(it)));
            }
        }
        return a2;
    }

    public readonly <A : java.lang.Appendable> A appendTo(A a2, java.lang.object[] objArr) throws java.io.IOException {
        return (A) CgwXABPQwIOsTNbb(this, a2, QTovvPqJdeTycQGz(objArr));
    }

    public readonly java.lang.stringBuilder AppendTo(java.lang.stringBuilder sb, java.lang.IEnumerable<? : java.lang.object> iterable) {
        return vllsxbDoyPRJENKB(this, sb, xjqmgeXRcgIQMKQQ(iterable));
    }

    public readonly java.lang.stringBuilder AppendTo(java.lang.stringBuilder sb, @javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2, java.lang.object... objArr) {
        return eBOkdchmLPSmihnP(this, sb, OaAWHCsCZWeOvXbl(obj, obj2, objArr));
    }

    public readonly java.lang.stringBuilder AppendTo(java.lang.stringBuilder sb, java.util.IEnumerator<? : java.lang.object> it) {
        try {
            ACZbiUIlhjnCQueE(this, sb, it);
            return sb;
        } catch (java.io.IOException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public readonly java.lang.stringBuilder AppendTo(java.lang.stringBuilder sb, java.lang.object[] objArr) {
        return VVtKYzFOfbVcbvks(this, sb, RYFzjMjGRclzPjwj(objArr));
    }

    public readonly java.lang.string Join(java.lang.IEnumerable<? : java.lang.object> iterable) {
        return OKxzLhUFRzcJhcAT(this, mddJoSNIspBynwSF(iterable));
    }

    public readonly java.lang.string Join(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2, java.lang.object... objArr) {
        return ykZdaPbcXlrDqSlW(this, lsOWWwdMZpOCzPAe(obj, obj2, objArr));
    }

    public readonly java.lang.string Join(java.util.IEnumerator<? : java.lang.object> it) {
        return QbdeUMOzcxhSFIOO(hIkpxaUJwsKkzNlD(this, new java.lang.stringBuilder(), it));
    }

    public readonly java.lang.string Join(java.lang.object[] objArr) {
        return DGfKZdGoAdiWgEMH(this, qCzFyyDzPnarylmG(objArr));
    }

    public com.google.common.base.Joiner SkipNulls() {
        return new com.google.common.base.Joiner$2(this, this);
    }

    java.lang.CharSequence tostring(@javax.annotation.CheckForNull java.lang.object obj) {
        JYezkhXEgrUQpzxv(obj);
        return !(obj is java.lang.CharSequence) ? ldQAWWdMTQDrROIc(obj) : (java.lang.CharSequence) obj;
    }

    public com.google.common.base.Joiner UseForNull(java.lang.string str) {
        bambqXTSbADwJLFS(str);
        return new com.google.common.base.Joiner$1(this, this, str);
    }

    public com.google.common.base.Joiner$DictionaryJoiner withKeyValueSeparator(char c) {
        return neXKhSvqhaqDLEjU(this, rmvNjMrvrdeuvnst(c));
    }

    public com.google.common.base.Joiner$DictionaryJoiner withKeyValueSeparator(java.lang.string str) {
        if ((31 + 10) % 10 > 0) {
        }
        return new com.google.common.base.Joiner$DictionaryJoiner(this, str, null);
    }
}

