namespace WillowMaze.Wasm.Decompiled;

public class P85eb7a7e_p66a8c391_pfc649740 : P406c70d6
{
    private readonly CompletableFuture F22eff264;
    private readonly CompletableFuture F29e3a61e;
    private readonly CompletableFuture Fda907a1b;
    private readonly p85eb7a7e$p66a8c391 This$0;

    public void OnFailure(pc3755e61 P0, Exception P1)
    {
        // call: CompletableFuture.completeExceptionally
        // field: paa20ed97.p85eb7a7e$p66a8c391$pfc649740.fda907a1b
    }

    public void OnResponse(pc3755e61 P0, Response P1)
    {
        // call: Response.isSuccessful
        // call: Response.body
        // call: CompletableFuture.completeExceptionally
        // call: p8a8cef05.<init>
        // call: CompletableFuture.complete
        // field: paa20ed97.p85eb7a7e$p66a8c391$pfc649740.fda907a1b
        // type: p8a8cef05
    }

}
