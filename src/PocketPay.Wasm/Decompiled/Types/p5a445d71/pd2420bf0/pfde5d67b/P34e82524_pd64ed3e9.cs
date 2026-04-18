namespace WillowMaze.Wasm.Decompiled;

public class P34e82524_pd64ed3e9 : P34e82524$p095a1b43, Pc2cc7082$pd64ed3e9
{
    private static SSLSocketFactory F08086131;
    private static System.Text.RegularExpressions.Regex F080a0474;
    private static int F150f5288;
    private static System.Text.RegularExpressions.Regex F4acc413c;
    private static string F533ec1a6;
    private static SSLSocketFactory F65fd40e8;
    private static SSLSocketFactory F6b7bcfa2;
    private static int F6bf04358;
    private static string F71233d73;
    private static System.Text.RegularExpressions.Regex F7f1af831;
    private static System.Text.RegularExpressions.Regex Fb76ba830;
    private static System.Text.RegularExpressions.Regex Fd1afb269;
    private static int Fdbfa734b;
    private static int Fdd6ddf78;
    private static int Fe661cc8d;
    private int F0521ef4e;
    private int F0a94ae75;
    private pc2cc7082$p15c2d85f F0f74aa99;
    private byte[] F1ee9ae64;
    private bool F28dbde11;
    private string F38822701;
    private Stream F3e6c0de6;
    private string F3e6d605b;
    private bool F436418be;
    private string F4c1d8a24;
    private int F553f2cb5;
    private byte[] F69452cca;
    private string F7733264d;
    private pc2cc7082$p15c2d85f F818e9546;
    private Stream F9907167b;
    private string F9faaab34;
    private string Fa153823c;
    private pc2cc7082$p15c2d85f Fa194057d;
    private bool Fa5ee8e66;
    private bool Fa6a909b5;
    private pc2cc7082$p15c2d85f Fab4d0a65;
    private int Fb0f5820d;
    private byte[] Fbe52c27c;
    private pc2cc7082$p15c2d85f Fc45e92c7;
    private int Fd6c0027e;
    private string Fdabb6a8c;
    private string Fdbd15349;
    private bool Fdc6f7d39;
    private int Fdc81d852;
    private string Fdf5feafa;
    private string Fdfa3760a;
    private int Ff9a31c6b;
    private bool Ff9e646c5;

    private static Dictionary<string, object> M054b473f(HttpClient P0)
    {
        // call: List<object>.<init>
        // call: HttpClient.getHeaderField
        // call: Dictionary<string, object>.get
        // call: Dictionary<string, object>.containsKey
        // call: List<object>.add
        // call: Dictionary<string, object>.put
        // call: HttpClient.getHeaderFieldKey
        // call: Dictionary<string, object>.<init>
        // type: Dictionary<string, object>
        // type: List<object>
        return default!;
    }

    private static HttpClient M18701ebd(pc2cc7082$p15c2d85f P0)
    {
        // str: "Cookie"
        // call: IEnumerator<object>.next
        // call: pc2cc7082$p15c2d85f.cookies
        // call: pc2cc7082$p15c2d85f.multiHeaders
        // call: IEnumerator<object>.hasNext
        // call: pc2cc7082$p15c2d85f.proxy
        // call: pc2cc7082$p15c2d85f.timeout
        // call: pc2cc7082$p15c2d85f.sslSocketFactory
        // call: HttpClient.setReadTimeout
        // call: HttpsURLConnection.setSSLSocketFactory
        // call: pc2cc7082$p15c2d85f.url
        // call: HttpClient.addRequestProperty
        // call: HttpsURLConnection.setHostnameVerifier
        // call: Dictionary<string, object>.size
        // call: HashSet<object>.iterator
        // call: pc2cc7082$p4c3880bb.hasBody
        // call: pc2cc7082$p4c3880bb.name
        // call: Map$Entry.getValue
        // call: p34e82524$pd64ed3e9.m22509790
        // call: pc2cc7082$p15c2d85f.validateTLSCertificates
        // call: p34e82524$pd64ed3e9.m3934f41c
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f6b7bcfa2
        return default!;
    }

    private static HostnameVerifier M22509790()
    {
        // call: p34e82524$pd64ed3e9$1.<init>
        // type: p34e82524$pd64ed3e9$1
        return default!;
    }

