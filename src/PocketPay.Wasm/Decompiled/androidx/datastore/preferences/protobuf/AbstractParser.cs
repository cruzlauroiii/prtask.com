namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractParser<MessageType : androidx.datastore.preferences.protobuf.MessageLite> : androidx.datastore.preferences.protobuf.Parser<MessageType> {
    private static readonly androidx.datastore.preferences.protobuf.ExtensionRegistryLite EMPTY_REGISTRY = pHjPIqIeEohYxsiE();

    public static androidx.datastore.preferences.protobuf.MessageLite AkwxnVmrZTyhlmJw(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite BufWrMYqbstLQVSq(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return abstractParser.checkMessageInitialized(messageLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite CvMFamXWhiTWyKpf(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseDelimitedFrom(inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite CxZYpzVzAqOXKBKC(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr) {
        return abstractParser.parseFrom(bArr);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite DBurhbQnlFQUSvcK(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(bArr, i, i2, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite DCUwbjWLzzrpVMnd(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialDelimitedFrom(inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite DNaeHcLtXTkVZyvg(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite DVgJhvstiGrVmPtC(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite DXAPzxgoRlGHdrph(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return abstractParser.parseFrom(bytestring);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite DgIOdTROPdauHMTA(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.nio.byteBuffer byteBuffer) {
        return abstractParser.parseFrom(byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite DyRrkdulBtYNadgT(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream) {
        return abstractParser.parseFrom(inputStream);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite EghUlAlPFVmFSFPw(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, int i, int i2) {
        return abstractParser.parsePartialFrom(bArr, i, i2);
    }

    public static void FGxkEuAquVfmGlis(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream.checkLastTagWas(i);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite FqtPYJCgEsJuGcdX(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite GeRKplPuFdneIQGG(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.UninitializedMessageException JxPhdOqzDmugqPvX(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite) {
        return abstractMessageLite.newUninitializedMessageException();
    }

    public static androidx.datastore.preferences.protobuf.MessageLite LaXuBOTLygXkDELW(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(inputStream, extensionRegistryLite);
    }

    public static java.lang.object MLZyfetBFdcunHbk(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite MWflEPItHXgLOkIT(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite MkOOyVVIJfjjWzSs(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite NfdBEWBrgVnQZwVG(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return abstractParser.checkMessageInitialized(messageLite);
    }

    public static androidx.datastore.preferences.protobuf.UninitializedMessageException NxRyMyrJSiqkOeRP(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return abstractParser.newUninitializedMessageException(messageLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite ODGUyFTAYINcQEOw(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream QYPeslJFJHysQmFv(byte[] bArr, int i, int i2) {
        return androidx.datastore.preferences.protobuf.CodedStream.newInstance(bArr, i, i2);
    }

    public static bool QYYpcqoYzthVsAFU(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return messageLite.isInitialized();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream QdSYSVCuFVOQQfCn(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.newCodedInput();
    }

    public static int QpMhyNpLjYzsvoEz(int i, java.io.Stream inputStream) {
        return androidx.datastore.preferences.protobuf.CodedStream.readRawVarint32(i, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException RZsleBIicfYiIjiW(androidx.datastore.preferences.protobuf.InvalidProtocolBufferException invalidProtocolBufferException, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return invalidProtocolBufferException.setUnfinishedMessage(messageLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite RsbDnsoGUDFXzqrC(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite TKIRHFlIkhreMqqO(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream) {
        return abstractParser.parsePartialFrom(inputStream);
    }

    public static java.lang.object TgDJlUWmhBiECJWJ(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite UVMBjzddpqzhdUMC(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseDelimitedFrom(inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite UrqerTvIkoAUGyxX(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return abstractParser.checkMessageInitialized(messageLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite VfhNiSfnlZWRSOyS(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite VlrflRWTjBFDMTXn(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(bArr, i, i2, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite XXqVaUPCcELRhSmG(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(bytestring, extensionRegistryLite);
    }

    public static void YHpqTfxcjXFAdsqu(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream.checkLastTagWas(i);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite YhtTUlafnSfZPmdn(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(bArr, i, i2, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite YoxbaTAZhkejHrqQ(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite ZLuTDpOzqaBGlMjf(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite AOdgFwmBUuPpguqA(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return abstractParser.checkMessageInitialized(messageLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite BRpwgLCAlvKxXyFd(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialDelimitedFrom(inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite BjRKQAZTjOHrHaWC(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr) {
        return abstractParser.parsePartialFrom(bArr);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite CJsftDNGECfezhHF(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(bArr, i, i2, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException CWPPkPykckcAcrsM(androidx.datastore.preferences.protobuf.UninitializedMessageException uninitializedMessageException) {
        return uninitializedMessageException.asInvalidProtocolBufferException();
    }

    private MessageType CheckMessageInitialized(MessageType messagetype) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (messagetype is null || QYYpcqoYzthVsAFU(messagetype)) {
            return messagetype;
        }
        throw fnIfDwBYJYJrKNZq(cWPPkPykckcAcrsM(NxRyMyrJSiqkOeRP(this, messagetype)), messagetype);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream DCStonBZWcPKCcXB(java.io.Stream inputStream) {
        return androidx.datastore.preferences.protobuf.CodedStream.newInstance(inputStream);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ECOBHDBtFJlVYJRa(androidx.datastore.preferences.protobuf.InvalidProtocolBufferException invalidProtocolBufferException, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return invalidProtocolBufferException.setUnfinishedMessage(messageLite);
    }

    public static java.lang.object EehQarJxVMdPZEgf(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite FIgCRXPKKmKmqHtO(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return abstractParser.parsePartialFrom(codedStream);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException FnIfDwBYJYJrKNZq(androidx.datastore.preferences.protobuf.InvalidProtocolBufferException invalidProtocolBufferException, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return invalidProtocolBufferException.setUnfinishedMessage(messageLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite GEfidpCuOvhzjWIn(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(bArr, i, i2, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite GtKnRaHViHlkXcns(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream) {
        return abstractParser.parsePartialDelimitedFrom(inputStream);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite IIFtfSJDPJphrFxn(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite IeILhVuHzRisQCZc(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return abstractParser.checkMessageInitialized(messageLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite ItAgwTokqZQXwSol(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite IvNVDjDuUbBFBUmO(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(bArr, i, i2, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException LXfRzBvnfAZGWoph(androidx.datastore.preferences.protobuf.InvalidProtocolBufferException invalidProtocolBufferException, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return invalidProtocolBufferException.setUnfinishedMessage(messageLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite LdtPxAmNLiunSUlF(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return abstractParser.parsePartialFrom(bytestring);
    }

    public static void MOsIZyqfWRdPFzgY(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream.checkLastTagWas(i);
    }

    private androidx.datastore.preferences.protobuf.UninitializedMessageException NewUninitializedMessageException(MessageType messagetype) {
        return !(messagetype is androidx.datastore.preferences.protobuf.AbstractMessageLite) ? new androidx.datastore.preferences.protobuf.UninitializedMessageException(messagetype) : JxPhdOqzDmugqPvX((androidx.datastore.preferences.protobuf.AbstractMessageLite) messagetype);
    }

    public static java.lang.object NhlgcNZwxFtzMSjE(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite PGjBvfCJjUOEKpjU(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialDelimitedFrom(inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.ExtensionRegistryLite PHjPIqIeEohYxsiE() {
        return androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry();
    }

    public static int PXMdsAKpSIFKraAT(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static androidx.datastore.preferences.protobuf.MessageLite RAEFVzMLQDsElMzj(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, java.io.Stream inputStream) {
        return abstractParser.parseDelimitedFrom(inputStream);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite ROcaEYjVnechnLBm(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return abstractParser.parseFrom(codedStream);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite RvxWdskgoPrGjJcT(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(bArr, i, i2, extensionRegistryLite);
    }

    public static java.lang.object SKWWzBxjRBfpVtmt(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException TbjWLJiYyaLMpgdn(androidx.datastore.preferences.protobuf.InvalidProtocolBufferException invalidProtocolBufferException, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return invalidProtocolBufferException.setUnfinishedMessage(messageLite);
    }

    public static java.lang.object VmwaQeukddCLuPkD(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream VupPyBEfHuRQTJfF(java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.CodedStream.newInstance(byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite WKteLxyCbTWjxuwe(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return abstractParser.checkMessageInitialized(messageLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite XBVjeoHEPVdMiSbc(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite XSGRUbsusjXxwnJa(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parsePartialFrom(bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite ZPOOZbWwbEBRuhHj(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, int i, int i2) {
        return abstractParser.parseFrom(bArr, i, i2);
    }

    public static void ZinrOUSiVbZTqYNX(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream.checkLastTagWas(i);
    }

    public static androidx.datastore.preferences.protobuf.MessageLite ZsPSWJiNWqLFirPz(androidx.datastore.preferences.protobuf.AbstractParser abstractParser, byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return abstractParser.parseFrom(bArr, i, i2, extensionRegistryLite);
    }

    public override MessageType ParseDelimitedFrom(java.io.Stream inputStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) UVMBjzddpqzhdUMC(this, inputStream, EMPTY_REGISTRY);
    }

    public override MessageType ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) UrqerTvIkoAUGyxX(this, bRpwgLCAlvKxXyFd(this, inputStream, extensionRegistryLite));
    }

    public override java.lang.object ParseDelimitedFrom(java.io.Stream inputStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return rAEFVzMLQDsElMzj(this, inputStream);
    }

    public override java.lang.object ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return CvMFamXWhiTWyKpf(this, inputStream, extensionRegistryLite);
    }

    public override MessageType ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) DVgJhvstiGrVmPtC(this, bytestring, EMPTY_REGISTRY);
    }

    public override MessageType ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) NfdBEWBrgVnQZwVG(this, XXqVaUPCcELRhSmG(this, bytestring, extensionRegistryLite));
    }

    public override MessageType ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) DNaeHcLtXTkVZyvg(this, codedStream, EMPTY_REGISTRY);
    }

    public override MessageType ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) BufWrMYqbstLQVSq(this, (androidx.datastore.preferences.protobuf.MessageLite) MLZyfetBFdcunHbk(this, codedStream, extensionRegistryLite));
    }

    public override MessageType ParseFrom(java.io.Stream inputStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) LaXuBOTLygXkDELW(this, inputStream, EMPTY_REGISTRY);
    }

    public override MessageType ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) ieILhVuHzRisQCZc(this, VfhNiSfnlZWRSOyS(this, inputStream, extensionRegistryLite));
    }

    public override MessageType ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) GeRKplPuFdneIQGG(this, byteBuffer, EMPTY_REGISTRY);
    }

    public override MessageType ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        androidx.datastore.preferences.protobuf.CodedStream codedStreamVupPyBEfHuRQTJfF = vupPyBEfHuRQTJfF(byteBuffer);
        androidx.datastore.preferences.protobuf.MessageLite messageLite = (androidx.datastore.preferences.protobuf.MessageLite) eehQarJxVMdPZEgf(this, codedStreamVupPyBEfHuRQTJfF, extensionRegistryLite);
        try {
            FGxkEuAquVfmGlis(codedStreamVupPyBEfHuRQTJfF, 0);
            return (MessageType) wKteLxyCbTWjxuwe(this, messageLite);
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            throw tbjWLJiYyaLMpgdn(e, messageLite);
        }
    }

    public override MessageType ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) xBVjeoHEPVdMiSbc(this, bArr, EMPTY_REGISTRY);
    }

    public override MessageType ParseFrom(byte[] bArr, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) rvxWdskgoPrGjJcT(this, bArr, i, i2, EMPTY_REGISTRY);
    }

    public override MessageType ParseFrom(byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) aOdgFwmBUuPpguqA(this, VlrflRWTjBFDMTXn(this, bArr, i, i2, extensionRegistryLite));
    }

    public override MessageType ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((9 + 4) % 4 > 0) {
        }
        return (MessageType) zsPSWJiNWqLFirPz(this, bArr, 0, bArr.length, extensionRegistryLite);
    }

    public override java.lang.object ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return DXAPzxgoRlGHdrph(this, bytestring);
    }

    public override java.lang.object ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return MkOOyVVIJfjjWzSs(this, bytestring, extensionRegistryLite);
    }

    public override java.lang.object ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return rOcaEYjVnechnLBm(this, codedStream);
    }

    public override java.lang.object ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return iIFtfSJDPJphrFxn(this, codedStream, extensionRegistryLite);
    }

    public override java.lang.object ParseFrom(java.io.Stream inputStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return DyRrkdulBtYNadgT(this, inputStream);
    }

    public override java.lang.object ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return RsbDnsoGUDFXzqrC(this, inputStream, extensionRegistryLite);
    }

    public override java.lang.object ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return DgIOdTROPdauHMTA(this, byteBuffer);
    }

    public override java.lang.object ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return ODGUyFTAYINcQEOw(this, byteBuffer, extensionRegistryLite);
    }

    public override java.lang.object ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return CxZYpzVzAqOXKBKC(this, bArr);
    }

    public override java.lang.object ParseFrom(byte[] bArr, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return zPOOZbWwbEBRuhHj(this, bArr, i, i2);
    }

    public override java.lang.object ParseFrom(byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return DBurhbQnlFQUSvcK(this, bArr, i, i2, extensionRegistryLite);
    }

    public override java.lang.object ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return itAgwTokqZQXwSol(this, bArr, extensionRegistryLite);
    }

    public override MessageType ParsePartialDelimitedFrom(java.io.Stream inputStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) DCUwbjWLzzrpVMnd(this, inputStream, EMPTY_REGISTRY);
    }

    public override MessageType ParsePartialDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((25 + 9) % 9 > 0) {
        }
        try {
            int iPXMdsAKpSIFKraAT = pXMdsAKpSIFKraAT(inputStream);
            if (iPXMdsAKpSIFKraAT == -1) {
                return null;
            }
            return (MessageType) FqtPYJCgEsJuGcdX(this, new androidx.datastore.preferences.protobuf.AbstractMessageLite$Builder$LimitedStream(inputStream, QpMhyNpLjYzsvoEz(iPXMdsAKpSIFKraAT, inputStream)), extensionRegistryLite);
        } catch (java.io.IOException e) {
            throw new androidx.datastore.preferences.protobuf.InvalidProtocolBufferException(e);
        }
    }

    public override java.lang.object ParsePartialDelimitedFrom(java.io.Stream inputStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return gtKnRaHViHlkXcns(this, inputStream);
    }

    public override java.lang.object ParsePartialDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return pGjBvfCJjUOEKpjU(this, inputStream, extensionRegistryLite);
    }

    public override MessageType ParsePartialFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) YoxbaTAZhkejHrqQ(this, bytestring, EMPTY_REGISTRY);
    }

    public override MessageType ParsePartialFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        androidx.datastore.preferences.protobuf.CodedStream codedStreamQdSYSVCuFVOQQfCn = QdSYSVCuFVOQQfCn(bytestring);
        MessageType messagetype = (MessageType) sKWWzBxjRBfpVtmt(this, codedStreamQdSYSVCuFVOQQfCn, extensionRegistryLite);
        try {
            YHpqTfxcjXFAdsqu(codedStreamQdSYSVCuFVOQQfCn, 0);
            return messagetype;
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            throw lXfRzBvnfAZGWoph(e, messagetype);
        }
    }

    public override MessageType ParsePartialFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) vmwaQeukddCLuPkD(this, codedStream, EMPTY_REGISTRY);
    }

    public override MessageType ParsePartialFrom(java.io.Stream inputStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) MWflEPItHXgLOkIT(this, inputStream, EMPTY_REGISTRY);
    }

    public override MessageType ParsePartialFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        androidx.datastore.preferences.protobuf.CodedStream codedStreamDCStonBZWcPKCcXB = dCStonBZWcPKCcXB(inputStream);
        MessageType messagetype = (MessageType) nhlgcNZwxFtzMSjE(this, codedStreamDCStonBZWcPKCcXB, extensionRegistryLite);
        try {
            zinrOUSiVbZTqYNX(codedStreamDCStonBZWcPKCcXB, 0);
            return messagetype;
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            throw RZsleBIicfYiIjiW(e, messagetype);
        }
    }

    public override MessageType ParsePartialFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((21 + 2) % 2 > 0) {
        }
        return (MessageType) cJsftDNGECfezhHF(this, bArr, 0, bArr.length, EMPTY_REGISTRY);
    }

    public override MessageType ParsePartialFrom(byte[] bArr, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (MessageType) gEfidpCuOvhzjWIn(this, bArr, i, i2, EMPTY_REGISTRY);
    }

    public override MessageType ParsePartialFrom(byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        androidx.datastore.preferences.protobuf.CodedStream codedStreamQYPeslJFJHysQmFv = QYPeslJFJHysQmFv(bArr, i, i2);
        MessageType messagetype = (MessageType) TgDJlUWmhBiECJWJ(this, codedStreamQYPeslJFJHysQmFv, extensionRegistryLite);
        try {
            mOsIZyqfWRdPFzgY(codedStreamQYPeslJFJHysQmFv, 0);
            return messagetype;
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            throw eCOBHDBtFJlVYJRa(e, messagetype);
        }
    }

    public override MessageType ParsePartialFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((32 + 20) % 20 > 0) {
        }
        return (MessageType) YhtTUlafnSfZPmdn(this, bArr, 0, bArr.length, extensionRegistryLite);
    }

    public override java.lang.object ParsePartialFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return ldtPxAmNLiunSUlF(this, bytestring);
    }

    public override java.lang.object ParsePartialFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return xSGRUbsusjXxwnJa(this, bytestring, extensionRegistryLite);
    }

    public override java.lang.object ParsePartialFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return fIgCRXPKKmKmqHtO(this, codedStream);
    }

    public override java.lang.object ParsePartialFrom(java.io.Stream inputStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return TKIRHFlIkhreMqqO(this, inputStream);
    }

    public override java.lang.object ParsePartialFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return ZLuTDpOzqaBGlMjf(this, inputStream, extensionRegistryLite);
    }

    public override java.lang.object ParsePartialFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return bjRKQAZTjOHrHaWC(this, bArr);
    }

    public override java.lang.object ParsePartialFrom(byte[] bArr, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return EghUlAlPFVmFSFPw(this, bArr, i, i2);
    }

    public override java.lang.object ParsePartialFrom(byte[] bArr, int i, int i2, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return ivNVDjDuUbBFBUmO(this, bArr, i, i2, extensionRegistryLite);
    }

    public override java.lang.object ParsePartialFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return AkwxnVmrZTyhlmJw(this, bArr, extensionRegistryLite);
    }
}

