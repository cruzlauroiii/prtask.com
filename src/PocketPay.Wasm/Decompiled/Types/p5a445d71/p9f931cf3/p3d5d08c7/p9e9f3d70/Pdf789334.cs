namespace WillowMaze.Wasm.Decompiled;

public class Pdf789334
{
    private static Dictionary<string, object> F0fea6a13;
    private static int F31249a32;
    private static int F3b2624e9;
    private static int F6dd527d6;
    private static Dictionary<string, object> F95cdea0c;
    private static int Fed2d2a6b;
    private static Dictionary<string, object> Fed6b8be0;
    private static int Ff7597b3d;

    private static p073d64c2 M5953b2a2(CertificateFactory P0, DateTime P1, Uri P2)
    {
        // str: "ldap"
        // call: Dictionary<string, object>.get
        // call: WeakReference<object>.get
        // call: p073d64c2.getMatches
        // call: ICollection<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: X509CRL.getNextUpdate
        // call: DateTime.before
        // call: Uri.getScheme
        // call: string.equals
        // call: pdf789334.mc4b2f1ed
        // call: pdf789334.me2d0dd3a
        // call: p1df1fd2d.<init>
        // call: pdf789334$pe41fd6af.<init>
        // call: WeakReference<object>.<init>
        // call: Dictionary<string, object>.put
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pdf789334.f0fea6a13
        // type: pdf789334
        // type: pdf789334$pe41fd6af
        // type: p1df1fd2d
        // type: WeakReference<object>
        return default!;
    }

    private static ICollection<object> Mc4b2f1ed(CertificateFactory P0, Uri P1)
    {
        // str: "java.naming.factory.initial"
        // str: "issue connecting to: "
        // str: "no CRL returned from: "
        // str: ""
        // str: "certificateRevocationList;binary"
        // str: "java.naming.provider.url"
        // str: "0db5e2c1172c43ee1596442b223ff2d2a67a2d55bfedd92602187f8206f061bf41e53e18cf57b78715090a591b0564e40..."
        // call: StringBuilder.toString
        // call: CRLException.<init>
        // call: Dictionary<string, object>.put
        // call: StringBuilder.<init>
        // call: Uri.toString
        // call: Hashtable.<init>
        // call: CertificateFactory.generateCRLs
        // call: DecryptString.decryptString
        // call: MemoryStream.<init>
        // call: InitialDirContext.<init>
        // call: DirContext.getAttributes
        // call: Attributes.get
        // call: Attribute.get
        // call: StringBuilder.append
        // type: CRLException
        // type: Hashtable
        // type: StringBuilder
        // type: MemoryStream
        // type: InitialDirContext
        return default!;
    }

    private static ICollection<object> Me2d0dd3a(CertificateFactory P0, Uri P1)
    {
        // call: Uri.toURL
        // call: Stream.close
        // call: HttpClient.setConnectTimeout
        // call: HttpClient.getInputStream
        // call: Uri.openConnection
        // call: HttpClient.setReadTimeout
        // call: CertificateFactory.generateCRLs
        return default!;
    }

}
