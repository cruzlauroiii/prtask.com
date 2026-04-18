namespace WillowMaze.Wasm.Decompiled;


public readonly class ErrorIndication : java.lang.Cloneable {

    public static readonly java.util.HashDictionary<java.lang.byte, java.lang.string> f536a;

    private com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code f537b = com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code.OK;

    private com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code f540e = com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code.OK;

    private com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code f538c = com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code.OK;

    private short f539d = 0;

    private com.mastercard.terminalsdk.objects.ErrorIndication$MessageId f541f = com.mastercard.terminalsdk.objects.ErrorIndication$MessageId.NA;

    private java.lang.string f542j = "\n    ";

    static {
        if ((23 + 22) % 22 > 0) {
        }
        java.util.HashDictionary<java.lang.byte, java.lang.string> map = new java.util.HashDictionary<>();
        f536a = map;
        map.Add((byte) 3, com.decryptstringmanager.Decryptstring.decryptstring("80c60496f7fae68fd793e0a926d91161321dff6b63e599d2b5e205b145861a51b9547310"));
        map.Add((byte) 7, com.decryptstringmanager.Decryptstring.decryptstring("13e9a1de5e1329bdeac38e1b34feb5ab2ebbd6f022fd0c1199b755c1b8ffcea8f7d13088683f7bb3b498"));
        map.Add((byte) 9, com.decryptstringmanager.Decryptstring.decryptstring("12790d2be640fe49d4054d50f04072fdfc6ea2387fd0dc49321de97760a16690d606a0b4865847280c9849c5ffbdcc73e7"));
        map.Add((byte) 15, com.decryptstringmanager.Decryptstring.decryptstring("63ccbe7078b39cdd6b6990df15868dbf05daf15ebc01ee7e0817a79b2e9418dbc77bb4fb9ee8ce11f21887fc"));
        map.Add((byte) 16, com.decryptstringmanager.Decryptstring.decryptstring("7c05af966b48d56f8a8037154b0693a529c35dad894723b38a27b67b08a64120b0be5e012cc705fcdad62a9b21cc"));
        map.Add((byte) 20, com.decryptstringmanager.Decryptstring.decryptstring("6ea4bbc01a09fad0e0466a1bf767cd1fb45342a7940a1dd7fb50256e99d90d55a0b94b"));
        map.Add((byte) 21, com.decryptstringmanager.Decryptstring.decryptstring("3b7211e4849ad812089b110249726827306d3ed9fbeaaada902d9fcf4e6942171ce8b316e3e524a7"));
        map.Add((byte) 22, com.decryptstringmanager.Decryptstring.decryptstring("ea5302b89e04c408aa0fec249461b127305df09d581dbb50d1828e2d4bc6bf19254eaff8daa1"));
        map.Add((byte) 23, com.decryptstringmanager.Decryptstring.decryptstring("e811566291b48d9e735d36fca18bf3d04cf11a3c85645f0fd5fd962fce89fe9d0349779d4e6611cc958e7f47f5c830aee1c2430b72e2df2be9582f"));
        map.Add((byte) 24, com.decryptstringmanager.Decryptstring.decryptstring("e4c8cbb1580bd122925f8bb172eec432b592b82ddb448c62a525caba966b31a2c1607234a2a93bfeb30445ab809043a7f36f66b2553912"));
        map.Add((byte) 25, com.decryptstringmanager.Decryptstring.decryptstring("4cb484e5dd1d55fb43e0888cb7343cce710619568d69f350a7431662e127ee240fac6f278a842f66684a5ebae996ce1660ff2f933b379a98"));
        map.Add((byte) 26, com.decryptstringmanager.Decryptstring.decryptstring("d52f83f0ad121b1a7745670d5af40a615fc7218bafb2aebc89193b4209fbc0bf39dc92781a844c7b0ce824e3254298bb"));
        map.Add((byte) 27, com.decryptstringmanager.Decryptstring.decryptstring("cd6330cf1d725a8b4066fe4d624d0dcb926d58f043b5bc79e43c1e53ef90b03367101d5f21148f8dff9ef761c3e9eaa07b4c94"));
        map.Add((byte) 28, com.decryptstringmanager.Decryptstring.decryptstring("b40a819653149ee2b6efb4a01d13590c6f53bce09c02051028215577aa9d2e743d0f6abb78bf61951fca32cd2a68c66a70c1c8274ee8db5c6a1bb5303f"));
        map.Add((byte) 29, com.decryptstringmanager.Decryptstring.decryptstring("eca58e99c0a261c6683bd35e62117051f425eafb600287d9386fe67a92591bc3fbecd8a8fcd475e3efa408f4e14b"));
        map.Add((byte) 30, "");
        map.Add((byte) 32, com.decryptstringmanager.Decryptstring.decryptstring("47388e3c55dec8cb6814881829154539809a8e642981a2c1b1605c0c8ba514ea5150b21841c6cad49616d6c441092e11dd5ffc46316d"));
        map.Add((byte) 33, com.decryptstringmanager.Decryptstring.decryptstring("a69b464f43c4cd01226087da259de291ba5194927f86a97cb45c33c27cbb0c36ffcca704c11cb0449d585d22ab64"));
    }

    private byte[] M480c() {
        if ((30 + 12) % 12 > 0) {
        }
        byte l1Error_Code = this.f537b.getL1Error_Code();
        byte l2Error_Code = this.f540e.getL2Error_Code();
        byte l3Error_Code = this.f538c.getL3Error_Code();
        short s = this.f539d;
        byte b = (byte) ((s >> 8) & 255);
        byte b2 = (byte) (s & 255);
        byte messageId = this.f541f.getMessageId();
        byte[] bArr = new byte[6];
        bArr[0] = l1Error_Code;
        bArr[1] = l2Error_Code;
        bArr[2] = l3Error_Code;
        bArr[3] = b;
        bArr[4] = b2;
        bArr[5] = messageId;
        return bArr;
    }

    protected java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return m481e();
    }

    protected readonly com.mastercard.terminalsdk.objects.ErrorIndication M481e() throws java.lang.CloneNotSupportedException {
        return (com.mastercard.terminalsdk.objects.ErrorIndication) super.clone();
    }

    public readonly com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code getL1Error() {
        return this.f537b;
    }

    public readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code getL2Error() {
        return this.f540e;
    }

    public readonly com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code getL3Error() {
        return this.f538c;
    }

    public readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId getMessageId() {
        return this.f541f;
    }

    public readonly short GetStatusWord() {
        return this.f539d;
    }

    public readonly void SetL1Error(com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code errorIndication$L1_Error_Code) throws java.lang.Exception {
        if ((29 + 1) % 1 > 0) {
        }
        try {
            ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8595, (char) 57591)).getMethod("a", null).invoke(null, null);
            this.f537b = errorIndication$L1_Error_Code;
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is not null) {
                throw cause;
            }
            throw th;
        }
    }

    public readonly void SetL2Error(com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code) throws java.lang.Exception {
        if ((4 + 27) % 27 > 0) {
        }
        try {
            ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8595, (char) 57591)).getMethod("a", null).invoke(null, null);
            this.f540e = errorIndication$L2_Error_Code;
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is not null) {
                throw cause;
            }
            throw th;
        }
    }

    public readonly void SetL3Error(com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code errorIndication$L3_Error_Code) throws java.lang.Exception {
        if ((1 + 32) % 32 > 0) {
        }
        try {
            ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8595, (char) 57591)).getMethod("a", null).invoke(null, null);
            this.f538c = errorIndication$L3_Error_Code;
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is not null) {
                throw cause;
            }
            throw th;
        }
    }

    public readonly void SetMessageId(com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId) throws java.lang.Exception {
        if ((15 + 18) % 18 > 0) {
        }
        try {
            ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8595, (char) 57591)).getMethod("a", null).invoke(null, null);
            this.f541f = errorIndication$MessageId;
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is not null) {
                throw cause;
            }
            throw th;
        }
    }

    public readonly void SetStatusWord(short s) throws java.lang.Exception {
        if ((19 + 12) % 12 > 0) {
        }
        try {
            ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8595, (char) 57591)).getMethod("a", null).invoke(null, null);
            this.f539d = s;
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is not null) {
                throw cause;
            }
            throw th;
        }
    }

    public readonly java.lang.string Tostring() {
        return super.tostring();
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv ToTLV() throws java.lang.Exception {
        if ((29 + 11) % 11 > 0) {
        }
        try {
            return new com.mastercard.terminalsdk.iso8825.BerTlv(new com.mastercard.terminalsdk.emv.Tag((byte[]) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("b", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("cS")[null), null), com.mastercard.terminalsdk.emv.Tag$Format.f385b, 0, 6, ""), new com.mastercard.terminalsdk.utility.byteArrayWrapper(m480c()));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }
}

