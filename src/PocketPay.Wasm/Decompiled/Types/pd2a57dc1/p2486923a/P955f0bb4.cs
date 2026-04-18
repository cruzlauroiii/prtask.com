namespace WillowMaze.Wasm.Decompiled;

public class P955f0bb4 : Pd3bd1847
{
    private void M48267b41(int P0)
    {
        // str: "null cannot be cast to non-null type android.app.NotificationManager"
        // str: "getActiveNotifications(...)"
        // str: "notification"
        // call: Intrinsics.checkNotNull
        // call: NotificationManagerCompat.from
        // call: NotificationManagerCompat.cancel
        // call: StatusBarNotification.getGroupKey
        // call: List<object>.<init>
        // call: ICollection<object>.isEmpty
        // call: StatusBarNotification.getId
        // call: NotificationManager.getActiveNotifications
        // call: p955f0bb4.getSystemService
        // call: Intrinsics.areEqual
        // call: ICollection<object>.add
        // call: Intrinsics.checkNotNullExpressionValue
        // type: List<object>
    }

    private void Mea2b2676(string P0)
    {
        // call: FragmentTransaction.commit
        // call: FragmentTransaction.replace
        // call: p955f0bb4.getSupportFragmentManager
        // call: FragmentManager.beginTransaction
        // call: p2a5e3090.<init>
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$id.container
        // type: p2a5e3090
    }

    public p52a1792f GetCurrentFragment()
    {
        // call: p955f0bb4.getSupportFragmentManager
        // call: FragmentManager.findFragmentById
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$id.container
        return default!;
    }

    public void OnBackPressed()
    {
        // call: p955f0bb4.finish
        // call: pd3bd1847.onBackPressed
    }

    private void OnCreate(Dictionary<string, object> P0)
    {
        // str: "073f241f4b759b73aaf39d9e8ea1266a45f77f8a55d5798ddd6b6f92c2af6b77a52216744c0115e63e002a"
        // str: "38165fd2456d6ce6f85710812d693675b337f6c06f26bacfc6acc48297e320"
        // call: pd3bd1847.onCreate
        // call: p955f0bb4.m48267b41
        // call: p955f0bb4.getIntent
        // call: object.getExtras
        // call: Dictionary<string, object>.getInt
        // call: p955f0bb4.mea2b2676
        // call: Dictionary<string, object>.getString
        // call: int.valueOf
        // call: DecryptString.decryptString
        // call: p955f0bb4.setContentView
        // call: System.Numerics.BigInteger.intValue
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$layout.layout_container
    }

}
