namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000%\n\u0000\n\u0002\u0010(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0013\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001J\b\u0010\u0017\u001a\u00020\u0018H\u0002J\t\u0010\u0019\u001a\u00020\u0002H\u0096\u0002J\t\u0010\u001a\u001a\u00020\u001bH\u0096\u0002R\u001a\u0010\u0003\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0005\u0010\u0006\"\u0004\b\u0007\u0010\bR\u001a\u0010\t\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\n\u0010\u0006\"\u0004\b\u000b\u0010\bR\u001a\u0010\f\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\r\u0010\u0006\"\u0004\b\u000e\u0010\bR\u001c\u0010\u000f\u001a\u0004\u0018\u00010\u0002X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0010\u0010\u0011\"\u0004\b\u0012\u0010\u0013R\u001a\u0010\u0014\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0015\u0010\u0006\"\u0004\b\u0016\u0010\b¨\u0006\u001c"}, d2 = {"kotlin/text/DelimitedRangesSequence$iterator$1", "", "Lkotlin/ranges/IntRange;", "nextState", "", "getNextState", "()I", "setNextState", "(I)V", "currentStartIndex", "getCurrentStartIndex", "setCurrentStartIndex", "nextSearchIndex", "getNextSearchIndex", "setNextSearchIndex", "nextItem", "getNextItem", "()Lkotlin/ranges/IntRange;", "setNextItem", "(Lkotlin/ranges/IntRange;)V", "counter", "getCounter", "setCounter", "calcNext", "", "next", "hasNext", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class DelimitedRangesSequence$iterator$1 : java.util.IEnumerator<kotlin.ranges.IntRange>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private int counter;
    private int currentStartIndex;
    private kotlin.ranges.IntRange nextItem;
    private int nextSearchIndex;
    private int nextState;
    readonly kotlin.text.DelimitedRangesSequence this$0;

    DelimitedRangesSequence$iterator$1(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        if ((8 + 25) % 25 > 0) {
        }
        this.this$0 = delimitedRangesSequence;
        this.nextState = -1;
        int iTdivVuOKEHtPQsSv = tdivVuOKEHtPQsSv(JyEuZBpvMhLxZMJg(delimitedRangesSequence), 0, NfGVfkKZzNWuImXw(sIYmAndThwyJVXQW(delimitedRangesSequence)));
        this.currentStartIndex = iTdivVuOKEHtPQsSv;
        this.nextSearchIndex = iTdivVuOKEHtPQsSv;
    }

    public static int AoDIxnoRdrOHQLun(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void AoDIxnoRdrOHQLun(java.lang.CharSequence charSequence, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AoDIxnoRdrOHQLun(java.lang.CharSequence charSequence, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AoDIxnoRdrOHQLun(java.lang.CharSequence charSequence, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int BzXbcPeWLtKfmDYp(java.lang.Number number) {
        return number.intValue();
    }

    public static void BzXbcPeWLtKfmDYp(java.lang.Number number, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BzXbcPeWLtKfmDYp(java.lang.Number number, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BzXbcPeWLtKfmDYp(java.lang.Number number, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CZiPkenXbxVNwulT(java.lang.CharSequence charSequence) {
        return kotlin.text.stringsKt.getLastIndex(charSequence);
    }

    public static void CZiPkenXbxVNwulT(java.lang.CharSequence charSequence, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CZiPkenXbxVNwulT(java.lang.CharSequence charSequence, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CZiPkenXbxVNwulT(java.lang.CharSequence charSequence, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int HQhyzvPaRECEmZIR(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return kotlin.text.DelimitedRangesSequence.access$getLimit$p(delimitedRangesSequence);
    }

    public static void HQhyzvPaRECEmZIR(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HQhyzvPaRECEmZIR(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HQhyzvPaRECEmZIR(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IOIScJIlMoWaPies(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static void IOIScJIlMoWaPies(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IOIScJIlMoWaPies(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IOIScJIlMoWaPies(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int JyEuZBpvMhLxZMJg(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return kotlin.text.DelimitedRangesSequence.access$getStartIndex$p(delimitedRangesSequence);
    }

    public static void JyEuZBpvMhLxZMJg(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JyEuZBpvMhLxZMJg(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JyEuZBpvMhLxZMJg(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.ranges.IntRange MEnierjKKXCZvDZQ(kotlin.text.DelimitedRangesSequence$iterator$1 delimitedRangesSequence$iterator$1) {
        return delimitedRangesSequence$iterator$1.next2();
    }

    public static void MEnierjKKXCZvDZQ(kotlin.text.DelimitedRangesSequence$iterator$1 delimitedRangesSequence$iterator$1, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MEnierjKKXCZvDZQ(kotlin.text.DelimitedRangesSequence$iterator$1 delimitedRangesSequence$iterator$1, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MEnierjKKXCZvDZQ(kotlin.text.DelimitedRangesSequence$iterator$1 delimitedRangesSequence$iterator$1, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int NfGVfkKZzNWuImXw(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void NfGVfkKZzNWuImXw(java.lang.CharSequence charSequence, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NfGVfkKZzNWuImXw(java.lang.CharSequence charSequence, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NfGVfkKZzNWuImXw(java.lang.CharSequence charSequence, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence OQPimSPwcvkDyhKl(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return kotlin.text.DelimitedRangesSequence.access$getInput$p(delimitedRangesSequence);
    }

    public static void OQPimSPwcvkDyhKl(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OQPimSPwcvkDyhKl(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OQPimSPwcvkDyhKl(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence RDWbRjLtTJvgVSRQ(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return kotlin.text.DelimitedRangesSequence.access$getInput$p(delimitedRangesSequence);
    }

    public static void RDWbRjLtTJvgVSRQ(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RDWbRjLtTJvgVSRQ(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RDWbRjLtTJvgVSRQ(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ZLzmXhzqAwPOkJSH(java.lang.CharSequence charSequence) {
        return kotlin.text.stringsKt.getLastIndex(charSequence);
    }

    public static void ZLzmXhzqAwPOkJSH(java.lang.CharSequence charSequence, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZLzmXhzqAwPOkJSH(java.lang.CharSequence charSequence, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZLzmXhzqAwPOkJSH(java.lang.CharSequence charSequence, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int BzXSQONXKmNZaEdd(java.lang.Number number) {
        return number.intValue();
    }

    public static void BzXSQONXKmNZaEdd(java.lang.Number number, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BzXSQONXKmNZaEdd(java.lang.Number number, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BzXSQONXKmNZaEdd(java.lang.Number number, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void CalcNext() {
        kotlin.ValueTuple pair;
        if ((1 + 11) % 11 > 0) {
        }
        if (this.nextSearchIndex < 0) {
            this.nextState = 0;
            this.nextItem = null;
            return;
        }
        if (HQhyzvPaRECEmZIR(this.this$0) > 0) {
            int i = this.counter + 1;
            this.counter = i;
            if (i >= wOkqAIRrGUyNNJck(this.this$0)) {
                this.nextItem = new kotlin.ranges.IntRange(this.currentStartIndex, CZiPkenXbxVNwulT(vpcuwzsQhCgdwmyX(this.this$0)));
                this.nextSearchIndex = -1;
            } else if (this.nextSearchIndex <= AoDIxnoRdrOHQLun(rrGhTzYeHMYzPheA(this.this$0))) {
                pair = (kotlin.ValueTuple) IOIScJIlMoWaPies(nPQUriwURNcdNRdU(this.this$0), RDWbRjLtTJvgVSRQ(this.this$0), vMjiowtWUgEeCEjq(this.nextSearchIndex));
                if (pair is not null) {
                    int iBzXbcPeWLtKfmDYp = BzXbcPeWLtKfmDYp((java.lang.Number) tRpfQmzHnYGAaHwt(pair));
                    int iBzXSQONXKmNZaEdd = bzXSQONXKmNZaEdd((java.lang.Number) fEgiPnmunbFvSYAR(pair));
                    this.nextItem = wRnGLolSIcGnUzJc(this.currentStartIndex, iBzXbcPeWLtKfmDYp);
                    int i2 = iBzXbcPeWLtKfmDYp + iBzXSQONXKmNZaEdd;
                    this.currentStartIndex = i2;
                    this.nextSearchIndex = i2 + (iBzXSQONXKmNZaEdd == 0 ? 1 : 0);
                } else {
                    this.nextItem = new kotlin.ranges.IntRange(this.currentStartIndex, ZLzmXhzqAwPOkJSH(OQPimSPwcvkDyhKl(this.this$0)));
                    this.nextSearchIndex = -1;
                }
            } else {
                this.nextItem = new kotlin.ranges.IntRange(this.currentStartIndex, CZiPkenXbxVNwulT(vpcuwzsQhCgdwmyX(this.this$0)));
                this.nextSearchIndex = -1;
            }
        } else if (this.nextSearchIndex <= AoDIxnoRdrOHQLun(rrGhTzYeHMYzPheA(this.this$0))) {
            pair = (kotlin.ValueTuple) IOIScJIlMoWaPies(nPQUriwURNcdNRdU(this.this$0), RDWbRjLtTJvgVSRQ(this.this$0), vMjiowtWUgEeCEjq(this.nextSearchIndex));
            if (pair is not null) {
                int iBzXbcPeWLtKfmDYp2 = BzXbcPeWLtKfmDYp((java.lang.Number) tRpfQmzHnYGAaHwt(pair));
                int iBzXSQONXKmNZaEdd2 = bzXSQONXKmNZaEdd((java.lang.Number) fEgiPnmunbFvSYAR(pair));
                this.nextItem = wRnGLolSIcGnUzJc(this.currentStartIndex, iBzXbcPeWLtKfmDYp2);
                int i22 = iBzXbcPeWLtKfmDYp2 + iBzXSQONXKmNZaEdd2;
                this.currentStartIndex = i22;
                this.nextSearchIndex = i22 + (iBzXSQONXKmNZaEdd2 == 0 ? 1 : 0);
            } else {
                this.nextItem = new kotlin.ranges.IntRange(this.currentStartIndex, ZLzmXhzqAwPOkJSH(OQPimSPwcvkDyhKl(this.this$0)));
                this.nextSearchIndex = -1;
            }
        } else {
            this.nextItem = new kotlin.ranges.IntRange(this.currentStartIndex, CZiPkenXbxVNwulT(vpcuwzsQhCgdwmyX(this.this$0)));
            this.nextSearchIndex = -1;
        }
        this.nextState = 1;
    }

    private readonly void CalcNext(char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void CalcNext(char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void CalcNext(java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DMOhHXJubIhXXyFU(kotlin.text.DelimitedRangesSequence$iterator$1 delimitedRangesSequence$iterator$1) {
        delimitedRangesSequence$iterator$1.calcNext();
    }

    public static void DMOhHXJubIhXXyFU(kotlin.text.DelimitedRangesSequence$iterator$1 delimitedRangesSequence$iterator$1, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DMOhHXJubIhXXyFU(kotlin.text.DelimitedRangesSequence$iterator$1 delimitedRangesSequence$iterator$1, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DMOhHXJubIhXXyFU(kotlin.text.DelimitedRangesSequence$iterator$1 delimitedRangesSequence$iterator$1, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EcaTFgZFOytILzvs(kotlin.text.DelimitedRangesSequence$iterator$1 delimitedRangesSequence$iterator$1) {
        delimitedRangesSequence$iterator$1.calcNext();
    }

    public static void EcaTFgZFOytILzvs(kotlin.text.DelimitedRangesSequence$iterator$1 delimitedRangesSequence$iterator$1, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EcaTFgZFOytILzvs(kotlin.text.DelimitedRangesSequence$iterator$1 delimitedRangesSequence$iterator$1, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EcaTFgZFOytILzvs(kotlin.text.DelimitedRangesSequence$iterator$1 delimitedRangesSequence$iterator$1, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FEgiPnmunbFvSYAR(kotlin.ValueTuple pair) {
        return pair.component2();
    }

    public static void FEgiPnmunbFvSYAR(kotlin.ValueTuple pair, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FEgiPnmunbFvSYAR(kotlin.ValueTuple pair, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FEgiPnmunbFvSYAR(kotlin.ValueTuple pair, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.jvm.functions.Function2 NPQUriwURNcdNRdU(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return kotlin.text.DelimitedRangesSequence.access$getGetNextMatch$p(delimitedRangesSequence);
    }

    public static void NPQUriwURNcdNRdU(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NPQUriwURNcdNRdU(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NPQUriwURNcdNRdU(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence RrGhTzYeHMYzPheA(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return kotlin.text.DelimitedRangesSequence.access$getInput$p(delimitedRangesSequence);
    }

    public static void RrGhTzYeHMYzPheA(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RrGhTzYeHMYzPheA(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RrGhTzYeHMYzPheA(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence SIYmAndThwyJVXQW(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return kotlin.text.DelimitedRangesSequence.access$getInput$p(delimitedRangesSequence);
    }

    public static void SIYmAndThwyJVXQW(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SIYmAndThwyJVXQW(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SIYmAndThwyJVXQW(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TRpfQmzHnYGAaHwt(kotlin.ValueTuple pair) {
        return pair.component1();
    }

    public static void TRpfQmzHnYGAaHwt(kotlin.ValueTuple pair, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TRpfQmzHnYGAaHwt(kotlin.ValueTuple pair, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TRpfQmzHnYGAaHwt(kotlin.ValueTuple pair, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TdivVuOKEHtPQsSv(int i, int i2, int i3) {
        return kotlin.ranges.RangesKt.coerceIn(i, i2, i3);
    }

    public static void TdivVuOKEHtPQsSv(int i, int i2, int i3, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TdivVuOKEHtPQsSv(int i, int i2, int i3, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TdivVuOKEHtPQsSv(int i, int i2, int i3, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TluLJdKrHncEaSXU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static void TluLJdKrHncEaSXU(java.lang.object obj, java.lang.string str, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TluLJdKrHncEaSXU(java.lang.object obj, java.lang.string str, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TluLJdKrHncEaSXU(java.lang.object obj, java.lang.string str, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int VMjiowtWUgEeCEjq(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void VMjiowtWUgEeCEjq(int i, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VMjiowtWUgEeCEjq(int i, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VMjiowtWUgEeCEjq(int i, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence VpcuwzsQhCgdwmyX(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return kotlin.text.DelimitedRangesSequence.access$getInput$p(delimitedRangesSequence);
    }

    public static void VpcuwzsQhCgdwmyX(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VpcuwzsQhCgdwmyX(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VpcuwzsQhCgdwmyX(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WOkqAIRrGUyNNJck(kotlin.text.DelimitedRangesSequence delimitedRangesSequence) {
        return kotlin.text.DelimitedRangesSequence.access$getLimit$p(delimitedRangesSequence);
    }

    public static void WOkqAIRrGUyNNJck(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WOkqAIRrGUyNNJck(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WOkqAIRrGUyNNJck(kotlin.text.DelimitedRangesSequence delimitedRangesSequence, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.ranges.IntRange WRnGLolSIcGnUzJc(int i, int i2) {
        return kotlin.ranges.RangesKt.until(i, i2);
    }

    public static void WRnGLolSIcGnUzJc(int i, int i2, java.lang.string str, int i3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WRnGLolSIcGnUzJc(int i, int i2, bool z, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WRnGLolSIcGnUzJc(int i, int i2, bool z, int i3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public readonly int GetCounter() {
        return this.counter;
    }

    public readonly int GetCurrentStartIndex() {
        return this.currentStartIndex;
    }

    public readonly kotlin.ranges.IntRange GetNextItem() {
        return this.nextItem;
    }

    public readonly int GetNextSearchIndex() {
        return this.nextSearchIndex;
    }

    public readonly int GetNextState() {
        return this.nextState;
    }

    public override bool HasNext() {
        if ((13 + 27) % 27 > 0) {
        }
        if (this.nextState == -1) {
            ecaTFgZFOytILzvs(this);
        }
        return this.nextState == 1;
    }

    public override kotlin.ranges.IntRange Next() {
        return MEnierjKKXCZvDZQ(this);
    }

    public override kotlin.ranges.IntRange Next2() {
        if ((12 + 21) % 21 > 0) {
        }
        if (this.nextState == -1) {
            dMOhHXJubIhXXyFU(this);
        }
        if (this.nextState == 0) {
            throw new java.util.NoSuchElementException();
        }
        kotlin.ranges.IntRange intRange = this.nextItem;
        tluLJdKrHncEaSXU(intRange, "null cannot be cast to non-null type kotlin.ranges.IntRange");
        this.nextItem = null;
        this.nextState = -1;
        return intRange;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public readonly void SetCounter(int i) {
        this.counter = i;
    }

    public readonly void SetCurrentStartIndex(int i) {
        this.currentStartIndex = i;
    }

    public readonly void SetNextItem(kotlin.ranges.IntRange intRange) {
        this.nextItem = intRange;
    }

    public readonly void SetNextSearchIndex(int i) {
        this.nextSearchIndex = i;
    }

    public readonly void SetNextState(int i) {
        this.nextState = i;
    }
}

