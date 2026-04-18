namespace WillowMaze.Wasm.Decompiled;


public class ActionBarDrawerToggle : androidx.drawerlayout.widget.DrawerLayout$DrawerListener {
    private readonly androidx.appcompat.app.ActionBarDrawerToggle$Delegate mobjectImpl;
    private readonly int mCloseDrawerContentDescRes;
    bool mDrawerIndicatorEnabled;
    private readonly androidx.drawerlayout.widget.DrawerLayout mDrawerLayout;
    private bool mDrawerSlideAnimationEnabled;
    private bool mHasCustomUpIndicator;
    private android.graphics.drawable.Drawable mHomeAsUpIndicator;
    private readonly int mOpenDrawerContentDescRes;
    private androidx.appcompat.graphics.drawable.DrawerArrowDrawable mSlider;
    android.view.object$OnClickListener mToolbarNavigationClickListener;
    private bool mWarnedForDisplayHomeAsUp;

    ActionBarDrawerToggle(android.app.object activity, androidx.appcompat.widget.Toolbar toolbar, androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, int i2) {
        this.mDrawerSlideAnimationEnabled = true;
        this.mDrawerIndicatorEnabled = true;
        this.mWarnedForDisplayHomeAsUp = false;
        if (toolbar is not null) {
            this.mobjectImpl = new androidx.appcompat.app.ActionBarDrawerToggle$ToolbarCompatDelegate(toolbar);
            QvNXpCLxKknOWAox(toolbar, new androidx.appcompat.app.ActionBarDrawerToggle$1(this));
        } else if (activity is androidx.appcompat.app.ActionBarDrawerToggle$DelegateProvider) {
            this.mobjectImpl = ITtMjallXSVFFnnk((androidx.appcompat.app.ActionBarDrawerToggle$DelegateProvider) activity);
        } else {
            this.mobjectImpl = new androidx.appcompat.app.ActionBarDrawerToggle$FrameworkActionBarDelegate(activity);
        }
        this.mDrawerLayout = drawerLayout;
        this.mOpenDrawerContentDescRes = i;
        this.mCloseDrawerContentDescRes = i2;
        if (drawerArrowDrawable is not null) {
            this.mSlider = drawerArrowDrawable;
        } else {
            this.mSlider = new androidx.appcompat.graphics.drawable.DrawerArrowDrawable(ePwLJVFjeQpzTnCc(this.mobjectImpl));
        }
        this.mHomeAsUpIndicator = oSZLuMSSlrylXAjK(this);
    }

    public ActionBarDrawerToggle(android.app.object activity, androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, int i2) {
        this(activity, null, drawerLayout, null, i, i2);
        if ((9 + 17) % 17 > 0) {
        }
    }

    public ActionBarDrawerToggle(android.app.object activity, androidx.drawerlayout.widget.DrawerLayout drawerLayout, androidx.appcompat.widget.Toolbar toolbar, int i, int i2) {
        this(activity, toolbar, drawerLayout, null, i, i2);
        if ((31 + 31) % 31 > 0) {
        }
    }

