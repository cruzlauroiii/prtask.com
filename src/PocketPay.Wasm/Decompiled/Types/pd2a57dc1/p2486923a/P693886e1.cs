namespace WillowMaze.Wasm.Decompiled;

public class P693886e1 : Pd3bd1847
{
    private readonly Lazy<object> AppViewModel$delegate;
    private p8b07625b F7509ece8;
    private p8b07625b F93d07c43;
    private readonly Lazy<object> LocaleRepository$delegate;

    private void M02140e0b()
    {
        // call: p693886e1.mc1da6297
        // call: p4faf9542.handleDeeplinkData
        // call: object.getData
        // call: p693886e1.getIntent
    }

    private void M0a233281()
    {
        // str: "android.permission.POST_NOTIFICATIONS"
        // call: PermissionUtils$Companion.checkAndRequestPermissions$default
        // field: android.os.Build$VERSION.SDK_INT
        // field: com.ckdroid.dynamicpermissions.PermissionUtils.Companion
    }

    private static void M163024fe(ViewGroup$MarginLayoutParams P0, int P1, object P2, ValueAnimator P3)
    {
        // str: "animator"
        // str: "null cannot be cast to non-null type kotlin.Int"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNull
        // call: object.setLayoutParams
        // call: int.intValue
        // call: ValueAnimator.getAnimatedValue
        // field: android.view.ViewGroup$MarginLayoutParams.topMargin
    }

    private static void M1bff47f1(p693886e1 P0, bool P1)
    {
        // call: p693886e1.m71d185d9
        // field: kotlin.Unit.INSTANCE
    }

    private void M30578753(object P0, int P1, int P2, long P3)
    {
        // str: "null cannot be cast to non-null type android.view.ViewGroup.MarginLayoutParams"
        // call: ValueAnimator.setDuration
        // call: object.getLayoutParams
        // call: ValueAnimator.addUpdateListener
        // call: p693886e1$pd41d8cd9$p144e4630.<init>
        // call: Intrinsics.checkNotNull
        // call: ValueAnimator.start
        // call: ValueAnimator.ofInt
        // type: p693886e1$pd41d8cd9$p144e4630
    }

    private static void M3fb476b9(p693886e1 P0, bool P1)
    {
        // call: DecryptString.decryptString
        // call: Intrinsics.checkNotNull
        // call: p693886e1.ma5689ba1
        // call: p693886e1.getResources
        // call: pba2170fe.ma5933f20
        // call: int.valueOf
        // call: p693886e1.getString
        // call: Resources.getDimensionPixelSize
        // call: TextView.setText
        // call: LinearLayout.findViewById
        // call: p693886e1.findViewById
        // field: pad5f82e8.p07214c67.p7d5c009e.pcc4dcad3.fb078ffd2
        // field: pad5f82e8.p07214c67.p7d5c009e.p6fde285f.f9b9c17e1
        // field: pad5f82e8.p07214c67.p7d5c009e.pbb8de671.fe396f36f
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$id.topSlideView
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$id.tvNetworkError
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$dimen.no_network_margin
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$color.color_white
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$string.app_network_issue
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$drawable.ic_no_network
    }

    private void M71d185d9(bool P0)
    {
        // call: p693886e1$pd41d8cd9$pcca4ef0e.<init>
        // call: p693886e1.runOnUiThread
        // type: p693886e1$pd41d8cd9$pcca4ef0e
    }

    public static void M7c5fa648(p693886e1 P0, bool P1)
    {
        // call: p693886e1.m1bff47f1
    }

    public static void M91786848(ViewGroup$MarginLayoutParams P0, int P1, object P2, ValueAnimator P3)
    {
        // call: p693886e1.m163024fe
    }

    private void M963502e9()
    {
        // str: "getApplicationContext(...)"
        // call: p693886e1.getApplicationContext
        // call: p6b91ea5d$p910eef8c.enqueue
        // call: Intrinsics.checkNotNullExpressionValue
        // call: WorkManager$Companion.getInstance
        // field: pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d.f910eef8c
        // field: androidx.work.WorkManager.Companion
    }

    private static void Ma5689ba1(p693886e1 P0, object P1, int P2, int P3, long P4, int P5, object P6)
    {
        // call: p693886e1.m30578753
    }

