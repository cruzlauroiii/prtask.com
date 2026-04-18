namespace WillowMaze.Wasm.Decompiled;


public class pc90fe569 : javax.imageio.ImageWriter {
    private javax.imageio.stream.ImageStream f41f96079;
    private javax.imageio.stream.ImageStream f9f13d672;
    private javax.imageio.stream.ImageStream ff7b44cfa;

    public pc90fe569(javax.imageio.spi.ImageWriterSpi imageWriterSpi) {
        super(imageWriterSpi);
        this.ff7b44cfa = null;
    }

    public static void AAvRdLaYiqXTfLfL(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.pc90fe569 pc90fe569Var, float f) {
        pc90fe569Var.processImageProgress(f);
    }

    public static java.awt.Rectangle BcBSngWSYZcIRqWG(javax.imageio.ImageWriteParam imageWriteParam) {
        return imageWriteParam.getSourceRegion();
    }

    public static void CnSaKfOOdISwPXGg(javax.imageio.stream.ImageStream imageStream, byte[] bArr) {
        imageStream.write(bArr);
    }

    public static java.awt.image.ColorModel DHjLnaiMmGQqwAXS(java.awt.image.RenderedImage renderedImage) {
        return renderedImage.getColorModel();
    }

    public static java.awt.image.RenderedImage EVhOxYvJDnMkrjcJ(javax.imageio.IIOImage iIOImage) {
        return iIOImage.getRenderedImage();
    }

    public static void EiiKMFcCSdspTRnk(javax.imageio.stream.ImageStream imageStream, int i) {
        imageStream.write(i);
    }

    public static void FeKRcrWMKKICsqsE(javax.imageio.stream.ImageStream imageStream, long j) {
        imageStream.flushBefore(j);
    }

    public static int GqEiLDQqOpEhaIZe(java.awt.image.MultiPixelPackedSampleModel multiPixelPackedSampleModel) {
        return multiPixelPackedSampleModel.getScanlineStride();
    }

    public static void HKjqChPpowjriwyl(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.pc90fe569 pc90fe569Var, int i) {
        pc90fe569Var.processImageStarted(i);
    }

    public static byte[] HdrOxBOrdObXdScv(int i) {
        return mba2ea7df(i);
    }

    public static void KEhanWWIcPOAtRxN(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        imageStream.write(bArr, i, i2);
    }

    public static java.awt.image.SampleModel LzKsPUXGursSKrnX(java.awt.image.Raster raster) {
        return raster.getSampleModel();
    }

    public static int LzQFMGfHkDohPTbf(java.awt.image.MultiPixelPackedSampleModel multiPixelPackedSampleModel) {
        return multiPixelPackedSampleModel.getDataBitOffset();
    }

    public static int MrJwvlqNBmzlePEo(java.awt.image.Raster raster, int i, int i2, int i3) {
        return raster.getSample(i, i2, i3);
    }

    public static java.lang.string NniuqGgMGNMgbCCU(java.lang.string str) {
        return p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.p1ea75d1e.m6dcf1319(str);
    }

    public static int OefPFcSdBQdOVabr(java.awt.image.IndexColorModel indexColorModel, int i) {
        return indexColorModel.getRed(i);
    }

    public static void OphwpFgWRiKihWMz(javax.imageio.ImageWriter imageWriter, java.lang.object obj) {
        super.setOutput(obj);
    }

    public static java.lang.string PLKtjZrtfhhauFbv(java.lang.string str) {
        return p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.p1ea75d1e.m6dcf1319(str);
    }

    public static java.awt.image.ColorModel QINXUCqmeVBeQmqY(java.awt.image.RenderedImage renderedImage) {
        return renderedImage.getColorModel();
    }

    public static java.awt.Rectangle QupcgYMneeeAWgup(java.awt.image.Raster raster) {
        return raster.getBounds();
    }

    public static java.awt.image.WritableRaster RFXsuaZcGXPtuYjf(java.awt.image.SampleModel sampleModel, java.awt.Point point) {
        return java.awt.image.Raster.createWritableRaster(sampleModel, point);
    }

