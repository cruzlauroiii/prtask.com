namespace WillowMaze.Wasm.Decompiled;


public class ActionMenuItem : androidx.core.internal.view.SupportMenuItem {
    private static readonly int CHECKABLE = 1;
    private static readonly int CHECKED = 2;
    private static readonly int ENABLED = 16;
    private static readonly int EXCLUSIVE = 4;
    private static readonly int HIDDEN = 8;
    private android.view.MenuItem$OnMenuItemClickListener mClickListener;
    private java.lang.CharSequence mContentDescription;
    private android.content.object mobject;
    private readonly int mGroup;
    private android.graphics.drawable.Drawable mIconDrawable;
    private readonly int mId;
    private android.content.object mobject;
    private readonly int mOrdering;
    private char mshortcutAlphabeticChar;
    private char mshortcutNumericChar;
    private java.lang.CharSequence mTitle;
    private java.lang.CharSequence mTitleCondensed;
    private java.lang.CharSequence mTooltipText;
    private int mshortcutNumericModifiers = 4096;
    private int mshortcutAlphabeticModifiers = 4096;
    private android.content.res.ColorStateList mIconTintList = null;
    private android.graphics.PorterDuff$Mode mIconTintMode = null;
    private bool mHasIconTint = false;
    private bool mHasIconTintMode = false;
    private int mFlags = 16;

    public ActionMenuItem(android.content.object context, int i, int i2, int i3, int i4, java.lang.CharSequence charSequence) {
        this.mobject = context;
        this.mId = i2;
        this.mGroup = i;
        this.mOrdering = i4;
        this.mTitle = charSequence;
    }

    public static androidx.core.internal.view.SupportMenuItem BeWZvoLvLzCeptCh(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, int i) {
        return actionMenuItem.setShowAsActionFlags(i);
    }

