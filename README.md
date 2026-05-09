# OOP C# kursusetööd

Autor: Kristo Torm  
Kool: Tallinna Polütehnikum  
Eriala: tarkvaraarendus  
Keel: C#  
Keskkond: Visual Studio  
Tüüp: Windows Forms  
Raamistik: .NET Framework 4.8

See repository sisaldab kooli OOP aluste kursuse jaoks tehtud väiksemaid C# Windows Forms harjutusprojekte ja ühte kursuseprojekti.

Projektide eesmärk oli harjutada vormirakenduste loomist, nuppude ja tekstiväljade kasutamist, sündmuste käsitlemist, tingimuslauseid, juhuslike arvude kasutamist ning lihtsat mänguloogikat.

## Projektid

### Torm_OOP_KT1_CSharp

Esimene kursusetöö on lihtne Windows Forms rakendus.

Rakenduses saab:
- sisestada nime ja kuvada tervituse;
- muuta vormi taustavärvi punaseks või siniseks;
- tühistada valikud ja puhastada väljad;
- sisestada kaks arvu ja need kokku liita.

Selles töös harjutasin TextBox, Label, Button, RadioButton, CheckBox ja GroupBox objektide kasutamist.

### Torm_OOP_KT2_CSharp

Teine kursusetöö on juhusliku arvuga mäng.

Programmi tööpõhimõte:
- kasutaja alustab mängu;
- iga nupuvajutus genereerib juhusliku arvu vahemikus 0 kuni 10;
- programm loeb, mitu katset kulus, kuni tuli arv 0 või 10;
- iga katse maksab 1 euro;
- lõpus kuvatakse, kas katseid oli vähem kui 10, täpselt 10 või rohkem kui 10.

Selles töös harjutasin Random klassi kasutamist, if/else tingimusi, loendurit ja PictureBoxi kasutamist.

### Torm_OOP_KT3_CSharp

Kolmas kursusetöö on kahe mängijaga täringumäng.

Programmi tööpõhimõte:
- mängus on kaks mängijat: Juku ja Peeter;
- Juku viskab kaks täringut;
- Peeter viskab kaks täringut;
- programm liidab mõlema mängija punktid;
- lõpus kuvatakse, kas võitis Juku, Peeter või jäi mäng viiki.

Selles töös harjutasin juhuslike arvude genereerimist vahemikus 1 kuni 6, punktide liitmist ja tulemuse võrdlemist.

### Torm_OOP_Kursusprojekt_CSharp

Kursuseprojektiks valisin Trips-Traps-Trull ehk Tic Tac Toe mängu.

Mängus on:
- 3x3 mängulaud;
- kaks mängijat: X ja O;
- kordamööda käigud;
- võidu kontroll ridade, veergude ja diagonaalide järgi;
- viigi kontroll;
- punktide arvestus X, O ja viikide jaoks;
- uus mäng ja punktide nullimine.

Selles projektis harjutasin rohkem mänguloogikat, massiivi kasutamist, nuppude dünaamilist käsitlemist ja võidutingimuste kontrollimist.

## Kuidas käivitada

1. Ava soovitud projekti kaust.
2. Ava `.sln` fail Visual Studios.
3. Vajuta `Start` või `F5`.

Näiteks kursuseprojekti avamiseks:

```text
Torm_OOP_Kursusprojekt_CSharp/Torm_OOP_Kursusprojekt_CSharp.sln
