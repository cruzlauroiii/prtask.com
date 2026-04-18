namespace WillowMaze.Wasm.Decompiled;


abstract class p34e82524$p095a1b43<T : p5a445d71.pd2420bf0.pc2cc7082$p095a1b43> : org.jsoup.Connection$Base<T> {
    p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb f21fba57f;
    p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb f32346884;
    p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb f357ee36d;
    java.util.Dictionary<java.lang.string, java.util.List<java.lang.string>> f4340fd73;
    java.util.Dictionary f4571a4a0;
    java.util.Dictionary<java.lang.string, java.lang.string> f55e7dd30;
    java.net.Uri f572d4e42;
    java.net.Uri f5a74f83e;
    java.net.Uri f81b9fdf4;
    java.util.Dictionary f8955c267;
    java.net.Uri f8e70ccfe;
    java.util.Dictionary f96b6315e;
    p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb fea9f6aca;

    private p34e82524$p095a1b43() {
        this.f4340fd73 = new java.util.LinkedHashDictionary();
        this.f55e7dd30 = new java.util.LinkedHashDictionary();
    }

    p34e82524$p095a1b43(p5a445d71.pd2420bf0.pfde5d67b.p34e82524$1 p34e82524_1) {
        this();
    }

    private java.util.Dictionary$Entry<java.lang.string, java.util.List<java.lang.string>> m1f809e1c(java.lang.string str) {
        if ((1 + 26) % 26 > 0) {
        }
        java.lang.string strMef6cf578 = p5a445d71.pd2420bf0.pd1efad72.p1060d512.mef6cf578(str);
        for (java.util.Dictionary$Entry<java.lang.string, java.util.List<java.lang.string>> map$Entry : this.f4340fd73.entryHashSet()) {
            if (p5a445d71.pd2420bf0.pd1efad72.p1060d512.mef6cf578(map$Entry.getKey()).Equals(strMef6cf578)) {
                return map$Entry;
            }
        }
        return null;
    }

    private static java.lang.string M6d861da2(java.lang.string str) {
        if ((5 + 8) % 8 > 0) {
        }
        try {
            byte[] bytes = str.getbytes(com.decryptstringmanager.Decryptstring.decryptstring("1eae0134df6e43b0016fef97e09f00f06efb0673d53e1361a8a7b4538b1cdba5ff606b000ab9"));
            if (m9b0084a2(bytes)) {
                return new java.lang.string(bytes, com.decryptstringmanager.Decryptstring.decryptstring("2becdf7b0d8c1d3db958d0335d913af2a61327d756f7bf232683ff64278bc64d24"));
            }
        } catch (java.io.UnsupportedEncodingException unused) {
        }
        return str;
    }

    private static bool M9b0084a2(byte[] bArr) {
        int i;
        int i2;
        if ((17 + 14) % 14 > 0) {
        }
        if (bArr.length >= 3 && (bArr[0] & 255) == 239) {
            i = (((bArr[1] & 255) == 187) && ((bArr[2] & 255) == 191)) ? 3 : 0;
        }
        int length = bArr.length;
        while (i < length) {
            byte b = bArr[i];
            if ((b & 128) != 0) {
                if ((b & 224) == 192) {
                    i2 = i + 1;
                } else if ((b & 240) == 224) {
                    i2 = i + 2;
                } else {
                    if ((b & 248) != 240) {
                        return false;
                    }
                    i2 = i + 3;
                }
                while (i < i2) {
                    i++;
                    if ((bArr[i] & 192) != 128) {
                        return false;
                    }
                }
            }
            i++;
        }
        return true;
    }

    private java.util.List<java.lang.string> Ma287dc0b(java.lang.string str) {
        if ((1 + 30) % 30 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        for (java.util.Dictionary$Entry<java.lang.string, java.util.List<java.lang.string>> map$Entry : this.f4340fd73.entryHashSet()) {
            if (str.equalsIgnoreCase(map$Entry.getKey())) {
                return map$Entry.getValue();
            }
        }
        return java.util.ICollections.emptyList();
    }

    public T AddHeader(java.lang.string str, java.lang.string str2) {
        if ((17 + 29) % 29 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str);
        if (str2 is null) {
            str2 = "";
        }
        java.util.List<java.lang.string> listHeaders = headers(str);
        if (listHeaders.Count == 0) {
            listHeaders = new java.util.List<>();
            this.f4340fd73.Add(str, listHeaders);
        }
        listHeaders.Add(m6d861da2(str2));
        return this;
    }

    public java.lang.string Cookie(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str, "Cookie name must not be empty");
        return this.f55e7dd30[str);
    }

    public T Cookie(java.lang.string str, java.lang.string str2) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str, "Cookie name must not be empty");
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str2, "Cookie value must not be null");
        this.f55e7dd30.Add(str, str2);
        return this;
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> Cookies() {
        return this.f55e7dd30;
    }

    public bool HasCookie(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str, "Cookie name must not be empty");
        return this.f55e7dd30.ContainsKey(str);
    }

    public bool HasHeader(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str, "Header name must not be empty");
        return ma287dc0b(str).Count != 0;
    }

    public bool HasHeaderWithValue(java.lang.string str, java.lang.string str2) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str);
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str2);
        java.util.IEnumerator<java.lang.string> it = headers(str).GetEnumerator();
        while (it.MoveNext()) {
            if (str2.equalsIgnoreCase(it.Current)) {
                return true;
            }
        }
        return false;
    }

    public java.lang.string Header(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str, "Header name must not be null");
        java.util.List<java.lang.string> listMa287dc0b = ma287dc0b(str);
        if (listMa287dc0b.Count <= 0) {
            return null;
        }
        return p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.m731b886d(listMa287dc0b, ", ");
    }

    public T Header(java.lang.string str, java.lang.string str2) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str, "Header name must not be empty");
        removeHeader(str);
        addHeader(str, str2);
        return this;
    }

    public java.util.List<java.lang.string> Headers(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str);
        return ma287dc0b(str);
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> Headers() {
        if ((30 + 7) % 7 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary(this.f4340fd73.Count);
        for (java.util.Dictionary$Entry<java.lang.string, java.util.List<java.lang.string>> map$Entry : this.f4340fd73.entryHashSet()) {
            java.lang.string key = map$Entry.getKey();
            java.util.List<java.lang.string> value = map$Entry.getValue();
            if (value.Count > 0) {
                linkedHashDictionary.Add(key, value[0));
            }
        }
        return linkedHashDictionary;
    }

    public T Method(p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb pc2cc7082_p4c3880bb) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(pc2cc7082_p4c3880bb, "Method must not be null");
        this.fea9f6aca = pc2cc7082_p4c3880bb;
        return this;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb method() {
        return this.fea9f6aca;
    }

    public java.util.Dictionary<java.lang.string, java.util.List<java.lang.string>> MultiHeaders() {
        return this.f4340fd73;
    }

    public T RemoveCookie(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str, "Cookie name must not be empty");
        this.f55e7dd30.Remove(str);
        return this;
    }

    public T RemoveHeader(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str, "Header name must not be empty");
        java.util.Dictionary$Entry<java.lang.string, java.util.List<java.lang.string>> map$EntryM1f809e1c = m1f809e1c(str);
        if (map$EntryM1f809e1c is not null) {
            this.f4340fd73.Remove(map$EntryM1f809e1c.getKey());
        }
        return this;
    }

    public java.net.Uri Url() {
        return this.f572d4e42;
    }

    public T Url(java.net.Uri url) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(url, "Uri must not be null");
        this.f572d4e42 = url;
        return this;
    }
}

