namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task73 Client index.html must have static SEO meta tags and prerendered fallback inside app div matching WASM UI")]
    public void Task73IndexHtmlStaticSeoAndPrerenderedFallback()
    {
        var IndexHtml = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Client", "wwwroot", "index.html"));
        Assert.IsTrue(IndexHtml.Contains("og:title"), "index.html must have og:title meta tag");
        Assert.IsTrue(IndexHtml.Contains("og:description"), "index.html must have og:description meta tag");
        Assert.IsTrue(IndexHtml.Contains("og:type"), "index.html must have og:type meta tag");
        Assert.IsTrue(IndexHtml.Contains("og:url"), "index.html must have og:url meta tag");
        Assert.IsTrue(IndexHtml.Contains("og:site_name"), "index.html must have og:site_name meta tag");
        Assert.IsTrue(IndexHtml.Contains("twitter:card"), "index.html must have twitter:card meta tag");
        Assert.IsTrue(IndexHtml.Contains("twitter:title"), "index.html must have twitter:title meta tag");
        Assert.IsTrue(IndexHtml.Contains("twitter:description"), "index.html must have twitter:description meta tag");
        Assert.IsTrue(IndexHtml.Contains("canonical"), "index.html must have canonical link");
        Assert.IsTrue(IndexHtml.Contains("<meta name=\"description\""), "index.html must have meta description");
        var AppDiv = IndexHtml[IndexHtml.IndexOf("id=\"app\"")..];
        Assert.IsTrue(AppDiv.Contains("nav-brand"), "app div must have prerendered navigation with nav-brand");
        Assert.IsTrue(AppDiv.Contains("hero"), "app div must have prerendered hero section");
        Assert.IsTrue(AppDiv.Contains("feature-card"), "app div must have prerendered feature cards");
        Assert.IsTrue(AppDiv.Contains("Browse Tasks"), "app div must have Browse Tasks CTA");
        Assert.IsTrue(AppDiv.Contains("site-footer"), "app div must have prerendered footer");
        Assert.IsFalse(IndexHtml.Contains(">Loading...</"), "index.html must not show Loading text");
        var Home = ReadSource("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Home.Contains("hero") && AppDiv.Contains("hero"), "prerendered hero must match WASM Home page structure");
        Assert.IsTrue(Home.Contains("feature-card") && AppDiv.Contains("feature-card"), "prerendered features must match WASM Home page structure");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task74 Build output must be minified with esbuild for CSS and JS and html-minifier-terser for HTML on Publish")]
    public void Task74BuildMinificationTargets()
    {
        var Props = File.ReadAllText(Path.Combine(SolutionRoot, "Directory.Build.props"));
        Assert.IsTrue(Props.Contains("MinifyCss"), "Must have MinifyCss target");
        Assert.IsTrue(Props.Contains("MinifyJs"), "Must have MinifyJs target");
        Assert.IsTrue(Props.Contains("MinifyHtml"), "Must have MinifyHtml target");
        Assert.IsTrue(Props.Contains("esbuild") && Props.Contains("--minify"), "MinifyCss must use esbuild --minify");
        Assert.IsFalse(Props.Contains("<Copy") && Props.Contains(".min.css"), "MinifyCss must not use Copy for CSS minification");
        Assert.IsTrue(Props.Contains("html-minifier-terser"), "MinifyHtml must use html-minifier-terser");
        Assert.IsTrue(Props.Contains("--collapse-whitespace"), "MinifyHtml must collapse whitespace");
        Assert.IsTrue(Props.Contains("--remove-comments"), "MinifyHtml must remove comments");
        Assert.IsTrue(Props.Contains("Publish") && Props.Contains("MinifyHtml"), "MinifyHtml must run on Publish not Build");
        var PackageJson = File.ReadAllText(Path.Combine(SolutionRoot, "package.json"));
        Assert.IsTrue(PackageJson.Contains("html-minifier-terser"), "package.json must include html-minifier-terser");
        Assert.IsTrue(PackageJson.Contains("esbuild"), "package.json must include esbuild");
    }
}
