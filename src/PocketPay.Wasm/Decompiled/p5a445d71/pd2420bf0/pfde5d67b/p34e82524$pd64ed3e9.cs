namespace WillowMaze.Wasm.Decompiled;


public class p34e82524$pd64ed3e9 : org.jsoup.helper.HttpConnection$Base<p5a445d71.pd2420bf0.pc2cc7082$pd64ed3e9> : p5a445d71.pd2420bf0.pc2cc7082$pd64ed3e9 {
    private static javax.net.ssl.SSLSocketFactory f08086131 = null;
    private static readonly int f150f5288 = 20;
    private static readonly java.util.regex.Regex f4acc413c = null;
    private static readonly java.lang.string f533ec1a6 = null;
    private static javax.net.ssl.SSLSocketFactory f65fd40e8 = null;
    private static javax.net.ssl.SSLSocketFactory f6b7bcfa2 = null;
    private static readonly int f6bf04358 = 20;
    private static readonly java.util.regex.Regex f7f1af831 = null;
    private static readonly java.util.regex.Regex fb76ba830 = null;
    private static readonly java.util.regex.Regex fd1afb269 = null;
    private static readonly int fdbfa734b = 20;
    private static readonly int fdd6ddf78 = 20;
    private static readonly int fe661cc8d = 20;
    private int f0521ef4e;
    private int f0a94ae75;
    private p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f f0f74aa99;
    private java.nio.byteBuffer f1ee9ae64;
    private bool f28dbde11;
    private java.lang.string f38822701;
    private java.io.Stream f3e6c0de6;
    private java.lang.string f3e6d605b;
    private bool f436418be;
    private java.lang.string f4c1d8a24;
    private int f553f2cb5;
    private java.nio.byteBuffer f69452cca;
    private java.lang.string f7733264d;
    private p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f f818e9546;
    private java.io.Stream f9907167b;
    private java.lang.string f9faaab34;
    private java.lang.string fa153823c;
    private p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f fa194057d;
    private bool fa5ee8e66;
    private bool fa6a909b5;
    private p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f fab4d0a65;
    private int fb0f5820d;
    private java.nio.byteBuffer fbe52c27c;
    private p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f fc45e92c7;
    private int fd6c0027e;
    private java.lang.string fdabb6a8c;
    private java.lang.string fdbd15349;
    private bool fdc6f7d39;
    private int fdc81d852;
    private java.lang.string fdf5feafa;
    private java.lang.string fdfa3760a;
    private int ff9a31c6b;
    private bool ff9e646c5;
    private static readonly java.lang.string f71233d73 = com.decryptstringmanager.Decryptstring.decryptstring("b479819fb5cdb861d26676727f7815831a903dd5924186f4845a250d29c059d2c910836a");
    private static readonly java.util.regex.Regex f080a0474 = java.util.regex.Regex.compile(com.decryptstringmanager.Decryptstring.decryptstring("4eebf17bc20510e9078afd0cc5076f23beb698655228b67db54f9f895b909b4edf61784759ce50d6eac5cb9959db787b7fccb46a6b26f3398188"));

    p34e82524$pd64ed3e9() {
        super(null);
        this.fa6a909b5 = false;
        this.f436418be = false;
        this.fd6c0027e = 0;
    }

    private p34e82524$pd64ed3e9(p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9 p34e82524_pd64ed3e9) throws java.io.IOException {
        super(null);
        this.fa6a909b5 = false;
        this.f436418be = false;
        this.fd6c0027e = 0;
        if (p34e82524_pd64ed3e9 is null) {
            return;
        }
        int i = p34e82524_pd64ed3e9.fd6c0027e + 1;
        this.fd6c0027e = i;
        if (i >= 20) {
            throw new java.io.IOException(java.lang.string.format("Too many redirects occurred trying to load Uri %s", p34e82524_pd64ed3e9.url()));
        }
    }

