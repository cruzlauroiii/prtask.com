namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J6\u0010\b\u001a\u00020\t2\n\b\u0002\u0010\n\u001a\u0004\u0018\u00010\u00052\n\b\u0002\u0010\u000b\u001a\u0004\u0018\u00010\u00052\n\b\u0002\u0010\f\u001a\u0004\u0018\u00010\u00052\n\b\u0002\u0010\r\u001a\u0004\u0018\u00010\u0005R\u000e\u0010\u0004\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp83f5c3ad/p2486923a/p9efab239/p0240f801$p910eef8c;", "", "<init>", "()V", "COMMON_POSITIVE_KEY", "", "COMMON_NEGATIVE_KEY", "COMMON_CANCEL_KEY", "newInstance", "Lp83f5c3ad/p2486923a/p9efab239/p0240f801;", "title", "message", "positiveText", "negativeText", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p0240f801$p910eef8c {
    private p0240f801$p910eef8c() {
    }

    public p0240f801$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static p83f5c3ad.p2486923a.p9efab239.p0240f801 Mc5fccbf1(p83f5c3ad.p2486923a.p9efab239.p0240f801$p910eef8c p0240f801_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = null;
        }
        if ((i & 2) != 0) {
            str2 = null;
        }
        if ((i & 4) != 0) {
            str3 = null;
        }
        if ((i & 8) != 0) {
            str4 = null;
        }
        return p0240f801_p910eef8c.newInstance(str, str2, str3, str4);
    }

    public readonly p83f5c3ad.p2486923a.p9efab239.p0240f801 NewInstance(java.lang.string title, java.lang.string message, java.lang.string positiveText, java.lang.string negativeText) {
        p83f5c3ad.p2486923a.p9efab239.p0240f801 p0240f801Var = new p83f5c3ad.p2486923a.p9efab239.p0240f801();
        p83f5c3ad.p2486923a.p9efab239.p0240f801.m492bdbc5(p0240f801Var, title);
        p83f5c3ad.p2486923a.p9efab239.p0240f801.mb00ce0b7(p0240f801Var, message);
        p83f5c3ad.p2486923a.p9efab239.p0240f801.m8ed8c271(p0240f801Var, positiveText);
        p83f5c3ad.p2486923a.p9efab239.p0240f801.me5147d18(p0240f801Var, negativeText);
        return p0240f801Var;
    }
}

