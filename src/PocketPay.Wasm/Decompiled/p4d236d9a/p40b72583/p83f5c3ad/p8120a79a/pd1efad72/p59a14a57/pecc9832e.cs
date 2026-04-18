namespace WillowMaze.Wasm.Decompiled;


public class pecc9832e {
    private readonly java.lang.ref.WeakReference f00fb0a4a;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 f0c7150e6;
    private readonly java.lang.ref.WeakReference f1a51e31b;
    private readonly java.lang.ref.WeakReference f3a9fcd83;
    private readonly byte[] f3ab4e77f;
    private readonly byte[] f3c6e0b8a;
    private p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2b3583e6.p4c0a1124 f76b4db54;
    private readonly java.lang.ref.WeakReference f8c8b4460;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 f9441ba50;
    private readonly java.lang.ref.WeakReference<android.view.object> fcd2a63b0;
    private readonly byte[] fce9a1ae4;
    private p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2b3583e6.p4c0a1124 fe4fdf329;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 fee424206;

    public pecc9832e(byte[] bArr, android.view.object view, p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 p1b22e7dc_p7142c551) {
        this.f3c6e0b8a = bArr;
        this.f9441ba50 = p1b22e7dc_p7142c551;
        this.fcd2a63b0 = new java.lang.ref.WeakReference<>(view);
    }

    public static int KVuiYRReOMzhDYXE(android.view.object view) {
        return view.getRight();
    }

    public static int MbRZfnLtdwvbvOGY(android.view.object view) {
        return view.getTop();
    }

    public static int MxFkhZSkVghmAhwV(android.view.object view) {
        return view.getTop();
    }

    public static int NaVLqviAxaixapkr(android.view.object view) {
        return view.getBottom();
    }

    public static bool OVdfdpDgDrOhlUat(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2b3583e6.p4c0a1124 p4c0a1124Var, int i, int i2) {
        return p4c0a1124Var.Contains(i, i2);
    }

    public static void PWdZrfLTdeccJxak(java.lang.ref.WeakReference weakReference) {
        weakReference.clear();
    }

    public static int WzQAAnmcELASIsJJ(android.view.object view) {
        return view.getLeft();
    }

    public static int IRogGXbJmrszktGX(android.view.object view) {
        return view.getBottom();
    }

    public static int IisoLWSLyzxJnjoi(android.view.object view) {
        return view.getLeft();
    }

    public static int TZUDVznZrsQOzxCk(android.view.object view) {
        return view.getRight();
    }

    public static java.lang.object WnRTijwSVvlTKnBi(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pecc9832e Calc(int i) {
        if ((31 + 10) % 10 > 0) {
        }
        android.view.object view = (android.view.object) wnRTijwSVvlTKnBi(this.fcd2a63b0);
        this.fe4fdf329 = new p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2b3583e6.p4c0a1124(new int[]{iisoLWSLyzxJnjoi(view), KVuiYRReOMzhDYXE(view), tZUDVznZrsQOzxCk(view), WzQAAnmcELASIsJJ(view)}, new int[]{MxFkhZSkVghmAhwV(view) + i, MbRZfnLtdwvbvOGY(view) + i, NaVLqviAxaixapkr(view) + i, iRogGXbJmrszktGX(view) + i}, 4);
        PWdZrfLTdeccJxak(this.fcd2a63b0);
        return this;
    }

    public bool CheckClickButton(int i, int i2) {
        return OVdfdpDgDrOhlUat(this.fe4fdf329, i, i2);
    }

    public byte[] GetKey() {
        return this.f3c6e0b8a;
    }

    public p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 getPinEntity() {
        return this.f9441ba50;
    }
}

