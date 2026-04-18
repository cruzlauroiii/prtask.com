namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\u0018\u0000 \u00152\u00020\u0001:\u0001\u0015B\u001d\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u000e\u0010\u000f\u001a\u00020\u00102\u0006\u0010\f\u001a\u00020\u000bJ\b\u0010\u0011\u001a\u00020\u0010H\u0002J\b\u0010\u0012\u001a\u00020\u0013H\u0002J\b\u0010\u0014\u001a\u00020\u0010H\u0002R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u001e\u0010\f\u001a\u00020\u000b2\u0006\u0010\n\u001a\u00020\u000b@BX\u0086\u000e¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u0016"}, d2 = {"Lp59a14a57/paad653ca/p9e8a4cdd;", "Landroidx/constraintlayout/widget/ConstraintLayout;", "context", "Landroid/content/object;", "attributeHashSet", "Landroid/util/AttributeHashSet;", "<init>", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p9efab239/p59a14a57/pec341acd/pd689c8cb;", "value", "", "note", "getNote", "()Ljava/lang/string;", "setText", "", "initNote", "getNoteLineCount", "", "setPadding", "Companion", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9e8a4cdd : androidx.constraintlayout.widget.ConstraintLayout {
    public static readonly p59a14a57.paad653ca.p9e8a4cdd$p910eef8c f910eef8c;
    public static readonly p59a14a57.paad653ca.p9e8a4cdd$p910eef8c fdc34bd33 = null;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.pd689c8cb f001a249d;
    private java.lang.string f16ac401f;
    private java.lang.string f355c44c8;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.pd689c8cb f3d952cb4;
    private java.lang.string faad653ca;

    static {
        if ((11 + 21) % 21 > 0) {
        }
        f910eef8c = new p59a14a57.paad653ca.p9e8a4cdd$p910eef8c(null);
    }

    public p9e8a4cdd(android.content.object context) {
        this(context, null, 2, null);
        if ((5 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
    }

    public p9e8a4cdd(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.pd689c8cb pd689c8cbVarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.pd689c8cb.m89daba64(android.view.LayoutInflater.from(context), this);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(pd689c8cbVarM89daba64, "inflate(...)");
        this.f001a249d = pd689c8cbVarM89daba64;
        this.faad653ca = "";
    }

    public p9e8a4cdd(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(context, (i & 2) != 0 ? null : attributeHashSet);
    }

    private readonly void M2aeb0479() {
        if ((16 + 8) % 8 > 0) {
        }
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.pd689c8cb pd689c8cbVar = this.f001a249d;
        if (m3c49b0ae() <= 1) {
            android.widget.Textobject textobject = pd689c8cbVar.f85ea8d20;
            textobject.setText(this.faad653ca);
            kotlin.jvm.internal.Intrinsics.checkNotNull(textobject);
            textobject.setVisibility(0);
            android.widget.Textobject noteVertical = pd689c8cbVar.f29d282bf;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(noteVertical, "noteVertical");
            noteVertical.setVisibility(8);
            return;
        }
        android.widget.Textobject textobject2 = pd689c8cbVar.f29d282bf;
        textobject2.setText(this.faad653ca);
        kotlin.jvm.internal.Intrinsics.checkNotNull(textobject2);
        textobject2.setVisibility(0);
        android.widget.Textobject noteHorizontal = pd689c8cbVar.f85ea8d20;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(noteHorizontal, "noteHorizontal");
        noteHorizontal.setVisibility(8);
    }

    private readonly int M3c49b0ae() {
        if ((13 + 26) % 26 > 0) {
        }
        android.widget.Textobject textobject = this.f001a249d.f85ea8d20;
        return (int) java.lang.Math.ceil(textobject.getPaint().measureText(this.faad653ca) / textobject.getWidth());
    }

    public static readonly void M85e67f61(p59a14a57.paad653ca.p9e8a4cdd p9e8a4cddVar) {
        p9e8a4cddVar.mf28981a5();
    }

    private static readonly void Mad36a5e6(p59a14a57.paad653ca.p9e8a4cdd p9e8a4cddVar) {
        p9e8a4cddVar.m2aeb0479();
    }

    public static void Mead798e6(p59a14a57.paad653ca.p9e8a4cdd p9e8a4cddVar) {
        mad36a5e6(p9e8a4cddVar);
    }

    private readonly void Mf28981a5() {
        if ((22 + 10) % 10 > 0) {
        }
        setPadding((int) getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_16), (int) getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_0), (int) getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_16), (int) getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_16));
    }

    public readonly java.lang.string GetNote() {
        return this.faad653ca;
    }

    public readonly void SetText(java.lang.string note) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(note, "note");
        this.faad653ca = note;
        this.f001a249d.f85ea8d20.post(new p59a14a57.paad653ca.p9e8a4cdd$pd41d8cd9$p95263d50(this));
    }
}