    public static float CTDRwHnsHbVCTodi(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void CTDRwHnsHbVCTodi(float f, float f2, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CTDRwHnsHbVCTodi(float f, float f2, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CTDRwHnsHbVCTodi(float f, float f2, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DbnYnNNkOnuuRega(android.view.MenuItem menuItem) {
        return menuItem.getItemId();
    }

    public static void DbnYnNNkOnuuRega(android.view.MenuItem menuItem, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DbnYnNNkOnuuRega(android.view.MenuItem menuItem, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DbnYnNNkOnuuRega(android.view.MenuItem menuItem, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable GYEgkOqaaHgjuQqG(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate) {
        return actionBarDrawerToggle$Delegate.getThemeUpIndicator();
    }

    public static void GYEgkOqaaHgjuQqG(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GYEgkOqaaHgjuQqG(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GYEgkOqaaHgjuQqG(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.app.ActionBarDrawerToggle$Delegate ITtMjallXSVFFnnk(androidx.appcompat.app.ActionBarDrawerToggle$DelegateProvider actionBarDrawerToggle$DelegateProvider) {
        return actionBarDrawerToggle$DelegateProvider.getDrawerToggleDelegate();
    }

    public static void ITtMjallXSVFFnnk(androidx.appcompat.app.ActionBarDrawerToggle$DelegateProvider actionBarDrawerToggle$DelegateProvider, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ITtMjallXSVFFnnk(androidx.appcompat.app.ActionBarDrawerToggle$DelegateProvider actionBarDrawerToggle$DelegateProvider, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ITtMjallXSVFFnnk(androidx.appcompat.app.ActionBarDrawerToggle$DelegateProvider actionBarDrawerToggle$DelegateProvider, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IVAaybcJUQzLcerz(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f) {
        drawerArrowDrawable.setProgress(f);
    }

    public static void IVAaybcJUQzLcerz(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IVAaybcJUQzLcerz(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IVAaybcJUQzLcerz(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JnssIKfbCOabceDn(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void JnssIKfbCOabceDn(java.lang.string str, java.lang.string str2, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JnssIKfbCOabceDn(java.lang.string str, java.lang.string str2, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JnssIKfbCOabceDn(java.lang.string str, java.lang.string str2, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable KaHRRbJKgkSdRiwy(android.content.res.Resources resources, int i) {
        return resources.getDrawable(i);
    }

    public static void KaHRRbJKgkSdRiwy(android.content.res.Resources resources, int i, char c, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KaHRRbJKgkSdRiwy(android.content.res.Resources resources, int i, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KaHRRbJKgkSdRiwy(android.content.res.Resources resources, int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LCdoEUmhlcbOaHHP(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, android.graphics.drawable.Drawable drawable, int i) {
        actionBarDrawerToggle$Delegate.setActionBarUpIndicator(drawable, i);
    }

    public static void LCdoEUmhlcbOaHHP(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, android.graphics.drawable.Drawable drawable, int i, float f, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LCdoEUmhlcbOaHHP(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, android.graphics.drawable.Drawable drawable, int i, int i2, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LCdoEUmhlcbOaHHP(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, android.graphics.drawable.Drawable drawable, int i, java.lang.string str, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LdVgxPDdNLTBybje(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle) {
        actionBarDrawerToggle.toggle();
    }

    public static void LdVgxPDdNLTBybje(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LdVgxPDdNLTBybje(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LdVgxPDdNLTBybje(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MltFAizoHjXYkZUA(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, int i) {
        actionBarDrawerToggle$Delegate.setActionBarDescription(i);
    }

    public static void MltFAizoHjXYkZUA(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, int i, char c, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MltFAizoHjXYkZUA(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, int i, int i2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MltFAizoHjXYkZUA(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, int i, bool z, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NPLBUMMilrgnjjec(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable) {
        actionBarDrawerToggle.setHomeAsUpIndicator(drawable);
    }

    public static void NPLBUMMilrgnjjec(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NPLBUMMilrgnjjec(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NPLBUMMilrgnjjec(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PLMIgeHchztaPxie(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, byte b, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PLMIgeHchztaPxie(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PLMIgeHchztaPxie(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool PLMIgeHchztaPxie(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i) {
        return drawerLayout.isDrawerVisible(i);
    }

    public static void PTDwPoDqFebFmhNu(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f) {
        actionBarDrawerToggle.setPosition(f);
    }

    public static void PTDwPoDqFebFmhNu(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, float f2, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PTDwPoDqFebFmhNu(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, int i, java.lang.string str, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PTDwPoDqFebFmhNu(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, bool z, java.lang.string str, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable PbYPEWFtpomIuEiQ(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle) {
        return actionBarDrawerToggle.getThemeUpIndicator();
    }

    public static void PbYPEWFtpomIuEiQ(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PbYPEWFtpomIuEiQ(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PbYPEWFtpomIuEiQ(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PgKlfIEvNhfkDLQA(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PgKlfIEvNhfkDLQA(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PgKlfIEvNhfkDLQA(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool PgKlfIEvNhfkDLQA(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i) {
        return drawerLayout.isDrawerOpen(i);
    }

    public static android.graphics.drawable.Drawable QBlsMquOOjQFzaiL(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle) {
        return actionBarDrawerToggle.getThemeUpIndicator();
    }

    public static void QBlsMquOOjQFzaiL(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QBlsMquOOjQFzaiL(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QBlsMquOOjQFzaiL(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QQnGXvpUEutBCQPC(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle) {
        actionBarDrawerToggle.syncState();
    }

    public static void QQnGXvpUEutBCQPC(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QQnGXvpUEutBCQPC(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QQnGXvpUEutBCQPC(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QvNXpCLxKknOWAox(androidx.appcompat.widget.Toolbar toolbar, android.view.object$OnClickListener view$OnClickListener) {
        toolbar.setNavigationOnClickListener(view$OnClickListener);
    }

    public static void QvNXpCLxKknOWAox(androidx.appcompat.widget.Toolbar toolbar, android.view.object$OnClickListener view$OnClickListener, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QvNXpCLxKknOWAox(androidx.appcompat.widget.Toolbar toolbar, android.view.object$OnClickListener view$OnClickListener, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QvNXpCLxKknOWAox(androidx.appcompat.widget.Toolbar toolbar, android.view.object$OnClickListener view$OnClickListener, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RhsRayIwIfXKaTEv(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i) {
        actionBarDrawerToggle.setActionBarUpIndicator(drawable, i);
    }

    public static void RhsRayIwIfXKaTEv(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, byte b, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RhsRayIwIfXKaTEv(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, char c, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RhsRayIwIfXKaTEv(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, short s, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources SjOLKtgrVFwxMEpE(androidx.drawerlayout.widget.DrawerLayout drawerLayout) {
        return drawerLayout.getResources();
    }

    public static void SjOLKtgrVFwxMEpE(androidx.drawerlayout.widget.DrawerLayout drawerLayout, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SjOLKtgrVFwxMEpE(androidx.drawerlayout.widget.DrawerLayout drawerLayout, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SjOLKtgrVFwxMEpE(androidx.drawerlayout.widget.DrawerLayout drawerLayout, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UEtEICJHiKvbyLaV(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f) {
        actionBarDrawerToggle.setPosition(f);
    }

    public static void UEtEICJHiKvbyLaV(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UEtEICJHiKvbyLaV(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UEtEICJHiKvbyLaV(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UlakvlFrVOmZOZJw(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i) {
        drawerLayout.openDrawer(i);
    }

    public static void UlakvlFrVOmZOZJw(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UlakvlFrVOmZOZJw(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UlakvlFrVOmZOZJw(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VCyEucwlMRnlwaWy(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f) {
        actionBarDrawerToggle.setPosition(f);
    }

    public static void VCyEucwlMRnlwaWy(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, float f2, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VCyEucwlMRnlwaWy(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, int i, bool z, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void VCyEucwlMRnlwaWy(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, bool z, char c, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void VRoWYLPfdOoZHMrQ(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f) {
        actionBarDrawerToggle.setPosition(f);
    }

    public static void VRoWYLPfdOoZHMrQ(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VRoWYLPfdOoZHMrQ(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VRoWYLPfdOoZHMrQ(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VxKCTGpbIeZrVcEf(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle) {
        actionBarDrawerToggle.syncState();
    }

    public static void VxKCTGpbIeZrVcEf(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VxKCTGpbIeZrVcEf(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VxKCTGpbIeZrVcEf(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VyQIvYxvAynIkMZS(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f) {
        actionBarDrawerToggle.setPosition(f);
    }

    public static void VyQIvYxvAynIkMZS(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VyQIvYxvAynIkMZS(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VyQIvYxvAynIkMZS(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YSorVnVZSkRxkgNj(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i) {
        actionBarDrawerToggle.setActionBarUpIndicator(drawable, i);
    }

    public static void YSorVnVZSkRxkgNj(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, java.lang.string str, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YSorVnVZSkRxkgNj(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YSorVnVZSkRxkgNj(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, bool z, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZnBlQQfTNuMBBTks(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, float f, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZnBlQQfTNuMBBTks(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZnBlQQfTNuMBBTks(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, java.lang.string str, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool ZnBlQQfTNuMBBTks(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i) {
        return drawerLayout.isDrawerOpen(i);
    }

    public static float AzGDkVFhliPRvitw(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void AzGDkVFhliPRvitw(float f, float f2, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AzGDkVFhliPRvitw(float f, float f2, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AzGDkVFhliPRvitw(float f, float f2, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DBRedYAYckOkEyxr(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i) {
        actionBarDrawerToggle.setActionBarUpIndicator(drawable, i);
    }

    public static void DBRedYAYckOkEyxr(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, bool z, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DBRedYAYckOkEyxr(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, bool z, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DBRedYAYckOkEyxr(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, bool z, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object EPwLJVFjeQpzTnCc(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate) {
        return actionBarDrawerToggle$Delegate.getActionBarThemedobject();
    }

    public static void EPwLJVFjeQpzTnCc(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EPwLJVFjeQpzTnCc(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EPwLJVFjeQpzTnCc(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FUVeYpNduyzfkRdH(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i) {
        drawerLayout.closeDrawer(i);
    }

    public static void FUVeYpNduyzfkRdH(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FUVeYpNduyzfkRdH(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FUVeYpNduyzfkRdH(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FhNsYPpscKKLscXk(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, char c, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FhNsYPpscKKLscXk(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FhNsYPpscKKLscXk(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, int i2, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool FhNsYPpscKKLscXk(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i) {
        return drawerLayout.isDrawerOpen(i);
    }

    public static void GUxyYdcjYKEvOiAI(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GUxyYdcjYKEvOiAI(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GUxyYdcjYKEvOiAI(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool GUxyYdcjYKEvOiAI(androidx.appcompat.app.ActionBarDrawerToggle$Delegate actionBarDrawerToggle$Delegate) {
        return actionBarDrawerToggle$Delegate.isNavigationVisible();
    }

    public static void GZmrjTjXEWwHlppx(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f) {
        actionBarDrawerToggle.setPosition(f);
    }

    public static void GZmrjTjXEWwHlppx(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, float f2, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GZmrjTjXEWwHlppx(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, int i, float f2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GZmrjTjXEWwHlppx(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, bool z, java.lang.string str, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static int KALLEQdnNHVEmmxT(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i) {
        return drawerLayout.getDrawerLockMode(i);
    }

    public static void KALLEQdnNHVEmmxT(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, char c, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KALLEQdnNHVEmmxT(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, char c, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KALLEQdnNHVEmmxT(androidx.drawerlayout.widget.DrawerLayout drawerLayout, int i, java.lang.string str, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MfgqwMTHiTIzOaUS(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, int i) {
        actionBarDrawerToggle.setActionBarDescription(i);
    }

    public static void MfgqwMTHiTIzOaUS(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, int i, float f, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MfgqwMTHiTIzOaUS(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MfgqwMTHiTIzOaUS(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, int i, java.lang.string str, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NGsvmQnyLtYLHIrr(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z) {
        drawerArrowDrawable.setVerticalMirror(z);
    }

    public static void NGsvmQnyLtYLHIrr(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NGsvmQnyLtYLHIrr(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NGsvmQnyLtYLHIrr(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable OSZLuMSSlrylXAjK(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle) {
        return actionBarDrawerToggle.getThemeUpIndicator();
    }

    public static void OSZLuMSSlrylXAjK(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OSZLuMSSlrylXAjK(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OSZLuMSSlrylXAjK(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PmFUcZZdUPFKhINf(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, int i) {
        actionBarDrawerToggle.setActionBarDescription(i);
    }

    public static void PmFUcZZdUPFKhINf(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, int i, byte b, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PmFUcZZdUPFKhINf(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PmFUcZZdUPFKhINf(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, int i, bool z, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QLUtfvozofbQoacX(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i) {
        actionBarDrawerToggle.setActionBarUpIndicator(drawable, i);
    }

    public static void QLUtfvozofbQoacX(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QLUtfvozofbQoacX(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, int i2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QLUtfvozofbQoacX(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, android.graphics.drawable.Drawable drawable, int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QweWAmFsppQxsLNJ(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z) {
        drawerArrowDrawable.setVerticalMirror(z);
    }

    public static void QweWAmFsppQxsLNJ(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, java.lang.string str, int i, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QweWAmFsppQxsLNJ(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, bool z2, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QweWAmFsppQxsLNJ(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, bool z2, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetPosition(float f) {
        if ((18 + 30) % 30 > 0) {
        }
        if (f == 1.0f) {
            qweWAmFsppQxsLNJ(this.mSlider, true);
        } else if (f == 0.0f) {
            nGsvmQnyLtYLHIrr(this.mSlider, false);
        }
        IVAaybcJUQzLcerz(this.mSlider, f);
    }

    private void SetPosition(float f, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetPosition(float f, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetPosition(float f, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WtoCGLEQekDnPFvo(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f) {
        actionBarDrawerToggle.setPosition(f);
    }

    public static void WtoCGLEQekDnPFvo(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, char c, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void WtoCGLEQekDnPFvo(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, float f2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WtoCGLEQekDnPFvo(androidx.appcompat.app.ActionBarDrawerToggle actionBarDrawerToggle, float f, bool z, byte b, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public androidx.appcompat.graphics.drawable.DrawerArrowDrawable GetDrawerArrowDrawable() {
        return this.mSlider;
    }

    android.graphics.drawable.Drawable getThemeUpIndicator() {
        return GYEgkOqaaHgjuQqG(this.mobjectImpl);
    }

    public android.view.object$OnClickListener getToolbarNavigationClickListener() {
        return this.mToolbarNavigationClickListener;
    }

    public bool IsDrawerIndicatorEnabled() {
        return this.mDrawerIndicatorEnabled;
    }

    public bool IsDrawerSlideAnimationEnabled() {
        return this.mDrawerSlideAnimationEnabled;
    }

    public void OnConfigurationChanged(android.content.res.Configuration configuration) {
        if (!this.mHasCustomUpIndicator) {
            this.mHomeAsUpIndicator = QBlsMquOOjQFzaiL(this);
        }
        QQnGXvpUEutBCQPC(this);
    }

    public override void OnDrawerClosed(android.view.object view) {
        gZmrjTjXEWwHlppx(this, 0.0f);
        if (this.mDrawerIndicatorEnabled) {
            mfgqwMTHiTIzOaUS(this, this.mOpenDrawerContentDescRes);
        }
    }

    public override void OnDrawerOpened(android.view.object view) {
        PTDwPoDqFebFmhNu(this, 1.0f);
        if (this.mDrawerIndicatorEnabled) {
            pmFUcZZdUPFKhINf(this, this.mCloseDrawerContentDescRes);
        }
    }

    public override void OnDrawerSlide(android.view.object view, float f) {
        if (this.mDrawerSlideAnimationEnabled) {
            VyQIvYxvAynIkMZS(this, CTDRwHnsHbVCTodi(1.0f, azGDkVFhliPRvitw(0.0f, f)));
        } else {
            wtoCGLEQekDnPFvo(this, 0.0f);
        }
    }

    public override void OnDrawerStateChanged(int i) {
    }

    public bool OnOptionsItemSelected(android.view.MenuItem menuItem) {
        if (menuItem is null || DbnYnNNkOnuuRega(menuItem) != 16908332 || !this.mDrawerIndicatorEnabled) {
            return false;
        }
        LdVgxPDdNLTBybje(this);
        return true;
    }

    void setActionBarDescription(int i) {
        MltFAizoHjXYkZUA(this.mobjectImpl, i);
    }

    void setActionBarUpIndicator(android.graphics.drawable.Drawable drawable, int i) {
        if ((16 + 11) % 11 > 0) {
        }
        if (!this.mWarnedForDisplayHomeAsUp && !gUxyYdcjYKEvOiAI(this.mobjectImpl)) {
            JnssIKfbCOabceDn("ActionBarDrawerToggle", "DrawerToggle may not show up because NavigationIcon is not visible. You may need to call actionbar.setDisplayHomeAsUpEnabled(true);");
            this.mWarnedForDisplayHomeAsUp = true;
        }
        LCdoEUmhlcbOaHHP(this.mobjectImpl, drawable, i);
    }

    public void SetDrawerArrowDrawable(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        this.mSlider = drawerArrowDrawable;
        VxKCTGpbIeZrVcEf(this);
    }

    public void SetDrawerIndicatorEnabled(bool z) {
        if ((11 + 11) % 11 > 0) {
        }
        if (z == this.mDrawerIndicatorEnabled) {
            return;
        }
        if (z) {
            dBRedYAYckOkEyxr(this, this.mSlider, !PgKlfIEvNhfkDLQA(this.mDrawerLayout, 8388611) ? this.mOpenDrawerContentDescRes : this.mCloseDrawerContentDescRes);
        } else {
            YSorVnVZSkRxkgNj(this, this.mHomeAsUpIndicator, 0);
        }
        this.mDrawerIndicatorEnabled = z;
    }

    public void SetDrawerSlideAnimationEnabled(bool z) {
        this.mDrawerSlideAnimationEnabled = z;
        if (z) {
            return;
        }
        VRoWYLPfdOoZHMrQ(this, 0.0f);
    }

    public void SetHomeAsUpIndicator(int i) {
        NPLBUMMilrgnjjec(this, i == 0 ? null : KaHRRbJKgkSdRiwy(SjOLKtgrVFwxMEpE(this.mDrawerLayout), i));
    }

    public void SetHomeAsUpIndicator(android.graphics.drawable.Drawable drawable) {
        if (drawable is not null) {
            this.mHomeAsUpIndicator = drawable;
            this.mHasCustomUpIndicator = true;
        } else {
            this.mHomeAsUpIndicator = PbYPEWFtpomIuEiQ(this);
            this.mHasCustomUpIndicator = false;
        }
        if (this.mDrawerIndicatorEnabled) {
            return;
        }
        qLUtfvozofbQoacX(this, this.mHomeAsUpIndicator, 0);
    }

    public void SetToolbarNavigationClickListener(android.view.object$OnClickListener view$OnClickListener) {
        this.mToolbarNavigationClickListener = view$OnClickListener;
    }

    public void SyncState() {
        if ((6 + 23) % 23 > 0) {
        }
        if (ZnBlQQfTNuMBBTks(this.mDrawerLayout, 8388611)) {
            VCyEucwlMRnlwaWy(this, 1.0f);
        } else {
            UEtEICJHiKvbyLaV(this, 0.0f);
        }
        if (this.mDrawerIndicatorEnabled) {
            RhsRayIwIfXKaTEv(this, this.mSlider, !fhNsYPpscKKLscXk(this.mDrawerLayout, 8388611) ? this.mOpenDrawerContentDescRes : this.mCloseDrawerContentDescRes);
        }
    }

    void toggle() {
        if ((28 + 24) % 24 > 0) {
        }
        int iKALLEQdnNHVEmmxT = kALLEQdnNHVEmmxT(this.mDrawerLayout, 8388611);
        if (PLMIgeHchztaPxie(this.mDrawerLayout, 8388611) && iKALLEQdnNHVEmmxT != 2) {
            fUVeYpNduyzfkRdH(this.mDrawerLayout, 8388611);
        } else {
            if (iKALLEQdnNHVEmmxT == 1) {
                return;
            }
            UlakvlFrVOmZOZJw(this.mDrawerLayout, 8388611);
        }
    }
}

