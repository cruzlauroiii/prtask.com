namespace WillowMaze.Wasm.Decompiled;

public class P5fdd819e
{
    private float F1c9c7c56;
    private float F1d50ac7b;
    private readonly Paint F56020094;
    private readonly Paint F73c92d3a;
    private float Fa6e436a8;
    private float Fc037ea82;
    private readonly Paint Fc1940aee;
    private readonly Paint Fcdbf902e;
    private float Fdcb3c5c3;
    private float Feb3a6da1;
    private float Fec722c42;
    private float Fed492da0;
    private float Ff910e3da;

    private void M145eb7f2()
    {
        // call: LinearGradient.<init>
        // call: Paint.setShader
        // call: p5fdd819e.getWidth
        // call: p5fdd819e.getHeight
        // call: p5fdd819e.getResources
        // call: Resources.getIntArray
        // field: p83f5c3ad.p2486923a.p1bda80f2.p5fdd819e.fc1940aee
        // field: android.graphics.Shader$TileMode.CLAMP
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$array.progressBarColors
        // type: LinearGradient
    }

    private void OnDraw(Canvas P0)
    {
        // str: "canvas"
        // call: p5fdd819e.getHeight
        // call: object.onDraw
        // call: Canvas.drawLine
        // call: Intrinsics.checkNotNullParameter
        // call: p5fdd819e.getWidth
        // field: p83f5c3ad.p2486923a.p1bda80f2.p5fdd819e.fc1940aee
        // field: p83f5c3ad.p2486923a.p1bda80f2.p5fdd819e.fa6e436a8
        // field: p83f5c3ad.p2486923a.p1bda80f2.p5fdd819e.fec722c42
    }

    private void OnMeasure(int P0, int P1)
    {
        // call: p5fdd819e.getContext
        // call: Resources.getDimensionPixelSize
        // call: p5fdd819e.setMeasuredDimension
        // call: object.getResources
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$dimen.transaction_progress_size
    }

    private void OnSizeChanged(int P0, int P1, int P2, int P3)
    {
        // call: object.onSizeChanged
        // call: p5fdd819e.m145eb7f2
    }

    public void SetMaxProgress(long P0)
    {
        // field: p83f5c3ad.p2486923a.p1bda80f2.p5fdd819e.fec722c42
    }

    public void UpdateProgress(float P0)
    {
        // call: p5fdd819e.invalidate
        // field: p83f5c3ad.p2486923a.p1bda80f2.p5fdd819e.fec722c42
        // field: p83f5c3ad.p2486923a.p1bda80f2.p5fdd819e.fa6e436a8
    }

    public void UpdateToMaxProgress()
    {
        // call: p5fdd819e.invalidate
        // field: p83f5c3ad.p2486923a.p1bda80f2.p5fdd819e.fec722c42
        // field: p83f5c3ad.p2486923a.p1bda80f2.p5fdd819e.fa6e436a8
    }

}
