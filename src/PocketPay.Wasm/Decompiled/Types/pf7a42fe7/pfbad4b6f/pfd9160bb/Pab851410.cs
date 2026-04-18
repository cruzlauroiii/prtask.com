namespace WillowMaze.Wasm.Decompiled;

public class Pab851410 : P48cb2d85
{
    private readonly p9cd72ef0 F0e83efaf;
    private readonly p9cd72ef0 F3b151157;
    private readonly p9cd72ef0 F560e45eb;
    private readonly p9cd72ef0 Ff3395cd5;

    public void Back()
    {
        // call: p9cd72ef0.exit
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.pab851410.ff3395cd5
    }

    public void FinishChain()
    {
        // call: p9cd72ef0.finishChain
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.pab851410.ff3395cd5
    }

    public void OpenChangeRoleDescription()
    {
        // call: p55b76044.AccountFoundChangeRoleScreen
        // call: p9cd72ef0.navigateTo
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.pab851410.ff3395cd5
    }

    public void OpenPhoneVerification()
    {
        // call: p55b76044.PhoneVerificationScreen
        // call: p9cd72ef0.navigateTo
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.pab851410.ff3395cd5
    }

    public void OpenSmsVerification(string P0)
    {
        // str: "phone"
        // call: p55b76044.SmsVerificationScreen
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.navigateTo
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.pab851410.ff3395cd5
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17
    }

    public void StartBusinessAccountFound()
    {
        // call: p55b76044.AccountFoundBusinessScreen
        // call: p9cd72ef0.newRootScreen
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.pab851410.ff3395cd5
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17
    }

    public void StartCashierAccountFound()
    {
        // call: p55b76044.AccountFoundCashierScreen
        // call: p9cd72ef0.newRootScreen
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.pab851410.ff3395cd5
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17
    }

    public void StartPhoneVerificationFlow()
    {
        // call: p9cd72ef0.newRootScreen
        // call: p55b76044.SetupScreen
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.pab851410.ff3395cd5
    }

    public void StartSmsVerificationChain(string P0)
    {
        // str: "phone"
        // call: p55b76044.SmsVerificationScreen
        // call: p55b76044.PhoneVerificationScreen
        // call: p9cd72ef0.newRootChain
        // call: Intrinsics.checkNotNullParameter
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.p55b76044.f76425f17
        // field: pf7a42fe7.pfbad4b6f.pfd9160bb.pab851410.ff3395cd5
    }

}
