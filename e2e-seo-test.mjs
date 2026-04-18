import { chromium } from 'playwright';

const Pages = [
    { Url: 'https://prtask.com', ExpectedH1: 'PrTask' },
    { Url: 'https://prtask.com/Tasks', ExpectedH1: 'Open Tasks' },
    { Url: 'https://prtask.com/Login', ExpectedH1: 'Sign In' },
    { Url: 'https://prtask.com/Dashboard', ExpectedH1: 'Dashboard' },
    { Url: 'https://prtask.com/Pricing', ExpectedH1: 'Pricing' },
    { Url: 'https://prtask.com/About', ExpectedH1: 'About' },
    { Url: 'https://prtask.com/HowItWorks', ExpectedH1: 'How It Works' },
    { Url: 'https://prtask.com/Leaderboard', ExpectedH1: 'Leaderboard' },
];

const Browser = await chromium.launch();
const Context = await Browser.newContext({ javaScriptEnabled: false });

let Passed = 0;
let Failed = 0;

for (const Page of Pages) {
    const Tab = await Context.newPage();
    await Tab.goto(Page.Url, { waitUntil: 'domcontentloaded', timeout: 30000 });

    const Title = await Tab.title();
    const H1 = await Tab.locator('h1').first().textContent().catch(() => 'NO H1 FOUND');
    const BodyText = await Tab.locator('body').textContent().catch(() => '');
    const IsBlank = BodyText.trim().length < 50;

    const H1Match = H1 && H1.includes(Page.ExpectedH1);
    const Status = IsBlank ? 'BLANK' : (H1Match ? 'PASS' : 'CONTENT BUT WRONG H1');

    if (IsBlank) Failed++;
    else Passed++;

    console.log(`${Status}: ${Page.Url}`);
    console.log(`  Title: ${Title}`);
    console.log(`  H1: ${H1}`);
    console.log(`  Body length: ${BodyText.trim().length} chars`);
    console.log(`  Blank: ${IsBlank}`);
    console.log('');

    await Tab.close();
}

await Browser.close();

console.log(`\nResults: ${Passed} passed, ${Failed} failed (blank)`);
process.exit(Failed > 0 ? 1 : 0);
