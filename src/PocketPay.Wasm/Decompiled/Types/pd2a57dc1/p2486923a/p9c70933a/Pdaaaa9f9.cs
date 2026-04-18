namespace WillowMaze.Wasm.Decompiled;

public class Pdaaaa9f9 : Pe38281d8
{
    private readonly ActivityResultLauncher F8c83a0b2;
    private readonly ActivityResultLauncher Fac01040d;
    private readonly ActivityResultLauncher Fb45bf84f;
    private readonly Lazy<object> ViewModel$delegate;

    private static void M1814f0a7(pdaaaa9f9 P0, ActivityResult P1)
    {
        // call: ActivityResult.getResultCode
        // call: Toast.show
        // call: DecryptString.decryptString
        // call: Toast.makeText
        // call: pdaaaa9f9.getActivity
        // call: pdaaaa9f9.getString
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$string.new_version_available_error
    }

    private void M49d81568()
    {
        // call: pe7853c26.getUiState
        // call: pdaaaa9f9.mac404cc3
        // call: pdaaaa9f9$pd41d8cd9$pcca4ef0e.<init>
        // call: pe7853c26.checkUpdates
        // call: pfafca1ef.m0788a692
        // field: pd2a57dc1.p2486923a.p9c70933a.pdaaaa9f9.fac01040d
        // type: pdaaaa9f9$pd41d8cd9$pcca4ef0e
    }

    private static void M5ccd754b(pdaaaa9f9 P0, p74c9efb4 P1)
    {
        // str: "state"
        // call: bool.booleanValue
        // call: Intrinsics.checkNotNullParameter
        // call: p93634cf6.getData
        // call: pdaaaa9f9.mac404cc3
        // call: p74c9efb4.getNeedAppUpdate
        // call: pdaaaa9f9.setLaunchScreen
        // call: pe7853c26.getUpdateScreen
        // call: pdaaaa9f9.getNavigator
        // field: kotlin.Unit.INSTANCE
    }

    public static void M62a8ed22(pdaaaa9f9 P0, p74c9efb4 P1)
    {
        // call: pdaaaa9f9.m5ccd754b
    }

    private pe7853c26 Mac404cc3()
    {
        // call: Lazy<object>.getValue
        // field: pd2a57dc1.p2486923a.p9c70933a.pdaaaa9f9.viewModel$delegate
        return default!;
    }

    public static void Mb23bd006(pdaaaa9f9 P0, ActivityResult P1)
    {
        // call: pdaaaa9f9.m1814f0a7
    }

    public p2fc3359e GetLaunchScreen()
    {
        // call: pe7853c26.getSplashScreen
        // call: pdaaaa9f9.mac404cc3
        return default!;
    }

    public void OnViewCreated(object P0, Dictionary<string, object> P1)
    {
        // str: "view"
        // call: Intrinsics.checkNotNullParameter
        // call: pe38281d8.onViewCreated
        // call: pdaaaa9f9.m49d81568
    }

}
