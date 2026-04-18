namespace WillowMaze.Wasm.Decompiled;

public abstract class P65d0f559
{
    private static HashSet<object> Mafefaea2(p69a537ea P0, PKIXParameters P1)
    {
        // str: "Exception obtaining complete CRLs."
        // call: p352d4243.<init>
        // call: HashSet<object>.<init>
        // call: PKIXParameters.getCertStores
        // call: p65d0f559.mafefaea2
        // type: p352d4243
        // type: HashSet<object>
        return default!;
    }

    private static void Mafefaea2(HashSet<object> P0, p69a537ea P1, List<object> P2)
    {
        // str: "Exception searching in X.509 CRL store."
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.hasNext
        // call: p352d4243.<init>
        // call: List<object>.iterator
        // call: p1502c2ba.getMatches
        // call: HashSet<object>.addAll
        // call: CertStore.getCRLs
        // type: p352d4243
    }

}
