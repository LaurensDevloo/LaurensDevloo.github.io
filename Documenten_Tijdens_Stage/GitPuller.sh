#!/bin/bash

# Gaan naar juiste foler.
path=~/web3wallet
simpleStore=$path/SimpleStore
simpleStoreContract=$path/SimpleStoreWithContract
simpleStoreToken=$path/SimpleStoreWithTokenContract
nft=$path/NFT-email

cd $path

# Git wordt gefetched
git fetch
# De status van de remote repository wordt opgehaald en gegrept om te kijken of de local up to date is of niet.
l=$(git status | egrep ".*up to date.*")

# Indien de waarde van l leeg is, wilt dit zeggen dat er nieuwe data op de remote repository staat en dat deze moet worden gepulled.
if [ -z "$l" ]; then
	# Stoppen van alle processen zodanig dat er geen verwisseling kan zijn.
	pm2 stop all

	# Nieuwe data wordt gepulled van BitBucket. Fouten worden naar error bestand weggeschreven.
	echo $(date) >> ~/errors.txt
	git pull 2> ~/errors.txt

	# Datum wordt wegeschreven.
 	echo  $(date) " | Script executie is begonnen" >> ~/Output/good.txt

 	# Verijwderen van node_modelus en build zodanig dat geen verwaring kan ontstaan.
	rm -fr $simpleStore/build/ $simpleStoreContract/build/  $simpleStoreToken/build/ $nft/build/ 2> ~/errors.txt


	# Rebuilden van SimpleStore
	cd $simpleStore
 
	# Herinstallatie node_modules
	# npm install
	# Heraanmaak build/
	npm run build 2> ~/errors.txt

	#Rebuildinen van SimpleStoreWithContract
	cd $simpleStoreContract

	npm run build 2> ~/errors.txt

	#Rebuilden van SimpleStoreWithTokenContract
	cd $simpleStoreToken

	npm run build 2> ~/errors.txt


	#Rebuilden van NFT-email
	cd $nft

	npm run build 2> ~/errors.txt

	# Herstarten processen.
	pm2 restart all

	echo $(date) " | Pull volledig gedaan | services herbuild " >> ~/Output/good.txt
else
	echo "Geen pull van de remote repository te doen"
	echo $(date) " | Geen pull nodig <= local and remote repository zijn gelijk" >> ~/Output/good.txt
fi
