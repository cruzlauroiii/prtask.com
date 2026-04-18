namespace WillowMaze.Wasm.Decompiled;

public abstract class P65d0f559
{
    private static HashSet<object> Mafefaea2(p9bcd0c1c P0, DateTime P1, List<object> P2, List<object> P3)
    {
        // str: "Exception obtaining complete CRLs."
        // call: X509CRL.getNextUpdate
        // call: DateTime.before
        // call: X509CRL.getThisUpdate
        // call: HashSet<object>.iterator
        // call: p9bcd0c1c.getCertificateChecking
        // call: IEnumerator<object>.next
        // call: HashSet<object>.<init>
        // call: p65d0f559.mafefaea2
        // call: p352d4243.<init>
        // call: IEnumerator<object>.hasNext
        // call: DateTime.after
        // call: X509Certificate.getNotAfter
        // call: HashSet<object>.add
        // type: HashSet<object>
        // type: p352d4243
        return default!;
    }

    private static void Mafefaea2(HashSet<object> P0, p9bcd0c1c P1, List<object> P2)
    {
        // str: "Exception searching in X.509 CRL store."
        // call: pfdb0c388.getMatches
        // call: HashSet<object>.addAll
        // call: List<object>.iterator
        // call: p352d4243.<init>
        // call: IEnumerator<object>.hasNext
        // call: p9bcd0c1c.m891cdc9e
        // call: IEnumerator<object>.next
        // type: p352d4243
    }

}
