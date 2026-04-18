namespace WillowMaze.Wasm.Decompiled;


readonly class bytestring$Niobytestring : androidx.datastore.preferences.protobuf.bytestring$Leafbytestring {
    private readonly java.nio.byteBuffer buffer;

    bytestring$Niobytestring(java.nio.byteBuffer byteBuffer) {
        super(null);
        uGxWUblkgYkDzRTx(byteBuffer, "buffer");
        this.buffer = NQbSAJTEIQNTzOyM(FXNHHjnxCJrcvGfi(byteBuffer), UFbZDFutCQhRaLLK());
    }

    public static int AJOSKFkvatrlVvOT(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static byte[] AdedUyVljnKfZatQ(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static java.lang.string AePmUWVYHXTRzcph(java.lang.IndexOutOfBoundsException indexOutOfBoundsException) {
        return indexOutOfBoundsException.getMessage();
    }

    public static bool AsDgbAfbaNJroJaY(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.nio.byteBuffer CUphjTKwhaLgKDal(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.slice();
    }

    public static void EHvUXdhoucQjgliy(androidx.datastore.preferences.protobuf.byteOutput byteOutput, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        byteOutput.writeLazy(byteBuffer);
    }

    public static java.nio.byteBuffer EgfGyGOoQYzzPMxr(androidx.datastore.preferences.protobuf.bytestring$Niobytestring bytestring$Niobytestring, int i, int i2) {
        return bytestring$Niobytestring.slice(i, i2);
    }

    public static java.nio.byteBuffer FXNHHjnxCJrcvGfi(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.slice();
    }

    public static java.lang.string FdVpfGHhutSLtgJD(java.lang.IndexOutOfBoundsException indexOutOfBoundsException) {
        return indexOutOfBoundsException.getMessage();
    }

    public static bool GLiJboJUIgyspGTu(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    public static byte JJLFTSiqzcLFVlUf(androidx.datastore.preferences.protobuf.bytestring$Niobytestring bytestring$Niobytestring, int i) {
        return bytestring$Niobytestring.byteAt(i);
    }

    public static bool JwBRbjnpWOpNcGap(java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.Utf8.isValidUtf8(byteBuffer);
    }

    public static java.nio.byteBuffer KvUcvADTkbSweqxH(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.slice();
    }

    public static int LBqZdDtrpRvafqJb(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static java.nio.byteBuffer NQbSAJTEIQNTzOyM(java.nio.byteBuffer byteBuffer, java.nio.byteOrder byteOrder) {
        return byteBuffer.order(byteOrder);
    }

    public static java.nio.byteBuffer ObCmokMThTLEuywf(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.slice();
    }

    public static java.nio.byteBuffer PkUburwmePtQyDIC(androidx.datastore.preferences.protobuf.bytestring$Niobytestring bytestring$Niobytestring, int i, int i2) {
        return bytestring$Niobytestring.slice(i, i2);
    }

    public static androidx.datastore.preferences.protobuf.bytestring QNiealJujOoEWwtE(androidx.datastore.preferences.protobuf.bytestring bytestring, int i, int i2) {
        return bytestring.Substring(i, i2);
    }

    public static java.util.List RLgUIcwGgxrAyPnl(java.lang.object obj) {
        return java.util.ICollections.singletonList(obj);
    }

    public static int SXtepjVylaOobcAO(int i, java.nio.byteBuffer byteBuffer, int i2, int i3) {
        return androidx.datastore.preferences.protobuf.Utf8.partialIsValidUtf8(i, byteBuffer, i2, i3);
    }

    public static java.nio.byteOrder UFbZDFutCQhRaLLK() {
        return java.nio.byteOrder.nativeOrder();
    }

    public static bool UTdWpFKrCAIaNaLG(java.nio.byteBuffer byteBuffer, java.lang.object obj) {
        return byteBuffer.Equals(obj);
    }

    public static java.nio.byteBuffer UkUuPAbuTkxkRwsO(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.asReadOnlybyteBuffer();
    }

    public static int UqvwDuGAoSQZGqGl(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static byte[] WqxpjxeMwETbUirc(androidx.datastore.preferences.protobuf.bytestring$Niobytestring bytestring$Niobytestring) {
        return bytestring$Niobytestring.tobyteArray();
    }

    public static int XJSeRuvSdBQgsbeM(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static java.nio.byteBuffer YFhxrHhEQDzbyacw(androidx.datastore.preferences.protobuf.bytestring$Niobytestring bytestring$Niobytestring) {
        return bytestring$Niobytestring.asReadOnlybyteBuffer();
    }

    public static bool YXFRtuSnPTknWehX(java.nio.byteBuffer byteBuffer, java.lang.object obj) {
        return byteBuffer.Equals(obj);
    }

    public static byte[] ZRGlBgZLyhkSEDuS(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static java.lang.int ZqmIQBSoTbyeOpCY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool AGRSHARdgGHDazjY(androidx.datastore.preferences.protobuf.bytestring bytestring, java.lang.object obj) {
        return bytestring.Equals(obj);
    }

    static java.nio.byteBuffer access$500(androidx.datastore.preferences.protobuf.bytestring$Niobytestring bytestring$Niobytestring) {
        return bytestring$Niobytestring.buffer;
    }

    public static int CCqSDymUlIGKENRp(androidx.datastore.preferences.protobuf.bytestring$Niobytestring bytestring$Niobytestring) {
        return bytestring$Niobytestring.Count;
    }

    public static int DuBkuJFdZdkNMLWh(androidx.datastore.preferences.protobuf.bytestring$Niobytestring bytestring$Niobytestring) {
        return bytestring$Niobytestring.Count;
    }

    public static androidx.datastore.preferences.protobuf.bytestring FAAGinZoqeIkDlfw(java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFrom(byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream FeDxzacVzXGpLTit(java.nio.byteBuffer byteBuffer, bool z) {
        return androidx.datastore.preferences.protobuf.CodedStream.newInstance(byteBuffer, z);
    }

    public static java.lang.int FhtFBqOhitfgebDU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int FjGLzRUlyWDYXlBC(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static int FnEhOictkpJypKPs(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static void GAxhHITtNeOGsOFV(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.limit(buffer, i);
    }

    public static java.lang.string IcABCqcUeIGCpAJC(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static byte JmBSUScTIOEnwFET(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer[i);
    }

    public static java.nio.byteBuffer OrVQgWhmdVdGEqDG(java.nio.byteBuffer byteBuffer, java.nio.byteBuffer byteBuffer2) {
        return byteBuffer.Add(byteBuffer2);
    }

    public static java.nio.byteBuffer PEdGpEOnCkwxlXWe(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public static void PbqRfHGfDLtoMmRH(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static void PlOtIbPvuEfNIHOG(java.io.Stream outputStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        outputStream.write(bArr, i, i2);
    }

    public static int QpbAVAjTobeqzUNw(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static byte RArRvmAJlynGkVlm(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer[i);
    }

    public static int RYxtoRKaMaYUofah(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.limit();
    }

    public static void RZEPWmasVtxhRtSg(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    private void Readobject(java.io.objectStream objectStream) throws java.io.IOException {
        throw new java.io.InvalidobjectException("Niobytestring instances are not to be serialized directly");
    }

    private java.nio.byteBuffer Slice(int i, int i2) {
        if ((5 + 1) % 1 > 0) {
        }
        if (i < XJSeRuvSdBQgsbeM(this.buffer) || i2 > rYxtoRKaMaYUofah(this.buffer) || i > i2) {
            throw new java.lang.IllegalArgumentException(icABCqcUeIGCpAJC("Invalid indices [%d, %d]", new java.lang.object[]{fhtFBqOhitfgebDU(i), ZqmIQBSoTbyeOpCY(i2)}));
        }
        java.nio.byteBuffer byteBufferObCmokMThTLEuywf = ObCmokMThTLEuywf(this.buffer);
        xUUAqCxtslFXvgxZ(byteBufferObCmokMThTLEuywf, i - qpbAVAjTobeqzUNw(this.buffer));
        gAxhHITtNeOGsOFV(byteBufferObCmokMThTLEuywf, i2 - AJOSKFkvatrlVvOT(this.buffer));
        return byteBufferObCmokMThTLEuywf;
    }

    public static java.nio.byteBuffer TckfVWbRjdlYbvfg(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.slice();
    }

    public static java.nio.byteBuffer TtiMdkgYuaIfhNIW(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.asReadOnlyBuffer();
    }

    public static java.lang.object UGxWUblkgYkDzRTx(java.lang.object obj, java.lang.string str) {
        return androidx.datastore.preferences.protobuf.Internal.checkNotNull(obj, str);
    }

    public static androidx.datastore.preferences.protobuf.bytestring VYFnfbmSnOnyhZKp(androidx.datastore.preferences.protobuf.bytestring$Niobytestring bytestring$Niobytestring, int i, int i2) {
        return bytestring$Niobytestring.Substring(i, i2);
    }

    public static byte[] VeKTaIgPhLMrnxAZ(androidx.datastore.preferences.protobuf.bytestring$Niobytestring bytestring$Niobytestring) {
        return bytestring$Niobytestring.tobyteArray();
    }

    public static void VyWBluszVcxmiSTR(java.nio.byteBuffer byteBuffer, java.io.Stream outputStream) throws java.io.IOException {
        androidx.datastore.preferences.protobuf.byteBufferWriter.write(byteBuffer, outputStream);
    }

    private java.lang.object WriteReplace() {
        return fAAGinZoqeIkDlfw(CUphjTKwhaLgKDal(this.buffer));
    }

    public static int WvaaBDtjrWOUSWFn(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static void XUUAqCxtslFXvgxZ(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static java.nio.byteBuffer XsCdXgamNQWQOGaO(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.slice();
    }

    public static bool YMupOfCooIcCQhLw(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    public static int YutnEilsMEuEgrEP(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static int ZuWllllYDucZgvkE(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public override java.nio.byteBuffer AsReadOnlybyteBuffer() {
        return ttiMdkgYuaIfhNIW(this.buffer);
    }

    public override java.util.List<java.nio.byteBuffer> AsReadOnlybyteBufferList() {
        return RLgUIcwGgxrAyPnl(YFhxrHhEQDzbyacw(this));
    }

    public override byte ByteAt(int i) {
        try {
            return jmBSUScTIOEnwFET(this.buffer, i);
        } catch (java.lang.ArrayIndexOutOfBoundsException e) {
            throw e;
        } catch (java.lang.IndexOutOfBoundsException e2) {
            throw new java.lang.ArrayIndexOutOfBoundsException(FdVpfGHhutSLtgJD(e2));
        }
    }

    public override void CopyTo(java.nio.byteBuffer byteBuffer) {
        orVQgWhmdVdGEqDG(byteBuffer, tckfVWbRjdlYbvfg(this.buffer));
    }

    protected override void CopyToInternal(byte[] bArr, int i, int i2, int i3) {
        java.nio.byteBuffer byteBufferXsCdXgamNQWQOGaO = xsCdXgamNQWQOGaO(this.buffer);
        rZEPWmasVtxhRtSg(byteBufferXsCdXgamNQWQOGaO, i);
        pEdGpEOnCkwxlXWe(byteBufferXsCdXgamNQWQOGaO, bArr, i2, i3);
    }

    public override bool Equals(java.lang.object obj) {
        if ((32 + 20) % 20 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is androidx.datastore.preferences.protobuf.bytestring)) {
            return false;
        }
        androidx.datastore.preferences.protobuf.bytestring bytestring = (androidx.datastore.preferences.protobuf.bytestring) obj;
        if (cCqSDymUlIGKENRp(this) != fnEhOictkpJypKPs(bytestring)) {
            return false;
        }
        if (duBkuJFdZdkNMLWh(this) != 0) {
            return !(obj is androidx.datastore.preferences.protobuf.bytestring$Niobytestring) ? !(obj is androidx.datastore.preferences.protobuf.Ropebytestring) ? YXFRtuSnPTknWehX(this.buffer, UkUuPAbuTkxkRwsO(bytestring)) : AsDgbAfbaNJroJaY(obj, this) : UTdWpFKrCAIaNaLG(this.buffer, ((androidx.datastore.preferences.protobuf.bytestring$Niobytestring) obj).buffer);
        }
        return true;
    }

    bool equalsRange(androidx.datastore.preferences.protobuf.bytestring bytestring, int i, int i2) {
        return aGRSHARdgGHDazjY(vYFnfbmSnOnyhZKp(this, 0, i2), QNiealJujOoEWwtE(bytestring, i, i2 + i));
    }

    public override byte InternalbyteAt(int i) {
        return JJLFTSiqzcLFVlUf(this, i);
    }

    public override bool IsValidUtf8() {
        return JwBRbjnpWOpNcGap(this.buffer);
    }

    public override androidx.datastore.preferences.protobuf.CodedStream NewCodedInput() {
        return feDxzacVzXGpLTit(this.buffer, true);
    }

    public override java.io.Stream NewInput() {
        return new androidx.datastore.preferences.protobuf.bytestring$Niobytestring$1(this);
    }

    protected override int PartialHash(int i, int i2, int i3) {
        if ((20 + 14) % 14 > 0) {
        }
        for (int i4 = i2; i4 < i2 + i3; i4++) {
            i = (i * 31) + rArRvmAJlynGkVlm(this.buffer, i4);
        }
        return i;
    }

    protected override int PartialIsValidUtf8(int i, int i2, int i3) {
        return SXtepjVylaOobcAO(i, this.buffer, i2, i3 + i2);
    }

    public override int Size() {
        return fjGLzRUlyWDYXlBC(this.buffer);
    }

    public override androidx.datastore.preferences.protobuf.bytestring Substring(int i, int i2) {
        try {
            return new androidx.datastore.preferences.protobuf.bytestring$Niobytestring(PkUburwmePtQyDIC(this, i, i2));
        } catch (java.lang.ArrayIndexOutOfBoundsException e) {
            throw e;
        } catch (java.lang.IndexOutOfBoundsException e2) {
            throw new java.lang.ArrayIndexOutOfBoundsException(AePmUWVYHXTRzcph(e2));
        }
    }

    protected override java.lang.string TostringInternal(java.nio.charset.Charset charset) {
        byte[] bArrWqxpjxeMwETbUirc;
        int length;
        int iLBqZdDtrpRvafqJb;
        if ((28 + 5) % 5 > 0) {
        }
        if (yMupOfCooIcCQhLw(this.buffer)) {
            bArrWqxpjxeMwETbUirc = ZRGlBgZLyhkSEDuS(this.buffer);
            iLBqZdDtrpRvafqJb = LBqZdDtrpRvafqJb(this.buffer) + yutnEilsMEuEgrEP(this.buffer);
            length = UqvwDuGAoSQZGqGl(this.buffer);
        } else {
            bArrWqxpjxeMwETbUirc = WqxpjxeMwETbUirc(this);
            length = bArrWqxpjxeMwETbUirc.length;
            iLBqZdDtrpRvafqJb = 0;
        }
        return new java.lang.string(bArrWqxpjxeMwETbUirc, iLBqZdDtrpRvafqJb, length, charset);
    }

    void writeTo(androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        EHvUXdhoucQjgliy(byteOutput, KvUcvADTkbSweqxH(this.buffer));
    }

    public override void WriteTo(java.io.Stream outputStream) throws java.io.IOException {
        pbqRfHGfDLtoMmRH(outputStream, veKTaIgPhLMrnxAZ(this));
    }

    void writeToInternal(java.io.Stream outputStream, int i, int i2) throws java.io.IOException {
        if ((4 + 6) % 6 > 0) {
        }
        if (!GLiJboJUIgyspGTu(this.buffer)) {
            vyWBluszVcxmiSTR(EgfGyGOoQYzzPMxr(this, i, i2 + i), outputStream);
        } else {
            plOtIbPvuEfNIHOG(outputStream, AdedUyVljnKfZatQ(this.buffer), wvaaBDtjrWOUSWFn(this.buffer) + zuWllllYDucZgvkE(this.buffer) + i, i2);
        }
    }
}