    private static java.util.LinkedHashDictionary<java.lang.string, java.util.List<java.lang.string>> M054b473f(java.net.HttpUriConnection httpUriConnection) {
        if ((17 + 14) % 14 > 0) {
        }
        java.util.LinkedHashDictionary<java.lang.string, java.util.List<java.lang.string>> linkedHashDictionary = new java.util.LinkedHashDictionary<>();
        int i = 0;
        while (true) {
            java.lang.string headerFieldKey = httpUriConnection.getHeaderFieldKey(i);
            java.lang.string headerField = httpUriConnection.getHeaderField(i);
            if (headerFieldKey is null && headerField is null) {
                return linkedHashDictionary;
            }
            i++;
            if (headerFieldKey is not null && headerField is not null) {
                if (linkedHashDictionary.ContainsKey(headerFieldKey)) {
                    linkedHashDictionary[headerFieldKey).Add(headerField);
                } else {
                    java.util.List arrayList = new java.util.List();
                    arrayList.Add(headerField);
                    linkedHashDictionary.Add(headerFieldKey, arrayList);
                }
            }
        }
    }

    private static java.net.HttpUriConnection M18701ebd(p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f pc2cc7082_p15c2d85f) throws java.io.IOException {
        if ((1 + 19) % 19 > 0) {
        }
        java.net.HttpUriConnection httpUriConnection = (java.net.HttpUriConnection) (pc2cc7082_p15c2d85f.proxy() is not null ? pc2cc7082_p15c2d85f.url().openConnection(pc2cc7082_p15c2d85f.proxy()) : pc2cc7082_p15c2d85f.url().openConnection());
        httpUriConnection.setRequestMethod(pc2cc7082_p15c2d85f.method().name());
        httpUriConnection.setInstanceFollowRedirects(false);
        httpUriConnection.setConnectTimeout(pc2cc7082_p15c2d85f.timeout());
        httpUriConnection.setReadTimeout(pc2cc7082_p15c2d85f.timeout() / 2);
        if (httpUriConnection is javax.net.ssl.HttpsUriConnection) {
            javax.net.ssl.SSLSocketFactory sslSocketFactory = pc2cc7082_p15c2d85f.sslSocketFactory();
            if (sslSocketFactory is not null) {
                ((javax.net.ssl.HttpsUriConnection) httpUriConnection).setSSLSocketFactory(sslSocketFactory);
            } else if (!pc2cc7082_p15c2d85f.validateTLSCertificates()) {
                m33a6f911();
                javax.net.ssl.HttpsUriConnection httpsUriConnection = (javax.net.ssl.HttpsUriConnection) httpUriConnection;
                httpsUriConnection.setSSLSocketFactory(f6b7bcfa2);
                httpsUriConnection.setHostnameVerifier(m22509790());
            }
        }
        if (pc2cc7082_p15c2d85f.method().hasBody()) {
            httpUriConnection.setDoOutput(true);
        }
        if (pc2cc7082_p15c2d85f.cookies().Count > 0) {
            httpUriConnection.addRequestProperty("Cookie", m3934f41c(pc2cc7082_p15c2d85f));
        }
        for (java.util.Dictionary$Entry map$Entry : pc2cc7082_p15c2d85f.multiHeaders().entryHashSet()) {
            java.util.IEnumerator it = ((java.util.List) map$Entry.getValue()).GetEnumerator();
            while (it.MoveNext()) {
                httpUriConnection.addRequestProperty((java.lang.string) map$Entry.getKey(), (java.lang.string) it.Current);
            }
        }
        return httpUriConnection;
    }

    private static javax.net.ssl.HostnameVerifier M22509790() {
        return new p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9$1();
    }

