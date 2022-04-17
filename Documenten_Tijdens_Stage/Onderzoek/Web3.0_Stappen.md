# Verdere stappen op Email NFT

Eerst is er een werkend smartcontract geweest, die het mogelijk maakt om een email-adres in te geven en dit in de NFT te steken bij mint.
Nu er een werkende smart contract is aangemaakt om een email adres in een NFT te steken zal er ook langs de Business zijde te kijken naar wat de mogelijkheden zijn.

Voor gebruikers met een EmailToken moet het mogelijk zijn zichzelf te registreren met behulp van deze NFT. Dit houdt concreet in dat de de gebruiker zich zal
connecteren met MetaMask en op deze manier zal de balans van EMTK worden opgevraagd. Door de functionaliteit van het smartcontract zal er kunnen worden weergegeven
welke EMTK de gebruiker bezit. Het emailadres wordt uitgelezen uit de NFT & dit wordt bijgehouden met het het address van de gebruiker. Bij registratie wordt er een
event uitgestuurd voor ook services off-chain op de hoogte te brengen van de verandering.

Voor een gebruiker moet het mogelijk zijn om aan te geven dat hij op de mailingslist van het bedrijf zou willen staan. Waneer dit voorkomt zal binnen het smartcontract
een functie worden aangeroepen, die de gebruiker op een mapping zet samen naar `#t`/address. Hierna zal de functie een event emitten, die off-chain services verwittigd.

Als een gebruiker in de mailingslijst staat en effectief de mail gelezen heeft zal dit een functie aanroepen binnen het smartcontract, die nagaat of de gebruiker
effectie mails wilt ontvangen. Hierna zal een voorafbepaald bedrag worden overgeschreven aan het address van de gebruiker. Indien de gebruiker had aangegeven dat deze
geen mails wou ontvangen zal een bedrag worden gevorderd van het bedrijf en een compensatie worden doorgegeven aan de gebruiker.

Als een gebruiker niet langer wenst op de mailingslist te staan zal dit opnieuw worden doorgegeven aan een functie van het smartcontract, welke het de mapping relevant
update. Hierna zal een event worden uitgestuurd om off-chain services up te daten.