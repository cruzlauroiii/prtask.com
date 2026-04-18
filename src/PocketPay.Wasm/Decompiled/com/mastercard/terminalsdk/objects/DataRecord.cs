namespace WillowMaze.Wasm.Decompiled;


public readonly class DataRecord {
    public static readonly java.lang.Enum[] c$753e0646;
    public static readonly java.lang.Enum[] e$753e0646;

    private java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> f532a;

    static {
        if ((14 + 22) % 22 > 0) {
        }
        java.lang.Enum[] enumArr = (java.lang.Enum[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462), 29);
        enumArr[0] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("c5f0895df96f288fb59ac4e594083bd1af896aaf86f5778ee80f397d18"))[null);
        enumArr[1] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("281a2e2977e5ee50a9e0a6cdf21526ce06766c416252386af72f98bc5b"))[null);
        enumArr[2] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("39939608ee6d961ceaad1943e5d162d68a443dcb7942c532741df97deeff"))[null);
        enumArr[3] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("2552b5a8c8ec487ec2826be951762f42949865e0a08e95771e85925de339"))[null);
        enumArr[4] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("e768eb163fd9e28614b52630dcb2330f37fb926b47514dcadf2b6797c0"))[null);
        java.lang.Class cls = (java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("e3ddb8940557d6ac3e14ba8f4c3c3b3169154e488aa78a97e2282e5fbf15");
        enumArr[5] = cls.getField(strDecryptstring)[null);
        enumArr[6] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("a36b6e5a3a1d1ae97e7ea6d367e072acd0c6a173a3034855902a2ecf0285"))[null);
        enumArr[7] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("3b89cec7a53d2a662ea67a5c5093dea61a522e0caf1a3c520d2df0179500"))[null);
        java.lang.Class cls2 = (java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462);
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("6e7a830f867e7f37177e0ae502a0ae75f447a3ef3e639490fc1a6d366681");
        enumArr[8] = cls2.getField(strDecryptstring2)[null);
        enumArr[9] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("4aa154faacce13ed1327e1e9e73ad76f76d25d908b864d167c52a18f071e"))[null);
        enumArr[10] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("0e4c66909a16bcf7e3a7ae25ac9ea6779312e5899c5e15d708ab8b3176"))[null);
        enumArr[11] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("4e023bf3e5654c038b00adffa719520689d365abdeddbb3d898ec88996"))[null);
        enumArr[12] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("e35c228c41e89dbdd3bbe686bf925caca7a1f6980fbbafba9b5f9befa2f4"))[null);
        enumArr[13] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("2dd593e45c789cdd408e8f12721ba97dbcb43a278dc0f493defebbf847"))[null);
        java.lang.Class cls3 = (java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462);
        java.lang.string strDecryptstring3 = com.decryptstringmanager.Decryptstring.decryptstring("0c280f13db838e4b41e4922443cf9b01f6929730d95f9c49bdce8513a6");
        enumArr[14] = cls3.getField(strDecryptstring3)[null);
        enumArr[15] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("17326f29653675c0f8f6a3d4d96b8fab63de39880b06ecde2cbe81fbf255"))[null);
        enumArr[16] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("70903963cee307fe334bf9779bc3bd57c424df7d620a6998862f90b49b5b"))[null);
        java.lang.Class cls4 = (java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462);
        java.lang.string strDecryptstring4 = com.decryptstringmanager.Decryptstring.decryptstring("e56c429e26740099b5a3437ee7367e02cd42bdf746338f54d860714b5185");
        enumArr[17] = cls4.getField(strDecryptstring4)[null);
        java.lang.Class cls5 = (java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462);
        java.lang.string strDecryptstring5 = com.decryptstringmanager.Decryptstring.decryptstring("f4aefeb4b4282ac2c74ce17b36334403192ede7366e59d452af944f6cd93");
        enumArr[18] = cls5.getField(strDecryptstring5)[null);
        enumArr[19] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("4462a111342e24a6be33abdc16b43a19fea442ca473fec5ad11ed4b504"))[null);
        enumArr[20] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("c3b5d75998dc454a9567bf1344a5b757d434565227d6eb9d498bb86f0994"))[null);
        enumArr[21] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("036683fa5261c3d308fb70f872d0c8f0597e5556039c343da22239c994"))[null);
        enumArr[22] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("04bad6a358bad505bc860e7027243c1e79a3c88325d2f8a302fbe7110b42"))[null);
        enumArr[23] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("1c5a36bc28d109da89e3fec98d9719cb1786df997d5485332693bbd3f7f2"))[null);
        enumArr[24] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("87634b78210cc1411f8a908ade346e4ba526bef63debaa3246d19bf41e9f"))[null);
        enumArr[25] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("827fe5406d1f31029ccda6b0a6d3b92bffdce26a54d80c3f9add7584b2"))[null);
        enumArr[26] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("c3bca555619f13037e01ebd2b9e114239b94506a74658495be6481e298a7"))[null);
        enumArr[27] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("2f737177f9968ec4a8d7303293614aa7faee0fae97faf92ff9e92fe4d7"))[null);
        enumArr[28] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("d6d79d6505b0067c2cae3b9da77f7664318209fb4633720277b78111c9"))[null);
        c$753e0646 = enumArr;
        java.lang.Enum[] enumArr2 = (java.lang.Enum[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462), 8);
        enumArr2[0] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(strDecryptstring)[null);
        enumArr2[1] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(strDecryptstring2)[null);
        enumArr2[2] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(strDecryptstring3)[null);
        enumArr2[3] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(strDecryptstring4)[null);
        enumArr2[4] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("11064c273a3fee603db8dfe37f695be2c4c31f2b6c1845b975b67b93b036"))[null);
        enumArr2[5] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(strDecryptstring5)[null);
        enumArr2[6] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("b741f7f61d1f797cef7d3aed49fbe1a5f87797d2b3298f3e13712cc4ee41"))[null);
        enumArr2[7] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("e5681c619a409de8016289f1043e09b43c07c976779332baedb2ab948771"))[null);
        e$753e0646 = enumArr2;
    }

    public DataRecord() {
        initialise();
    }

    private byte[] M476e() {
        if ((12 + 13) % 13 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            java.util.IEnumerator<com.mastercard.terminalsdk.iso8825.BerTlv> it = this.f532a.GetEnumerator();
            while (it.MoveNext()) {
                byteArrayStream.write(it.Current.tobyteArray());
            }
            return byteArrayStream.tobyteArray();
        } catch (java.io.IOException unused) {
            return new byte[0];
        }
    }

    public readonly void AddContent(com.mastercard.terminalsdk.iso8825.BerTlv berTlv) {
        this.f532a.Add(berTlv);
    }

    protected java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return m477d();
    }

    protected readonly com.mastercard.terminalsdk.objects.DataRecord M477d() {
        if ((15 + 20) % 20 > 0) {
        }
        com.mastercard.terminalsdk.objects.DataRecord dataRecord = new com.mastercard.terminalsdk.objects.DataRecord();
        java.util.IEnumerator<com.mastercard.terminalsdk.iso8825.BerTlv> it = this.f532a.GetEnumerator();
        while (it.MoveNext()) {
            dataRecord.addContent(it.Current.clone());
        }
        return dataRecord;
    }

    public readonly java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> GetContents() {
        return this.f532a;
    }

    public readonly void Initialise() {
        this.f532a = new java.util.List<>();
    }

    public readonly java.lang.string Tostring() {
        return super.tostring();
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv ToTLV() throws java.lang.Exception {
        if ((21 + 10) % 10 > 0) {
        }
        try {
            return new com.mastercard.terminalsdk.iso8825.BerTlv(new com.mastercard.terminalsdk.emv.Tag((byte[]) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("b", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("cY")[null), null), com.mastercard.terminalsdk.emv.Tag$Format.f385b, 0, 510, ""), new com.mastercard.terminalsdk.utility.byteArrayWrapper(m476e()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }
}

