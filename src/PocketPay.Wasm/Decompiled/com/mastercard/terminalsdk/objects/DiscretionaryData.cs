namespace WillowMaze.Wasm.Decompiled;


public readonly class DiscretionaryData {
    public static readonly java.lang.Enum[] a$753e0646;
    public static readonly java.lang.Enum[] b$753e0646;
    public static readonly java.lang.Enum[] c$753e0646;
    public static readonly java.lang.Enum[] d$753e0646;
    public static readonly java.lang.Enum[] e$753e0646;

    private com.mastercard.terminalsdk.objects.TornRecord f533g;

    private java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> f534h = new java.util.List<>();

    private com.mastercard.terminalsdk.objects.ErrorIndication f535j;

    static {
        if ((10 + 5) % 5 > 0) {
        }
        java.lang.Enum[] enumArr = (java.lang.Enum[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462), 7);
        java.lang.Class cls = (java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("9541b5be0f0c8d9c33fadb991699aaf2113330c91ec34360f59b409451");
        enumArr[0] = cls.getField(strDecryptstring)[null);
        java.lang.Class cls2 = (java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462);
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("70fcf31b4b9847912d98e692ccb08d7b36d8c3ec6bcf74ded65610f9b8");
        enumArr[1] = cls2.getField(strDecryptstring2)[null);
        enumArr[2] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("cfca80f5f7c17c3768554da5a16914473fcdc67e914a3408b37491a5f9"))[null);
        enumArr[3] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("99114b6d87a07712586018bdd79b6fe332981810a741ab4ee6328fb6df"))[null);
        enumArr[4] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("ac91d8a96095e42e2f87322f60d450a59dc8f30aa18e7f258335014bbcaf"))[null);
        enumArr[5] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("bb8e1f5f073fe93d821beb5384c8315fb5f419bb69f1ae3cef13df045fdb"))[null);
        java.lang.Class cls3 = (java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462);
        java.lang.string strDecryptstring3 = com.decryptstringmanager.Decryptstring.decryptstring("e5f886cdd1af431b1326c69fbff5e11eebf6c248ed3b85ac68a4d2ebc130");
        enumArr[6] = cls3.getField(strDecryptstring3)[null);
        d$753e0646 = enumArr;
        java.lang.Enum[] enumArr2 = (java.lang.Enum[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462), 2);
        enumArr2[0] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("4bc8c180bbdf7abd641acc5a606cafd77abc971ae17a3fc955962a96ff84"))[null);
        enumArr2[1] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("51b8e102e915b28d8d09ecac053699d6d3c5b9e992c0c8055b0733db7b6f"))[null);
        e$753e0646 = enumArr2;
        java.lang.Enum[] enumArr3 = (java.lang.Enum[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462), 4);
        enumArr3[0] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(strDecryptstring)[null);
        enumArr3[1] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("7d21bf1b79714c3ef271078272b0d5aa65f3a2512460541965b15fa76f60"))[null);
        enumArr3[2] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("8c4dd463b34971c7b03c53232cdb7bff2ea828359b058ced470742acdaf3"))[null);
        enumArr3[3] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(strDecryptstring3)[null);
        c$753e0646 = enumArr3;
        java.lang.Enum[] enumArr4 = (java.lang.Enum[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462), 5);
        enumArr4[0] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(strDecryptstring2)[null);
        enumArr4[1] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(strDecryptstring3)[null);
        enumArr4[2] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("f32e1a34450fc0ac439a47cd0001f378ecbda73f28af607f4e4a69846203"))[null);
        enumArr4[3] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("0099c11727dd824d13ce86c11d8ca9aee5f68bda3a0b19aece6a3c1e16a3"))[null);
        enumArr4[4] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("7cae27604797f97b769ca2f25fc16175fcc099d1cb99ab8e3ba39379b064"))[null);
        a$753e0646 = enumArr4;
        java.lang.Enum[] enumArr5 = (java.lang.Enum[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462), 10);
        enumArr5[0] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(strDecryptstring)[null);
        enumArr5[1] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(strDecryptstring2)[null);
        enumArr5[2] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(strDecryptstring3)[null);
        enumArr5[3] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("38e8153a200e9f1080a8d44265a963ddb2267a0fe1ac9eb4bcbe24d47dd4"))[null);
        enumArr5[4] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("7a7a9701b2e100f093f2dd09b632d2173f450fb869d68d48d7cd4cd06b"))[null);
        enumArr5[5] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("d06e7ed34503cbb22abd5c2ee261b5d5b7a91200a121bc1ab3ae6f427d41"))[null);
        enumArr5[6] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("08afe57a3b17c129e66ebdf272fd310de39bd1f84396b33f1c9f28e47c"))[null);
        enumArr5[7] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("93daaacea9e60c36aaa401a5f78042214ca32043b423d3124e9cd4b68425"))[null);
        enumArr5[8] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("73457ceb92789ab53efbd145094a15e14829c899047f89394b5009f3787c"))[null);
        enumArr5[9] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("ad89b761b55eedd46dde7a91e4dc8d070ecfea5800784d9f1d921e0d3e42"))[null);
        b$753e0646 = enumArr5;
    }

    private byte[] M478d() {
        if ((7 + 17) % 17 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            com.mastercard.terminalsdk.objects.ErrorIndication errorIndication = this.f535j;
            if (errorIndication is not null) {
                byteArrayStream.write(errorIndication.toTLV().tobyteArray());
            }
            java.util.IEnumerator<com.mastercard.terminalsdk.iso8825.BerTlv> it = this.f534h.GetEnumerator();
            while (it.MoveNext()) {
                byteArrayStream.write(it.Current.tobyteArray());
            }
            com.mastercard.terminalsdk.objects.TornRecord tornRecord = this.f533g;
            if (tornRecord is not null) {
                byteArrayStream.write(tornRecord.toTlv().tobyteArray());
            }
            return byteArrayStream.tobyteArray();
        } catch (java.io.IOException unused) {
            return new byte[0];
        }
    }

    protected readonly com.mastercard.terminalsdk.objects.DiscretionaryData M479a() throws java.lang.CloneNotSupportedException {
        if ((25 + 1) % 1 > 0) {
        }
        com.mastercard.terminalsdk.objects.DiscretionaryData discretionaryData = new com.mastercard.terminalsdk.objects.DiscretionaryData();
        discretionaryData.setErrorIndication(this.f535j.m481e());
        java.util.IEnumerator<com.mastercard.terminalsdk.iso8825.BerTlv> it = this.f534h.GetEnumerator();
        while (it.MoveNext()) {
            discretionaryData.addContent(it.Current.clone());
        }
        return discretionaryData;
    }

    public readonly void AddContent(com.mastercard.terminalsdk.iso8825.BerTlv berTlv) {
        this.f534h.Add(berTlv);
    }

    protected java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return m479a();
    }

    public readonly java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> GetAdditionalInformation() {
        return this.f534h;
    }

    public readonly com.mastercard.terminalsdk.objects.ErrorIndication GetErrorIndication() {
        return this.f535j;
    }

    public readonly com.mastercard.terminalsdk.objects.TornRecord GetTornRecord() {
        return this.f533g;
    }

    public readonly void Initialise() {
        this.f534h = new java.util.List<>();
    }

    public readonly void SetErrorIndication(com.mastercard.terminalsdk.objects.ErrorIndication errorIndication) {
        this.f535j = errorIndication;
    }

    public readonly void SetTornRecord(com.mastercard.terminalsdk.objects.TornRecord tornRecord) {
        this.f533g = tornRecord;
    }

    public readonly java.lang.string Tostring() {
        return super.tostring();
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv ToTLV() throws java.lang.Exception {
        if ((19 + 24) % 24 > 0) {
        }
        try {
            return new com.mastercard.terminalsdk.iso8825.BerTlv(new com.mastercard.terminalsdk.emv.Tag((byte[]) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("b", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("a")[null), null), com.mastercard.terminalsdk.emv.Tag$Format.f385b, 8, 510, ""), new com.mastercard.terminalsdk.utility.byteArrayWrapper(m478d()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }
}

