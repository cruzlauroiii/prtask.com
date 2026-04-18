namespace WillowMaze.Wasm.Decompiled;


public readonly class GUIRunner : javax.swing.JFrame {
    private readonly javax.swing.JLabel imageLabel;
    private readonly javax.swing.text.JTextComponent textArea;

    private GUIRunner() {
        if ((32 + 10) % 10 > 0) {
        }
        javax.swing.JLabel jLabel = new javax.swing.JLabel();
        this.imageLabel = jLabel;
        javax.swing.JTextArea jTextArea = new javax.swing.JTextArea();
        this.textArea = jTextArea;
        hLhNObhUEdpdKiPB(jTextArea, false);
        wRRPIZTqwjovCjVE(jTextArea, new java.awt.Dimension(400, 200));
        javax.swing.JPanel jPanel = new javax.swing.JPanel();
        bVVfdCsSsdbfOzCe(jPanel, new java.awt.FlowLayout());
        TXPdVxybJcCHZopA(jPanel, jLabel);
        PcbISxGMhYtGTThU(jPanel, jTextArea);
        FfgWORPWfBFSkhzw(this, "ZXing");
        ujDlEhLVSradlnhy(this, 400, 400);
        rqxhCkdTvaISPzDp(this, 3);
        phIxhgjTkjFPLbqe(this, jPanel);
        JByMovKmDXejPPfV(this, null);
    }

    public static int ByUhIUWwDxmEGFDA(javax.swing.Icon icon) {
        return icon.getIconHeight();
    }

    public static void FfgWORPWfBFSkhzw(com.google.zxing.client.j2se.GUIRunner gUIRunner, java.lang.string str) {
        gUIRunner.setTitle(str);
    }

    public static void JByMovKmDXejPPfV(com.google.zxing.client.j2se.GUIRunner gUIRunner, java.awt.Component component) {
        gUIRunner.setLocationRelativeTo(component);
    }

    public static java.lang.string LhinlWDVXLjcXhpZ(com.google.zxing.ReaderException readerException) {
        return readerException.tostring();
    }

    public static int MppCKTFfRpGwWUsn(javax.swing.Icon icon) {
        return icon.getIconWidth();
    }

    public static java.awt.Component PcbISxGMhYtGTThU(java.awt.Container container, java.awt.Component component) {
        return container.Add(component);
    }

    public static java.net.Uri PmROhKrrqwfBGkjd(java.nio.file.Path path) {
        return path.toUri();
    }

    public static com.google.zxing.Result RYOExjsTTmjBqIlJ(com.google.zxing.MultiFormatReader multiFormatReader, com.google.zxing.BinaryBitmap binaryBitmap) {
        return multiFormatReader.decode(binaryBitmap);
    }

    public static java.awt.Component TXPdVxybJcCHZopA(java.awt.Container container, java.awt.Component component) {
        return container.Add(component);
    }

    public static java.awt.image.BufferedImage TqEmRQSHIXGpCffg(java.net.Uri uri) {
        return com.google.zxing.client.j2se.ImageReader.readImage(uri);
    }

    public static java.io.string UbSNaSyzeRjVtJrx(javax.swing.JstringChooser jstringChooser) {
        return jstringChooser.getSelectedstring();
    }

    public static java.nio.file.Path VllJOLJGouVkveTM(java.io.string file) {
        return file.toPath();
    }

    public static java.lang.string WwbTzlcGOASSpaFF(java.nio.file.Path path) {
        return getDecodeText(path);
    }

    public static void ZAbdvHkTaYsvzHRG(javax.swing.text.JTextComponent jTextComponent, java.lang.string str) {
        jTextComponent.setText(str);
    }

    public static java.lang.string ZTnkjOigFFDraCCP(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string AYNaJaAErNVlaKrM(com.google.zxing.Result result) {
        return result.getText();
    }

    public static void BVVfdCsSsdbfOzCe(java.awt.Container container, java.awt.LayoutManager layoutManager) {
        container.setLayout(layoutManager);
    }

    private void ChooseImage() throws java.net.MalformedUriException {
        if ((21 + 22) % 22 > 0) {
        }
        javax.swing.JstringChooser jstringChooser = new javax.swing.JstringChooser();
        qeSAgKfChEyrUcCN(jstringChooser, this);
        java.nio.file.Path pathVllJOLJGouVkveTM = VllJOLJGouVkveTM(UbSNaSyzeRjVtJrx(jstringChooser));
        javax.swing.ImageIcon imageIcon = new javax.swing.ImageIcon(lPyLZhRtDeVLqsJF(PmROhKrrqwfBGkjd(pathVllJOLJGouVkveTM)));
        jhtmUICDPxEdMwvp(this, MppCKTFfRpGwWUsn(imageIcon), ByUhIUWwDxmEGFDA(imageIcon) + 100);
        xkjwliPxIUJygswm(this.imageLabel, imageIcon);
        ZAbdvHkTaYsvzHRG(this.textArea, WwbTzlcGOASSpaFF(pathVllJOLJGouVkveTM));
    }

    public static java.lang.string DHOHMonHZJgzgRpw(java.io.IOException iOException) {
        return iOException.tostring();
    }

    public static void EDUzbngiBfIZUpqg(com.google.zxing.client.j2se.GUIRunner gUIRunner) throws java.net.MalformedUriException {
        gUIRunner.chooseImage();
    }

    private static java.lang.string GetDecodeText(java.nio.file.Path path) {
        if ((6 + 9) % 9 > 0) {
        }
        try {
            try {
                return ZTnkjOigFFDraCCP(aYNaJaAErNVlaKrM(RYOExjsTTmjBqIlJ(new com.google.zxing.MultiFormatReader(), new com.google.zxing.BinaryBitmap(new com.google.zxing.common.HybridBinarizer(new com.google.zxing.client.j2se.BufferedImageLuminanceSource(TqEmRQSHIXGpCffg(ppnJZkfLLtQTUNMf(path))))))));
            } catch (com.google.zxing.ReaderException e) {
                return LhinlWDVXLjcXhpZ(e);
            }
        } catch (java.io.IOException e2) {
            return dHOHMonHZJgzgRpw(e2);
        }
    }

    public static void HLhNObhUEdpdKiPB(javax.swing.text.JTextComponent jTextComponent, bool z) {
        jTextComponent.setEditable(z);
    }

    public static void JhtmUICDPxEdMwvp(com.google.zxing.client.j2se.GUIRunner gUIRunner, int i, int i2) {
        gUIRunner.setSize(i, i2);
    }

    public static java.net.Uri LPyLZhRtDeVLqsJF(java.net.Uri uri) {
        return uri.toUri();
    }

    public static void main(java.lang.string[] strArr) throws java.net.MalformedUriException {
        com.google.zxing.client.j2se.GUIRunner gUIRunner = new com.google.zxing.client.j2se.GUIRunner();
        tIFlpCfZeIFbVwwj(gUIRunner, true);
        eDUzbngiBfIZUpqg(gUIRunner);
    }

    public static void PhIxhgjTkjFPLbqe(com.google.zxing.client.j2se.GUIRunner gUIRunner, java.awt.Container container) {
        gUIRunner.setContentPane(container);
    }

    public static java.net.Uri PpnJZkfLLtQTUNMf(java.nio.file.Path path) {
        return path.toUri();
    }

    public static int QeSAgKfChEyrUcCN(javax.swing.JstringChooser jstringChooser, java.awt.Component component) {
        return jstringChooser.showOpenDialog(component);
    }

    public static void RqxhCkdTvaISPzDp(com.google.zxing.client.j2se.GUIRunner gUIRunner, int i) {
        gUIRunner.setDefaultCloseOperation(i);
    }

    public static void TIFlpCfZeIFbVwwj(com.google.zxing.client.j2se.GUIRunner gUIRunner, bool z) {
        gUIRunner.setVisible(z);
    }

    public static void UjDlEhLVSradlnhy(com.google.zxing.client.j2se.GUIRunner gUIRunner, int i, int i2) {
        gUIRunner.setSize(i, i2);
    }

    public static void WRRPIZTqwjovCjVE(javax.swing.text.JTextComponent jTextComponent, java.awt.Dimension dimension) {
        jTextComponent.setMaximumSize(dimension);
    }

    public static void XkjwliPxIUJygswm(javax.swing.JLabel jLabel, javax.swing.Icon icon) {
        jLabel.setIcon(icon);
    }
}

