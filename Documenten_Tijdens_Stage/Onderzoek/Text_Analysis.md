 # Text Analysis

## Table of Contents

- [Text Analysis](#text-analysis)
  - [Table of Contents](#table-of-contents)
  - [1    Wat is Text analyse?](#1----wat-is-text-analyse)
  - [2    Soorten](#2----soorten)
    - [2.1 Sentiment Analyse](#21-sentiment-analyse)
      - [2.1.1  Types van Sentiment Analyse](#211--types-van-sentiment-analyse)
        - [2.1.1.1 Graded Sentiment Analysis](#2111-graded-sentiment-analysis)
        - [2.1.1.2 Emotion Detection](#2112-emotion-detection)
        - [2.1.1.3 Aspect-based Sentiment Analysis](#2113-aspect-based-sentiment-analysis)
        - [2.1.1.4 Multilingual sentiment analysis](#2114-multilingual-sentiment-analysis)
      - [2.2    Waarom is Sentiment Analyse Belangrijk?](#22----waarom-is-sentiment-analyse-belangrijk)
      - [2.3    Hoe werkt SA?](#23----hoe-werkt-sa)
        - [2.3.1 Rule-Based](#231-rule-based)
        - [2.3.2 Automatisch](#232-automatisch)
          - [2.3.2.1  Training & Prediction Process](#2321--training--prediction-process)
          - [2.3.2.2  Classification agloritmes](#2322--classification-agloritmes)
        - [2.3.3 Hybrid manier](#233-hybrid-manier)
        - [2.3.4 SA Challenges](#234-sa-challenges)
          - [2.3.4.1  Subjectiviteit & Toon](#2341--subjectiviteit--toon)
          - [2.3.4.2  Context & Polariteit](#2342--context--polariteit)
          - [2.3.4.3  Ironie & Sarcasme](#2343--ironie--sarcasme)
          - [2.3.4.4  Vergelijkingen](#2344--vergelijkingen)
          - [2.3.4.5  Emojis](#2345--emojis)
  - [3    Packages](#3----packages)
    - [3.1 NLTK(Natural Language Toolkit)](#31-nltknatural-language-toolkit)
    - [3.2 spaCy](#32-spacy)
    - [3.3 Gensim](#33-gensim)
    - [3.4 Pattern](#34-pattern)
    - [3.5 TextBlob](#35-textblob)
    - [3.6 Rake_NLTK](#36-rake_nltk)

<div style="page-break-after: always"></div>
\newpage

## 1    Wat is Text analyse?

- Txt = heel vaak ongestructureerde data, met veel waardevolle info in.
- Text Analysis(TA) = automatische proces van txt data te extraheren & classificeren.
- Soorten:
  - [Sentiment Analyse(SA)](#sentiment-analyse).
  - [Topic Analysis(TA)](#topic-analyse).
  - [Urgency Detection(UD)](#urgency-detection).
  - [Intent Categorization(IC)](#intent-categorization).

## 2    Soorten

### 2.1 Sentiment Analyse

- SA = proces om positieve & negatieve sentimenten in txt te onderscheiden.
- Vaak gebruikt in
  - Sociale data.
  - Merk reputatie meten.
  - Klanten beter begrijpen.

#### 2.1.1  Types van Sentiment Analyse

- Focust op polariteit van txt(Positiev, Negatiev, Neutraal).
  - Kan ook verder gaan door te focussen op:
    - Emotie.
    - Dringendheid.
    - Intentie.

##### 2.1.1.1 Graded Sentiment Analysis

- Geeft verschillende levels van positiviteit/negatieviteit aan:
  - Zeer positief.
  - Positief.
  - Neutraal.
  - Negatief.
  - Zeer negatief.
- Kan vaak geïnterpreteerd worden als 5-sterren rating systeem.

##### 2.1.1.2 Emotion Detection

- Geeft de emotie achter te txt terug.
- Gebruiken vaan lexicons(woord lijsten met geconeecteerde emotie) of zeer complexe machine learning algoritmes.
- Nadeel aan lexicons = dat vershillende mensen verschillende emoties aan bepaalde woorden zullen hangen.

##### 2.1.1.3 Aspect-based Sentiment Analysis

- Geeft weer welk specifiek gedeelte in positiev/negatief besproken wordt.

##### 2.1.1.4 Multilingual sentiment analysis

- = moeilijk <= vraagt veel preprocessing & resources.
- Kunnen ook eerst taal detecteren & dan pipen naar SA in juiste taal.

#### 2.2    Waarom is Sentiment Analyse Belangrijk?

- Voordelen:
  - Kunnen grootte # data snel sorteren op sentiment.
  - Kunnen SA toepassen in RT => actie kan onmiddelijk genomen worden.
  - Krijgen consisten antwoord van SA i.v.m. als mensen dit zouden doen(negatief voor 1 persoon $\neq$ negattief voor andere persoon).

#### 2.3    Hoe werkt SA?

- = opinion mining.
- Werkt a.d.h.v. *Natural Language Processing(NLP)* & *Machine Learning algorithmes(MLA's)* om automatisch de emotionele toon achter txt te bepalen.

##### 2.3.1 Rule-Based

- Regels houden NLP techinieken in zoals:
  - Stemming.
  - Tokenization.
  - Part-of-speech tagging.
  - Parsing.
  - Lexicon.
- = naïve .
  - <= houden geen rekening met gecominbeerde woorden.
- Kunnen meer geavanceerde technieken gebruiken.
  - Nieuwe regels kunnen voorgaande resultaten impacteren.
  - Hele systeem kan zeer complex worden.
- Moeten constant worden ge-finetuned & onderhouden => regelmatige investeringen = nodig.

##### 2.3.2 Automatisch

- Verwachten geen manuele regels, maar op ML technieken.
- = vaak gemodelleerd als klassiek classificatie probleem.

###### 2.3.2.1  Training & Prediction Process

- In traininig process leert model *input* aan correcte *output tag* te binden.
- *Feauture extractor transfers* de txt *input* naar *feauture vector*.
- Paren van *feautre vectoren* & *tags* worden in MLA gegeven om model te generen.
- Model geeft voorspelde *tags*.

###### 2.3.2.2  Classification agloritmes

- Naïve Bayes = familie van probalistische algoritmes, die het theorema van Bayes gebruiken voor categorie van txt te voorspellen.
- Lineaire Regressie gebruikt statistiek om waarde Y te voorspellen voor set van features X.
- Support Vector Machines(SVM) = $\neg$probalistisch model, die representaties van txt vb gebruikt als punten in een multidimensionele ruimte.
- Deep Learning(DL) = diverse set van algoritmes, die proberen het menselijke brein na te doen door een artificieël Neuraal Netwerk te gebruiken.s

##### 2.3.3 Hybrid manier

- = mogelijk gewenste elementen van regels-gebaseerd en automatische systemen te kiezen en te mengen.
- Voordeel = dat resultaten vaak accurater =.

##### 2.3.4 SA Challenges

- = 1 v/d. moeilijkste taken in NLP <= mensen kunnen het zelf amper.

###### 2.3.4.1  Subjectiviteit & Toon

- = 2 soorten txt'en:
  - Objectief: $\neg$ bevatten expliciete sentimenten.
  - Surjectief: bevatten expliciete sentimenten.
- $\neg$ alle predicaten(adj, ww, zelf.nmw) moeten worden behandeld met zelfde level van respect als het aankomt op sentiment.

###### 2.3.4.2  Context & Polariteit

- Machines hebben nood aan het expliciet zeggen v/d. context.
- Context kan polariteit veranderen.
- = nood aan veel preprocessing om  [deel v/d.] context duidelijk te maken.

###### 2.3.4.3  Ironie & Sarcasme

- In ironie/sarcasme geven mensen negatief gevoel weer door positieve woorden te gebruiken.
- Machines hebben het zeer moeilijk hiermee.

###### 2.3.4.4  Vergelijkingen

- Context = cruciaal in achterhalen van sentiment achter vgl <= iets dat positief = in 1 context kan zeer negatief = in andere.

###### 2.3.4.5  Emojis

- = 2 soorten emojis:
  - Westerse = geëncodeerd als 2 karakters.
  - Oosterse = langere combinaties van karakters met een verticale aard.
- Veel preprocessing = nodig

## 3    Packages

### 3.1 NLTK(Natural Language Toolkit)

- Veel gebruikt als educationele & onderzoekstool.
- Gemakkelijk te gebruiken.
- Kunnen:
  - Tokenizatie.
  - Part of Speech Tagging(POS).
  - Named Entity Recognition(NER).
  - Classificatie.
  - Sentiment Analyse(SA).
  - Packages voor chatbots.
- UC's:
  - Aanbevelingssysteem.
  - SA.
  - Bouwen van chatbots.
- Website: [NLTK](https://www.nltk.org/).

| Pro                       | Con                             |
| ------------------------- | ------------------------------- |
| Meest gekende NLP library | Moeilijk te leren & gebruiken   |
| Ondersteunt vele talen    | Context v/h. woord = genegeerd  |
|                           | Traag                           |
|                           | Geen Neuraal Netwerk Model(NNM) |

### 3.2 spaCy

- = os NLP Python library.
- ontworpen voor snel & productie-klaar te =.
- feautures:
  - Tokenizatie.
  - POS.
  - NER.
  - Clasificatie.
  - SA.
  - Dependecy parsing(DP).
  - Woord vectoren.
- UC's:
  - Autocomplete & autocorrect.
  - Analyseren van reviews.
  - Sammenvattingen maken.
- Website: [spaCy](https://spacy.io/)

| Pro                       | Con             |
| ------------------------- | --------------- |
| Snel                      | Minder flexibel |
| Snel te leren & gebruiken |                 |
| Gebruikt NN voor training |                 |

### 3.3 Gensim

- = NLP Python Framework gebruikt in:
  - Toppic modeling.
  - Gelijkheid detectie.
- $\neq$ general-purpose NLP library.
- Features:
  - Latent semantic analysis.
  - Non-negative matrix factorisatie.
  - TF-IDF.
- UC's:
  - Converteren van documenten naar vectoren.
  - Vinden van text gelijkheden.
  - Tekst samenvatten.
- Website: [Genism](https://pypi.org/project/gensim/)

| Pro                       | Cons                                      |
| ------------------------- | ----------------------------------------- |
| Intuitieve interface      | Ontworpen voor unsupervised txt modellen  |
| Schaalbaar                | Moet gebruikt worden met andere libraries |
| Geïmplementeert algoritme |                                           |

### 3.4 Pattern

- NLP Python Framework(NLP PF) met makkelijke syntax.
- Krachtig voor zowel wetenschappelijk als $\neg$ wetenschappelijk taken.
- Populair bij studenten.
- Features:
  - Tokenizatie.
  - POS.
  - NER.
  - Parsing.
  - SA.
- UC's:
  - Spelling correctie.
  - Search Engine(SE) optimalisatie.
  - SA.
- Website: [Pattern](https://github.com/clips/pattern)

| Pro                            | Con                                             |
| ------------------------------ | ----------------------------------------------- |
| Data Mining                    | $\neg$ geöptimaliseerd voor specifieke NLP taak |
| Netwerk analyse & visualisatie |                                                 |

### 3.5 TextBlob

- Features:
  - POS.
  - Zelf. standignaamwoord extractie.
  - SA.
  - Classificatie.
  - Taal transistie.
  - Parsing.
  - Wordnet integratie.
- UC's:
  - SA.
  - Spelling correctie.
  - Translatie & Taal detectie.
- Website: [TextBlob](https://textblob.readthedocs.io/en/dev/)

| Pro                                 | Con                               |
| ----------------------------------- | --------------------------------- |
| Gemakkelijk te gebruiken            | Traag                             |
| Intuitieve interface voor NLTK      | Geen NNM                          |
| Voorziet taal translatie & detectie | Geen geïntegreerde woord vectoren |

### 3.6 Rake_NLTK

- Key word extractor o.b.v. [NLTK](#31-nltknatural-language-toolkit).
- Ondersteund alle talen, die NLTK ondersteund.
- Lijk beste oplossing.