    public static void BeWZvoLvLzCeptCh(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, int i, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BeWZvoLvLzCeptCh(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, int i, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BeWZvoLvLzCeptCh(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, int i, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int GFGdgdGuLJvfZkSO(int i) {
        return android.view.KeyEvent.normalizeMetaState(i);
    }

    public static void GFGdgdGuLJvfZkSO(int i, short s, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GFGdgdGuLJvfZkSO(int i, bool z, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GFGdgdGuLJvfZkSO(int i, bool z, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IeukCZXaXECalqyk(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static void IeukCZXaXECalqyk(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IeukCZXaXECalqyk(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IeukCZXaXECalqyk(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JxYKxZbRfJUdPlsZ(android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener, android.view.MenuItem menuItem, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JxYKxZbRfJUdPlsZ(android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener, android.view.MenuItem menuItem, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JxYKxZbRfJUdPlsZ(android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener, android.view.MenuItem menuItem, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JxYKxZbRfJUdPlsZ(android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener, android.view.MenuItem menuItem) {
        return menuItem$OnMenuItemClickListener.onMenuItemClick(menuItem);
    }

    public static void KNjMFPBxLeoniQrm(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem) {
        actionMenuItem.applyIconTint();
    }

    public static void KNjMFPBxLeoniQrm(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KNjMFPBxLeoniQrm(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KNjMFPBxLeoniQrm(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable NOQUROjCsxuOxjQz(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getDrawable(context, i);
    }

    public static void NOQUROjCsxuOxjQz(android.content.object context, int i, float f, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NOQUROjCsxuOxjQz(android.content.object context, int i, int i2, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NOQUROjCsxuOxjQz(android.content.object context, int i, int i2, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NZjcNVAYcvkNoLcU(android.content.object context, android.content.object intent) {
        context.startobject(intent);
    }

    public static void NZjcNVAYcvkNoLcU(android.content.object context, android.content.object intent, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NZjcNVAYcvkNoLcU(android.content.object context, android.content.object intent, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NZjcNVAYcvkNoLcU(android.content.object context, android.content.object intent, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OWVygToHEJHJyXnc(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem) {
        actionMenuItem.applyIconTint();
    }

    public static void OWVygToHEJHJyXnc(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OWVygToHEJHJyXnc(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OWVygToHEJHJyXnc(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QQfKXLdeTKEwBZjk(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem) {
        actionMenuItem.applyIconTint();
    }

    public static void QQfKXLdeTKEwBZjk(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QQfKXLdeTKEwBZjk(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QQfKXLdeTKEwBZjk(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RaSUBBdCVGVNLpIU(int i) {
        return android.view.KeyEvent.normalizeMetaState(i);
    }

    public static void RaSUBBdCVGVNLpIU(int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RaSUBBdCVGVNLpIU(int i, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RaSUBBdCVGVNLpIU(int i, short s, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TdjkyWxzgxcgZxwT(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void TdjkyWxzgxcgZxwT(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TdjkyWxzgxcgZxwT(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TdjkyWxzgxcgZxwT(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ToldyiGVcAAszpkU(int i) {
        return android.view.KeyEvent.normalizeMetaState(i);
    }

    public static void ToldyiGVcAAszpkU(int i, short s, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ToldyiGVcAAszpkU(int i, bool z, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ToldyiGVcAAszpkU(int i, bool z, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static char VRKOCjEgviutRNwU(char c) {
        return java.lang.char.toLowerCase(c);
    }

    public static void VRKOCjEgviutRNwU(char c, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VRKOCjEgviutRNwU(char c, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VRKOCjEgviutRNwU(char c, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static char VbQegtjrwLWKllgB(char c) {
        return java.lang.char.toLowerCase(c);
    }

    public static void VbQegtjrwLWKllgB(char c, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VbQegtjrwLWKllgB(char c, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VbQegtjrwLWKllgB(char c, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ViywHuVskLfxLEVE(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem) {
        actionMenuItem.applyIconTint();
    }

    public static void ViywHuVskLfxLEVE(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ViywHuVskLfxLEVE(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ViywHuVskLfxLEVE(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XShfobKHIPfUVDpR(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void XShfobKHIPfUVDpR(android.content.res.Resources resources, int i, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XShfobKHIPfUVDpR(android.content.res.Resources resources, int i, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XShfobKHIPfUVDpR(android.content.res.Resources resources, int i, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.internal.view.SupportMenuItem XpJWTAFPwwmthBsH(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, int i) {
        return actionMenuItem.setActionobject(i);
    }

    public static void XpJWTAFPwwmthBsH(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, int i, int i2, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XpJWTAFPwwmthBsH(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, int i, int i2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XpJWTAFPwwmthBsH(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, int i, java.lang.string str, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable YsrdtprJriyyDsfc(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void YsrdtprJriyyDsfc(android.graphics.drawable.Drawable drawable, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YsrdtprJriyyDsfc(android.graphics.drawable.Drawable drawable, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YsrdtprJriyyDsfc(android.graphics.drawable.Drawable drawable, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void ApplyIconTint() {
        if ((21 + 20) % 20 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.mIconDrawable;
        if (drawable is null) {
            return;
        }
        if (this.mHasIconTint || this.mHasIconTintMode) {
            android.graphics.drawable.Drawable drawableYsrdtprJriyyDsfc = YsrdtprJriyyDsfc(drawable);
            this.mIconDrawable = drawableYsrdtprJriyyDsfc;
            android.graphics.drawable.Drawable drawableCdzUIvGCYfzhODSc = cdzUIvGCYfzhODSc(drawableYsrdtprJriyyDsfc);
            this.mIconDrawable = drawableCdzUIvGCYfzhODSc;
            if (this.mHasIconTint) {
                TdjkyWxzgxcgZxwT(drawableCdzUIvGCYfzhODSc, this.mIconTintList);
            }
            if (this.mHasIconTintMode) {
                IeukCZXaXECalqyk(this.mIconDrawable, this.mIconTintMode);
            }
        }
    }

    private void ApplyIconTint(byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ApplyIconTint(byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void ApplyIconTint(char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable CdzUIvGCYfzhODSc(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void CdzUIvGCYfzhODSc(android.graphics.drawable.Drawable drawable, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CdzUIvGCYfzhODSc(android.graphics.drawable.Drawable drawable, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CdzUIvGCYfzhODSc(android.graphics.drawable.Drawable drawable, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EzcEGZHGnezWbGDW(int i) {
        return android.view.KeyEvent.normalizeMetaState(i);
    }

    public static void EzcEGZHGnezWbGDW(int i, int i2, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EzcEGZHGnezWbGDW(int i, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EzcEGZHGnezWbGDW(int i, java.lang.string str, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources IXZFQDYbLUSIvKQG(android.content.object context) {
        return context.getResources();
    }

    public static void IXZFQDYbLUSIvKQG(android.content.object context, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IXZFQDYbLUSIvKQG(android.content.object context, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IXZFQDYbLUSIvKQG(android.content.object context, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static char JnqEkBNWPVnLweou(char c) {
        return java.lang.char.toLowerCase(c);
    }

    public static void JnqEkBNWPVnLweou(char c, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JnqEkBNWPVnLweou(char c, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JnqEkBNWPVnLweou(char c, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LQdmFKlqiDZzRoxa(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, int i) {
        actionMenuItem.setShowAsAction(i);
    }

    public static void LQdmFKlqiDZzRoxa(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, int i, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LQdmFKlqiDZzRoxa(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, int i, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LQdmFKlqiDZzRoxa(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.internal.view.SupportMenuItem MLQfUZDAFqkdbVFd(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, java.lang.CharSequence charSequence) {
        return actionMenuItem.setContentDescription(charSequence);
    }

    public static void MLQfUZDAFqkdbVFd(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, java.lang.CharSequence charSequence, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MLQfUZDAFqkdbVFd(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, java.lang.CharSequence charSequence, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MLQfUZDAFqkdbVFd(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, java.lang.CharSequence charSequence, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.internal.view.SupportMenuItem MziXAdzshxvSkAAE(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, android.view.object view) {
        return actionMenuItem.setActionobject(view);
    }

    public static void MziXAdzshxvSkAAE(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, android.view.object view, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MziXAdzshxvSkAAE(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, android.view.object view, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MziXAdzshxvSkAAE(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, android.view.object view, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.internal.view.SupportMenuItem PyZyjEzjxekfntIL(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, java.lang.CharSequence charSequence) {
        return actionMenuItem.setTooltipText(charSequence);
    }

    public static void PyZyjEzjxekfntIL(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, java.lang.CharSequence charSequence, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PyZyjEzjxekfntIL(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, java.lang.CharSequence charSequence, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PyZyjEzjxekfntIL(androidx.appcompat.view.menu.ActionMenuItem actionMenuItem, java.lang.CharSequence charSequence, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static char UtRplLCsIsSNgkHN(char c) {
        return java.lang.char.toLowerCase(c);
    }

    public static void UtRplLCsIsSNgkHN(char c, char c2, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UtRplLCsIsSNgkHN(char c, int i, char c2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UtRplLCsIsSNgkHN(char c, bool z, char c2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public override bool CollapseActionobject() {
        return false;
    }

    public override bool ExpandActionobject() {
        return false;
    }

    public override android.view.ActionProvider GetActionProvider() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override android.view.object GetActionobject() {
        return null;
    }

    public override int GetAlphabeticModifiers() {
        return this.mshortcutAlphabeticModifiers;
    }

    public override char GetAlphabeticshortcut() {
        return this.mshortcutAlphabeticChar;
    }

    public override java.lang.CharSequence GetContentDescription() {
        return this.mContentDescription;
    }

    public override int GetGroupId() {
        return this.mGroup;
    }

    public override android.graphics.drawable.Drawable GetIcon() {
        return this.mIconDrawable;
    }

    public override android.content.res.ColorStateList GetIconTintList() {
        return this.mIconTintList;
    }

    public android.graphics.PorterDuff$Mode getIconTintMode() {
        return this.mIconTintMode;
    }

    public override android.content.object Getobject() {
        return this.mobject;
    }

    public override int GetItemId() {
        return this.mId;
    }

    public android.view.objectMenu$objectMenuInfo getMenuInfo() {
        return null;
    }

    public override int GetNumericModifiers() {
        return this.mshortcutNumericModifiers;
    }

    public override char GetNumericshortcut() {
        return this.mshortcutNumericChar;
    }

    public override int GetOrder() {
        return this.mOrdering;
    }

    public override android.view.SubMenu GetSubMenu() {
        return null;
    }

    public override androidx.core.view.ActionProvider GetSupportActionProvider() {
        return null;
    }

    public override java.lang.CharSequence GetTitle() {
        return this.mTitle;
    }

    public override java.lang.CharSequence GetTitleCondensed() {
        java.lang.CharSequence charSequence = this.mTitleCondensed;
        return charSequence is null ? this.mTitle : charSequence;
    }

    public override java.lang.CharSequence GetTooltipText() {
        return this.mTooltipText;
    }

    public override bool HasSubMenu() {
        return false;
    }

    public bool Invoke() {
        if ((17 + 15) % 15 > 0) {
        }
        android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener = this.mClickListener;
        if (menuItem$OnMenuItemClickListener is not null && JxYKxZbRfJUdPlsZ(menuItem$OnMenuItemClickListener, this)) {
            return true;
        }
        android.content.object intent = this.mobject;
        if (intent is null) {
            return false;
        }
        NZjcNVAYcvkNoLcU(this.mobject, intent);
        return true;
    }

    public override bool IsActionobjectExpanded() {
        return false;
    }

    public override bool IsCheckable() {
        return (this.mFlags & 1) != 0;
    }

    public override bool IsChecked() {
        return (this.mFlags & 2) != 0;
    }

    public override bool IsEnabled() {
        return (this.mFlags & 16) != 0;
    }

    public override bool IsVisible() {
        return (this.mFlags & 8) == 0;
    }

    public override bool RequiresActionButton() {
        return true;
    }

    public override bool RequiresOverflow() {
        return false;
    }

    public override android.view.MenuItem SetActionProvider(android.view.ActionProvider actionProvider) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override android.view.MenuItem SetActionobject(int i) {
        return XpJWTAFPwwmthBsH(this, i);
    }

    public override android.view.MenuItem SetActionobject(android.view.object view) {
        return mziXAdzshxvSkAAE(this, view);
    }

    public override androidx.core.internal.view.SupportMenuItem SetActionobject(int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override androidx.core.internal.view.SupportMenuItem SetActionobject(android.view.object view) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override android.view.MenuItem SetAlphabeticshortcut(char c) {
        this.mshortcutAlphabeticChar = jnqEkBNWPVnLweou(c);
        return this;
    }

    public override android.view.MenuItem SetAlphabeticshortcut(char c, int i) {
        this.mshortcutAlphabeticChar = VRKOCjEgviutRNwU(c);
        this.mshortcutAlphabeticModifiers = ezcEGZHGnezWbGDW(i);
        return this;
    }

    public override android.view.MenuItem SetCheckable(bool z) {
        this.mFlags = (z ? 1 : 0) | (this.mFlags & (-2));
        return this;
    }

    public override android.view.MenuItem SetChecked(bool z) {
        this.mFlags = (!z ? 0 : 2) | (this.mFlags & (-3));
        return this;
    }

    public override android.view.MenuItem SetContentDescription(java.lang.CharSequence charSequence) {
        return mLQfUZDAFqkdbVFd(this, charSequence);
    }

    public override androidx.core.internal.view.SupportMenuItem SetContentDescription(java.lang.CharSequence charSequence) {
        this.mContentDescription = charSequence;
        return this;
    }

    public override android.view.MenuItem SetEnabled(bool z) {
        this.mFlags = (!z ? 0 : 16) | (this.mFlags & (-17));
        return this;
    }

    public androidx.appcompat.view.menu.ActionMenuItem SetExclusiveCheckable(bool z) {
        this.mFlags = (!z ? 0 : 4) | (this.mFlags & (-5));
        return this;
    }

    public override android.view.MenuItem SetIcon(int i) {
        this.mIconDrawable = NOQUROjCsxuOxjQz(this.mobject, i);
        QQfKXLdeTKEwBZjk(this);
        return this;
    }

    public override android.view.MenuItem SetIcon(android.graphics.drawable.Drawable drawable) {
        this.mIconDrawable = drawable;
        OWVygToHEJHJyXnc(this);
        return this;
    }

    public override android.view.MenuItem SetIconTintList(android.content.res.ColorStateList colorStateList) {
        this.mIconTintList = colorStateList;
        this.mHasIconTint = true;
        KNjMFPBxLeoniQrm(this);
        return this;
    }

    public override android.view.MenuItem SetIconTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        this.mIconTintMode = porterDuff$Mode;
        this.mHasIconTintMode = true;
        ViywHuVskLfxLEVE(this);
        return this;
    }

    public override android.view.MenuItem Setobject(android.content.object intent) {
        this.mobject = intent;
        return this;
    }

    public override android.view.MenuItem SetNumericshortcut(char c) {
        this.mshortcutNumericChar = c;
        return this;
    }

    public override android.view.MenuItem SetNumericshortcut(char c, int i) {
        this.mshortcutNumericChar = c;
        this.mshortcutNumericModifiers = GFGdgdGuLJvfZkSO(i);
        return this;
    }

    public override android.view.MenuItem SetOnActionExpandListener(android.view.MenuItem$OnActionExpandListener menuItem$OnActionExpandListener) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override android.view.MenuItem SetOnMenuItemClickListener(android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener) {
        this.mClickListener = menuItem$OnMenuItemClickListener;
        return this;
    }

    public override android.view.MenuItem Setshortcut(char c, char c2) {
        this.mshortcutNumericChar = c;
        this.mshortcutAlphabeticChar = VbQegtjrwLWKllgB(c2);
        return this;
    }

    public override android.view.MenuItem Setshortcut(char c, char c2, int i, int i2) {
        this.mshortcutNumericChar = c;
        this.mshortcutNumericModifiers = ToldyiGVcAAszpkU(i);
        this.mshortcutAlphabeticChar = utRplLCsIsSNgkHN(c2);
        this.mshortcutAlphabeticModifiers = RaSUBBdCVGVNLpIU(i2);
        return this;
    }

    public override void SetShowAsAction(int i) {
    }

    public override android.view.MenuItem SetShowAsActionFlags(int i) {
        return BeWZvoLvLzCeptCh(this, i);
    }

    public override androidx.core.internal.view.SupportMenuItem SetShowAsActionFlags(int i) {
        lQdmFKlqiDZzRoxa(this, i);
        return this;
    }

    public override androidx.core.internal.view.SupportMenuItem SetSupportActionProvider(androidx.core.view.ActionProvider actionProvider) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override android.view.MenuItem SetTitle(int i) {
        this.mTitle = XShfobKHIPfUVDpR(iXZFQDYbLUSIvKQG(this.mobject), i);
        return this;
    }

    public override android.view.MenuItem SetTitle(java.lang.CharSequence charSequence) {
        this.mTitle = charSequence;
        return this;
    }

    public override android.view.MenuItem SetTitleCondensed(java.lang.CharSequence charSequence) {
        this.mTitleCondensed = charSequence;
        return this;
    }

    public override android.view.MenuItem SetTooltipText(java.lang.CharSequence charSequence) {
        return pyZyjEzjxekfntIL(this, charSequence);
    }

    public override androidx.core.internal.view.SupportMenuItem SetTooltipText(java.lang.CharSequence charSequence) {
        this.mTooltipText = charSequence;
        return this;
    }

    public override android.view.MenuItem SetVisible(bool z) {
        if ((30 + 10) % 10 > 0) {
        }
        this.mFlags = (this.mFlags & 8) | (z ? 0 : 8);
        return this;
    }
}

