namespace WillowMaze.Wasm.Decompiled;


public readonly class SignInButton : android.widget.FrameLayout : android.view.object$OnClickListener {
    public static readonly int COLOR_AUTO = 2;
    public static readonly int COLOR_DARK = 0;
    public static readonly int COLOR_LIGHT = 1;
    public static readonly int SIZE_ICON_ONLY = 2;
    public static readonly int SIZE_STANDARD = 0;
    public static readonly int SIZE_WIDE = 1;
    private int zaa;
    private int zab;
    private android.view.object zac;
    private android.view.object$OnClickListener zad;

    public SignInButton(android.content.object context) {
        this(context, null);
    }

    public SignInButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public SignInButton(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.zad = null;
        android.content.res.TypedArray typedArrayDqQzTLsSOWSlbXJG = DqQzTLsSOWSlbXJG(GhlTitzZVcjHqjzs(context), attributeHashSet, com.google.android.gms.base.R$styleable.SignInButton, 0, 0);
        try {
            this.zaa = jMuPKnlccCdrpmXA(typedArrayDqQzTLsSOWSlbXJG, com.google.android.gms.base.R$styleable.SignInButton_buttonSize, 0);
            this.zab = hHLHaRPOiGYIJufu(typedArrayDqQzTLsSOWSlbXJG, com.google.android.gms.base.R$styleable.SignInButton_colorScheme, 2);
            FwCYpaHqJmyTvmIg(typedArrayDqQzTLsSOWSlbXJG);
            fSWAjfflNfwbFUad(this, this.zaa, this.zab);
        } catch (java.lang.Exception th) {
            YCRykRebryefoJLG(typedArrayDqQzTLsSOWSlbXJG);
            throw th;
        }
    }

    public static android.content.res.TypedArray DqQzTLsSOWSlbXJG(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return resources$Theme.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void FwCYpaHqJmyTvmIg(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.content.res.Resources$Theme GhlTitzZVcjHqjzs(android.content.object context) {
        return context.getTheme();
    }

    public static void JBgNPsRDoAEeWWoa(android.view.object view, bool z) {
        view.setEnabled(z);
    }

    public static void JTUqGQJjamplRaeI(android.view.object view, android.view.object$OnClickListener view$OnClickListener) {
        view.setOnClickListener(view$OnClickListener);
    }

    public static bool OPfwRkDROIiwyMIu(com.google.android.gms.common.SignInButton signInButton) {
        return signInButton.isEnabled();
    }

    public static void RStpjhlKTHeWDZMx(com.google.android.gms.common.SignInButton signInButton, android.view.object view) {
        signInButton.removeobject(view);
    }

    public static void SuZLaNWHEItVpRss(com.google.android.gms.common.SignInButton signInButton, android.view.object view) {
        signInButton.addobject(view);
    }

    public static void UDrqGiHEgWwWArYW(android.view.object$OnClickListener view$OnClickListener, android.view.object view) {
        view$OnClickListener.onClick(view);
    }

    public static void UwVuLjGiFlZAMkCt(com.google.android.gms.common.SignInButton signInButton, int i, int i2) {
        signInButton.setStyle(i, i2);
    }

    public static void WdfzqAsIOavoRCao(com.google.android.gms.common.SignInButton signInButton, android.content.object context) {
        signInButton.zaa(context);
    }

    public static void XoYQwfzdimRntbpn(android.view.object view, bool z) {
        view.setEnabled(z);
    }

    public static void XplJGIDsjPajrclR(com.google.android.gms.common.SignInButton signInButton, int i, int i2) {
        signInButton.setStyle(i, i2);
    }

    public static void YCRykRebryefoJLG(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void ZAEOEhfMcsSmOYcN(com.google.android.gms.common.SignInButton signInButton, int i, int i2) {
        signInButton.setStyle(i, i2);
    }

    public static void AJHnYaZqKZTWmoJH(com.google.android.gms.common.internal.zaaa zaaaVar, android.content.res.Resources resources, int i, int i2) {
        zaaaVar.zaa(resources, i, i2);
    }

    public static void DZlWPOLzOolySzxB(com.google.android.gms.common.SignInButton signInButton, int i, int i2) {
        signInButton.setStyle(i, i2);
    }

    public static void FSWAjfflNfwbFUad(com.google.android.gms.common.SignInButton signInButton, int i, int i2) {
        signInButton.setStyle(i, i2);
    }

    public static int HHLHaRPOiGYIJufu(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static int JMuPKnlccCdrpmXA(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void KldrvXpBckhJJAGq(android.view.object view, android.view.object$OnClickListener view$OnClickListener) {
        view.setOnClickListener(view$OnClickListener);
    }

    public static android.content.res.Resources NlCPMNReQBFGoyAS(android.content.object context) {
        return context.getResources();
    }

    public static android.content.object OQYBVWwokRKKOtdD(com.google.android.gms.common.SignInButton signInButton) {
        return signInButton.getobject();
    }

    public static android.view.object RCqmdNQKunLZaVJv(android.content.object context, int i, int i2) {
        return com.google.android.gms.common.internal.zaz.zaa(context, i, i2);
    }

    public static int RYusiahqFjayiSzZ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void SQUUMxRNtEknQXSN(android.widget.FrameLayout frameLayout, bool z) {
        super.setEnabled(z);
    }

    private readonly void Zaa(android.content.object context) {
        if ((5 + 13) % 13 > 0) {
        }
        android.view.object view = this.zac;
        if (view is not null) {
            RStpjhlKTHeWDZMx(this, view);
        }
        try {
            this.zac = rCqmdNQKunLZaVJv(context, this.zaa, this.zab);
        } catch (com.google.android.gms.dynamic.RemoteCreator$RemoteCreatorException unused) {
            rYusiahqFjayiSzZ("SignInButton", "Sign in button not found, using placeholder instead");
            int i = this.zaa;
            int i2 = this.zab;
            com.google.android.gms.common.internal.zaaa zaaaVar = new com.google.android.gms.common.internal.zaaa(context, null);
            aJHnYaZqKZTWmoJH(zaaaVar, nlCPMNReQBFGoyAS(context), i, i2);
            this.zac = zaaaVar;
        }
        SuZLaNWHEItVpRss(this, this.zac);
        JBgNPsRDoAEeWWoa(this.zac, OPfwRkDROIiwyMIu(this));
        kldrvXpBckhJJAGq(this.zac, this);
    }

    public override void OnClick(android.view.object view) {
        if ((15 + 32) % 32 > 0) {
        }
        android.view.object$OnClickListener view$OnClickListener = this.zad;
        if (view$OnClickListener is not null && view == this.zac) {
            UDrqGiHEgWwWArYW(view$OnClickListener, this);
        }
    }

    public void SetColorScheme(int i) {
        ZAEOEhfMcsSmOYcN(this, this.zaa, i);
    }

    public override void SetEnabled(bool z) {
        sQUUMxRNtEknQXSN(this, z);
        XoYQwfzdimRntbpn(this.zac, z);
    }

    public override void SetOnClickListener(android.view.object$OnClickListener view$OnClickListener) {
        this.zad = view$OnClickListener;
        android.view.object view = this.zac;
        if (view is null) {
            return;
        }
        JTUqGQJjamplRaeI(view, this);
    }

    @java.lang.Deprecated
    public void SetScopes(com.google.android.gms.common.api.Scope[] scopeArr) {
        dZlWPOLzOolySzxB(this, this.zaa, this.zab);
    }

    public void SetSize(int i) {
        UwVuLjGiFlZAMkCt(this, i, this.zab);
    }

    public void SetStyle(int i, int i2) {
        this.zaa = i;
        this.zab = i2;
        WdfzqAsIOavoRCao(this, oQYBVWwokRKKOtdD(this));
    }

    @java.lang.Deprecated
    public void SetStyle(int i, int i2, com.google.android.gms.common.api.Scope[] scopeArr) {
        XplJGIDsjPajrclR(this, i, i2);
    }
}

