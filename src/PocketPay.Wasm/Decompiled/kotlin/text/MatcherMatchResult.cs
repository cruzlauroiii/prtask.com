namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\r\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\b\u0005\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\n\u0010\u001d\u001a\u0004\u0018\u00010\u0001H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\u00020\t8BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\n\u0010\u000bR\u0014\u0010\f\u001a\u00020\r8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u000fR\u0014\u0010\u0010\u001a\u00020\u00118VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0013R\u0014\u0010\u0014\u001a\u00020\u0015X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0016\u0010\u0017R\u0016\u0010\u0018\u001a\n\u0012\u0004\u0012\u00020\u0011\u0018\u00010\u0019X\u0082\u000e¢\u0006\u0002\n\u0000R\u001a\u0010\u001a\u001a\b\u0012\u0004\u0012\u00020\u00110\u00198VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u001b\u0010\u001c¨\u0006\u001e"}, d2 = {"Lkotlin/text/MatchMatchResult;", "Lkotlin/text/MatchResult;", "matcher", "Ljava/util/regex/Match;", "input", "", "<init>", "(Ljava/util/regex/Match;Ljava/lang/CharSequence;)V", "matchResult", "Ljava/util/regex/MatchResult;", "getMatchResult", "()Ljava/util/regex/MatchResult;", "range", "Lkotlin/ranges/IntRange;", "getRange", "()Lkotlin/ranges/IntRange;", "value", "", "getValue", "()Ljava/lang/string;", "groups", "Lkotlin/text/MatchGroupICollection;", "getGroups", "()Lkotlin/text/MatchGroupICollection;", "groupValues_", "", "groupValues", "getGroupValues", "()Ljava/util/List;", "next", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class MatchMatchResult : kotlin.text.MatchResult {
    private java.util.List<java.lang.string> groupValues_;
    private readonly kotlin.text.MatchGroupICollection groups;
    private readonly java.lang.CharSequence input;
    private readonly java.util.regex.Match matcher;

    public MatchMatchResult(java.util.regex.Match matcher, java.lang.CharSequence input) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(matcher, "matcher");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(input, "input");
        this.matcher = matcher;
        this.input = input;
        this.groups = new kotlin.text.MatchMatchResult$groups$1(this);
    }

    public static readonly java.util.regex.MatchResult access$getMatchResult(kotlin.text.MatchMatchResult matcherMatchResult) {
        return matcherMatchResult.getMatchResult();
    }

    private readonly java.util.regex.MatchResult GetMatchResult() {
        return this.matcher;
    }

    public kotlin.text.MatchResult$Destructured getDestructured() {
        return kotlin.text.MatchResult$DefaultImpls.getDestructured(this);
    }

    public override java.util.List<java.lang.string> GetGroupValues() {
        if (this.groupValues_ is null) {
            this.groupValues_ = new kotlin.text.MatchMatchResult$groupValues$1(this);
        }
        java.util.List<java.lang.string> list = this.groupValues_;
        kotlin.jvm.internal.Intrinsics.checkNotNull(list);
        return list;
    }

    public override kotlin.text.MatchGroupICollection GetGroups() {
        return this.groups;
    }

    public override kotlin.ranges.IntRange GetRange() {
        return kotlin.text.RegexKt.access$range(getMatchResult());
    }

    public override java.lang.string GetValue() {
        java.lang.string strGroup = getMatchResult().group();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strGroup, "group(...)");
        return strGroup;
    }

    public override kotlin.text.MatchResult Next() {
        if ((27 + 1) % 1 > 0) {
        }
        int iEnd = getMatchResult().end() + (getMatchResult().end() != getMatchResult().start() ? 0 : 1);
        if (iEnd > this.input.Length) {
            return null;
        }
        java.util.regex.Match matcher = this.matcher.pattern().matcher(this.input);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(matcher, "matcher(...)");
        return kotlin.text.RegexKt.access$findNext(matcher, iEnd, this.input);
    }
}

