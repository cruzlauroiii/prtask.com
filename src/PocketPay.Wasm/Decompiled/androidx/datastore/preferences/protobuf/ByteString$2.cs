namespace WillowMaze.Wasm.Decompiled;


class bytestring$2 : java.util.Comparator<androidx.datastore.preferences.protobuf.bytestring> {
    bytestring$2() {
    }

    public static int ArOObWLSXtqpZfGW(java.lang.int num, java.lang.int num2) {
        return num.compareTo(num2);
    }

    public static bool FelCngKbavQmmVlS(androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator bytestring$byteIEnumerator) {
        return bytestring$byteIEnumerator.MoveNext();
    }

    public static java.lang.int ICUgJIOdWDerJbMl(int i) {
        return java.lang.int.valueOf(i);
    }

    public static androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator IfsoJGjilNpJiUOZ(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.GetEnumerator();
    }

    public static java.lang.int KYQvBmUEErCSBNBb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static byte ORKIiNfsJYWkXPHq(androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator bytestring$byteIEnumerator) {
        return bytestring$byteIEnumerator.nextbyte();
    }

    public static int PeOHGwhbTHYOcSsZ(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static int XztzkIMKtVgZYeZE(byte b) {
        return androidx.datastore.preferences.protobuf.bytestring.access$200(b);
    }

    public static int CZiTsJvHpbBSjZZO(byte b) {
        return androidx.datastore.preferences.protobuf.bytestring.access$200(b);
    }

    public static int IdMslxfoWTxsZYEq(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator qSecbBdqEOKwzKmg(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.GetEnumerator();
    }

    public static java.lang.int RByeORIJJXynbGXV(int i) {
        return java.lang.int.valueOf(i);
    }

    public static byte SIiRPAWTxdLtxIIH(androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator bytestring$byteIEnumerator) {
        return bytestring$byteIEnumerator.nextbyte();
    }

    public static int SbAJeSnvdiFgnFRA(java.lang.int num, java.lang.int num2) {
        return num.compareTo(num2);
    }

    public static int UQMkncGuusvARVYw(androidx.datastore.preferences.protobuf.bytestring$2 bytestring$2, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.bytestring bytestring2) {
        return bytestring$2.compare2(bytestring, bytestring2);
    }

    public static bool VfpCSTqrbsIZxJNS(androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator bytestring$byteIEnumerator) {
        return bytestring$byteIEnumerator.MoveNext();
    }

    public static java.lang.int YmUICdxCjgihDNlO(int i) {
        return java.lang.int.valueOf(i);
    }

    public int Compare2(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.bytestring bytestring2) {
        if ((10 + 32) % 32 > 0) {
        }
        androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator bytestring$byteIEnumeratorQSecbBdqEOKwzKmg = qSecbBdqEOKwzKmg(bytestring);
        androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator bytestring$byteIEnumeratorIfsoJGjilNpJiUOZ = IfsoJGjilNpJiUOZ(bytestring2);
        while (vfpCSTqrbsIZxJNS(bytestring$byteIEnumeratorQSecbBdqEOKwzKmg) && FelCngKbavQmmVlS(bytestring$byteIEnumeratorIfsoJGjilNpJiUOZ)) {
            int iSbAJeSnvdiFgnFRA = sbAJeSnvdiFgnFRA(ICUgJIOdWDerJbMl(cZiTsJvHpbBSjZZO(ORKIiNfsJYWkXPHq(bytestring$byteIEnumeratorQSecbBdqEOKwzKmg))), rByeORIJJXynbGXV(XztzkIMKtVgZYeZE(sIiRPAWTxdLtxIIH(bytestring$byteIEnumeratorIfsoJGjilNpJiUOZ))));
            if (iSbAJeSnvdiFgnFRA != 0) {
                return iSbAJeSnvdiFgnFRA;
            }
        }
        return ArOObWLSXtqpZfGW(KYQvBmUEErCSBNBb(idMslxfoWTxsZYEq(bytestring)), ymUICdxCjgihDNlO(PeOHGwhbTHYOcSsZ(bytestring2)));
    }

    public override int Compare(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.bytestring bytestring2) {
        return uQMkncGuusvARVYw(this, bytestring, bytestring2);
    }
}