    private static void M28d90eec(pc2cc7082$p15c2d85f P0, Stream P1, string P2)
    {
        // str: "Content-Disposition: form-data; name=\""
        // str: "\""
        // str: "\"\r\nContent-Type: "
        // str: "\r\n"
        // str: "--"
        // str: "\r\n\r\n"
        // str: "; filename=\""
        // str: "c7c6c7e1383f1e9fe1bb1aa855aa4b35158d21fb251ab4fad3058acffff7eb94b24ef3626ccae7ce4063191da88d5cb63..."
        // call: StreamWriter.write
        // call: pc2cc7082$p15c2d85f.postDataCharset
        // call: pc2cc7082$p15c2d85f.requestBody
        // call: StreamWriter.<init>
        // call: p34e82524.m5ec06fdf
        // call: pc2cc7082$pe1110b8b.key
        // call: pc2cc7082$pe1110b8b.contentType
        // call: p8f4da9a1.mbcaca301
        // call: ICollection<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: Stream.flush
        // call: IEnumerator<object>.next
        // call: StreamWriter.flush
        // call: pc2cc7082$p15c2d85f.data
        // call: pc2cc7082$pe1110b8b.value
        // call: DecryptString.decryptString
        // call: StreamWriter.append
        // call: pc2cc7082$pe1110b8b.inputStream
        // call: pc2cc7082$pe1110b8b.hasInputStream
        // call: URLEncoder.encode
        // type: StreamWriter
        // type: StreamWriter
    }

    private void M2a39071b(HttpClient P0, pc2cc7082$pd64ed3e9 P1)
    {
        // call: Map$Entry.getKey
        // call: HttpClient.getResponseCode
        // call: p34e82524$pd64ed3e9.cookie
        // call: pc2cc7082$p4c3880bb.valueOf
        // call: IEnumerator<object>.hasNext
        // call: HttpClient.getRequestMethod
        // call: pc2cc7082$pd64ed3e9.cookies
        // call: Dictionary<string, object>.entrySet
        // call: p34e82524$pd64ed3e9.hasCookie
        // call: p34e82524$pd64ed3e9.m054b473f
        // call: HttpClient.getResponseMessage
        // call: HttpClient.getContentType
        // call: HashSet<object>.iterator
        // call: p34e82524$pd64ed3e9.processResponseHeaders
        // call: IEnumerator<object>.next
        // call: HttpClient.getURL
        // call: Map$Entry.getValue
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fa153823c
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f572d4e42
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fea9f6aca
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fdf5feafa
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.ff9a31c6b
    }

    private static void M33a6f911()
    {
        // str: "SSL"
        // str: "Can't create unsecure trust manager"
        // call: p34e82524$pd64ed3e9$2.<init>
        // call: SSLContext.getInstance
        // call: System.Security.Cryptography.RandomNumberGenerator.<init>
        // call: SSLContext.init
        // call: SSLContext.getSocketFactory
        // call: IOException.<init>
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f6b7bcfa2
        // type: p34e82524$pd64ed3e9$2
        // type: System.Security.Cryptography.RandomNumberGenerator
        // type: IOException
        // type: p34e82524$pd64ed3e9
    }

    private static string M3934f41c(pc2cc7082$p15c2d85f P0)
    {
        // str: "; "
        // call: Map$Entry.getKey
        // call: StringBuilder.append
        // call: IEnumerator<object>.hasNext
        // call: HashSet<object>.iterator
        // call: IEnumerator<object>.next
        // call: p101ebc0f.m75031929
        // call: StringBuilder.toString
        // call: Map$Entry.getValue
        // call: pc2cc7082$p15c2d85f.cookies
        // call: Dictionary<string, object>.entrySet
        return string.Empty;
    }

    private void M3c6a0b54()
    {
        // str: "Request must be executed (with .execute(), .get(), or .post() before getting response body"
        // str: "Request has already been read (with .parse())"
        // call: p34e82524$pd64ed3e9.m75c18bad
        // call: pad3d06d0.mda0c5fd7
        // call: p7f7aeb05.<init>
        // call: pad3d06d0.m54001a1a
        // call: pc2cc7082$p15c2d85f.maxBodySize
        // call: p8f4da9a1.m33919f21
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fa6a909b5
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f69452cca
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f436418be
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f3e6c0de6
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fab4d0a65
        // type: p7f7aeb05
    }

    private void M75c18bad()
    {
        // call: Stream.close
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f3e6c0de6
    }

