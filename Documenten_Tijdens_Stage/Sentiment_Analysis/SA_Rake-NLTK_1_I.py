import  nltk
from rake_nltk import Rake

def download ():
    l = ['stopwords']

    for i in l:
        nltk.download(i)

def print_list(list):
    for i in list:
        print(f"{i}")

download()

r = Rake()


text = '''Er is in de laatste jaren veel over Amerika en de roodhuiden
geschreven. Tal van schrijvers, onder wie enkele met onbetwistbaar
talent, hebben zich tot taak gesteld, ons in de tot nog toe voor onze
beschaving ontoegankelijke, door wilde volksstammen bewoonde prairiën
en savannen van ’t verre westen rond te leiden. Slechts weinigen hebben
zich echter van hun wegwijzerschap naar eisch gekweten. Den meesten
ontbrak het aan eene grondige, uit eigen ervaring opgedane kennis van
de landen en volksstammen, welker aard en zeden zij ons schilderen
wilden.

De Franschman Gustave Aimard is hierin gelukkiger dan velen zijner
voorgangers geweest. De beschaafde wereld voor jaren vaarwel zeggende,
heeft hij, als aangenomen zoon van een hunner machtigste stammen, onder
en met de Indianen op de gewijde grasvlakten hun zwervend leven
gedeeld, bij de vredespijp aan hunne rust en hunne jachten, na ’t
opgraven der strijdbijl met buks en tomahawk, aan hunne ondernemingen
en tochten zelf deelgenomen.

Een zoodanig leven—de bestendige worsteling met moeiten en vaak
schijnbaar onoverkomelijke bezwaren—heeft een aantrekkelijkheid,
waarvan alleen hij, die het bij ondervinding leerde kennen, zich een
eenigszins helder begrip kan vormen. De mensch staat daar in de
wildernis alleen en komt er als zelfstandig wezen tot bewustheid van
zijne volle kracht. Met God alleen boven zich, oog en oor bestendig op
de wacht, den vinger aan zijn geweertrekker; omringd door gevaren
zonder tal, bedreigd door Indianen en wilde dieren, die achter bosch en
struik, in donkere kloven of in hooge boomtoppen loeren, om zich op hem
te werpen en hem tot hun prooi te maken, gevoelt hij zich in waarheid
eerst heer der schepping, welke hij met al de macht van zijn wil, zijn
verstand, overleg en onverschrokkenheid beheerscht.

Langer dan vijftien jaar hield Aimard dat hier vluchtig aangeduide,
vaak koortsig gejaagde leven vol. Onverschrokken jager, ging hij met de
Sioux en Zwartvoeten in de verst westelijke prairiën op bisons uit. In
’t golvend zand van de onbegrensde Del Norte verdwaald, zwerft hij daar
langer dan eene maand rond, aan de martelingen van honger, dorst en
koorts prijsgegeven. Tot tweemaal toe werd hij door de Apachen aan den
folterpaal gebonden. Twaalf maanden slaaf bij de Patagoniers aan de
Straat van Magellaan, had hij daar gruwelijke kwellingen en tergingen
te verduren en ontsnapte slechts door een wonder aan hunne handen.
Moederziel alleen trok hij de pampas van Buenos-Ayres tot San-Luïs de
Mendoza door en had op dien zwerftocht met panters en jaguars, met
roodhuiden en gaucho’s te kampen. Een dollen inval gehoor gevende,
wilde hij de geheimnissen van Brazilie’s ongerepte wouden doorgronden
en liet zich door geen wilde horden afschrikken, om die in hunne volle
breedte te doorkruisen. Beurtelings squatter, bevervanger,
partijganger, goudzoeker en bergwerker leerde hij Amerika, van de
hoogste Cordillera’s tot aan de stranden van den Oceaan kennen—een kind
van den dag, gelukkig in ’t heden, zonder zorg voor de toekomst,
wakkere voorpost van de beschaving, die in ’t far west van jaar tot
jaar meer veroveringen maakt.

’t Zijn derhalve niet zoo zeer romans, die Aimard na zijne terugkomst
in Frankrijk schreef, als wel gedenkschriften en levensberichten.
Evenals Gabriël Ferry, zijn landsman, als Gerstäcker en Armand
(Strubberg), de Duitschers, vertelt hij van zijn eigen leven, van zijn
eigen ontmoetingen en ervaringen in het vreemde land. De door hem
beschreven zeden en gebruiken waren eens hemzelf eigen, met de door hem
geteekende Indianen heeft hij jaren lang geleefd en geleden, gejaagd en
gevischt, feestgevierd en gevast, in den wigwam of op ’t krijgspad
gelegen; wat hij geeft zijn in meer dan één opzicht photographieën.——

De ondergeteekende vertrouwt dan ook dat deze „Pelsjagers van de
Arkansas” en de verder in deze serie aangekondigde verhalen van Aimard
bij ’t neêrlandsch lezend publiek naast Gerstäcker, Ferry en Armand nog
wel een open plaatsje zullen vinden.
'''

r.extract_keywords_from_text(text)

list = r.get_ranked_phrases_with_scores()[0:10]

print_list(list)