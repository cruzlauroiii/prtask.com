namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$None : com.google.common.base.CharMatch$NamedFastMatch {
    static readonly com.google.common.base.CharMatch$None INSTANCE = new com.google.common.base.CharMatch$None();

    private CharMatch$None() {
        super("CharMatch.none()");
    }

    public static java.lang.string ERGTuGOYrmBJelZP(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object GRQSaZMFSHFQHATQ(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string GaFUtuBkedwMmACN(java.lang.object obj) {
        return obj.tostring();
    }

    public static int JFzdEkHqVFNDVYww(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.object JQpPnMYcRTjovtuw(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string LhTSHwHPbdavStcd(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string ObBkiPiLMaOFwNVZ(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string QAlQdWbPAzCMsxsB(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object WaMawAmhrMGKZCTA(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string XUJEqHuYqumkkYdv(java.lang.object obj) {
        return obj.tostring();
    }

    public static int BoCbEQltdAUWfRFs(int i, int i2) {
        return com.google.common.base.Preconditions.checkPositionIndex(i, i2);
    }

    public static com.google.common.base.CharMatch DpkDgsnevPFcqTZr() {
        return any();
    }

    public static java.lang.object IpQpLZrfbRGcqkrK(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object LZDCXqISrPCHOOGT(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object PHXxDEVbAnnikoSO(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static int VyRdknsOTuQBKGhh(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.object XVwJAhhkdTgjdbYZ(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string ZccwnnrYgNjRmrci(java.lang.object obj) {
        return obj.tostring();
    }

    public override com.google.common.base.CharMatch And(com.google.common.base.CharMatch charMatch) {
        xVwJAhhkdTgjdbYZ(charMatch);
        return this;
    }

    public override java.lang.string CollapseFrom(java.lang.CharSequence charSequence, char c) {
        return GaFUtuBkedwMmACN(charSequence);
    }

    public override int CountIn(java.lang.CharSequence charSequence) {
        JQpPnMYcRTjovtuw(charSequence);
        return 0;
    }

    public override int IndexIn(java.lang.CharSequence charSequence) {
        GRQSaZMFSHFQHATQ(charSequence);
        return -1;
    }

    public override int IndexIn(java.lang.CharSequence charSequence, int i) {
        boCbEQltdAUWfRFs(i, vyRdknsOTuQBKGhh(charSequence));
        return -1;
    }

    public override int LastIndexIn(java.lang.CharSequence charSequence) {
        WaMawAmhrMGKZCTA(charSequence);
        return -1;
    }

    public override bool Matches(char c) {
        return false;
    }

    public override bool MatchesAllOf(java.lang.CharSequence charSequence) {
        return JFzdEkHqVFNDVYww(charSequence) == 0;
    }

    public override bool MatchesNoneOf(java.lang.CharSequence charSequence) {
        lZDCXqISrPCHOOGT(charSequence);
        return true;
    }

    public override com.google.common.base.CharMatch Negate() {
        return dpkDgsnevPFcqTZr();
    }

    public override com.google.common.base.CharMatch Or(com.google.common.base.CharMatch charMatch) {
        return (com.google.common.base.CharMatch) pHXxDEVbAnnikoSO(charMatch);
    }

    public override java.lang.string RemoveFrom(java.lang.CharSequence charSequence) {
        return XUJEqHuYqumkkYdv(charSequence);
    }

    public override java.lang.string ReplaceFrom(java.lang.CharSequence charSequence, char c) {
        return ObBkiPiLMaOFwNVZ(charSequence);
    }

    public override java.lang.string ReplaceFrom(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        ipQpLZrfbRGcqkrK(charSequence2);
        return zccwnnrYgNjRmrci(charSequence);
    }

    public override java.lang.string TrimFrom(java.lang.CharSequence charSequence) {
        return ERGTuGOYrmBJelZP(charSequence);
    }

    public override java.lang.string TrimLeadingFrom(java.lang.CharSequence charSequence) {
        return LhTSHwHPbdavStcd(charSequence);
    }

    public override java.lang.string TrimTrailingFrom(java.lang.CharSequence charSequence) {
        return QAlQdWbPAzCMsxsB(charSequence);
    }
}

