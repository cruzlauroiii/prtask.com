namespace WillowMaze.Wasm.Decompiled;

public class P43cc13e8 : FrameLayout
{
    public static int F0e3b7847;
    public static string F1ea56884;
    private static int F253cb00c;
    private static int F2e87b862;
    public static string F32659863;
    public static int F3a659c02;
    public static int F3e1b7425;
    public static string F4384f147;
    public static int F6d341db5;
    public static string F8014db2c;
    public static int F86e5d0d8;
    public static int F94118821;
    private static int F94ef2e4d;
    public static int Fc6cbf4db;
    public static string Fd6dac95e;
    public static string Fda44f67e;
    public static int Fdc00cbcc;
    private static int Fdcac9125;
    private static int Fe9c00cd9;
    public static string Ffe950fad;
    private int F071451d0;
    private int F0f740dd3;
    private float F1180a13c;
    private int F15aaa82e;
    private int F191ba4de;
    private int F24709280;
    private ValueAnimator F30108994;
    private int F319dd424;
    private float F31db438c;
    private Interpolator F31e0c9bd;
    private ValueAnimator F3af46292;
    private ValueAnimator F4f96aa65;
    private ValueAnimator F5208843e;
    private p43cc13e8$pf6bde74d F67302613;
    private float F70400652;
    private Interpolator F76818240;
    private int F79994ca9;
    private float F8133c783;
    private Interpolator F8fe1bc56;
    private Interpolator F95dcf55c;
    private int F9ed39e2e;
    private int Fb85ec314;
    private float Fb982385b;
    private int Fc59796d6;
    private p43cc13e8$pf6bde74d Fd0b62cf0;
    private Interpolator Fd34fb590;
    private int Fda163942;
    private float Fdbbcb7ef;
    private float Fe92d51ed;
    private int Fecab859f;
    private float Fef763cd7;
    private float Ffb7b8960;
    private ValueAnimator Fff95d550;

    private static int M26d3284d(p43cc13e8 P0, int P1)
    {
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f9ed39e2e
        return 0;
    }

    private void Md00d8e45(int P0)
    {
        // call: ValueAnimator.setInterpolator
        // call: ValueAnimator.addListener
        // call: ValueAnimator.setDuration
        // call: ValueAnimator.cancel
        // call: p43cc13e8$pa8a8f663.<init>
        // call: p43cc13e8$1.<init>
        // call: ValueAnimator.addUpdateListener
        // call: ValueAnimator.ofFloat
        // call: ValueAnimator.start
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f4f96aa65
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.fb85ec314
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f1180a13c
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f8fe1bc56
        // type: p43cc13e8$pa8a8f663
        // type: p43cc13e8$1
    }

    public void Collapse()
    {
        // call: p43cc13e8.collapse
    }

    public void Collapse(bool P0)
    {
        // call: p43cc13e8.setExpanded
    }

    public void Expand()
    {
        // call: p43cc13e8.expand
    }

    public void Expand(bool P0)
    {
        // call: p43cc13e8.setExpanded
    }

    public int GetDuration()
    {
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.fb85ec314
        return 0;
    }

    public float GetExpansion()
    {
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f1180a13c
        return 0;
    }

    public int GetOrientation()
    {
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.fda163942
        return 0;
    }

    public float GetParallax()
    {
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.ffb7b8960
        return 0;
    }

    public int GetState()
    {
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f9ed39e2e
        return 0;
    }

    public bool IsExpanded()
    {
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f9ed39e2e
        return false;
    }

    private void OnConfigurationChanged(Configuration P0)
    {
        // call: FrameLayout.onConfigurationChanged
        // call: ValueAnimator.cancel
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f4f96aa65
    }

    private void OnMeasure(int P0, int P1)
    {
        // call: object.setTranslationY
        // call: p43cc13e8.getMeasuredWidth
        // call: p43cc13e8.getLayoutDirection
        // call: Math.round
        // call: object.setTranslationX
        // call: p43cc13e8.setMeasuredDimension
        // call: FrameLayout.onMeasure
        // call: p43cc13e8.getMeasuredHeight
        // call: p43cc13e8.getChildCount
        // call: p43cc13e8.setVisibility
        // call: p43cc13e8.getChildAt
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f1180a13c
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.ffb7b8960
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.fda163942
    }

    private void OnRestoreInstanceState(Parcelable P0)
    {
        // str: "dfa36f98b418d2e420d741d6c4583bae729cda366f9e8ac470d062f63d59696e9eacfa8039d34d"
        // str: "55768652c037423b2d40cf29d194bb0a5adaa6f2b802f10ef16a9efa3c8ec4622c4411d166"
        // call: DecryptString.decryptString
        // call: FrameLayout.onRestoreInstanceState
        // call: Dictionary<string, object>.getParcelable
        // call: Dictionary<string, object>.getFloat
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f1180a13c
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f9ed39e2e
    }

    private Parcelable OnSaveInstanceState()
    {
        // str: "c7195a39ca5ca896d560bb37324cd01b624f168a2db66002f95160aa4d478733054beaeebf1520"
        // str: "1f10f293debfd8a275c0d7879a04f41cff184005e4b8fc3c1870167fd353883b6002dc6680"
        // call: DecryptString.decryptString
        // call: Dictionary<string, object>.<init>
        // call: Dictionary<string, object>.putFloat
        // call: Dictionary<string, object>.putParcelable
        // call: p43cc13e8.isExpanded
        // call: FrameLayout.onSaveInstanceState
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f1180a13c
        // type: Dictionary<string, object>
        return default!;
    }

    public void SetDuration(int P0)
    {
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.fb85ec314
    }

    public void SetExpanded(bool P0)
    {
        // call: p43cc13e8.setExpanded
    }

    public void SetExpanded(bool P0, bool P1)
    {
        // call: p43cc13e8.isExpanded
        // call: p43cc13e8.md00d8e45
        // call: p43cc13e8.setExpansion
    }

    public void SetExpansion(float P0)
    {
        // call: p43cc13e8.requestLayout
        // call: p43cc13e8$pf6bde74d.onExpansionUpdate
        // call: p43cc13e8.setVisibility
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f9ed39e2e
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f1180a13c
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.fd0b62cf0
    }

    public void SetInterpolator(Interpolator P0)
    {
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.f8fe1bc56
    }

    public void SetOnExpansionUpdateListener(p43cc13e8$pf6bde74d P0)
    {
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.fd0b62cf0
    }

    public void SetOrientation(int P0)
    {
        // str: "Orientation must be either 0 (horizontal) or 1 (vertical)"
        // call: IllegalArgumentException.<init>
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.fda163942
        // type: IllegalArgumentException
    }

    public void SetParallax(float P0)
    {
        // call: Math.max
        // call: Math.min
        // field: p40fa73c9.pe322176b.paf9805a7.p43cc13e8.ffb7b8960
    }

    public void Toggle()
    {
        // call: p43cc13e8.toggle
    }

    public void Toggle(bool P0)
    {
        // call: p43cc13e8.isExpanded
        // call: p43cc13e8.expand
        // call: p43cc13e8.collapse
    }

}