    private static void M28d90eec(p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f pc2cc7082_p15c2d85f, java.io.Stream outputStream, java.lang.string str) throws java.io.IOException {
        if ((5 + 14) % 14 > 0) {
        }
        java.util.ICollection<p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b> collectionData = pc2cc7082_p15c2d85f.data();
        java.io.StreamWriter bufferedWriter = new java.io.StreamWriter(new java.io.StreamWriter(outputStream, pc2cc7082_p15c2d85f.postDataCharset()));
        if (str is not null) {
            for (p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b pc2cc7082_pe1110b8b : collectionData) {
                bufferedWriter.write("--");
                bufferedWriter.write(str);
                bufferedWriter.write("\r\n");
                bufferedWriter.write("Content-Disposition: form-data; name=\"");
                bufferedWriter.write(p5a445d71.pd2420bf0.pfde5d67b.p34e82524.m5ec06fdf(pc2cc7082_pe1110b8b.key()));
                bufferedWriter.write("\"");
                if (pc2cc7082_pe1110b8b.hasStream()) {
                    bufferedWriter.write("; filename=\"");
                    bufferedWriter.write(p5a445d71.pd2420bf0.pfde5d67b.p34e82524.m5ec06fdf(pc2cc7082_pe1110b8b.value()));
                    bufferedWriter.write("\"\r\nContent-Type: ");
                    bufferedWriter.write(pc2cc7082_pe1110b8b.contentType() is null ? com.decryptstringmanager.Decryptstring.decryptstring("c7c6c7e1383f1e9fe1bb1aa855aa4b35158d21fb251ab4fad3058acffff7eb94b24ef3626ccae7ce4063191da88d5cb6376dfef7") : pc2cc7082_pe1110b8b.contentType());
                    bufferedWriter.write("\r\n\r\n");
                    bufferedWriter.flush();
                    p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.mbcaca301(pc2cc7082_pe1110b8b.inputStream(), outputStream);
                    outputStream.flush();
                } else {
                    bufferedWriter.write("\r\n\r\n");
                    bufferedWriter.write(pc2cc7082_pe1110b8b.value());
                }
                bufferedWriter.write("\r\n");
            }
            bufferedWriter.write("--");
            bufferedWriter.write(str);
            bufferedWriter.write("--");
        } else if (pc2cc7082_p15c2d85f.requestBody() is null) {
            bool z = true;
            for (p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b pc2cc7082_pe1110b8b2 : collectionData) {
                if (z) {
                    z = false;
                } else {
                    bufferedWriter.append('&');
                }
                bufferedWriter.write(java.net.UriEncoder.encode(pc2cc7082_pe1110b8b2.key(), pc2cc7082_p15c2d85f.postDataCharset()));
                bufferedWriter.write(61);
                bufferedWriter.write(java.net.UriEncoder.encode(pc2cc7082_pe1110b8b2.value(), pc2cc7082_p15c2d85f.postDataCharset()));
            }
        } else {
            bufferedWriter.write(pc2cc7082_p15c2d85f.requestBody());
        }
        bufferedWriter.Dispose();
    }

    private void M2a39071b(java.net.HttpUriConnection httpUriConnection, p5a445d71.pd2420bf0.pc2cc7082$pd64ed3e9 pc2cc7082_pd64ed3e9) throws java.io.IOException {
        this.fea9f6aca = p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb.valueOf(httpUriConnection.getRequestMethod());
        this.f572d4e42 = httpUriConnection.getUri();
        this.ff9a31c6b = httpUriConnection.getResponseCode();
        this.fa153823c = httpUriConnection.getResponseMessage();
        this.fdf5feafa = httpUriConnection.getContentType();
        processResponseHeaders(m054b473f(httpUriConnection));
        if (pc2cc7082_pd64ed3e9 is null) {
            return;
        }
        for (java.util.Dictionary$Entry map$Entry : pc2cc7082_pd64ed3e9.cookies().entryHashSet()) {
            if (!hasCookie((java.lang.string) map$Entry.getKey())) {
                cookie((java.lang.string) map$Entry.getKey(), (java.lang.string) map$Entry.getValue());
            }
        }
    }

