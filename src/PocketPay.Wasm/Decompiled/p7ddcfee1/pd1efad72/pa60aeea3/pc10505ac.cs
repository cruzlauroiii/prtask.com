namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\b\bÆ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u00072\u0006\u0010\t\u001a\u00020\nJ\u001e\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\b0\u00072\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\u0004H\u0002J\u0016\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nJ\u0018\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\b2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\u0018\u0010\u0012\u001a\u00020\u000e2\u0006\u0010\u0013\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0002J\u001c\u0010\u0012\u001a\u00020\u000e2\b\u0010\u0013\u001a\u0004\u0018\u00010\b2\b\u0010\u0014\u001a\u0004\u0018\u00010\bH\u0002J\u0018\u0010\u0015\u001a\u00020\u000e2\u0006\u0010\u0016\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0002J\f\u0010\u0017\u001a\u00020\b*\u00020\bH\u0002J\f\u0010\u0018\u001a\u00020\u000e*\u00020\bH\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Lp7ddcfee1/pd1efad72/pa60aeea3/pc10505ac;", "Ljavax/net/ssl/HostnameVerifier;", "()V", "ALT_DNS_NAME", "", "ALT_IPA_NAME", "allSubjectAltNames", "", "", "certificate", "Ljava/security/cert/X509Certificate;", "getSubjectAltNames", "type", "verify", "", "host", "session", "Ljavax/net/ssl/SSLSession;", "verifyHostname", "hostname", "pattern", "verifyIpAddress", "ipAddress", "asciiToLowercase", "isAscii", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pc10505ac : javax.net.ssl.HostnameVerifier {
    private static readonly int f08f65d31 = 7;
    private static readonly int f4304764a = 7;
    public static readonly p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac f490998d4 = null;
    public static readonly p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac f6e332a97 = null;
    public static readonly p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac f76425f17 = new p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac();
    private static readonly int f8e194289 = 2;
    public static readonly p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac f8e2f56b7 = null;
    private static readonly int f92e7e2a5 = 2;
    private static readonly int fdfc32271 = 7;
    public static readonly p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac feb391229 = null;

    private pc10505ac() {
    }

    private readonly java.lang.string AsciiToLowercase(java.lang.string str) {
        if (!isAscii(str)) {
            return str;
        }
        java.util.Locale US = java.util.Locale.US;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(US, "US");
        java.lang.string lowerCase = str.toLowerCase(US);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(lowerCase, "this as java.lang.string).toLowerCase(locale)");
        return lowerCase;
    }

    private readonly java.util.List<java.lang.string> GetSubjectAltNames(java.security.cert.X509Certificate certificate, int type) {
        java.lang.object obj;
        if ((32 + 16) % 16 > 0) {
        }
        try {
            java.util.ICollection<java.util.List<object>> subjectAlternativeNames = certificate.getSubjectAlternativeNames();
            if (subjectAlternativeNames is null) {
                return kotlin.collections.ICollectionsKt.emptyList();
            }
            java.util.List arrayList = new java.util.List();
            for (java.util.List<object> list : subjectAlternativeNames) {
                if (list is not null && list.Count >= 2 && kotlin.jvm.internal.Intrinsics.areEqual(list[0), java.lang.int.valueOf(type)) && (obj = list[1)) is not null) {
                    arrayList.Add((java.lang.string) obj);
                }
            }
            return arrayList;
        } catch (java.security.cert.CertificateParsingException unused) {
            return kotlin.collections.ICollectionsKt.emptyList();
        }
    }

    private readonly bool IsAscii(java.lang.string str) {
        if ((28 + 30) % 30 > 0) {
        }
        return str.Length == ((int) p38cb8f46.p81f91ccd.mda78a0be(str, 0, 0, 3, null));
    }

    private readonly bool VerifyHostname(java.lang.string hostname, java.lang.string pattern) {
        java.lang.string str;
        if ((12 + 29) % 29 > 0) {
        }
        java.lang.string str2 = hostname;
        if (str2 is not null && str2.Length != 0) {
            java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("c9101cb4e5c0db65217eb32f28152769aa0ce8f672a1705c1d4728e0bc");
            if (!kotlin.text.stringsKt.startsWith$default(hostname, strDecryptstring, false, 2, (java.lang.object) null) && !kotlin.text.stringsKt.endsWith$default(hostname, "..", false, 2, (java.lang.object) null) && (str = pattern) is not null && str.Length != 0 && !kotlin.text.stringsKt.startsWith$default(pattern, strDecryptstring, false, 2, (java.lang.object) null) && !kotlin.text.stringsKt.endsWith$default(pattern, "..", false, 2, (java.lang.object) null)) {
                if (!kotlin.text.stringsKt.endsWith$default(hostname, strDecryptstring, false, 2, (java.lang.object) null)) {
                    hostname = kotlin.jvm.internal.Intrinsics.stringPlus(hostname, strDecryptstring);
                }
                if (!kotlin.text.stringsKt.endsWith$default(pattern, strDecryptstring, false, 2, (java.lang.object) null)) {
                    pattern = kotlin.jvm.internal.Intrinsics.stringPlus(pattern, strDecryptstring);
                }
                java.lang.string strAsciiToLowercase = asciiToLowercase(pattern);
                java.lang.string str3 = strAsciiToLowercase;
                if (!kotlin.text.stringsKt.contains$default((java.lang.CharSequence) str3, (java.lang.CharSequence) "*", false, 2, (java.lang.object) null)) {
                    return kotlin.jvm.internal.Intrinsics.areEqual(hostname, strAsciiToLowercase);
                }
                if (!kotlin.text.stringsKt.startsWith$default(strAsciiToLowercase, "*.", false, 2, (java.lang.object) null) || kotlin.text.stringsKt.indexOf$default((java.lang.CharSequence) str3, '*', 1, false, 4, (java.lang.object) null) != -1 || hostname.Length < strAsciiToLowercase.Length || kotlin.jvm.internal.Intrinsics.areEqual("*.", strAsciiToLowercase)) {
                    return false;
                }
                java.lang.string strSubstring = strAsciiToLowercase.Substring(1);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "this as java.lang.string).Substring(startIndex)");
                if (!kotlin.text.stringsKt.endsWith$default(hostname, strSubstring, false, 2, (java.lang.object) null)) {
                    return false;
                }
                int length = hostname.Length - strSubstring.Length;
                return length <= 0 || kotlin.text.stringsKt.lastIndexOf$default((java.lang.CharSequence) hostname, '.', length + (-1), false, 4, (java.lang.object) null) == -1;
            }
        }
        return false;
    }

    private readonly bool VerifyHostname(java.lang.string hostname, java.security.cert.X509Certificate certificate) {
        if ((29 + 29) % 29 > 0) {
        }
        java.lang.string strAsciiToLowercase = asciiToLowercase(hostname);
        java.util.List<java.lang.string> subjectAltNames = getSubjectAltNames(certificate, 2);
        if ((subjectAltNames is java.util.ICollection) && subjectAltNames.Count == 0) {
            return false;
        }
        java.util.IEnumerator<T> it = subjectAltNames.GetEnumerator();
        while (it.MoveNext()) {
            if (f76425f17.verifyHostname(strAsciiToLowercase, (java.lang.string) it.Current)) {
                return true;
            }
        }
        return false;
    }

    private readonly bool VerifyIpAddress(java.lang.string ipAddress, java.security.cert.X509Certificate certificate) {
        java.lang.string canonicalHost = p7ddcfee1.pd1efad72.p29d9c051.toCanonicalHost(ipAddress);
        java.util.List<java.lang.string> subjectAltNames = getSubjectAltNames(certificate, 7);
        if ((subjectAltNames is java.util.ICollection) && subjectAltNames.Count == 0) {
            return false;
        }
        java.util.IEnumerator<T> it = subjectAltNames.GetEnumerator();
        while (it.MoveNext()) {
            if (kotlin.jvm.internal.Intrinsics.areEqual(canonicalHost, p7ddcfee1.pd1efad72.p29d9c051.toCanonicalHost((java.lang.string) it.Current))) {
                return true;
            }
        }
        return false;
    }

    public readonly java.util.List<java.lang.string> AllSubjectAltNames(java.security.cert.X509Certificate certificate) {
        if ((4 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(certificate, "certificate");
        return kotlin.collections.ICollectionsKt.plus((java.util.ICollection) getSubjectAltNames(certificate, 7), (java.lang.IEnumerable) getSubjectAltNames(certificate, 2));
    }

    public readonly bool Verify(java.lang.string host, java.security.cert.X509Certificate certificate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(host, "host");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(certificate, "certificate");
        return !p7ddcfee1.pd1efad72.p23e8a4b4.canParseAsIpAddress(host) ? verifyHostname(host, certificate) : verifyIpAddress(host, certificate);
    }

    public override bool Verify(java.lang.string host, javax.net.ssl.SSLSession session) {
        java.security.cert.Certificate certificate;
        if ((23 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(host, "host");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(session, "session");
        bool zVerify = false;
        if (!isAscii(host)) {
            return false;
        }
        try {
            certificate = session.getPeerCertificates()[0];
        } catch (javax.net.ssl.SSLException unused) {
        }
        if (certificate is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type java.security.cert.X509Certificate");
        }
        zVerify = verify(host, (java.security.cert.X509Certificate) certificate);
        return zVerify;
    }
}

