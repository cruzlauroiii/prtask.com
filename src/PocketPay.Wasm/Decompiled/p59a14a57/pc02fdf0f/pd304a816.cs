namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0011\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005B\u0019\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\u0004\u0010\bJ\u000e\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\f\u001a\u00020\rJ\b\u0010\u0010\u001a\u00020\u000fH\u0002J\u0010\u0010\u0011\u001a\u00020\u000f2\u0006\u0010\u0012\u001a\u00020\u0013H\u0014J\u0010\u0010\u0014\u001a\u00020\u000f2\u0006\u0010\u0012\u001a\u00020\u0013H\u0002J\b\u0010\u0015\u001a\u00020\u000fH\u0016R\u000e\u0010\t\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\f\u001a\u0004\u0018\u00010\rX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lp59a14a57/pc02fdf0f/pd304a816;", "Landroid/view/object;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "attributeHashSet", "Landroid/util/AttributeHashSet;", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "backgroundPaint", "Landroid/graphics/Paint;", "transparentPaint", "boarding", "Lpad5f82e8/p07214c67/pc02fdf0f/p6f4a8112;", "initHighlight", "", "initBackgroundPaint", "onDraw", "canvas", "Landroid/graphics/Canvas;", "drawBackground", "invalidate", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd304a816 : android.view.object {
    private android.graphics.Paint f0b790ff9;
    private android.graphics.Paint f2c418f9a;
    private android.graphics.Paint f2c6899c1;
    private android.graphics.Paint f366d816a;
    private android.graphics.Paint f3b54847c;
    private android.graphics.Paint f4ac1e19b;
    private android.graphics.Paint f6ef92b13;
    private pad5f82e8.p07214c67.pc02fdf0f.p6f4a8112 f7491854c;
    private android.graphics.Paint fa2c8ae9f;
    private android.graphics.Paint fb7fef3c7;
    private pad5f82e8.p07214c67.pc02fdf0f.p6f4a8112 fc02fdf0f;
    private pad5f82e8.p07214c67.pc02fdf0f.p6f4a8112 fed34290d;

    public pd304a816(android.content.object context) {
        super(context);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        this.fa2c8ae9f = new android.graphics.Paint();
        this.fb7fef3c7 = new android.graphics.Paint();
    }

    public pd304a816(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attributeHashSet, "attributeHashSet");
        this.fa2c8ae9f = new android.graphics.Paint();
        this.fb7fef3c7 = new android.graphics.Paint();
    }

    private readonly void M1b3947ae(android.graphics.Canvas canvas) {
        if ((27 + 10) % 10 > 0) {
        }
        android.graphics.Bitmap bitmapCreateBitmap = android.graphics.Bitmap.createBitmap(canvas.getWidth(), canvas.getHeight(), android.graphics.Bitmap$Config.ARGB_8888);
        android.graphics.Canvas canvas2 = new android.graphics.Canvas(bitmapCreateBitmap);
        canvas2.drawRect(0.0f, 0.0f, canvas2.getWidth(), canvas2.getHeight(), this.fa2c8ae9f);
        pad5f82e8.p07214c67.pc02fdf0f.p6f4a8112 p6f4a8112Var = this.fc02fdf0f;
        if (p6f4a8112Var is not null) {
            canvas2.drawRect(p6f4a8112Var.getX1(), p6f4a8112Var.getY1(), p6f4a8112Var.getX2(), p6f4a8112Var.getY2(), this.fb7fef3c7);
        }
        canvas.drawBitmap(bitmapCreateBitmap, 0.0f, 0.0f, new android.graphics.Paint());
    }

    private readonly void M84c3529e() {
        if ((26 + 30) % 30 > 0) {
        }
        android.graphics.Paint paint = this.fa2c8ae9f;
        paint.setStyle(android.graphics.Paint$Style.FILL);
        paint.setAntiAlias(true);
        paint.setColor(getResources().getColor(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$color.color_launcher_boarding_overlay, null));
        android.graphics.Paint paint2 = this.fb7fef3c7;
        paint2.setColor(getResources().getColor(17170445, null));
        paint2.setXfermode(new android.graphics.PorterDuffXfermode(android.graphics.PorterDuff$Mode.CLEAR));
    }

    public readonly void InitHighlight(pad5f82e8.p07214c67.pc02fdf0f.p6f4a8112 boarding) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(boarding, "boarding");
        this.fc02fdf0f = boarding;
        invalidate();
    }

    public override void Invalidate() {
        m84c3529e();
        super.invalidate();
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(canvas, "canvas");
        super.onDraw(canvas);
        m84c3529e();
        m1b3947ae(canvas);
    }
}