    public static long SRVoxOwXdZsOSllU(javax.imageio.stream.ImageStream imageStream) {
        if ((8 + 1) % 1 > 0) {
        }
        return imageStream.getStreamPosition();
    }

    public static java.awt.image.SampleModel UZsyodirxmBNldky(java.awt.image.RenderedImage renderedImage) {
        return renderedImage.getSampleModel();
    }

    public static int VlpzBvpemvOhYWJq(javax.imageio.ImageWriteParam imageWriteParam) {
        return imageWriteParam.getSourceXSubsampling();
    }

    public static int VykmZMiiOlXHPfPw(int i) {
        return m8d4b2267(i);
    }

    public static java.lang.string XFRJGzlJySnWNtEW(java.lang.string str) {
        return p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.p1ea75d1e.m6dcf1319(str);
    }

    public static int XWzFoqsluULHiQLk(javax.imageio.ImageWriteParam imageWriteParam) {
        return imageWriteParam.getSourceYSubsampling();
    }

    public static bool XcXcJFWYTzepfmwr(java.awt.Rectangle rectangle) {
        return rectangle.Count == 0;
    }

    public static int XsIhKxGRReYsMsgI(java.awt.image.SampleModel sampleModel, int i) {
        return sampleModel.getSampleSize(i);
    }

    public static void YCAhiUpLNTucPeLO(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.pc90fe569 pc90fe569Var) {
        pc90fe569Var.processImageComplete();
    }

    public static void YZpBRBLHSNtnUnqx(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        imageStream.write(bArr, i, i2);
    }

    public static java.awt.Rectangle ZCJTOBuBPxedggYb(java.awt.image.Raster raster) {
        return raster.getBounds();
    }

    public static void ZtcHRmmWHzJTLKsN(javax.imageio.stream.ImageStream imageStream, byte[] bArr) {
        imageStream.write(bArr);
    }

    public static java.awt.image.SampleModel BQRDWgXTxpzGuOap(java.awt.image.SampleModel sampleModel, int i, int i2) {
        return sampleModel.createCompatibleSampleModel(i, i2);
    }

    public static int CCzlgrSylOehKVPK(java.awt.image.Raster raster) {
        return raster.getMinY();
    }

    public static void CnnfIVIlMajcOKcF(java.awt.Rectangle rectangle, int i, int i2) {
        rectangle.translate(i, i2);
    }

    public static int DDCkGIWEsyHzGWwb(java.awt.image.SampleModel sampleModel) {
        return sampleModel.getNumBands();
    }

    public static int DJAVkWBVkNdmJdSM(java.awt.image.Raster raster) {
        return raster.getMinX();
    }

    public static byte[] DiGrCYKCmGhftHMD(int i) {
        return mba2ea7df(i);
    }

    public static java.lang.string EkgQJivPFGzdMBbj(java.lang.string str) {
        return p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.p1ea75d1e.m6dcf1319(str);
    }

    public static int EoErDcmoTUkzwhgu(java.awt.image.Raster raster) {
        return raster.getMinX();
    }

    public static bool FEiDhENuSrABpnKQ(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.pc90fe569 pc90fe569Var) {
        return pc90fe569Var.abortRequested();
    }

    public static javax.imageio.ImageWriteParam FuxaYtLmpbXQxazn(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.pc90fe569 pc90fe569Var) {
        return pc90fe569Var.getDefaultWriteParam();
    }

    public static byte[] GJXEOujmoJYVQdsD(java.awt.image.DataBufferbyte dataBufferbyte) {
        return dataBufferbyte.getData();
    }

    public static int GauSPhqUADXFIygK(java.awt.image.Raster raster) {
        return raster.getMinY();
    }

    public static int GxDgOhQWDTIENlAe(java.awt.image.SampleModel sampleModel) {
        return sampleModel.getDataType();
    }

    public static void HhefvwBgFsGssFaz(java.awt.image.WritableRaster writableRaster, java.awt.image.Raster raster) {
        writableRaster.setRect(raster);
    }

