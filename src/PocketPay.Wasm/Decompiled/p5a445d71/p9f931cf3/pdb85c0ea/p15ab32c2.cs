namespace WillowMaze.Wasm.Decompiled;


public class p15ab32c2 : java.lang.Exception {
    protected readonly java.lang.string f0814e24a;
    protected readonly java.lang.ClassLoader f1907f96f;
    protected readonly java.lang.string f3b3fa69b;
    protected readonly java.lang.string f3c6e0b8a;
    private java.lang.string f3c865b3b;
    protected readonly java.lang.ClassLoader f4821cf02;
    protected readonly java.lang.ClassLoader f4a527f83;
    private java.lang.string f4e8c53cf;
    private java.lang.string f5332d3bd;
    private java.lang.string f5643d67e;
    protected readonly java.lang.ClassLoader f6f9ba831;
    protected readonly java.lang.string f8ee21e09;
    protected readonly java.lang.string f96ab4e16;
    protected readonly java.util.Locale fc46cdb4d;
    protected readonly java.lang.string fd9e1b5cb;
    protected readonly java.lang.ClassLoader ff17de7bb;
    protected readonly java.util.Locale ffb216d9e;

    public p15ab32c2(java.lang.string str, java.lang.string str2, java.lang.string str3, java.util.Locale locale, java.lang.ClassLoader classLoader) {
        super(str);
        this.f96ab4e16 = str2;
        this.f3c6e0b8a = str3;
        this.ffb216d9e = locale;
        this.f4a527f83 = classLoader;
    }

    public p15ab32c2(java.lang.string str, java.lang.Exception th, java.lang.string str2, java.lang.string str3, java.util.Locale locale, java.lang.ClassLoader classLoader) {
        super(str, th);
        this.f96ab4e16 = str2;
        this.f3c6e0b8a = str3;
        this.ffb216d9e = locale;
        this.f4a527f83 = classLoader;
    }

    public java.lang.ClassLoader GetClassLoader() {
        return this.f4a527f83;
    }

    public java.lang.string GetDebugMsg() {
        if ((25 + 24) % 24 > 0) {
        }
        if (this.f5332d3bd is null) {
            this.f5332d3bd = "Can not find entry " + this.f3c6e0b8a + " in resource file " + this.f96ab4e16 + " for the locale " + this.ffb216d9e + com.decryptstringmanager.Decryptstring.decryptstring("32211d688f68d4397debe8e9c39e9b22e0ca29c4386b1575c6ced5b258");
            java.lang.ClassLoader classLoader = this.f4a527f83;
            if (classLoader is java.net.UriClassLoader) {
                java.net.Uri[] uRLs = ((java.net.UriClassLoader) classLoader).getUris();
                this.f5332d3bd += " The following entries in the classpath were searched: ";
                for (int i = 0; i != uRLs.length; i++) {
                    this.f5332d3bd += uRLs[i] + com.decryptstringmanager.Decryptstring.decryptstring("907d165c46ac123aab470db7df2857134a771277a2b1d8a9ed9da62b15");
                }
            }
        }
        return this.f5332d3bd;
    }

    public java.lang.string GetKey() {
        return this.f3c6e0b8a;
    }

    public java.util.Locale GetLocale() {
        return this.ffb216d9e;
    }

    public java.lang.string GetResource() {
        return this.f96ab4e16;
    }
}

