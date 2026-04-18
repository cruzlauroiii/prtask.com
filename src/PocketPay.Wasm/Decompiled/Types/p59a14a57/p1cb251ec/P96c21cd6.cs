namespace WillowMaze.Wasm.Decompiled;

public class P96c21cd6 : AppCompatTextView
{
    private int F3271f0e1;
    private readonly Paint F429f8fe9;
    private int F515abb6e;
    private readonly Paint F7eae5de6;
    private readonly Paint Fb2de16f9;
    private int Fba6952a1;
    private readonly Paint Fc935be02;

    private void M432b2dd0()
    {
        // call: Paint.setColor
        // call: Paint.setAntiAlias
        // call: Paint.setStyle
        // field: android.graphics.Paint$Style.FILL
        // field: p59a14a57.p1cb251ec.p96c21cd6.fba6952a1
        // field: p59a14a57.p1cb251ec.p96c21cd6.fb2de16f9
    }

    private void M558c27ca(TypedArray P0)
    {
        // call: p96c21cd6.getContext
        // call: TypedArray.getColor
        // call: ContextCompat.getColor
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.CircleTextView_circleColor
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$color.color_accent
        // field: p59a14a57.p1cb251ec.p96c21cd6.fba6952a1
    }

    private void M9a821ad1(Canvas P0)
    {
        // call: p96c21cd6.getWidth
        // call: p96c21cd6.getHeight
        // call: System.Numerics.BigInteger.intValue
        // call: int.valueOf
        // call: p96c21cd6.setWidth
        // call: int.intValue
        // call: Canvas.drawCircle
        // call: p96c21cd6.setHeight
        // field: p59a14a57.p1cb251ec.p96c21cd6.fb2de16f9
    }

    private void OnDraw(Canvas P0)
    {
        // str: "canvas"
        // call: AppCompatTextView.onDraw
        // call: p96c21cd6.m432b2dd0
        // call: Intrinsics.checkNotNullParameter
        // call: p96c21cd6.m9a821ad1
    }

}
