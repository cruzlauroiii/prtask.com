namespace WillowMaze.Wasm.Decompiled;

public class Pf83fabfe_1 : P406c70d6
{
    private readonly pf83fabfe This$0;
    private readonly p406c70d6 Val$callback;

    private void CallFailure(Exception P0)
    {
        // call: pa470a233.throwIfFatal
        // call: p406c70d6.onFailure
        // call: Exception.printStackTrace
        // field: paa20ed97.pf83fabfe$1.val$callback
        // field: paa20ed97.pf83fabfe$1.this$0
    }

    public void OnFailure(pc3755e61 P0, IOException P1)
    {
        // call: pf83fabfe$1.callFailure
    }

    public void OnResponse(pc3755e61 P0, pd64ed3e9 P1)
    {
        // call: pa470a233.throwIfFatal
        // call: Exception.printStackTrace
        // call: pf83fabfe.parseResponse
        // call: p406c70d6.onResponse
        // call: pf83fabfe$1.callFailure
        // field: paa20ed97.pf83fabfe$1.this$0
        // field: paa20ed97.pf83fabfe$1.val$callback
    }

}
