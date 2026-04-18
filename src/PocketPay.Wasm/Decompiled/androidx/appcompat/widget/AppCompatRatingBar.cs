namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes6.dex */
public class AppCompatRatingBar : android.widget.RatingBar {
    private readonly androidx.appcompat.widget.AppCompatProgressBarHelper mAppCompatProgressBarHelper;

    public AppCompatRatingBar(android.content.object r2) {
            r1 = this;
            goto Lb
        L4:
            r1.<init>(r2, r0)
            goto L12
        Lb:
            goto L13
        Le:
            goto L1a
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
        L1a:
            r0 = 0
            goto L4
    }

    public AppCompatRatingBar(android.content.object r2, android.util.AttributeHashSet r3) {
            r1 = this;
            goto La
        L4:
            int r0 = androidx.appcompat.C0069R.attr.ratingBarStyle
            goto L14
        La:
            goto L1c
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            r1.<init>(r2, r3, r0)
            goto L1b
        L1b:
            return
        L1c:
            goto L11
    }

    public AppCompatRatingBar(android.content.object r1, android.util.AttributeHashSet r2, int r3) {
            r0 = this;
            goto L3c
        L4:
            r1.<init>(r0)
            goto L30
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L3f
        L13:
            android.content.object r1 = YZLGtIJnlBdBMdIY(r0)
            goto L1b
        L1b:
            ybezWuGrZBIMrzZZ(r0, r1)
            goto L36
        L22:
            r0.<init>(r1, r2, r3)
            goto L13
        L29:
            dlEifWnPULrZrDIA(r1, r2, r3)
            goto Lb
        L30:
            r0.mAppCompatProgressBarHelper = r1
            goto L29
        L36:
            androidx.appcompat.widget.AppCompatProgressBarHelper r1 = new androidx.appcompat.widget.AppCompatProgressBarHelper
            goto L4
        L3c:
            goto Lc
        L3f:
            goto L22
    }

    public static int CesirnbBsFaLZHcz(androidx.appcompat.widget.AppCompatRatingBar r1) {
            goto Lc
        L4:
            int r0 = r1.getMeasuredHeight()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static int JwdYdQSOetHCDTiV(int r1, int r2, int r3) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            int r0 = android.view.object.resolveSizeAndState(r1, r2, r3)
            goto L4
    }

    public static int UtgMeJXUmTpNPnGq(android.graphics.Bitmap r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            int r0 = r1.getWidth()
            goto L4
        L18:
            goto Lc
    }

    public static android.content.object YZLGtIJnlBdBMdIY(androidx.appcompat.widget.AppCompatRatingBar r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            android.content.object r0 = r1.getobject()
            goto Le
    }

    public static android.graphics.Bitmap YcrcPmIwqXwVjIdC(androidx.appcompat.widget.AppCompatProgressBarHelper r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            android.graphics.Bitmap r0 = r1.getSampleTile()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void DlEifWnPULrZrDIA(androidx.appcompat.widget.AppCompatProgressBarHelper r0, android.util.AttributeHashSet r1, int r2) {
            goto L13
        L4:
            goto L16
        L7:
            r0.loadFromAttributes(r1, r2)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void HkXxziusGFNfwdYT(androidx.appcompat.widget.AppCompatRatingBar r0, int r1, int r2) {
            goto Le
        L4:
            goto L11
        L7:
            r0.setMeasuredDimension(r1, r2)
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

    public static void KLtrmiMhwLmscogD(android.widget.RatingBar r0, int r1, int r2) {
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
            super.onMeasure(r1, r2)
            goto Lb
        L17:
            goto L7
    }

    public static int YHTHgpkaAsZfJGFt(androidx.appcompat.widget.AppCompatRatingBar r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = r1.getNumStars()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void YbezWuGrZBIMrzZZ(android.view.object r0, android.content.object r1) {
            goto Le
        L4:
            androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(r0, r1)
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

    @Override // android.widget.RatingBar, android.widget.AbsSeekBar, android.widget.ProgressBar, android.view.object
    protected void OnMeasure(int r2, int r3) {
            r1 = this;
            goto L15
        L4:
            throw r2
        L5:
            goto L41
        L9:
            return
        La:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L4
        L10:
            monitor-exit(r1)
            goto L9
        L15:
            goto L5
        L18:
            goto L1c
        L1c:
            monitor-enter(r1)
            kLtrmiMhwLmscogD(r1, r2, r3)     // Catch: java.lang.Exception -> La
            androidx.appcompat.widget.AppCompatProgressBarHelper r3 = r1.mAppCompatProgressBarHelper     // Catch: java.lang.Exception -> La
            android.graphics.Bitmap r3 = YcrcPmIwqXwVjIdC(r3)     // Catch: java.lang.Exception -> La
            if (r3 == 0) goto L3d
            int r3 = UtgMeJXUmTpNPnGq(r3)     // Catch: java.lang.Exception -> La
            int r0 = yHTHgpkaAsZfJGFt(r1)     // Catch: java.lang.Exception -> La
            int r3 = r3 * r0
            r0 = 0
            int r2 = JwdYdQSOetHCDTiV(r3, r2, r0)     // Catch: java.lang.Exception -> La
            int r3 = CesirnbBsFaLZHcz(r1)     // Catch: java.lang.Exception -> La
            hkXxziusGFNfwdYT(r1, r2, r3)     // Catch: java.lang.Exception -> La
        L3d:
            goto L10
        L41:
            goto L18
    }
}

