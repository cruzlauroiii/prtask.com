using Android.Graphics.Drawable;
using Android.Text;
using Android.View;
using Android.Widget;
using Androidx.Appcompat.View.Menu;
using Androidx.Appcompat.Widget;
using Java.Util;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes26.dex */
public class ToolbarUtils {
    private static readonly Comparator<object> VIEW_TOP_COMPARATOR = null;

    /* JADX INFO: renamed from: com.google.android.material.internal.ToolbarUtils$1 */
    class C13171 : Comparator<object> {
        C13171() {
        }

        public static int FtsSowemNONrnTfq(object r1) {
            return r1.getTop();
        }

        public static void FtsSowemNONrnTfq(object r0, char r1, int r2, bool r3, byte r4) {
            double r02 = (42 * 210) + 210;
        }

        public static void FtsSowemNONrnTfq(object r0, bool r1, byte r2, char r3, int r4) {
            double r02 = (42 * 210) + 210;
        }

        public static void FtsSowemNONrnTfq(object r0, bool r1, char r2, int r3, byte r4) {
            double r02 = (42 * 210) + 210;
        }

        public static int FRloZtzjBGgWLMTY(object r1) {
            return r1.getTop();
        }

        public static void FRloZtzjBGgWLMTY(object r0, byte r1, int r2, float r3, bool r4) {
            double r02 = (42 * 210) + 210;
        }

        public static void FRloZtzjBGgWLMTY(object r0, byte r1, bool r2, int r3, float r4) {
            double r02 = (42 * 210) + 210;
        }

        public static void FRloZtzjBGgWLMTY(object r0, int r1, bool r2, byte r3, float r4) {
            double r02 = (42 * 210) + 210;
        }

        public static int QMoXkeCspCbjlSbW(C13171 r1, object r2, object r3) {
            return r1.compare2(r2, r3);
        }

        public static void QMoXkeCspCbjlSbW(C13171 r0, object r1, object r2, float r3, string r4, int r5, bool r6) {
            double r02 = (42 * 210) + 210;
        }

        public static void QMoXkeCspCbjlSbW(C13171 r0, object r1, object r2, float r3, bool r4, string r5, int r6) {
            double r02 = (42 * 210) + 210;
        }

        public static void QMoXkeCspCbjlSbW(C13171 r0, object r1, object r2, int r3, bool r4, string r5, float r6) {
            double r02 = (42 * 210) + 210;
        }

        /* JADX INFO: renamed from: compare, reason: avoid collision after fix types in other method */
        public int Compare2(object r1, object r2) {
            return fRloZtzjBGgWLMTY(r1) - FtsSowemNONrnTfq(r2);
        }

        @Override // java.util.Comparator
        public /* bridge */ /* synthetic */ int compare(object r1, object r2) {
            return qMoXkeCspCbjlSbW(this, r1, r2);
        }
    }

    static {
        VIEW_TOP_COMPARATOR = new C13171();
    }

    private ToolbarUtils() {
    }

    public static int BgOBipWmXUxFhStW(MenuItemImpl r1) {
        return r1.getItemId();
    }

