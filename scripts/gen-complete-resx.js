// Master script to generate all resx files with 584 keys
// Reads existing files, adds missing translations, writes complete output
const fs = require('fs');
const path = require('path');
const resDir = path.join('C:', 'work', 'prtask.com', 'src', 'PrTask.SharedUI', 'Resources');

function readResx(fp) {
  const content = fs.readFileSync(fp, 'utf-8');
  const entries = {};
  const re = /<data name="([^"]+)" xml:space="preserve"><value>([\s\S]*?)<\/value><\/data>/g;
  let m;
  while ((m = re.exec(content)) !== null) entries[m[1]] = m[2];
  return entries;
}

function writeResx(lang, entries, allKeys) {
  let out = `<?xml version="1.0" encoding="utf-8"?>
<root>
  <xsd:schema id="root" xmlns="" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata">
    <xsd:element name="root" msdata:IsDataSet="true">
      <xsd:complexType>
        <xsd:choice maxOccurs="unbounded">
          <xsd:element name="data">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
              </xsd:sequence>
              <xsd:attribute name="name" type="xsd:string" use="required" />
              <xsd:attribute name="type" type="xsd:string" />
              <xsd:attribute name="xml:space" type="xsd:string" />
            </xsd:complexType>
          </xsd:element>
        </xsd:choice>
      </xsd:complexType>
    </xsd:element>
  </xsd:schema>
  <resheader name="resmimetype"><value>text/microsoft-resx</value></resheader>
  <resheader name="version"><value>2.0</value></resheader>
  <resheader name="reader"><value>System.Resources.ResXResourceReader</value></resheader>
  <resheader name="writer"><value>System.Resources.ResXResourceWriter</value></resheader>\n`;
  for (const k of allKeys) {
    out += `  <data name="${k}" xml:space="preserve"><value>${entries[k]}</value></data>\n`;
  }
  out += `</root>\n`;
  const fp = path.join(resDir, `SharedResource.${lang}.resx`);
  fs.writeFileSync(fp, out, 'utf-8');
  console.log(`${lang}: ${allKeys.length} keys`);
}

function escXml(s) {
  return s.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;');
}

const en = readResx(path.join(resDir, 'SharedResource.resx'));
const allKeys = Object.keys(en).sort();
console.log(`English: ${allKeys.length} keys`);

// zh is already done (584 keys)
// Process remaining 12 languages: de, es, fr, hi, it, ja, ko, pt, ru, id, nl, tr, ar

// Load all translation JSON files from scripts directory
const langs = ['de','es','fr','hi','it','ja','ko','pt','ru','id','nl','tr','ar'];
const scriptsDir = path.join('C:', 'work', 'prtask.com', 'scripts');

for (const lang of langs) {
  const jsonPath = path.join(scriptsDir, `trans_${lang}.json`);
  if (!fs.existsSync(jsonPath)) {
    console.log(`SKIP ${lang}: no trans_${lang}.json found`);
    continue;
  }
  const existing = readResx(path.join(resDir, `SharedResource.${lang}.resx`));
  const newTrans = JSON.parse(fs.readFileSync(jsonPath, 'utf-8'));
  const merged = { ...existing };
  for (const [k, v] of Object.entries(newTrans)) {
    merged[k] = escXml(v);
  }
  const missing = allKeys.filter(k => merged[k] === undefined);
  if (missing.length > 0) {
    console.error(`${lang}: Still missing ${missing.length} keys: ${missing.slice(0,3).join(', ')}...`);
    continue;
  }
  writeResx(lang, merged, allKeys);
}
