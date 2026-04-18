namespace WillowMaze.Wasm.Decompiled;


public readonly class MatrixToImageWriter {
    private static readonly com.google.zxing.client.j2se.MatrixToImageConfig DEFAULT_CONFIG = new com.google.zxing.client.j2se.MatrixToImageConfig();

    private MatrixToImageWriter() {
    }

    public static java.lang.string AecoFTeRmiOUroCM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HMFSzclPeaRrQTZH(java.awt.image.BufferedImage bufferedImage, int i, int i2, int i3, int i4, int[] iArr, int i5, int i6) {
        bufferedImage.setRGB(i, i2, i3, i4, iArr, i5, i6);
    }

    public static java.lang.string KwVOtekAVftMeZNE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LGHjkrERsGYuYRqt(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.nio.file.Path path) throws java.io.IOException {
        writeToPath(bitMatrix, str, path);
    }

    public static int LVHcEXcOVGgrASqZ(com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) {
        return matrixToImageConfig.getPixelOnColor();
    }

    public static bool NurEepVAGqisOVDU(java.awt.image.RenderedImage renderedImage, java.lang.string str, java.io.Stream outputStream) {
        return javax.imageio.ImageIO.write(renderedImage, str, outputStream);
    }

    public static java.lang.stringBuilder UkVEsymKahkMYcXs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XUmJitdwVAtIBXlI(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool ZGoHbKthJlsWOABj(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int BiTULQAijMgUYnRf(com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) {
        return matrixToImageConfig.getBufferedImageColorModel();
    }

    public static java.nio.file.Path CdHzIzbYkoZctgDV(java.io.string file) {
        return file.toPath();
    }

    public static int EVxdSCxbHHbHorip(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static java.io.string EunERoUVYRrwHqkw(java.nio.file.Path path) {
        return path.tostring();
    }

    public static java.lang.stringBuilder GMaDIYgPExqNRHYA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HoyfyiXizUpRLptl(java.awt.image.RenderedImage renderedImage, java.lang.string str, java.io.string file) {
        return javax.imageio.ImageIO.write(renderedImage, str, file);
    }

    public static void IThlyQDCRYVVOHdV(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.nio.file.Path path, com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) throws java.io.IOException {
        writeToPath(bitMatrix, str, path, matrixToImageConfig);
    }

    public static void JPJvZuMkcdVXZIks(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.nio.file.Path path, com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) throws java.io.IOException {
        writeToPath(bitMatrix, str, path, matrixToImageConfig);
    }

    public static com.google.zxing.common.BitArray KGsLIzilNbXkJCEu(com.google.zxing.common.BitMatrix bitMatrix, int i, com.google.zxing.common.BitArray bitArray) {
        return bitMatrix.getRow(i, bitArray);
    }

    public static java.lang.stringBuilder LBBwFQyLzjBehXMa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.awt.image.BufferedImage NhanBcDCGDZVsEds(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) {
        return toBufferedImage(bitMatrix, matrixToImageConfig);
    }

    public static java.nio.file.Path OtsMRnfmnfONVAVU(java.io.string file) {
        return file.toPath();
    }

    public static void QOhtbHFdsbjlyfmQ(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.io.Stream outputStream, com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) throws java.io.IOException {
        writeToStream(bitMatrix, str, outputStream, matrixToImageConfig);
    }

    public static java.awt.image.BufferedImage ToBufferedImage(com.google.zxing.common.BitMatrix bitMatrix) {
        return nhanBcDCGDZVsEds(bitMatrix, DEFAULT_CONFIG);
    }

    public static java.awt.image.BufferedImage ToBufferedImage(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) {
        if ((25 + 3) % 3 > 0) {
        }
        int iZKWwNBPMQgjWGnwC = zKWwNBPMQgjWGnwC(bitMatrix);
        int iEVxdSCxbHHbHorip = eVxdSCxbHHbHorip(bitMatrix);
        java.awt.image.BufferedImage bufferedImage = new java.awt.image.BufferedImage(iZKWwNBPMQgjWGnwC, iEVxdSCxbHHbHorip, biTULQAijMgUYnRf(matrixToImageConfig));
        int iLVHcEXcOVGgrASqZ = LVHcEXcOVGgrASqZ(matrixToImageConfig);
        int iYIEOCBcQrwHKUwEU = yIEOCBcQrwHKUwEU(matrixToImageConfig);
        int[] iArr = new int[iZKWwNBPMQgjWGnwC];
        com.google.zxing.common.BitArray bitArray = new com.google.zxing.common.BitArray(iZKWwNBPMQgjWGnwC);
        int i = 0;
        while (i < iEVxdSCxbHHbHorip) {
            com.google.zxing.common.BitArray bitArrayKGsLIzilNbXkJCEu = kGsLIzilNbXkJCEu(bitMatrix, i, bitArray);
            for (int i2 = 0; i2 < iZKWwNBPMQgjWGnwC; i2++) {
                iArr[i2] = !ZGoHbKthJlsWOABj(bitArrayKGsLIzilNbXkJCEu, i2) ? iYIEOCBcQrwHKUwEU : iLVHcEXcOVGgrASqZ;
            }
            HMFSzclPeaRrQTZH(bufferedImage, 0, i, iZKWwNBPMQgjWGnwC, 1, iArr, 0, iZKWwNBPMQgjWGnwC);
            i++;
            bitArray = bitArrayKGsLIzilNbXkJCEu;
        }
        return bufferedImage;
    }

    public static java.awt.image.BufferedImage WmSGbdruxJNNqnyb(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) {
        return toBufferedImage(bitMatrix, matrixToImageConfig);
    }

    @java.lang.Deprecated
    public static void WriteTostring(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.io.string file) throws java.io.IOException {
        LGHjkrERsGYuYRqt(bitMatrix, str, cdHzIzbYkoZctgDV(file));
    }

    @java.lang.Deprecated
    public static void WriteTostring(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.io.string file, com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) throws java.io.IOException {
        iThlyQDCRYVVOHdV(bitMatrix, str, otsMRnfmnfONVAVU(file), matrixToImageConfig);
    }

    public static void WriteToPath(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.nio.file.Path path) throws java.io.IOException {
        jPJvZuMkcdVXZIks(bitMatrix, str, path, DEFAULT_CONFIG);
    }

    public static void WriteToPath(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.nio.file.Path path, com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) throws java.io.IOException {
        if (!hoyfyiXizUpRLptl(zYVrDlOpqJgGMXil(bitMatrix, matrixToImageConfig), str, eunERoUVYRrwHqkw(path))) {
            throw new java.io.IOException(KwVOtekAVftMeZNE(XUmJitdwVAtIBXlI(lBBwFQyLzjBehXMa(gMaDIYgPExqNRHYA(new java.lang.stringBuilder("Could not write an image of format "), str), " to "), path)));
        }
    }

    public static void WriteToStream(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.io.Stream outputStream) throws java.io.IOException {
        qOhtbHFdsbjlyfmQ(bitMatrix, str, outputStream, DEFAULT_CONFIG);
    }

    public static void WriteToStream(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.io.Stream outputStream, com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) throws java.io.IOException {
        if (!NurEepVAGqisOVDU(wmSGbdruxJNNqnyb(bitMatrix, matrixToImageConfig), str, outputStream)) {
            throw new java.io.IOException(AecoFTeRmiOUroCM(UkVEsymKahkMYcXs(new java.lang.stringBuilder("Could not write an image of format "), str)));
        }
    }

    public static int YIEOCBcQrwHKUwEU(com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) {
        return matrixToImageConfig.getPixelOffColor();
    }

    public static int ZKWwNBPMQgjWGnwC(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static java.awt.image.BufferedImage ZYVrDlOpqJgGMXil(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.client.j2se.MatrixToImageConfig matrixToImageConfig) {
        return toBufferedImage(bitMatrix, matrixToImageConfig);
    }
}