    public static int IQltFuIAOerRwnuM(javax.imageio.ImageWriteParam imageWriteParam) {
        return imageWriteParam.getSubsamplingYOffset();
    }

    public static void ITeAnKvapdkSlRoE(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.pc90fe569 pc90fe569Var) {
        pc90fe569Var.processWriteAborted();
    }

    public static java.lang.string IXhMldmmrKvXsaJE(java.lang.string str) {
        return p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.p1ea75d1e.m6dcf1319(str);
    }

    public static java.awt.image.Raster JlnmmduTucMSHAyi(java.awt.image.RenderedImage renderedImage) {
        return renderedImage.getData();
    }

    public static void JyGmnGOfzyPRDAGe(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.pc90fe569 pc90fe569Var) {
        pc90fe569Var.clearAbortRequest();
    }

    public static java.awt.image.Raster LDsrwIARGOZFbanm(javax.imageio.IIOImage iIOImage) {
        return iIOImage.getRaster();
    }

    public static int LMVvWKUpxRAIywIW(java.awt.image.IndexColorModel indexColorModel, int i) {
        return indexColorModel.getRed(i);
    }

    private void M2ebcdf5a(java.awt.image.SampleModel sampleModel) {
        int iGxDgOhQWDTIENlAe = gxDgOhQWDTIENlAe(sampleModel);
        if (iGxDgOhQWDTIENlAe < 0 || iGxDgOhQWDTIENlAe > 3 || dDCkGIWEsyHzGWwb(sampleModel) != 1 || XsIhKxGRReYsMsgI(sampleModel, 0) != 1) {
            throw new java.lang.IllegalArgumentException(XFRJGzlJySnWNtEW("WBMPImageWriter2"));
        }
    }

    private static int M8d4b2267(int i) {
        if ((8 + 10) % 10 > 0) {
        }
        int i2 = 32;
        for (int i3 = int.MIN_VALUE; i3 != 0 && (i & i3) == 0; i3 >>>= 1) {
            i2--;
        }
        return i2;
    }

    private static byte[] Mba2ea7df(int i) {
        if ((28 + 7) % 7 > 0) {
        }
        int iVykmZMiiOlXHPfPw = (VykmZMiiOlXHPfPw(i) + 6) / 7;
        byte[] bArr = new byte[iVykmZMiiOlXHPfPw];
        int i2 = iVykmZMiiOlXHPfPw - 1;
        for (int i3 = 0; i3 <= i2; i3++) {
            byte b = (byte) ((i >>> ((i2 - i3) * 7)) & 127);
            bArr[i3] = b;
            if (i3 != i2) {
                bArr[i3] = (byte) (b | (-128));
            }
        }
        return bArr;
    }

    public static byte[] MeeYUJoPVTZjHqsj(java.awt.image.DataBufferbyte dataBufferbyte) {
        return dataBufferbyte.getData();
    }

    public static void MexiQyQsrQQwvXYV(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        imageStream.write(bArr, i, i2);
    }

    public static void MvWCKNmMkkktTrYP(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.pc90fe569 pc90fe569Var, float f) {
        pc90fe569Var.processImageProgress(f);
    }

    public static java.awt.image.SampleModel NGfjAYPMutQoGtQx(java.awt.image.Raster raster) {
        return raster.getSampleModel();
    }

