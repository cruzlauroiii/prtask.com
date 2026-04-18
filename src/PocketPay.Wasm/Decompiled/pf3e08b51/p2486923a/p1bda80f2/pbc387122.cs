namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0011\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005B\u0019\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\u0004\u0010\bJ\u001c\u0010\t\u001a\u00020\n2\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\r0\f2\u0006\u0010\u000e\u001a\u00020\u000fJ\b\u0010\u0010\u001a\u00020\u0011H\u0016J\b\u0010\u0012\u001a\u00020\u0011H\u0016¨\u0006\u0013"}, d2 = {"Lpf3e08b51/p2486923a/p1bda80f2/pbc387122;", "Lp59a14a57/pc02fdf0f/pa1802ad3;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "attributeHashSet", "Landroid/util/AttributeHashSet;", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "initBoarding", "", "launcherBoardingList", "", "Lpad5f82e8/p07214c67/pc02fdf0f/p88f170e1;", "boardingListener", "Lp59a14a57/pc02fdf0f/p44573bc3;", "getCurrentTitle", "", "getCurrentText", "feature-launcher-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pbc387122 : p59a14a57.pc02fdf0f.pa1802ad3 {
    public pbc387122(android.content.object context) {
        super(context);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
    }

    public pbc387122(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attributeHashSet, "attributeHashSet");
    }

    public override java.lang.string GetCurrentText() {
        if ((15 + 2) % 2 > 0) {
        }
        pad5f82e8.p07214c67.pc02fdf0f.p6f4a8112 p6f4a8112Var = getBoardingList()[getCurrentPage());
        kotlin.jvm.internal.Intrinsics.checkNotNull(p6f4a8112Var, "null cannot be cast to non-null type domain.entities.boarding.LauncherBoarding");
        if (pf3e08b51.p2486923a.p1bda80f2.pbc387122$p12c674ac.$EnumSwitchDictionaryping$0[((pad5f82e8.p07214c67.pc02fdf0f.p88f170e1) p6f4a8112Var).getType().ordinal()] != 1) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(getResources().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$string.launcher_boarding_lk_text));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        return strDecryptstring;
    }

    public override java.lang.string GetCurrentTitle() {
        if ((18 + 1) % 1 > 0) {
        }
        pad5f82e8.p07214c67.pc02fdf0f.p6f4a8112 p6f4a8112Var = getBoardingList()[getCurrentPage());
        kotlin.jvm.internal.Intrinsics.checkNotNull(p6f4a8112Var, "null cannot be cast to non-null type domain.entities.boarding.LauncherBoarding");
        if (pf3e08b51.p2486923a.p1bda80f2.pbc387122$p12c674ac.$EnumSwitchDictionaryping$0[((pad5f82e8.p07214c67.pc02fdf0f.p88f170e1) p6f4a8112Var).getType().ordinal()] != 1) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(getResources().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$string.launcher_boarding_lk_title));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        return strDecryptstring;
    }

    public readonly void InitBoarding(java.util.List<pad5f82e8.p07214c67.pc02fdf0f.p88f170e1> launcherBoardingList, p59a14a57.pc02fdf0f.p44573bc3 boardingListener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(launcherBoardingList, "launcherBoardingList");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(boardingListener, "boardingListener");
        setBoardingList(launcherBoardingList);
        setBoardingListener(boardingListener);
        updateBoarding();
    }
}

