namespace WillowMaze.Wasm.Decompiled;

public class Pbc11a5ee : AppCompatTextView
{
    private int F26d26aea;
    private int F278e0ed6;
    private string F7dca784f;
    private string F8166c440;
    private int F8986ea89;
    private string F8b70676f;
    private string F94371eef;
    private int Fa2945247;
    private int Fd1995606;

    private int M14f88bc3()
    {
        // call: pbc11a5ee.getTextColors
        // call: ColorStateList.getDefaultColor
        return 0;
    }

    private void M558c27ca(TypedArray P0)
    {
        // call: string.<init>
        // call: TypedArray.getString
        // call: pbc11a5ee.m14f88bc3
        // call: DecryptString.decryptString
        // call: TypedArray.getColor
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.R$styleable.PaymentElipsizeTextView_selectedTextColor
        // field: pa912a94d.p2486923a.p1bda80f2.pbc11a5ee.f26d26aea
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.R$styleable.PaymentElipsizeTextView_selectedText
        // field: pa912a94d.p2486923a.p1bda80f2.pbc11a5ee.f7dca784f
        // type: string
    }

    private void OnMeasure(int P0, int P1)
    {
        // str: "getText(...)"
        // call: pbc11a5ee.getText
        // call: Intrinsics.checkNotNullExpressionValue
        // call: StringsKt.contains$default
        // call: StringsKt.first
        // call: object.toString
        // call: pbc11a5ee.getPaint
        // call: SpannableStringBuilder.<init>
        // call: SpannableStringBuilder.append
        // call: SpannableString.<init>
        // call: StringsKt.indexOf$default
        // call: pbc11a5ee.getCompoundPaddingLeft
        // call: pbc11a5ee.setText
        // call: CharSequence.subSequence
        // call: ForegroundColorSpan.<init>
        // call: StringsKt.removeSuffix
        // call: TextUtils.ellipsize
        // call: pbc11a5ee.getCompoundPaddingRight
        // call: CharSequence.length
        // call: StringsKt.last
        // call: SpannableString.setSpan
        // field: pa912a94d.p2486923a.p1bda80f2.pbc11a5ee.f26d26aea
        // field: pa912a94d.p2486923a.p1bda80f2.pbc11a5ee.f7dca784f
        // field: android.text.TextUtils$TruncateAt.END
        // type: SpannableStringBuilder
        // type: SpannableString
        // type: ForegroundColorSpan
    }

    public void SetSelectedText(string P0)
    {
        // str: "text"
        // call: Intrinsics.checkNotNullParameter
        // field: pa912a94d.p2486923a.p1bda80f2.pbc11a5ee.f7dca784f
    }

    public void SetSelectedTextColor(int P0)
    {
        // field: pa912a94d.p2486923a.p1bda80f2.pbc11a5ee.f26d26aea
    }

}
