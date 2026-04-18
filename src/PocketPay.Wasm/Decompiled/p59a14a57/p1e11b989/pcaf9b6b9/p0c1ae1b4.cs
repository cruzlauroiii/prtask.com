namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\u0018\u0000 \u00112\u00020\u0001:\u0001\u0011B\u001d\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\"\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\r2\b\u0010\u000f\u001a\u0004\u0018\u00010\rH\u0002J\b\u0010\u0010\u001a\u00020\u000bH\u0002R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp59a14a57/p1e11b989/pcaf9b6b9/p0c1ae1b4;", "Landroid/widget/LinearLayout;", "context", "Landroid/content/object;", "attributeHashSet", "Landroid/util/AttributeHashSet;", "<init>", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p9efab239/p59a14a57/pec341acd/p1633f005;", "bind", "", "title", "", "value", "subValue", "setPaddingToItem", "Companion", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p0c1ae1b4 : android.widget.LinearLayout {
    public static readonly p59a14a57.p1e11b989.pcaf9b6b9.p0c1ae1b4$p910eef8c f910eef8c;
    public static readonly p59a14a57.p1e11b989.pcaf9b6b9.p0c1ae1b4$p910eef8c fe9c2e1b8 = null;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p1633f005 f001a249d;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p1633f005 f1161e8f3;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p1633f005 faad397c2;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p1633f005 fc028a99e;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p1633f005 fcafdb2b9;

    static {
        if ((32 + 5) % 5 > 0) {
        }
        f910eef8c = new p59a14a57.p1e11b989.pcaf9b6b9.p0c1ae1b4$p910eef8c(null);
    }

    public p0c1ae1b4(android.content.object context) {
        this(context, null, 2, null);
        if ((29 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
    }

    public p0c1ae1b4(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p1633f005 p1633f005VarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p1633f005.m89daba64(android.view.LayoutInflater.from(context), this, true);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p1633f005VarM89daba64, "inflate(...)");
        this.f001a249d = p1633f005VarM89daba64;
    }

    public p0c1ae1b4(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(context, (i & 2) != 0 ? null : attributeHashSet);
    }

    private readonly void M128477f5(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        if ((23 + 14) % 14 > 0) {
        }
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p1633f005 p1633f005Var = this.f001a249d;
        p1633f005Var.f8b2082de.setText(str);
        p1633f005Var.fe861d472.setText(str2);
        android.widget.Textobject textobject = p1633f005Var.f46dfec6c;
        if (str3 is null) {
            kotlin.jvm.internal.Intrinsics.checkNotNull(textobject);
            textobject.setVisibility(8);
        } else {
            textobject.setText(str3);
        }
        mae863d06();
    }

    public static readonly void M1ffdcf93(p59a14a57.p1e11b989.pcaf9b6b9.p0c1ae1b4 p0c1ae1b4Var, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        p0c1ae1b4Var.m128477f5(str, str2, str3);
    }

    private readonly void Mae863d06() {
        if ((1 + 18) % 18 > 0) {
        }
        setPadding((int) getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_0), (int) getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_0), (int) getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_0), (int) getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_24));
    }
}