    private void Mb97b03ea()
    {
        // call: p8b07625b.<init>
        // call: p693886e1$pd41d8cd9$p95263d50.<init>
        // call: p8b07625b.start
        // field: pd2a57dc1.p2486923a.p693886e1.f93d07c43
        // type: p8b07625b
        // type: p693886e1$pd41d8cd9$p95263d50
    }

    private p4faf9542 Mc1da6297()
    {
        // call: Lazy<object>.getValue
        // field: pd2a57dc1.p2486923a.p693886e1.appViewModel$delegate
        return default!;
    }

    private p776a1426 Me1686b47()
    {
        // call: Lazy<object>.getValue
        // field: pd2a57dc1.p2486923a.p693886e1.localeRepository$delegate
        return default!;
    }

    public static void Me3a398b0(p693886e1 P0, bool P1)
    {
        // call: p693886e1.m3fb476b9
    }

    public p52a1792f GetCurrentFragment()
    {
        // call: p693886e1.getSupportFragmentManager
        // call: FragmentManager.findFragmentById
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$id.container
        return default!;
    }

    private void OnActivityResult(int P0, int P1, object P2)
    {
        // call: p693886e1.getCurrentFragment
        // call: p52a1792f.onFragmentResult
        // call: pd3bd1847.onActivityResult
    }

    public void OnBackPressed()
    {
        // call: p693886e1.getCurrentFragment
        // call: p52a1792f.onBackPressed
        // call: pd3bd1847.onBackPressed
    }

    private void OnCreate(Dictionary<string, object> P0)
    {
        // call: p693886e1.me1686b47
        // call: p693886e1.setContentView
        // call: p693886e1.getSupportFragmentManager
        // call: p693886e1.m963502e9
        // call: p693886e1.m02140e0b
        // call: p693886e1.mc1da6297
        // call: pdaaaa9f9.<init>
        // call: FragmentManager.beginTransaction
        // call: FragmentTransaction.commit
        // call: Intrinsics.checkNotNull
        // call: pd3bd1847.onCreate
        // call: p693886e1.m0a233281
        // call: p776a1426.updateConfiguration
        // call: p693886e1.findViewById
        // call: FragmentTransaction.replace
        // call: p57ac6ab6.m4f9637b1
        // call: p4faf9542.sendLifecycleEvent
        // field: androidx.lifecycle.Lifecycle$Event.ON_CREATE
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$layout.layout_container
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$id.container
        // type: pdaaaa9f9
    }

    private void OnDestroy()
    {
        // call: p4faf9542.sendLifecycleEvent
        // call: p8b07625b.stop
        // call: p693886e1.mc1da6297
        // call: pd3bd1847.onDestroy
        // field: androidx.lifecycle.Lifecycle$Event.ON_DESTROY
        // field: pd2a57dc1.p2486923a.p693886e1.f93d07c43
    }

    private void OnPause()
    {
        // call: pd3bd1847.onPause
        // call: p4faf9542.sendLifecycleEvent
        // call: p693886e1.mc1da6297
        // field: androidx.lifecycle.Lifecycle$Event.ON_PAUSE
    }

    private void OnResume()
    {
        // call: p693886e1.mb97b03ea
        // call: p693886e1.mc1da6297
        // call: pd3bd1847.onResume
        // call: p4faf9542.sendLifecycleEvent
        // field: androidx.lifecycle.Lifecycle$Event.ON_RESUME
    }

    private void OnStart()
    {
        // call: p4faf9542.sendLifecycleEvent
        // call: p693886e1.mc1da6297
        // call: pd3bd1847.onStart
        // call: p4faf9542.setDefaultApplicationMode
        // field: androidx.lifecycle.Lifecycle$Event.ON_START
    }

    private void OnStop()
    {
        // call: p4faf9542.sendLifecycleEvent
        // call: p693886e1.mc1da6297
        // call: pd3bd1847.onStop
        // field: androidx.lifecycle.Lifecycle$Event.ON_STOP
    }

    public void OnWindowFocusChanged(bool P0)
    {
        // call: Window.clearFlags
        // call: pd3bd1847.onWindowFocusChanged
        // call: p693886e1.getWindow
        // call: Window.setFlags
    }

}
