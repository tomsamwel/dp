# Proxy Design Pattern

## Definitie

Proxy is a structural design pattern that lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.

## UML

![ProxyClassDiagram](/uploads/ba3770c472eac17e0d1dce92ce3c38b9/ProxyClassDiagram.png)

## Casus 

FinTechCo, een opkomend financieel bedrijf, staat voor een uitbreiding van haar dienstverlening. Momenteel ligt de focus op betaalrekeningen. Het plan omvat de lancering van twee nieuwe rekeningtypen: de "BeleggenRekening" voor investeringsfaciliteiten en de "Spaarrekening" voor spaarmogelijkheden. Een uitdaging hierbij is het effectief implementeren van autorisatieprocessen in alle klassen

## Huidige situatie

![BaseSituation](/uploads/e59f9fee7a62136afb965514be6b6bb3/BaseSituation.png)

In de huidige situatie gebeurt autorisatie binnen "BankAccount".

## De "slechte" oplossing

![WrongSolution](/uploads/4a5809dfacc967e6049f1e3c87e94a4c/WrongSolution.png)

In deze oplossing moet je binnen elke klasse autorisatie implementeren wat niet uitbreidbaar is.

## De goede oplossing

![BankAccount](/uploads/18e0490ade95591ce91b3838df732b43/BankAccount.png)

Hier implementeer autorisatie alleen maar in de Proxy.

## Sequence diagram

![BankAccount1](/uploads/5057347cf0e80043f2562411e918ec00/BankAccount1.png)

