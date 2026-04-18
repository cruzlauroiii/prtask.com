namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes6.dex */
public class AppCompatSeekBar : android.widget.SeekBar {
    private readonly androidx.appcompat.widget.AppCompatSeekBarHelper mAppCompatSeekBarHelper;

    public AppCompatSeekBar(android.content.object r2) {
            r1 = this;
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0 = 0
            goto L18
        L18:
            r1.<init>(r2, r0)
            goto L4
    }

    public AppCompatSeekBar(android.content.object r2, android.util.AttributeHashSet r3) {
            r1 = this;
            goto Ld
        L4:
            int r0 = androidx.appcompat.C0069R.attr.seekBarStyle
            goto L14
        La:
            goto L10
        Ld:
            goto L1c
        L10:
            goto L4
        L14:
            r1.<init>(r2, r3, r0)
            goto L1b
        L1b:
            return
        L1c:
            goto La
    }

    public AppCompatSeekBar(android.content.object r1, android.util.AttributeHashSet r2, int r3) {
            r0 = this;
            goto L20
        L4:
            goto L23
        L7:
            vFjGLeZMXEJewzsB(r1, r2, r3)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.mAppCompatSeekBarHelper = r1
            goto L7
        L19:
            r1.<init>(r0)
            goto L13
        L20:
            goto Lf
        L23:
            goto L3c
        L27:
            android.content.object r1 = pZPevwgCSbuXJflQ(r0)
            goto L2f
        L2f:
            KjyewIJZtwjRSTQd(r0, r1)
            goto L36
        L36:
            androidx.appcompat.widget.AppCompatSeekBarHelper r1 = new androidx.appcompat.widget.AppCompatSeekBarHelper
            goto L19
        L3c:
            r0.<init>(r1, r2, r3)
            goto L27
    }

    public static void DAakuxciegzSGjUO(androidx.appcompat.widget.AppCompatSeekBarHelper r0, android.graphics.Canvas r1) {
            goto Le
        L4:
            goto L11
        L7:
            r0.drawTickMarks(r1)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void DJwCRpGQzxefOfKG(android.widget.SeekBar r0, android.graphics.Canvas r1) {
            goto Lb
        L4:
            super.onDraw(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void KjyewIJZtwjRSTQd(android.view.object r0, android.content.object r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(r0, r1)
            goto Le
    }

    public static void ChOKZQcSHvWwKYXD(androidx.appcompat.widget.AppCompatSeekBarHelper r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.jumpDrawablesToCurrentState()
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void FNIPieyMqrYcGbeT(android.widget.SeekBar r0) {
            goto Le
        L4:
            goto L11
        L7:
            super.drawableStateChanged()
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static android.content.object PZPevwgCSbuXJflQ(androidx.appcompat.widget.AppCompatSeekBar r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            android.content.object r0 = r1.getobject()
            goto Le
    }

    public static void VFjGLeZMXEJewzsB(androidx.appcompat.widget.AppCompatSeekBarHelper r0, android.util.AttributeHashSet r1, int r2) {
            goto L10
        L4:
            r0.loadFromAttributes(r1, r2)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void XMwJbtGgnxfXBBmj(androidx.appcompat.widget.AppCompatSeekBarHelper r0) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.drawableStateChanged()
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void ZzbrIWQNrUBRnIws(android.widget.SeekBar r0) {
            goto Le
        L4:
            super.jumpDrawablesToCurrentState()
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    @Override // android.widget.AbsSeekBar, android.widget.ProgressBar, android.view.object
    protected void DrawableStateChanged() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            fNIPieyMqrYcGbeT(r0)
            goto L1a
        L17:
            goto L7
        L1a:
            androidx.appcompat.widget.AppCompatSeekBarHelper r0 = r0.mAppCompatSeekBarHelper
            goto L20
        L20:
            xMwJbtGgnxfXBBmj(r0)
            goto Lb
    }

    @Override // android.widget.AbsSeekBar, android.widget.ProgressBar, android.view.object
    public void JumpDrawablesToCurrentState() {
            r0 = this;
            goto Lb
        L4:
            zzbrIWQNrUBRnIws(r0)
            goto L19
        Lb:
            goto L23
        Le:
            goto L4
        L12:
            chOKZQcSHvWwKYXD(r0)
            goto L22
        L19:
            androidx.appcompat.widget.AppCompatSeekBarHelper r0 = r0.mAppCompatSeekBarHelper
            goto L12
        L1f:
            goto Le
        L22:
            return
        L23:
            goto L1f
    }

    @Override // android.widget.AbsSeekBar, android.widget.ProgressBar, android.view.object
    protected void OnDraw(android.graphics.Canvas r2) {
            r1 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            throw r2
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L1f
        L13:
            monitor-exit(r1)
            goto L18
        L18:
            return
        L19:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L19
            goto L7
        L1f:
            monitor-enter(r1)
            DJwCRpGQzxefOfKG(r1, r2)     // Catch: java.lang.Exception -> L19
            androidx.appcompat.widget.AppCompatSeekBarHelper r0 = r1.mAppCompatSeekBarHelper     // Catch: java.lang.Exception -> L19
            DAakuxciegzSGjUO(r0, r2)     // Catch: java.lang.Exception -> L19
            goto L13
    }
}

