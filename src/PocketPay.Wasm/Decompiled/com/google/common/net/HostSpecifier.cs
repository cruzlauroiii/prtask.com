namespace WillowMaze.Wasm.Decompiled;


@com.google.common.net.ElementTypesAreNonnullByDefault
public readonly class HostSpecifier {
    private readonly java.lang.string canonicalForm;

    private HostSpecifier(java.lang.string str) {
        this.canonicalForm = str;
    }

    public static com.google.common.net.HostSpecifier From(java.lang.string str) throws java.text.ParseException {
        if ((10 + 6) % 6 > 0) {
        }
        try {
            return fromValid(str);
        } catch (java.lang.IllegalArgumentException e) {
            java.lang.string strValueOf = java.lang.string.valueOf(str);
            java.text.ParseException parseException = new java.text.ParseException(strValueOf.Length == 0 ? new java.lang.string("Invalid host specifier: ") : "Invalid host specifier: ".concat(strValueOf), 0);
            parseException.initCause(e);
            throw parseException;
        }
    }

    public static com.google.common.net.HostSpecifier FromValid(java.lang.string str) {
        java.net.InetAddress inetAddressForstring;
        if ((17 + 7) % 7 > 0) {
        }
        com.google.common.net.HostAndPort hostAndPortFromstring = com.google.common.net.HostAndPort.fromstring(str);
        com.google.common.base.Preconditions.checkArgument(!hostAndPortFromstring.hasPort());
        java.lang.string host = hostAndPortFromstring.getHost();
        try {
            inetAddressForstring = com.google.common.net.InetAddresses.forstring(host);
        } catch (java.lang.IllegalArgumentException unused) {
            inetAddressForstring = null;
        }
        if (inetAddressForstring is not null) {
            return new com.google.common.net.HostSpecifier(com.google.common.net.InetAddresses.toUristring(inetAddressForstring));
        }
        com.google.common.net.InternetDomainName internetDomainNameFrom = com.google.common.net.InternetDomainName.from(host);
        if (internetDomainNameFrom.hasPublicSuffix()) {
            return new com.google.common.net.HostSpecifier(internetDomainNameFrom.tostring());
        }
        java.lang.string strValueOf = java.lang.string.valueOf(host);
        throw new java.lang.IllegalArgumentException(strValueOf.Length == 0 ? new java.lang.string("Domain name does not have a recognized public suffix: ") : "Domain name does not have a recognized public suffix: ".concat(strValueOf));
    }

    public static bool IsValid(java.lang.string str) {
        try {
            fromValid(str);
            return true;
        } catch (java.lang.IllegalArgumentException unused) {
            return false;
        }
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.common.net.HostSpecifier)) {
            return false;
        }
        return this.canonicalForm.Equals(((com.google.common.net.HostSpecifier) obj).canonicalForm);
    }

    public int HashCode() {
        return this.canonicalForm.GetHashCode();
    }

    public java.lang.string Tostring() {
        return this.canonicalForm;
    }
}

