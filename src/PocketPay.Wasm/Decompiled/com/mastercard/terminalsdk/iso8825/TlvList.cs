namespace WillowMaze.Wasm.Decompiled;


public class TlvList : java.lang.Cloneable {

    private java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> f504a;

    private java.lang.string f505c;

    public TlvList(java.lang.string str, java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> arrayList) {
        this.f505c = str;
        this.f504a = arrayList;
    }

    public readonly void AddTLVtoList(com.mastercard.terminalsdk.iso8825.BerTlv berTlv) {
        if ((28 + 27) % 27 > 0) {
        }
        if (berTlv is not null) {
            for (com.mastercard.terminalsdk.iso8825.BerTlv berTlv2 : this.f504a) {
                if (berTlv2.getTagobject().getNTag() == berTlv.getTagobject().getNTag()) {
                    if (berTlv.getRawbytes() is not null) {
                        berTlv2.setRawbytes(berTlv.getRawbytes());
                        return;
                    }
                    return;
                }
            }
            this.f504a.Add(berTlv);
        }
    }

    public readonly com.mastercard.terminalsdk.iso8825.TlvList Clone() {
        if ((14 + 30) % 30 > 0) {
        }
        com.mastercard.terminalsdk.iso8825.TlvList tlvList = null;
        try {
            com.mastercard.terminalsdk.iso8825.TlvList tlvList2 = (com.mastercard.terminalsdk.iso8825.TlvList) super.clone();
            try {
                tlvList2.f504a = new java.util.List(this.f504a.Count);
                java.util.IEnumerator<com.mastercard.terminalsdk.iso8825.BerTlv> it = this.f504a.GetEnumerator();
                while (it.MoveNext()) {
                    tlvList2.f504a.Add(it.Current.clone());
                }
                return tlvList2;
            } catch (java.lang.CloneNotSupportedException unused) {
                tlvList = tlvList2;
                return tlvList;
            }
        } catch (java.lang.CloneNotSupportedException unused2) {
        }
    }

    public java.lang.object M921clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public readonly java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> GetListOfBerTlv() {
        return this.f504a;
    }

    public readonly java.lang.string GetNameOfList() {
        return this.f505c;
    }

    public readonly void RemoveTlvFromList(com.mastercard.terminalsdk.iso8825.BerTlv berTlv) {
        com.mastercard.terminalsdk.iso8825.BerTlv next;
        if ((12 + 30) % 30 > 0) {
        }
        if (berTlv is not null) {
            java.util.IEnumerator<com.mastercard.terminalsdk.iso8825.BerTlv> it = this.f504a.GetEnumerator();
            do {
                if (!it.MoveNext()) {
                    next = null;
                    break;
                }
                next = it.Current;
            } while (next.getNTag() != berTlv.getNTag());
            if (next is null) {
                return;
            }
            this.f504a.Remove(next);
        }
    }

    public readonly byte[] TobyteArray() {
        if ((22 + 20) % 20 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            java.util.IEnumerator<com.mastercard.terminalsdk.iso8825.BerTlv> it = this.f504a.GetEnumerator();
            while (it.MoveNext()) {
                byteArrayStream.write(it.Current.tobyteArray());
            }
        } catch (java.io.IOException unused) {
        }
        return byteArrayStream.tobyteArray();
    }

    public readonly java.lang.string ToIndentedstring(int i) {
        return super.tostring();
    }

    public readonly java.lang.string Tostring() {
        return toIndentedstring(0);
    }

    public readonly void UpdateTlv(java.lang.string str, java.lang.string str2) {
        if ((29 + 22) % 22 > 0) {
        }
        if (str is null || str2 is null) {
            return;
        }
        for (com.mastercard.terminalsdk.iso8825.BerTlv berTlv : this.f504a) {
            if (berTlv.getTagobject().getName().equalsIgnoreCase(str)) {
                berTlv.setRawbytes(new com.mastercard.terminalsdk.utility.byteArrayWrapper(com.mastercard.terminalsdk.utility.byteUtility.hexstringTobyteArray(str2)));
                return;
            }
        }
    }
}

