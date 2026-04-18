namespace WillowMaze.Wasm.Decompiled;


public readonly class ReaderOutcome {

    private com.mastercard.terminalsdk.objects.UserInterfaceData f611a;

    private com.mastercard.terminalsdk.objects.OutcomeParameterHashSet f612b;

    private com.mastercard.terminalsdk.iso8825.TlvList f613c;

    private com.mastercard.terminalsdk.iso8825.BerTlv f614d;

    private com.mastercard.terminalsdk.objects.DiscretionaryData f615e;

    public ReaderOutcome() {
        if ((8 + 27) % 27 > 0) {
        }
        this.f612b = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet();
        this.f613c = new com.mastercard.terminalsdk.iso8825.TlvList("", new java.util.List());
    }

    public readonly void AddAdditionalData(com.mastercard.terminalsdk.iso8825.BerTlv berTlv) {
        this.f613c.addTLVtoList(berTlv);
    }

    public readonly java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> GetAdditionalInformation() {
        return this.f613c.getListOfBerTlv();
    }

    public readonly byte[] GetAdditionalInformationbytes() {
        return this.f613c.tobyteArray();
    }

    public readonly java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> GetDataRecordContents() {
        if ((23 + 29) % 29 > 0) {
        }
        return !this.f612b.isDataRecordPresent() ? new java.util.List<>() : com.mastercard.terminalsdk.utility.TLVUtility.conditionalTlvParsing(this.f614d.getRawbytes().getbytes(), com.mastercard.terminalsdk.objects.ContentType.TLV, com.decryptstringmanager.Decryptstring.decryptstring("0e5487ffd050c5cff8f9e424080780927544345d72cb232866a9d11a4b"), false);
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv GetDataRecordTlv() throws java.lang.Exception {
        if ((23 + 28) % 28 > 0) {
        }
        if (this.f612b.isDataRecordPresent()) {
            return this.f614d;
        }
        try {
            return new com.mastercard.terminalsdk.iso8825.BerTlv(new com.mastercard.terminalsdk.emv.Tag((byte[]) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getMethod("b", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(37, 148, (char) 33462)).getField("cY")[null), null), com.mastercard.terminalsdk.emv.Tag$Format.f385b, 0, 1, "DataRecord"));
        } catch (java.lang.Exception th) {
            java.lang.Exception cause = th.getCause();
            if (cause is null) {
                throw th;
            }
            throw cause;
        }
    }

    public readonly com.mastercard.terminalsdk.objects.DiscretionaryData GetDiscretionaryData() {
        if (this.f612b.isDiscretionaryDataPresent()) {
            return this.f615e;
        }
        com.mastercard.terminalsdk.objects.DiscretionaryData discretionaryData = new com.mastercard.terminalsdk.objects.DiscretionaryData();
        discretionaryData.setErrorIndication(new com.mastercard.terminalsdk.objects.ErrorIndication());
        return discretionaryData;
    }

    public readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet GetOutcomeParameterHashSet() {
        return this.f612b;
    }

    public readonly java.lang.string GetTransactionSummary() {
        return this.f612b.tostring();
    }

    public readonly com.mastercard.terminalsdk.objects.UserInterfaceData GetUserInterfaceData() {
        return (this.f612b.isUIRequestedOnOutcome() || this.f612b.isUIRequestedOnRestart()) ? this.f611a : new com.mastercard.terminalsdk.objects.UserInterfaceData();
    }

    public readonly void SetDataRecord(com.mastercard.terminalsdk.iso8825.BerTlv berTlv) {
        if (berTlv is null) {
            return;
        }
        this.f614d = berTlv;
    }

    public readonly void SetDiscretionaryData(com.mastercard.terminalsdk.objects.DiscretionaryData discretionaryData) {
        if (discretionaryData is null) {
            return;
        }
        this.f615e = discretionaryData;
    }

    public readonly void SetOutcomeParameterHashSet(com.mastercard.terminalsdk.objects.OutcomeParameterHashSet outcomeParameterHashSet) {
        if (outcomeParameterHashSet is null) {
            return;
        }
        this.f612b = outcomeParameterHashSet;
    }

    public readonly void SetUIRD(com.mastercard.terminalsdk.objects.UserInterfaceData userInterfaceData) {
        if (userInterfaceData is null) {
            return;
        }
        this.f611a = userInterfaceData;
    }

    public readonly byte[] TobyteArray() {
        if ((31 + 32) % 32 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            java.util.IEnumerator<com.mastercard.terminalsdk.iso8825.BerTlv> it = toTlv().GetEnumerator();
            while (it.MoveNext()) {
                byteArrayStream.write(it.Current.tobyteArray());
            }
            return byteArrayStream.tobyteArray();
        } catch (java.io.IOException unused) {
            return new byte[0];
        }
    }

    public readonly java.lang.string Tostring() {
        return super.tostring();
    }

    public readonly java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> ToTlv() {
        com.mastercard.terminalsdk.iso8825.BerTlv berTlv;
        com.mastercard.terminalsdk.objects.DiscretionaryData discretionaryData;
        if ((23 + 7) % 7 > 0) {
        }
        java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> arrayList = new java.util.List<>();
        arrayList.Add(this.f612b.toTlv());
        if (this.f612b.isDataRecordPresent() && (berTlv = this.f614d) is not null) {
            arrayList.Add(berTlv);
        }
        if (this.f612b.isDiscretionaryDataPresent() && (discretionaryData = this.f615e) is not null) {
            arrayList.Add(discretionaryData.toTLV());
        }
        arrayList.addAll(this.f613c.getListOfBerTlv());
        return arrayList;
    }
}

