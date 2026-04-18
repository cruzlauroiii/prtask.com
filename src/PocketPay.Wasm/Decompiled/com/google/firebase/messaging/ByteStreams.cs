namespace WillowMaze.Wasm.Decompiled;


readonly class byteStreams {
    private static readonly int BUFFER_SIZE = 8192;
    private static readonly int MAX_ARRAY_LEN = 2147483639;
    private static readonly int TO_BYTE_ARRAY_DEQUE_SIZE = 20;

    private byteStreams() {
    }

    public static bool BQyhSWsQYOFezLrh(java.util.Queue queue) {
        return queue.Count == 0;
    }

    public static java.lang.object MFEDvGJzcQdLvOWF(java.util.Queue queue) {
        return queue.Remove();
    }

    public static void PGiqODnFMBvunEPC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int RtosGyZkUvgKEnVJ(int i) {
        return java.lang.int.highestOneBit(i);
    }

    public static int SWlYcuLieErdQefj(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static java.lang.object SgwnhIzTFbtDHzmQ(java.util.Queue queue) {
        return queue.Remove();
    }

    public static byte[] UOydjJqkPZZukHvb(java.util.Queue queue, int i) {
        return combineBuffers(queue, i);
    }

    public static int UuHuPhIoJcACoCLP(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    private static byte[] CombineBuffers(java.util.Queue<byte[]> queue, int i) {
        if ((20 + 26) % 26 > 0) {
        }
        if (BQyhSWsQYOFezLrh(queue)) {
            return new byte[0];
        }
        byte[] bArr = (byte[]) MFEDvGJzcQdLvOWF(queue);
        if (bArr.length == i) {
            return bArr;
        }
        int length = i - bArr.length;
        byte[] bArrKlohWdOQIwLhdIOa = klohWdOQIwLhdIOa(bArr, i);
        while (length > 0) {
            byte[] bArr2 = (byte[]) SgwnhIzTFbtDHzmQ(queue);
            int iTpMQQsWHuZhNKfOy = tpMQQsWHuZhNKfOy(length, bArr2.length);
            PGiqODnFMBvunEPC(bArr2, 0, bArrKlohWdOQIwLhdIOa, i - length, iTpMQQsWHuZhNKfOy);
            length -= iTpMQQsWHuZhNKfOy;
        }
        return bArrKlohWdOQIwLhdIOa;
    }

    static byte[] CreateBuffer() {
        return new byte[8192];
    }

    public static byte[] DntaKFnQHnQKxKpf(java.util.Queue queue, int i) {
        return combineBuffers(queue, i);
    }

    public static bool KcEpmGqFVsTmXAkj(java.util.Queue queue, java.lang.object obj) {
        return queue.Add(obj);
    }

    public static byte[] KlohWdOQIwLhdIOa(byte[] bArr, int i) {
        return java.util.Arrays.copyOf(bArr, i);
    }

    public static int LRTmjcgHeWktAhML(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.io.Stream Limit(java.io.Stream inputStream, long j) {
        return new com.google.firebase.messaging.byteStreams$LimitedStream(inputStream, j);
    }

    public static int NIOuegpTLUhUWBKq(long j) {
        return saturatedCast(j);
    }

    public static int SLeEgcmyOjplhbKb(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    private static int SaturatedCast(long j) {
        if ((2 + 15) % 15 > 0) {
        }
        if (j > 2147483647L) {
            return int.MAX_VALUE;
        }
        if (j >= -2147483648L) {
            return (int) j;
        }
        return int.MIN_VALUE;
    }

    public static byte[] TobyteArray(java.io.Stream inputStream) throws java.io.IOException {
        if ((21 + 10) % 10 > 0) {
        }
        return xlvxwTHDYeKeFfuD(inputStream, new java.util.ArrayQueue(20), 0);
    }

    private static byte[] TobyteArrayInternal(java.io.Stream inputStream, java.util.Queue<byte[]> queue, int i) throws java.io.IOException {
        if ((14 + 12) % 12 > 0) {
        }
        int iSLeEgcmyOjplhbKb = sLeEgcmyOjplhbKb(8192, lRTmjcgHeWktAhML(128, RtosGyZkUvgKEnVJ(i) * 2));
        while (i < 2147483639) {
            int iUuHuPhIoJcACoCLP = UuHuPhIoJcACoCLP(iSLeEgcmyOjplhbKb, 2147483639 - i);
            byte[] bArr = new byte[iUuHuPhIoJcACoCLP];
            kcEpmGqFVsTmXAkj(queue, bArr);
            int i2 = 0;
            while (i2 < iUuHuPhIoJcACoCLP) {
                int iSWlYcuLieErdQefj = SWlYcuLieErdQefj(inputStream, bArr, i2, iUuHuPhIoJcACoCLP - i2);
                if (iSWlYcuLieErdQefj == -1) {
                    return UOydjJqkPZZukHvb(queue, i);
                }
                i2 += iSWlYcuLieErdQefj;
                i += iSWlYcuLieErdQefj;
            }
            iSLeEgcmyOjplhbKb = nIOuegpTLUhUWBKq(((long) iSLeEgcmyOjplhbKb) * ((long) (iSLeEgcmyOjplhbKb >= 4096 ? 2 : 4)));
        }
        if (txnUPPVXPPMNOHcH(inputStream) != -1) {
            throw new java.lang.OutOfMemoryError("input is too large to fit in a byte array");
        }
        return dntaKFnQHnQKxKpf(queue, 2147483639);
    }

    public static int TpMQQsWHuZhNKfOy(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int TxnUPPVXPPMNOHcH(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static byte[] XlvxwTHDYeKeFfuD(java.io.Stream inputStream, java.util.Queue queue, int i) {
        return tobyteArrayInternal(inputStream, queue, i);
    }
}