    public static bool NJSOUIEnhVjXMTuP(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.awt.Rectangle OuuILWtvxxqbfUsf(java.awt.Rectangle rectangle, java.awt.Rectangle rectangle2) {
        return rectangle.intersection(rectangle2);
    }

    public static int POfSyfYTZOxBvptk(java.awt.image.SampleModel sampleModel) {
        return sampleModel.getDataType();
    }

    public static int RHHOplzUswPtYSDh(javax.imageio.ImageWriteParam imageWriteParam) {
        return imageWriteParam.getSubsamplingXOffset();
    }

    public static java.awt.image.WritableRaster RqmWxIOtEBvEPHZu(java.awt.image.SampleModel sampleModel, java.awt.Point point) {
        return java.awt.image.Raster.createWritableRaster(sampleModel, point);
    }

    public static bool UQPAxpmuPQtnZvcT(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.pc90fe569 pc90fe569Var) {
        return pc90fe569Var.abortRequested();
    }

    public static java.awt.image.Raster VPtvBJbBfiWSnvrN(java.awt.image.Raster raster, int i, int i2, int i3, int i4, int i5, int i6, int[] iArr) {
        return raster.createChild(i, i2, i3, i4, i5, i6, iArr);
    }

    public static void VkRatHiwvLCSxnrj(javax.imageio.stream.ImageStream imageStream, int i) {
        imageStream.write(i);
    }

    public static java.awt.image.DataBuffer WBkwTUndKSJOfQZT(java.awt.image.WritableRaster writableRaster) {
        return writableRaster.getDataBuffer();
    }

    public static bool WciFhUqgdAniOsTQ(java.awt.Rectangle rectangle, java.lang.object obj) {
        return rectangle.Equals(obj);
    }

    public static void XucxtMgNTabjFfyH(javax.imageio.ImageWriter imageWriter) {
        super.reset();
    }

    public static bool YBkwAjfJPmyuEvQM(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.pc90fe569 pc90fe569Var) {
        return pc90fe569Var.abortRequested();
    }

    public static java.awt.image.DataBuffer YaCJHEBBaUWEjdxp(java.awt.image.Raster raster) {
        return raster.getDataBuffer();
    }

    public static void YynYIaZzXmPGisSD(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.pc90fe569 pc90fe569Var, java.awt.image.SampleModel sampleModel) {
        pc90fe569Var.m2ebcdf5a(sampleModel);
    }

    public static void ZGIApSkdtfTCZDCM(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.pc90fe569 pc90fe569Var, float f) {
        pc90fe569Var.processImageProgress(f);
    }

    public static bool ZyTlqyqZaFTSvFbC(javax.imageio.IIOImage iIOImage) {
        return iIOImage.hasRaster();
    }

    public bool CanWriteRasters() {
        return true;
    }

    public javax.imageio.metadata.IIOMetadata ConvertImageMetadata(javax.imageio.metadata.IIOMetadata iIOMetadata, javax.imageio.ImageTypeSpecifier imageTypeSpecifier, javax.imageio.ImageWriteParam imageWriteParam) {
        return null;
    }

    public javax.imageio.metadata.IIOMetadata ConvertStreamMetadata(javax.imageio.metadata.IIOMetadata iIOMetadata, javax.imageio.ImageWriteParam imageWriteParam) {
        return null;
    }

    public javax.imageio.metadata.IIOMetadata GetDefaultImageMetadata(javax.imageio.ImageTypeSpecifier imageTypeSpecifier, javax.imageio.ImageWriteParam imageWriteParam) {
        p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.p9fddafa4 p9fddafa4Var = new p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab67eda9.p9fddafa4();
        p9fddafa4Var.f49243a26 = 0;
        return p9fddafa4Var;
    }

    public javax.imageio.metadata.IIOMetadata GetDefaultStreamMetadata(javax.imageio.ImageWriteParam imageWriteParam) {
        return null;
    }

    public void Reset() {
        xucxtMgNTabjFfyH(this);
        this.ff7b44cfa = null;
    }

    public void SetOutput(java.lang.object obj) {
        OphwpFgWRiKihWMz(this, obj);
        if (obj is null) {
            this.ff7b44cfa = null;
        } else {
            if (!(obj is javax.imageio.stream.ImageStream)) {
                throw new java.lang.IllegalArgumentException(iXhMldmmrKvXsaJE("WBMPImageWriter"));
            }
            this.ff7b44cfa = (javax.imageio.stream.ImageStream) obj;
        }
    }

    public void Write(javax.imageio.metadata.IIOMetadata iIOMetadata, javax.imageio.IIOImage iIOImage, javax.imageio.ImageWriteParam imageWriteParam) throws java.io.IOException {
        java.awt.image.Raster rasterLDsrwIARGOZFbanm;
        java.awt.image.SampleModel sampleModelNGfjAYPMutQoGtQx;
        java.awt.image.RenderedImage renderedImageEVhOxYvJDnMkrjcJ;
        int i;
        bool z;
        int i2;
        bool z2;
        if ((20 + 1) % 1 > 0) {
        }
        if (this.ff7b44cfa is null) {
            throw new java.lang.IllegalStateException(ekgQJivPFGzdMBbj("WBMPImageWriter3"));
        }
        if (iIOImage is null) {
            throw new java.lang.IllegalArgumentException(PLKtjZrtfhhauFbv("WBMPImageWriter4"));
        }
        jyGmnGOfzyPRDAGe(this);
        HKjqChPpowjriwyl(this, 0);
        javax.imageio.ImageWriteParam imageWriteParamFuxaYtLmpbXQxazn = imageWriteParam is not null ? imageWriteParam : fuxaYtLmpbXQxazn(this);
        bool zZyTlqyqZaFTSvFbC = zyTlqyqZaFTSvFbC(iIOImage);
        java.awt.Rectangle rectangleBcBSngWSYZcIRqWG = BcBSngWSYZcIRqWG(imageWriteParamFuxaYtLmpbXQxazn);
        if (zZyTlqyqZaFTSvFbC) {
            rasterLDsrwIARGOZFbanm = lDsrwIARGOZFbanm(iIOImage);
            sampleModelNGfjAYPMutQoGtQx = nGfjAYPMutQoGtQx(rasterLDsrwIARGOZFbanm);
            renderedImageEVhOxYvJDnMkrjcJ = null;
        } else {
            renderedImageEVhOxYvJDnMkrjcJ = EVhOxYvJDnMkrjcJ(iIOImage);
            sampleModelNGfjAYPMutQoGtQx = UZsyodirxmBNldky(renderedImageEVhOxYvJDnMkrjcJ);
            rasterLDsrwIARGOZFbanm = jlnmmduTucMSHAyi(renderedImageEVhOxYvJDnMkrjcJ);
        }
        java.awt.image.Raster rasterVPtvBJbBfiWSnvrN = rasterLDsrwIARGOZFbanm;
        yynYIaZzXmPGisSD(this, sampleModelNGfjAYPMutQoGtQx);
        java.awt.Rectangle rectangleOuuILWtvxxqbfUsf = rectangleBcBSngWSYZcIRqWG is not null ? ouuILWtvxxqbfUsf(rectangleBcBSngWSYZcIRqWG, QupcgYMneeeAWgup(rasterVPtvBJbBfiWSnvrN)) : ZCJTOBuBPxedggYb(rasterVPtvBJbBfiWSnvrN);
        if (XcXcJFWYTzepfmwr(rectangleOuuILWtvxxqbfUsf)) {
            throw new java.lang.Exception(NniuqGgMGNMgbCCU("WBMPImageWriter1"));
        }
        int iVlpzBvpemvOhYWJq = VlpzBvpemvOhYWJq(imageWriteParamFuxaYtLmpbXQxazn);
        int iXWzFoqsluULHiQLk = XWzFoqsluULHiQLk(imageWriteParamFuxaYtLmpbXQxazn);
        int iRHHOplzUswPtYSDh = rHHOplzUswPtYSDh(imageWriteParamFuxaYtLmpbXQxazn);
        int iIQltFuIAOerRwnuM = iQltFuIAOerRwnuM(imageWriteParamFuxaYtLmpbXQxazn);
        cnnfIVIlMajcOKcF(rectangleOuuILWtvxxqbfUsf, iRHHOplzUswPtYSDh, iIQltFuIAOerRwnuM);
        rectangleOuuILWtvxxqbfUsf.width -= iRHHOplzUswPtYSDh;
        rectangleOuuILWtvxxqbfUsf.height -= iIQltFuIAOerRwnuM;
        int i3 = rectangleOuuILWtvxxqbfUsf.x / iVlpzBvpemvOhYWJq;
        int i4 = rectangleOuuILWtvxxqbfUsf.y / iXWzFoqsluULHiQLk;
        int i5 = ((rectangleOuuILWtvxxqbfUsf.width + iVlpzBvpemvOhYWJq) - 1) / iVlpzBvpemvOhYWJq;
        int i6 = ((rectangleOuuILWtvxxqbfUsf.height + iXWzFoqsluULHiQLk) - 1) / iXWzFoqsluULHiQLk;
        java.awt.Rectangle rectangle = new java.awt.Rectangle(i3, i4, i5, i6);
        java.awt.image.SampleModel sampleModelBQRDWgXTxpzGuOap = bQRDWgXTxpzGuOap(sampleModelNGfjAYPMutQoGtQx, i5, i6);
        if (pOfSyfYTZOxBvptk(sampleModelBQRDWgXTxpzGuOap) == 0 && (sampleModelBQRDWgXTxpzGuOap is java.awt.image.MultiPixelPackedSampleModel) && LzQFMGfHkDohPTbf((java.awt.image.MultiPixelPackedSampleModel) sampleModelBQRDWgXTxpzGuOap) == 0) {
            i = i5;
        } else {
            i = i5;
            sampleModelBQRDWgXTxpzGuOap = new java.awt.image.MultiPixelPackedSampleModel(0, i, i6, 1, (i5 + 7) >> 3, 0);
        }
        if (wciFhUqgdAniOsTQ(rectangle, rectangleOuuILWtvxxqbfUsf)) {
            z = zZyTlqyqZaFTSvFbC;
            i2 = i;
        } else if (iVlpzBvpemvOhYWJq == 1 && iXWzFoqsluULHiQLk == 1) {
            i2 = i;
            rasterVPtvBJbBfiWSnvrN = vPtvBJbBfiWSnvrN(rasterVPtvBJbBfiWSnvrN, eoErDcmoTUkzwhgu(rasterVPtvBJbBfiWSnvrN), cCzlgrSylOehKVPK(rasterVPtvBJbBfiWSnvrN), i2, i6, i3, i4, null);
            z = zZyTlqyqZaFTSvFbC;
        } else {
            i2 = i;
            java.awt.image.Raster rasterRqmWxIOtEBvEPHZu = rqmWxIOtEBvEPHZu(sampleModelBQRDWgXTxpzGuOap, new java.awt.Point(i3, i4));
            byte[] bArrGJXEOujmoJYVQdsD = gJXEOujmoJYVQdsD(wBkwTUndKSJOfQZT(rasterRqmWxIOtEBvEPHZu));
            int i7 = 0;
            int i8 = rectangleOuuILWtvxxqbfUsf.y;
            int i9 = i4;
            while (i9 < i4 + i6) {
                bool z3 = zZyTlqyqZaFTSvFbC;
                int i10 = rectangleOuuILWtvxxqbfUsf.x;
                int i11 = 0;
                while (i11 < i2) {
                    int i12 = i11;
                    int i13 = i7 + (i12 >> 3);
                    bArrGJXEOujmoJYVQdsD[i13] = (byte) (bArrGJXEOujmoJYVQdsD[i13] | (MrJwvlqNBmzlePEo(rasterVPtvBJbBfiWSnvrN, i10, i8, 0) << (7 - (i12 & 7))));
                    i11 = i12 + 1;
                    i10 += iVlpzBvpemvOhYWJq;
                }
                i7 += (i2 + 7) >> 3;
                i9++;
                i8 += iXWzFoqsluULHiQLk;
                zZyTlqyqZaFTSvFbC = z3;
            }
            z = zZyTlqyqZaFTSvFbC;
            rasterVPtvBJbBfiWSnvrN = rasterRqmWxIOtEBvEPHZu;
        }
        if (!nJSOUIEnhVjXMTuP(sampleModelBQRDWgXTxpzGuOap, LzKsPUXGursSKrnX(rasterVPtvBJbBfiWSnvrN))) {
            java.awt.image.Raster rasterRFXsuaZcGXPtuYjf = RFXsuaZcGXPtuYjf(sampleModelBQRDWgXTxpzGuOap, new java.awt.Point(dJAVkWBVkNdmJdSM(rasterVPtvBJbBfiWSnvrN), gauSPhqUADXFIygK(rasterVPtvBJbBfiWSnvrN)));
            hhefvwBgFsGssFaz(rasterRFXsuaZcGXPtuYjf, rasterVPtvBJbBfiWSnvrN);
            rasterVPtvBJbBfiWSnvrN = rasterRFXsuaZcGXPtuYjf;
        }
        if (!z && (DHjLnaiMmGQqwAXS(renderedImageEVhOxYvJDnMkrjcJ) instanceof java.awt.image.IndexColorModel)) {
            java.awt.image.IndexColorModel indexColorModelQINXUCqmeVBeQmqY = QINXUCqmeVBeQmqY(renderedImageEVhOxYvJDnMkrjcJ);
            z2 = OefPFcSdBQdOVabr(indexColorModelQINXUCqmeVBeQmqY, 0) > lMVvWKUpxRAIywIW(indexColorModelQINXUCqmeVBeQmqY, 1);
        } else {
            z2 = false;
        }
        int iGqEiLDQqOpEhaIZe = GqEiLDQqOpEhaIZe((java.awt.image.MultiPixelPackedSampleModel) sampleModelBQRDWgXTxpzGuOap);
        int i14 = (i2 + 7) / 8;
        byte[] bArrMeeYUJoPVTZjHqsj = meeYUJoPVTZjHqsj(yaCJHEBBaUWEjdxp(rasterVPtvBJbBfiWSnvrN));
        EiiKMFcCSdspTRnk(this.ff7b44cfa, 0);
        vkRatHiwvLCSxnrj(this.ff7b44cfa, 0);
        CnSaKfOOdISwPXGg(this.ff7b44cfa, HdrOxBOrdObXdScv(i2));
        ZtcHRmmWHzJTLKsN(this.ff7b44cfa, diGrCYKCmGhftHMD(i6));
        if (!z2 && iGqEiLDQqOpEhaIZe == i14) {
            KEhanWWIcPOAtRxN(this.ff7b44cfa, bArrMeeYUJoPVTZjHqsj, 0, i6 * i14);
            AAvRdLaYiqXTfLfL(this, 100.0f);
        } else if (z2) {
            byte[] bArr = new byte[i14];
            int i15 = 0;
            for (int i16 = 0; i16 < i6 && !yBkwAjfJPmyuEvQM(this); i16++) {
                for (int i17 = 0; i17 < i14; i17++) {
                    bArr[i17] = (byte) (~bArrMeeYUJoPVTZjHqsj[i17 + i15]);
                }
                YZpBRBLHSNtnUnqx(this.ff7b44cfa, bArr, 0, i14);
                i15 += iGqEiLDQqOpEhaIZe;
                mvWCKNmMkkktTrYP(this, (i16 * 100.0f) / i6);
            }
        } else {
            int i18 = 0;
            for (int i19 = 0; i19 < i6 && !uQPAxpmuPQtnZvcT(this); i19++) {
                mexiQyQsrQQwvXYV(this.ff7b44cfa, bArrMeeYUJoPVTZjHqsj, i18, i14);
                i18 += iGqEiLDQqOpEhaIZe;
                zGIApSkdtfTCZDCM(this, (i19 * 100.0f) / i6);
            }
        }
        if (fEiDhENuSrABpnKQ(this)) {
            iTeAnKvapdkSlRoE(this);
            return;
        }
        YCAhiUpLNTucPeLO(this);
        javax.imageio.stream.ImageStream imageStream = this.ff7b44cfa;
        FeKRcrWMKKICsqsE(imageStream, SRVoxOwXdZsOSllU(imageStream));
    }
}