    private static string Mab9c4db3(pc2cc7082$p15c2d85f P0)
    {
        // str: "multipart/form-data; boundary="
        // str: "9bf74495bbc350272ea23c7cf3dd6be800b5285069f7342126ec24abea10fcd1e1b976dc2155e224"
        // str: "application/x-www-form-urlencoded; charset="
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pc2cc7082$p15c2d85f.header
        // call: StringBuilder.append
        // call: p8f4da9a1.m8067f055
        // call: p34e82524.m337ceba5
        // call: DecryptString.decryptString
        // call: pc2cc7082$p15c2d85f.postDataCharset
        // call: pc2cc7082$p15c2d85f.hasHeader
        // type: StringBuilder
        return string.Empty;
    }

    private static void Mae20745d(pc2cc7082$p15c2d85f P0)
    {
        // str: "://"
        // str: "ad7cf2353533b31017aafe265bfafd116446760bc56ca6c9b3ebfdf78e8044a523"
        // str: "InputStream data not supported in URL query string."
        // str: "?"
        // call: StringBuilder.append
        // call: ICollection<object>.iterator
        // call: ICollection<object>.clear
        // call: pc2cc7082$p15c2d85f.url
        // call: pc2cc7082$pe1110b8b.key
        // call: pc2cc7082$pe1110b8b.hasInputStream
        // call: pc2cc7082$pe1110b8b.value
        // call: Uri.getQuery
        // call: p101ebc0f.m75031929
        // call: DecryptString.decryptString
        // call: StringBuilder.toString
        // call: pad3d06d0.m54001a1a
        // call: Uri.getProtocol
        // call: IEnumerator<object>.hasNext
        // call: pc2cc7082$p15c2d85f.data
        // call: URLEncoder.encode
        // call: IEnumerator<object>.next
        // call: Uri.getAuthority
        // call: Uri.getPath
        // call: Uri.<init>
        // type: Uri
    }

    private static p34e82524$pd64ed3e9 Mec0cd3cb(pc2cc7082$p15c2d85f P0)
    {
        // call: p34e82524$pd64ed3e9.mec0cd3cb
        return default!;
    }

    private static p34e82524$pd64ed3e9 Mec0cd3cb(pc2cc7082$p15c2d85f P0, p34e82524$pd64ed3e9 P1)
    {
        // str: "ffa94bbf520156268365ab36263a8d2c7c554d57090a3225105d7b7c8916257d91878967545bf3cf7671cb19"
        // str: "HTTP error fetching URL"
        // str: "Request must not be null"
        // str: "Only http & https protocols supported"
        // str: "http"
        // str: "https"
        // str: "b8ad721287c6c66007f7cff6b7c36774fac494fdf9bda8e2aaf32ca213b1ef512353fb16"
        // str: "5ebd6e103b129ec8e12b1ba49f425c055c6069fc35489ef916b8d8da6391b15f47357926cca1ad01"
        // str: "http:/"
        // str: "text/"
        // str: "Unhandled content type. Must be text/*, application/xml, or application/xhtml+xml"
        // str: "gzip"
        // str: "deflate"
        // str: "Cannot set a request body for HTTP method "
        // call: System.nanoTime
        // call: MalformedURLException.<init>
        // call: string.equals
        // call: pc2cc7082$p15c2d85f.requestBody
        // call: HttpClient.disconnect
        // call: pc2cc7082$p4c3880bb.hasBody
        // call: p34e82524$pd64ed3e9.mab9c4db3
        // call: Uri.getProtocol
        // call: pc2cc7082$p15c2d85f.url
        // call: Uri.toString
        // call: pe2038545.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p34e82524$pd64ed3e9.mae20745d
        // call: pc2cc7082$p15c2d85f.data
        // call: pc2cc7082$p15c2d85f.method
        // call: p34e82524$pd64ed3e9.m18701ebd
        // call: HttpClient.connect
        // call: HttpClient.getDoOutput
        // call: HttpClient.getOutputStream
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fa6a909b5
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fab4d0a65
        // field: p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb.f7528035a
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f55e7dd30
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f080a0474
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fdf5feafa
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fdbd15349
        // field: p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb.fe15e216f
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f3e6c0de6
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f69452cca
        // type: pe2038545
        // type: MalformedURLException
        // type: p34e82524$pd64ed3e9
        // type: p73fdd8a2
        // type: GZIPInputStream
        // type: InflaterInputStream
        // type: Inflater
        // type: StringBuilder
        return default!;
    }

    public string Body()
    {
        // str: "b00b8876e78bcce14e486cbd3915196f5f18bbf5e11c47f885847054f9e06621dc"
        // call: p34e82524$pd64ed3e9.m3c6a0b54
        // call: DecryptString.decryptString
        // call: System.Text.Encoding.decode
        // call: CharBuffer.toString
        // call: System.Text.Encoding.forName
        // call: Buffer.rewind
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f69452cca
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fdbd15349
        return string.Empty;
    }

