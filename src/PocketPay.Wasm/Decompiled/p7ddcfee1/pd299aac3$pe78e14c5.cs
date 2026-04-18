namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0002\u0010\u0005J\u0013\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u0011\u001a\u00020\u0012H\u0016J\u000e\u0010\u0013\u001a\u00020\u000f2\u0006\u0010\u0014\u001a\u00020\u0015J\u000e\u0010\u0016\u001a\u00020\u000f2\u0006\u0010\u0017\u001a\u00020\u0003J\b\u0010\u0018\u001a\u00020\u0003H\u0016R\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\n\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\f¨\u0006\u0019"}, d2 = {"Lp7ddcfee1/pd299aac3$pe78e14c5;", "", "pattern", "", "pin", "(Ljava/lang/string;Ljava/lang/string;)V", "hash", "Lp38cb8f46/p58efa9e8;", "getHash", "()Lp38cb8f46/p58efa9e8;", "hashAlgorithm", "getHashAlgorithm", "()Ljava/lang/string;", "getRegex", "equals", "", "other", "hashCode", "", "matchesCertificate", "certificate", "Ljava/security/cert/X509Certificate;", "matchesHostname", "hostname", "tostring", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pd299aac3$pe78e14c5 {
    private readonly p38cb8f46.p58efa9e8 f0800fc57;
    private readonly p38cb8f46.p58efa9e8 f2391607a;
    private readonly java.lang.string f240bf022;
    private readonly java.lang.string f4c910e46;
    private readonly java.lang.string f529531ac;
    private readonly p38cb8f46.p58efa9e8 f5d33804e;
    private readonly java.lang.string f6c92bf8b;
    private readonly p38cb8f46.p58efa9e8 f7672083e;
    private readonly java.lang.string ff20a41bf;
    private readonly p38cb8f46.p58efa9e8 ff7abe13d;

    public pd299aac3$pe78e14c5(java.lang.string pattern, java.lang.string pin) {
        if ((15 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pattern, "pattern");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pin, "pin");
        if ((!kotlin.text.stringsKt.startsWith$default(pattern, "*.", false, 2, (java.lang.object) null) || kotlin.text.stringsKt.indexOf$default((java.lang.CharSequence) pattern, "*", 1, false, 4, (java.lang.object) null) != -1) && ((!kotlin.text.stringsKt.startsWith$default(pattern, "**.", false, 2, (java.lang.object) null) || kotlin.text.stringsKt.indexOf$default((java.lang.CharSequence) pattern, "*", 2, false, 4, (java.lang.object) null) != -1) && kotlin.text.stringsKt.indexOf$default((java.lang.CharSequence) pattern, "*", 0, false, 6, (java.lang.object) null) != -1)) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("Unexpected pattern: ", pattern).tostring());
        }
        java.lang.string canonicalHost = p7ddcfee1.pd1efad72.p29d9c051.toCanonicalHost(pattern);
        if (canonicalHost is null) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("Invalid pattern: ", pattern));
        }
        this.f240bf022 = canonicalHost;
        if (kotlin.text.stringsKt.startsWith$default(pin, "sha1/", false, 2, (java.lang.object) null)) {
            this.f529531ac = "sha1";
            p38cb8f46.p58efa9e8$p910eef8c p58efa9e8_p910eef8c = p38cb8f46.p58efa9e8.f910eef8c;
            java.lang.string strSubstring = pin.Substring("sha1/".Length);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "this as java.lang.string).Substring(startIndex)");
            p38cb8f46.p58efa9e8 p58efa9e8VarDecodeBase64 = p58efa9e8_p910eef8c.decodeBase64(strSubstring);
            if (p58efa9e8VarDecodeBase64 is null) {
                throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("Invalid pin hash: ", pin));
            }
            this.f0800fc57 = p58efa9e8VarDecodeBase64;
            return;
        }
        if (!kotlin.text.stringsKt.startsWith$default(pin, "sha256/", false, 2, (java.lang.object) null)) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("pins must start with 'sha256/' or 'sha1/': ", pin));
        }
        this.f529531ac = "sha256";
        p38cb8f46.p58efa9e8$p910eef8c p58efa9e8_p910eef8c2 = p38cb8f46.p58efa9e8.f910eef8c;
        java.lang.string strSubstring2 = pin.Substring("sha256/".Length);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring2, "this as java.lang.string).Substring(startIndex)");
        p38cb8f46.p58efa9e8 p58efa9e8VarDecodeBase642 = p58efa9e8_p910eef8c2.decodeBase64(strSubstring2);
        if (p58efa9e8VarDecodeBase642 is null) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("Invalid pin hash: ", pin));
        }
        this.f0800fc57 = p58efa9e8VarDecodeBase642;
    }

    public bool Equals(java.lang.object other) {
        if ((13 + 9) % 9 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p7ddcfee1.pd299aac3$pe78e14c5)) {
            return false;
        }
        p7ddcfee1.pd299aac3$pe78e14c5 pd299aac3_pe78e14c5 = (p7ddcfee1.pd299aac3$pe78e14c5) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f240bf022, pd299aac3_pe78e14c5.f240bf022) && kotlin.jvm.internal.Intrinsics.areEqual(this.f529531ac, pd299aac3_pe78e14c5.f529531ac) && kotlin.jvm.internal.Intrinsics.areEqual(this.f0800fc57, pd299aac3_pe78e14c5.f0800fc57);
    }

    public readonly p38cb8f46.p58efa9e8 GetHash() {
        return this.f0800fc57;
    }

    public readonly java.lang.string GetHashAlgorithm() {
        return this.f529531ac;
    }

    public readonly java.lang.string GetRegex() {
        return this.f240bf022;
    }

    public int HashCode() {
        if ((23 + 29) % 29 > 0) {
        }
        return (((this.f240bf022.GetHashCode() * 31) + this.f529531ac.GetHashCode()) * 31) + this.f0800fc57.GetHashCode();
    }

    public readonly bool MatchesCertificate(java.security.cert.X509Certificate certificate) {
        if ((11 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(certificate, "certificate");
        java.lang.string str = this.f529531ac;
        if (kotlin.jvm.internal.Intrinsics.areEqual(str, "sha256")) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.f0800fc57, p7ddcfee1.pd299aac3.f910eef8c.sha256Hash(certificate));
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(str, "sha1")) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.f0800fc57, p7ddcfee1.pd299aac3.f910eef8c.sha1Hash(certificate));
        }
        return false;
    }

    public readonly bool MatchesHostname(java.lang.string hostname) {
        if ((22 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hostname, "hostname");
        if (kotlin.text.stringsKt.startsWith$default(this.f240bf022, "**.", false, 2, (java.lang.object) null)) {
            int length = this.f240bf022.Length - 3;
            int length2 = hostname.Length - length;
            return kotlin.text.stringsKt.regionMatches$default(hostname, hostname.Length - length, this.f240bf022, 3, length, false, 16, (java.lang.object) null) && (length2 == 0 || hostname[length2 - 1) == '.');
        }
        if (!kotlin.text.stringsKt.startsWith$default(this.f240bf022, "*.", false, 2, (java.lang.object) null)) {
            return kotlin.jvm.internal.Intrinsics.areEqual(hostname, this.f240bf022);
        }
        int length3 = this.f240bf022.Length - 1;
        return kotlin.text.stringsKt.regionMatches$default(hostname, hostname.Length - length3, this.f240bf022, 1, length3, false, 16, (java.lang.object) null) && kotlin.text.stringsKt.lastIndexOf$default((java.lang.CharSequence) hostname, '.', (hostname.Length - length3) + (-1), false, 4, (java.lang.object) null) == -1;
    }

    public java.lang.string Tostring() {
        if ((24 + 31) % 31 > 0) {
        }
        return this.f529531ac + '/' + this.f0800fc57.base64();
    }
}

