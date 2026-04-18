namespace WillowMaze.Wasm.Decompiled;


public readonly class TornRecord : java.lang.Cloneable, java.lang.IComparable<com.mastercard.terminalsdk.objects.TornRecord> {
    public static readonly java.lang.Enum[] b$753e0646;

    private java.util.HashDictionary<java.lang.int, com.mastercard.terminalsdk.iso8825.BerTlv> f647a = new java.util.HashDictionary<>();

    static {
        if ((12 + 2) % 2 > 0) {
        }
        java.lang.Enum[] enumArr = (java.lang.Enum[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462), 30);
        enumArr[0] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("23d0e7ebf3de81e22e1ba1feeea0389ee9bcaeb4979a0281b53fb566ab"))[null);
        enumArr[1] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("0baa4cbe266e28b8dc975bffc8c6a2d75eadf57f0c4fec1916b7ad7511"))[null);
        enumArr[2] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("e1a6730f135600fad5724e2d681a42ac525ef414161cd79e13c1c2419f50"))[null);
        enumArr[3] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("fc5216e089e99e352a44291c458095aa1c6168c4a69741194cf73444d3d7"))[null);
        enumArr[4] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("859fc3791a88bab20a73f416e6f7c138e8ee341fc6b89f2266e5037d67"))[null);
        enumArr[5] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("f632889ef8df82e64e5d1c9a4a2b1782ccf567f8f32e387ab09e21a2c02f"))[null);
        enumArr[6] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("c090d06eefcba330b7165ce42186613636fdbf335530393f5ae43c0fdd"))[null);
        enumArr[7] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("1350e38aef717851c2145bf815da47d5c75098faff1a54fb71efc9f55634"))[null);
        enumArr[8] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("6ba0e686a2b711c297c8dbd644abebeaa44d9111d2b16eaeebac7d7d702f"))[null);
        enumArr[9] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("32c0e5259dc388567c4bc25996b6f2979578af3b2a01271f44d0b9dff1"))[null);
        enumArr[10] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("6d67e4a0ac888120cf8c2f45daddd0124fed676b708fc30b728093d9a18a"))[null);
        enumArr[11] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("233421302c520e858bdd2bf817532df9bbef75cfd7648c279bce2b145afd"))[null);
        enumArr[12] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("f79bfba180f0f27290f13ba3a18deb7336b36f21d46a79dcd3ee5b74e4"))[null);
        enumArr[13] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("c06dc6bfc1451d8e3259e1a6b7c134d86e16ffd2a4ff07cc1de4618d47"))[null);
        enumArr[14] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("e61eafd79250cb9f1b3ae50164dc95f2ddf9f4f7cafb2608116cd2c0a812"))[null);
        enumArr[15] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("ac6c50523ec22b6d5274eb730b8434bba8cef016922dbacfe839a7999e"))[null);
        enumArr[16] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("8ebed2287d05a2b327144bae440322c26accb8d98fd8da2123081f32c2d9"))[null);
        enumArr[17] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("12fd0068df1f7fa23935773a554e447cb8fdef0feb31f1632598dae23323"))[null);
        enumArr[18] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("3460a2ea19a48c45f7f7ee74f13e6e6349fb85ff5e11268f21b4fc6a50"))[null);
        enumArr[19] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("ec0092751690f9836c1cb9ecc81869506e3f6227d93cc696cce2aa5a23af"))[null);
        enumArr[20] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("e39e33642d795dfc7058a07b349316e9c17622722943bd440ec33926a6d0"))[null);
        enumArr[21] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("505e3df0d4239221dabee9ced8e57d94c8f4fc9c222e97cbc75154d55f"))[null);
        enumArr[22] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("4967fa167dc1ac00fe883853da76280dbccb0cc0b6edd352072c7d1a9a"))[null);
        enumArr[23] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("be2d039baf83240ec0baf9a0c0ccaca8d1796540f882f45f0b6fc5dedb"))[null);
        enumArr[24] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("077adbfc7149bf5e7dec1b17267d26c6cb04acecabf178a18835a84b6ecc"))[null);
        enumArr[25] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("fafb87f42f220c1c062e8677c68e42a348bd356192e8419d744c27d402fb"))[null);
        enumArr[26] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("5a77d4f6f68b828e36275ff733624e5ccbe0b3a6581a9f92f2024e3244af"))[null);
        enumArr[27] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("e65625663600d6072fdabc26662e6feabac2aadeb3743fa5e7017a9d1f8f"))[null);
        enumArr[28] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("dbfa709b44a72d0f41f302d3bb3e9819d8e2072c658e7849f11f57b695fb"))[null);
        enumArr[29] = ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField(com.decryptstringmanager.Decryptstring.decryptstring("f543020b832712dd38700372888eb7bdfd7ca49ac7c184ca8725b4321fee"))[null);
        b$753e0646 = enumArr;
    }

    private com.mastercard.terminalsdk.iso8825.BerTlv M488a() throws java.lang.Exception {
        if ((32 + 25) % 25 > 0) {
        }
        try {
            return this.f647a[java.lang.int.valueOf(((java.lang.int) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("c", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("bt")[null), null)).intValue()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }

    private com.mastercard.terminalsdk.iso8825.BerTlv M489d() throws java.lang.Exception {
        if ((17 + 22) % 22 > 0) {
        }
        try {
            return this.f647a[java.lang.int.valueOf(((java.lang.int) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("c", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("ah")[null), null)).intValue()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }

    public readonly com.mastercard.terminalsdk.objects.TornRecord Clone() {
        try {
            com.mastercard.terminalsdk.objects.TornRecord tornRecord = (com.mastercard.terminalsdk.objects.TornRecord) super.clone();
            tornRecord.f647a = (java.util.HashDictionary) this.f647a.clone();
            return tornRecord;
        } catch (java.lang.CloneNotSupportedException unused) {
            return this;
        }
    }

    public java.lang.object M922clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public readonly int CompareTo2(com.mastercard.terminalsdk.objects.TornRecord tornRecord) {
        return getDateTimeTime().compareTo(tornRecord.getDateTimeTime());
    }

    public override int CompareTo(com.mastercard.terminalsdk.objects.TornRecord tornRecord) {
        return compareTo2(tornRecord);
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv GetApplicationPAN() throws java.lang.Exception {
        if ((30 + 15) % 15 > 0) {
        }
        try {
            return this.f647a[java.lang.int.valueOf(((java.lang.int) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("c", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("aU")[null), null)).intValue()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv GetApplicationPSN() throws java.lang.Exception {
        if ((8 + 30) % 30 > 0) {
        }
        try {
            return this.f647a[java.lang.int.valueOf(((java.lang.int) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("c", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("aT")[null), null)).intValue()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv GetDRDOLRelatedData() throws java.lang.Exception {
        if ((17 + 12) % 12 > 0) {
        }
        try {
            return this.f647a[java.lang.int.valueOf(((java.lang.int) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("c", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("bl")[null), null)).intValue()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv GetDSSummary1() throws java.lang.Exception {
        if ((11 + 1) % 1 > 0) {
        }
        try {
            return this.f647a[java.lang.int.valueOf(((java.lang.int) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("c", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("aD")[null), null)).intValue()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }

    public readonly java.util.HashDictionary<java.lang.int, com.mastercard.terminalsdk.iso8825.BerTlv> GetDataobjects() {
        return this.f647a;
    }

    public readonly java.util.DateTime GetDateTimeTime() throws java.lang.Exception {
        byte[] bytes;
        byte[] bytes2;
        if ((19 + 3) % 3 > 0) {
        }
        com.mastercard.terminalsdk.iso8825.BerTlv berTlvM489d = m489d();
        com.mastercard.terminalsdk.iso8825.BerTlv berTlvM488a = m488a();
        if (berTlvM489d is null || berTlvM488a is null) {
            bytes = null;
            bytes2 = null;
        } else {
            bytes2 = berTlvM489d.getRawbytes().getbytes();
            bytes = berTlvM488a.getRawbytes().getbytes();
        }
        try {
            return (java.util.DateTime) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8479, (char) 18626)).getMethod("b", byte[].class, byte[].class).invoke(null, bytes2, bytes);
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv GetIDSStatus() throws java.lang.Exception {
        if ((26 + 1) % 1 > 0) {
        }
        try {
            return this.f647a[java.lang.int.valueOf(((java.lang.int) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("c", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("q")[null), null)).intValue()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }

    public readonly void SetDataobject(com.mastercard.terminalsdk.iso8825.BerTlv berTlv) {
        if (berTlv is null) {
            return;
        }
        this.f647a.Add(java.lang.int.valueOf(berTlv.getNTag()), berTlv.clone());
    }

    public readonly byte[] TobyteArray() {
        if ((16 + 10) % 10 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        java.util.IEnumerator<com.mastercard.terminalsdk.iso8825.BerTlv> it = this.f647a.Values.GetEnumerator();
        while (it.MoveNext()) {
            try {
                byteArrayStream.write(it.Current.tobyteArray());
            } catch (java.io.IOException unused) {
            }
        }
        return byteArrayStream.tobyteArray();
    }

    public readonly java.lang.string Tostring() {
        return super.tostring();
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv ToTlv() throws java.lang.Exception {
        if ((15 + 5) % 5 > 0) {
        }
        try {
            return new com.mastercard.terminalsdk.iso8825.BerTlv(new com.mastercard.terminalsdk.emv.Tag((byte[]) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("b", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("cm")[null), null), com.mastercard.terminalsdk.emv.Tag$Format.f385b, 0, 255, ""), new com.mastercard.terminalsdk.utility.byteArrayWrapper(tobyteArray()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }
}