    public byte[] BodyAsBytes()
    {
        // call: byte[].array
        // call: p34e82524$pd64ed3e9.m3c6a0b54
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f69452cca
        return default!;
    }

    public BufferedInputStream BodyStream()
    {
        // str: "Request has already been read"
        // str: "Request must be executed (with .execute(), .get(), or .post() before getting response body"
        // call: pad3d06d0.m54001a1a
        // call: p4377c794.mccfc59a5
        // call: pad3d06d0.mda0c5fd7
        // call: pc2cc7082$p15c2d85f.maxBodySize
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fa6a909b5
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fab4d0a65
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f436418be
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f3e6c0de6
        return default!;
    }

    public pc2cc7082$pd64ed3e9 BufferUp()
    {
        // call: p34e82524$pd64ed3e9.m3c6a0b54
        return default!;
    }

    public string Charset()
    {
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fdbd15349
        return string.Empty;
    }

    public pc2cc7082$pd64ed3e9 Charset(string P0)
    {
        // call: p34e82524$pd64ed3e9.charset
        return default!;
    }

    public p34e82524$pd64ed3e9 Charset(string P0)
    {
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fdbd15349
        return default!;
    }

    public string ContentType()
    {
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fdf5feafa
        return string.Empty;
    }

    public string Cookie(string P0)
    {
        // call: p34e82524$p095a1b43.cookie
        return string.Empty;
    }

    public Dictionary<string, object> Cookies()
    {
        // call: p34e82524$p095a1b43.cookies
        return default!;
    }

    public bool HasCookie(string P0)
    {
        // call: p34e82524$p095a1b43.hasCookie
        return false;
    }

    public bool HasHeader(string P0)
    {
        // call: p34e82524$p095a1b43.hasHeader
        return false;
    }

    public bool HasHeaderWithValue(string P0, string P1)
    {
        // call: p34e82524$p095a1b43.hasHeaderWithValue
        return false;
    }

    public string Header(string P0)
    {
        // call: p34e82524$p095a1b43.header
        return string.Empty;
    }

    public List<object> Headers(string P0)
    {
        // call: p34e82524$p095a1b43.headers
        return default!;
    }

    public Dictionary<string, object> Headers()
    {
        // call: p34e82524$p095a1b43.headers
        return default!;
    }

    public pc2cc7082$p4c3880bb Method()
    {
        // call: p34e82524$p095a1b43.method
        return default!;
    }

    public Dictionary<string, object> MultiHeaders()
    {
        // call: p34e82524$p095a1b43.multiHeaders
        return default!;
    }

    public p09453598 Parse()
    {
        // str: "Input stream already read and parsed, cannot re-read."
        // str: "Request must be executed (with .execute(), .get(), or .post() before parsing response"
        // call: p8f4da9a1.m585bd234
        // call: p34e82524$pd64ed3e9.m75c18bad
        // call: pc2cc7082$p15c2d85f.parser
        // call: System.Text.Encoding.name
        // call: byte[].array
        // call: MemoryStream.<init>
        // call: p09453598$p98e1d1af.charset
        // call: Uri.toExternalForm
        // call: p09453598.outputSettings
        // call: pad3d06d0.mda0c5fd7
        // call: pad3d06d0.m54001a1a
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f69452cca
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f3e6c0de6
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f436418be
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fdbd15349
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fa6a909b5
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.f572d4e42
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fab4d0a65
        // type: MemoryStream
        return default!;
    }

    private void ProcessResponseHeaders(Dictionary<string, object> P0)
    {
        // str: "="
        // str: "Set-Cookie"
        // str: ";"
        // call: IEnumerator<object>.hasNext
        // call: Dictionary<string, object>.entrySet
        // call: HashSet<object>.iterator
        // call: pad99caab.<init>
        // call: p34e82524$pd64ed3e9.cookie
        // call: string.equalsIgnoreCase
        // call: List<object>.iterator
        // call: IEnumerator<object>.next
        // call: string.trim
        // call: pad99caab.chompTo
        // call: Map$Entry.getValue
        // call: Map$Entry.getKey
        // call: pad99caab.consumeTo
        // call: p34e82524$pd64ed3e9.addHeader
        // call: string.length
        // type: pad99caab
    }

    public int StatusCode()
    {
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.ff9a31c6b
        return 0;
    }

    public string StatusMessage()
    {
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.fa153823c
        return string.Empty;
    }

    public Uri Url()
    {
        // call: p34e82524$p095a1b43.url
        return default!;
    }

}