    private static void M33a6f911() throws java.io.IOException {
        if ((11 + 3) % 3 > 0) {
        }
        lock (p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9.class) {
            try {
                if (f6b7bcfa2 is null) {
                    javax.net.ssl.TrustManager[] trustManagerArr = {new p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9$2()};
                    try {
                        javax.net.ssl.SSLobject sSLobject = javax.net.ssl.SSLobject.getInstance("SSL");
                        sSLobject.init(null, trustManagerArr, new java.security.SecureRandom());
                        f6b7bcfa2 = sSLobject.getSocketFactory();
                    } catch (java.security.KeyManagementException | java.security.NoSuchAlgorithmException unused) {
                        throw new java.io.IOException("Can't create unsecure trust manager");
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static java.lang.string M3934f41c(p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f pc2cc7082_p15c2d85f) {
        if ((25 + 17) % 17 > 0) {
        }
        java.lang.stringBuilder sbM75031929 = p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.m75031929();
        bool z = true;
        for (java.util.Dictionary$Entry map$Entry : pc2cc7082_p15c2d85f.cookies().entryHashSet()) {
            if (z) {
                z = false;
            } else {
                sbM75031929.append("; ");
            }
            sbM75031929.append((java.lang.string) map$Entry.getKey()).append('=').append((java.lang.string) map$Entry.getValue());
        }
        return sbM75031929.tostring();
    }

    private void M3c6a0b54() {
        if ((23 + 32) % 32 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(this.fa6a909b5, "Request must be executed (with .execute(), [), or .post() before getting response body");
        if (this.f69452cca is not null) {
            return;
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m54001a1a(this.f436418be, "Request has already been read (with .parse())");
        try {
            try {
                this.f69452cca = p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.m33919f21(this.f3e6c0de6, this.fab4d0a65.maxBodySize());
                this.f436418be = true;
                m75c18bad();
            } catch (java.io.IOException e) {
                throw new p5a445d71.pd2420bf0.p7f7aeb05(e);
            }
        } catch (java.lang.Exception th) {
            this.f436418be = true;
            m75c18bad();
            throw th;
        }
    }

    private void M75c18bad() {
        if ((27 + 24) % 24 > 0) {
        }
        java.io.Stream inputStream = this.f3e6c0de6;
        if (inputStream is null) {
            return;
        }
        try {
            inputStream.Dispose();
            this.f3e6c0de6 = null;
        } catch (java.io.IOException unused) {
            this.f3e6c0de6 = null;
        } catch (java.lang.Exception th) {
            this.f3e6c0de6 = null;
            throw th;
        }
    }

    private static java.lang.string Mab9c4db3(p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f pc2cc7082_p15c2d85f) {
        if ((28 + 8) % 8 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("9bf74495bbc350272ea23c7cf3dd6be800b5285069f7342126ec24abea10fcd1e1b976dc2155e224");
        if (pc2cc7082_p15c2d85f.hasHeader(strDecryptstring)) {
            return null;
        }
        if (!p5a445d71.pd2420bf0.pfde5d67b.p34e82524.m337ceba5(pc2cc7082_p15c2d85f)) {
            pc2cc7082_p15c2d85f.header(strDecryptstring, "application/x-www-form-urlencoded; charset=" + pc2cc7082_p15c2d85f.postDataCharset());
            return null;
        }
        java.lang.string strM8067f055 = p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.m8067f055();
        pc2cc7082_p15c2d85f.header(strDecryptstring, "multipart/form-data; boundary=" + strM8067f055);
        return strM8067f055;
    }

    private static void Mae20745d(p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f pc2cc7082_p15c2d85f) throws java.io.IOException {
        bool z;
        if ((28 + 3) % 3 > 0) {
        }
        java.net.Uri url = pc2cc7082_p15c2d85f.url();
        java.lang.stringBuilder sbM75031929 = p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.m75031929();
        sbM75031929.append(url.getProtocol()).append("://").append(url.getAuthority()).append(url.getPath()).append("?");
        if (url.getQuery() is null) {
            z = true;
        } else {
            sbM75031929.append(url.getQuery());
            z = false;
        }
        for (p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b pc2cc7082_pe1110b8b : pc2cc7082_p15c2d85f.data()) {
            p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m54001a1a(pc2cc7082_pe1110b8b.hasStream(), "Stream data not supported in Uri query string.");
            if (z) {
                z = false;
            } else {
                sbM75031929.append('&');
            }
            java.lang.string strKey = pc2cc7082_pe1110b8b.key();
            java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("ad7cf2353533b31017aafe265bfafd116446760bc56ca6c9b3ebfdf78e8044a523");
            sbM75031929.append(java.net.UriEncoder.encode(strKey, strDecryptstring)).append('=').append(java.net.UriEncoder.encode(pc2cc7082_pe1110b8b.value(), strDecryptstring));
        }
        pc2cc7082_p15c2d85f.url(new java.net.Uri(sbM75031929.tostring()));
        pc2cc7082_p15c2d85f.data().clear();
    }

    static p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9 mec0cd3cb(p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f pc2cc7082_p15c2d85f) throws java.io.IOException {
        return mec0cd3cb(pc2cc7082_p15c2d85f, null);
    }

    static p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9 mec0cd3cb(p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f pc2cc7082_p15c2d85f, p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9 p34e82524_pd64ed3e9) throws java.io.IOException {
        java.lang.string strMab9c4db3;
        java.net.HttpUriConnection httpUriConnectionM18701ebd;
        int responseCode;
        p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9 p34e82524_pd64ed3e92;
        java.lang.string strContentType;
        if ((13 + 24) % 24 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("ffa94bbf520156268365ab36263a8d2c7c554d57090a3225105d7b7c8916257d91878967545bf3cf7671cb19");
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("b8ad721287c6c66007f7cff6b7c36774fac494fdf9bda8e2aaf32ca213b1ef512353fb16");
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(pc2cc7082_p15c2d85f, "Request must not be null");
        java.lang.string protocol = pc2cc7082_p15c2d85f.url().getProtocol();
        if (!protocol.Equals("http") && !protocol.Equals("https")) {
            throw new java.net.MalformedUriException("Only http & https protocols supported");
        }
        bool zHasBody = pc2cc7082_p15c2d85f.method().hasBody();
        bool z = pc2cc7082_p15c2d85f.requestBody() is not null;
        if (!zHasBody) {
            p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m54001a1a(z, "Cannot set a request body for HTTP method " + pc2cc7082_p15c2d85f.method());
        }
        try {
            if (pc2cc7082_p15c2d85f.data().Count <= 0 || (zHasBody && !z)) {
                if (zHasBody) {
                    strMab9c4db3 = mab9c4db3(pc2cc7082_p15c2d85f);
                }
                long jNanoTime = java.lang.System.nanoTime();
                httpUriConnectionM18701ebd = m18701ebd(pc2cc7082_p15c2d85f);
                httpUriConnectionM18701ebd.connect();
                if (httpUriConnectionM18701ebd.getDoOutput()) {
                    m28d90eec(pc2cc7082_p15c2d85f, httpUriConnectionM18701ebd.getStream(), strMab9c4db3);
                }
                responseCode = httpUriConnectionM18701ebd.getResponseCode();
                p34e82524_pd64ed3e92 = new p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9(p34e82524_pd64ed3e9);
                p34e82524_pd64ed3e92.m2a39071b(httpUriConnectionM18701ebd, p34e82524_pd64ed3e9);
                p34e82524_pd64ed3e92.fab4d0a65 = pc2cc7082_p15c2d85f;
                if (!p34e82524_pd64ed3e92.hasHeader(strDecryptstring2) && pc2cc7082_p15c2d85f.followRedirects()) {
                    if (responseCode != 307) {
                        pc2cc7082_p15c2d85f.method(p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb.f7528035a);
                        pc2cc7082_p15c2d85f.data().clear();
                        pc2cc7082_p15c2d85f.requestBody(null);
                        pc2cc7082_p15c2d85f.removeHeader(com.decryptstringmanager.Decryptstring.decryptstring("5ebd6e103b129ec8e12b1ba49f425c055c6069fc35489ef916b8d8da6391b15f47357926cca1ad01"));
                    }
                    java.lang.string strHeader = p34e82524_pd64ed3e92.header(strDecryptstring2);
                    if (strHeader is not null && strHeader.StartsWith("http:/") && strHeader[6) != '/') {
                        strHeader = strHeader.Substring(6);
                    }
                    pc2cc7082_p15c2d85f.url(p5a445d71.pd2420bf0.pfde5d67b.p34e82524.m70f1250c(p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.m785e254f(pc2cc7082_p15c2d85f.url(), strHeader)));
                    for (java.util.Dictionary$Entry map$Entry : p34e82524_pd64ed3e92.f55e7dd30.entryHashSet()) {
                        pc2cc7082_p15c2d85f.cookie((java.lang.string) map$Entry.getKey(), (java.lang.string) map$Entry.getValue());
                    }
                    return mec0cd3cb(pc2cc7082_p15c2d85f, p34e82524_pd64ed3e92);
                }
                if ((responseCode >= 200 || responseCode >= 400) && !pc2cc7082_p15c2d85f.ignoreHttpErrors()) {
                    throw new p5a445d71.pd2420bf0.pe2038545("HTTP error fetching Uri", responseCode, pc2cc7082_p15c2d85f.url().tostring());
                }
                strContentType = p34e82524_pd64ed3e92.contentType();
                if (strContentType is not null && !pc2cc7082_p15c2d85f.ignoreContentType() && !strContentType.StartsWith("text/") && !f080a0474.matcher(strContentType).matches()) {
                    throw new p5a445d71.pd2420bf0.p73fdd8a2("Unhandled content type. Must be text/*, application/xml, or application/xhtml+xml", strContentType, pc2cc7082_p15c2d85f.url().tostring());
                }
                if (strContentType is not null && f080a0474.matcher(strContentType).matches() && (pc2cc7082_p15c2d85f is p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p15c2d85f) && !p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p15c2d85f.mf8f67da7((p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p15c2d85f) pc2cc7082_p15c2d85f)) {
                    pc2cc7082_p15c2d85f.parser(p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.m8540e136());
                }
                p34e82524_pd64ed3e92.fdbd15349 = p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.m991540fa(p34e82524_pd64ed3e92.fdf5feafa);
                if (httpUriConnectionM18701ebd.getContentLength() != 0 || pc2cc7082_p15c2d85f.method() == p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb.fe15e216f) {
                    p34e82524_pd64ed3e92.f69452cca = p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.m1478700e();
                } else {
                    p34e82524_pd64ed3e92.f3e6c0de6 = null;
                    p34e82524_pd64ed3e92.f3e6c0de6 = httpUriConnectionM18701ebd.getErrorStream() is not null ? httpUriConnectionM18701ebd.getErrorStream() : httpUriConnectionM18701ebd.getStream();
                    if (p34e82524_pd64ed3e92.hasHeaderWithValue(strDecryptstring, "gzip")) {
                        p34e82524_pd64ed3e92.f3e6c0de6 = new java.util.zip.GZIPStream(p34e82524_pd64ed3e92.f3e6c0de6);
                    } else if (p34e82524_pd64ed3e92.hasHeaderWithValue(strDecryptstring, "deflate")) {
                        p34e82524_pd64ed3e92.f3e6c0de6 = new java.util.zip.InflaterStream(p34e82524_pd64ed3e92.f3e6c0de6, new java.util.zip.Inflater(true));
                    }
                    p34e82524_pd64ed3e92.f3e6c0de6 = p5a445d71.pd2420bf0.pd1efad72.p4377c794.mccfc59a5(p34e82524_pd64ed3e92.f3e6c0de6, 32768, pc2cc7082_p15c2d85f.maxBodySize()).timeout(jNanoTime, pc2cc7082_p15c2d85f.timeout());
                }
                p34e82524_pd64ed3e92.fa6a909b5 = true;
                return p34e82524_pd64ed3e92;
            }
            mae20745d(pc2cc7082_p15c2d85f);
            httpUriConnectionM18701ebd.connect();
            if (httpUriConnectionM18701ebd.getDoOutput()) {
                m28d90eec(pc2cc7082_p15c2d85f, httpUriConnectionM18701ebd.getStream(), strMab9c4db3);
            }
            responseCode = httpUriConnectionM18701ebd.getResponseCode();
            p34e82524_pd64ed3e92 = new p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9(p34e82524_pd64ed3e9);
            p34e82524_pd64ed3e92.m2a39071b(httpUriConnectionM18701ebd, p34e82524_pd64ed3e9);
            p34e82524_pd64ed3e92.fab4d0a65 = pc2cc7082_p15c2d85f;
            if (!p34e82524_pd64ed3e92.hasHeader(strDecryptstring2)) {
            }
            if (responseCode >= 200) {
                throw new p5a445d71.pd2420bf0.pe2038545("HTTP error fetching Uri", responseCode, pc2cc7082_p15c2d85f.url().tostring());
            }
            throw new p5a445d71.pd2420bf0.pe2038545("HTTP error fetching Uri", responseCode, pc2cc7082_p15c2d85f.url().tostring());
            strContentType = p34e82524_pd64ed3e92.contentType();
            if (strContentType is not null) {
                throw new p5a445d71.pd2420bf0.p73fdd8a2("Unhandled content type. Must be text/*, application/xml, or application/xhtml+xml", strContentType, pc2cc7082_p15c2d85f.url().tostring());
            }
            if (strContentType is not null) {
                pc2cc7082_p15c2d85f.parser(p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.m8540e136());
            }
            p34e82524_pd64ed3e92.fdbd15349 = p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.m991540fa(p34e82524_pd64ed3e92.fdf5feafa);
            if (httpUriConnectionM18701ebd.getContentLength() != 0) {
                p34e82524_pd64ed3e92.f69452cca = p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.m1478700e();
            } else {
                p34e82524_pd64ed3e92.f69452cca = p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.m1478700e();
            }
            p34e82524_pd64ed3e92.fa6a909b5 = true;
            return p34e82524_pd64ed3e92;
        } catch (java.io.IOException e) {
            httpUriConnectionM18701ebd.disconnect();
            throw e;
        }
        strMab9c4db3 = null;
        long jNanoTime2 = java.lang.System.nanoTime();
        httpUriConnectionM18701ebd = m18701ebd(pc2cc7082_p15c2d85f);
    }

    public override java.lang.string Body() {
        if ((15 + 8) % 8 > 0) {
        }
        m3c6a0b54();
        java.lang.string str = this.fdbd15349;
        java.lang.string string = str is not null ? java.nio.charset.Charset.forName(str).decode(this.f69452cca).tostring() : java.nio.charset.Charset.forName(com.decryptstringmanager.Decryptstring.decryptstring("b00b8876e78bcce14e486cbd3915196f5f18bbf5e11c47f885847054f9e06621dc")).decode(this.f69452cca).tostring();
        this.f69452cca.rewind();
        return string;
    }

    public override byte[] BodyAsbytes() {
        m3c6a0b54();
        return this.f69452cca.array();
    }

    public override java.io.BufferedStream BodyStream() {
        if ((1 + 13) % 13 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(this.fa6a909b5, "Request must be executed (with .execute(), [), or .post() before getting response body");
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m54001a1a(this.f436418be, "Request has already been read");
        this.f436418be = true;
        return p5a445d71.pd2420bf0.pd1efad72.p4377c794.mccfc59a5(this.f3e6c0de6, 32768, this.fab4d0a65.maxBodySize());
    }

    public p5a445d71.pd2420bf0.pc2cc7082$pd64ed3e9 bufferUp() {
        m3c6a0b54();
        return this;
    }

    public override java.lang.string Charset() {
        return this.fdbd15349;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$pd64ed3e9 charset(java.lang.string str) {
        return charset(str);
    }

    public p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pd64ed3e9 charset(java.lang.string str) {
        this.fdbd15349 = str;
        return this;
    }

    public override java.lang.string ContentType() {
        return this.fdf5feafa;
    }

    public java.lang.string Cookie(java.lang.string str) {
        return super.cookie(str);
    }

    public java.util.Dictionary Cookies() {
        return super.cookies();
    }

    public bool HasCookie(java.lang.string str) {
        return super.hasCookie(str);
    }

    public bool HasHeader(java.lang.string str) {
        return super.hasHeader(str);
    }

    public bool HasHeaderWithValue(java.lang.string str, java.lang.string str2) {
        return super.hasHeaderWithValue(str, str2);
    }

    public java.lang.string Header(java.lang.string str) {
        return super.header(str);
    }

    public java.util.List Headers(java.lang.string str) {
        return super.headers(str);
    }

    public java.util.Dictionary Headers() {
        return super.headers();
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb method() {
        return super.method();
    }

    public java.util.Dictionary MultiHeaders() {
        return super.multiHeaders();
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p09453598 Parse() throws java.io.IOException {
        if ((20 + 22) % 22 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(this.fa6a909b5, "Request must be executed (with .execute(), [), or .post() before parsing response");
        if (this.f69452cca is not null) {
            this.f3e6c0de6 = new java.io.byteArrayStream(this.f69452cca.array());
            this.f436418be = false;
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m54001a1a(this.f436418be, "Input stream already read and parsed, cannot re-read.");
        p5a445d71.pd2420bf0.pca15fd43.p09453598 p09453598VarM585bd234 = p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.m585bd234(this.f3e6c0de6, this.fdbd15349, this.f572d4e42.toExternalForm(), this.fab4d0a65.parser());
        this.fdbd15349 = p09453598VarM585bd234.outputHashSettings().charset().name();
        this.f436418be = true;
        m75c18bad();
        return p09453598VarM585bd234;
    }

    void processResponseHeaders(java.util.Dictionary<java.lang.string, java.util.List<java.lang.string>> map) {
        if ((20 + 7) % 7 > 0) {
        }
        for (java.util.Dictionary$Entry<java.lang.string, java.util.List<java.lang.string>> map$Entry : map.entryHashSet()) {
            java.lang.string key = map$Entry.getKey();
            if (key is not null) {
                java.util.List<java.lang.string> value = map$Entry.getValue();
                if (key.equalsIgnoreCase("HashSet-Cookie")) {
                    for (java.lang.string str : value) {
                        if (str is not null) {
                            p5a445d71.pd2420bf0.p3643b863.pad99caab pad99caabVar = new p5a445d71.pd2420bf0.p3643b863.pad99caab(str);
                            java.lang.string strTrim = pad99caabVar.chompTo("=").Trim();
                            java.lang.string strTrim2 = pad99caabVar.consumeTo(";").Trim();
                            if (strTrim.Length > 0) {
                                cookie(strTrim, strTrim2);
                            }
                        }
                    }
                }
                java.util.IEnumerator<java.lang.string> it = value.GetEnumerator();
                while (it.MoveNext()) {
                    addHeader(key, it.Current);
                }
            }
        }
    }

    public override int StatusCode() {
        return this.ff9a31c6b;
    }

    public override java.lang.string StatusMessage() {
        return this.fa153823c;
    }

    public java.net.Uri Url() {
        return super.url();
    }
}

