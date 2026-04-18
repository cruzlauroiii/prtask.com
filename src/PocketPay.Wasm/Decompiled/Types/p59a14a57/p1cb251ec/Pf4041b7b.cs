namespace WillowMaze.Wasm.Decompiled;

public class Pf4041b7b : TextInputLayout
{
    private FrameLayout F0325924e;
    private FrameLayout F29072c9d;
    private ImageView F2f8473f1;
    private Drawable F3ac53d58;
    private Drawable F3bdbb487;
    private Drawable F476ea345;
    private Drawable F4b27c8e6;
    private ImageView F56fcc810;
    private ImageView F5b1559b7;
    private Drawable F75a875d2;
    private ImageView F7c478722;
    private Drawable Fa020d48b;
    private Drawable Faa288ac2;
    private Drawable Fb44cc43b;
    private FrameLayout Fb86a34ed;
    private ImageView Fca7b4698;
    private ImageView Fd0357cfb;
    private ImageView Fd25b0eff;
    private Drawable Ff80a1743;

    private static void M065c6ff0(Func<object, object> P0, object P1)
    {
        // str: "view"
        // call: Func<object, object>.invoke
        // call: bool.valueOf
        // call: object.isActivated
        // call: Intrinsics.checkNotNullParameter
        // call: object.setActivated
        // field: kotlin.Unit.INSTANCE
    }

    public static void M0dd7de93(Func<object, object> P0, object P1)
    {
        // call: pf4041b7b.md611ad86
    }

    public static void M153dcb9f(Func<object, object> P0, object P1)
    {
        // call: pf4041b7b.m065c6ff0
    }

    private void M558c27ca(TypedArray P0)
    {
        // call: TypedArray.getDrawable
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.TwoEndIconsTextInputLayout_secondEndIcon
        // field: p59a14a57.p1cb251ec.pf4041b7b.f3bdbb487
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.TwoEndIconsTextInputLayout_firstEndIcon
        // field: p59a14a57.p1cb251ec.pf4041b7b.f75a875d2
    }

    private void M5620cc95(object P0)
    {
        // call: object.findViewById
        // call: ImageView.setImageDrawable
        // field: p59a14a57.p1cb251ec.pf4041b7b.fd25b0eff
        // field: p59a14a57.p1cb251ec.pf4041b7b.fd0357cfb
        // field: p59a14a57.p1cb251ec.pf4041b7b.f3bdbb487
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$id.iv_first_end_icon
        // field: p59a14a57.p1cb251ec.pf4041b7b.f75a875d2
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$id.iv_second_end_icon
    }

    private void Mb8c5c249(FrameLayout P0)
    {
        // str: "null cannot be cast to non-null type android.widget.FrameLayout.LayoutParams"
        // call: LayoutInflater.inflate
        // call: object.getLayoutParams
        // call: Intrinsics.checkNotNull
        // call: EditText.getResources
        // call: EditText.setPadding
        // call: FrameLayout.addView
        // call: pf4041b7b.m5620cc95
        // call: EditText.getPaddingTop
        // call: pf4041b7b.getEditText
        // call: pf4041b7b.getContext
        // call: EditText.getPaddingBottom
        // call: EditText.getPaddingStart
        // call: Resources.getDimension
        // call: LayoutInflater.from
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$layout.item_two_end_icons_text_input_layout
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_text_input_layout_icon_size
        // field: android.widget.FrameLayout$LayoutParams.gravity
    }

    private static void Md611ad86(Func<object, object> P0, object P1)
    {
        // str: "view"
        // call: object.isActivated
        // call: Intrinsics.checkNotNullParameter
        // call: object.setActivated
        // call: Func<object, object>.invoke
        // call: bool.valueOf
        // field: kotlin.Unit.INSTANCE
    }

    public void AddView(object P0, int P1, ViewGroup$LayoutParams P2)
    {
        // str: "child"
        // str: "params"
        // call: Intrinsics.checkNotNullParameter
        // call: pf4041b7b.mb8c5c249
        // call: TextInputLayout.addView
        // field: p59a14a57.p1cb251ec.pf4041b7b.f29072c9d
    }

    public void SetFirstIconClickListener(Func<object, object> P0)
    {
        // str: "onFirstIconClick"
        // call: pf4041b7b$pd41d8cd9$pcca4ef0e.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: pf5e18aff.m2fa6d087
        // field: p59a14a57.p1cb251ec.pf4041b7b.fd25b0eff
        // type: pf4041b7b$pd41d8cd9$pcca4ef0e
    }

    public void SetFirstIconVisible(bool P0)
    {
        // call: object.setVisibility
        // field: p59a14a57.p1cb251ec.pf4041b7b.fd25b0eff
    }

    public void SetSecondIconClickListener(Func<object, object> P0)
    {
        // str: "onSecondIconClick"
        // call: Intrinsics.checkNotNullParameter
        // call: pf4041b7b$pd41d8cd9$p95263d50.<init>
        // call: pf5e18aff.m2fa6d087
        // field: p59a14a57.p1cb251ec.pf4041b7b.fd0357cfb
        // type: pf4041b7b$pd41d8cd9$p95263d50
    }

    public void SetSecondIconVisible(bool P0)
    {
        // call: object.setVisibility
        // field: p59a14a57.p1cb251ec.pf4041b7b.fd0357cfb
    }

}
