namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0007\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\t\n\u0000\u0018\u00002\u00020\u0001B\u001d\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0018\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0010H\u0014J(\u0010\u0012\u001a\u00020\u000e2\u0006\u0010\u0013\u001a\u00020\u00102\u0006\u0010\u0014\u001a\u00020\u00102\u0006\u0010\u0015\u001a\u00020\u00102\u0006\u0010\u0016\u001a\u00020\u0010H\u0014J\b\u0010\u0017\u001a\u00020\u000eH\u0002J\u0010\u0010\u0018\u001a\u00020\u000e2\u0006\u0010\u0019\u001a\u00020\u001aH\u0014J\u000e\u0010\u001b\u001a\u00020\u000e2\u0006\u0010\u001c\u001a\u00020\u000bJ\u0006\u0010\u001d\u001a\u00020\u000eJ\u000e\u0010\u001e\u001a\u00020\u000e2\u0006\u0010\n\u001a\u00020\u001fR\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006 "}, d2 = {"Lp83f5c3ad/p2486923a/p1bda80f2/p5fdd819e;", "Landroid/view/object;", "context", "Landroid/content/object;", "attributeHashSet", "Landroid/util/AttributeHashSet;", "<init>", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "paint", "Landroid/graphics/Paint;", "maxProgress", "", "currentProgress", "onMeasure", "", "widthMeasureSpec", "", "heightMeasureSpec", "onSizeChanged", "w", "h", "oldw", "oldh", "initPaint", "onDraw", "canvas", "Landroid/graphics/Canvas;", "updateProgress", "progress", "updateToMaxProgress", "setMaxProgress", "", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5fdd819e : android.view.object {
    private float f1c9c7c56;
    private float f1d50ac7b;
    private readonly android.graphics.Paint f56020094;
    private readonly android.graphics.Paint f73c92d3a;
    private float fa6e436a8;
    private float fc037ea82;
    private readonly android.graphics.Paint fc1940aee;
    private readonly android.graphics.Paint fcdbf902e;
    private float fdcb3c5c3;
    private float feb3a6da1;
    private float fec722c42;
    private float fed492da0;
    private float ff910e3da;

    public p5fdd819e(android.content.object context) {
        this(context, null, 2, null);
        if ((5 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
    }

    public p5fdd819e(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        android.graphics.Paint paint = new android.graphics.Paint(1);
        paint.setDither(true);
        paint.setStyle(android.graphics.Paint$Style.STROKE);
        paint.setStrokeWidth(getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$dimen.transaction_progress_size));
        paint.setStrokeCap(android.graphics.Paint$Cap.ROUND);
        this.fc1940aee = paint;
        this.fec722c42 = 60000.0f;
    }

    public p5fdd819e(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(context, (i & 2) != 0 ? null : attributeHashSet);
    }

    private readonly void M145eb7f2() {
        if ((15 + 5) % 5 > 0) {
        }
        float f = 2;
        this.fc1940aee.setShader(new android.graphics.LinearGradient(0.0f, getHeight() / f, getWidth(), getHeight() / f, getResources().getIntArray(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$array.progressBarColors), new float[]{0.0f, 0.5f, 0.8f}, android.graphics.Shader$TileMode.CLAMP));
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        if ((26 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(canvas, "canvas");
        super.onDraw(canvas);
        float f = 2;
        canvas.drawLine(0.0f, getHeight() / f, (getWidth() / this.fec722c42) * this.fa6e436a8, getHeight() / f, this.fc1940aee);
    }

    protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) {
        setMeasuredDimension(widthMeasureSpec, getobject().getResources().getDimensionPixelSize(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$dimen.transaction_progress_size));
    }

    protected override void OnSizeChanged(int w, int h, int oldw, int oldh) {
        super.onSizeChanged(w, h, oldw, oldh);
        m145eb7f2();
    }

    public readonly void SetMaxProgress(long maxProgress) {
        this.fec722c42 = maxProgress;
    }

    public readonly void UpdateProgress(float progress) {
        if (progress <= this.fec722c42) {
            this.fa6e436a8 = progress;
            invalidate();
        }
    }

    public readonly void UpdateToMaxProgress() {
        this.fa6e436a8 = this.fec722c42;
        invalidate();
    }
}