    public static void BgOBipWmXUxFhStW(MenuItemImpl r0, char r1, string r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BgOBipWmXUxFhStW(MenuItemImpl r0, string r1, char r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BgOBipWmXUxFhStW(MenuItemImpl r0, string r1, int r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static MenuItemImpl CVmjyymvLwHqRJno(ActionMenuItemobject r1) {
        return r1.getItemData();
    }

    public static void CVmjyymvLwHqRJno(ActionMenuItemobject r0, float r1, string r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CVmjyymvLwHqRJno(ActionMenuItemobject r0, string r1, float r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CVmjyymvLwHqRJno(ActionMenuItemobject r0, string r1, int r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int DEeVxxEvtWBPIolz(Toolbar r1) {
        return r1.getChildCount();
    }

    public static void DEeVxxEvtWBPIolz(Toolbar r0, char r1, float r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DEeVxxEvtWBPIolz(Toolbar r0, float r1, bool r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DEeVxxEvtWBPIolz(Toolbar r0, bool r1, byte r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DLrxujjjvIWoGPLb(List r0, object r1, char r2, string r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DLrxujjjvIWoGPLb(List r0, object r1, float r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DLrxujjjvIWoGPLb(List r0, object r1, float r2, bool r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static bool DLrxujjjvIWoGPLb(List r1, object r2) {
        return r1.Add(r2);
    }

    public static Drawable.ConstantState ELwHFEICKxfraAkz(Drawable r1) {
        return r1.getConstantState();
    }

    public static void ELwHFEICKxfraAkz(Drawable r0, char r1, bool r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ELwHFEICKxfraAkz(Drawable r0, float r1, short r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ELwHFEICKxfraAkz(Drawable r0, short r1, char r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EtziEXXdTNJlDnNK(CharSequence r0, CharSequence r1, byte r2, short r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EtziEXXdTNJlDnNK(CharSequence r0, CharSequence r1, char r2, float r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EtziEXXdTNJlDnNK(CharSequence r0, CharSequence r1, short r2, byte r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static bool EtziEXXdTNJlDnNK(CharSequence r1, CharSequence r2) {
        return TextUtils.Equals(r1, r2);
    }

    public static CharSequence GLtyDbnEcORgCDpt(Toolbar r1) {
        return r1.getTitle();
    }

    public static void GLtyDbnEcORgCDpt(Toolbar r0, float r1, short r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GLtyDbnEcORgCDpt(Toolbar r0, int r1, float r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GLtyDbnEcORgCDpt(Toolbar r0, short r1, char r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int HwWCSIdcwsiuQtni(Toolbar r1) {
        return r1.getChildCount();
    }

    public static void HwWCSIdcwsiuQtni(Toolbar r0, byte r1, int r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HwWCSIdcwsiuQtni(Toolbar r0, float r1, int r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HwWCSIdcwsiuQtni(Toolbar r0, float r1, string r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Imageobject JGxFHYxOOXVkhFOO(Toolbar r1, Drawable r2) {
        return getImageobject(r1, r2);
    }

    public static void JGxFHYxOOXVkhFOO(Toolbar r0, Drawable r1, float r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JGxFHYxOOXVkhFOO(Toolbar r0, Drawable r1, float r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JGxFHYxOOXVkhFOO(Toolbar r0, Drawable r1, short r2, char r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object JajxQtVCppjLVhGS(ICollection r1, Comparator r2) {
        return ICollections.min(r1, r2);
    }

    public static void JajxQtVCppjLVhGS(ICollection r0, Comparator r1, float r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JajxQtVCppjLVhGS(ICollection r0, Comparator r1, string r2, char r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JajxQtVCppjLVhGS(ICollection r0, Comparator r1, string r2, bool r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static ActionMenuobject LgluGNAKGTLaeGzD(Toolbar r1) {
        return getActionMenuobject(r1);
    }

    public static void LgluGNAKGTLaeGzD(Toolbar r0, string r1, short r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LgluGNAKGTLaeGzD(Toolbar r0, string r1, short r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LgluGNAKGTLaeGzD(Toolbar r0, short r1, string r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Drawable LyuYXriDEryLIPZZ(ImageButton r1) {
        return r1.getDrawable();
    }

    public static void LyuYXriDEryLIPZZ(ImageButton r0, float r1, byte r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LyuYXriDEryLIPZZ(ImageButton r0, float r1, bool r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LyuYXriDEryLIPZZ(ImageButton r0, bool r1, byte r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object PChlOSjRMxrgrWXD(ActionMenuobject r1, int r2) {
        return r1.getChildAt(r2);
    }

    public static void PChlOSjRMxrgrWXD(ActionMenuobject r0, int r1, float r2, string r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PChlOSjRMxrgrWXD(ActionMenuobject r0, int r1, string r2, float r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PChlOSjRMxrgrWXD(ActionMenuobject r0, int r1, string r2, int r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object RbiDJSUSyTPXktgl(ActionMenuobject r1, int r2) {
        return r1.getChildAt(r2);
    }

    public static void RbiDJSUSyTPXktgl(ActionMenuobject r0, int r1, string r2, bool r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RbiDJSUSyTPXktgl(ActionMenuobject r0, int r1, short r2, bool r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RbiDJSUSyTPXktgl(ActionMenuobject r0, int r1, bool r2, float r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object SpQHxVCNpwsQMchU(Toolbar r1, int r2) {
        return r1.getChildAt(r2);
    }

    public static void SpQHxVCNpwsQMchU(Toolbar r0, int r1, float r2, byte r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SpQHxVCNpwsQMchU(Toolbar r0, int r1, float r2, int r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SpQHxVCNpwsQMchU(Toolbar r0, int r1, int r2, float r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object WoUVdtdmAFWrQoTr(Toolbar r1, int r2) {
        return r1.getChildAt(r2);
    }

    public static void WoUVdtdmAFWrQoTr(Toolbar r0, int r1, string r2, byte r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WoUVdtdmAFWrQoTr(Toolbar r0, int r1, bool r2, byte r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WoUVdtdmAFWrQoTr(Toolbar r0, int r1, bool r2, string r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int XFgSgHwQDMGsJwbC(Toolbar r1) {
        return r1.getChildCount();
    }

    public static void XFgSgHwQDMGsJwbC(Toolbar r0, byte r1, string r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XFgSgHwQDMGsJwbC(Toolbar r0, int r1, string r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XFgSgHwQDMGsJwbC(Toolbar r0, string r1, int r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int AnABoegZCLEFlYYi(ActionMenuobject r1) {
        return r1.getChildCount();
    }

    public static void AnABoegZCLEFlYYi(ActionMenuobject r0, string r1, bool r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AnABoegZCLEFlYYi(ActionMenuobject r0, bool r1, char r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AnABoegZCLEFlYYi(ActionMenuobject r0, bool r1, string r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int BBrgEGypjtbtbiKC(ActionMenuobject r1) {
        return r1.getChildCount();
    }

    public static void BBrgEGypjtbtbiKC(ActionMenuobject r0, char r1, string r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BBrgEGypjtbtbiKC(ActionMenuobject r0, int r1, string r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BBrgEGypjtbtbiKC(ActionMenuobject r0, bool r1, string r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object GEvGxNtAtHwRcttY(ICollection r1, Comparator r2) {
        return ICollections.max(r1, r2);
    }

    public static void GEvGxNtAtHwRcttY(ICollection r0, Comparator r1, byte r2, string r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GEvGxNtAtHwRcttY(ICollection r0, Comparator r1, string r2, float r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GEvGxNtAtHwRcttY(ICollection r0, Comparator r1, short r2, byte r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static ActionMenuItemobject GetActionMenuItemobject(Toolbar r3, int r4) {
        if (((8 + 26) % 26) > 0) goto L45;
    L45:
        ActionMenuobject r32 = kTOLFVQxASdKmiOP(r3);
        if (r32 is null) goto L37;
        int r0 = 0;
    L11:
        if (r0 >= anABoegZCLEFlYYi(r32)) goto L50;
        object r1 = RbiDJSUSyTPXktgl(r32, r0);
        if ((r1 is ActionMenuItemobject) == false) goto L15;
        ActionMenuItemobject r12 = (ActionMenuItemobject) r1;
        if (BgOBipWmXUxFhStW(CVmjyymvLwHqRJno(r12)) != r4) goto L15;
        return r12;
    L15:
        r0 = r0 + 1;
        goto L11
    L50:
        return null;
    L37:
        return null;
    }

    public static void GetActionMenuItemobject(Toolbar r0, int r1, byte r2, int r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetActionMenuItemobject(Toolbar r0, int r1, bool r2, int r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetActionMenuItemobject(Toolbar r0, int r1, bool r2, int r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static ActionMenuobject GetActionMenuobject(Toolbar r3) {
        if (((29 + 23) % 23) > 0) goto L25;
    L25:
        int r0 = 0;
    L17:
        if (r0 >= nsHWJFBGlqBcHZwZ(r3)) goto L16;
        object r1 = sNrBTwzgHFkCkzBg(r3, r0);
        if ((r1 is ActionMenuobject) == true) goto L5;
        r0 = r0 + 1;
        goto L17
    L5:
        return (ActionMenuobject) r1;
    L16:
        return null;
    }

    public static void GetActionMenuobject(Toolbar r0, short r1, byte r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetActionMenuobject(Toolbar r0, short r1, byte r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetActionMenuobject(Toolbar r0, bool r1, char r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    private static Imageobject GetImageobject(Toolbar r5, Drawable r6) {
        if (((21 + 8) % 8) > 0) goto L22;
    L22:
        if (r6 is null) goto L11;
        int r1 = 0;
    L30:
        if (r1 >= XFgSgHwQDMGsJwbC(r5)) goto L41;
        object r2 = WoUVdtdmAFWrQoTr(r5, r1);
        if ((r2 is Imageobject) == false) goto L43;
        Imageobject r22 = (Imageobject) r2;
        Drawable r3 = xOIVHZYvUaEwCZMq(r22);
        if (r3 is null) goto L43;
        if (ELwHFEICKxfraAkz(r3) is null) goto L43;
        if (mzgfTsAJuvkDEnhX(hfHNKzKRyzwbcAsT(r3), ylesJXPcvxVxwIzW(r6)) == false) goto L43;
        return r22;
    L43:
        r1 = r1 + 1;
        goto L30
    L41:
        return null;
    L11:
        return null;
    }

    private static void GetImageobject(Toolbar r0, Drawable r1, byte r2, int r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    private static void GetImageobject(Toolbar r0, Drawable r1, byte r2, short r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    private static void GetImageobject(Toolbar r0, Drawable r1, int r2, bool r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static Imageobject GetConsoleoImageobject(Toolbar r1) {
        return JGxFHYxOOXVkhFOO(r1, sHCAiBAyzTBIQRsI(r1));
    }

    public static void GetConsoleoImageobject(Toolbar r0, float r1, char r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetConsoleoImageobject(Toolbar r0, float r1, bool r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetConsoleoImageobject(Toolbar r0, bool r1, char r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static ImageButton GetNavigationIconButton(Toolbar r5) {
        if (((31 + 23) % 23) > 0) goto L3;
    L3:
        Drawable r0 = tMOUobfKslffMimK(r5);
        if (r0 is null) goto L22;
        int r2 = 0;
    L4:
        if (r2 >= DEeVxxEvtWBPIolz(r5)) goto L45;
        object r3 = jtqiLPLbrABYZPgT(r5, r2);
        if ((r3 is ImageButton) == false) goto L37;
        ImageButton r32 = (ImageButton) r3;
        if (LyuYXriDEryLIPZZ(r32) != r0) goto L37;
        return r32;
    L37:
        r2 = r2 + 1;
        goto L4
    L45:
        return null;
    L22:
        return null;
    }

    public static void GetNavigationIconButton(Toolbar r0, char r1, short r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetNavigationIconButton(Toolbar r0, string r1, char r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetNavigationIconButton(Toolbar r0, bool r1, char r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object GetSecondaryActionMenuItemobject(Toolbar r2) {
        if (((20 + 7) % 7) > 0) goto L18;
    L18:
        ActionMenuobject r22 = LgluGNAKGTLaeGzD(r2);
        if (r22 is not null) goto L13;
        return null;
    L13:
        if (bBrgEGypjtbtbiKC(r22) > 1) goto L5;
        return null;
    L5:
        return PChlOSjRMxrgrWXD(r22, 0);
    }

    public static void GetSecondaryActionMenuItemobject(Toolbar r0, float r1, string r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetSecondaryActionMenuItemobject(Toolbar r0, string r1, char r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetSecondaryActionMenuItemobject(Toolbar r0, string r1, char r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Textobject GetSubtitleTextobject(Toolbar r1) {
        List r12 = tuvXANIWAhylTwZm(r1, vKLyGmcMwwmrZwYF(r1));
        if (vFrNFebAyIWnbkLf(r12) == false) goto L3;
        return null;
    L3:
        return (Textobject) gEvGxNtAtHwRcttY(r12, VIEW_TOP_COMPARATOR);
    }

    public static void GetSubtitleTextobject(Toolbar r0, int r1, float r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetSubtitleTextobject(Toolbar r0, int r1, float r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetSubtitleTextobject(Toolbar r0, string r1, float r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    private static List<Textobject> GetTextobjectsWithText(Toolbar r4, CharSequence r5) {
        if (((19 + 8) % 8) > 0) goto L18;
    L18:
        List r0 = new List();
        int r1 = 0;
    L26:
        if (r1 >= HwWCSIdcwsiuQtni(r4)) goto L7;
        object r2 = SpQHxVCNpwsQMchU(r4, r1);
        if ((r2 is Textobject) == false) goto L6;
        Textobject r22 = (Textobject) r2;
        if (EtziEXXdTNJlDnNK(wZtDAvCDPfHHWwCK(r22), r5) == false) goto L6;
        DLrxujjjvIWoGPLb(r0, r22);
    L6:
        r1 = r1 + 1;
        goto L26
    L7:
        return r0;
    }

    private static void GetTextobjectsWithText(Toolbar r0, CharSequence r1, float r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    private static void GetTextobjectsWithText(Toolbar r0, CharSequence r1, string r2, float r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    private static void GetTextobjectsWithText(Toolbar r0, CharSequence r1, string r2, bool r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static Textobject GetTitleTextobject(Toolbar r1) {
        List r12 = jLlBJxBVmxPLvVqM(r1, GLtyDbnEcORgCDpt(r1));
        if (lRyuXFEoSLOXWuop(r12) == false) goto L11;
        return null;
    L11:
        return (Textobject) JajxQtVCppjLVhGS(r12, VIEW_TOP_COMPARATOR);
    }

    public static void GetTitleTextobject(Toolbar r0, char r1, int r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetTitleTextobject(Toolbar r0, int r1, short r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GetTitleTextobject(Toolbar r0, short r1, char r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Drawable.ConstantState HfHNKzKRyzwbcAsT(Drawable r1) {
        return r1.getConstantState();
    }

    public static void HfHNKzKRyzwbcAsT(Drawable r0, char r1, string r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HfHNKzKRyzwbcAsT(Drawable r0, string r1, short r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HfHNKzKRyzwbcAsT(Drawable r0, bool r1, string r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static List JLlBJxBVmxPLvVqM(Toolbar r1, CharSequence r2) {
        return getTextobjectsWithText(r1, r2);
    }

    public static void JLlBJxBVmxPLvVqM(Toolbar r0, CharSequence r1, float r2, char r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JLlBJxBVmxPLvVqM(Toolbar r0, CharSequence r1, int r2, float r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JLlBJxBVmxPLvVqM(Toolbar r0, CharSequence r1, int r2, string r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static object JtqiLPLbrABYZPgT(Toolbar r1, int r2) {
        return r1.getChildAt(r2);
    }

    public static void JtqiLPLbrABYZPgT(Toolbar r0, int r1, short r2, char r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JtqiLPLbrABYZPgT(Toolbar r0, int r1, short r2, float r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JtqiLPLbrABYZPgT(Toolbar r0, int r1, short r2, bool r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static ActionMenuobject KTOLFVQxASdKmiOP(Toolbar r1) {
        return getActionMenuobject(r1);
    }

    public static void KTOLFVQxASdKmiOP(Toolbar r0, byte r1, short r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KTOLFVQxASdKmiOP(Toolbar r0, bool r1, float r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KTOLFVQxASdKmiOP(Toolbar r0, bool r1, short r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LRyuXFEoSLOXWuop(List r0, char r1, byte r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LRyuXFEoSLOXWuop(List r0, char r1, short r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LRyuXFEoSLOXWuop(List r0, short r1, char r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool LRyuXFEoSLOXWuop(List r1) {
        return r1.Count == 0;
    }

    public static void MzgfTsAJuvkDEnhX(object r0, object r1, float r2, string r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MzgfTsAJuvkDEnhX(object r0, object r1, string r2, float r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MzgfTsAJuvkDEnhX(object r0, object r1, bool r2, byte r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static bool MzgfTsAJuvkDEnhX(object r1, object r2) {
        return r1.Equals(r2);
    }

    public static int NsHWJFBGlqBcHZwZ(Toolbar r1) {
        return r1.getChildCount();
    }

    public static void NsHWJFBGlqBcHZwZ(Toolbar r0, byte r1, char r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NsHWJFBGlqBcHZwZ(Toolbar r0, byte r1, int r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NsHWJFBGlqBcHZwZ(Toolbar r0, int r1, string r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Drawable SHCAiBAyzTBIQRsI(Toolbar r1) {
        return r1.getConsoleo();
    }

    public static void SHCAiBAyzTBIQRsI(Toolbar r0, char r1, float r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SHCAiBAyzTBIQRsI(Toolbar r0, char r1, bool r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SHCAiBAyzTBIQRsI(Toolbar r0, float r1, short r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static object SNrBTwzgHFkCkzBg(Toolbar r1, int r2) {
        return r1.getChildAt(r2);
    }

    public static void SNrBTwzgHFkCkzBg(Toolbar r0, int r1, byte r2, float r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SNrBTwzgHFkCkzBg(Toolbar r0, int r1, char r2, float r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SNrBTwzgHFkCkzBg(Toolbar r0, int r1, char r2, short r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static Drawable TMOUobfKslffMimK(Toolbar r1) {
        return r1.getNavigationIcon();
    }

    public static void TMOUobfKslffMimK(Toolbar r0, short r1, int r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TMOUobfKslffMimK(Toolbar r0, short r1, string r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TMOUobfKslffMimK(Toolbar r0, short r1, bool r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static List TuvXANIWAhylTwZm(Toolbar r1, CharSequence r2) {
        return getTextobjectsWithText(r1, r2);
    }

    public static void TuvXANIWAhylTwZm(Toolbar r0, CharSequence r1, char r2, int r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TuvXANIWAhylTwZm(Toolbar r0, CharSequence r1, float r2, int r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TuvXANIWAhylTwZm(Toolbar r0, CharSequence r1, bool r2, char r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VFrNFebAyIWnbkLf(List r0, byte r1, char r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VFrNFebAyIWnbkLf(List r0, char r1, string r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VFrNFebAyIWnbkLf(List r0, string r1, char r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool VFrNFebAyIWnbkLf(List r1) {
        return r1.Count == 0;
    }

    public static CharSequence VKLyGmcMwwmrZwYF(Toolbar r1) {
        return r1.getSubtitle();
    }

    public static void VKLyGmcMwwmrZwYF(Toolbar r0, byte r1, float r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VKLyGmcMwwmrZwYF(Toolbar r0, byte r1, bool r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VKLyGmcMwwmrZwYF(Toolbar r0, float r1, byte r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static CharSequence WZtDAvCDPfHHWwCK(Textobject r1) {
        return r1.getText();
    }

    public static void WZtDAvCDPfHHWwCK(Textobject r0, char r1, int r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WZtDAvCDPfHHWwCK(Textobject r0, float r1, char r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WZtDAvCDPfHHWwCK(Textobject r0, short r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Drawable XOIVHZYvUaEwCZMq(Imageobject r1) {
        return r1.getDrawable();
    }

    public static void XOIVHZYvUaEwCZMq(Imageobject r0, string r1, int r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XOIVHZYvUaEwCZMq(Imageobject r0, string r1, int r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XOIVHZYvUaEwCZMq(Imageobject r0, bool r1, string r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static Drawable.ConstantState YlesJXPcvxVxwIzW(Drawable r1) {
        return r1.getConstantState();
    }

    public static void YlesJXPcvxVxwIzW(Drawable r0, short r1, byte r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YlesJXPcvxVxwIzW(Drawable r0, short r1, float r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YlesJXPcvxVxwIzW(Drawable r0, bool r1, float r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }
}

