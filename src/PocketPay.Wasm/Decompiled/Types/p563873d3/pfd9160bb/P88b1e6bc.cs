namespace WillowMaze.Wasm.Decompiled;

public class P88b1e6bc : P4514631e
{
    private readonly p9cd72ef0 F192771ce;
    private readonly p9cd72ef0 F6e5f759b;
    private readonly p9cd72ef0 F97760498;
    private readonly p9cd72ef0 Ff3395cd5;

    public void Back()
    {
        // call: p9cd72ef0.exit
        // field: p563873d3.pfd9160bb.p88b1e6bc.ff3395cd5
    }

    public void FinishChain()
    {
        // call: p9cd72ef0.finishChain
        // field: p563873d3.pfd9160bb.p88b1e6bc.ff3395cd5
    }

    public void OpenAccountNotFound()
    {
        // call: p1e1e789b.AccountNotFoundScreen
        // call: p9cd72ef0.navigateTo
        // field: p563873d3.pfd9160bb.p1e1e789b.f76425f17
        // field: p563873d3.pfd9160bb.p88b1e6bc.ff3395cd5
    }

    public void OpenCheckRegisteredAccountError()
    {
        // call: p9cd72ef0.replaceScreen
        // call: p1e1e789b.CheckRegisteredAccountErrorScreen
        // field: p563873d3.pfd9160bb.p88b1e6bc.ff3395cd5
        // field: p563873d3.pfd9160bb.p1e1e789b.f76425f17
    }

    public void OpenRegistration()
    {
        // call: p1e1e789b.RegistrationScreen
        // call: p9cd72ef0.navigateTo
        // field: p563873d3.pfd9160bb.p1e1e789b.f76425f17
        // field: p563873d3.pfd9160bb.p88b1e6bc.ff3395cd5
    }

    public void OpenRegistrationInfo()
    {
        // call: p1e1e789b.RegistrationInfoScreen
        // call: p9cd72ef0.navigateTo
        // field: p563873d3.pfd9160bb.p88b1e6bc.ff3395cd5
        // field: p563873d3.pfd9160bb.p1e1e789b.f76425f17
    }

    public void OpenRegistrationSuccess(string P0)
    {
        // str: "email"
        // call: Intrinsics.checkNotNullParameter
        // call: p1e1e789b.RegistrationSuccessScreen
        // call: p9cd72ef0.replaceScreen
        // field: p563873d3.pfd9160bb.p88b1e6bc.ff3395cd5
        // field: p563873d3.pfd9160bb.p1e1e789b.f76425f17
    }

    public void StartRegistrationFlow()
    {
        // call: p9cd72ef0.newRootScreen
        // call: p1e1e789b.ChooseUserRoleScreen
        // field: p563873d3.pfd9160bb.p1e1e789b.f76425f17
        // field: p563873d3.pfd9160bb.p88b1e6bc.ff3395cd5
    }

}
