namespace WillowMaze.Wasm.Decompiled;

public class P9ad3946d : CertPath
{
    private static List<object> F73db4cc8;
    private static List<object> F776eb91c;
    private static List<object> Fb39f0f14;
    private static List<object> Fdf08d74f;
    private readonly pb3b7fb02 F0688fa4c;
    private List<object> F357db581;
    private List<object> F3cc41d0f;
    private List<object> F5770eff0;
    private readonly pb3b7fb02 Ffde5d67b;

    private p301c7ed4 M327fd698(X509Certificate P0)
    {
        // str: "Exception while encoding certificate: "
        // call: Exception.toString
        // call: X509Certificate.getEncoded
        // call: pd1c2953c.<init>
        // call: pd1c2953c.readObject
        // call: StringBuilder.toString
        // call: CertificateEncodingException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // type: StringBuilder
        // type: CertificateEncodingException
        // type: pd1c2953c
        return default!;
    }

    private byte[] M4803ae89(p0fd1bdf1 P0)
    {
        // str: "Exception thrown: "
        // str: "c09f73c68b7bed4e23dd1de26c1863af6a538c0d0b5132e212e5f690ce7b68"
        // call: CertificateEncodingException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: p0fd1bdf1.toASN1Primitive
        // call: DecryptString.decryptString
        // call: p301c7ed4.getEncoded
        // type: CertificateEncodingException
        // type: StringBuilder
        return default!;
    }

    private List<object> M5a2c85f5(List<object> P0)
    {
        // call: List<object>.size
        // call: X509Certificate.getIssuerX500Principal
        // call: List<object>.get
        // call: X500Principal.equals
        // call: List<object>.<init>
        // call: X509Certificate.getSubjectX500Principal
        // call: List<object>.add
        // call: List<object>.remove
        // type: List<object>
        return default!;
    }

    public List<object> GetCertificates()
    {
        // call: Collections.unmodifiableList
        // call: List<object>.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p9ad3946d.f3cc41d0f
        // type: List<object>
        return default!;
    }

    public byte[] GetEncoded()
    {
        // call: IEnumerator<object>.next
        // call: p9ad3946d.getEncodings
        // call: IEnumerator<object>.hasNext
        // call: p9ad3946d.getEncoded
        return default!;
    }

    public byte[] GetEncoded(string P0)
    {
        // str: "can't encode certificate for PEM encoded path"
        // str: "unsupported encoding: "
        // str: "PEM"
        // str: "PkiPath"
        // str: "CERTIFICATE"
        // str: "PKCS7"
        // call: pd6ccb7fc.add
        // call: p8f99ab96.<init>
        // call: List<object>.get
        // call: StringBuilder.append
        // call: p32555e78.<init>
        // call: ListIterator.previous
        // call: CertificateEncodingException.<init>
        // call: ListIterator.hasPrevious
        // call: p9ad3946d.m4803ae89
        // call: MemoryStream.toByteArray
        // call: p9ad3946d.m327fd698
        // call: StringBuilder.toString
        // call: string.equalsIgnoreCase
        // call: p5fd96ef9.<init>
        // call: List<object>.size
        // call: X509Certificate.getEncoded
        // call: p00f5edd4.<init>
        // call: p5fd96ef9.writeObject
        // call: p5fd96ef9.close
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p9ad3946d.f3cc41d0f
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f5cc1048a
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f8d777f38
        // type: pd6ccb7fc
        // type: CertificateEncodingException
        // type: pf391b73d
        // type: p32555e78
        // type: StringBuilder
        // type: MemoryStream
        // type: p8f99ab96
        // type: p00f5edd4
        // type: pb840b7ef
        // type: p574943f4
        return default!;
    }

    public IEnumerator<object> GetEncodings()
    {
        // call: List<object>.iterator
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p9ad3946d.fb39f0f14
        return default!;
    }

}
