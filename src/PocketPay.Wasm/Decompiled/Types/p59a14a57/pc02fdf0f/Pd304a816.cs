namespace WillowMaze.Wasm.Decompiled;

public class Pd304a816
{
    private Paint F0b790ff9;
    private Paint F2c418f9a;
    private Paint F2c6899c1;
    private Paint F366d816a;
    private Paint F3b54847c;
    private Paint F4ac1e19b;
    private Paint F6ef92b13;
    private p6f4a8112 F7491854c;
    private Paint Fa2c8ae9f;
    private Paint Fb7fef3c7;
    private p6f4a8112 Fc02fdf0f;
    private p6f4a8112 Fed34290d;

    private void M1b3947ae(Canvas P0)
    {
        // call: Canvas.getHeight
        // call: Canvas.drawRect
        // call: Paint.<init>
        // call: Canvas.getWidth
        // call: p6f4a8112.getX1
        // call: Canvas.drawBitmap
        // call: p6f4a8112.getY2
        // call: p6f4a8112.getX2
        // call: p6f4a8112.getY1
        // call: Canvas.<init>
        // call: Bitmap.createBitmap
        // field: p59a14a57.pc02fdf0f.pd304a816.fa2c8ae9f
        // field: p59a14a57.pc02fdf0f.pd304a816.fb7fef3c7
        // field: android.graphics.Bitmap$Config.ARGB_8888
        // field: p59a14a57.pc02fdf0f.pd304a816.fc02fdf0f
        // type: Canvas
        // type: Paint
    }

    private void M84c3529e()
    {
        // call: Paint.setAntiAlias
        // call: pd304a816.getResources
        // call: PorterDuffXfermode.<init>
        // call: Resources.getColor
        // call: Paint.setXfermode
        // call: Paint.setColor
        // call: Paint.setStyle
        // field: android.graphics.PorterDuff$Mode.CLEAR
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$color.color_launcher_boarding_overlay
        // field: p59a14a57.pc02fdf0f.pd304a816.fb7fef3c7
        // field: android.graphics.Paint$Style.FILL
        // field: p59a14a57.pc02fdf0f.pd304a816.fa2c8ae9f
        // type: PorterDuffXfermode
    }

    public void InitHighlight(p6f4a8112 P0)
    {
        // str: "boarding"
        // call: pd304a816.invalidate
        // call: Intrinsics.checkNotNullParameter
        // field: p59a14a57.pc02fdf0f.pd304a816.fc02fdf0f
    }

    public void Invalidate()
    {
        // call: object.invalidate
        // call: pd304a816.m84c3529e
    }

    private void OnDraw(Canvas P0)
    {
        // str: "canvas"
        // call: Intrinsics.checkNotNullParameter
        // call: object.onDraw
        // call: pd304a816.m1b3947ae
        // call: pd304a816.m84c3529e
    }

}
